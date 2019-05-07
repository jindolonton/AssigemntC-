using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment5
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            string name;
            string phone;
            Boolean flag = false;
            do
            {
                Console.WriteLine("PHONEBOOK MANAGEMENT SYSTEM:");

                Console.WriteLine("1. Insert Phone");

                Console.WriteLine("2. Remove Phone");

                Console.WriteLine("3. Update Phone");

                Console.WriteLine("4. Search Phone");

                Console.WriteLine("5. Exit");
                

                int luachon = int.Parse(Console.ReadLine());
                while (luachon < 0 || luachon > 4)
                {
                    Console.WriteLine("moi chon lai:");
                    luachon = int.Parse(Console.ReadLine());
                }
                switch (luachon)
                {
                    case 1:
                        name= inputName();
                        phone= inputPhone();
                        phoneBook.isertPhone(name, phone);
                        break;
                    case 2:
                        name = inputName();
                        phoneBook.removePhone(name);
                        break;
                    case 3:
                        name = inputName();
                        phone = inputPhone();
                        phoneBook.updatePhone(name, phone);
                        break;
                    case 4:
                        name = inputName();
                        phoneBook.searchPhone(name);
                        break;
                    case 5:
                        flag = true;
                        break;

                }

            } while (flag = false);
        }
        public static string inputName()
        {
            Console.WriteLine("Nhap ten:");
            return Console.ReadLine();
        }
        public static string inputPhone()
        {
            Console.WriteLine("Nhap SDT:");
            return Console.ReadLine();
        }
    }
}
