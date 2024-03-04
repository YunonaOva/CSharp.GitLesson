// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        Person person = new Person();
        person.age = 15;
        person.name = "Дмитрий";

        if (person.CheckIsAdult())
        {
            Console.WriteLine(person.age);
            Console.WriteLine(person.name);
        }
        else
        {
            Console.WriteLine(person.name);
        }
       


    }
}