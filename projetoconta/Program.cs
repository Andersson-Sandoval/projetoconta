using System;
using System.Globalization;

namespace projetoconta
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;


            Console.Write("Entre com o Número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do(a) Titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial na conta (S/N)? ");
            char resp = char.Parse(Console.ReadLine());

            if ( resp == 's' || resp == 'S' ) {
                Console.Write("Digite o valor de deposito inicial:  ");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
              
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }

            else {
                conta = new ContaBancaria(numero, titular);    }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine( conta );

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para Saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
