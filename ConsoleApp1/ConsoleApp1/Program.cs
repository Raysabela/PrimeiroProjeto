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
            bool verdadeiro ou falso;

            bolinha vermelha => breakpoint
            debbugar => passaro código passo a passo - apertando F10 você passa linha a linha

             */


            double numero1 = 0;
            double numero2 = 0;
            double resultado = 0;
            double auxiliar = 0;
            string entradaDoUsuario;
            double opcao = 0;

            Console.WriteLine("Bem vindo(a)!");

            Console.Write("Digite o primeiro número: ");
            entradaDoUsuario = Console.ReadLine();
            numero1 = AtribuiNumeroValido(auxiliar, entradaDoUsuario);

            Console.Write("Digite o segundo número: ");
            entradaDoUsuario = Console.ReadLine();
            numero2 = AtribuiNumeroValido(auxiliar, entradaDoUsuario);

            Console.WriteLine("O que você quer fazer com estes números? :\n 1 - Somar\n 2 - Subtrair\n 3 - Multiplicar\n 4 - Dividir");
            entradaDoUsuario = Console.ReadLine();
            opcao = AtribuiNumeroValido(auxiliar, entradaDoUsuario);


            switch (opcao)
            {
                case 1:
                    resultado = SomaDoisNumerosInteiros(numero1, numero2);
                    break;
                case 2:
                    resultado = SubtrairDoisNumerosInteiros(numero1, numero2);
                    break;
                case 3:
                    resultado = MultiplicarDoisNumerosFracionados(numero1, numero2);
                    break;
                case 4:
                    resultado = DivideDoisNumerosFracionados(numero1, numero2);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }


            Console.WriteLine("O resultado da operação é: " + resultado);
            Console.ReadKey();

        }

        public static double SomaDoisNumerosInteiros(double a, double b)
        {
            return a + b;
        }

        public static double DivideDoisNumerosFracionados(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            return num1 / num2;

        }
        public static double SubtrairDoisNumerosInteiros(double num1sub, double num2sub)
        {
            return num1sub - num2sub;

        }

        public static double MultiplicarDoisNumerosFracionados(double num1mult, double num2mult)
        {
            return num1mult * num2mult;

        }

        public static double AtribuiNumeroValido(double auxiliar, string entradaDoUsuario)

        {
            if (!double.TryParse(entradaDoUsuario, out auxiliar))
            {
                Console.WriteLine("O valor digitado é inválido.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            return auxiliar;

        }


    }
}
