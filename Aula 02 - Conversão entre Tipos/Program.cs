//4 Tipos de Conversões: IMPLICITAS / EXPLICITAS / CLASSE CONVERT / METODO PARSE

using System;

namespace Conversão_Tipos
{
    public class Conversão_Tipos
    {
        public static void Main(string[] args)
        {
            //IMPLICITA: Pois converter de Int para um maior ele aceita;
            int notaAluno = 10;
            double notaAlunoDouble = notaAluno;

            //EXPLICITA: É necessario a Sintaxe (int), pois ocorre perda de informação;
            int numeroDoubleComoInt = (int) notaAlunoDouble;

            //CALSSE CONVERT: Convertendo de Strin para Int é preciso usar a Sintaxe: Convert.ToInt32(variavel)
            string notaString = "10";
            int notaCovert = Convert.ToInt32(notaString);

            //METODO PARSE: Sintaxe int.Parse(variavel) > Funciona para numerais, mas se for alfanumerico da excessão:
            int notaParse = int.Parse(notaString);

            //PARSE: Validando numeral ou alfanumerico
            if (int.TryParse(notaString, out int notaTryParse))
            {
                //Se não conseguir converter retorna o Iválido
            } else{
                System.Console.WriteLine("Número formato Inválido!");
            }
        }
    }
}