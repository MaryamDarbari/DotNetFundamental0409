namespace DotNetFundamental0409
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your First Name");
            String Name = Console.ReadLine();
            Console.WriteLine("What is your Last Name");
            String FamilyName = Console.ReadLine();
            String FullName = Name + " " + FamilyName;
            Console.WriteLine("How old are you?");
            String AgeStr = Console.ReadLine();
            int Age = int.Parse(AgeStr);
            Console.WriteLine("What is your phone number?");
            String PhoneNumberStr = Console.ReadLine();
            int PhoneNumkber = int.Parse(PhoneNumberStr);
            Console.WriteLine("What is your card number?");
            String CardNumberStr = Console.ReadLine();
            int CardNumber = int.Parse(CardNumberStr);
            Console.WriteLine("What is your national identification number?");
            String IDStr = Console.ReadLine();
            int ID = int.Parse(IDStr);
            Console.WriteLine("Thanks" + " " + FullName);
            

        }
    }
}
