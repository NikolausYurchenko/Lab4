using System;
using System.Collections.Generic;
using System.Text;

namespace task4
{
    //Работа ограниченной версии
    class TrialVersion : CommonVersion
    {
        private double _area;

        protected double Area
        {
            get
            {
                return _area;
            }
            set
            {
                _area = value;
            }
        }

        public new void AboutVersion()
        {
            Console.WriteLine("---------- ---------- ----------\n\n" +
                "Триальная (ограниченная) версия\n" +
                "Вы можете расчитать периметр и площадь прямоугольного треугольника;\n" +
                "Для этого Вам необходимо ввести значения катетов\n" +
                "Вводите целые значения\n");
        }
        
        public void CalculateArea()
        {
            Area = (Side1 * Side2) *0.5;
        }
        public override void GetResult()
        {
            base.GetResult();
            Console.WriteLine($"Площадь: {Area}");
        }
    }
}
