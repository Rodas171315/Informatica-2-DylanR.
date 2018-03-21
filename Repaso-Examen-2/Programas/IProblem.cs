using System;

namespace IProblem
{
    public interface IProblem<T>
    {
        T[] Crossover(T[] arreglo1, T[] arreglo2);

        T[] Mutate(T[] arreglo);

        double Score(T[] nombre);
        
        T[] Guess();
    }
}