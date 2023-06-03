// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Console.WriteLine("Введите пятизначное число:");
// int num = Convert.ToInt32(Console.ReadLine());
// int t=num;
// int r;
// int sum=0;
// if(num>9999 && num<100000)
// {
// for(t=num;num!=0;num=num/10)
// {
// r=num % 10;
// sum=sum*10+r;
// }
// if(t==sum)
// Console.Write($"{t} является палиндромом.");
// else
// Console.Write($"{t} не является палиндромом.");
// } else
// Console.Write("Введите пятизначное число!");

// Задача 21
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между 
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите абсциссу первой точки:");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите ординату первой точки:");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите аппликату первой точки:");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите абсциссу второй точки:");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите ординату второй точки:");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите аппликату второй точки:");
// int z2 = Convert.ToInt32(Console.ReadLine());

// int A = x2 - x1;
// int B = y2 - y1;
// int C = z1 - z2;

// double d = Math.Sqrt(A * A + B * B + C * C);
// Console.WriteLine($"Расстояние между точками {d}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());
int N=1;
while (num>=N)
{
    Console.Write(Math.Pow(N,3) + " ");
    N=N+1;
    }