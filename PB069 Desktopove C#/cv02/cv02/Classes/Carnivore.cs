using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv02
{
    class Carnivore : Animal
    {
        public Carnivore(string name)
            :base(name)
        {

        }

        public override string Feed(FoodType type)
        {
            if (type == FoodType.Meat)
            {
                base.Hunger--;
                return String.Format("{0}'s hunger went down.", base.Name);
            }

            return String.Format("{0} only eats meat!", base.Name);
        }
    }
}
