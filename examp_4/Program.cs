// See https://aka.ms/new-console-template for more information

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("YES");
}else
{
  Console.WriteLine("NO");  
}