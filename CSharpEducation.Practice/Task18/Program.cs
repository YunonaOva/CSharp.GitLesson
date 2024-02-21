// See https://aka.ms/new-console-template for more information

/* 19 Создайте и реализуйте метод, который вычисляет сумму двух чисел и возвращает их сумму. 
Вызовите метод в методе Main и выведите результат на экран. Два числе передайте в метод как вам угодно. 
Метод, который вы напишите, не должен работать с консолью.*/


using Microsoft.VisualBasic;

class program
{
public static void Main(string[] args)
{
int a = 100;
int b = 200;

var sum = Sum(a >= 100 ? a : 0, b);
Console.WriteLine(sum);
}

public static int Sum(int x, int y)
{
   return x + y;
}


}