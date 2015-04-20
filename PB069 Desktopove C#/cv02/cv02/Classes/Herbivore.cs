using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv02
{
    class Herbivore : Animal
    {
        public Herbivore(string name)
            :base(name)
        {

        }

        public override string Feed(FoodType type)
        {
            if (type == FoodType.Grass) { 
                base.Hunger--;
                return String.Format("{0}'s hunger went down.", base.Name);
            }

            return String.Format("{0} only eats grass!",base.Name);
        }
    }
}
