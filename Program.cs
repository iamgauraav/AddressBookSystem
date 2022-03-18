using System;

namespace AddressBook
{
    public class Program
    {
        //UC1 to create contact in a address book
        //declaring instance variable
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zip;
        public string email;
        public int phoneNumber;

        //Paeameterized constructor
        public Program(string firstName, string lastName, string address, string city, string state, string zip, int phoneNumber,string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your address book");
            Console.ReadLine();
        }
    }
}
