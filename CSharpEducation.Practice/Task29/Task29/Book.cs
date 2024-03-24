using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task29
{
    public class Book             //Создайте в папке проекта файл Book.cs, и создайте в нём новый public класс Book. 
    {
        //* В класс добавьте поля, соответствующие названию книги, автору книги, год издания, жанр. 

        public string Name_book;

        public string Avtor;

        public int Years;

        public string Genre;


        public static int BooksCount = 0;    // В класс добавьте static поле BooksCount, которое будет использоваться для подсчёта созданных книг. 

        public Book (string name_book, string author, int year, string genre)         //Создайте конструктор класса, в котором увеличивайте значение BooksCount на единицу.
        {
        Name_book = name_book;
        Avtor = author;
        Years = year;
        Genre = genre;   
        
        BooksCount++;
        }



    }
}

