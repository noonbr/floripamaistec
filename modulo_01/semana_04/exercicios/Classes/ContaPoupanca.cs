using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios.Classes
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != TipoPessoa.FISICA)
            {
                throw new ArgumentException("Somente pessoas físicas podem criar uma conta poupança.");
            }
        }

        public override void Sacar(decimal valor)
        {
            base.Saldo -= valor + 0.1M;
            Console.WriteLine($"Você realizou o saque de R$ {valor}.");
        }

        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            base.Saldo -= valor + 0.05M;
            conta.Depositar(valor);
            Console.WriteLine($"Você realizou uma transferência para a conta {conta.Cliente.Nome} ({conta.Numero}) de R$ {valor}.");
        }
    }
}
