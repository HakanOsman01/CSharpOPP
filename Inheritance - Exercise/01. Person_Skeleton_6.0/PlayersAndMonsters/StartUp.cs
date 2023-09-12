using System;
using PlayersAndMonsters.Knights;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            BladeKnight bladeKnight=new BladeKnight("Dark Veider",15);
            Console.WriteLine(bladeKnight);
        }
    }
}