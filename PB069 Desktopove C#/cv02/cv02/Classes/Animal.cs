using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv02
{
    abstract class Animal
    {
        /// <summary>
        /// Name of animal
        /// </summary>
        public string Name { get; private set; }

        protected int Hunger{ get; set; }

        public bool isDead 
        { 
            get 
            {
                return (Hunger > 5);
            }
        }

        protected Animal(string name)
        {
            Name = name;
            Hunger = 3;
        }
        public string Starve()
        { 
            Hunger++;
            if (isDead)
            {
                return String.Format("{0} died of hunger.", Name);
            }

            return String.Format("{0} grew hungry.",Name);
        }

        public abstract string Feed(FoodType type);
        public override string ToString()
        {
            return String.Format("{0}, Hunger: {1}",Name,Hunger);
        }
    }
}
