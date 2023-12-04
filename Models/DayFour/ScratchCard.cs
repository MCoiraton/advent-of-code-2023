using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace advent_of_code_2023.Models.DayFour
{
    public class ScratchCard
    {
        private int[] winningNumbers { get; set; }
        private int[] numbers { get; set; }
        private int points { get; set; }
        private int id { get; set; }
        private int numberOfInstance { get; set; }


        public ScratchCard(int[] winningNumbers, int[] numbers, int id)
        {
            this.winningNumbers = winningNumbers;
            this.numbers = numbers;
            points = 0;
            this.id = id;
            numberOfInstance=1;
        }



        public int CalculatePoints()
        {
            int totalWinNum = 0;
            foreach (int number in numbers)
            {
                if (winningNumbers.Contains(number))
                {
                    totalWinNum += 1;
                    points = (int)Math.Pow(2, totalWinNum - 1);
                }
            }
            return points;
        }

        public int MatchingNumbers()
        {
         int total = 0;
            foreach (int number in numbers)
            {
                if (winningNumbers.Contains(number))
                {
                    total += 1;
                }
            }
            return total;   
        }

        public int getId(){
            return id;
        }

        public void addInstance(int number){
            numberOfInstance+=number;
        }

        public int getNumberOfInstance(){
            return numberOfInstance;
        }
    }
}