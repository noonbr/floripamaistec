using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios.Classes
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != TipoPessoa.FISICA)
            {
                throw new ArgumentException("Somente pessoas físicas podem criar uma conta corrente.");
            }
        }

        public override void Sacar(decimal valor)
        {
            base.Saldo -= valor + 0.5M;
            Console.WriteLine($"Você realizou o saque de R$ {valor}.");
        }
        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            base.Saldo -= valor + 0.25M;
            conta.Depositar(valor);
            Console.WriteLine($"Você realizou uma transferência para a conta {conta.Cliente.Nome} ({conta.Numero}) de R$ {valor}.");
        }
    }
}
