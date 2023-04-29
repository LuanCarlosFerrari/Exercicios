using Microsoft.Extensions.DependencyInjection;
using System;

namespace ExemploCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria o contêiner de injeção de dependência
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICalculadora, Calculadora>()
                .BuildServiceProvider();

            // Obtém a instância da Calculadora através do contêiner de injeção de dependência
            var calculadora = serviceProvider.GetService<ICalculadora>();

            int opcao = 0;
            double num1, num2;

            do
            {
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                if (opcao != 0)
                {
                    Console.Write("Digite o primeiro número: ");
                    num1 = double.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    num2 = double.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Resultado: " + calculadora.Somar(num1, num2));
                            break;
                        case 2:
                            Console.WriteLine("Resultado: " + calculadora.Subtrair(num1, num2));
                            break;
                        case 3:
                            Console.WriteLine("Resultado: " + calculadora.Multiplicar(num1, num2));
                            break;
                        case 4:
                            Console.WriteLine("Resultado: " + calculadora.Dividir(num1, num2));
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                    Console.WriteLine();
                }

            } while (opcao != 0);
        }
    }
}