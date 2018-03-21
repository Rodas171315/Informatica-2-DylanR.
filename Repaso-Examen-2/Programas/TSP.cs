using System;

namespace TSP
{
    public abstract class TSP : IProblem<int>
    {
        private int[][] distancias;

        public TSP(int[][] distancias)
        {
            this.distancias = distancias;
        }

        public abstract int[] Guess();

        public abstract int[] Crossover(int[] x1, int[] x2);

        public abstract int[] Mutate(int[] x);

        public double Score(int[] guess)
        {
            double score = 0;
            
            for(int i = 0; i <= guess.Length; i++)
            {
                score += 1;
            }
        }
    }
}