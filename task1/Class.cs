using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Class
    {
        // Создание переменных и своиств
        private int _a;
        private string _b;
        private double _c;
        private char _d;
        protected int A
        {
            get
            {
                return _a;
            }
            set
            {
                _a = value;
            }
        }
        protected string B
        {
            get
            {
                return _b;
            }
            set
            {
                _b = value;
            }
        }
        protected double C
        {
            get
            {
                return _c;
            }
            set
            {
                _c = value;
            }
        }
        protected char D
        {
            get
            {
                return _d;
            }
            set
            {
                _d = value;
            }
        }

        // Метод, который выводит на консоль все аргументы
        public void SetValue(int A, string B, double C, char D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            Console.WriteLine("Base Class");
            Console.WriteLine($"All arguments: {A}, {B}, {C}, {D}\n" +
                $"---------- ----------\n");
        }
    }
}
