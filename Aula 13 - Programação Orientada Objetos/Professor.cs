using System;

namespace Aula_13___Programação_Orientada_Objetos.obj.Entities
{
    public class Professor : Pessoa
    {
        public Professor(decimal salario, string nome, string documento, DateTime dataNascimento) : base (nome, documento, dataNascimento)//Contrutor
        {
            Salario = salario;
            Turmas = new List<string> {"A", "B"};
        }
        public List<string> Turmas { get; private set; }
        public decimal Salario { get; private set; }

        public override void SeApresentar()
        {
            var turmas = string.Join(',', Turmas);

            System.Console.WriteLine($"Meu salario é de R$ {Salario} dou aulas para a turma {turmas}");
        }
    }
}