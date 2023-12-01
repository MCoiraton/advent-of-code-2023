using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace advent_of_code_2023.Services.DayOne
{
    public interface IDayOneService
    {
        //int PostEntry(string entry);
        int SumValues();

        string[] ReadFile();
        
    }
}