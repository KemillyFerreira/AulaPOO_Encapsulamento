using System;
using Encapsulamento.classes;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();

            m.Parcelas = 12;

            Console.WriteLine(m.Bandeira);
        }
    }
}