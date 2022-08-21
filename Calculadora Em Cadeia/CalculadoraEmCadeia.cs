using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Em_Cadeia
{
    internal class CalculadoraEmCadeia
    {
        private double ValorAtual = 0;
        public CalculadoraEmCadeia(double valor)
        {
            ValorAtual = valor;
        }

        public double Soma(double valor)
        {
            ValorAtual += valor;
            return ValorAtual;
        }
        public double Subtrair(double valor)
        {
            ValorAtual -= valor;
            return ValorAtual;
        }
        public double Multiplicacao(double valor)
        {
            ValorAtual *= valor;
            return ValorAtual;
        }
        public double divisao(double valor)
        {
            ValorAtual /= valor;
            return ValorAtual;
        }
        public static void Executar()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("=-=-= CALCULADORA =-=-=-=-=-=");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Operações da Calculadora:");
            Console.WriteLine("1 - soma. ");
            Console.WriteLine("2 - Subtração. ");
            Console.WriteLine("3 - Multiplicação. ");
            Console.WriteLine("4 - Divisão. ");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("Informe um número. ");
            double.TryParse(Console.ReadLine(), out double valorUsuario);
            var calculadora = new CalculadoraEmCadeia(valorUsuario);
            var funk = true;

            while (funk)
            {
                Console.WriteLine("Informe um novo numero");
                double operacao = double.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine("Escolha uma Operação");
                int.TryParse(Console.ReadLine(), out int opcao);

                switch (opcao)
                {
                    case 1:
                        calculadora.Soma(operacao);
                        Console.WriteLine("Resultado da soma: " + calculadora.ValorAtual);
                        break;
                    case 2:
                        calculadora.Subtrair(operacao);
                        Console.WriteLine("Resultado da subtraçao: " + calculadora.ValorAtual);
                        break;
                    case 3:
                        calculadora.Multiplicacao(operacao);
                        Console.WriteLine("Resultado da multiplicação: " + calculadora.ValorAtual);
                        break;
                    case 4:
                        calculadora.divisao(operacao);
                        Console.WriteLine("Resultado da soma: " + calculadora.ValorAtual);
                        break;

                    default:
                        Console.WriteLine("Operação Invalida");
                        continue;
                        //break; Nao precisa ser usado.
                }
                Console.WriteLine("Você deseja fazer uma nova operação? Sim (s) Não (n)");
                var sair = Console.ReadLine() ?? "";
                if (sair == "s")
                {
                    funk = true;
                }
                else
                {
                    funk = false;
                    Console.WriteLine("Operação Finalizada.");
                    break;
                }

            }


        }




    }
}

