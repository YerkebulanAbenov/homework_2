//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным. Не использовать строки
//6 -> да
//7 -> да
//1 -> нет

int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int daynumber = Prompt("Vvedit den nedeli");
if (daynumber == 6 || daynumber == 7)
{
    System.Console.WriteLine("Etot den vyhodnoy");
}
else if (daynumber < 1 || daynumber > 7)
{
    System.Console.WriteLine("Eto ne den nedeli");
}
else System.Console.WriteLine("(Etot den ne vyhodnoi) -> net");
