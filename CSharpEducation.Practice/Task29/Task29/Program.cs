namespace Task29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** Создайте в папке проекта файл Book.cs, и создайте в нём новый public класс Book. 
             * В класс добавьте static поле BooksCount, которое будет использоваться для подсчёта созданных книг. 
             * Создайте конструктор класса, в котором увеличивайте значение BooksCount на единицу. 
             * В класс добавьте поля, соответствующие названию книги, автору книги, год издания, жанр. 
             * Создайте несколько книг в классе Program. Выведите на экран консоли значение BooksCount.*/

            Book book1 = new Book(name_book: "Пиши, сокращай", author: "Максим Ильяхов", year: 2020, genre: "копирайтинг");

            Book book2 = new Book(name_book: "Пикник на обочине", author: "братья Стругацкие", year: 1972, genre: "фантастика");

            Console.WriteLine(Book.BooksCount);
            Console.ReadLine();
        }
    }
}
