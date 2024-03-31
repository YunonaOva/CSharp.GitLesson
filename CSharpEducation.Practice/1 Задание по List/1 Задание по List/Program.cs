using System.Security.Cryptography.X509Certificates;

namespace _1_Задание_по_List
{
    internal class Program

    // b) В Program.Main создайте список и студентов.

    {
        static void Main(string[] args)
        {
            List<Student> SpisokStudent = new List<Student>();

            int p_menu;

            do
            {
                Console.WriteLine("Меню: ");
                Console.WriteLine("1. Добавить студента.");
                Console.WriteLine("2. Удалить студента.");
                Console.WriteLine("3. Вывести список студентов.");
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

                    SpisokStudent.Add(new Student(name, age));

                    Console.WriteLine();
                }
                else if (p_menu == 2)
                {
                    if (SpisokStudent.Count == 0)
                    {
                        Console.WriteLine("Список студентов пуст.");
                    }
                    else
                    {
                        Print(SpisokStudent);
                    }
                    Console.WriteLine();

                    Console.Write("Выберите студента, чтобы удалить: ");

                    string delet_name = Console.ReadLine();

                    for (int i = 0; i < SpisokStudent.Count; i++)
                    {
                        if (SpisokStudent[i].name == delet_name)
                        {
                            SpisokStudent.RemoveAt(i);
                        }
                    }


                    Console.WriteLine();
                }
                else if (p_menu == 3)
                {
                    if (SpisokStudent.Count == 0)
                    {
                        Console.WriteLine("Список студентов пуст.");
                    }
                    else
                    {
                        Print(SpisokStudent);
                    }
                    Console.WriteLine();
                }
                else
                    Console.WriteLine("Введите еще раз пункт из меню.");
                Console.WriteLine();

            }
            while (p_menu != 0);


        }
        private static void Print(List<Student> array)
        {
            foreach (var x in array)
            {
                Console.WriteLine($"Имя: {x.name}, Возраст: {x.age}");
            }
        }

    }
}

