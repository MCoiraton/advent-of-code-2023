using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using advent_of_code_2023.Models.DayThree;

namespace advent_of_code_2023.Services.DayThree
{
    public interface IDayThreeService
    {
        List<Part> FindPart();
        int PartTotal();
    }
}