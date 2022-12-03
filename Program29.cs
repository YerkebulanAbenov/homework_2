Console.Write("Введите первое число > ");
string inputValue1 = Console.ReadLine();
int value1 = Convert.ToInt32(inputValue1);

Console.Write("Введите первое число > ");
string inputValue2 = Console.ReadLine();
int value2 = Convert.ToInt32(inputValue2);

int squareValue = value1 * value1;
if (squareValue == value2)
{
   System.Console.WriteLine("Является"); 
}
else
{
   System.Console.WriteLine("Не Является"); 
}
