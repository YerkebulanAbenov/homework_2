int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int number1 = Prompt("Dobavte pervoe chislo");
int number2 = Prompt("Dobavte vtoroe chislo");

int div = number1 % number2;

if (div > 0)
{
    Console.WriteLine("Chislo " + number1 + " ne kratno ostatok ot delenya " + div);
}
else
{
    Console.WriteLine("Chislo " + number1 + " kratno " + number2);
}
