using System;

namespace Module6Lab 
{
    internal class SuperPlayer : Player
    {
        //Additional properties or methods for the SuperPlayer
        //This method is specific to SuperPlayer (it doesn't exist in the parent class of player)

        public void Fly ()
        {
            Console.WriteLine("SuperPlayer is flying!");
        }
            
        }
}
