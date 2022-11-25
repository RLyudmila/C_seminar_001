
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
//а какое меньшее
 
 int number1 = int.Parse(Console.ReadLine());
 int number2 = int.Parse(Console.ReadLine());
 
 Console.WriteLine(number1);
 Console.WriteLine(number2);

 if (number1 > number2) 
 {
int max = number1;
 }
 else 
 {
   int max = number2;
    }
 Console.Write("max=", max);
 
