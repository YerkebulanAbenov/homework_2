// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите первое число > ");
string inputValue = Console.ReadLine();
int value = Convert.ToInt32(inputValue);

if ((value%2)==0)
{
   System.Console.WriteLine("Chetnaya"); 
}
else
{
   System.Console.WriteLine("Ne CHetnaya"); 
}

