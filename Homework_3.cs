int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int number = Prompt("Vvedit chislo");
string number1 = Convert.ToString(number);
if (number >= 100 && number < 1000)
{
    System.Console.WriteLine("Vtoraya cifra > " + number1[1]);
}
else
{
    System.Console.WriteLine("ne treh znachnaya");
}

