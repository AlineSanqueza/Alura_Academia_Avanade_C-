using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(conta.Agencia);
            //Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(987, 9876543);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente minhaConta = new ContaCorrente(000, 90909090);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
