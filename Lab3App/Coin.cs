using System;
using System.Collections.Generic;

namespace Lab3App
{
     class Coin :Treasure
    {
        
        public int Value { get; set; }


        public override void AddMe(List<Collectable> collectables)
        {
            base.AddMe(collectables);
            UpdateTotalValue();
        }


        public void UpdateTotalValue() { base.Board.TotalValue += Value; 
        Console.WriteLine($"Total value is updated to : {base.Board.TotalValue}");}

        public override void Display()
        {
            Console.WriteLine($"Coin {base.Description} is displayed");
        }

        public override void UpdateTotalScore()
        {
            throw new NotImplementedException();
        }

        public Coin(int score, int value, string description) {
            base.Score = score;
            this.Value = value;
            base.Description = description;
        }



    }
}