using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_по_Stack
{
    /* Создайте класс Student. 
     * Добавьте в него два свойства Name и Age. 
     * Свойства должны быть доступны только для чтения. 
     * Инициализируйте их передачей значений в конструкторе.*/

    public class Student
    {
        public string Name { get; }
        public int Age { get; }

        public Student(string name, int age)
        {
             this.Name = name;
             this.Age = age;
        }
    }
}

