using System;

public class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;

    public Person(string firstName, string lastName, int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        Age = age;
    }

    public string FirstName => _firstName;
    public string LastName => _lastName;
    public int Age
    {
        get => _age;
        private set
        {
            if (value < 0)
                throw new ArgumentException("Возраст должен быть больше 0");
            _age = value;
        }
    }
}

