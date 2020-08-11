using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; set; }
        public double ValorSaque { get; set; }

        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(double saldo, double valorSaque)
            :this("Valor do saque"+valorSaque+" Saldo atual "+saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsuficienteException(string message)
            :base(message)
        {

        }
    }
}
