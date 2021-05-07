using System;
using System.Globalization;
using Calc_Douglas_Final.Exceptions;

namespace Calc_Douglas_Final
{
    class Calculadora
    {
        public static double Calcular(string expressao)
        {

            string[] valores = expressao.Split(' ');

            double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            char sinal = char.Parse(valores[1]);
            double n2 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            double resultado = 0;

            switch (sinal)
            {
                case '+':
                    resultado = Soma(n1, n2);
                    break;
                case '-':
                    resultado = Sub(n1, n2);
                    break;
                case '*':
                    resultado = Mult(n1, n2);
                    break;
                case '/':
                    resultado = Divi(n1, n2);
                    break;
            }

            return resultado;

        }

        public static double Soma(double a, double b)
        {
            return a + b;
        }

        public static double Sub(double a, double b)
        {
            return a - b;
        }
        public static double Mult(double a, double b)
        {
            return a * b;
        }
        public static double Divi(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Não é possível realizar a divisão por zero");
            }
            return a / b;
        }
    }
}
