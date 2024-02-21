// See https://aka.ms/new-console-template for more information

string a = "введите число от 1 до 5";
Console.WriteLine(a);
string answer = Console.ReadLine();

if (answer == "1")
{
    Console.WriteLine("Ужасно");
}
else if (answer == "2")
{
    Console.WriteLine("Неудовлетворительно");
}
else if (answer == "3")
{
    Console.WriteLine("Удовлетворительно");
}
else if (answer == "4")
{
    Console.WriteLine("Хорошо");
}
else 
{
    Console.WriteLine("Отлично");
}