using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void MusteriSilme(Customer customer)
        {
            Console.WriteLine("Müşteri silindi =" + " " + customer.Name + customer.LastName);
        }
        public void MusterEkle(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi =" + " " + customer.Name + customer.LastName);
        }
        public void MusteriListele(Customer customer)
        {
            Console.WriteLine("Müşteri Listelendi =" + " " + customer.Name + customer.LastName);
        }
    }
}
