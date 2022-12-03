Console.Write("Введите число N > ");
string inputValue = Console.ReadLine();
double N = Convert.ToDouble(inputValue);

double K = 1/N;
Console.Write($"Obratnoe chislo {N:f2} = {K:f2}");

