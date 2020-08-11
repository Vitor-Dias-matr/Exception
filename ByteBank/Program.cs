using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente contaCorrente = new ContaCorrente(123, 132321);

                contaCorrente.Saldo = 50;
                contaCorrente.Sacar(40);

                ContaCorrente contaCorrente1 = new ContaCorrente(32, 321);

                contaCorrente1.Saldo = 100;

                contaCorrente1.Transferir(-200, contaCorrente);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.ParamName+" Negaivo"+ ex.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
