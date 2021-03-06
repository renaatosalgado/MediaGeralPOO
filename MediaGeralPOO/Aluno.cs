using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    class Aluno
    {
        public string Nome { get; private set; } // propriedade da classe, com private set, após a criação do objeto não será mais possível alterar a propriedade

        private double[] _notas; // campo, array não inicializado

        public double Media
        {
            get
            {
                return CalcularMedia();
            }
        }

        public Aluno(string nome, int provas)
        {
            Nome = nome;
            _notas = new double[provas]; // inicializa o array
        }

        public void InserirNotas() // publico porque o objeto tem que acessar para poder preencher
        {
            for (int i = 0; i < _notas.Length; i++)
            {
                Console.Write("Nota #" + (i + 1) + ": ");
                _notas[i] = double.Parse(Console.ReadLine()); // transforma a string em double
            }
        }

        private double CalcularMedia() // ninguém de fora acessa esse método, pois não é necessário, basta que ele seja executado
        {
            double total = 0;
            for (int i = 0; i < _notas.Length; i++)
            {
                total += _notas[i];
            }
            return (total) / (_notas.Length);
        }


    }
}
