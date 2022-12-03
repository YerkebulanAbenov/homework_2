int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int number = Prompt("Vvedit chislo");
if (number >= 100 && number < 1000)
{
    int result = number % 10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("ne treh znachn");
}