int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int input1 = Prompt("add number");
int delitel1 = Prompt("1 delitel");
int delitel2 = Prompt("2 delitel");
if (input1%delitel1 == 0 && input1%delitel2 ==0)
{
    Console.WriteLine("Chislo kratnoe");
}
else
{
    Console.WriteLine("Chislo ne kratnoe");
}