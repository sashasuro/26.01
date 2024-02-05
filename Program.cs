using System;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            /// 1. Ввести две даты и определить количество дней между ними.
            ///
            DateTime now = DateTime.Now;
            DateTime d1 = new DateTime(2024, 2, 2);
            DateTime d2 = new DateTime(2024, 2, 7);
            TimeSpan dt = d2 - d1;
            Console.WriteLine(dt);

            ///
            /// 2. Определить, сколько дней осталось до конца месяца.
            ///
            Console.WriteLine(DateTime.DaysInMonth(now.Year, now.Month) - now.Day);

            ///
            /// 3. Ввести свою дату рождения. Определить:
            /// a). день недели, в котором вы родились;
            ///
            int day, month, year;
            Console.WriteLine("День: ");
            day = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Месяц: ");
            month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Год: ");
            year = Int32.Parse(Console.ReadLine());
            DateTime old = new DateTime(year, month, day);
            Console.WriteLine(old.DayOfWeek);

            ///
            /// b). порядковый номер дня рождения в году
            ///
            Console.WriteLine(old.DayOfYear);

            ///
            /// c). является ли ваш год рождения високосным;
            ///
            Console.WriteLine(DateTime.IsLeapYear(year));

            ///
            /// d). дату ближайшего дня рождения (формат вывода: среда, 11 января 2023);
            ///
            DateTime next_old = new DateTime(now.Year, old.Month, old.Day);
            if (next_old < old) { next_old = next_old.AddYears(1); }
            Console.WriteLine("Следуещее день рождения: " + next_old.ToString("dddd, dd MMMM yyyy"));

            ///
            /// e). количество полных лет;
            ///
            Console.WriteLine($"Тебе уже/будет {now.Year - year} годиков!");



            Console.ReadKey();
        }
    }
}
