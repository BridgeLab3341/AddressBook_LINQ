﻿namespace AddressBook_LINQ
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Contacts> contacts = new List<Contacts>();
            AddressBookMain address=new AddressBookMain();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Option to Perform Operation\n1.Add Contact\n2.Display By Descending Order\n3.Skip Top 3 Records\n4.Get Records(FirstName,LastName and PhoneNumber)\n5.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        contacts.Add(new Contacts { FirstName = "Soma", LastName = "Shekar", Address = "Banglore", City = "Banglore", State = "Karnataka", ZIP = "563123", PhoneNumber = "7890165432", Email = "somu@email.com" });
                        contacts.Add(new Contacts { FirstName = "James", LastName = "Cameron", Address = "USA", City = "Mexico", State = "US", ZIP = "032145", PhoneNumber = "7890654321", Email = "james@email.com" });
                        contacts.Add(new Contacts { FirstName = "Jeevan", LastName = "Kumar", Address = "KR pura", City = "Bengaluru", State = "Karnataka", ZIP = "560054", PhoneNumber = "9065478321", Email = "jeevan@email.com" });
                        contacts.Add(new Contacts { FirstName = "Veena", LastName = "Kumari", Address = "Marathalli", City = "Bengaluru", State = "Karnataka", ZIP = "560065", PhoneNumber = "8906543217", Email = "veena@email.com" });
                        contacts.Add(new Contacts { FirstName = "Nan", LastName = "jeeva", Address = "Kadugodi", City = "Bengaluru", State = "Karnataka", ZIP = "560068", PhoneNumber = "7890632154", Email = "nan@email.com" });
                        Console.WriteLine("Contact Deatils In AddressBook");
                        Console.WriteLine("===============================");
                        foreach(var data in contacts)
                        {
                            Console.WriteLine($"FirstName:- {data.FirstName} \t LastName:- {data.LastName} \t Address:- {data.Address} \t City:- {data.City} \t {data.State} \t Zip:- {data.ZIP} \t PhoneNumber:- {data.PhoneNumber} \t Email:- {data.Email}");
                            Console.WriteLine(" ");
                        }
                        break;
                    case 2:
                        address.TopRecords(contacts);
                        break;
                    case 3:
                        address.TopRecords(contacts);
                        break;
                    case 4:
                        address.GetRecords(contacts);
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}