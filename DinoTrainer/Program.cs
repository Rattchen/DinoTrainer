using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoTrainer
{
    class Program
    {

        class Dino{
            // main attributes
            protected string passive;
            protected string active;
            
            protected string species;
            protected string name;
            protected int maxHP;
            protected int maxATK;
            protected int maxSPD;
            // int values
            protected int level; // 1-10
            protected int stage; // 0=egg, 5=dying old
            protected int sensitivity; // 0, 1, 2 - low, mid, high
            protected int trust; // 0, 1, 2 - low, mid, high
            // bool values
            protected bool handicapped;
            protected bool rebellious;
            protected bool exhaust;

            public Dino(string species, string name){
                this.name = name;
                this.species = species;

                switch (species)
                {
                    case "Velociraptor":
                        maxHP = 20;
                        maxATK = 20;
                        break;
                    case "Ditto":
                        maxHP = 10;
                        maxATK = 10;
                        break;
                    default:
                        maxHP = 0;
                        maxATK = 0;
                        break;
                }
            }

            public void attack(Dino dino){
                if (dino.maxHP <= this.maxATK){
                    Console.WriteLine("Won a battle!");            
                }  else {
                    Console.WriteLine("You lost.");
                }
                Console.WriteLine($"Your oponent is {dino.name}");
                }

            public void giveName()
            {
                Console.WriteLine($"Name your new pet {species}!");
                this.name = Console.ReadLine();
            }
            }

        static void Main(string[] args)
        {
            Dino winner = new Dino("Velociraptor", "Veluś");
            winner.giveName();
            Dino loser = new Dino("Ditto", "Marzenie Tesi");
            winner.attack(loser);
            loser.attack(winner);
        }
    }
}
