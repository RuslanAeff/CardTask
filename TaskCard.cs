using System;

namespace Kart
{
   public class Card
    {
        public string Code { get; set; }
        public string CVV { get; set; }
        public string ExpiryDate { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public decimal Balance { get; set; }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {

            Card myCard = new Card();

            myCard.Code = "4169919909191901";
            myCard.CVV = "1001";
            myCard.ExpiryDate = "01/29";
            myCard.Name = "Ruslan";
            myCard.Surname = "Aliyev";
            myCard.Company = "Kapital Bank";
            myCard.Balance = 0;

            Console.WriteLine(myCard.Name);
            Console.WriteLine(myCard.Surname);
            Console.WriteLine(myCard.Company);
            Console.WriteLine(myCard.Balance);


        }
    }
}
