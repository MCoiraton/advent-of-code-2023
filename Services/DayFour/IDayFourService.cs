using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using advent_of_code_2023.Models.DayFour;

namespace advent_of_code_2023.Services.DayFour
{
    public interface IDayFourService
    {
        List<ScratchCard> ReadCards();

        int GetTotalPoint();

        int PartTwo();
    }
}