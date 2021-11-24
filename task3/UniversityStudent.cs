using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    class UniversityStudent : Person
    {
        public void SetInfo(string firstName, string secondName, int age, string faculty, string group)
        {
            base.SetInfo(firstName, secondName, age);
            base.Faculty = faculty;
            base.Group = group;
        }
        public new void GetInfo()
        {
            Console.WriteLine("University student");
            base.GetInfo();
            Console.WriteLine($"Faculty: {base.Faculty}\n" +
                $"Group: {base.Group}");
        }
    }
}
