// See https://aka.ms/new-console-template for more information

//5. Создайте массив строк. В цикле заполните его значениями, которые вводит пользователь.//


string [] words = new string[4]; // создала массив

int a = 0;

for (int i = 0; i < words.Length; i++)
{
    words[i] = Console.ReadLine();
}

for (int i = 0; i < words.Length; i++)
{
    Console.Write(words[i]);
}

