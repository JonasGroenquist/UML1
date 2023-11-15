using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML1
{
    public class Order
    {
        private Customer _theCustomer;
        private Pizza _thePizza;
        private Employee _theEmployee;
        public string _date;
        public double _tax = 1.25;


        public Customer Customer { 
            get { return _theCustomer; }
        }
        public Employee Employee { 
            get { return _theEmployee; }
        }
        public Pizza Pizza { 
            get {  return _thePizza; }
        }

        public Order(Pizza pizza, Customer customer, Employee employee) 
        {
            _theCustomer = customer;
            _thePizza = pizza;
            _theEmployee = employee;

        }

        public double CalculateTotalPrice()
        {
            return (Pizza.Cost*_tax)+40;

        }

        public override string ToString()
        {
            return $"{_thePizza.ToString()}\n Customer: {_theCustomer.ToString()}\n Order was accepted by {_theEmployee.Name}\n Total order cost with delivery {CalculateTotalPrice()} kr,-";
        }


    }
}
