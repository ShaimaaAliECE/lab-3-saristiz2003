


using System;
using System.Collections.Generic;

namespace Lab3App
{
     class Axe: Tool
    {
        public Axe(string description) {base.Description = description;}

        public  override void Display() { Console.WriteLine($"Axe {base.Description} is displayed"); }

        public override void AddMe(List<Collectable>collectables) { DoAction(); }

        public override void DoAction() { base.DoAction(); Console.WriteLine("Axe is used"); }

        public override void UpdateTotalScore()
        {
            throw new NotImplementedException();
        }
    }
}