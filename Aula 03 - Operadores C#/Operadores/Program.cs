//ARITMETICOS / COMPARAÇÃO / IGUALDADE / LÓGICOS

using System;

namespace Operadores
{
    public class Operadores
    {
        public static void Main(string[] args)
        {
            //ARITMÉTICOS (Unários ++, --, + e -)

            int numeroOperador = 4;
            System.Console.WriteLine(numeroOperador++);// 4 > Na linha debaixo é 5
            System.Console.WriteLine(numeroOperador--);// 5 > Na linha debaixo é 4
            //Usando o operador antes da variavel - Incrementa ou Decrementa antes > e após depois
            System.Console.WriteLine(++numeroOperador);// 5
            System.Console.WriteLine(--numeroOperador);// 4

            System.Console.WriteLine(numeroOperador);
            System.Console.WriteLine(-numeroOperador);//Sinal -
            System.Console.WriteLine(-(-numeroOperador));//Sinal +

            //OPERADORES (Binários + - * /)
            var soma = 4 + 5;
            var subtracao = 4 - 5;
            var multiplicacao = 4 * 5;
            var divisao = 20 / 3;
            var divisaoDouble = (double)20 / 3;

            var multiplos = (4 * 5) + 10;

            //OPERADORES DE COMPARAÇÃO ( > >= < <=) - Retorna True ou False

            System.Console.WriteLine(4 > 5);//FALSE
            System.Console.WriteLine(5 > 5);//FALSE
            System.Console.WriteLine(6 >= 5);//TRUE

            System.Console.WriteLine(5 < 4);//FALSE
            System.Console.WriteLine(5 <= 5);//TRUE
            System.Console.WriteLine(5 < 6);//TRUE

            //OPERADORES IGUALDADE ( == , != )
            System.Console.WriteLine(5 == 5);//TRUE
            System.Console.WriteLine(5 == 4);//FALSE

            System.Console.WriteLine(5 != 5);//FALSE
            System.Console.WriteLine(4 != 5);//TRUE

            //OPERADORES LÓGICOS ( AND(&&) , OR(||) )

            //OR || - Retorna True se um deles for True
            System.Console.WriteLine(true || false);//TRUE
            System.Console.WriteLine(false || true);//TRUE
            System.Console.WriteLine(false || false);//FALSE
            System.Console.WriteLine(true || true);//TRUE

            //AND && - Retorna True somente quando os 2 são True
            System.Console.WriteLine(true && false);//FALSE
            System.Console.WriteLine(false && true);//FALSE
            System.Console.WriteLine(false && false);//FALSE
            System.Console.WriteLine(true && true);//FALSE

            // EXEMPLO

            var minhaNota = 7;
            var ultimoAno = true;
                //true             true  = true (Print)
            if (minhaNota >= 7 && ultimoAno)
            {
                System.Console.WriteLine("Aprovado!");
            }
            // var = 4 - false     true  =  true (Print)  
            if (minhaNota >= 7 || ultimoAno)
            {
                System.Console.WriteLine("Aprovado!");
            }
        }
    }
}