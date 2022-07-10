using System;

namespace meuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente("Tiago", 12345, 789, 10);
            ContaCorrente conta_Alberto = new ContaCorrente("Alberto", 12345, 987, 200);
            ContaCorrente conta_Florentina = new ContaCorrente("Florentina", 12345, 321, 150);

            Console.WriteLine("Titular da conta: " + conta.Titular + " - Agência: " + conta.Agencia + " - Número: " + conta.Numero + " - Saldo: " + conta.Saldo);
            Console.WriteLine("Titular da conta: " + conta_Alberto.Titular + " - Agência: " + conta_Alberto.Agencia + " - Número: " + conta_Alberto.Numero + " - Saldo: " + conta_Alberto.Saldo);
            Console.WriteLine("Titular da conta: " + conta_Florentina.Titular + " - Agência: " + conta_Florentina.Agencia + " - Número: " + conta_Florentina.Numero + " - Saldo: " + conta_Florentina.Saldo);

            bool sacar_conta = conta.Sacar(100);
            bool sacar_conta1 = conta_Alberto.Sacar(100);
            bool sacar_conta2 = conta_Florentina.Sacar(100);

            bool depositar_conta = conta.Depositar(50);
            bool depositar_conta1 = conta_Alberto.Depositar(50);
            bool depositar_conta2 = conta_Florentina.Depositar(50);

            Console.WriteLine("Titular da conta: " + conta.Titular + " - Agência: " + conta.Agencia + " - Número: " + conta.Numero + " - Saldo: " + conta.Saldo);
            Console.WriteLine("Titular da conta: " + conta_Alberto.Titular + " - Agência: " + conta_Alberto.Agencia + " - Número: " + conta_Alberto.Numero + " - Saldo: " + conta_Alberto.Saldo);
            Console.WriteLine("Titular da conta: " + conta_Florentina.Titular + " - Agência: " + conta_Florentina.Agencia + " - Número: " + conta_Florentina.Numero + " - Saldo: " + conta_Florentina.Saldo);
        }
    }
}