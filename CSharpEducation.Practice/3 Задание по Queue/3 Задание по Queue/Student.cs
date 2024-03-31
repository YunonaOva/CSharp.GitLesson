using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Задание_по_Queue
{
            /* Создайте класс Student. 
             * Добавьте в него два свойства Name и Age. 
             * Свойства должны быть доступны только для чтения. 
             * Инициализируйте их передачей значений в конструкторе. */


    class Student
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