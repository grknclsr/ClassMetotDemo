using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 01;
            customer.Name = "Gürkan";
            customer.Surname = "Çalışır";
            customer.Age = 20;

            Customer customer2 = new Customer();
            customer2.Id = 02;
            customer2.Name = "Ahmet";
            customer2.Surname = "Sarı";
            customer2.Age = 21;

            Customer customer3 = new Customer();
            customer3.Id = 03;
            customer3.Name = "Hikmet";
            customer3.Surname = "Köfte";
            customer3.Age = 22;

            Customer[] customers = new Customer[] { customer2, customer, customer3 };


            foreach (var custom in customers)
            {
                Console.WriteLine("Id: " + custom.Id + "\n Name: " + custom.Name + "\n Surname: " + custom.Surname + "\n Age: " + custom.Age);
                Console.WriteLine("**********************************");

            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Delete();
            customerManager.Update();
            customerManager.List();


        }
    }
}
