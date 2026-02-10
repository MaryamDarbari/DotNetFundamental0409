using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace DotNetFundamental0409
{
    internal class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {
                Console.WriteLine("What is your First Name");
                String Name = Console.ReadLine();
                if (HamashHarfBashe(Name) && NullNabashe(Name))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid name");
                }
            }

            MagentaSubmitted();

            while (true)
            {
                Console.WriteLine("What is your family name?");
                String FamilyName = Console.ReadLine();
                if (HamashHarfBashe(FamilyName) && NullNabashe(FamilyName))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid Family Name.");
                }

            }
            MagentaSubmitted();


            while (true)
            {


                Console.WriteLine("How old are you?");
                String AgeStr = Console.ReadLine();

                if (!(HamashAdadBashe(AgeStr) && NullNabashe(AgeStr)))
                {
                    Console.WriteLine("Please enter a valid number!");

                }


                else if ((AgeStr.Length > 2))
                {
                    Console.WriteLine("Please enter a valid age!");

                }
                else
                {
                    break;
                }
            }
            MagentaSubmitted();
            while (true)
            {
                Console.WriteLine("What is your phone number?");
                String PhoneNumberStr = Console.ReadLine();


                if (!(PhoneNumberStr.Length == 11 && HamashAdadBashe(PhoneNumberStr) && NullNabashe(PhoneNumberStr)))
                {
                    Console.WriteLine("Please enter a valid phone number");


                }
                else
                {
                    break;

                }
            }
            MagentaSubmitted();

            string CardNumberStr = "";
            while (true)
            {
                Console.WriteLine("What is your Card Number?");
                CardNumberStr = Console.ReadLine();
                if (!(CardNumberStr.Length == 16 && HamashAdadBashe(CardNumberStr) && NullNabashe(CardNumberStr)))
                {
                    Console.WriteLine("Please Enter a Valid Card Number");


                }
                else
                {
                    break;
                }
            }

            MagentaSubmitted();


            while (true)
            {

                Console.WriteLine("What is your national identification number?");
                string IDStr = Console.ReadLine();
                if (!(IDStr.Length <= 18 && IDStr.Length >= 9&&HamashAdadBashe(IDStr)&&NullNabashe(IDStr)))
                {
                    Console.WriteLine("Please enter a valid identification number");
                }
                else if (IDStr.Length == 9)
                {
                    Console.WriteLine("United States");
                    
                   Ending();
                    break;

                }
                else if (IDStr.Length == 12)
                {
                    Console.WriteLine("India");
                    Ending();
                    break;
                }
                else if (IDStr.Length == 11)
                {
                    Console.WriteLine("Brazil");
                    Ending();
                    break;
                }
                else if (IDStr.Length == 9)
                {
                    Console.WriteLine("United Kingdom");
                    Ending();
                    break;
                }
                else
                {
                    Ending();
                    break;
                }
            }
           
        }
                

            
        
        public static bool HamashHarfBashe(string N)
        {
            foreach (char m in N)
            {
                if (char.IsLetter(m))
                {
                    return true;
                }
                
            }
            return false;
        }
        public static bool HamashAdadBashe(string N)
        {
            foreach (char m in N)
            {
                if (char.IsDigit(m))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool NullNabashe(string N)
        {
            if (string.IsNullOrEmpty(N))
            {
                return false;
            }
            return true;


        }
        public static void MagentaSubmitted()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Submitted");
            Console.ResetColor();
        }

        public static void Ending() { 
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Thanks for your submission");
            Console.ResetColor();
        }


    }
}