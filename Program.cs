///llll
using System;
using System.Collections.Generic;
using System.Text;















namespace FactoryDesignPattern
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();

    }

    class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }

        public int GetAnnualCharge()
        {
            return 500;
        }
    }

    public class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCreditLimit()
        {
            return 1000;
        }

        public int GetAnnualCharge()
        {
            return 333;
        }
    }

    public class Platinum : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum";
        }

        public int GetCreditLimit()
        {
            return 2000;
        }

        public int GetAnnualCharge()
        {
            return 2;
        }
    }

    public class CreditCardFactory
    {
        public static ICreditCard GetICreditCard(string cardType)
        {
            ICreditCard card = null;
            if (cardType == "MoneyBack")
            {
                card = new MoneyBack();
            }

            else if (cardType == "Titanium")
            {
                card = new Titanium();
            }

            else if (cardType == "Platinum")
            {
                card = new Platinum();
            }

            return card;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ICreditCard card = CreditCardFactory.GetICreditCard("Titanium");
            if (card != null)
            {
                Console.WriteLine("Card Type {0}", card.GetCardType());
                Console.WriteLine("Credit Limit {0}", card.GetCreditLimit());
                Console.WriteLine("Annual Charge {0}", card.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
        }
    }
}

/*namespace SingletonDesignPattern
{
    public sealed class Singleton{
        private static int count = 0;
        private static Singleton instance = null;
        public static Singleton Getinstance{
           get{
                if(instance == null)
                    instance = new Singleton();
                
                return instance;
           }
        }

        private Singleton(){
            count++;
            Console.WriteLine(count);
        }

        public void print(string msg){
            Console.WriteLine(msg);
        }
    }
     class ma{
        static void Main(string[] args){
            Singleton a = Singleton.Getinstance;
            a.print("object 1");
            Singleton b = Singleton.Getinstance;
            b.print("object 2");
            Singleton c = Singleton.Getinstance;
            c.print("object 3");
            Console.ReadLine();

        }
    }

}
//result:
 1
 object 1
 object 2
 object 3
*/