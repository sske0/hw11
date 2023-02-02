using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11
{
    internal class User
    {
       
        public string Name{ get; set; }
        public string Surname { get; set; }
        public RegistrationMonth RegistrationMonth { get; set; }

        public string PIN
        {
            get
            {
                if (pin.LenghtIs7())
                    return pin;
                else
                    throw new Exception("PIN lenght must be 7 and all letters must be CAPITALIZED");
            }
            set
            {
                pin = value;
            }
        }

        private string pin;

        public User(string Name, string Surname, RegistrationMonth RegistrationMonth, string PIN) 
        {
            this.Name = Name;
            this.Surname = Surname;
            this.RegistrationMonth = RegistrationMonth;
            this.PIN = PIN;
            
        }

        public void GetDetails()
        {
            Console.WriteLine($"{Name}, {Surname}, {RegistrationMonth}, {PIN}");
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
