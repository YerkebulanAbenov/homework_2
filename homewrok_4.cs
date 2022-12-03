//Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа. Не использовать строки

//456 -> 5
//782 -> 8
//918 -> 1

int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int number = Prompt("Vvedit treh znachnoe chislo");
string number1 = Convert.ToString(number);
if (number >= 100 && number < 1000)
{
    System.Console.WriteLine("Vtoraya cifra > " + number1[1]);
}

