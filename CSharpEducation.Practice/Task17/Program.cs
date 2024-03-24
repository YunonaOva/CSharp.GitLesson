// See https://aka.ms/new-console-template for more information

/* 18. Создать метод GetArray, который возвращает массив целых чисел и не принимает аргументов. 
Реализовывать метод не нужно, тело должно остаться пустым, но код должен компилироваться. 
В теле метода можно вернуть пустой массив. Метод вызовите в методе Main.*/

class program
{
public static void Main(string[] args)
{
    const int N = 10;
    var array = GetArray(N);
    for (int i = 1; i < N; i++)
    {
        array[i] = i;
    }
    for (int i = 0; i < N; i++)
    {
        Console.Write(i);
        if (i < N - 1)
            Console.Write(", ");
    }
    Console.WriteLine();
    Console.ReadLine();
}

public static int[] GetArray(int n)
{
    return new int[n];
}
}