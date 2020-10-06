using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
           //gabriela.profissao = "Dev C#";
          //gabriela.cpf = "123.456.789-12";

            ContaCorrente conta = new ContaCorrente();

            // conta.titular = gabriela;
            //conta.titular = new Cliente();
            //conta.titular.nome = "Gabriela Costa";
            //conta.titular.cpf = "123.456.789-12";
            //conta.titular.profissao = "Dev C#";

            conta.saldo = 500;
            conta.agencia = 867;
            conta.numero = 345678;

            if (conta.titular == null)
            {
                Console.WriteLine("A referência é null");
            }

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular);
            //Console.WriteLine(conta.titular.nome);
            //Console.WriteLine(conta.titular.cpf);
            //Console.WriteLine(conta.titular.profissao);



            Console.ReadLine();

        }
    }
}
