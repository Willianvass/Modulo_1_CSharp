//ESTRUTURAS DE REPETIÇÃO: WHILE - FOR - FOREACH

using System;

namespace Estruturas_Repeticao
{
    public class Estruturas_Repeticao
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite uma sequencia de numeros, separados por espaço");
            var numerosTexto = Console.ReadLine();
            var numeros = numerosTexto.Split(' ');

            System.Console.WriteLine("Numeros: ");

            var contador = 0;
            //Define o tipo da coleção - corre a variavel
            foreach (var numero in numeros)
            {
                System.Console.WriteLine(numero);
            }
        }
    }
}