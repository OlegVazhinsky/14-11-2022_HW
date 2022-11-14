/*

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

*/

double GetNumber (string message) {
    double userNumber;
    while (true) {
        Console.Write(message);

        if (double.TryParse(Console.ReadLine(), out double number)) {
            userNumber = number;
            break;
        }    
        else {
            Console.WriteLine($"{number} не является числом, повторите ввод.");
        }
    } 
    return userNumber;
}

double k1 = GetNumber("Введите коэффициент k1 = ");
double b1 = GetNumber("Введите коэффициент b1 = ");
double k2 = GetNumber("Введите коэффициент k2 = ");
double b2 = GetNumber("Введите коэффициент b2 = ");

if (k1 == k2 && b1 != b2) Console.WriteLine($"Заданные линии параллельны и не имееют пересечений.");
else if (k1 == k2 && b1 == b2) Console.WriteLine($"Заданные линии совпадают и имееют бесконечное число пересечений.");
else {
    double dotY = (b2 - (k2 / k1) * b1) / (1 - (k2 / k1));
    double dotX = (dotY - b1) / (k1);
    Console.WriteLine($"Пересечение в точке [{dotX}, {dotY}].");
}

