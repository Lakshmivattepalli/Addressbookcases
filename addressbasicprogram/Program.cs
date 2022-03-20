using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createContact
{
    class CreateContact
    {
        string FirstName, LastName, Address, City, State, Email;
        int ZipCode;
        long PhoneNo;
        public void Create_Contact()
        {
            Console.Write("Enter the First Name : ");
            FirstName = Console.ReadLine();

            Console.Write("Enter the Last Name : ");
            LastName = Console.ReadLine();

            Console.Write("Enter the Address : ");
            Address = Console.ReadLine();

            Console.Write("Enter the City : ");
            City = Console.ReadLine();

            Console.Write("Enter the State : ");
            State = Console.ReadLine();

            Console.Write("Enter the ZipCode : ");
            ZipCode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Phone Number : ");
            PhoneNo = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter Your Email ID : ");
            Email = Console.ReadLine();
        }

        public void DisplayContact()
        {
            Console.WriteLine("\n .................................... \n");
            Console.WriteLine(" First Name : " + FirstName + "\n Last name : " + LastName + "\n Address : " + Address +
                "\n City : " + City + "\n State : " + State + "\n ZipCode : " + ZipCode +
                "\n Phone Number : " + PhoneNo + "\n Email ID : " + Email);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program ");
            CreateContact obj = new CreateContact();
            obj.Create_Contact();
            obj.DisplayContact();
            CreateContact newContact = new CreateContact();
            newContact.DisplayContact();

            Console.ReadLine();
        }
    }
}