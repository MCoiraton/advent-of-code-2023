using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace advent_of_code_2023.Models.DayThree
{
    public class Part
    {
        public int number { get; set; }
        public int[] startPos { get; set; }
        public int[] endPos { get; set; }
        

        public Part(int number, int[] startPosistion, int[] endPosition)
        {
            this.number = number;
            this.startPos = startPosistion;
            this.endPos = endPosition;
        }
    }
}