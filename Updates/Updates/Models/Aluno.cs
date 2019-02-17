using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using static System.DateTime;
using static System.String;

namespace Updates.Models
{
    public class Aluno : INotifyPropertyChanged
    {
        private IList<Avaliacao> avaliacoes = new List<Avaliacao>();

        public event PropertyChangedEventHandler PropertyChanged;

        public string Nome { get; }
        public string Sobrenome { get; }
        private string endereco;
        private string telefone;
        public DateTime DataNascimento { get; } = new DateTime(1990, 1, 1);

        public Aluno(string nome, string sobrenome)
        {
            VerificarParametroPreenchido(nome, nameof(nome));
            VerificarParametroPreenchido(sobrenome, nameof(sobrenome));

            Nome = nome;
            Sobrenome = sobrenome;
        }

        public Aluno(string nome, string sobrenome, DateTime dataNascimento) :
            this(nome, sobrenome)
        {
            DataNascimento = dataNascimento;
        }

        public string NomeCompleto => Nome + " " + Sobrenome;

        public int GetIdade() => (int)(((Now - DataNascimento).TotalDays) / 365.242199);

        public string Endereco
        {
            get { return endereco; }
            set
            {
                if (endereco != value)
                {
                    endereco = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(DadosPessoais));
                }
            }
        }

        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (telefone != value)
                {
                    telefone = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(DadosPessoais));
                }
            }
        }

        public string DadosPessoais =>
                 $"Nome: {NomeCompleto}, Endereço: {Endereco}, Telefone: {Telefone}, Data de Nascimento: {DataNascimento:dd/MM/yyyy}";

        private static void VerificarParametroPreenchido(string valorParametro, string nomeParametro)
        {
            if (IsNullOrEmpty(valorParametro))
            {
                throw new ArgumentException("Parâmetro não informado!", nomeParametro);
            }
        }

        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public IReadOnlyCollection<Avaliacao> Avaliacoes => new ReadOnlyCollection<Avaliacao>(avaliacoes);
        public Avaliacao MelhorAvaliacao => avaliacoes.OrderBy(a => a.Nota).LastOrDefault();

        public void AdicionarAvaliacao(Avaliacao avaliacao)
        {
            avaliacoes.Add(avaliacao);
        }
    }
}