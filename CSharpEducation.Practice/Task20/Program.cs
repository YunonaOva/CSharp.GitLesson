// See https://aka.ms/new-console-template for more information
namespace Task20
{
    class program
    {
    // 25_a) В методе Main создайте массив строк, содержащий имена студентов. Заполните его не менее чем 5-ю произвольными именами.

        public static void Main(string[] args)
        {
            string [] study = new string[5];     // создала массив

            for (int i = 0; i < study.Length; i++)
            {
                Console.Write("Ввидите имена студента " + (i + 1) + " :");
                study[i] = Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("Список имен студентов: ");

            SpisokStudy(study);

            Console.WriteLine();

            Console.WriteLine("Введите имя нового студента");
            string newstudy = Console.ReadLine();

            Console.WriteLine("Список имен с новым студентом: ");

            Insert(ref study, newstudy, 2);

            Console.WriteLine("Проверяем наличие студента в списке: ");

            string name1 = "Аня";
            Poisk(study, name1);
            Console.WriteLine(Poisk(study, name1));


            Console.ReadLine();




        }

        // 25_b) Напишите метод для вывода на экран всех имён студентов из массива.

        public static void SpisokStudy(string [] spisok)
        {
            for (int i = 0; i < spisok.Length; i++)
            {
                Console.WriteLine(spisok[i]);
            }

        }

        // 25_c) Напишите метод для добавления нового студента в группу. Метод должен принимать имя нового студента в качестве аргумента.

        static void Insert (ref string[] array, string value, int index) 
        {
        string [] newArray = new string[array.Length + 1]; // создала новый массив на +1 индекс

        newArray[index] = value;                    // по индексу джобавляю элемент

        for (int i = 0; i < index; i++)             
            {
                newArray[i] = array[i];
            }
        for (int i = index; i<array.Length; i++) 
            {
                newArray[i+1] = array[i];
            }
        array = newArray;

            for (int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine(array[i]);
            }
         

        }


        /* 25 d) Напишите метод для проверки находится ли студент в списке. 
         * Метод должен принимать через аргумент имя студента и признак того, есть ли студент в списке.*/



        static string Poisk(string[] array, string _name) 
        {
        for (int i = 0;i < array.Length;i++) 
            {
                if (array[i] == _name)
                {
                    return "Студент найден: " + array[i];
                }

            }
            return "Студента с именем " + _name + " в списке нет!";





        }
    }
}
