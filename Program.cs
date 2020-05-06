using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Global Declarations
            int daysToStay;
            string addonCode;
            //Main line
            welcomeMod();
            Console.WriteLine("How many days will your dog be staying with us?");
            daysToStay = Convert.ToInt32(userInputReq());
            Console.WriteLine("Would you like a service package addon with that too?");
            Console.WriteLine("If not, please leave it blank and hit enter.");
            Console.WriteLine("Here are the service codes...");
            Console.WriteLine("N or blank = No Service addon, + $0.00.");
            Console.WriteLine("A = Bathing and Grooming, + $169.00 per day.");
            Console.WriteLine("C = Bathing, + $112.00 per day.");
            addonCode = userInputReq();
            if(string.IsNullOrEmpty(addonCode) || addonCode == "N" || addonCode == "n"){
                computeRate(daysToStay);
            }
            else{
                computeRate(daysToStay, addonCode);
            }
        }
        // Welcome Module
        public static void welcomeMod(){
            Console.WriteLine("MPLS Dog Boarding");
            Console.WriteLine("-----------------");
            Console.WriteLine("Hello Customer!");
            Console.WriteLine("Thank you for using our rate computation program!");
        }
        // User input
        public static string userInputReq(){
            string input = Console.ReadLine();
            return input;
        }
        // Deals with rate computation without addon codes.
        public static void computeRate(int days){
            int price;
            price = days * 79;
            Console.WriteLine("Here is your final Bill!");
            Console.WriteLine($"Your dog will be staying with us for {days} days.");
            Console.WriteLine("Your Addon Service code is N, which means no addon package was selected.");
            Console.WriteLine($"Your total bill is ${price}");
        }
        // Deals with rate computation with addon codes.
        public static void computeRate(int days, string code){
            int price;
            if(code == "A" || code == "a"){
                price = (169 + 79) * days;
                Console.WriteLine("Here is your final Bill!");
                Console.WriteLine($"Your dog will be staying with us for {days} days.");
                Console.WriteLine("Your Addon Service code is A, bathing and grooming is included");
                Console.WriteLine($"Your total bill is ${price}");
            }
            else if(code == "C" || code == "c"){
                price = (112 + 79) * days;
                Console.WriteLine("Here is your final Bill!");
                Console.WriteLine($"Your dog will be staying with us for {days} days.");
                Console.WriteLine("Your Addon Service code is A, bathing and grooming is included");
                Console.WriteLine($"Your total bill is ${price}");
            }
        }
    }
}
