using System;

public class Dice
{
        //fields
        private const int numOfSides = 6;
        private Random dice;
        private int topSide;

        //proprities 
        public int TopSide{
            get { return topSide;}
        }

        //constructors
        public Dice()
        {
            dice = new Random();
            Roll();
        }
        
        public void Roll()
        {
            topSide = dice.Next(0, numOfSides + 1);
        }


}