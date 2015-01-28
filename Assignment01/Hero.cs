using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Hero
    {

        Random rnd = new Random();
        //Private Properties

        private int strength =0;
        private int speed;
        private int health;
        

        //Public Properties
        public string name;

        //Constructor
        public Hero(string name)
        {
            
            this.name = name;

            this.generateAbilities();
        }

        private void generateAbilities(Random rnd)
        {
            
            strength = rnd.Next(1,100);
            speed = rnd.Next(1, 100);
            health = rnd.Next(1, 100);

        }

        public bool hitAttempt()
        {


        }

        private bool hitAttempt()
        {

        }

        private int hitDamage()
        {

        }

        public void show ()
        {


        }
    }
}
