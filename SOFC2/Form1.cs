namespace SOFC3
{
    public partial class SOFC_knapsack : Form
    {
        public SOFC_knapsack()
        {
            InitializeComponent();
            txtBoxPopulationSize.Text = "10";
            txtBoxMaxGens.Text = "10";
            txtBoxMutationRate.Text = "0.05";
            txtBoxCapacity.Text = "5";
            LoadTextFilesIntoComboBox(cmbBoxTextFile);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var fileName = cmbBoxTextFile.SelectedItem as string;
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Please select a file name.");
                return;
            }
            List<Item> items = LoadItemsFromFile(fileName);
            int populationSize = Convert.ToInt32(txtBoxPopulationSize.Text);
            int maxGens = Convert.ToInt32(txtBoxMaxGens.Text);
            double mutationRate;
            Double.TryParse(txtBoxMutationRate.Text, out mutationRate);
            if(mutationRate < 0 || mutationRate > 1) {
                MessageBox.Show("Invalid mutation rate");
            }
            int backpackCapacity = Convert.ToInt32(txtBoxCapacity.Text);
            Knapsack knapsack = new Knapsack(backpackCapacity);
            foreach (Item item in items)
            {
                knapsack.Items.Add(item);
            }
            EvolutionaryAlgorithm evolutionaryAlgorithm = new EvolutionaryAlgorithm(populationSize, maxGens, (1-mutationRate), knapsack);
            List<Population> populationList = evolutionaryAlgorithm.Run(checkBoxElitism.Checked);
            for (int i = 0; i < populationList.Count(); i++)
            {
                for (int j = 0; j < populationList[i].Individuals.Count(); j++)
                {
                    textBox1.Text += "\r\n" + populationList[i].Individuals[j].Fitness.ToString() + ": ";
                    for (int k = 0; k < populationList[i].Individuals[j].Genes.Count(); k++)
                    {
                        if (populationList[i].Individuals[j].Genes[k] == true)
                        {
                            textBox1.Text += items[k].Name.ToString() + ", ";
                        }
                    }
                }
                textBox1.Text += "\r\n--------------------";
            }
        }

        private static List<Item> LoadItemsFromFile(string filePath)
        {
            List<Item> itemList = new List<Item>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string id = parts[0];
                int weight = int.Parse(parts[1]);
                int value = int.Parse(parts[2]);
                Item item = new Item(id, weight, value);
                itemList.Add(item);
            }
            return itemList;
        }

        private void LoadTextFilesIntoComboBox(ComboBox cmbBoxTextFile)
        {
            var txtFiles = Directory.GetFiles(Application.StartupPath, "*.txt");
            foreach (var file in txtFiles)
            {
                var fileName = Path.GetFileName(file);
                if (!cmbBoxTextFile.Items.Contains(fileName))
                {
                    cmbBoxTextFile.Items.Add(fileName);
                }
            }
            if (cmbBoxTextFile.Items.Count > 0 && cmbBoxTextFile.SelectedIndex == -1)
            {
                cmbBoxTextFile.SelectedIndex = 0;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}