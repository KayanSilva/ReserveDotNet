﻿using System;

namespace NewFetures.Class01
{
    internal class NamedArguments : MenuItem
    {
        public override void Main()
        {
            //O método pode ser chamado do jeito normal, usando argumentos posicionais.
            ImprimirDetalhesDoPedido("Maria de Fátima", 31, "Caneca Vermelha");

            //Argumentos nomeados podem ser fornecidos para os parâmetros em qualquer ordem.
            ImprimirDetalhesDoPedido(numeroPedido: 31, nomeProduto: "Caneca Vermelha", vendedor: "Maria de Fátima");
            ImprimirDetalhesDoPedido(nomeProduto: "Caneca Vermelha", vendedor: "Maria de Fátima", numeroPedido: 31);

            //Argumentos nomeados misturados com argumentos posicionais são válidos
            //desde que sejam usados em sua posição correta.
            ImprimirDetalhesDoPedido("Maria de Fátima", 31, nomeProduto: "Caneca Vermelha");

            // As 2 linhas abaixo geravam erro de compilação ANTES DO C# 7.2:
            ImprimirDetalhesDoPedido(vendedor: "Maria de Fátima", 31, nomeProduto: "Caneca Vermelha"); // somente a partir do C# 7.2
            ImprimirDetalhesDoPedido("Maria de Fátima", numeroPedido: 31, "Caneca Vermelha"); // somente a partir do C# 7.2
        }

        private static void ImprimirDetalhesDoPedido(string vendedor, int numeroPedido, string nomeProduto)
        {
            if (string.IsNullOrWhiteSpace(vendedor))
            {
                throw new ArgumentException(message: "Nome de vendedor não pode ser nulo ou vazio.", paramName: nameof(vendedor));
            }

            Console.WriteLine($"Vendedor: {vendedor}, Pedido #: {numeroPedido}, Produto: {nomeProduto}");
        }
    }
}