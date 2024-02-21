// See https://aka.ms/new-console-template for more information

//6 Создайте массив целых чисел. В цикле заполните его значениями счётчика в квадрате.//

int [] world = new int[4]; // создала массив

for (int k = 0; k < world.Length; k++)
{
    world[k] = int.Parse(Console.ReadLine());
}

int result = 0;

for (int k = 0; k < world.Length; k++)
{                                         // др вариант: int element = world[k];
    world[k] = world[k] * world[k];       // world[k] = element * element;
    Console.WriteLine(world[k]);     
}


/* 16. Напишите программу, которая проходит по массиву и находит наименьшее число.*/

int [] massiv = {1, 9, 45, 96, 2, 6, -15, 0}; // создала массив

int minimum = massiv[0];

for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i] < minimum)
    {
        minimum = massiv[i];
    }
}
Console.WriteLine(minimum); 