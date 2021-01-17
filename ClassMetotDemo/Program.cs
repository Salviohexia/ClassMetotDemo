using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Name = "Berke", LastName = "Dogan", AccountNo = 45568, DateOfBirth = "26.08.1976", Gender = "Male" };
            Customer customer2 = new Customer { Name = "Mert", LastName = "Kaya", AccountNo = 68524, DateOfBirth = "07.10.1982", Gender = "Male" };
            Customer customer3 = new Customer { Name = "Lara", LastName = "Doğru", AccountNo = 73285, DateOfBirth = "16.08.1990", Gender = "Female" };
            Customer customer4 = new Customer { Name = "Ayşe", LastName = "Yılmaz", AccountNo = 65893, DateOfBirth = "03.04.1995", Gender = "Female" };

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.MusterEkle(customer2);
            customerManager.MusteriSilme(customer4);
            Console.WriteLine("___________________");
            customerManager.MusteriListele(customer1);
            customerManager.MusteriListele(customer2);
            customerManager.MusteriListele(customer3);


            Console.WriteLine(" ");
            

    
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name = " + customer.Name);
                Console.WriteLine("Last Name = " + customer.LastName);
                Console.WriteLine("Account No = " + customer.AccountNo);
                Console.WriteLine("Date of Birth = " + customer.DateOfBirth);
                Console.WriteLine("Gender = " + customer.Gender);
                Console.WriteLine("-------------------");
            }

            








        }
    }
}
