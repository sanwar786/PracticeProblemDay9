using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemDay9.AddressBook
{
    internal class CreateContactUC1
    {
        public static void AddContactDetails(string AddressBook, string BookName)
        {
            //Creating a contact with person details(UC1)
            Console.Write("Enter Your First Name : ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Your Last Name : ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Your Home Address : ");
            string address = Console.ReadLine();
            Console.Write("Enter Your City Name : ");
            string city = Console.ReadLine();
            Console.Write("Enter Your State Name : ");
            string state = Console.ReadLine();
            Console.Write("Enter Your Area Zip Code : ");
            int zip = int.Parse(Console.ReadLine());
            Console.Write("Enter Your Phone Number : ");
            long phoneNum = long.Parse(Console.ReadLine());
            Console.Write("Enter Your EmailId : ");
            string emailId = Console.ReadLine();

            //User Data Entry            
            AddressBook.AddContactDetails(firstName, lastName, address, city, state, zip, phoneNum, emailId, BookName);
            Console.ReadLine();
        }
    }
}
