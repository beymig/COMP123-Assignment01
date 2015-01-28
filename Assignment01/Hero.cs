using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Hero
    {
        
        //Private Properties

        private int strength = 0;
        private int speed = 0;
        private int health = 0;

        //Public Properties
        public string name;

        //Constructor
        public Hero(string name)
        {
            this.strength = 0;
            this.speed = 0;
            this.health = 0;
            this.name = name;

            this.generateAbilities();
        }

        private void generateAbilities()
        {


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
