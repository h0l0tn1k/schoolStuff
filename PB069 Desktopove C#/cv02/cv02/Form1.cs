using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cv02
{
    public partial class Form1 : Form
    {
        private Animal[] animals;
        private int currAnimal;

        public Form1()
        {
            InitializeComponent();

            animals = new Animal[] 
            {
                new Herbivore("Giraffe"),
                new Carnivore("Lion")
            };

            currAnimal = 0;
            labelAnimal.Text = animals[currAnimal].ToString();
        }

        #region btnClickFeed*
        private void btnClickFeedGrass(object sender, EventArgs e)
        {
            FeedAnimal(FoodType.Grass);
        }



        private void btnClickFeedMeat(object sender, EventArgs e)
        {
            FeedAnimal(FoodType.Meat);
        }
        #endregion

        private void FeedAnimal(FoodType f) 
        {
            labelInfo.Text = animals[currAnimal].Feed(f);
            labelInfo.Text += "\n" + animals[currAnimal].Starve();

            ///LINQ
            if (animals.All(animal => animal.isDead))
            {
                MessageBox.Show("All animals are dead.");
                Close();    
            }
            else
            { 
                do
                {
                    currAnimal = (++currAnimal % animals.Length);            
                } while (animals[currAnimal].isDead);
            
                labelAnimal.Text = animals[currAnimal].ToString();
            }
        }
    }
}
