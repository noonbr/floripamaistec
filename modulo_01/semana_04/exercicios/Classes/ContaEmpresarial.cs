using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace exercicios.Classes
{
    public class ContaEmpresarial : ContaBancaria
    {
        public decimal LimiteEmprestimos { get; private set; }
        public decimal TaxaJuros { get; private set; }
        public bool PossuiEmprestimo { get; private set; }
        public decimal ValorUsado { get; private set; }
        public string CNPJ{ get; private set; }

        public ContaEmpresarial(int numero, int agencia, Cliente cliente, decimal limite, decimal taxaJuros, string cnpj) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != TipoPessoa.JURIDICA)
            {
                throw new ArgumentException("Somente pessoas jurídicas podem criar uma conta empresarial.");
            }

            LimiteEmprestimos = limite;
            TaxaJuros = taxaJuros;
            CNPJ = cnpj;
        }

        public override void Sacar(decimal valor)
        {
            base.Saldo -= valor + 1M;
            Console.WriteLine($"Você realizou o saque de R$ {valor}.");
        }

        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            base.Saldo -= valor + 0.5M;
            conta.Depositar(valor);
            Console.WriteLine($"Você realizou uma transferência para a conta {conta.Cliente.Nome} ({conta.Numero}) de R$ {valor}.");
        }

        public void FazerEmprestimo(decimal valor)
        {
            if (PossuiEmprestimo)
            {
                Console.WriteLine("Você precisa pagar o empréstimo anterior.");
                return;
            }

            if (valor <= LimiteEmprestimos)
            {
                base.Depositar(valor);
                ValorUsado = valor;
                PossuiEmprestimo = true;
                Console.WriteLine($"Você recebeu um empréstimo de R$ {valor}.");
            } else
            {
                Console.WriteLine("O valor ultrapassa o limite do empréstimo.");
                return;
            }
        }

        public void PagarEmprestimo()
        {
            if (!PossuiEmprestimo)
            {
                Console.WriteLine("Você não tem empréstimos.");
                return;
            }

            decimal valorTotal = ValorUsado + (ValorUsado * TaxaJuros / 100);
            if (base.Saldo < valorTotal)
            {
                Console.WriteLine("Você não tem saldo suficiente para pagar o empréstimo.");
                return;
            }

            base.Saldo -= valorTotal;
            ValorUsado = 0;
            PossuiEmprestimo = false;
            Console.WriteLine($"Pagamento de R$ {valorTotal} realizado com sucesso!");
        }
    }
}
