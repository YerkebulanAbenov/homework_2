// Напишите программу, , а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число от 1");
int num = Convert.ToInt32(Console.ReadLine());
int index = 0;
string allEvenNum = "Chetnye chisla";
while (index <= num)
{
    if ((index % 2) == 0)
    {
        allEvenNum = allEvenNum + " " + index;
        index++;
    }
    else
    {

        index++;
    }
}
Console.WriteLine(allEvenNum);

