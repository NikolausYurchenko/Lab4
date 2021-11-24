using System;
using System.Collections.Generic;
using System.Text;

namespace task4
{
    class ApplicationLicense
    {
        private string _trialKey = "1234"; //Номер ключа к ограниченной версии
        private string _proKey = "4321"; //Номер ключа к платной версии

        private int _a = 0; // переменная используется для корректного отображения бесплатного режима
        public int A
        {
            get
            {
                return _a;
            }
        }

        public string TrialKey
        {
            get
            {
                return _trialKey;
            }
        }
        public string ProKey
        {
            get
            {
                return _proKey;
            }
        }

        public void AllowTrial() // Метод запрашивает ключ к ограниченной версии
        {
            Console.WriteLine("Ограниченный режим");
            Console.Write("Введите номер ключа Trial:");
            string text = Console.ReadLine();
            if(text == TrialKey)
            {
                _a = 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("У Вас есть доступ к триальному режиму\n" +
                    "Попробуйте ввести номер ключа к режиму Pro\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                if(String.IsNullOrEmpty(text))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы не ввели номер ключа, попробуйте ввести номер ключа к режиму Pro;\n" +
                        "В доступе к режиму Trial отказано\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели неверный номер ключа, попробуйте ввести номер ключа к режиму Pro\n" +
                        "В доступе к режиму Trial отказано\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        public int AllowCommon() // Метод проверяет версию, если а = 0, версия бесплатная, если 1 - ограниченная, 2 - платная
        {
            if(_a == 0)
            {
                Console.WriteLine("Бесплатная версия");
                Console.WriteLine("У Вас есть доступ только к бесплатной версии\n");
            }
            return A;
        }

        public void AllowPro() // Метод запрашивает ключ к платной версии
        {
            Console.WriteLine("Платная версия");
            Console.Write("Введите номер ключа Pro:");
            string text = Console.ReadLine();
            if (text == ProKey)
            {
                _a = 2;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("У Вас есть доступ к режиму Pro\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                if (String.IsNullOrEmpty(text))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы не ввели номер ключа;\n"+
                        "В доступе к режиму Pro отказано\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели неверный номер ключа;\n" +
                        "В доступе к режиму Pro отказано\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

    }
}
