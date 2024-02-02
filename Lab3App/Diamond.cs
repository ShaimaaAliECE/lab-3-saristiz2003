using System;

namespace Lab3App
{
      class Diamond : Treasure
    {

        public Diamond(int score, string description) {
            base.Score = score; base.Description = description; }

        public override void Display()
        {
            Console.WriteLine($"Diamond {base.Description} is displayed.");
        }

        public override void UpdateTotalScore()
        {
            throw new NotImplementedException();
        }
    }
}