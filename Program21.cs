int value1 = new Random().Next(10,100);
Console.WriteLine(value1);

int edinica = value1%10;
int desyatka = value1/10;

if (edinica > desyatka)
{
    Console.WriteLine("naibolwee chislo " + edinica);
}
else
{
    Console.WriteLine("naibolwee chislo " + desyatka);
}

