using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Threading.Tasks;
using advent_of_code_2023.Models.DayThree;

namespace advent_of_code_2023.Services.DayThree
{
    public class DayThreeService : IDayThreeService
    {
        public List<Part> partList = new List<Part> { };


        public int PartTotal()
        {

            int total = 0;
            foreach (Part part in FindPart())
            {
                total += part.number;
            }
            Console.WriteLine(partList.Count);
            return total;
        }

        public List<Part> FindPart()
        {
            string text = File.ReadAllText("Services/DayThree/inputFile.txt");
            char[] delims = new[] { '\r', '\n' };
            string[] lines = text.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            int length = lines.Length;
            char[,] schematic = new char[length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    schematic[i, j] = lines[i].ToCharArray()[j];

                }
            }
            for (int i = 0; i < length; i++)
            {
                string numMem = "";
                int num;
                Boolean PartLegal = false;
                for (int j = 0; j < length; j++)
                {
                    List<char> voisin = new List<char> { };

                    if (char.IsDigit(schematic[i, j]))
                    {
                        //signifie le début ou le milieu d'un nombre
                        //on enregistre le nombre digit par digit
                        numMem += schematic[i, j].ToString();

                        //on regarde ses voisins :
                        //ligne du haut :

                        if (i > 0 && ((!schematic[i - 1, j].Equals('.')) || (j > 0 && !schematic[i - 1, j - 1].Equals('.')) || (j < length - 1 && !schematic[i - 1, j + 1].Equals('.')))) PartLegal = true;
                        //ligne actuel sans dépasser sur le numéro
                        if (j > 0 && numMem.Length == 1 && !schematic[i, j - 1].Equals('.')) PartLegal = true;
                        //ligne du bas :
                        if (i < length - 1 && (!schematic[i + 1, j].Equals('.') || (j > 0 && !schematic[i + 1, j - 1].Equals('.')) || (j < length - 1 && !schematic[i + 1, j + 1].Equals('.')))) PartLegal = true;
                        if (j == length - 1)
                        {
                            // si on se trouve au bord du tableau,
                            // cela veut dire que le nombre est complet
                            if (PartLegal)
                            {
                                Part part = new Part(int.Parse(numMem), new int[] { i, j - numMem.Length + 1 }, new int[] { i, j });
                                this.partList.Add(part);
                            }
                            numMem = "";
                            PartLegal = false;
                        }

                    }
                    else if (int.TryParse(numMem, out num))
                    {
                        // si un nombre est en mémoire mais que le char sur lequel on est n'est pas un digit,
                        // cela veut dire que le nombre est complet

                        //on regarde son voisin de droite, ce qui signifie le nombre sur lequel on est
                        if (!schematic[i, j].Equals('.') || PartLegal)
                        {
                            Part part = new Part(num, new int[] { i, j - numMem.Length }, new int[] { i, j - 1 });
                            this.partList.Add(part);

                        }
                        numMem = "";
                        PartLegal = false;
                    }
                }
            }
            return this.partList;
        }
        public int PartTwo()
        {
            string text = File.ReadAllText("Services/DayThree/inputFile.txt");
            char[] delims = new[] { '\r', '\n' };
            string[] lines = text.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            int length = lines.Length;
            int totalGearRatio=0;
            char[,] schematic = new char[length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if(lines[i].ToCharArray()[j].Equals('*')){
                        //on regarde les 8 voisins
                        //ligne du haut
                        List<int> numVoisin=new List<int>{};
                        if(i>0 &&((j>0 && char.IsDigit(lines[i-1].ToCharArray()[j-1]))||char.IsDigit(lines[i-1].ToCharArray()[j])||(j>length && char.IsDigit(lines[i-1].ToCharArray()[j-1])))){
                            numVoisin.Add(1);
                        }
                        //ligne actuel
                        if((j>0 && char.IsDigit(lines[i].ToCharArray()[j-1]))||(j>length && char.IsDigit(lines[i].ToCharArray()[j-1]))){
                           // numVoisin+=1;
                        }
                        //ligne du bas
                        if(i<length &&((j>0 && char.IsDigit(lines[i+1].ToCharArray()[j-1]))||char.IsDigit(lines[i+1].ToCharArray()[j])||(j>length && char.IsDigit(lines[i+1].ToCharArray()[j-1])))){
                           // numVoisin+=1;
                        }

                        if(numVoisin.Count==2){

                        }
                    }
                    schematic[i, j] = lines[i].ToCharArray()[j];
                }
            }
            return totalGearRatio;
        }
    }

}