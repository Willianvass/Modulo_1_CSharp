using System;

namespace Date_Time
{
    public class MyClass
    {
        public static void Main(string[] args)
        {  
            var now = DateTime.Now;
            //Listagem dos formatos que exitem para datas
            System.Console.WriteLine("Formato: ");
            var formats = new string[] {"d","D","f","F","g","G","m","o","r","s","t","T","u","U","Y"};

            foreach (var format in formats)
            {
                //2 formas de imprimir o resultado
                System.Console.WriteLine("Data no Formato {0}: {1}", format, now.ToString(format));
                //Usando o $ se chama interpolação
                //System.Console.WriteLine($"Data no formato {format} : {now.ToString(format)}");
            }
            //Maneiras de formatar manualmente
            System.Console.WriteLine($"Data no format d: {now:d}");
            System.Console.WriteLine($"Data no formato MM-dd-yyyy: {now:MM-dd-yyyy}");
            
            var dateFormat = now.ToString("MM-dd-yyyy");
            var dateFormatBr = now.ToString("dd/MM/yyyy HH:mm:ss");

            Console.ReadKey();
        }
    }
}