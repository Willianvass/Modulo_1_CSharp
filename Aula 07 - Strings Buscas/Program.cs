//STRINGS BUSCAS - INDEXOF / LASTINDEXOF / STARTSWITH / SUBSTRING / CONTAINS 

using System;

namespace Strings
{
    public class Strings
    {
        public static void Main(string[] args)
        {
            var outroParagrafo = "C# é uma linguagem moderna e versatil." + "Com C# consigo desenvolver para Web, Desktop, Jogos, " + "Mobile, entre outros.";

            //INDEXOF
            var indexOf = outroParagrafo.IndexOf("C#");

            //LASTINDEXOF
            var lastIndexOf = outroParagrafo.StartsWith("C#");

            //SUBSTRING
            var indexOfMobile = outroParagrafo.IndexOf("Mobile");
                                        //Variavel palavra Mobile - Quantidade de caracteres
            var substringMobile = outroParagrafo.Substring(indexOfMobile, 6);

            //CONTAINS
                                                     //Localiza a string e ignora se é maiusculo ...
            var containsJogos = outroParagrafo.Contains("jogos", StringComparison.OrdinalIgnoreCase);
                                      //Exatamente igual a string digitada  
            var containsJogosExatos = outroParagrafo.Contains("Jogos");

            var containsRuim = outroParagrafo.Contains("Ruim"); 
            Console.ReadKey();
        }
    }
}

