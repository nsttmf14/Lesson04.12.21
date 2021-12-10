using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04._12._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laboratory Work 12.1");

            Console.Write("Введите баланс 1-ого счёта: ");
            double.TryParse(Console.ReadLine(), out double balance1st);
            BankAccount acc1 = new BankAccount(BankAccount.Type.Current, balance1st);

            Console.Write("Введите баланс 2-ого счёта: ");
            double.TryParse(Console.ReadLine(), out double balance2st);
            BankAccount acc2 = new BankAccount(BankAccount.Type.Current, balance2st);

            Console.WriteLine("\nacc1 != acc2: " + (acc1 != acc2));
            Console.WriteLine("acc1.Equals(acc2): " + acc1.Equals(acc2));

            Console.WriteLine("\nLaboratory Work 12.2");

            RationalNumbers r1 = new RationalNumbers(4, 8); //Числитель и знаменатель
            Console.WriteLine("\nr1 = " + r1);
            Console.WriteLine("r1.Equals(0,5): " + r1.Equals(0.5)); //Сравнение
            Console.WriteLine("r1 = " + ++r1); //Преинкремент
            Console.WriteLine($"{15.0 / 19} < {13.0 / 15}: {new RationalNumbers(17, 21) < new RationalNumbers(15, 19)}"); //Сравнение
            Console.WriteLine("Остаток деления r1 на 1/4: " + r1 % new RationalNumbers(1, 4)); //Остаток

            Console.WriteLine("\nHomework 12.1");
            ComplexNumbers c1 = new ComplexNumbers(10, -5);
            Console.WriteLine("\nc1 = 10 - 5i");
            ComplexNumbers c2 = new ComplexNumbers(1, 1);
            Console.WriteLine("c1 = 1 + i");
            Console.WriteLine("c1 + c2 = " + (c1 + c2));
            Console.WriteLine("c1 * c2 = " + (c1 * c2));
            Console.WriteLine("c1 == c2 ? " + (c1 == c2));
            Console.WriteLine("c1 != c2 ? " + (c1 != c2));

            Console.WriteLine("\nHomework 12.2");
            Books<Book> books = new Books<Book>();
            books.Add(new Book("451 градус по Фаренгейту", "Рэй Брэдбери", "PocketBook"));
            books.Add(new Book("Великий Гэтсби", "Френсис Скотт Фицджеральд", "ACT"));

            Console.WriteLine("\nLaboratory Work 13.1");
            Console.WriteLine(acc1.TypeOfAcc);

            Console.WriteLine("\nLaboratory Work 13.2");
            Console.WriteLine("\nacc1: " + acc1.ToString() + "\nacc2:" + acc2.ToString());

            Console.WriteLine("\nHomework 13.1");
            House house = new House();
            house.NumberOfHome = 10;
            house.Height = 35;
            house.FloorsCounter = 10;
            house.ApartmentsCounter = 228;
            house.EntrancesCounter = 10;
            Console.WriteLine(house.ToString());

            Console.WriteLine("\nHomework 13.2");
            House[] houses = new House[10];
            for (byte i = 1; i < 12; i++)
            {
                houses[i] = new House((float)i * 20, (byte)(i * 5), (int)i * 50, (byte)(i * 2)); //Создаём 10 зданий
            }
            Console.WriteLine(houses[5].NumberOfHome); //Пример вывода

        }
    }
}
