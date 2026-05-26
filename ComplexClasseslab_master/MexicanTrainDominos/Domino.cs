using System;

namespace DominoClasses
{
    public class Domino
    {
        private int side1;
        private int side2;

        public Domino(int side1, int side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public int Side1
        {
            get { return side1; }
        }

        public int Side2
        {
            get { return side2; }
        }

        public int TotalDots
        {
            get { return side1 + side2; }
        }

        public bool IsDouble
        {
            get { return side1 == side2; }
        }

        public override string ToString()
        {
            return $"[{side1}|{side2}]";
        }
    }
}
