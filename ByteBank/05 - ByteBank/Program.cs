using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.profissão = "Desenvolvedora C#";
            //gabriela.CPF = "187.187.187-00";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabriela;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 102679;

            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.CPF = "187.187.187-00";
            conta.titular.profissão = "Desenvolvedora C#";


            //Console.WriteLine(gabriela.nome);
            Console.WriteLine("Titular: " + conta.titular.nome);
            Console.WriteLine("CPF: " + conta.titular.CPF);
            Console.WriteLine("Profissão: "+ conta.titular.profissão);

            Console.ReadLine();
        }
    }
}
