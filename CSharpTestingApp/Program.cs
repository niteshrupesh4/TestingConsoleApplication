using System;


namespace CSharpTestingApp
{
    class Customer
    {
        string _firstName;
        string _lastName;
        public Customer() : this("firstname", "lastname") { }
        static Customer()
        {
            Console.WriteLine("Static constructor");
        }
        public Customer(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }
        public void Print()
        {
            Console.WriteLine("Customer full name {0} {1}",_firstName.ToUpper(),_lastName);
        }
        ~Customer()
        {

        }
    }
    class Program
    {
        static void Main()
        {
            string str = "test";
            Console.WriteLine(str.ToString());
            Console.ReadKey();
        }
        
    }
}
