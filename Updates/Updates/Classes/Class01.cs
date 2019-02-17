using System;
using Updates.Models;

namespace Updates.Classes
{
    public class Program1
    {
        public void Main()
        {
            Console.WriteLine("1. Propriedades Automáticas Somente-Leitura");

            var aluno = new Aluno("Marty", "McFly", new DateTime(1968, 6, 12));

            Console.WriteLine(aluno.ToString());
        }
    }
}