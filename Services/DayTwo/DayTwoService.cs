using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using advent_of_code_2023.Models.DayTwo;

namespace advent_of_code_2023.Services.DayTwo
{
    public class DayTwoService : IDayTwoService
    {
        public List<Game> ReadFile()
        {
            List<Game> gameList = new List<Game>();
            string text = File.ReadAllText("Services/DayTwo/inputFile.txt");
            char[] delims = new[] { '\r', '\n' };
            string[] games = text.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            foreach (string game in games)
            {

                string[] gameParts = game.Split(':');
                int gameId = int.Parse(gameParts[0].Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
                Game actualGame = new Game(gameId);
                foreach (string reveal in gameParts[1].Split(';'))
                {
                    int blue = 0;
                    int red = 0;
                    int green = 0;
                    string[] color = reveal.Split(',');
                    for (int i = 0; i < color.Length; i++)
                    {
                        if (color[i].Contains("blue"))
                        {
                            blue += int.Parse(color[i].Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
                        }
                        if (color[i].Contains("red"))
                        {
                            red += int.Parse(color[i].Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
                        }
                        if (color[i].Contains("green"))
                        {
                            green += int.Parse(color[i].Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
                        }
                    }
                    actualGame.NewReveal(blue, red, green);
                }
                gameList.Add(actualGame);
            }
            return gameList;
        }

        public int SumPossibleGame()
        {
            int totalId = 0;
            int maxBlue = 14;
            int maxRed = 12;
            int maxGreen = 13;
            foreach (Game game in ReadFile())
            {
                if (game.IsPossible(maxBlue, maxRed, maxGreen))
                {
                    totalId += game.id;
                }
            }
            return totalId;
        }

        public int SumPower()
        {
            int total = 0;
            foreach (Game game in ReadFile())
            {
                total += game.getPowa();
            }
            return total;
        }
    }
}