using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWExtensionMethodsMethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask for how much money they have in their bank account
            // what was the last thing you bought and how much money was it /decimal
            // double, why, yes, convert. 

            PersonModel person = new PersonModel();
            //person.GetBankAccountMoney(252);

            person.BankMoney = "Add Bank Account Money: ".RequestBankAccountMoney(52);

            Console.WriteLine($"The mony is : {person.BankMoney}");
        }
    }

    public static class ConsoleExtension
    {
        public static PersonModel GetBankAccountMoney(this PersonModel person, double money)
        {
            person.BankMoney = money;
            return person;
        }

        public static double RequestBankAccountMoney(this string message, double money)
        {
            Console.WriteLine(message);
            double output = 0;
            bool isValid = double.TryParse(Console.ReadLine(), out output);
            return output;
        }

       
    }

    public class PersonModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double BankMoney { get; set; }

    }
}
