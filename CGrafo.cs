using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata
{
    class CGrafo
    {
        //variables grlogales
        int[,] mAdyacencia; //matriz
        int[] indegree; //arreglo de aristas
        int nodos; //cantidad de nodos

        //constructor
        public CGrafo(int pNodos)
        {
            //variable
            nodos = pNodos;

            mAdyacencia = new int[nodos, nodos];

            indegree = new int[nodos];

        }

        //funcion para agregar una arista, inicial o final

        public void AdicionarArista(int pNodoInicio, int pNodoFinal)
        {
            mAdyacencia[pNodoInicio, pNodoFinal] = 1;
        }

        //metodo para mostrar la matriz
        public void MuuestraAdyacencia()
        {
            int n = 0;
            int m = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;

            //listar el numero de nodos
            for (n = 0; n < nodos; n++)
            {
                Console.Write("\t{0}", n);
            }

            Console.WriteLine();

            //recorro la matriz 
            for (n = 0; n < nodos; n++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(n);
                for(m = 0; m < nodos; m++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.Write("\t{0}", mAdyacencia[n, m]);
                }

                Console.WriteLine();
            }
        }

        public void CalcularIndegree()
        {
            int n = 0;
            int m = 0;

            for(n = 0; n < nodos; n++)
            {
                for(m = 0; m < nodos; m++)
                {
                    if (mAdyacencia[m, n] == 1)
                        indegree[n]++;
                }
            }
        }

        public void MostrarIndegree()
        {
            int n = 0;

            Console.ForegroundColor = ConsoleColor.White;

            for (n = 0; n < nodos; n++)
                Console.WriteLine("Nodo:  {0}, {1} ", n, indegree[n]);

        }

        public int EncuentraI0()
        {
            bool encontrado = false;
            int n = 0;

            for(n=0; n< nodos; n++)
            {
                if(indegree[n] == 0)
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                return n;
            }
            else
            {
                return -1; //esto indica que no se encontrado nada en el indice 
            }
        }

        //recorrer la matriz
        public void DecrementaIndegree(int pNodo)
        {
            indegree[pNodo] = -1;

            int n = 0;

            for (n = 0; n < nodos; n++)
            {
                if(mAdyacencia[pNodo, n] == 1)
                {
                    indegree[n]--;
                }
            }
        }

    }
}
