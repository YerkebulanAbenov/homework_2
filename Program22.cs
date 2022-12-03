Console.Write("Введите день недели > ");
string inputValue = Console.ReadLine();
int value = Convert.ToInt32(inputValue);

switch (value)
{
   case 1: System.Console.WriteLine("Monday");break;
   case 2: System.Console.WriteLine("Tuesday");break; 
   case 3: System.Console.WriteLine("Wednesday");break; 
   case 4: System.Console.WriteLine("Thursday");break; 
   case 5: System.Console.WriteLine("Friday");break; 
   case 6: System.Console.WriteLine("Saturday");break; 
   case 7: System.Console.WriteLine("Sunday");break; 
   default: System.Console.WriteLine("There is no week day");break;  
}

