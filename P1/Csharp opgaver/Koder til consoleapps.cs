using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Opgave 0.1
            Console.WriteLine("Hello World!");
            Console.ReadKey(); */
            /*Opgave 0.1.0
            Console.WriteLine(Console.ReadLine());
            Console.ReadKey(); */
            /*Opgave 0.1.1
            int tal = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(tal + 2);
            Console.ReadKey(); */
            /*Opgave 1.0.0
            double tal1, tal2;
            Console.WriteLine("Indtast første tal");
            tal1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Indtast andet tal");
            tal2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Summen af de 2 tal er {0}", tal1 + tal2);
            Console.ReadKey(); */
            /*Opgave 1.0.1
            double tal1, tal2, resultat = 0;
            string operatorer;
            Console.WriteLine("Indtast første tal");
            tal1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Vil du + eller -?");
            operatorer = Console.ReadLine();
            Console.WriteLine("Indtast andet tal");
            tal2 = Convert.ToInt16(Console.ReadLine());
            if (operatorer == "+")
            {
                resultat = tal1 + tal2;
            }
            else if (operatorer == "-")
            {
                resultat = tal1 - tal2;
            }
            Console.WriteLine("Summen er {0}", resultat);
            Console.ReadKey(); */
            /*Opgave 1.1
            double tal1, tal2, resultat = 0;
            string operatorer;
            Console.WriteLine("Indtast første tal");
            tal1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Vil du +,-,/eller*?");
            operatorer = Console.ReadLine();
            Console.WriteLine("Indtast andet tal");
            tal2 = Convert.ToInt16(Console.ReadLine());
            if (operatorer == "+")
            {
                resultat = tal1 + tal2;
            }
            else if (operatorer == "-")
            {
                resultat = tal1 - tal2;
            }
            else if (operatorer == "/")
            {
                if ((tal1 != 0) || (tal2 != 0))
                {
                    resultat = tal1 / tal2;
                }
                else if ((tal1 == 0) || (tal2 == 0))
                {
                    Console.Clear();
                    Console.WriteLine("Der er sket en fejl");
                    Environment.Exit(2000);
                }
            }
            else if (operatorer == "*")
            {
                resultat = tal1 * tal2;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Der er sket en fejl");
                Environment.Exit(2000);
            }
            Console.WriteLine("Summen er {0}", resultat);
            Console.ReadKey(); */



        }
    }
}