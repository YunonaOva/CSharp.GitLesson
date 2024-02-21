// See https://aka.ms/new-console-template for more information
//a) Нарисуйте прямоугольный треугольник звёздочками. Чтобы высоту треугольника можно было задавать программно.//

Console.WriteLine("введите максимальное кол-во звездочек в строке - ");
int star = int.Parse(Console.ReadLine());
int i = 0;
int k = 0;
char sum = '*';
char Sum = '*';

for (i = 0; i < star; i++)
{
        for (k = 0; k < i; k++)
        {
            Console.Write(Sum);
        }
    Console.WriteLine(sum);
}

/* b) *
     **
    ***
   ****
и тд */

int n = 5;
char symbol = '0';
char space = ' ';
string outputString = string.Empty; // ""
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - (i + 1); j++)
    {
        Console.Write(space);
    }
    for (int j = 0; j < i + 1; j++)
    {
        Console.Write(symbol);
    }
    Console.WriteLine();
}



/* c) Дайте возможность задавать символ для отрисовки программно. Т.е. вместо звёздочки может быть любой символ.*/

Console.WriteLine("введите максимальное кол-во символов в строке - ");
int Star1 = int.Parse(Console.ReadLine());
int I = 0;
int K = 0;
Console.WriteLine("введите символ в строке - ");
char simbol = char.Parse(Console.ReadLine());
char sum1 = simbol;
char Sum1 = simbol;

for (I = 0; I < Star1; I++)                        
{
        for (K = 0; K < I; K++)
        {
            Console.Write(Sum1);
        }
    Console.WriteLine(sum1);
}