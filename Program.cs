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
        public void display()
        {
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(address);
            Console.WriteLine(city);
            Console.WriteLine(state);
            Console.WriteLine(zip);
            Console.WriteLine(phoneNumber);
            Console.WriteLine(email);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your address book");

            Program pro = new Program("\nGaurav", "\nRawat", "civil line", "Indore", "M.P", "452001", 999, "iamgaurav@gmail.com");
            pro.display();
            Console.ReadLine();
        }
    }
}
