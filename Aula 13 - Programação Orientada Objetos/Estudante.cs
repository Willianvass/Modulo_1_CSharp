namespace Aula_13___Programação_Orientada_Objetos.obj.Entities
{
    public class Estudante : Pessoa//Herdada prpiedades
    {
        public Estudante(string turma, string nome, string documento, DateTime dataNascimento) : base(nome, documento, dataNascimento)//Base chama o construtor da classe base
        {
            Turma = turma;
            Notas = new List<int> {5, 10, 4, 2 , 3, 5};//Ja inicializando com valores
        }
        public string Turma { get; private set; }//Pode alterar comente dentro da classe
        public List<int> Notas { get; private set; }

        public override void SeApresentar()//Add novas informações, sobscrever
        {
            base.SeApresentar();
            var media = Notas.Average();
            System.Console.WriteLine($"Sou um estudante da turma {Turma}, a media das minahs notas é {media}");
        }
    }
}