using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(100, 200);

            player.ShowStats();
        }
    }

    class Player
    {
        private int _speed;
        private int _health;

        public Player(int speed, int health)
        {
            _speed = speed;
            _health = health;
        }

        public void ShowStats()
        {
            Console.WriteLine($"скорость: {_speed}\nздоровье: {_health}");
        }
    }
}
