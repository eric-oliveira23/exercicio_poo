using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            p.peso = 65;
            p.altura = 1.85;
            p.mensagem();

            Console.ReadKey();
        }
    }
}
