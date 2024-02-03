using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFC3
{
    internal class EvolutionaryAlgorithm
    {
        private int _populationSize;
        private int _maxGenerations;
        private double _mutationRate;
        private Knapsack _knapsack;
        private Random _random;

        public EvolutionaryAlgorithm(int populationSize, int maxGenerations, double mutationRate, Knapsack knapsack)
        {
            _populationSize = populationSize;
            _maxGenerations = maxGenerations;
            _mutationRate = mutationRate;
            _knapsack = knapsack;
            _random = new Random();
        }

        public List<Population> Run(Boolean useElitism)
        {
            Boolean _useElitism = useElitism;
            List<Population> ret = new List<Population>();

            Population population = InitializePopulation(_populationSize);
            EvaluatePopulation(population);

            for (int i = 0; i < _maxGenerations; i++)
            {
                Population newPopulation = new Population(_populationSize);

                if (_useElitism)
                {
                    newPopulation.Individuals[0] = GetBestIndividual(population);
                }

                for (int j = (_useElitism ? 1 : 0); j < _populationSize; j++)
                {
                    Individual parent1 = SelectParent(population);
                    Individual parent2 = SelectParent(population);
                    Individual child = Crossover(parent1, parent2);
                    Mutate(child, _mutationRate);
                    newPopulation.Individuals[j] = child;
                }

                EvaluatePopulation(newPopulation);
                ret.Add(newPopulation);
                population = newPopulation;
            }

            return ret;
        }


        private Population InitializePopulation(int size)
        {
            Population population = new Population(size);

            for (int i = 0; i < size; i++)
            {
                Individual individual = new Individual();
                for (int j = 0; j < _knapsack.Items.Count; j++)
                {
                    bool gene = _random.Next(0, 2) == 1;
                    individual.Genes.Add(gene);
                }
                population.Individuals[i] = individual;
            }

            return population;
        }

        private void EvaluatePopulation(Population population)
        {
            foreach (Individual individual in population.Individuals)
            {
                int weight = 0;
                int value = 0;
                for (int i = 0; i < _knapsack.Items.Count; i++)
                {
                    if (individual.Genes[i])
                    {
                        weight += _knapsack.Items[i].Weight;
                        value += _knapsack.Items[i].Value;
                    }
                }
                if (weight > _knapsack.Capacity)
                {
                    value = 0;
                }
                individual.Fitness = value;
            }
        }

        private Individual SelectParent(Population population)
        {
            List<Individual> tournament = new List<Individual>();
            for (int i = 0; i < 3; i++)
            {
                int index = _random.Next(0, _populationSize);
                tournament.Add(population.Individuals[index]);
            }
            return tournament.OrderByDescending(individual => individual.Fitness).First();
        }

        private Individual Crossover(Individual parent1, Individual parent2)
        {
            Individual child = new Individual();
            for (int i = 0; i < _knapsack.Items.Count; i++)
            {
                bool gene = _random.Next(0, 2) == 1;
                if (gene)
                {
                    child.Genes.Add(parent1.Genes[i]);
                }
                else
                {
                    child.Genes.Add(parent2.Genes[i]);
                }
            }
            return child;
        }

        private void Mutate(Individual individual, double mutationRate)
        {
            for (int i = 0; i < _knapsack.Items.Count; i++)
            {
                if (_random.NextDouble() < mutationRate)
                {
                    individual.Genes[i] = !individual.Genes[i];
                }
            }
        }
        public Individual GetBestIndividual(Population population)
        {
            return population.Individuals.OrderByDescending(individual => individual.Fitness).First();
        }
    }
}
