namespace hw11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1= new User("Name1", "Surname1", RegistrationMonth.December, "AG00012");
            User user2 = new User("Name2", "Surname2", RegistrationMonth.November, "1234KN2");
            User user3 = new User("Name3", "Surname3", RegistrationMonth.August, "AND02FD");
            User user4 = new User("Name4", "Surname4", RegistrationMonth.July, "FJVZN1D");
            User user5 = new User("Name5", "Surname5", RegistrationMonth.October, "LV234JA");

            user1.GetDetails();
            user2.GetDetails();
            user3.GetDetails();
            user4.GetDetails();
            user5.GetDetails();

        }
    }
}