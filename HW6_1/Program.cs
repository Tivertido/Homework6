// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Введите числа через запятую: ");
        string input = Console.ReadLine();

        string[] numbers = input.Split(',');

        int greaterThanZeroCount = 0;

        foreach (string numberStr in numbers)
        {
            int number = Convert.ToInt32(numberStr.Trim());
            
            if (number > 0)
            {
                greaterThanZeroCount++;
            }
        }

        Console.WriteLine($"Количество чисел больше 0: {greaterThanZeroCount}");
