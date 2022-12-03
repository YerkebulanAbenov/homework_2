int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int input1 = Prompt("add number");
int input2 = Prompt("add number");
int input3 = Prompt("add number");
int input4 = Prompt("add number");
int input5 = Prompt("add number");
double avg = (input1 + input2 + input3 + input4 + input5) / 5.0;
int sum = (input1 + input2 + input3 + input4 + input5);

Console.WriteLine("Total = " + sum);
Console.WriteLine("Average = " + avg);
