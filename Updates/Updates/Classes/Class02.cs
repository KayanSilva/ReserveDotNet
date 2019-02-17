using System;
using Updates.Models;

namespace Updates.Classes
{
    internal class Program2
    {
        public void Main()
        {
            Console.WriteLine("2. Inicializadores De Propriedade Automática");

            var aluno = new Aluno("Marty", "McFly", new DateTime(1968, 6, 12));
            Console.WriteLine(aluno.Nome);
            Console.WriteLine(aluno.Sobrenome);
        }
    }
}