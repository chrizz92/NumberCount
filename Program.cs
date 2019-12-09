using System;

namespace NumberCount.ConsoleApplication
{
    class NumberCount
    {
        static void Main(string[] args)
        {
            int[] counter;
            string running;
            int number, count = 0;

            do
            {
                running = "";
                counter = new int[10];
                number = -1;
                count = 0;
                Console.WriteLine("Zahlen 0-9 zählen");
                Console.WriteLine("=================");

                do
                {
                    count++;
                    Console.Write("Bitte {0}. Zahl eingeben(-1 für Auswertung): ",count);
                    number = Convert.ToInt32(Console.ReadLine());

                    switch (number)
                    {
                        case -1:
                            break;
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            counter[number]++;
                            break;
                        default:
                            Console.WriteLine("Ungültige Eingabe!");
                            break;
                    }

                } while (number!=-1);

                Console.WriteLine("Auswertung");

                for(int i = 0;i<counter.Length;i++)
                {
                    Console.WriteLine("Zahl {0} wurde {1}x eingegeben!", i, counter[i]);
                }

                Console.Write("Nochmal(y/n)?: ");
                running = Console.ReadLine();

            } while(running=="y");
        }
    }
}
