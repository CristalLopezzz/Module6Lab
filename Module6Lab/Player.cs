using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6Lab 
{
    
    internal class Player 
    {
        //Attributes (characteristics that describe a player)

        private string name;

        private int score;

        private int livesLeft;

        public Player()
        {  
        }

        //Constructors - methods that create a new instance instance of the object

        public Player(string name) 
        {
            this.name = name; //Sets the name of the player on the name attribute

        } //end constructor method

        //Create a player that has both the name and the livesLeft set immediately

        public Player(string name, int startingLives) 
        {
            this.name = name; //sets the name of the player
            livesLeft = startingLives;

        } //end constructor method

        //Methods for the player class - actions that the plauer can perform

        //Retrun the player's current score

        public int GetScore() 
        {
            return score;
        } //end getScore method

        //Adds points to the player's score

        public void AddPoints(int totalPoints) 
        {
            score += totalPoints;
        } //end addPoints method

        //Kill metod - it allows you to kill off the player

        public void Kill() 
        {
            //We want to make sure that can't get negative lives
            if(livesLeft > 0) 
            {
                livesLeft --;
            } //end if
        } //end kill method

        //Get the lives left for the player
        public int GetLivesLeft()
        {
            return livesLeft;
        }
    } //end class
} //end namespace