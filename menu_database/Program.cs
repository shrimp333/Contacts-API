using System;
using System.Net.Http.Headers;
namespace ContactApp
{
    class Program
    {
        public static string ApiServer = "localhost:5016";
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
            string uri = $"http://{ApiServer}/api/add?contactConstructor={cid},{name},{number}";
            Task<string> result = MakeApiRequest(uri);
            Console.WriteLine($"{result.Result}\nPress any key to continue");
            Console.ReadKey();
        }
        static void DeleteRecord()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Delete Record Section\n------------------------------------");
            Console.WriteLine("To start, please enter the Contact's Identification Number");
            string cid = Console.ReadLine();
            string uri = $"http://{ApiServer}/api/delete?cid={cid}";
            Task<string> result = MakeApiRequest(uri);
            Console.WriteLine($"{result.Result}\nPress any key to continue");
            Console.ReadKey();
        }
        static void PrintRecord()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Print Record Section\n-----------------------------------");
            Console.WriteLine("To start, please enter the Contact's Identification Number");
            string cid = Console.ReadLine();
            string uri = $"http://{ApiServer}/api/search?cid={cid}";
            Task<string> result = MakeApiRequest(uri);
            Console.WriteLine($"{result.Result}\nPress any key to continue");
            Console.ReadKey();
        }

        static async Task<string> MakeApiRequest(string uri)
        {
            using HttpClient client = new();
            string response = await client.GetStringAsync(uri);
            return response;
        }
    }

}