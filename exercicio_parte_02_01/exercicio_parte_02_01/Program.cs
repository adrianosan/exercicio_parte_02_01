using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_parte_02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int sucessor = 0;

            Console.Write("Digite o Número: ");
            sucessor = int.Parse(Console.ReadLine());

            sucessor += 1;

            Console.WriteLine("O sucessor do Número Digitado é: {0}", sucessor);
        }
    }
}
