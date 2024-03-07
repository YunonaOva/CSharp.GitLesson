// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        Person person = new Person();

        Console.WriteLine("возраст: " + person.age);
        Console.WriteLine("имя: " + person.name);
        Console.WriteLine("фамилия: " + person.family);
        Console.WriteLine("название компании: " + person.company_name);
        Console.WriteLine();

       Person person2 = new Person(_age: 14, _name:"Дмитрий", _family:"Привет", _company_name:"ЦУК");
    
        Console.WriteLine("возраст: " + person2.age);
        Console.WriteLine("имя: " + person2.name);
        Console.WriteLine("фамилия: " + person2.family);
        Console.WriteLine("название компании: " + person2.company_name);
        Console.WriteLine();
        

        Person person3 = new Person(_age: 16, _name:"Света");
    
        Console.WriteLine("возраст: " + person3.age);
        Console.WriteLine("имя: " + person3.name);
        Console.WriteLine("фамилия: " + person3.family);
        Console.WriteLine("название компании: " + person3.company_name);
        Console.WriteLine();
    }
}