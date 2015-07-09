using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XnaFan;

namespace CardShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHand = new Hand();
            var mydeck = CreateDeck();
            mydeck.Shuffle();
            myHand.GetCards(mydeck);

            Console.WriteLine(myHand.card1);
            Console.WriteLine(myHand.card2);
            Console.WriteLine(myHand.card3);
            Console.WriteLine(myHand.card4);
            Console.WriteLine(myHand.card5);
            

            Console.ReadLine();
        }

        
        public static List<string> CreateDeck()
        {
            string[] values = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] suits = { "H", "D", "C", "S" };
            List<string> newDeck = new List<string>();
            foreach (string suit in suits)
            {
                foreach (string value in values)
                {
                    string card = value + suit;
                    newDeck.Add(card);
                }
            }
            return newDeck;
        }


        //private static List<string> DealCards(Deck myDeck)
        //{
            

        //    return;
        //}
    }
}
