
using System;
namespace Bank.Karti
{
    class DebitCard
    {
        public string CardNumber { get; set; }
        public string CardCVV { get; set; }
        public string ExpirationDate { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public string CompanyName { get; set; }
        public decimal Balance { get; private set; }
        public void IncreaseBalance(decimal sum)
        { if (sum <= 0) return;
            Balance += sum;
        }







    }
    public class Program
    {
        public static void Main(string[] args)
        {
            DebitCard card = new DebitCard();
            card.CardNumber = "4169 - 7388 - 1111 - 1111";
            card.CardCVV = "111";
            card.ExpirationDate = "11/25";
            card.PersonName = "Zilish";
            card.PersonSurname = "Zulfugarli";
            card.CompanyName = "Kapital Bank";
            card.IncreaseBalance(200);
            Console.WriteLine(card.CardNumber);
            Console.WriteLine(card.CardCVV);
            Console.WriteLine(card.ExpirationDate);
            Console.WriteLine(card.PersonName);
            Console.WriteLine(card.CompanyName);
        }
    }
}