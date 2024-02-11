using System;

public struct Birthday
{
    private DateTime birthDate;

    public Birthday(DateTime date)
    {
        birthDate = date;
    }

    public void SetBirthDate(DateTime date)
    {
        birthDate = date;
    }

    public DayOfWeek DayOfWeekOfBirth()
    {
        return birthDate.DayOfWeek;
    }

    public DayOfWeek DayOfWeekInYear(int year)
    {
        DateTime nextBirthday = new DateTime(year, birthDate.Month, birthDate.Day);
        return nextBirthday.DayOfWeek;
    }

    public int DaysUntilBirthday()
    {
        DateTime today = DateTime.Today;
        DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);

        if (nextBirthday < today)
            nextBirthday = nextBirthday.AddYears(1);

        return (nextBirthday - today).Days;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Birthday birthday = new Birthday(new DateTime(1990, 4, 1));

        Console.WriteLine("День недели рождения: " + birthday.DayOfWeekOfBirth());
        Console.WriteLine("День недели рождения в 2025 году: " + birthday.DayOfWeekInYear(2025));
        Console.WriteLine("Дней до дня рождения: " + birthday.DaysUntilBirthday());

        Console.ReadLine();
    }
}