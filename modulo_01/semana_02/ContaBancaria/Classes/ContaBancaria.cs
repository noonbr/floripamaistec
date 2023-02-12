using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Classes
{
    public class cBancaria
    {
        public int numero;
        public int agencia;
        public string titular;
        public int saldo = 0;
        public tipoContaBancaria tipo;

        public void depositar(int novoSaldo)
        {
            if ((int) novoSaldo > 0)
            {
                this.saldo += novoSaldo;
            };
        }

        public void sacar(int qtdSaque)
        {
            if (qtdSaque > 0 && qtdSaque <= this.saldo)
            {
                this.saldo -= qtdSaque;
            } else
            {
                Console.WriteLine("Você não tem saldo suficiente para efeutar o saque.");
            }
        }

        public void mostrarSaldo()
        {
            Console.WriteLine($"O saldo atual da conta de {this.titular} é de R$ {this.saldo}.");
        }
    }
    
    public enum tipoContaBancaria
    {
        CORRENTE,
        POUPANCA
    }
}
