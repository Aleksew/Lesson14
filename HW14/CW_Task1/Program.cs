using System;

namespace CW_Task1
{
    class Program
    {
        //Создайте класс Element.В теле класса создайте три закрытых поля типа int и пользовательский конструктор.
        //Создайте класс TestClass, реализующий интерфейсы IEnumerable и IEnumerator.В конструкторе заполните коллекцию  5 элементами Element. 
        //Реализуйте весь необходимый функционал для использования цикла foreach с данной коллекцией.
        //В методе Main выполните перебор элементов экземпляра TestClass и вывод на экран значений его полей с помощью цикла foreach - два раза. (Без использования yield)

        static void Main(string[] args)
        {
            var arr = new TestClass();
            foreach (Element item in arr)
            {
                Console.WriteLine($"{item.Value1}, {item.Value2}, {item.Value3}");
            }

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Добавление");

            arr.Add(new Element(61, 62, 63));

            foreach (Element item in arr)
            {
                Console.WriteLine($"{item.Value1}, {item.Value2}, {item.Value3}");
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Обращение по индексу");
            Console.WriteLine($"{arr.GetOnTheIndex(4).Value1}, {arr.GetOnTheIndex(4).Value2},{arr.GetOnTheIndex(4).Value3}");

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Удаление");
            arr.Remove(2);

            foreach (Element item in arr)
            {
                Console.WriteLine($"{item.Value1}, {item.Value2}, {item.Value3}");
            }
        }
    }
}
