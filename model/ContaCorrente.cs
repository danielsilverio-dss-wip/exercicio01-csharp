using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01.model
{
    sealed class ContaCorrente : Conta
    {
        public ContaCorrente(int agencia, DateTime dataAbertura, int numero, decimal saldo) : base(agencia, dataAbertura, numero, saldo)
        {
        }

        private TipoConta Tipo { get; set; }

        public override void depositar(decimal valor)
        {
            Saldo = Saldo + valor;
        }

        public override void retirar(decimal valor)
        {
            Saldo = Saldo - valor;
        }
    }
}
