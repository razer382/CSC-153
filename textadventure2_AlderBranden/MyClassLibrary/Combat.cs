using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Combat
    {
        public static void Attack(ref int health, ref int enemyHP) 
        {
            Random rand = new Random(); // Simulates attacking something and possibly taking damage
            int damage = rand.Next(20);
            int damaged = rand.Next(20);
            health = health - damaged;
            enemyHP = enemyHP - damage;
            
        }
    }
}
