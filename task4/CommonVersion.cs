using System;
using System.Collections.Generic;
using System.Text;

namespace task4
{
    // Работа бесплатной версии
    class CommonVersion
    {
        private int _side1;
        private int _side2;
        private double _side3;
        private double _perimeter;

        protected int Side1
        {
            get
            {
                return _side1;
            }
            set
            {
                _side1 = value;
            }
        }
        protected int Side2
        {
            get
            {
                return _side2;
            }
            set
            {
                _side2 = value;
            }
        }
        protected double Side3
        {
            get
            {
                return _side3;
            }
            set
            {
                _side3 = value;
            }
        }

        public void AboutVersion()
        {
            Console.WriteLine("---------- ---------- ----------\n\n" +
                "Бесплатная версия\n" +
                "Вы можете расчитать периметр прямоугольного треугольника;\n" +
                "Для этого Вам необходимо ввести значения катетов\n" +
                "Вводите целые значения\n");
        }
        public void GetSides()
        {
            Console.Write("Введите значение первого катета: ");
            string text = Console.ReadLine();
            Side1 = Int32.Parse(text);

            Console.Write("Введите значение второго катета: ");
            text = Console.ReadLine();
            Side2 = Int32.Parse(text);
        }
        public void CalculatePerimeter()
        {
            Side3 = Math.Sqrt(Math.Pow(Side1,2) + Math.Pow(Side2,2));
            _perimeter = Side1 + Side2 + Side3;
        }
        public virtual void GetResult()
        {
            Console.WriteLine("\nРезультат работы программы:\n" +
                $"Стороны треугольника: {Side1}, {Side2}, {Side3}\n" +
                $"Периметр: {_perimeter}");
        }
    }
}
