using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment5
{
    class PhoneBook:Phone
    {
        List<PhoneNumber> PhoneList;
       
        
        PhoneBook()
        {
            PhoneList = new List<PhoneNumber>();
        }

        
        public override void isertPhone(string name1, string phone1)
        {
            PhoneNumber phoneNumber = new PhoneNumber(name1, phone1);
            for(int i=0; i < this.PhoneList.Count; i++)
            {
                if (PhoneList[i].name.Equals(name1))
                {
                    string[] arrPhone = PhoneList[i].phone.Split(':');
                    for(int j = 0; j < arrPhone.Length; j++)
                    {
                        if (arrPhone[j].Equals(phone1))
                        {
                            return;
                        }

                    }
                    PhoneList[i].phone += ':' + phone1;
                    return;
                }
                PhoneList.Add(new PhoneNumber(name1, phone1));
                return;
            }
        }

        public override void removePhone(string name)
        {
            for (int i = 0; i < this.PhoneList.Count; i++)
            {
                if (PhoneList[i].name.Equals(name))
                {
                    this.PhoneList.Remove(PhoneList[i]);
                }
            }
        }

        public override void searchPhone(string name)
        {
            for (int i = 0; i < this.PhoneList.Count; i++)
            {
                if (PhoneList[i].name.Equals(name))
                {
                    Console.WriteLine("Name:" + this.PhoneList[i].name + "Phone: " + this.PhoneList[i].phone);
                    break;
                }
            }
        }

        public override void updatePhone(string name, string newphone)
        {
            for (int i = 0; i < this.PhoneList.Count; i++)
            {
                if (PhoneList[i].name.Equals(name))
                {
                    this.PhoneList[i].phone = newphone;
                }
            }
        }
    }
}
