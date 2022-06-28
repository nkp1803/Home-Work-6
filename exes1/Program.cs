// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
int Prompt(string message)
{
    System.Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int[] numbers(int M)
{
    int[] MNum = new int[M];
    for (int i = 0; i < M; i++)
    {
        MNum[i] = Prompt($"Введите {i + 1} из {M} числа");
    }
    return MNum;
}
int PositivNumber(int[] array)
{
    int counter = 0;
    foreach (int elemtnt in array)
    {
        if (elemtnt > 0) counter++;
    }
    return counter;
}
int M = Prompt("Сколь цыфр хотите ввести? ");
int [] mynumbers = numbers(M);
System.Console.WriteLine($"Вы ввели{PositivNumber(mynumbers)} Положительные числа ");