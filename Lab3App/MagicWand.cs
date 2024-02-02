using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Lab3App
{
    internal class MagicWand :Tool
    {
        public MagicWand(string description) { base.Description = description; }

        public override void DoAction()
        {
            base.DoAction();
            Console.WriteLine("MagicWand is used.");}

            public override void Display() { Console.WriteLine($"MagicWaand {base.Description} is displayed"); }
        public override void AddMe(List<Collectable> collectables)
        {
            DoAction();
        }

        public override void UpdateTotalScore()
        {
            throw new NotImplementedException();
        }
    }
}