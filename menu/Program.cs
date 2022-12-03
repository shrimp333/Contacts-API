using System;
using contactsLib;
namespace ContactApp
{
    class Program
    {
        public static ContactLink link = new ContactLink();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please select a menu item (1-4)");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1. Add Record\n2. Delete Record\n3. Print\n4. Exit");
                string? selection = Console.ReadLine();

                if (selection == "1")
                {
                    AddRecord();
                }
                if (selection == "2")
                {
                    DeleteRecord();
                }
                if (selection == "3")
                {
                    PrintRecord();
                }
                if (selection == "4")
                {
                    Environment.Exit(0);
                }
            }
        }

        static void AddRecord()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Add Record Section\n---------------------------------");
            Console.WriteLine("To start, please enter the Contact's Identification Number");
            string cid = Console.ReadLine();
            Console.WriteLine("Please enter the Contact's First Name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the Contact's Phone Number");
            string number = Console.ReadLine();            
            Contact contact = new Contact(cid,name,number);
            link.get().AddContact(contact);
            Console.WriteLine("Contact Added\nPress any key to continue");
            Console.ReadKey();
        }

        static void DeleteRecord()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Delete Record Section\n------------------------------------");
            Console.WriteLine("To start, please enter the Contact's Identification Number");
            int index = int.Parse(Console.ReadLine());
            link.get().DeleteContact(index);
            Console.WriteLine("Contact Deleted");
            Thread.Sleep(2000);
        }

        static void PrintRecord()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Print Record Section\n-----------------------------------");
            Console.WriteLine("To start, please enter the Contact's Identification Number");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(link.get().ConvertToString()[index]);
        }


    }

}