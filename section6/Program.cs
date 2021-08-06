using Course;
using System;
using System.Globalization;

namespace section6
{
    class Program
    {
        private static double quantia;

        static void Main(string[] args)


        {
            ContaBancaria conta;

            Console.WriteLine("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o títular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n) ?");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);

            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Qual Operação deseja realizar ( 1 - Depósito /  2 -  Saque  ) ?");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == '1')
            {
                Console.WriteLine();
                Console.WriteLine("Entre um valor para Deposito: ");
                double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposito(quantia);
                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(conta);
            }

            if (resposta == '2')
            {
                Console.WriteLine();
                Console.WriteLine("Entre um valor para Saque: ");
                quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("---------");
                Console.WriteLine("O saque tem uma taxa no valor de R$ 5,00 reais, Deseja continuar (s/n)?");
                char saquezin = char.Parse(Console.ReadLine());
                if (saquezin == 's' || saquezin == 'S')
                {
                    conta.Saque(quantia);
                    Console.WriteLine("Dados da conta atualizados: ");
                    Console.WriteLine(conta);
                }
                if (saquezin == 'n' || saquezin == 'N')
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Obrigado, tenha um ótimo dia");
                    Console.WriteLine("-----------------------------");
                }



                else
                {
                    Console.WriteLine("Digite uma opção Válida!");
                }




            }
        }
    }
}
