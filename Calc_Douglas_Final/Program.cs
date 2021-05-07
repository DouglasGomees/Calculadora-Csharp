using System;
using System.Globalization;

namespace Calc_Douglas_Final
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("-- Calculadora Douglas Final -- ");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Insira seus dados no seguinte formato: ");
            Console.WriteLine("    número     operador     número     ");
            Console.WriteLine();
            Console.WriteLine("Se quiser parar a execução digite SAIR");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");

            bool sair = false;


            while (!sair)
            {
                try
                {
                    string expressao = Console.ReadLine();

                    if (expressao == "SAIR")
                    {
                        sair = true;
                    }
                    else
                    {
                        double resultado = Calculadora.Calcular(expressao);
                        Console.WriteLine(resultado.ToString("F3", CultureInfo.InvariantCulture));
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Entrada invalida, por favor insira uma entrada válida");
                }

            }
            Console.WriteLine("Calculadora será desligada");
        }
    }
}
