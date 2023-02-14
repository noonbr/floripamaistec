using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public float altura;

        // Overload (sobrecarga) de métodos
        // Criando métodos iguais com quantidade de parâmetros diferentes
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public Pessoa(string nome, int idade, float altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
        }
    }
}