using System;
namespace T1806_Csharp
{
    public class PhoneBook:Phone
    {
        public List<PhoneNumber> PhoneList;
        public PhoneBook()
        {
            PhoneList = new List<PhoneNumber>();
        }
        public void insertPhone(String name, String phone)
        {
            foreach( List<PhoneNumber> list in PhoneList)
            {
                if (String.Compare(list.Name, name) == 0)
                {
                    string[] arrPhone = list.Phonenumber;
                    if (string.Compare(list.Phonenumber, phone) == 0)
                    {
                        return;
                    }
                    list.Phonenumber += ";" + phone;
                    return;

                }
                else
                {
                    PhoneList.Add(new PhoneNumber(name, phone));
                }
            }
        }
        public void removePhone(String name)
        {
            foreach(List<PhoneNumber> list in PhoneList)
            {
                if (string.Compare(list.Name, name) == 0)
                {
                    PhoneList.remove(list);
                }
            }

        }
        public void updatePhone(String name, String newphone)
        {
            foreach (List<PhoneNumber> list in PhoneList)
            {
                if (string.Compare(list.Name, name) == 0)
                {
                    list.Phonenumber = newphone;
                }
            }
        }
        public void searchPhone(String name)
        {
            foreach (List<PhoneNumber> list in PhoneList)
            {
                if (string.Compare(list.Name, name) == 0)
                {
                    Console.WriteLine("" + list.Name + "" + list.Phonenumber);
                    break;
                }
            }
        }
        public void displayPhoneBook()
        {

        }


    }

}

