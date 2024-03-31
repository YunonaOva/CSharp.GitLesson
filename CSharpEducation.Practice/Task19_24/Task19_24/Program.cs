using System.Xml.Linq;

namespace Task19_24
{
    internal class Program
    {

        /* 24. Создайте и реализуйте метод, который будет принимать массив на вход убирать из него отрицательные числа и возвращать новый изменённый массив. 
         * Через out параметр возвращать количество удалённых символов.*/

        static void Main(string[] args)
        {
            int[] Massiv = { 1, 2, 3, -5, -15, 10 };

            for (int i = 0; i < Massiv.Length; i++)
            {
                Console.WriteLine("Исходный массив " + Massiv[i]);
            }
            int element = 0;

            ArrayNew(Massiv, out element);

            Console.WriteLine("\nМассив без отрицательных чисел:");
           
            Console.WriteLine("Кол-во отрицательных чисел: " + element);


        }

        static void ArrayNew(int[] array, out int element)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }
        }
    }
}

