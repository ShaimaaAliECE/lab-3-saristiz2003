using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal public abstract class Treasure:Collectable
    {
        public int Score { get; set; }

        public override void AddMe(List<Collectable> collectables)
        {
            collectables.Add(this);
            UpdateTotalScore();
        }

        public virtual UpdateTotalScore() { 
            base.Board.TotalScore += Score;
            Console.WriteLine($"{Description} Collected, Congrats !!!");
            Console.WriteLine($"Total Score is updated to : {base.Board.TotalScore}");
        }

        public override void Display()  { }

    }
}
