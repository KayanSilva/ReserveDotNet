using System;

namespace Updates
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var menus = new string[] {
                "1. Propriedades Automáticas Somente-Leitura",
                "2. Inicializadores De Propriedade Automática",
                "3. Membros Com Corpo De Expressão",
                "4. Using Static",
                "5. Operadores Null-Condicionais",
                "6. Interpolação De Cadeia De Caracteres",
                "7. Expressões nameOf",
                "8. Filtros De Exceção",
                "9. Await Em Blocos Catch E Finally",
                "10. Inicializadores De Índice",
                "11. Metodos De Extensão Para Inicializadores De Coleção"
            };

            Console.WriteLine("ÍNDICE DE PROGRAMAS");
            Console.WriteLine("===================");

            var program = 0;
            string line;
            do
            {
                foreach (var menu in menus)
                {
                    Console.WriteLine(menu);
                }

                Console.WriteLine();
                Console.WriteLine("Escolha um programa:");

                line = Console.ReadLine();
                int.TryParse(line, out program);
                switch (program)
                {
                    case 1:
                        new Classes.Program1().Main();
                        break;

                    case 2:
                        new Classes.Program2().Main();
                        break;

                    case 3:
                        new Classes.Program3().Main();
                        break;

                    case 4:
                        new Classes.Program4().Main();
                        break;

                    case 5:
                        new Classes.Program5().Main();
                        break;

                    case 6:
                        new Classes.Program6().Main();
                        break;

                    case 7:
                        new Classes.Program7().Main();
                        break;
                    case 8:
                        new Classes.Program8().Main();
                        break;
                    case 9:
                        new Classes.Program9().Main();
                        break;
                    case 10:
                        new Classes.Program10().Main();
                        break;
                    case 11:
                        new Classes.Program11().Main();
                        break;
                    default:
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("PRESSIONE UMA TECLA PARA CONTINUAR...");
                Console.ReadKey();
                Console.Clear();
            } while (line.Length > 0);
        }
    }
}