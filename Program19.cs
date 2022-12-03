int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int div = Prompt("delitel > ");

while (true)
{
    int value = new Random().Next(0,10);
    Console.WriteLine(value);
    if (value % div == 0)
    {
        Console.WriteLine($"My nawli delitel eto - {value}");
        break;
    }
}

