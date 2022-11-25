//Случайные числа

Random random = new Random();
int number = random.Next(10,100);

int firstNumber = number / 10;
int lastNumber = number % 10;

if(firstNumber > lastNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(lastNumber);
}