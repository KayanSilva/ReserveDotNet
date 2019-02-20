using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Refactoring.Models;

namespace Refactoring.Codes
{
    public static class ExtractSuperclass
    {
        public static void ExtractSuperMain()
        {
            var item1 = new Item(new Product("Escova dental Dentinho Feliz", 15), 15, 3);
            var item2 = new Item(new Product("Sabonete Flor da Manhã", 3), 3, 10);
            var item3 = new Item(new Product("Desodorante Man Power", 20), 20, 2);

            const string nomeCliente = "João Snow";
            const string enderecoEntrega = "Castelo Estarque, Torre 2 - Vila do Norte";
            var order = new Order(nomeCliente, enderecoEntrega);
            var notaFiscal = new NotaFiscal(order);
        }
    }
}
