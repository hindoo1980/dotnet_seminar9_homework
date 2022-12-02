// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

    void recursion(int n) 
    {
        if (n == 1) 
        {
           Console.WriteLine(1);
        } 
        else 
        {   
            Console.WriteLine(n);
            recursion(n - 1);
        }
    }
  
    string tmp = string.Empty;

    Console.Write($"введите целым положительным числом значение N: ");

    tmp =  Console.ReadLine();

    bool check = int.TryParse(tmp, out int n);

    if (check == false || n < 0 )
    {
        Console.WriteLine("неверный ввод");
        Environment.Exit(0);
    }

    recursion(n);