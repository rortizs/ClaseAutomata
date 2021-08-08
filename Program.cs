using System;

namespace Automata
{
    class Program
    {
        //automata finito
        static void Main(string[] args)
        {
            //variable con valor cero
            int nodo = 0;

            //instanciar
            CGrafo miGrafo = new CGrafo(7);

            miGrafo.AdicionarArista(0, 1);
            miGrafo.AdicionarArista(0, 2);
            miGrafo.AdicionarArista(0, 3);
            miGrafo.AdicionarArista(1, 3);
            miGrafo.AdicionarArista(1, 4);
            miGrafo.AdicionarArista(2, 5);
            miGrafo.AdicionarArista(3, 2);
            miGrafo.AdicionarArista(3, 5);
            miGrafo.AdicionarArista(3, 6);
            miGrafo.AdicionarArista(4, 3);
            miGrafo.AdicionarArista(4, 6);
            miGrafo.AdicionarArista(6, 5);

            miGrafo.MuuestraAdyacencia();

            miGrafo.CalcularIndegree();
            miGrafo.MostrarIndegree();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;

            //Ordenamiento

            //recorrido ciclico mientras no sea -1
            do
            {
                nodo = miGrafo.EncuentraI0();

                if (nodo != -1)
                {
                    //imprimo el nodo
                    Console.Write("{0}->", nodo);

                    //graficamos la arista y la restamos
                    miGrafo.DecrementaIndegree(nodo);
                }
            } while (nodo != -1);

            Console.WriteLine();


        }
    }
}
