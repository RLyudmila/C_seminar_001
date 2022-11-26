// See https://aka.ms/new-console-template for more information

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
if (number1 == number2)
{
    Console.WriteLine(number1);
    Console.WriteLine("Числа равны");
}
if (number1 > number2)
{
    Console.WriteLine("max=",number1);
    Console.whiteLine(number1);
    Console.Write("min=",number2);
    Console.WriteLine(number2);
}
else
{
    Console.WriteLine("max=", number2);
    Console.WriteLine("min=", number1);
}