using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBancaria.Classes
{
    public class ContaBancaria
    {
        private string _titular;
        private int _numero;
        private int _agencia;
        private decimal _saldo = 0;
        private tipoConta _tipoConta;

        public ContaBancaria(string titular, int numero, int agencia, tipoConta tipoConta)
        {
            _titular = titular;
            _numero = numero;
            _agencia = agencia;
            _tipoConta = tipoConta;
        }

        public ContaBancaria(string titular, tipoConta tipoConta)
        {
            Random random = new Random();
            _titular = titular;
            _tipoConta = tipoConta;
            _numero = random.Next(0, 9999);
            _agencia = random.Next(0, 9999);
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
            }
            else
            {
                Console.WriteLine("O valor deve ser maior que 0.");
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor <= _saldo)
            {
                Console.WriteLine($"Saque de {valor} realizado com sucesso.");
                _saldo -= valor;
                Depositar(valor);
            }
        }

        public void Transferir(ContaBancaria conta, decimal valor)
        {
            if (valor > 0 && _saldo >= valor)
            {
                conta.Depositar(valor);
                _saldo -= valor;
                Console.WriteLine($"Você transferiu R$ {valor} com sucesso para {conta._titular} ({conta._numero}).");
            }
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"O saldo atual da conta {_titular} ({_numero}) é de R$ {_saldo}.");
        }
    }

    public enum tipoConta
    {
        POUPANCA = 0,
        CORRENTE = 1
    }
}
