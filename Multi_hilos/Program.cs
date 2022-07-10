using System;
using System.Threading;

namespace Multi_hilos
{
    class Program
    {
        public static void metodo1()
        {
            Console.WriteLine("\tMétodo 1 ha empezado\n");

            for (int i = 0; i <= 10; i++) {
                Console.WriteLine("Números del primer método: {0}", i);
                if (i == 5) {
                    Console.WriteLine("\n\tComenzó el proceso difícil en el método 1\n");
                    Thread.Sleep(6000);
                }
            }
            Console.WriteLine("\n\tEl método 1 ha finalizado");
        }

        public static void metodo2()
        {
            Console.WriteLine("\tEl método 2 ha iniciado\n");

            for (int j = 0; j <= 10; j++)
                Console.WriteLine("Números del segundo método: {0}", j);
            Console.WriteLine("\n\tMétodo 2 ha finalizado\n");
        }
        static void Main(string[] args)
        {
            Thread thr1 = new Thread(metodo1);
            Thread thr2 = new Thread(metodo2);

            thr1.Priority = ThreadPriority.Lowest;
            thr2.Priority = ThreadPriority.Highest;

            thr1.Start();
            thr2.Start();

            Console.ReadKey(true);
        }
    }
}
