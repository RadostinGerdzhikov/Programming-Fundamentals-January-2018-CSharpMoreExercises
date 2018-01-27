using System;

class MegaPixels
{
    static void Main()
    {
        double widthImage = double.Parse(Console.ReadLine());
        double heightImage = double.Parse(Console.ReadLine());
        double megapixels = Math.Round ((widthImage * heightImage)/1000000 , 1);
        
        Console.WriteLine(widthImage + "x" + heightImage + " => " + megapixels + "MP");         
    }
}