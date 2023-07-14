using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_LINQ
{
    public class AddressBookMain
    {
        public void TopRecords(List<Contacts> contacts)
        {
            var result = (from contact in contacts
                          orderby contact.FirstName descending
                          select contact);
            foreach(var data in result)
            {
                Console.WriteLine($"FirstName:- {data.FirstName} \t LastName:- {data.LastName} \t Address:- {data.Address} \t City:- {data.City} \t {data.State} \t Zip:- {data.ZIP} \t PhoneNumber:- {data.PhoneNumber} \t Email:- {data.Email}");
                Console.WriteLine("");
            }
        }
        public void SkipRecords(List<Contacts> contacts)
        {
            var result = (from contact in contacts 
                          orderby contact.FirstName descending
                          select contact).Skip(3);
            foreach(var data in result)
            {
                Console.WriteLine($"FirstName:- {data.FirstName} \t LastName:- {data.LastName} \t Address:- {data.Address} \t City:- {data.City} \t {data.State} \t Zip:- {data.ZIP} \t PhoneNumber:- {data.PhoneNumber} \t Email:- {data.Email}");
                Console.WriteLine("");
            }
        }
        public void GetRecords(List<Contacts> contacts)
        {
            var result = (from contact in contacts
                          select contact);
            foreach(var data in result)
            {
                Console.WriteLine($"FirstName:- {data.FirstName} \t LastName:- {data.LastName} " +
                                    $"\t PhoneNumber:- {data.PhoneNumber}");
            }
        }
    }
}
