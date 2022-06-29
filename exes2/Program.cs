/* 
 Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
 значения b1, k1, b2 и k2 задаются пользователем.
*/
void lineIntersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * x + b1);
    System.Console.WriteLine($"Вывести точки пересечения линий {x} {y} :  ");
    if (k1 == k2) System.Console.WriteLine("Прямые паралельные , пересечений нет .");
}
double Prompt(string message)
{
    System.Console.WriteLine(message);
    double number = double.Parse(Console.ReadLine());
    return number;
}
double b1 = Prompt("Введите число b1");
double k1 = Prompt("Введите число k1");
double b2 = Prompt("Введите число b2");
double k2 = Prompt("Введите число k2");


lineIntersection(b1, k1, b2, k2);