namespace Task19_23
{
    internal class Program
    {
        /*Создайте и реализуйте метод, который будет принимать два числа и менять их значения местами. 
         * Вызовите метод в Main.*/

        static void Main(string[] args)
        {
            int value1 = 5;
            int value2 = 15;

            Console.WriteLine("Элемент 1 до изменений: " + value1);
            Console.WriteLine("Элемент 2 до изменений: " + value2);

            ChangeElement(ref value1, ref value2);

            Console.WriteLine("Элемент 1 после изменений: " + value1);
            Console.WriteLine("Элемент 2 после изменений: " + value2);

        }

        static void ChangeElement(ref int value1, ref int value2)
        { 
         int temp = value1;
         value1 = value2;
         value2 = temp;

        }
    }
}
