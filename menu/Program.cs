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
                Console.WriteLine("Please select a menu item (1-5)");
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
            string cid = Console.ReadLine();
            string name = Console.ReadLine();
            string number = Console.ReadLine();
            Contact contact = new Contact(cid,name,number);
            link.get().AddContact(contact);
        }

        static void DeleteRecord()
        {

        }

        static void PrintRecord()
        {
        }


    }

}