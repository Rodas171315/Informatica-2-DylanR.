using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        int[][] tablero = new Tablero(2);

        int[][] tablero = new int [][] {
            [
                [0,0,0,0,0],
                [0,0,0,0,0],
                [0,0,0,0,0],
                [0,0,0,0,0],
                [0,0,0,0,0]
            ]
        };

        int[] barco = new Barco(3,2,1,1);

    }

    public class Barco: IBarco
    {
        public int Longitud{get;}

        public int Y{get;}

        public int X{get;}

        public int Orientacion{get;}

        public bool Atacar(int valor)
        {

        }

        public bool EstaHundido()
        {

        }

    }

    public class Tablero: ITablero
    {
        public int Capacidad{get;}
        
        public ColocarBarco(IBarco barco)
        {
            this.barco = barco;
        }

        public bool ColocarBarco(IBarco barco)
        {
            // orientacion horizontal = 1
            // orientacion vertical = 2

            if(barco.Orientacion == 1){
                for(i=barco.X; i<=barco.Longitud; i++)
                {
                    if(tablero[barco.Y][barco.X]==0){
                        tablero[barco.Y][i]=1;
                    }else{
                        return false;
                    }
                }
            }else{
                for(i=barco.Y; i<=barco.Longitud; i++)
                {
                    if(tablero[barco.Y][barco.X]==0){
                        tablero[i][barco.X]=1;
                    }else{
                        return false;
                    }                        
                }
            }

        }        

        public bool Atacar(int x, int y)
        {
            if(tablero[y][x] == 1)
            {
                tablero[y][x] = 0;
                return true;
            }else{
                return false;
            }

        }

        public bool EstaConcluido()
        {

        }

    }

}
