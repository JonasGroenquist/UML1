using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML1
{
    public class Employee
    {
        private int _id;
        private string _name;
        private string _email;
        private string _phone;
        private string _adress;
        private static int _counter = 0;

        public Employee(string name, string email, string phone, string adress)
        {
            _name = name;
            _email = email;
            _phone = phone;
            _adress = adress;
            _counter++; ;
            _id = _counter++;
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
        }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }


        public override string ToString()
        {
            return $"Employee: {Name}";
        }
    }
}
