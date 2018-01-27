using System;


class RealBpmCounterByMe
{
    static void Main()
    {
        double beatsPerMinute = double.Parse(Console.ReadLine());
        double numberOfBeats = double.Parse(Console.ReadLine());

        double bars = numberOfBeats / 4;

        double beatForOneSecond = 60 / beatsPerMinute;
        double allSecondsBeats = numberOfBeats * beatForOneSecond;

        int minutes = (int)allSecondsBeats / 60;
        int seconds = (int)allSecondsBeats % 60;

        Console.WriteLine($"{Math.Round(bars, 1)} bars - {minutes}m {seconds}s");

    }
}
