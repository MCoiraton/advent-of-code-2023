using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using advent_of_code_2023.Models.DayTwo;

namespace advent_of_code_2023.Services.DayTwo
{
    public interface IDayTwoService
    {
        List<Game> ReadFile();

        int SumPossibleGame();

        int SumPower();
    }
}