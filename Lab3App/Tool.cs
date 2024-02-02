using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Tool:Collectable
    {
        public override void Display()
        {
         
        }

        public virtual void DoAction() { Console.WriteLine($"{ base.Description} Collected, Congrats !!!");}
    }
}
