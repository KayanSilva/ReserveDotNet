using System;
using System.IO;
using Updates.Commons;
using Updates.Models;
using static System.Console;

namespace Updates.Classes
{
    class Program9
    {
        public async void Main()
        {
            WriteLine("9. Await Em Blocos Catch E Finally");

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

                aluno.AdicionarAvaliacao(new Avaliacao(1, "Geografia", 8));
                aluno.AdicionarAvaliacao(new Avaliacao(1, "Matemática", 7));
                aluno.AdicionarAvaliacao(new Avaliacao(1, "História", 9));
                Services.ImprimirMelhorNota(aluno);

                var aluno2 = new Aluno("Bart", "Simpson");
                await logAplicacao.WriteLineAsync("Aluno Bart Simpson foi criado...");
                Services.ImprimirMelhorNota(aluno2);

                aluno.PropertyChanged += Services.Aluno_PropertyChanged;

                aluno.Endereco = "Rua Vergueiro, 3185";
                aluno.Telefone = "555-1234";

                var aluno3 = new Aluno("Charlie", "");
                await logAplicacao.WriteLineAsync("Aluno Charlie Brown foi criado...");

            }
            catch (ArgumentException exc) when (exc.Message.Contains("não informado"))
            {
                var msg = $"Parâmetro {exc.ParamName} não foi informado!";
                await logAplicacao.WriteLineAsync(msg);
                WriteLine(msg);
            }
            catch (ArgumentException exc)
            {
                var msg = $"Parâmetro com problema! {exc.Message}";
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
