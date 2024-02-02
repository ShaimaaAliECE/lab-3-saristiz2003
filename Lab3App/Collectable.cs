






using System.Collections.Generic;

namespace Lab3App
{
     abstract class Collectable: Displayable 
    {

        public CollectionBoard Board { get; set; }
        public string Description { get; set; }

        public virtual void AddMe(List<Collectable> collectables)
        {
            collectables.Add(this);
            collectables.Remove(this);
        }

        public abstract void UpdateTotalScore();
        public abstract void Display();

    }
}