using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01.model
{
    abstract class Conta
    {
        public int Agencia { get; set; }
        public DateTime DataAbertura { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get; set; }

        public Conta(int agencia, DateTime dataAbertura, int numero, decimal saldo)
        {
        }

        public abstract void depositar(decimal valor);

        public abstract void retirar(decimal valor);

    }
}
