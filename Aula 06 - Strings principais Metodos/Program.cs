//STRINGS Princiapis Metodos: LENGTH / EMPTY / TO UPPER/LOWER / SPLIT / TRIM, TRIMEND, TRIMSTART / ISNULLORWHUTESPACE / REPLACE 

using System;

namespace Strings
{
    public class Strings
    {
        public static void Main(string[] args)
        {
            var paragrafo = "   C# é uma linguagem moderna e versatil." + "Com C# consigo desenvolver para Web, Desktop, Jogos, " + "Mobile, entre outros.  ";

            //LENGTH - Tamanho do string
            var tamanho = paragrafo.Length;

            //EMPTY - Retorna string vazio
            var vazio = string.Empty;

            //TOLOWER / TOUPPER - Minusculo / maiusculo
            var paragrafoMinusculo = paragrafo.ToLower();
            var paragrafoMaiusculo = paragrafo.ToUpper();

            //SPLIT Obtem frases atraves da divisao escolhida
            var frases = paragrafo.Split();

            //TRIM / TRIMEND / TRISTART - Remove so espaços
            var paragrafoTrim = paragrafo.Trim();
            var paragrafoTrimend = paragrafo.TrimEnd();
            var paragrafoTristart = paragrafo.TrimStart();

            //ISNULLORWHITESPACE
            var isnullorwhitespace = string.IsNullOrWhiteSpace(paragrafo);

            //REPLACE mudar a string
                                        //Informar o que vai mudar
            var paragrafoCsharp = paragrafo.Replace("C#", "C-sharp");

            //READKEY - Para aplicação finalizar a execução
            Console.ReadKey();

        }
    }
}
