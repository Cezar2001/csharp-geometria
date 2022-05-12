using System;
namespace csharp_geometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int value1, value2;
                Console.WriteLine("Inserire il valore della base del rettangolo");
                if (!int.TryParse(Console.ReadLine(), out value1))
                {
                    Console.WriteLine("Non hai inserito un numero");
                    Environment.Exit(1);
                }
                Console.WriteLine("Inserire il valore dell'altezza del rettangolo");
                if (!int.TryParse(Console.ReadLine(), out value2))
                {
                    Console.WriteLine("Non hai inserito un numero");
                    Environment.Exit(1);
                }

                Rettangolo Rettangolo = new Rettangolo(value1, value2);
                Console.WriteLine("--RETTANGOLO 1--");
                Console.WriteLine("Il perimetro del rettangolo è di {0}cm", Rettangolo.CalcolaPerimetro());
                Console.WriteLine("L'area del rettangolo è di {0}m²", Rettangolo.CalcolaArea());
            }

            {
                int value1, value2;
                Console.WriteLine("Inserire il valore della base del rettangolo");
                if (!int.TryParse(Console.ReadLine(), out value1))
                {
                    Console.WriteLine("Non hai inserito un numero");
                    Environment.Exit(1);
                }
                Console.WriteLine("Inserire il valore dell'altezza del rettangolo");
                if (!int.TryParse(Console.ReadLine(), out value2))
                {
                    Console.WriteLine("Non hai inserito un numero");
                    Environment.Exit(1);
                }

                Rettangolo Rettangolo = new Rettangolo(value1, value2);
                Console.WriteLine("--RETTANGOLO 2--");
                Console.WriteLine("Il perimetro del rettangolo è di {0}cm", Rettangolo.CalcolaPerimetro());
                Console.WriteLine("L'area del rettangolo è di {0}m²", Rettangolo.CalcolaArea());
            }

            {
                int value1, value2;
                Console.WriteLine("Inserire il valore della base del rettangolo");
                if (!int.TryParse(Console.ReadLine(), out value1))
                {
                    Console.WriteLine("Non hai inserito un numero");
                    Environment.Exit(1);
                }
                Console.WriteLine("Inserire il valore dell'altezza del rettangolo");
                if (!int.TryParse(Console.ReadLine(), out value2))
                {
                    Console.WriteLine("Non hai inserito un numero");
                    Environment.Exit(1);
                }

                Rettangolo Rettangolo = new Rettangolo(value1, value2);
                Console.WriteLine("--RETTANGOLO 3--");
                Console.WriteLine("Il perimetro del rettangolo è di {0}cm", Rettangolo.CalcolaPerimetro());
                Console.WriteLine("L'area del rettangolo è di {0}m²", Rettangolo.CalcolaArea());
            }
        }
    }
}
