using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardShuffle
{
    public class Hand
    {
        public string card1 { get; set; }
        public string card2 { get; set; }
        public string card3 { get; set; }
        public string card4 { get; set; }
        public string card5 { get; set; }



        public Hand()
        {
            
        }

        public void GetCards(List<string> mydeck)
        {
            card1 = mydeck.ElementAt(0);
            card2 = mydeck.ElementAt(1);
            card3 = mydeck.ElementAt(2);
            card4 = mydeck.ElementAt(3);
            card5 = mydeck.ElementAt(4);
            mydeck.RemoveRange(0, 5);
        }
    }
}


