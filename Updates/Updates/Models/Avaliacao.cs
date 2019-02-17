using System.Collections.Generic;

namespace Updates.Models
{
    public class Avaliacao
    {
        public int Bimestre { get; }
        public string Cd_Materia { get; }
        public double Nota { get; }

        Dictionary<string, string> Materias = new Dictionary<string, string>
        {
            ["MAT"] = "Matemática",
            ["LPL"] = "Língua Portuguesa",
            ["FIS"] = "Física",
            ["HIS"] = "História",
            ["GEO"] = "Geografia",
            ["QUI"] = "Química",
            ["BIO"] = "Biologia"
        };

        public Avaliacao(int bimestre, string cd_Materia, double nota)
        {
            Bimestre = bimestre;
            Cd_Materia = cd_Materia;
            Nota = nota;
        }

        public override string ToString()
        {
            return $"Bimestre: {Bimestre}, Materia: {Materias[Cd_Materia]}, Nota: {Nota}";
        }
    }
}