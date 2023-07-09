﻿// Доп.Задача Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. (Решить можно, если хотите потренироваться)
// (Следующее число складывается из двух предыдущих)
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите количество чисел Фибоначчи (N): ");
        int N = Convert.ToInt32(Console.ReadLine());

        int prev = 0; // Предыдущее число
        int current = 1; // Текущее число

        Console.Write("Последовательность чисел Фибоначчи: ");

        Console.Write(prev); // Выводим первое число Фибоначчи

        for (int i = 1; i < N; i++)
        {
            Console.Write(" " + current); // Выводим текущее число Фибоначчи

            int temp = current; // Сохраняем текущее число
            current = prev + current; // Считаем следующее число
            prev = temp; // Обновляем предыдущее число
        }

        Console.WriteLine();