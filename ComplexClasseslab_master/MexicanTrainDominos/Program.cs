using System;
using DominoClasses;


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Domino Boneyard Test\n");

            Boneyard boneyard = new Boneyard(6);
            Console.WriteLine($"Created a 6/6 boneyard.");
            Console.WriteLine($"Total dominos: {boneyard.NumDominos}");
            Console.WriteLine($"Is empty: {boneyard.IsEmpty}\n");

            Console.WriteLine("Unshuffled Boneyard");
            Console.WriteLine(boneyard.ToString());

            boneyard.Shuffle();
            Console.WriteLine("Shuffled Boneyard");
            Console.WriteLine(boneyard.ToString());

            Console.WriteLine($"Domino at position 0: {boneyard[0]}");
            Console.WriteLine($"Domino at position 1: {boneyard[1]}\n");

            Console.WriteLine("Replacing domino at position 0 with 6/6");
            boneyard[0] = new Domino(6, 6);
            Console.WriteLine($"Domino at position 0: {boneyard[0]}\n");

            Console.WriteLine("Drawing dominos");
            for (int i = 0; i < 3; i++)
            {
                Domino drawn = boneyard.Draw();
                Console.WriteLine($"Drew: {drawn}   Remaining: {boneyard.NumDominos}");
            }
            Console.WriteLine();

            Console.WriteLine("Drawing all dominos from a double-1 boneyard");
            Boneyard small = new Boneyard(1);
            Console.WriteLine($"Small boneyard has {small.NumDominos} dominos.");
            while (!small.IsEmpty)
            {
                Console.WriteLine($"Drew: {small.Draw()}    Remaining: {small.NumDominos}");
            }
            Console.WriteLine($"Is empty: {small.IsEmpty}");

            Domino nullDomino = small.Draw();
            Console.WriteLine($"\nDraw from empty boneyard returns: {(nullDomino == null ? "null (as expected)" : nullDomino.ToString())}");
        }
    }

