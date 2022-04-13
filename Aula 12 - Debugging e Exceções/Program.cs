using System; 

class URI {

    static void Main(string[] args) 
    { 
        double salario, vendas, total;
        string nome;
        nome = (Console.ReadLine());
        salario = double.Parse(Console.ReadLine());
        vendas = double.Parse(Console.ReadLine());

        total = (vendas * 0.15) + salario;

        System.Console.WriteLine("TOTAL = R$ " + total.ToString("0.00"));

    }

}