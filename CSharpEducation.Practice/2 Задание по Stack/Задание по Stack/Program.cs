namespace Задание_по_Stack
{
    internal class Program
    {
        /* Создайте класс Student. Добавьте в него два свойства Name и Age. Свойства должны быть доступны только для чтения. 
         * Инициализируйте их передачей значений в конструкторе. Можно использовать реализацию из других задач.
        В Program.Main создайте Stack студентов. Добавьте в него элементы программно, не запрашивая ничего у пользователя.
        Реализуйте поиск студента по имени и возрасту в стеке. 
        На входе: имя и возраст студента
        На выходе: объект типа Student. Если такого студента нет, то метод поиска должен вернуть null.
        Проверьте реализацию поиска в методе Main. Исходный стек после поиска должен содержать исходное количество элементов в том же порядке, в котором и был до поиска.

        */

        static void Main(string[] args)
        {
            Stack<Student> students = new Stack<Student>();

            students.Push(new Student(name: "Игорь", age: 18));
            students.Push(new Student(name: "Анна", age: 18));
            students.Push(new Student(name: "Ирина", age: 19));

            string poisk_Name = "Анна";
            int poisk_Age = 18;

            Student poisk = NewStudent(students, poisk_Name, poisk_Age);

            if (poisk != null)
            {
                Console.WriteLine($"Найден студент: {poisk.Name}, {poisk.Age} лет");
            }
            else
            {
                Console.WriteLine("Студент не найден - null");
            }

            static Student NewStudent(Stack<Student> students, string name, int age)
            {
                foreach (var student in students)
                {
                    if (student.Name == name && student.Age == age)
                    {
                        return student;
                    }
                }
                return null;
            }
            Console.ReadLine();
        }
    }
}
