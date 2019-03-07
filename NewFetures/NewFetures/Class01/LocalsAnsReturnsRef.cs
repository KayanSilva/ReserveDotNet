using System;

namespace NewFetures.Class01
{
    internal class LocalsAnsReturnsRef : MenuItem
    {
        public override void Main()
        {
            int[] numeros = { 2, 7, 1, 9, 12, 8, 15 };
            ref int numero = ref LocalizarNumero(12, numeros);
            numero = -12;
            Console.WriteLine(numeros[4]);
        }

        public static ref int LocalizarNumero(int valor, int[] numeros)
        {
            for (var i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == valor)
                {
                    return ref numeros[i];
                }
            }

            throw new ArgumentException("Não encontrado!");
        }
    }
}