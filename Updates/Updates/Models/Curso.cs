using System.Collections;
using System.Collections.Generic;

namespace Updates.Models
{
    public class Curso : IEnumerable<Aluno>
    {
        private List<Aluno> alunos = new List<Aluno>();

        public IEnumerator<Aluno> GetEnumerator()
        {
            return ((IEnumerable<Aluno>)alunos).GetEnumerator();
        }

        public void Matricular(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Aluno>)alunos).GetEnumerator();
        }
    }

    static class CursoExtensions
    {
        public static void Add(this Curso lista, Aluno aluno) => lista.Matricular(aluno);
    }
}