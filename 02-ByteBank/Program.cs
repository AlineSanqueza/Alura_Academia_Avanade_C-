using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.saldo = 200;
            Console.WriteLine(conta.saldo);

            conta.saldo += 100;
            Console.WriteLine(conta.saldo);

            ContaCorrente outraConta = new ContaCorrente();
            outraConta.saldo = 50;
            Console.WriteLine("A primeira conta tem " + conta.saldo);
            Console.WriteLine("A outra conta tem " + outraConta.saldo);


            Console.ReadLine();
        }
    }
}
