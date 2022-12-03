int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int quant = Prompt("Vvedite kolichestvo chisel > ");
int index = 0;
double sum = 0;

while (index < quant)
{
    int value = Prompt($"Vvedit {index} chislo");
    sum = sum + value;
    index++;
}
double avg = sum / index;

Console.WriteLine("Total = " + sum);
Console.WriteLine($"Average = {avg:f2}");