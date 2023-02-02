using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11
{
    internal class User
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public RegistrationMonth RegistrationMonth { get; set; }

        public string PIN
        {
            get
            {
                    return pin;
            }
            set
            {
                if (value.LenghtIs7())
                {
                    pin = value;
                }
                else
                {
                    throw new Exception("PIN length must be 7 and all letters must be CAPITALIZED");
                }
            }
        }

        private string pin;

        public User(string name, string surname, RegistrationMonth registrationMonth, string pin)
        {
            Name = name;
            Surname = surname;
            RegistrationMonth = registrationMonth;
            PIN = pin;

        }

        public void GetDetails()
        {
            Console.WriteLine($"{Name}, {Surname}, {RegistrationMonth}, {pin}");
        }



    }
    public enum RegistrationMonth
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }









}
