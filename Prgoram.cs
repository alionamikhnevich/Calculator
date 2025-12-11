using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Простой консольный калькулятор на C#");
        Console.WriteLine("-----------------------------------");

        double num1, num2;
        char operation;

        // Ввод первого числа
        Console.Write("Введите первое число: ");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            Console.Write("Введите первое число: ");
        }

        // Ввод оператора
        Console.Write("Введите оператор (+, -, *, /): ");
        while (!char.TryParse(Console.ReadLine(), out operation) || (operation != '+' && operation != '-' && operation != '*' && operation != '/'))
        {
            Console.WriteLine("Некорректный оператор. Пожалуйста, введите +, -, * или /.");
            Console.Write("Введите оператор (+, -, *, /): ");
        }

        // Ввод второго числа
        Console.Write("Введите второе число: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            Console.Write("Введите второе число: ");
        }

        double result = 0;
        bool validOperation = true;

        // Выполнение операции
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Ошибка: Деление на ноль!");
                    validOperation = false;
                }
                break;
        }

        // Вывод результата
        if (validOperation)
        {
            Console.WriteLine($"\nРезультат: {num1} {operation} {num2} = {result}");
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода.");
        Console.ReadKey();
    }
}
