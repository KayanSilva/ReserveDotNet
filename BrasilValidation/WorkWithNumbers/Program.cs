using Caelum.Stella.CSharp.Inwords;
using System.Diagnostics;

namespace WorkWithNumbers
{
    class Program
    {
        static void Main()
        {
            double valor = 75;
            var extenso = new Numero(valor).Extenso();
            Debug.WriteLine(extenso);

            valor = 1532987;
            extenso = new Numero(valor).Extenso();
            Debug.WriteLine(extenso);

            Debug.WriteLine(extenso + " Reais");

            var extensoBRL = new MoedaBRL(valor).Extenso();
            Debug.WriteLine(extensoBRL);

            valor = 1532987.89;
            extensoBRL = new MoedaBRL(valor).Extenso();
            Debug.WriteLine(extensoBRL);
        }
    }
}