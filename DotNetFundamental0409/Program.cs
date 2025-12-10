namespace DotNetFundamental0409
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name");
            String Name = Console.ReadLine();
            Console.WriteLine("What is your last name");
            String FamilyName=Console.ReadLine();
            Console.WriteLine("How old are you?");
                String Age = Console.ReadLine();
            Console.WriteLine("What is your phone number?");
            String PhoneNumber = Console.ReadLine();
            Console.WriteLine("What is your card number?");
                String CardNumber = Console.ReadLine();
            Console.WriteLine("What is your national identification number?");
                String ID = Console.ReadLine();
            Console.WriteLine("Thanks "  +  Name);
            
        }
    }
}
