// See https://aka.ms/new-console-template for more information

/* 14/ Создайте массив массивов. 
Размер каждого внутреннего массива должен быть на 1 больше, чем предыдущий. 
Первый массив должен быть размера 1.*/

using System.Formats.Asn1;
using System.Threading.Tasks.Dataflow;
Console.WriteLine("Введите желаемое количество массивов");
int a = int.Parse(Console.ReadLine());
int[][] numbers = new int[a][];            // создала массив массивов
                                      

for (int i = 1; i< a; i++)
{
    numbers[i] = new int[i + 1];

    for (int j = 0; j<numbers[i].Length;j++)
    {
        Console.WriteLine("Введите значения");
        numbers[i][j] = int.Parse(Console.ReadLine());
        
    }
}
for (int i = 0; i < numbers.Length; i++)
    for (int j = 0; j < numbers[i].Length; j++)
        Console.WriteLine("Значения в массиву: " + numbers[i][j]);


/* 15. Создайте двумерный массив. В циклах заполните его значениями счётчика. Выведите массив на экран.*/

/*int[,] nums2 = new int[2, 3];      // создала массив массивов//

for (int i = 1; i<numbers.Length;i++)*/




