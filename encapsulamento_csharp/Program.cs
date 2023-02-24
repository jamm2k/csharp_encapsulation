using encapsulamento_csharp;
using System;
using System.Globalization;

ContaBancaria conta1;

Console.Write("Digite o número da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Digite o nome do titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá deposito inicial? (s/n)");
char inicial = char.Parse(Console.ReadLine());
if (inicial == 's' || inicial == 'S')
{
    Console.Write("Digite o depósito inicial: ");
    double depInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta1 = new ContaBancaria(numero, titular, depInicial);
} else
{
    conta1 = new ContaBancaria(numero, titular);
}

Console.WriteLine();
Console.WriteLine("Dados da conta: ");
Console.WriteLine(conta1);