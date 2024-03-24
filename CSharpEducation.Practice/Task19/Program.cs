// See https://aka.ms/new-console-template for more information


/*
 20. Создайте и реализуйте метод, который принимает на вход размер массива n и возвращает пустой массив указанного размера. 
 Вызовите метод в методе Main и заполните его полученный массив. Содержимое массива выведите на экран.
 */
class Program
{
   public static void Main(string[] args)
    {
        int N = 5;

        var Array = NewArray(N);

        for (int i = 0; i < N; i++)
        {
            Array[i] = i;
        }
        for (int i = 0; i < N; i++)
        {
            Console.Write(i);
        }
        Console.ReadLine();
    }

   public static int[] NewArray(int n)
    {
        return new int[n];
    }
}