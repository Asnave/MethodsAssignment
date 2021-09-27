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
            ShowHUD();
            Console.ReadKey(true);
        }

        static void ShowHUD()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("------HUD------");
            Console.ResetColor();
            Console.WriteLine(" Score: " + score);
            Console.WriteLine(" Health: " + health);
            Console.WriteLine(" Lives: " + lives);
            Console.WriteLine(" XP: " + xp);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("---------------");
            Console.ResetColor();

        }

        static void Damage(int damage)
        {
            health = health - damage;
        }

        static void AddScore(int enemyValue, int ScoreMulti)
        { 

        }
        
    }
}
