int Prompt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int 
if (x == 0 || y == 0)
            {
                Console.WriteLine("Odna iz koordinat ravna 0");
                return false;
            }
            return true;
        }

        int GetQuarter(int x, int y);
        {
            if (y > 0 && x > 0)
            {
                return 1;
            }
            if (y > 0 && x < 0)
            {
                return 2;
            }
            if (y < 0 && x < 0)
            {
                return 3;
            }
            return 4;
        }
        int coordX = Prompt("Vvedite X");
        int coordY = Prompt("Vvedite Y");

        if (ValidateQuarter(coordX, coordY))
        {
            int quarter = GetQuarter(coordX, coordY);
            Console.WriteLine($"Poluchennaya chetvert {quarter}");
        }
    }
}