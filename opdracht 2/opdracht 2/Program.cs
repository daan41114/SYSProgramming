using System;

namespace opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy myEnemy = new Enemy();
            int newhelt = myEnemy.helt(10);
            bool yes = true;
            string command = Console.ReadLine();
            while (yes == true)
            {   
                newhelt -= 1;
                Console.WriteLine(newhelt);
                Console.ReadLine();
                if (newhelt == 0)
                {
                    yes = false;
                }
            }
            
        }
    }
    class Enemy
    {
        public int helt(int heltgetal)
        {
            return heltgetal;
        }
        
    }
}
