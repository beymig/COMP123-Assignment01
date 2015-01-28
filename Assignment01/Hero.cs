using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Hero
    {
        //Random class to be used in different methods
        Random rnd = new Random();
        
        //Private Properties

        private int strength;
        private int speed;
        private int health;
        

        //Public Properties
        public string name;

        //Public Properties
        //Constructor
        public Hero(string name)
        {
            
            this.name = name;

            generateAbilities();
        }

        

        //Receives value to determine if the villain will be hit by the hero
        public void fight()
        {
            hitAttempt();

            if (hitAttempt() == true)
            {
                
                Console.WriteLine("********************SUPERMAN HITS LEX LUTHOR!!! YEEEEI!*******************");
                hitDamage();
                Console.WriteLine("DAMAGE CAUSED ----------------> {0}", hitDamage());
                hitAttempt();
            }
            else
            {
                Console.WriteLine("-----------------------SUPERMAN COULDN'T HIT LEX LUTHOR :( BUUUUU---------------------------");
            }
            
        }

        //Show the hero abilities
        public void show()
        {
            Console.WriteLine("SUPERMAN STRENGHT ------------> {0}", strength);
            Console.WriteLine("SUPERMAN SPEED ---------------> {0}", speed);
            Console.WriteLine("SUPERMAN HEALTH --------------> {0}", health);

        }

       //Private Methods
        //Randomly generates Hero Abilities
        private void generateAbilities()
        {

            strength = rnd.Next(1, 100);
            speed = rnd.Next(1, 100);
            health = rnd.Next(1, 100);

        }
        //Randomly determines if the villain will be hit
        private bool hitAttempt()
        {
            bool hit;
            int rndHit;
            rndHit = rnd.Next(1, 1000);
            if (rndHit <= 200)
            {
                
                hit = true;
                return hit;
            }
            else
            {
                hit = false;
                return hit;
            }

        }

        //Determine the damage occasionated by the hit
        private int hitDamage()
        {
            int damage;
            damage = strength * rnd.Next(1, 6);
            return damage;
        }

        
    }
}
