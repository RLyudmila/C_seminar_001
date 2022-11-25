
// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
 int number1 = int.Parse(Console.ReadLine());
 int number2 = int.Parse(Console.ReadLine());

 int result = number1 * number1;
 if (number2 == result) 
 {
Console.WriteLine("первое число является квадратом второго");
 }
 else 
 {
    Console.WriteLine("первое число не является квадратом второго");
 }
