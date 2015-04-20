using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace rpsQuest
{
    class Program
    {
        /// <summary>
        /// Main Function
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Hello, type  \"new game\" to start");

            WaitFor("new game");
            StartGame();           
        }

        /// <summary>
        /// Starts game,Creates player, and waits for commands
        /// </summary>
        public static void StartGame()
        {
            Console.WriteLine("Game started!");
            Hero player = new Hero();

            while (true)
            {
                if (!player.IsAlive())
                {
                    Console.WriteLine("End of game");
                    return;
                }


                if (player.Level == 10)
                {
                    Console.WriteLine("You won the game!\nCongratualtions!");
                }
                else 
                { 
                    GetCommands(ref player);
                }
                
            }
        
        }

        /// <summary>
        /// Function Fight, Creates Monster
        /// </summary>
        /// <param name="player">player</param>
        public static void Fight(ref Hero player)
        {
            int lifeOfMonster = player.Level + 5;
            int damageOfMonster = player.PaperDamage
                                  + player.ScissorsDamage
                                  + player.RockDamage;

            ///Rovnomerne rozdelit damage
            int[] dmgs = new int[]{damageOfMonster / 3,damageOfMonster /3,damageOfMonster/3};
            int rest = damageOfMonster % 3;
            Random index = new Random();

            /// Rozdelit zvysok medzi weapons
            if (rest == 1)
            { 
                dmgs[index.Next(0, 2)]++;
            }
            if (rest == 2)
            { 
                dmgs[index.Next(0, 2)]++;
                dmgs[index.Next(0, 2)]++;
            }
            Monster mon = new Monster(dmgs[0], dmgs[1], dmgs[2], lifeOfMonster);
            Console.WriteLine("Monster has " + mon.HitPoints + " hp");
            Console.WriteLine("Paper " + dmgs[(int)Weapon.Paper].ToString());
            Console.WriteLine("Stone " + dmgs[(int)Weapon.Stone].ToString());
            Console.WriteLine("Scissors " + dmgs[(int)Weapon.Scissors].ToString());

            while (player.IsAlive() && mon.IsAlive())
            {
                Weapon pw = player.ChooseWeapon(),  mw = mon.ChooseWeapon();
                if (pw == Weapon.NewGame)
                {
                    StartGame();
                    return;
                }
                EvaluateWeapons(pw, mw,ref player,ref mon);
            }
        }

        /// <summary>
        /// Determines who won
        /// </summary>
        /// <param name="playersWeapon">weapon of player</param>
        /// <param name="monstersWeapon">weapon of monster</param>
        /// <param name="player">Player from Hero Class</param>
        /// <param name="monster">Monster from Monster Class</param>
        public static void EvaluateWeapons(Weapon playersWeapon, Weapon monstersWeapon,ref Hero player,ref Monster monster)
        {
            if (playersWeapon == monstersWeapon) 
            {
                Console.WriteLine(playersWeapon.ToString() + " - Draw" );
            }
            else if(playersWeapon == Weapon.Paper)
            {
                if (monstersWeapon == Weapon.Stone)
                    HurtMonster(ref monster, playersWeapon,ref player);

                if (monstersWeapon == Weapon.Scissors)
                    HurtPlayer(ref player, monstersWeapon,ref monster);
            }
            else if (playersWeapon == Weapon.Scissors)
            {
                if (monstersWeapon == Weapon.Paper)
                    HurtMonster(ref monster, playersWeapon,ref player);
                
                if (monstersWeapon == Weapon.Stone)
                    HurtPlayer(ref player, monstersWeapon,ref monster);
            }
            else /// player has STONE
            {
                if(monstersWeapon == Weapon.Scissors)
                    HurtMonster(ref monster,playersWeapon,ref player);
                if(monstersWeapon == Weapon.Paper)
                    HurtPlayer(ref player,monstersWeapon,ref monster);
            }

            return;
        }

        /// <summary>
        /// Hurts monster by players damage of players chosen weapon
        /// </summary>
        /// <param name="monster">monster to be hurt</param>
        /// <param name="playersWeapon">player's weapon used in fight</param>
        /// <param name="player">player</param>
        public static void HurtMonster(ref Monster monster,Weapon playersWeapon,ref Hero player)
        {
            monster.TakeDamage(player.GetWeapDamage(playersWeapon));
            Console.WriteLine(playersWeapon + " - Monster has been hurt");
            Console.WriteLine("Monster has " + monster.HitPoints + " hp");
            if (!monster.IsAlive())
            {
                int dmgs = monster.PaperDamage
                          + monster.ScissorsDamage
                          + monster.RockDamage;
                Console.Write("Monster is dead.");
                Console.WriteLine("You have gained {0}p experience.",dmgs);
                ///Experience based on monsters damages
                player.AddExperience(dmgs);
                Console.WriteLine("Your level is {0} and you have {1} points of experience.",player.Level,player.ExperiencePoints);
                GetCommands(ref player);
            }
            return;
        }
        
        /// <summary>
        /// Hurts player by monsters damage of monsters chosen weapon
        /// </summary>
        /// <param name="player">player to be hurt</param>
        /// <param name="monstersWeapon">Weapon of monster</param>
        /// <param name="monster">monster</param>
        public static void HurtPlayer(ref Hero player, Weapon monstersWeapon,ref Monster monster)
        {
            player.TakeDamage(monster.GetWeapDamage(monstersWeapon));
            Console.WriteLine(monstersWeapon.ToString() + " - You have been hurt");
            if (!player.IsAlive())
            {
                Console.WriteLine("You are dead");
            }
            return;
        }

        /// <summary>
        /// Cycles and waits until used enter command new game
        /// </summary>
        /// <param name="command"></param>
        public static void WaitFor(string command) { 
            string input = "";
            while ((input = Console.ReadLine()) != command)
                { }
        }


        /// <summary>
        /// Waits for commands that can be used out of fight
        /// </summary>
        /// <param name="player">player</param>
        public static void GetCommands(ref Hero player) 
        {
            string input = "";
            while (true)
            {
                input = Console.ReadLine();
                if (input == "new game")
                {
                    StartGame();
                    return;
                }
                if (input == "fight")
                { 
                    Fight(ref player);
                    return;
                }
                if(player.ExperiencePoints>0)
                {
                    if (input == "lvlup rock" && player.ExperiencePoints >= player.GetWeapDamage(Weapon.Stone)*2)
                    {
                        player.ExperiencePoints -= player.GetWeapDamage(Weapon.Stone) * 2;
                        player.EnhanceWeapon(Weapon.Stone);
                        player.LevelUp();
                        Console.WriteLine("Level{0}!Rock++ Rock damage is {1}.", player.Level, player.GetWeapDamage(Weapon.Stone));
                    }
                    if (input == "lvlup paper" && player.ExperiencePoints >= player.GetWeapDamage(Weapon.Paper) * 2)
                    {
                        player.ExperiencePoints -= player.GetWeapDamage(Weapon.Paper) * 2;
                        player.EnhanceWeapon(Weapon.Paper);
                        player.LevelUp();
                        Console.WriteLine("Level{0}!Paper++ Paper damage is {1}.", player.Level, player.GetWeapDamage(Weapon.Paper));
                    }
                    if (input == "lvlup scissors" && player.ExperiencePoints >= player.GetWeapDamage(Weapon.Scissors) * 2)
                    {
                        player.ExperiencePoints -= player.GetWeapDamage(Weapon.Scissors) * 2;
                        player.EnhanceWeapon(Weapon.Scissors);
                        player.LevelUp();
                        Console.WriteLine("Level{0}!Scissors++ Scissors damage is {1}.", player.Level, player.GetWeapDamage(Weapon.Scissors));
                    }
                }
                if (input == "healer")
                {
                    player.HitPoints = 10;
                    Console.WriteLine("You have been healed!");
                }
                    
            }
        }
    }
}
