/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
Console.Clear();
Console.Write("Введите цифру дня недели: ");
int wd = int.Parse(Console.ReadLine());
if (wd < 6 || wd <=0){
    Console.WriteLine("no");
}else if (wd <=7){
    Console.WriteLine("yes");
}else {
    Console.WriteLine("Такого дня нет");
}

