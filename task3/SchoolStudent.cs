using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    class SchoolStudent : Person
    {
        public void SetInfo(string firstName, string secondName, int age, string grade)
        {
            base.SetInfo(firstName,secondName,age);
            base.Grade = grade;
        }
        public new void GetInfo()
        {
            Console.WriteLine("School student");
            base.GetInfo();
            Console.WriteLine($"Grade: {Grade}");
        }
    }
}
