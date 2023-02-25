using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios.Classes
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string Profissao { get; private set; }
        public EstadoCivil EstadoCivil { get; private set; }
        public TipoPessoa TipoPessoa { get; private set; }

        public Cliente(string nome, DateTime nascimento, string profissao, EstadoCivil estadoCivil, TipoPessoa tipoPessoa)
        {
            Nome = nome;
            Nascimento = nascimento;
            Profissao = profissao;
            EstadoCivil = estadoCivil;
            TipoPessoa = tipoPessoa;
        }
    }

    public enum EstadoCivil
    {
        SOLTEIRO = 0,
        CASADO = 1
    }

    public enum TipoPessoa
    {
        FISICA = 0,
        JURIDICA = 1
    }
}
