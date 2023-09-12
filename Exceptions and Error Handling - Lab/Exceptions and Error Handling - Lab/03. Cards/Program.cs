using System;
namespace _03._Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]cards=Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries);
            List<Card> validCards = new List<Card>();
            for(int current=0; current<cards.Length; current++)
            {
                string[] cardInfo = cards[current]
                       .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    string cardFace = cardInfo[0];
                    string suitCard = cardInfo[1];
                    Card card=new Card(cardFace, suitCard);

                    validCards.Add(card);
                   

                    
                  

                }catch(CartInvalidException ms)
                {
                    Console.WriteLine(ms.Message);
                }
            }
            PrintValidCards(validCards);
        }
        static void PrintValidCards(List<Card> validCards)
        {
            foreach(Card card in validCards)
            {
                Console.Write($"{card} ");
            }
        }
    }
}