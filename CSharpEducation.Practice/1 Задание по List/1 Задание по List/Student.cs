using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _1_Задание_по_List

    /* a) Создайте класс Student. 
     * Добавьте в него два свойства Name и Age. 
     * Свойства должны быть доступны только для чтения. 
     * Инициализируйте их передачей значений в конструкторе.*/

{
     public class Student
     {
         public string name { get; }
         public int age { get; }

         public Student(string name, int age)
         {
             this.name = name;
             this.age = age;
         }

     }
}
