Console.Write("Введите число N > ");
string inputValue = Console.ReadLine();
int N = Convert.ToInt32(inputValue);

int unN = -N;

while (unN <= N)
{
    Console.Write(unN + " ");
    unN = unN + 1; 
}
