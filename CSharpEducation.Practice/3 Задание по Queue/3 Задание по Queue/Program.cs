namespace _3_Задание_по_Queue
{
    internal class Program
    {
        /* Создайте класс Student. 
         * Добавьте в него два свойства Name и Age. 
         * Свойства должны быть доступны только для чтения. 
         * Инициализируйте их передачей значений в конструкторе. 
         * 
            В Program.Main создайте Queue со студентами.
            Там же реализуйте меню
	        “Добавить студента в очередь" – добавить студента в Queue со студентами.
            “Убрать следующего в очереди студента” – получить следующего в очереди студента и убрать его из очереди.
            “Узнать, кто следующий в очереди” – посмотреть кто следующий в очереди без извлечения из неё.*/



        static void Main(string[] args)
        {
            Queue<Student> SpisokStudents = new Queue<Student>();

            int p_menu;

            do
            {
                Console.WriteLine("Меню: ");
                Console.WriteLine("1. Добавить студента.");
                Console.WriteLine("2. Убрать следующего в очереди студента.");
                Console.WriteLine("3. Узнать, кто следующий в очереди.");
                Console.WriteLine("0. Выход.");
                Console.WriteLine();
                Console.Write("Введите пункт из меню: ");

                p_menu = int.Parse(Console.ReadLine());

                if (p_menu == 1)
                {
                    Console.Write("Введите имя студента: ");
                    string name = Console.ReadLine();

                    Console.Write("Введите возраст студента: ");
                    int age = int.Parse(Console.ReadLine());

                    SpisokStudents.Enqueue(new Student(name, age));

                    Console.WriteLine();
                }
                else if (p_menu == 2)
                {
                    if (SpisokStudents.Count == 0)
                    {
                        Console.WriteLine("Список студентов пуст.");
                    }
                    else
                    {
                        Console.WriteLine();

                        Console.Write(" Убрать следующего в очереди студента. ");

                        SpisokStudents.Dequeue();
                    }

                    Console.WriteLine();
                }
                else if (p_menu == 3)
                {
                    if (SpisokStudents.Count == 0)
                    {
                        Console.WriteLine("Список студентов пуст.");
                    }
                    else
                    {
                        Print(SpisokStudents);
                    }
                    Console.WriteLine();
                }
                else
                    Console.WriteLine("Введите еще раз пункт из меню.");
                Console.WriteLine();

            }
            while (p_menu != 0);


        }
        private static void Print(Queue<Student> array)
        {
            foreach (var x in array)
            {
                Console.WriteLine($"Имя: {x.Name}, Возраст: {x.Age}");
            }
        }

    }
}