using System;
using Updates.Models;

namespace Updates.Classes
{
    internal class Program3
    {
        public void Main()
        {
            Console.WriteLine("3. Membros Com Corpo De Expressão");

            var aluno = new Aluno("Marty", "McFly", new DateTime(1968, 6, 12));
            Console.WriteLine(aluno.Nome);
            Console.WriteLine(aluno.Sobrenome);

            Console.WriteLine(aluno.NomeCompleto);
            Console.WriteLine($"Idade: {aluno.GetIdade()}");
        }
    }
}