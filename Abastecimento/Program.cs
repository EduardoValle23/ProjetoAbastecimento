using System;
using System.Globalization;

namespace Abastecimento
{
    class Program
    {
        static void Main(string[] args)
        {
            AbastecimentoMotorista dados;
            double tA;

            Console.WriteLine("CONTROLE DE ABASTECIMENTO E MEDIA");
            Console.WriteLine();

            Console.Write("Digite o nome do motorista: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a placa do veiculos: ");
            string placa = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite valor do Hodometro do ultimo abastecimento: ");
            int ultimoHodometro = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Informe a quantidade do abastecimento: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Digite os valores abaixo: ");
                Console.WriteLine("Abastecimento: " + i + "°");
                Console.Write("Litros: ");
                double litros = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Valor por litro: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Hodometro: ");
                int hodometro = int.Parse(Console.ReadLine());
                tA = litros * valor;
                int km = hodometro - ultimoHodometro;
                Console.WriteLine("Total do Abastecimento: ");
                Console.WriteLine("Valor do Abastecimento: R$" + tA.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Km rodados: "+km);
            }

            Console.WriteLine();

            
           
        }
    }
}
