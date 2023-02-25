using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios.Classes
{
    public class ContaBancaria
    {
        public int Numero { get; protected set; }
        public int Agencia { get; protected set; }
        public Cliente Cliente { get; protected set; }
        public decimal Saldo { get; protected set; }

        public ContaBancaria(int numero, int agencia, Cliente cliente)
        {
            Numero = numero;
            Agencia = agencia;
            Cliente = cliente;
        }

        public virtual void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public virtual void Transferir(ContaBancaria conta, decimal valor)
        { 
            if (valor <= Saldo)
            {
                conta.Saldo += valor;
            } else
            {
                Console.WriteLine("Você não tem saldo suficiente para realizar a transferência.");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"A conta de {Cliente.Nome} ({Numero}) tem saldo de R$ {Saldo}.");
        }
    }
}
