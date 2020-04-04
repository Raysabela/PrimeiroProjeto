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

            Console.WriteLine("Digite o primeiro numéro");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numéro");
            numero2 = int.Parse(Console.ReadLine());

            resultado = SomaDoisNumerosInteiros(numero1, numero2);
            Console.WriteLine("O resultado é: " + resultado);
            Console.ReadKey();


        }

        public static int SomaDoisNumerosInteiros(int a, int b)
        {
            return a + b;
        }


        public static string RetornaNomeDePessoa()
        {
            return "Rafaela";
        }
    }
}
