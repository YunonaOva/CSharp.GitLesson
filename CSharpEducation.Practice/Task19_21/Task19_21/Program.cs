using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task19_21
{
    internal class Program
    {
        /* 21. Создайте и реализуйте метод, который принимает на вход массив и инвертирует его. Вызовите его в методе Main. 
         * Исходный массив задайте сами. Инвертированный массив выведите на экран консоли.

         */


        public static void Main(string[] args)
        {
            int[] Array = { 1, 2, 3, 4 };

            InvertMassiv(Array);

            Console.WriteLine("Инвертированный массив:");

            foreach (int num in Array)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();

            static void InvertMassiv(int[] array)
            {
             for (int i = 0; i < array.Length / 2; i++)
                {
                    int temp = array[i];
                    array[i] = array[array.Length - 1 - i];
                    array[array.Length - 1 - i] = temp;
                }
            }
        } 
    }
}
