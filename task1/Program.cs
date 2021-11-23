using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Классы ClassInt, ClassString, ClassDouble, ClassChar - наследники класса Class
            // Приведение classOne к ClassInt
            Class classOne = new ClassInt();
            classOne.SetValue(5, "Hello World", 5.06, 'c');
            if (classOne is ClassInt classInt)
            {
                classInt.SetValue(5, "Hello World", 5.06, 'c');
            }

            // Приведение classOne к ClassString
            classOne = new ClassString();
            if (classOne is ClassString classString)
            {
                classString.SetValue(5, "Hello World", 5.06, 'c');
            }

            // Приведение classOne к ClassDouble
            classOne = new ClassDouble();
            if (classOne is ClassDouble classDouble)
            {
                classDouble.SetValue(5, "Hello World", 5.06, 'c');
            }

            // Приведение classOne к ClassChar
            classOne = new ClassChar();
            if (classOne is ClassChar classChar)
            {
                classChar.SetValue(5, "Hello World", 5.06, 'c');
            }
            Console.ReadLine();
        }
    }
}
