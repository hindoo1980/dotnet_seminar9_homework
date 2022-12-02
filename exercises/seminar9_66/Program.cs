//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

    int recursion(int m, int n) 
    {
        if (m == n) 
        {
           return m;
        } 
        else 
        {   
          return n + recursion(m, n - 1);
        }
    }

    string tmp = string.Empty;

    Console.Write($"введите целым числом значение M: ");

    tmp =  Console.ReadLine();

    bool check = int.TryParse(tmp, out int m);

    if (check == false )
    {
        Console.WriteLine("неверный ввод");
        Environment.Exit(0);
    }

    int mshow = m;

    tmp = string.Empty;

    Console.Write($"введите целым положительным числом значение N: ");

    tmp =  Console.ReadLine();

    check = int.TryParse(tmp, out int n);

    if (check == false || n < 0 )
    {
        Console.WriteLine("неверный ввод");
        Environment.Exit(0);
    }

    if (m < 0)
    {
        m = 0;
    }

    Console.WriteLine($"сумма всех натуральных значений от {mshow} до {n} равна {recursion(m, n)}");
