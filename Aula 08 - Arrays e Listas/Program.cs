using System;
using System.Collections.Generic;

namespace Arrays_Listas
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            
            //Inicializar List<> - CTRL + . = using System.Collections.Generic; Lista na utiliza a capacidade
            var list = new List<int> { 0, 1, 2, 3, 4};

            //METODOS:
            //ADD - ADDRANGE
            list.Add(5);//Add um valor unitario
            list.AddRange(new List<int> {6, 7});//Add uma Lista
            list.AddRange(new int[] { 8, 9});//Add um Array

            //CONTAINS - Contar quantos elementos tem na lista
            var count = list.Count;
            var contains14 = list.Contains(14);//False
            var contains2 = list.Contains(2);//True

            System.Console.WriteLine("Lista Reversa");
            //REVERSE
            list.Reverse();
            //Passa uam instrução para cada elementno da lista
            list.ForEach(1 => Console.WriteLine(1));

            System.Console.WriteLine("Lista Ordenada");
            list.Sort();
            list.ForEach(1 => Console.WriteLine(1));

            list.Remove(4);
            list.RemoveAll(1 => 1 > 5);//Remove todo maior que 5

            list.Clear();
        }
    }
}