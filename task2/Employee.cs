using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class Employee
    {

        public Employee(Worker firstWorker, string typeUser)
        {
            firstWorker.TypeUser = typeUser;

        }
        public Employee(Worker firstWorker, string typeUser, string password):this(firstWorker, typeUser)
        {

        }

    }
}
