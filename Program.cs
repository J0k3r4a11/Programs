using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen beim Taschenrechner_Light");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Welche Art der Berechnung möchten Sie durchführen?");
            Console.WriteLine("Bitte eingeben:");
            Console.WriteLine();
            Console.WriteLine("1 = Addition");
            Console.WriteLine("2 = Subtration");
            Console.WriteLine("3 = Multiplikation");
            Console.WriteLine("4 = Division");
            Console.WriteLine();
            Console.WriteLine("Oder um das Programm zu beenden");
            Console.WriteLine("5 = Ende");
            Console.WriteLine();
            Console.WriteLine("Bitte wählen Sie aus!");

           
            int zahl1;
            int zahl2;
            int ergebnis;

            do
            {
                string eingabe = Console.ReadLine();
                if (eingabe == "1")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Bitte geben Sie die erste Zahl ein");
                    zahl1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Bitte geben Sie die zweite Zahl ein");
                    zahl2 = Convert.ToInt32(Console.ReadLine());
                    ergebnis = zahl1 + zahl2;
                    Console.WriteLine("Das Ergebnis ist: {0}", ergebnis);
                    Console.WriteLine();
                    Console.WriteLine("Wählen Sie eine Art der Berechnung!");
                    Console.WriteLine("1 = Addition");
                    Console.WriteLine("2 = Subtration");
                    Console.WriteLine("3 = Multiplikation");
                    Console.WriteLine("4 = Division");
                    Console.WriteLine();
                    Console.WriteLine("Oder um das Programm zu beenden");
                    Console.WriteLine("5 = Ende");
                }

                else if (eingabe == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bitte geben Sie die erste Zahl ein");
                    zahl1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Bitte geben Sie die zweite Zahl ein");
                    zahl2 = Convert.ToInt32(Console.ReadLine());
                    ergebnis = zahl1 - zahl2;
                    Console.WriteLine("Das Ergebnis ist: {0}", ergebnis);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("Wählen Sie eine Art der Berechnung!");
                    Console.WriteLine("1 = Addition");
                    Console.WriteLine("2 = Subtration");
                    Console.WriteLine("3 = Multiplikation");
                    Console.WriteLine("4 = Division");
                    Console.WriteLine();
                    Console.WriteLine("Oder um das Programm zu beenden");
                    Console.WriteLine("5 = Ende");
                }

                else if (eingabe == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Bitte geben Sie die erste Zahl ein");
                    zahl1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Bitte geben Sie die zweite Zahl ein");
                    zahl2 = Convert.ToInt32(Console.ReadLine());
                    ergebnis = zahl1 * zahl2;
                    Console.WriteLine("Das Ergebnis ist: {0}", ergebnis);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("Wählen Sie eine Art der Berechnung!");
                    Console.WriteLine("1 = Addition");
                    Console.WriteLine("2 = Subtration");
                    Console.WriteLine("3 = Multiplikation");
                    Console.WriteLine("4 = Division");
                    Console.WriteLine();
                    Console.WriteLine("Oder um das Programm zu beenden");
                    Console.WriteLine("5 = Ende");
                }

                else if (eingabe == "4")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Bitte geben Sie die erste Zahl ein");
                    zahl1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Bitte geben Sie die zweite Zahl ein");
                    zahl2 = Convert.ToInt32(Console.ReadLine());
                    ergebnis = zahl1 / zahl2;
                    Console.WriteLine("Das Ergebnis ist: {0}", ergebnis);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("Wählen Sie eine Art der Berechnung!");
                    Console.WriteLine("1 = Addition");
                    Console.WriteLine("2 = Subtration");
                    Console.WriteLine("3 = Multiplikation");
                    Console.WriteLine("4 = Division");
                    Console.WriteLine();
                    Console.WriteLine("Oder um das Programm zu beenden");
                    Console.WriteLine("5 = Ende");
                }

                else if (eingabe == "")
                {
                    Console.WriteLine("Bitte treffen Sie eine Wahl");
                    Console.WriteLine("1 = Addition");
                    Console.WriteLine("2 = Subtration");
                    Console.WriteLine("3 = Multiplikation");
                    Console.WriteLine("4 = Division");
                    Console.WriteLine();
                    Console.WriteLine("Oder um das Programm zu beenden");
                    Console.WriteLine("5 = Ende");
                }

                else if (eingabe == "5")
                {
                    break;
                }

                continue;
            }
            while (true);
            Console.WriteLine("Das Programm ist beendet");
            Console.ReadKey();



            



                

              


        }    
    }
}
