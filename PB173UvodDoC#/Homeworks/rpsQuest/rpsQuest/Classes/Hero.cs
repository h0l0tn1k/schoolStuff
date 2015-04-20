using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsQuest
{
    /// <summary>
    /// Hero class deriving from Iplayer interface
    /// </summary>
    class Hero : Iplayer
    {

        #region Variables & Properties
        /// <summary>
        /// Stores info about player's level
        /// </summary>
        private int lvl;
        /// <summary>
        /// Stores info about player's experiences points
        /// </summary>
        public int ExperiencePoints { get; set; }

        /// <summary>
        /// public property
        /// </summary>
        public int Level
        {
            get { return lvl; }
            private set{lvl = value;}
        }

        #endregion


        #region Constructor
        /// <summary>
        /// Constructor for Hero Class, Calls base constructor of Iplayer interface to set up values
        /// all weapons have damage 2, and player's health is 10
        /// </summary>
        public Hero()
            : base(2,2,2,10)
        {
            Level = 1;
            ExperiencePoints = 0;
        }

        #endregion


        #region Methods
        /// <summary>
        /// Read keywords from stdin, and chooses weapo from Weapon enum
        /// </summary>
        /// <returns>Chosen weapon, can return NewGame</returns>
        public override Weapon ChooseWeapon()
        {
            while (true)
            {
                Console.Write("Enter weapon: ");
                string weap = Console.ReadLine();
                if (weap == "new game")
                    return Weapon.NewGame;
                if (weap == "rock")
                    return Weapon.Stone;
                if (weap == "scissors")
                    return Weapon.Scissors;
                if (weap == "paper")
                    return Weapon.Paper;                    
            }
        }

        /// <summary>
        /// Heals player's health to 10hp
        /// </summary>
        public void Heal() 
        {
            HitPoints = 10;    
        }

        /// <summary>
        /// Adds experience to player
        /// </summary>
        /// <param name="amount">amount of experience to be added</param>
        public void AddExperience(int amount) 
        {
            ExperiencePoints += amount;
        }

        /// <summary>
        /// Increments damage of given weapon by one
        /// </summary>
        /// <param name="weapon">Weapon to be enhanced</param>
        public void EnhanceWeapon(Weapon weapon)
        {
            damages[(int)weapon]++;
        }

        /// <summary>
        /// Increasing player's level by one
        /// </summary>
        public void LevelUp()
        {
            lvl++;
        }

        #endregion
    }
}
