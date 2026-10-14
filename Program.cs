using System;

namespace GeometryProject
{
    // Оголошення класу Point (Точка на площині)
    class Point
    {
        // Поля класу для збереження координат типу double
        public double X;
        public double Y;

        // Метод для виведення стану точки на екран
        public void DisplayInfo()
        {
            Console.WriteLine("Точка з координатами: (" + X + "; " + Y + ")");
        }

        // Домашнє завдання: метод, який обнуляє координати точки
        // (переносить її в початок координат)
        public void ResetToOrigin()
        {
            X = 0;
            Y = 0;
            Console.WriteLine("Координати обнулено (перенесено в початок координат).");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================================");
            Console.WriteLine("       ПРАКТИЧНЕ ЗАНЯТТЯ №2: СТВОРЕННЯ КЛАСУ 'ТОЧКА'     ");
            Console.WriteLine("=========================================================");
            Console.WriteLine();

            // Створення трьох точок у різних квадрантах
            
            // Точка 1: Перший квадрант (X > 0, Y > 0)
            Point p1 = new Point();
            p1.X = 5.5;
            p1.Y = 3.2;

            // Точка 2: Другий квадрант (X < 0, Y > 0)
            Point p2 = new Point();
            p2.X = -4.8;
            p2.Y = 7.1;

            // Точка 3: Четвертий квадрант (X > 0, Y < 0)
            Point p3 = new Point();
            p3.X = 2.9;
            p3.Y = -6.4;

            // Виклик методу виведення інформації для кожної точки
            Console.WriteLine("--- Початковий стан трьох точок ---");
            Console.Write("Точка 1: "); p1.DisplayInfo();
            Console.Write("Точка 2: "); p2.DisplayInfo();
            Console.Write("Точка 3: "); p3.DisplayInfo();
            Console.WriteLine("---------------------------------------------------------");

            // Тестування домашнього завдання: обнулення координат Точки 2
            Console.WriteLine("\n--- Тестування домашнього завдання (Обнулення Точки 2) ---");
            Console.Write("Стан Точки 2 до обнулення: ");
            p2.DisplayInfo();
            
            p2.ResetToOrigin(); // Виклик методу обнулення
            
            Console.Write("Стан Точки 2 після обнулення: ");
            p2.DisplayInfo();
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("\n✅ Програму успішно виконано!");
        }
    }
}
