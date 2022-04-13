namespace Aula_13___Programação_Orientada_Objetos.obj
{
    public abstract class Pessoa//Abstract a classe vai ser herdada de outras
    {
        public Pessoa(string nome, string documento, DateTime dataNascimento)//Construtor
        {
            Nome = nome;//Os parametos que passo no bloco de baixo inicializo aqui
            Documento = documento;
            DataNascimento = dataNascimento;
        }
        public string Nome { get; protected set; }//Nao quero que alte o valor nome (protected)
        public string Documento { get; protected set; }
        public DateTime DataNascimento { get; protected set; }

        public virtual void SeApresentar()
        {
            //Criando um comportamento Polimorfismo
            System.Console.WriteLine($"Olá meu nome é {Nome}, nasci no dia {DataNascimento} meu documento é {Documento}");
        }
        
    }
}