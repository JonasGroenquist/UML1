using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML1
{
    public class Pizza
    {
        private string _name;
        private string _topping;
        private double _cost;

        public Pizza(string name, string topping, double cost)
        {
            _name = name;
            _topping = topping;
            _cost = cost;
        }
        public string Name
        {
            get { return _name; }
        }
        public string Topping
        {
            get { return _topping; }
        }
        public double Cost
        {
            get { return _cost; }
        }

        public override string ToString()
        {
            return $"Pizza {Name} \n Topping: {Topping} \n {Cost} kr,-";
        }
    }
}
