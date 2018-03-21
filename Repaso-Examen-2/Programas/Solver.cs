using System;

namespace Solver
{
    public class Solver
    {
        public static bool IsSolved<T>(IProblem<T> problema, T[][] guesses, double worse)
        {
            for(int i=0; i < guesses.Length; i++)
            {
                if(problema.Score(guesses[i]) <= worse)
                {
                    return true;
                }
            }
            return false;
        }

        public static T[] Solve<T>(IProblem<T> problema, double worse)
        {
            Random random = new Random();
            T[][] candidatos = new T[5][];

            for(int i=0; i < candidatos.Length; i++)
            {
                candidatos[i] = problema.Guess();
            }

            while(Solver.IsSolved(problema, candidatos, worse))
            {
                
            }
        }
    }
}