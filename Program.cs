using System;
using System.Collections.Generic;

namespace AddressBook
{/// <summary>
/// Template for Address Book Program
/// </summary>
     class Program
    {
        //UC2 to create contact in a address book
        public List<Contacts> personDetails = new List<Contacts>();


        private void AddPerson()
        {
            //creating object person from contacts class
            Contacts person = new Contacts();
            Console.WriteLine("Enter First Name");
            person.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            person.lastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            person.address = Console.ReadLine();
            Console.WriteLine("Enter City");
            person.city = Console.ReadLine();
            Console.WriteLine("Enter state");
            person.state = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            person.zip = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            person.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email Id");
            person.email = Console.ReadLine();
            personDetails.Add(person);
            Print(person);
        }

        //printing the address book details

        private void Print(Contacts person)
        {
            Console.WriteLine("-----Address book details-----");
            Console.WriteLine("First Name: " + person.firstName);
            Console.WriteLine("Last Name: " + person.lastName);
            Console.WriteLine("Address: " + person.address);
            Console.WriteLine("City: " + person.city);
            Console.WriteLine("State: " + person.state);
            Console.WriteLine("Zip: " + person.zip);
            Console.WriteLine("phone Number: " + person.phoneNumber);
            Console.WriteLine("Email: " + person.email);
        }




        static void Main(string[] args)
        {
            Console.WriteLine("-----Welcome to your Address Book-----");
            //creating object person1 of Program Class()
            Program person1 = new Program();
            person1.AddPerson();
            Console.ReadLine();

        }
    }
}
