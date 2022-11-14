/*

Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

*/

Console.Write("Введите числа через запятую - ");

string[] stringArr = Console.ReadLine().Split(',');

int[] intArr = new int [stringArr.Length];

int nonZero = 0;

for (int i = 0; i < stringArr.Length; i++) {
    intArr[i] = int.Parse(stringArr[i]);
    if (intArr[i] > 0) nonZero += 1;
}

Console.WriteLine($"В введеной последовательности положительных чисел -> {nonZero}.");