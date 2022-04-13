//ESTRUTURAS DE CONDIÇOES: Permitem que o sistema tome uma decisão (IF / ELSE - SWITCH / CASE);

using System;

namespace Estruturas_Condicoes
{
    public class Estruturas_Condicoes
    {
        public static void Main(string[] args)
        {
            //IF/ELSE - Booleano caso o if não seja atendido o bloco Else é executado;
            System.Console.WriteLine("Digite 1 ou 2");
            var numeroDigitado = Console.ReadLine();

            if (numeroDigitado == "1")
            {
                 System.Console.WriteLine("O numero 1 foi digitado!");
            }
            else if (numeroDigitado == "2")
            {
                 System.Console.WriteLine("O numero 2 foi digitado!");
            }
            else
            {
                 System.Console.WriteLine("Outro numero foi digitado!");

            //SWITCH/CASE Utilizado para valores mais definidos. EX: Atendente pede para digitar 1, 2...

            System.Console.WriteLine("Digite 1 ou 2");
            var numeroDigitado = Console.ReadLine();

            switch (numeroDigitado)
            {
                case "1":
                    System.Console.WriteLine("O numero 1 foi digitado!");
                    break;
                case "2":
                    System.Console.WriteLine("O numero 2 foi digitado!");
                    break;
                case "3":
                    System.Console.WriteLine("Outro numero foi digitado!");
                    break;
            }

            
        }
    }
}
