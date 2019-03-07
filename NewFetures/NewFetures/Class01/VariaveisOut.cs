using System;
using System.IO;

namespace NewFetures.Class01
{
    internal class VariaveisOut : MenuItem
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
                        Cliente cliente = new Cliente(id, campos[1], campos[2], campos[3]);

                        Console.WriteLine("Dados do Cliente");
                        Console.WriteLine("================");
                        Console.WriteLine("ID: " + cliente.Id);
                        Console.WriteLine("Nome: " + cliente.Nome);
                        Console.WriteLine("Telefone: " + cliente.Telefone);
                        Console.WriteLine("Website: " + cliente.Website);
                        Console.WriteLine("================");
                    }

                    Console.WriteLine($"Valor do ID: {id}");
                }
            }
        }
    }

    internal class Cliente
    {
        private readonly int id;
        private readonly string nome;
        private readonly string telefone;
        private readonly string website;

        public int Id => id;

        public string Nome => nome;

        public string Telefone => telefone;

        public string Website => website;

        public Cliente(int id, string nome, string telefone, string website)
        {
            this.id = id;
            this.nome = nome;
            this.telefone = telefone;
            this.website = website;
        }
    }
}