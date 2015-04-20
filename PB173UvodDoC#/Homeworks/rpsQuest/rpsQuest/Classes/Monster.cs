using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsQuest
{
    /// <summary>
    /// Class Monster
    /// </summary>
    class Monster : Iplayer
    {

        #region Constructor
        /// <summary>
        /// COnstructor for class Monster
        /// </summary>
        /// <param name="rockDamage">Damage of rock</param>
        /// <param name="paperDamage">Damage of paper</param>
        /// <param name="scissorsDamage">Damage of scissors</param>
        /// <param name="health">Heath of Monster</param>
        public Monster(int rockDamage,int paperDamage,int scissorsDamage,int health)
            : base(rockDamage,paperDamage,scissorsDamage,health)
        {
            
        }

        #endregion


        #region Overriden Method ChooseWeapon()
        /// <summary>
        /// Randomly chooses weapon
        /// </summary>
        /// <returns>choosen weapon</returns>
        public override Weapon ChooseWeapon(){
            Weapon[] weaps =  new Weapon[3]{Weapon.Paper,Weapon.Scissors,Weapon.Stone};
            Random randNum = new Random();
            return weaps[randNum.Next(0, 2)];
        }

        #endregion
   
    }
}
