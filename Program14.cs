int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int input1 = Prompt("add first number");
if (input1%7 == 0 && input1%23 ==0)
{
    Console.WriteLine("Chislo kratnoe 7 i 23");
}
else
{
    Console.WriteLine("Chislo ne kratnoe 7 i 23");
}