//Задание 6
//Пользователь вводит с клавиатуры показания тем-
//пературы. В зависимости от выбора пользователя про-
//грамма переводит температуру из Фаренгейта в Цельсий 
//или наоборот.


int k;
do
{
    Console.WriteLine("Input temperature");
    double tem = double.Parse(Console.ReadLine());
    Console.WriteLine("from degrees Celsius to degrees Fahrenheit input - 0");
    Console.WriteLine("from degrees Fahrenheit to degrees Celsius input - 1");
    int i = int.Parse(Console.ReadLine());
    if (i == 0)
    {
        Console.Write(tem + " degrees Celsius is ");
        Console.WriteLine(tem * 1.8 + 32 + " degrees Fahrenheit ");
    }
    else if (i == 1)
    {
        Console.Write(tem + " degrees Fahrenheit is ");
        Console.WriteLine((tem - 32) * 0.5556 + " degrees Celsius ");
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
    Console.WriteLine("Input key - 1 - to continue, 0 - to exit");
    k = int.Parse(Console.ReadLine());
} while (k == 1);
return;