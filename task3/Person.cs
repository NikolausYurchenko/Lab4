using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace task3
{
    class Person
    {

        public int Age { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Grade { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }

        public void SetInfo(string firstName, string secondName, int age)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
        }
        public void GetInfo()
        {
            Console.WriteLine($"First name: {FirstName}\n" +
                $"Second name: {SecondName}\n" +
                $"Age: {Age}");
        }
        public void PrintToDebug()
        {
            Debug.WriteLine($"Age: {Age}\n" +
                $"FirstName: {FirstName}\n" +
                $"SecondName: {SecondName}\n" +
                $"Grade: {Grade}\n" +
                $"Group: {Group}\n" +
                $"Faculty: {Faculty}\n");
        }
    }
}
