using System;
using System.IO;
using static System.Console;

namespace NewFetures.Class05
{
    internal class CodeStyle : MenuItem
    {
        public override void Main()
        {
            using (var streamReader = File.OpenText("clientes.csv"))
            {
                string linha = string.Empty;
                while ((linha = streamReader.ReadLine()) != null)
                {
                    string[] campos = linha.Split(',');

                    if (int.TryParse(campos[0], out var id))
                    {
                        Cliente1 cliente = new Cliente1(id, campos[1], campos[2], campos[3]);

                        WriteLine("Dados do Cliente");
                        WriteLine("================");
                        WriteLine("ID: " + cliente.Id);
                        WriteLine("Nome: " + cliente.Nome);
                        WriteLine("Telefone: " + cliente.Telefone);
                        WriteLine("Website: " + cliente.Website);
                        WriteLine("================");
                    }

                    Console.WriteLine($"Valor do ID: {id}");
                }
            }
        }
    }

    internal class Cliente1
    {
        private readonly int id;
        private readonly string nome;
        private readonly string telefone;
        private readonly string website;

        public int Id => id;

        public string Nome => nome;

        public string Telefone => telefone;

        public string Website => website;

        private string endereco;

        public string Endereco
        {
            get => endereco;

            set => endereco = value;
        }

        public Cliente1(int id, string nome, string telefone, string website)
        {
            this.id = id;
            this.nome = nome;
            this.telefone = telefone;
            this.website = website;
        }
    }
}