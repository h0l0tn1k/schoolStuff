using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsQuest
{
    /// <summary>
    /// Interface for players such as Hero and Monster
    /// </summary>
    abstract class Iplayer
    {

        #region Variables & Properties
        /// <summary>
        /// Array of damages
        /// indexing using [Weapon.GivenWeapon]
        /// </summary>
        protected int[] damages = new int[3];
        
        /// <summary>
        /// Health of given player
        /// </summary>
        public int HitPoints { get; set; }
        
        ///<summary>
        /// Rock damage properties getter, private setter for damage of rock
        /// </summary>
        public int RockDamage { 
            get { return damages[(int)Weapon.Stone]; }
            private set { damages[(int)Weapon.Stone] = value; }
        }

        ///<summary>
        /// Paper damage properties getter, private setter for damage of paper
        /// </summary>
        public int PaperDamage
        {
            get { return damages[(int)Weapon.Paper]; }
            private set { damages[(int)Weapon.Paper] = value; }
        }

        ///<summary>
        /// Scissors damage properties getter, private setter for damage of scissors
        /// </summary>
        public int ScissorsDamage
        {
            get { return damages[(int)Weapon.Scissors]; }
            private set { damages[(int)Weapon.Scissors] = value; }
        }
        

        #endregion


        #region Constructor
        /// <summary>
        /// Constructor for Iplayer inteface
        /// </summary>
        /// <param name="rockDamage">Damage of rock</param>
        /// <param name="paperDamage">Damage of paper</param>
        /// <param name="stoneDamage">Damage of scissors</param>
        /// <param name="health">Health of player</param>
        public Iplayer(int rockDamage,int paperDamage,int stoneDamage,int health)
        {
            damages[(int)Weapon.Paper] = paperDamage;
            damages[(int)Weapon.Stone] = rockDamage;
            damages[(int)Weapon.Scissors] = stoneDamage;
            HitPoints = health;
        }

        #endregion


        #region Methods

        /// <summary>
        /// Returns damage of player's weapon in given argument
        /// </summary>
        /// <param name="weapon">type of weapon</param>
        /// <returns>amount of damage</returns>
        public int GetWeapDamage(Weapon weapon) 
        {
            return damages[(int)weapon];
        }


        /// <summary>
        /// Abstract function, implemented in Monster & Hero class
        /// chooses weapon to be used in fight
        /// </summary>
        /// <returns></returns>
        public abstract Weapon ChooseWeapon();

        /// <summary>
        /// Is player alive
        /// </summary>
        /// <returns>true if player is alive</returns>
        public bool IsAlive()
        { 
            return (HitPoints > 0);
        }
        /// <summary>
        /// Called when players gets damage
        /// </summary>
        /// <param name="damage">Amount of damage</param>
        public void TakeDamage(int damage) {
            HitPoints -= damage;
        }

        #endregion
    }
}
