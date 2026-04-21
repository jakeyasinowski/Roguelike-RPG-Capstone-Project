using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            bool repeatPlaying = false;
            

            while (playAgain) // While loop to let user play again
            {
                // Asks player for name and creates player object
                Console.Clear();
                Console.WriteLine("Hello user, what is your name?");

                // Player/enemy objects
                Player player = new Player (Console.ReadLine(), 100, 10);
                Enemy rat = new GiantRat();
                Enemy orc = new Orc();
                Enemy goblin = new Goblin();
                Enemy dragon = new Dragon();

                // Loot objects
                Loot chestplate = new ChestplateOfDefense();
                Loot helmet = new HelmetOfProtection();
                Loot bow = new BowOfPiercing();
                Loot sword = new SwordOfTruth();

                // Introduction to the game
                player.RestoreToFullHealth();
                Console.WriteLine($"Welcome {player.name}! To attack, you'll just have to press any key.");
                Console.WriteLine("Whenever you're ready, press any key to start.");
                Console.ReadKey();
                Fight1(player, rat, chestplate);

            }
        }
            
        public static void ShowCombatStats(Player player, Enemy enemy) // updates player and enemy stats
        {
            Console.WriteLine("===== Combat Stats =====");

            Console.WriteLine($"Player Health: {player.GetCurrentHealth()} / {player.GetMaxHealth()}");
            Console.WriteLine($"Enemy Health:  {enemy.GetCurrentHealth()}");

            Console.WriteLine("========================");
            return;
        }
        

        public static void Fight1(Player player, Enemy rat, Loot chestplate)
        {
            bool battleActive = true;
            
            Console.Clear();
            Console.WriteLine("You begin travelling the dungeon in search for treasure, " +
                              "after some time you find a giant rat blocking your path!\n");

            while (battleActive)
            {
                // Shows current player and enemy health
                ShowCombatStats(player, rat);
                Console.WriteLine("\nPress any key to attack the enemy\n");
                Console.ReadKey();


                // Runs enemy attack and take damage methods
                rat.TakeDamage(player);
                rat.AttackPlayer(player);

                if (rat.enemyDead) // Check if player has killed the rat
                {
                    battleActive = false;
                    Console.Clear();
                    Console.WriteLine("The rat has been slain!\n");
                    Console.WriteLine("You have obtain the Chestplate Of Defense!\n");

                    chestplate.ItemDescription();

                    Console.WriteLine("Do you want to equip the chestplate? (y/n)");
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        Console.WriteLine("You equipped the chestplate!");
                        player.UpdatePlayerStats(chestplate.addHealth, chestplate.addDamage);
                    }
                    else
                    {
                        Console.WriteLine("You decide to throw the chestplate away.");
                    }

                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();

                }

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
