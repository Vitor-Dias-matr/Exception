// using _05_ByteBank;

using System;
using System.Data;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        public int Agencia { get; }

        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {


            if (agencia <= 0)
            {
                throw new ArgumentException("O número da agencia deve ser maior que zero.", nameof(agencia));
            }
            if (numero <= 0)
            {
                throw new ArgumentException("O número da conta deve ser maior que zero.", nameof(numero));

                //throw new Exception("O número da conta deve ser maior que zero.");
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }


        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor negativo ", nameof(valor));
            }

            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;

        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {


            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException(Saldo,valor);
            }

            Sacar(valor);
            contaDestino.Depositar(valor);
        }
    }
}
