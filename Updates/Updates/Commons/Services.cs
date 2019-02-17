using System.ComponentModel;
using Updates.Models;
using static System.Console;

namespace Updates.Commons
{
    public class Services
    {
        public static void ImprimirMelhorNota(Aluno aluno)
        {
            WriteLine($"Melhor nota: {aluno?.MelhorAvaliacao?.Nota}");
        }

        public static void Aluno_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            WriteLine($"Propriedade {e.PropertyName} foi alterada!");
        }
    }
}