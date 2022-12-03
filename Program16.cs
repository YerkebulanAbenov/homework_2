int value1 = new Random().Next(10,10000);
Console.WriteLine(value1);

int max = 0;
while (value1 > 0)
{
    int num = value1%10;
    value1 = value1/10;
    if (max < num)
    {
        max = num;
    }
}

    Console.WriteLine("MAX = " + max);

