using ConsoleUI.ConsoleTable.Services;
using System;

namespace ConsoleUI.ConsoleTable.Structural
{
    public class Column
    {

        public string Name { get; set; }

        public ConsoleColor DefColor { get; set; } = ConsoleColor.White;

        public int MaxLenght { get; set; } = 20;

        public float AverageValue { get; set; } = 0;

        public bool IsStatColumn { get; set; } = false;

        public Column(string name,  int maxLenght, ConsoleColor defColor)
        {
            Name = name;
            DefColor = defColor;
            MaxLenght = maxLenght;
            IsStatColumn = false;
        }

        public Column(string name)
        {
            Name = name;
        }

        public Column(string name, int maxLenght)
        {
            Name = name;
            MaxLenght = maxLenght;
            IsStatColumn = false;
        }


        public Column(string name, int maxLenght, float averageValue)
        {
            Name = name;
            MaxLenght = maxLenght;
            AverageValue = averageValue;
            IsStatColumn = true;
        }

        public void Write()
        {
            ConsoleWriteService.Write(Name, MaxLenght, DefColor);
        }
    }
}
