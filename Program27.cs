int N = 1;

while (N <= 100) 
{
    if (N%3==0 && N%5==0)
    {
        Console.Write(" FIZZBUZZ ");
    }
    else if (N%3==0)
    {
        Console.Write(" FIZZ ");
    }
    else if (N%5==0)
    {
        Console.Write(" BUZZ ");
    }
    N = N + 1; 
}
