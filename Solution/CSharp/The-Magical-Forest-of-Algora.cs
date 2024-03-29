using System;
using System.Collections.Generic;

public enum DanceMove
{
    Twirl,
    Leap,
    Spin
}

public class Creature
{
    public string? Name { get; set; }
    public List<DanceMove>? DanceMoves { get; set; }
}

public class Forest
{
    public string? State { get; set; }
}

public class Algora
{
    public static void Main(string[] args)
    {
        var lox = new Creature { Name = "Lox", DanceMoves = new List<DanceMove> { DanceMove.Twirl, DanceMove.Leap, DanceMove.Spin, DanceMove.Twirl, DanceMove.Leap } };
        var drako = new Creature { Name = "Drako", DanceMoves = new List<DanceMove> { DanceMove.Spin, DanceMove.Twirl, DanceMove.Leap, DanceMove.Leap, DanceMove.Spin } };

        var forest = new Forest { State = "Normal" };

        for (int i = 0; i < 5; i++)
        {
            var loxMove = lox.DanceMoves[i];
            var drakoMove = drako.DanceMoves[i];

            if (loxMove == DanceMove.Twirl && drakoMove == DanceMove.Twirl)
            {
                forest.State = "Fireflies light up the forest.";
            }
            else if ((loxMove == DanceMove.Leap && drakoMove == DanceMove.Spin) || (loxMove == DanceMove.Spin && drakoMove == DanceMove.Leap))
            {
                forest.State = "A rainbow appears in the sky.";
            }
            else
            {
                forest.State = "Gentle rain starts falling.";
            }

            Console.WriteLine($"After sequence {i + 1}, {forest.State}");
        }
    }
}