using System;

namespace Tipos_Variveis
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numeroInt = 10;
            int maiorNumero = int.MaxValue;//Maior numero int
            int menorNumero = int.MaxValue;//menor numero int

            long numeroLong = 12121212312313213;
            long maiorNumeroLong = long.MaxValue;
            long menorNumeroLong = long.MinValue;

            decimal numeroDecimal = 10.52m;//Usa M no fim. Expressa com decimal mais preciso (Altura, preços, peso..)

            double numeroDouble = 12.3;
            double menorNumeroDouble = double.MinValue;
            double maiorNumeroDouble = double.MaxValue;

            bool verdadeiro = true;
            bool falso = false;

            var numero = 10;//Var infere o tipo de varivel automatico, vale para tudo

            string nome = "Willian Vasselo";
            char letra = 'L';//Representa uma letra, sexo

            //Usado para boletos por exemplo
            DateTime entradaNaEmpresa = new DateTime(2021, 2 , 3);
            TimeSpan quantoTempoEstanaEmpresa = DateTime.Now - entradaNaEmpresa;
        }
    }
}
