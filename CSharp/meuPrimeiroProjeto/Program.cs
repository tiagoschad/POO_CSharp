using System;

namespace meuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente("Tiago", 12345, 789, 10);
            ContaCorrente conta_Alberto = new ContaCorrente("Alberto", 12345, 987, 20);
            ContaCorrente conta_Florentina = new ContaCorrente("Florentina", 12345, 321, 15);

            Console.WriteLine("Titular da conta: " + conta.Titular + " - Agência: " + conta.Agencia + " - Número: " + conta.Numero);
            Console.WriteLine("Titular da conta: " + conta_Alberto.Titular + " - Agência: " + conta_Alberto.Agencia + " - Número: " + conta_Alberto.Numero);
            Console.WriteLine("Titular da conta: " + conta_Florentina.Titular + " - Agência: " + conta_Florentina.Agencia + " - Número: " + conta_Florentina.Numero);


        }
    }
}