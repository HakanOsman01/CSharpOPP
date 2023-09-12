

using System.Collections.Generic;

namespace _03._Cards
{
    public class Card
    {
        private List<string> cardFaces =
            new List<string>() 
            { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "K", "Q", "A" };
        private Dictionary<string, string> cardSuits = new Dictionary<string, string>()
        {
            {"S","\u2660"},
            {"H","\u2665" },
            {"D","\u2666" },
            {"C","\u2663" }

        };
        private string cardFace;
        private string cardSuit;
        public Card(string face,string suit)
        {
            bool isValid=CheckIsCardValid(cardFaces,cardSuits,face,suit);
            if (isValid)
            {
                this.cardFace = face;
                this.cardSuit = cardSuits[suit];
            }
            else
            {
                throw new CartInvalidException();
           
            }
           
        }
        private bool CheckIsCardValid(List<string> cardFaces, 
            Dictionary<string, string> cardSuits, string face,string suit)
        {
            if(cardFaces.Contains(face) && cardSuits.ContainsKey(suit))
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"[{cardFace}{cardSuit}]";
        }


    }
}
