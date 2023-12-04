using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using advent_of_code_2023.Models.DayFour;

namespace advent_of_code_2023.Services.DayFour
{
    public class DayFourService : IDayFourService
    {
        public int GetTotalPoint()
        {
            int total = 0;
            foreach (ScratchCard card in ReadCards())
            {
                total += card.CalculatePoints();
            }
            return total;
        }


        public List<ScratchCard> ReadCards()
        {
            List<ScratchCard> cardList = new List<ScratchCard>();
            string text = File.ReadAllText("Services/DayFour/inputFile.txt");
            char[] delims = new[] { '\r', '\n' };
            string[] cards = text.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            foreach (string card in cards)
            {
                string[] cardParts = card.Split(':', '|');
                string cardName = cardParts[0];
                int cardId = int.Parse(cardName.Split(' ',StringSplitOptions.RemoveEmptyEntries)[1]);
                int[] winningNumbers = Array.ConvertAll(cardParts[1].Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
                int[] numbers = Array.ConvertAll(cardParts[2].Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
                ScratchCard scratchCard = new ScratchCard(winningNumbers, numbers, cardId);
                cardList.Add(scratchCard);
            }
            return cardList;
        }

        public int PartTwo()
        {
            List<ScratchCard> cardList = ReadCards();
            int cardTotal=0;            
            foreach (ScratchCard card in cardList)
            {
                if (card.MatchingNumbers()>0){
                    for (int i=0; i<card.MatchingNumbers();i++)
                    cardList[card.getId()+i].addInstance(card.getNumberOfInstance());
                }
                cardTotal+=card.getNumberOfInstance();
            }
            return cardTotal;
        }

    }




}