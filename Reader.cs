using System;

class Reader : Person
{
    public Reader(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
    }

    public void ReadBook(Library library, string bookTitle)
    {
        if (library.HasBook(bookTitle))
        {
            Console.WriteLine($"Reader {FirstName} {LastName} прочитал книгу \"{bookTitle}\".");
        }
        else
        {
            Console.WriteLine($"Книга \"{bookTitle}\" не найдена.");
            }
        }
    }
