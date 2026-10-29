using System;

public class Student
{
    private int _age;

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 6 || value > 100)
            {
                Console.WriteLine("Ошибка: возраст должен быть в диапазоне от 6 до 100!");
            }
            else
            {
                _age = value;
            }
        }
    }

    public string FullName
    {
        get { return $"{FirstName} {LastName}"; }
    }

    public Student(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Создание профилей студентов ---");

        // Студент 1
        Student student1 = new Student("Мария", "Кузнецова", 22);
        Console.WriteLine("Студент 1:");
        Console.WriteLine($"Привет, меня зовут {student1.FullName}, мне {student1.Age} лет.");
        Console.WriteLine($"Полное имя: {student1.FullName}");

        // Студент 2
        Student student2 = new Student("Дмитрий", "Волков", 17);
        Console.WriteLine("Студент 2:");
        Console.WriteLine($"Привет, меня зовут {student2.FullName}, мне {student2.Age} лет.");
        Console.WriteLine($"Полное имя: {student2.FullName}");

        // Студент 3
        Student student3 = new Student("Елена", "Морозова", 20);
        Console.WriteLine("Студент 3:");
        Console.WriteLine($"Привет, меня зовут {student3.FullName}, мне {student3.Age} лет.");
        Console.WriteLine($"Полное имя: {student3.FullName}");

        // Попытка задать некорректный возраст
        Console.WriteLine("--- Попытка изменить возраст на некорректное значение ---");
        student1.Age = 3;
        Console.WriteLine($"Текущий возраст студента 1: {student1.Age}");

        Console.ReadLine();
    }
}