using System.Linq.Expressions;
using System.Net.Mail;
using System.Globalization;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal saldo = 10000;
            int tentativa = 0;


            Console.Write("Digite seu nome de usuario: ");
            string usuario = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Digite a senha de acesso: ");
            string senha = Console.ReadLine();

            while (senha != "RafaTop" && tentativa < 3) {

                Console.WriteLine("Senha Incorreta !");
                Console.WriteLine();
                Console.Write("Digite a senha de acesso: ");
                senha = Console.ReadLine();
                tentativa += 1;

            }

            if (tentativa >= 3)
            {
                Console.WriteLine("ACESSO BLOQUEADO");

            }

            else
            {

                int opcao = 0;

                Console.WriteLine();

                while (opcao != 4)
                {

                    Console.WriteLine("=======================================");
                    Console.WriteLine($" BEM VINDO AO SEU BANCO {usuario}!");
                    Console.WriteLine();
                    Console.WriteLine(" 1 - Sacar ");
                    Console.WriteLine(" 2 - Depositar ");
                    Console.WriteLine(" 3 - Consultar Saldo");
                    Console.WriteLine(" 4 - Sair");
                    Console.WriteLine();
                    Console.WriteLine("=======================================");

                    opcao = int.Parse(Console.ReadLine());


                    switch (opcao)
                    {

                        case 1:

                            int outraOperacao = 1;
                            decimal saque;

                            while (outraOperacao == 1)
                            {

                                Console.Write("Digite o Valor do Saque: ");
                                saque = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                                while (saque > saldo)
                                {

                                    Console.WriteLine("Valor de Saldo Insuficinete, digite um valor válido: ");
                                    saque = decimal.Parse(Console.ReadLine());

                                }

                                saldo = saldo - saque;
                                Console.WriteLine();

                                Console.WriteLine($" Total Saldo: R$ {saldo} reais  ");

                                Console.WriteLine();

                                Console.WriteLine($"{usuario}, você gostaria de realizar outro Saque: 1- Sim || 2- Não");
                                outraOperacao = int.Parse(Console.ReadLine());

                                while (outraOperacao < 1 || outraOperacao > 2)
                                {

                                    Console.Write("Opção Inválida, digite uma opção válida: ");
                                    outraOperacao = int.Parse(Console.ReadLine());

                                }

                            }

                            break;


                        case 2:

                            int outraOperacao2 = 1;

                            while (outraOperacao2 == 1)
                            {

                                Console.Write("Digite o Valor do Depósito: ");
                                decimal deposito = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                                while (deposito <= 0)
                                {

                                    Console.Write("Valor de Depósito inválido, insira uma valor válido: ");
                                    deposito = decimal.Parse(Console.ReadLine());

                                }

                                saldo = deposito + saldo;

                                Console.WriteLine();

                                Console.WriteLine($" Total Saldo: R$ {saldo} reais  ");

                                Console.WriteLine();

                                Console.WriteLine($"{usuario}, você gostaria de realizar outro Depósito: 1- Sim || 2- Não");
                                outraOperacao2 = int.Parse(Console.ReadLine());

                                while (outraOperacao2 < 1 || outraOperacao2 > 2)
                                {

                                    Console.Write("Opção Inválida, digite uma opção válida: ");
                                    outraOperacao2 = int.Parse(Console.ReadLine());

                                }

                            }

                            break;


                        case 3:

                            Console.WriteLine();

                            Console.WriteLine($"{usuario} seu saldo atual é: R$ {saldo} reais ");

                            Console.WriteLine();

                            break;


                        case 4:

                            Console.WriteLine();

                            Console.WriteLine($"Até a próxima {usuario}!");

                            break;

                        default:

                            Console.WriteLine("Opção Inválida, insira uma opção válida: ");
                            opcao = int.Parse(Console.ReadLine());

                            break;

                    }

                }
            }

            }
        }
    }
