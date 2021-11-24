using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolStudent studentOne = new SchoolStudent();
            UniversityStudent studentTwo = new UniversityStudent();

            //Вносим данные в экземпляры
            studentOne.SetInfo("Bob", "Peters", 15, "9A");
            studentTwo.SetInfo("John", "Smith", 20, "FIT", "S415");

            //Вывод на экран внесеных ранее данных
            studentOne.GetInfo();
            Console.WriteLine("----- ----- -----");
            studentTwo.GetInfo();

            //Вывод в дебаг свойств
            studentOne.PrintToDebug();
            studentTwo.PrintToDebug();
        }
    }
}
