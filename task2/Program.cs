using System;

namespace task2
{
    class Program
    {
         
        static void Main(string[] args)
        {
            Worker firstWorker = new Worker();
            Employee student = new Employee(firstWorker, "Admin", "SomePassword");
            User user = new User();
            Admin admin = new Admin();
            Manager manager = new Manager();

            user.GetLogin();
            user.ShowInfo();
            user.ChangeInfo();

            admin.GetLogin();
            admin.ShowInfo();
            admin.ChangeInfo();

            manager.GetLogin();
            manager.ShowInfo();
            manager.ChangeInfo();

            Console.ReadLine();
        }
    }
}
