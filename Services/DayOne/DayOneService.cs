using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace advent_of_code_2023.Services.DayOne
{
    public class DayOneService : IDayOneService
    {
        //TODO add a way to upload a txt file instead of a text for the entry
        /*public int PostEntry(string entry)
        {
            char[] delims = new[] { '\r', '\n', ' ' };
            string[] calibration = entry.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            calibrationDocument.calibration = calibration;
            return SumValues();
        }*/

        public int SumValues()
        {

            int total = 0;
            foreach (string line in ReadFile())
            {
                int[] lineValue = new int[]{0,0};
                bool stop1 = false, stop2 = false;
                for (int i = 0; i < line.Length; i++)
                {
                    int value1;
                    int value2;
                    if (int.TryParse(line[i].ToString(), out value1) && !stop1)
                    {
                        lineValue[0]=value1;
                        stop1=true;
                    }
                    if (int.TryParse(line[line.Length - i - 1].ToString(), out value2) && !stop2)
                    {
                        lineValue[1]=value2;
                        stop2 =true;
                    }
                    
                }
                
                total += int.Parse(String.Join("",lineValue));
                Console.WriteLine(String.Join("",lineValue));
            }
            Console.WriteLine(total);
            return total;
        }

        public string[] ReadFile()
        {
            string text = File.ReadAllText("Services/DayOne/inputFile.txt");
            //La p2 demande de prendre en compte les chiffres en toutes lettres
            //on traduit donc tout en laissant les lettres pouvant s'overlap (ex :"sevenine")
            text = Regex.Replace(text, "one", "o1e");
            text = Regex.Replace(text, "two", "t2o");
            text = Regex.Replace(text, "three", "t3e");
            text = Regex.Replace(text, "four", "4");
            text = Regex.Replace(text, "five", "5");
            text = Regex.Replace(text, "six", "6");
            text = Regex.Replace(text, "seven", "7n");
            text = Regex.Replace(text, "eight", "e8t");
            text = Regex.Replace(text, "nine", "n9e");
            char[] delims = new[] { '\r', '\n', ' ' };
            string[] lines = text.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            return lines;
        }
    }
}