using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace advent_of_code_2023.Models.DayTwo
{
    public class Game
    {
        public int id { get; set; }
        private int blueCubes { get; set; }
        private int redCubes { get; set; }
        private int greenCubes { get; set; }

        public Game(int id)
        {
            this.id = id;
            blueCubes = 0;
            redCubes = 0;
            greenCubes = 0;
        }

        public void NewReveal(int blueCubesRevealed, int redCubesRevealed, int greenCubesRevealed)
        {
            if (blueCubesRevealed > blueCubes) blueCubes = blueCubesRevealed;
            if (redCubesRevealed > redCubes) redCubes = redCubesRevealed;
            if (greenCubesRevealed > greenCubes) greenCubes = greenCubesRevealed;
        }

        public Boolean IsPossible(int maxBlue, int maxRed, int maxGreen)
        {
            if (maxBlue >= blueCubes && maxGreen >= greenCubes && maxRed >= redCubes) return true;
            else return false;
        }

        public int getPowa()
        {
            return blueCubes * redCubes * greenCubes;
        }
    }
}