// See https://aka.ms/new-console-template for more information

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int N = int.Parse(Console.ReadLine());
int k;
k = 2;
while (k<=N)
{
    Console.WriteLine(k);
    k = k +2;
}


