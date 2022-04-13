//LINQ - ANY / SINGLE / SIGLEORDEFAULT / FIRST / FIRSTORDEFAULT / ORDERBY / ORDERBYDESCENDING / WHERE / SELECT / SELECTMANY / SUM / MIN / MAX / COUNT 

using System;
using Aula_09___LINQ.Model;

namespace LINQ
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student(1, "Will", "12345678910", 100),
                new Student(1, "Marcos", "12344654910", 15),
                new Student(1, "Fabio", "124565878910", 105),
                new Student(1, "Will", "12348321910", 88),
                new Student(1, "Roger", "123487938910", 50),
            };

            //ANY - Existe agum student nesta lista
            var any = students.Any();
            //Tem algum aluno com nota 100 condição
            var any100 = students.Any(s => s.Grade == 100);

            //SINGLE se for 1 - Retorna caso diferente lança excessão
            var single = students.Single(s => s.Id == 1);
            //Existe algum aluno com nota igual a zero
            var singleOrDefault = students.SingleOrDefault(s => s.Document == "12345678910");

            //FIRST - Retorna a primeira expressão correta que achar
            var first = students.First(s => s.FullName == "Will");
            //Retorna Null se não atender
            var FirstOrDefault = students.FirstOrDefault(s => s.Grade == 0);

            //ORDERED - Ordem crescente e decrescente
            var orderedByGrade = students.OrderBy(s => s.Grade);
            var orderedByGradeDescending = students.OrderByDescending(s => s.Grade);  
            //WWHERE muito versatil, busca alunos com nota igual ou maior que 70
            var approvedStudents = students.Where(s => s.Grade >= 70);

            //SELECT selecionando apenas as notas deles
            var grades = students.Select(s => s.Grade);
            var phoneNUmbers = 

            Console.ReadKey();
        }
    }
}
