// faça um programa que leia um número e informe se o número é par ou impar;

int num;
int numParImp;

Console.WriteLine("Digite um número:");
num = int.Parse(Console.ReadLine());

numParImp = num % 2;

if (numParImp == 0)
{
    Console.WriteLine("Esse número é par");
}
else
{
    Console.WriteLine("Esse número é impar");
}
