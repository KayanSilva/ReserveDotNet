﻿using System;
using Updates.Commons;
using Updates.Models;
using static System.Console;

namespace Updates.Classes
{
    internal class Program5
    {
        public void Main()
        {
            WriteLine("5. Operadores Null-Condicionais");

            var aluno = new Aluno("Marty", "McFly", new DateTime(1968, 6, 12))
            {
                Endereco = "9303 Lyon Drive Hill Valley CA",
                Telefone = "555-4385"
            };
            WriteLine(aluno.Nome);
            WriteLine(aluno.Sobrenome);

            WriteLine(aluno.NomeCompleto);
            WriteLine($"Idade: {aluno.GetIdade()}");
            WriteLine(aluno.DadosPessoais);

            aluno.AdicionarAvaliacao(new Avaliacao(1, "Geografia", 8));
            aluno.AdicionarAvaliacao(new Avaliacao(1, "Matemática", 7));
            aluno.AdicionarAvaliacao(new Avaliacao(1, "História", 9));
            Services.ImprimirMelhorNota(aluno);

            var aluno2 = new Aluno("Bart", "Simpson");

            Services.ImprimirMelhorNota(aluno2);
        }
    }
}