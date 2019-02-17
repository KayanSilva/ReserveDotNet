using System;
using Updates.Models;
using static System.Console;

namespace Updates.Classes
{
    internal class Program4
    {
        public void Main()
        {
            WriteLine("4. Using Static");

            var aluno = new Aluno("Marty", "McFly", new DateTime(1968, 6, 12))
            {
                Endereco = "Rua Alphaville, 338",
                Telefone = "555-6049"
            };

            WriteLine(aluno.Nome);
            WriteLine(aluno.Sobrenome);
            WriteLine(aluno.NomeCompleto);
            WriteLine($"Idade: {aluno.GetIdade()}");
            WriteLine(aluno.DadosPessoais);
        }
    }
}