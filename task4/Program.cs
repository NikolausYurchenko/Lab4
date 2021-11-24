using System;

namespace task4
{
    class Program
    {

        /*Программа имеет 3 режим работы:
          Бесплатная версия: пользователь вводит 2 стороны прямоугольника (катеты) и программа высчитывает ТОЛЬКО периметр (а также гипотенузу)
          Ограниченная версия: программа высчитывает периметр и площадь
          Платная: программа высчитывает периметр, площадь, а также объем конуса, который образован вращением прямоугольника вокруг первого катета;
                   второй катет является высотой конуса*/
        static void Main(string[] args)
        {
            int a;
            CommonVersion commonVersion = new CommonVersion();
            TrialVersion trialVersion = new TrialVersion();
            ProVersion proVersion = new ProVersion();

            // Пользователь получает версию програмы в зависимости от наличия ключа продукта
            //       !!!!!!!!!!!!!!!!!!!!!!!!
            // Ключи доступа: К ограниченному режиму: 1234; К платному режиму: 4321
            ApplicationLicense access = new ApplicationLicense();
            access.AllowTrial();
            access.AllowPro();
            a = access.AllowCommon();

            //Проверяем какая версия у пользователя и реализуем её
            if (a == 0)
            {
                commonVersion.AboutVersion();
                commonVersion.GetSides();
                commonVersion.CalculatePerimeter();
                commonVersion.GetResult();
            }
            if (a == 1)
            {
                trialVersion.AboutVersion();
                trialVersion.GetSides();
                trialVersion.CalculatePerimeter();
                trialVersion.CalculateArea();
                trialVersion.GetResult();
            }
            if(a == 2)
            {
                proVersion.AboutVersion();               //Информация о версии
                proVersion.GetSides();                   //Получаем катеты от пользователя 
                proVersion.CalculatePerimeter();         //Расчёт периметра
                proVersion.CalculateArea();              //Расчёт площади
                proVersion.CalculateConeVolume();        //Расчёт объёма конуса
                proVersion.GetResult();                  //Вывод на экран результата
            }

            Console.ReadLine();
        }
    }
}
