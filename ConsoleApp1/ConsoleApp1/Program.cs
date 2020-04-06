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
            int numero1subtrair;
            int numero2subtrair;
            int resultadoSubtrair;
            double numero1multiplica;
            double numero2multiplica;
            double resultadoMultiplicação;

            //Console.WriteLine("Digite o primeiro número para somar");
            //numero1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo número para somar");
            //numero2 = int.Parse(Console.ReadLine());
            //resultado = SomaDoisNumerosInteiros(numero1, numero2);
            //Console.WriteLine("O resultado da soma é: " + resultado);

            //Console.Write("Digite o primeiro número para dividir ");
            //numero1divide = double.Parse(Console.ReadLine());
            //Console.Write("Digite o segundo número para dividir ");
            //numero2divide = double.Parse(Console.ReadLine());
            //resultadoDivide = DivideDoisNumerosFracionados(numero1divide, numero2divide);
            //Console.Write("O resultado da divisão é: " + resultadoDivide);
            //Console.ReadKey();

            //Console.Write("Digite o primeiro número para subtrair ");
            //numero1subtrair = int.Parse(Console.ReadLine());
            //Console.Write("Digite o segundo número para subtrair ");
            //numero2subtrair = int.Parse(Console.ReadLine());
            //resultadoSubtrair = SubtrairDoisNumerosInteiros(numero1subtrair, numero2subtrair);
            //Console.Write("O resultado da subtração é: " + resultadoSubtrair);
            //Console.ReadKey();

            Console.Write("Digite o primeiro número para multiplicar ");
            numero1multiplica = double.Parse(Console.ReadLine());
            Console.Write("Digitar o segundo número para multiplicar ");
            numero2multiplica = double.Parse(Console.ReadLine());
            resultadoMultiplicação = MultiplicarDoisNumerosFracionados(numero1multiplica, numero2multiplica);
            Console.Write("O resultado da multiplicação é: " + resultadoMultiplicação);
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
        public static int SubtrairDoisNumerosInteiros(int num1sub, int num2sub)
        {
            return num1sub - num2sub;

        }

        public static double MultiplicarDoisNumerosFracionados(double num1mult, double num2mult)
        {
            return num1mult * num2mult;

        }
        public static string RetornaNomeDePessoa()
        {
            return "Rafaela";
        }
    }
}
