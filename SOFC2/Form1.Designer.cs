namespace SOFC3
{
    partial class SOFC_knapsack
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SOFC_knapsack));
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxPopulationSize = new TextBox();
            txtBoxMaxGens = new TextBox();
            txtBoxMutationRate = new TextBox();
            label4 = new Label();
            txtBoxCapacity = new TextBox();
            checkBoxElitism = new CheckBox();
            cmbBoxTextFile = new ComboBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(22, 209);
            button1.Name = "button1";
            button1.Size = new Size(299, 29);
            button1.TabIndex = 0;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(327, 8);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(667, 367);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 2;
            label1.Text = "Population Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 48);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 3;
            label2.Text = "Max Generations";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 81);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 4;
            label3.Text = "Mutation Rate";
            // 
            // txtBoxPopulationSize
            // 
            txtBoxPopulationSize.Location = new Point(196, 8);
            txtBoxPopulationSize.Name = "txtBoxPopulationSize";
            txtBoxPopulationSize.Size = new Size(125, 27);
            txtBoxPopulationSize.TabIndex = 5;
            // 
            // txtBoxMaxGens
            // 
            txtBoxMaxGens.Location = new Point(196, 41);
            txtBoxMaxGens.Name = "txtBoxMaxGens";
            txtBoxMaxGens.Size = new Size(125, 27);
            txtBoxMaxGens.TabIndex = 6;
            // 
            // txtBoxMutationRate
            // 
            txtBoxMutationRate.Location = new Point(196, 74);
            txtBoxMutationRate.Name = "txtBoxMutationRate";
            txtBoxMutationRate.Size = new Size(125, 27);
            txtBoxMutationRate.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 114);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 8;
            label4.Text = "Backpack capacity";
            // 
            // txtBoxCapacity
            // 
            txtBoxCapacity.Location = new Point(196, 111);
            txtBoxCapacity.Name = "txtBoxCapacity";
            txtBoxCapacity.Size = new Size(125, 27);
            txtBoxCapacity.TabIndex = 9;
            // 
            // checkBoxElitism
            // 
            checkBoxElitism.AutoSize = true;
            checkBoxElitism.Checked = true;
            checkBoxElitism.CheckState = CheckState.Checked;
            checkBoxElitism.Location = new Point(24, 179);
            checkBoxElitism.Name = "checkBoxElitism";
            checkBoxElitism.Size = new Size(103, 24);
            checkBoxElitism.TabIndex = 10;
            checkBoxElitism.Text = "Use Elitism";
            checkBoxElitism.UseVisualStyleBackColor = true;
            // 
            // cmbBoxTextFile
            // 
            cmbBoxTextFile.FormattingEnabled = true;
            cmbBoxTextFile.Location = new Point(22, 145);
            cmbBoxTextFile.Name = "cmbBoxTextFile";
            cmbBoxTextFile.Size = new Size(299, 28);
            cmbBoxTextFile.TabIndex = 11;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(196, 176);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear Log";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // SOFC_knapsack
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 385);
            Controls.Add(btnClear);
            Controls.Add(cmbBoxTextFile);
            Controls.Add(checkBoxElitism);
            Controls.Add(txtBoxCapacity);
            Controls.Add(label4);
            Controls.Add(txtBoxMutationRate);
            Controls.Add(txtBoxMaxGens);
            Controls.Add(txtBoxPopulationSize);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SOFC_knapsack";
            Text = "SOFC - Knapsack";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxPopulationSize;
        private TextBox txtBoxMaxGens;
        private TextBox txtBoxMutationRate;
        private Label label4;
        private TextBox txtBoxCapacity;
        private CheckBox checkBoxElitism;
        private ComboBox cmbBoxTextFile;
        private Button btnClear;
    }
}