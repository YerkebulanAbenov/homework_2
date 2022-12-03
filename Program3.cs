//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int max = 0;
Console.Write("insert first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("insert second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("insert third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > max);
{
    max = number1;
}
if (number2 > max);
{
    max = number2;
}
if (number3 > max);
{
    max = number3;
}
{
    Console.WriteLine("max = " + max);
}