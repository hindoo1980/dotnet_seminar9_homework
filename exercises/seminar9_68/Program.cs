// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// static class GlobalVars
// {
//     public static uint a;
// }

class Akkerman
{
     public static int akk(int n, int m) 
    {
        if (n == 0) 
        {
            //GlobalVars.a++;
            return  m + 1 ;
        } 
        else 
        {          
            if (n != 0 && m == 0)
            {
                //GlobalVars.a++;
                return akk(n - 1, 1);              
            }     
            else
            {
                //GlobalVars.a++;
                return akk(n - 1 , akk(n, m - 1));              
            }
        }
    }
  
  static void Main() 
  {

     string tmp = string.Empty;

        Console.WriteLine($"введите целым положительным числом значение n:");

        tmp =  Console.ReadLine();

        bool check = int.TryParse(tmp, out int n);

        if (check == false || n < 0 )
        {
            Console.WriteLine("неверный ввод");
            Environment.Exit(0);
        }

        Console.WriteLine($"введите целым положительным числом значение m:");

        tmp =  Console.ReadLine();

        check = int.TryParse(tmp, out int m );

        if (check == false || m < 0 )
        {
            Console.WriteLine("неверный ввод");
            Environment.Exit(0);
        }

    Console.WriteLine(); Console.WriteLine ($"результат: {akk(n, m)}");
    //Console.WriteLine (GlobalVars.a);
  }
  
}
