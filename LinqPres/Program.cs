using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPres
{
    class Program
    {
        public static List<string> flowers = new List<string> { "Daisies", "Roses", "Dandelions" };
        public static List<string> suits = new List<string> { "Diamonds", "Hearts", "Spades", "Clubs" };
        public static List<int> numberCards = new List<int> {2,3,4,5,6,7,8,9,10};
        public static List<string> faceCards = new List<string> { "Ace", "Jack", "Queen", "King" };
        static void Main(string[] args)
        {
            List<string> bank = new List<string>();
            List<Func<string>> fish = new List<Func<string>> { ListFunction };
            bank.Add("card1");
            //Console.WriteLine(bank[0]);
            //flowers.ForEach(Console.WriteLine);
            //Console.WriteLine(fish[0]());
            //flowers.ForEach(Console.WriteLine);
            var deck = (from card in numberCards from face in faceCards from suit in suits select card.ToString() +" " +face+" "+ suit).ToList();
            //var altDeck = (from card in deck where card.card > 4 select card).ToList();
            //var alt2Deck = (from number in numberCards select number.ToString()).ToList().AddRange(faceCards);
            deck.ForEach(Console.WriteLine);
            Console.ReadKey();
        }

        public static string ListFunction()
        {
            flowers.Add("ooga booga");
            return "ooga booga";
        }
    }
}
