using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyEights
{
    class AI_Opponent
    {
        private List<Card> playable = new List<Card>();

        public Card Move(List<Card> hand, Card discardPile, char playableSuit)
        {
            Card move;
            playable.Clear();


            //check for playable cards that aren't 8's
            foreach (Card card in hand)
            {
                if (card.Value != 8 && (card.Value == discardPile.Value || card.Suit == playableSuit )) playable.Add(card);
            }

            //if no playable cards, then check for 8's
            if (playable.Count == 0)
            {
                foreach (Card card in hand)
                {
                    if (card.Value == 8) playable.Add(card);
                }
            }
            

            //if there are still no playable cards then send back the pickup move.
            if (playable.Count == 0) move = new Card(14, 'p');
            //else choose a random card from list of playable moves
            else move = playable[ChooseMove()];

            return move;
        }

        public int ChooseMove()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            return rnd.Next(0, playable.Count);
        } 


        //This method chooses a suit for the AI if the AI places an 8.
        //The logic is that the AI will choose a suit that they have the most of in their hand.
        public char ChooseSuit(List<Card> hand)
        {
            char suit;
            Dictionary<char, int> suitCount = new Dictionary<char, int>() { { 'D', 0 }, { 'H', 0 }, { 'C', 0 }, { 'S', 0 } };
            
            foreach(Card card in hand)
            {
                suitCount[card.Suit] += 1;    
            }

            //this was adapted from https://stackoverflow.com/questions/10290838/how-to-get-max-value-from-dictionary
            suit = suitCount.Aggregate((x, y) => x.Value >= y.Value ? x : y).Key;

            return suit;
        }

    }
}
