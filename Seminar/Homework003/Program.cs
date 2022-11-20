// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом(первое число равно последнему, второе равно предпоследнему).


Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
string number1 = number.ToString();

if (number1.Length !=5)  
{
    Console.WriteLine("Введено неверное число!");
}
else
{
    if (number1[0] == number1[4] && number1[1] == number1[3])
    {
    Console.WriteLine("Введенное число является палиндромом ");
    }
else
    {
    Console.WriteLine("Введено не является палиндромом ");
    }
}


// Задача 21 Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] mas = {3, 6, 8, 2, 1, -7};
// int[] mas = {7, -5, 0,  1, -1, 9};
double masR = Math.Sqrt(Math.Pow(mas[0]-mas[3], 2) + Math.Pow(mas[1]-mas[4], 2) + Math.Pow(mas[2]-mas[5], 2));
Console.WriteLine($"{masR:f2}");


// Задача 23 Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N: ");
int num = int.Parse(Console.ReadLine()!);

for (int i=1; i <= num; i++)
{
    Console.Write($"{Math.Pow(i, 3)}  ");
}