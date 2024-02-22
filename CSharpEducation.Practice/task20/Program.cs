// See https://aka.ms/new-console-template for more information

class program
{
// a) В методе Main создайте массив строк, содержащий имена студентов. Заполните его не менее чем 5-ю произвольными именами.

public static void Main(string[] args)
{
string [] study = new string[5];     // создала массив

for (int i = 0; i < study.Length; i++)
{
    study[i] = Console.ReadLine();
}
for (int i = 0; i < study.Length; i++)
{
    Console.WriteLine(study[i]);
}

}
}