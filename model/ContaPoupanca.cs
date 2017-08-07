using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01.model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {

        public readonly decimal _rendimento;

        public ContaPoupanca(int agencia, DateTime dataAbertura, int numero, decimal saldo, decimal rendimento) : base(agencia, dataAbertura, numero, saldo)
        {
        }

        public decimal Taxa { get; set; }

        public void CalculaRetornoInvestimento()
        {

        }

        public void ContaPoupanca()
        {

        }

        public override void depositar(decimal valor)
        {
            throw new NotImplementedException();
        }

        public override void retirar(decimal valor)
        {
            throw new NotImplementedException();
        }

        double IContaInvestimento.CalculaRetornoInvestimento()
        {
            throw new NotImplementedException();
        }
    }
}
