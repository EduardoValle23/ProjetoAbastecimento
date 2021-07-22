using System.Globalization;

namespace Abastecimento
{
    class AbastecimentoMotorista
    {
        public string Nome { get; set; }
        public double Litro { get; private set; }
        public double Valor { get; private set; }
        public int Hodometro { get; private set; }

        public AbastecimentoMotorista(string nome, double litro, double valor, int hodometro)
        {
            Nome = nome;
            Litro = litro;
            Valor = valor;
            Hodometro = hodometro;
        }


        public double ValorDoAbastecimento()
        {
            return Litro * Valor;
        }

        public override string ToString()
        {
            return Nome 
                + ", Litros: " 
                + Litro 
                +", Valor por Litro: R$ " 
                + Valor 
                + ", Valor do Abastecimento: R$ " 
                + ValorDoAbastecimento().ToString("F2", CultureInfo.InvariantCulture);
        }

    }




    
}
