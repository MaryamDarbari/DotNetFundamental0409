using System.ComponentModel.Design;

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
            if (!(Age>=0 && Age<=100)) {
                Console.WriteLine("Please enter a valid number!"); return;
            }
            Console.WriteLine("What is your phone number?");
            String PhoneNumberStr = Console.ReadLine();
            long PhoneNumber = long.Parse(PhoneNumberStr);//In Estefade ei nadare

            if (PhoneNumberStr.Length == 11)
            {


            }
            else
            {
                Console.WriteLine("Your phone number is invalid");
                return;
            }



            string CardNumberStr = "";
            while (!(CardNumberStr.Length == 16))
            {
                Console.WriteLine("What is your Card Number?");
                CardNumberStr = Console.ReadLine();
                if (!(CardNumberStr.Length == 16)) 
                {
                    Console.WriteLine("Please Enter a Valid Card Number");
                    

                }
                else
                {
                    
                }
            }

                
            String IDStr = "";

            while (!(IDStr.Length <= 18 && IDStr.Length>=9))
            {
                Console.WriteLine("What is your national identification number?");
                IDStr = Console.ReadLine();
                if ((!(IDStr.Length <= 18 && IDStr.Length >= 9)))
                {
                    Console.WriteLine("Please enter a valid number");
                }
                else if (IDStr.Length == 9)
                {
                    Console.WriteLine("United States");
                }
                else if (IDStr.Length == 12)
                {
                    Console.WriteLine("India");
                }
                else if (IDStr.Length == 11)
                {
                    Console.WriteLine("Brazil");
                }
                else if (IDStr.Length == 9)
                {
                    Console.WriteLine("United Kingdom");
                }
                else
                {
                    Console.WriteLine("Unknown");
                }
            }
          
            Console.WriteLine("Thanks" + " " + FullName);


        }
    }
}