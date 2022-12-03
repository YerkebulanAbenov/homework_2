///Напишите программу, которая выводит случайное трёхзначное число 
///и удаляет вторую цифру этого числа. Не использовать строки для расчета
///456 -> 46
///782 -> 72
///918 -> 98

int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int number = Prompt("Vvedit trehznachnoe chislo");
string number1 = Convert.ToString(number);
{
    System.Console.WriteLine("Vtoraya cifra > " + number1[1]);
}
