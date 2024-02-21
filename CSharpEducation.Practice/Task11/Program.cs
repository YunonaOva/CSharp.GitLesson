// See https://aka.ms/new-console-template for more information


/*Напишите цикл следующего вида:

a) цикл for. Пусть он выводит в консоль значение своего же счётчика.*/

using System.ComponentModel.DataAnnotations;

for (int a = 0; a < 5; a++)
{
    Console.WriteLine($"цикл for: {a}");
}

// b) цикл while. Пусть он выводит в консоль значение своего же счётчика.//

int b = 10;
while (b > 0)
{
    b--;
    Console.WriteLine($"цикл while: {b}");
}

// с) цикл do while. Пусть он выводит в консоль значение своего же счётчика.//

int c = 5;
do 
{
    c--;
    Console.WriteLine($"цикл do while: {c}");
}
while (c >= 0);

//d) тоже самое, что и задание a), но счётчик должен идти в обратную сторону.//
for (int d = 5; d > 0; d--)
{
    Console.WriteLine($"цикл for: {d}");
}

//e) тоже самое, что и задание b), но счётчик должен идти в обратную сторону

int e = 0;
while (e < 10)
{
    e++;
    Console.WriteLine($"цикл while: {e}");
}

// f) тоже самое, что и задание c), но счётчик должен идти в обратную сторону.
int f = 0;
do 
{
    f++;
    Console.WriteLine($"цикл do while: {f}");
}
while (f <= 5);

/* g) цикл for, в котором у пользователя запрашиваются слова, 
затем выводится полная фраза, слова в которой разделены пробелами.*/

Console.WriteLine("введите количество слов - ");
int WordCount = int.Parse(Console.ReadLine());

string WordAll = "";
int g = 0;
for (g = 0 ; g < WordCount; g++)
{
    Console.WriteLine("введите одно слово - ");
    string Word = Console.ReadLine();
    WordAll += Word + " ";
}

Console.WriteLine(WordAll);

/*string v = "введите слово для приветствия - ";
string privet = Console.ReadLine();
string l = "введите слово Мир - ";
string word = Console.ReadLine();
Console.WriteLine(privet + ", " + word + "!");*/

/* h) цикл while, в котором у пользователя запрашиваются слова, 
затем выводится полная фраза, слова в которой разделены пробелами.*/

Console.WriteLine("введите количество слов - ");
int WordCount1 = int.Parse(Console.ReadLine());

string WordAll1 = "";
int h = WordCount1;
while (h > 0)
{
    h--;
    Console.WriteLine("введите одно слово - ");
    string Word1 = Console.ReadLine();
    WordAll1 += Word1 + " ";
}
Console.WriteLine(WordAll1);

/* i) цикл do while, в котором у пользователя запрашиваются слова, 
затем выводится полная фраза, слова в которой разделены пробелами.*/

Console.WriteLine("введите количество слов - ");
int WordCount2 = int.Parse(Console.ReadLine());

string WordAll2 = "";
int I1 = WordCount2;
do
{
    I1--;
    Console.WriteLine("введите одно слово - ");
    string Word2 = Console.ReadLine();
    WordAll2 += Word2 + " ";
}
while (I1 > 0);
Console.WriteLine(WordAll2);