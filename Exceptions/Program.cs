using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exceptions
{
    class Program
    {
        public static int ReadInt ()
        {
            int ivstup = 0;
            Console.Write("Zadej první číslo: ");
            string vstup1 = Console.ReadLine();
            try
            {
                ivstup = int.Parse(vstup1);
            }
            catch (FormatException)
            {
                if (vstup1 == "exit")
                    Environment.Exit(0);
                else
                    throw new FormatException("Špatná hodnota formátu");
            }

            return ivstup;
        }
        public static int Divide(int num1, int num2)
        {
            int k = 0;
            try { k = num1 / num2; }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nesmí se dělit nulou");
            }
            return k;
        }

        static void Main(string[] args)
        {
            int cislo1;
            int cislo2;

            do
            {
                cislo1 = ReadInt();
                cislo2 = ReadInt();
                Console.WriteLine(Divide(cislo1, cislo2);
            }
            while (true);

        }

    }
}
