using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comentários

            /*       
            int é para número
            string é palavra
            DateTime para data
            double para número fracionado   
             */

            int numero1;
            int numero2;
            int resultado;
            double numero1divide;
            double numero2divide;
            double resultadoDivide;

            //Console.WriteLine("Digite o primeiro número para somar");
            //numero1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo número para somar");
            //numero2 = int.Parse(Console.ReadLine());
            //resultado = SomaDoisNumerosInteiros(numero1, numero2);
            //Console.WriteLine("O resultado da soma é: " + resultado);

            Console.Write("Digite o primeiro número para dividir ");
            numero1divide = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número para dividir ");
            numero2divide = double.Parse(Console.ReadLine());
            resultadoDivide = DivideDoisNumerosFracionados(numero1divide, numero2divide);
            Console.Write("O resultado da divisão é: " + resultadoDivide);
            Console.ReadKey();


        }

        public static int SomaDoisNumerosInteiros(int a, int b)
        {
            return a + b;
        }

        public static double DivideDoisNumerosFracionados(double num1, double num2)
        {
            return num1 / num2;

        }
        public static string RetornaNomeDePessoa()
        {
            return "Rafaela";
        }
    }
}
