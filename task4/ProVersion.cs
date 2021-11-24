using System;
using System.Collections.Generic;
using System.Text;

namespace task4
{
    //Работа платной версии
    class ProVersion : TrialVersion
    {
        private double _coneVolume;
        protected double ConeVolume
        {
            get
            {
                return _coneVolume;
            }
            set
            {
                _coneVolume = value;
            }
        }
        public new void AboutVersion()
        {
            Console.WriteLine("---------- ---------- ----------\n\n" +
                "Платная версия\n" +
                "Вы можете расчитать периметр и площадь прямоугольного треугольника\n" +
                "Платная версия даёт возможность расчёта объёма конуса\n" +
                "Для этого Вам необходимо ввести значения катетов\n" +
                "Первый катет берётся за радиус конуса, второй - за его высоту\n" +
                "Вводите целые значения\n");
        }
        public void CalculateConeVolume()
        {
            ConeVolume = (Math.PI * Math.Pow(Side1, 2) * Side2) / 3; 
        }
        public override void GetResult()
        {
            base.GetResult();
            Console.WriteLine($"Объем конуса: {ConeVolume}");
        }
    }
}
