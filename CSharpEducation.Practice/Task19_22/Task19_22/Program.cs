namespace Task19_22
{
    internal class Program


        /*22. Создайте и реализуйте метод, который будет принимать число по ссылке (ref) и менять его знак на противоположный. 
         * Метод должен принимать один аргумент и не возвращать ничего.*/
    {
        public static void Main(string[] args)
        {
            int elevent = 5;

            Foo(ref elevent);

            Console.WriteLine(elevent);

            Console.ReadLine();
        }

        public static void Foo(ref int x)
        { 
            x *= -1; 
        }

    }
}
