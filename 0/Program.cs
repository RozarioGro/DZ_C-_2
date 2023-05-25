/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
Console.Clear();
Console.WriteLine ("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine ());
int num2 = num / 10;
int num3 = num2 % 10;
if (num < 100 || num >= 1000){
    Console.WriteLine("Введите коректное число");
    return;
}
Console.WriteLine($"{num}->{num3}");
