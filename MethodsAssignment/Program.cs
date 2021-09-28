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
        static int ScoreM = 2;
        static int enemyValue = 5;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Pretty Cool Game");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ReadKey(true);

            ShowHUD();

            Console.WriteLine("");
            Console.WriteLine("You began with all your equipment from previous levels");
            Console.WriteLine("Including a new Score Multiplier which increases your Score by X2");
            Console.WriteLine("");
            Console.ReadKey(true);

            Damage(10);
            ShowHUD();

            Console.WriteLine("");
            Console.WriteLine("As you ride into battle you get strucken by an arrow");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Taking -10 Damage");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.ReadKey(true);

            AddScore(enemyValue, 2);
            ShowHUD();

            Console.WriteLine("");
            Console.WriteLine("With your mighty sword out you spear head a goblin");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You gain: " + enemyValue + " points to your score with the muiltplier of X2 increasing it to 10!");
            Console.WriteLine("");
            Console.ReadKey(true);
            Console.ResetColor();

            AddScore(10, 1);
            ShowHUD2();

            Console.WriteLine("");
            Console.WriteLine("This time you gallop into an orc, slaying it with one swipe");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Riding as fast as you are, your Score multiplier falls out of one of your pockets");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You gain only +10 points to your score because of the lack of the multiplier ");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("");
            Console.WriteLine("As you get closer and closer to the enemys lines they bring out a cave troll ");
            Console.WriteLine(" which smashes you and your horse into the ground mutliple times over then chucking you into the distance");
            Console.ResetColor();
            Console.ReadKey(true);

            GameOver();

            Console.ReadKey(true);
        }

        static void ShowHUD()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("------HUD------");
            Console.ResetColor();
            Console.WriteLine(" ScoreMulti: " + ScoreM);
            Console.WriteLine(" Score: " + score);
            Console.WriteLine(" Health: " + health);
            Console.WriteLine(" Lives: " + lives);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("---------------");
            Console.ResetColor();

        }

        static void Damage(int damage)
        {
            health = health - damage;
        }

        static void AddScore( int enemyValue, int ScoreMulti)
        {

            score = score + enemyValue * ScoreMulti;


        }

        static void ShowHUD2()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("------HUD------");
            Console.ResetColor();
            Console.WriteLine(" ScoreMulti: ");
            Console.WriteLine(" Score: " + score);
            Console.WriteLine(" Health: " + health);
            Console.WriteLine(" Lives: " + lives);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("---------------");
            Console.ResetColor();

        }

        static void GameOver()
        {
            lives = 0;
            health = 0;
            score = 0;
            ShowHUD2();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("YOU DIED");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("  =====    ========   ==     ==   =======");
            Console.WriteLine("=      =   =      =   = =   = =   =      ");
            Console.WriteLine("=      =   =      =   =  = =  =   =      ");
            Console.WriteLine("=          ========   =   =   =   =======");
            Console.WriteLine("=    ===   =      =   =       =   =      ");
            Console.WriteLine("=      =   =      =   =       =   =      ");
            Console.WriteLine(" =     =   =      =   =       =   =      ");
            Console.WriteLine("  =====    =      =   =       =   =======");
            Console.WriteLine("");
            Console.WriteLine(" ======    =     =    ========   ========");
            Console.WriteLine("=      =   =     =    =          =      =");
            Console.WriteLine("=      =   =     =    =          =      =");
            Console.WriteLine("=      =   =     =    ========   ========");
            Console.WriteLine("=      =   =     =    =          =     = ");
            Console.WriteLine("=      =    =   =     =          =      =");
            Console.WriteLine("=      =    =   =     =          =      =");
            Console.WriteLine("=      =    =   =     =          =      =");
            Console.WriteLine(" ======      ==       ========   =      =");
            Console.ResetColor();
            Console.ReadKey(true);


        }
    } 
}
