using System;

namespace AtividadeDiamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numDiamante, quantEspacos, quantX, metade;
            Console.WriteLine("\t\tDIGITE O NÚMERO IMPAR");
            numDiamante = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            
            metade = (numDiamante + 1) / 2;
            quantEspacos = (numDiamante - 1) / 2;
            quantX = 1;

            for (int i = 0; i < metade; i++)
            {
                for (int j = 0; j < quantEspacos; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < quantX; k++)
                {
                    Console.Write("♦");
                }
                Console.WriteLine();

                quantEspacos = quantEspacos - 1;
                quantX = quantX + 2;
            }

            quantEspacos = 0;
            quantX = numDiamante;
            
            for (int i = 0; i < metade; i++)
            {
                quantEspacos = quantEspacos + 1;
                quantX = quantX - 2;

                for (int j = 0; j < quantEspacos; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < quantX; k++)
                {
                    Console.Write("♦");
                }
                Console.WriteLine();                                
            }

            Console.ReadLine();
        }
    }
}
