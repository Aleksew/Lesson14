using System;

namespace HW_Task1
{
    class Program
    {
        //Создайте класс MyClassCollection.В теле класса создайте открытый строковой массив на 10 элементов.Создайте методы GetEvenIndexValues() и GetOddIndexValues(), 
        //возвращающие IEnumerable.С помощью оператора yield реализуйте в телах методов механизм обращения к массиву строк и возврат всех значений, хранящихся по четному и нечетному индексу соответственно.
        //В методе Main создайте экземпляр класса MyClassCollection, заполните его внутренний массив и в циклах foreach обойдите получаемые сначала из GetEvenIndexValues() и потом из GetOddIndexValues() значения.

        static void Main(string[] args)
        {
            var myClassCollection = new MyClassCollection();

            myClassCollection.strArr = new string[] { "Один", "Два", "Три", "Четыре", "Пять", "Шесть", "Семь", "Восемь", "Девять", "Десять" };

            Console.WriteLine("Чётные");

            foreach (var item in myClassCollection.GetEvenIndexValues())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Не чётные");

            foreach (var item in myClassCollection.GetOddIndexValues())
            {
                Console.WriteLine(item);
            }
        }
    }
}
