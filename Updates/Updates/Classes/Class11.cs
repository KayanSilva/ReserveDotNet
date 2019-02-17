using System;
using System.IO;
using Updates.Commons;
using Updates.Models;
using static System.Console;

namespace Updates.Classes
{
    class Program11
    {
        public async void Main()
        {
            WriteLine("11. Metodos De Extensão Para Inicializadores De Coleção");

            var logAplicacao = new StreamWriter("LogAplicacao.txt");

            try
            {
                await logAplicacao.WriteLineAsync("Aplicação está iniciando...");
                var aluno = new Aluno("Marty", "McFly", new DateTime(1968, 6, 12))
                {
                    Endereco = "9303 Lyon Drive Hill Valley CA",
                    Telefone = "555-4385"
                };

                await logAplicacao.WriteLineAsync("Aluno Marty McFly foi criado...");

                WriteLine(aluno.Nome);
                WriteLine(aluno.Sobrenome);

                WriteLine(aluno.NomeCompleto);
                WriteLine("Idade: {0}", aluno.GetIdade());
                WriteLine(aluno.DadosPessoais);

                aluno.AdicionarAvaliacao(new Avaliacao(1, "GEO", 8));
                aluno.AdicionarAvaliacao(new Avaliacao(1, "MAT", 7));
                aluno.AdicionarAvaliacao(new Avaliacao(1, "HIS", 9));

                foreach (var avaliacao in aluno.Avaliacoes)
                {
                    WriteLine(avaliacao.ToString());
                }

                Services.ImprimirMelhorNota(aluno);

                var aluno2 = new Aluno("Bart", "Simpson");
                await logAplicacao.WriteLineAsync("Aluno Bart Simpson foi criado...");
                Services.ImprimirMelhorNota(aluno2);

                aluno.PropertyChanged += Services.Aluno_PropertyChanged;

                aluno.Endereco = "Rua Vergueiro, 3185";
                aluno.Telefone = "555-1234";

                var aluno3 = new Aluno("Charlie", "Brown");
                await logAplicacao.WriteLineAsync("Aluno Charlie Brown foi criado...");

                var curso = new Curso
                {
                    aluno, aluno2, aluno3
                };

                WriteLine("ALUNOS DA LISTA");
                WriteLine("===============");

                foreach (var a in curso)
                {
                    WriteLine(a.DadosPessoais);
                }
            }
            catch (ArgumentException exc) when (exc.Message.Contains("não informado"))
            {
                var msg = $"Parâmetro {exc.ParamName} não foi informado!";
                await logAplicacao.WriteLineAsync(msg);
                WriteLine(msg);
            }
            catch (ArgumentException exc)
            {
                const string msg = "Parâmetro com problema!";
                await logAplicacao.WriteLineAsync(msg);
                WriteLine(msg);
            }
            catch (Exception exc)
            {
                await logAplicacao.WriteLineAsync(exc.ToString());
                WriteLine(exc.ToString());
            }
            finally
            {
                await logAplicacao.WriteLineAsync("Aplicação terminou.");
                logAplicacao.Dispose();
            }
        }
    }
}