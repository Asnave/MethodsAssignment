using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    class Program
    {
        static int score = 0;
        static int health = 100;
        static int lives = 3;
        static int xp = 0;
        static void Main(string[] args)
        {
        }

        static void ShowHUD()
        {
            
            Console.WriteLine("------HUD------");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health" + health);
            Console.WriteLine("Lives" + lives);
            Console.WriteLine("XP" + xp);
            Console.WriteLine("---------------");

        }
    }
}
