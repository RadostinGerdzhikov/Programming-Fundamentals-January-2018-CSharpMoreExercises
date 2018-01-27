using System;

class PhotoGalery
{
    static void Main()
    {
        int numPhoto = int.Parse(Console.ReadLine());
        int dayTakePhoto = int.Parse(Console.ReadLine());
        int monthTakePhoto = int.Parse(Console.ReadLine());
        int yearTakePhoto = int.Parse(Console.ReadLine());
        int hourTakePhoto = int.Parse(Console.ReadLine());
        int minTakePhoto = int.Parse(Console.ReadLine());
        int sizePhotoBytes = int.Parse(Console.ReadLine());
        int photoWidth = int.Parse(Console.ReadLine());
        int photoHeight = int.Parse(Console.ReadLine());

        double sizeMbPhoto = (double)sizePhotoBytes /1000000;
        double sizeKbPhoto = (double)sizePhotoBytes / 1000;

        Console.WriteLine($"Name: DSC_{numPhoto:d4}.jpg");
        Console.WriteLine($"Date Taken: {dayTakePhoto:d2}/{monthTakePhoto:d2}/{yearTakePhoto} {hourTakePhoto:d2}:{minTakePhoto:d2}");

        if (sizePhotoBytes < 1001 )
        {
            Console.WriteLine($"Size: {sizePhotoBytes}B");
        }
        else if (sizePhotoBytes < 1000001)
        {
            Console.WriteLine($"Size: {sizeKbPhoto}KB");
        }

        else if (sizePhotoBytes > 1000000) // провери дали работи само с else
        {
            Console.WriteLine($"Size: {sizeMbPhoto}MB");
        }

        if (photoWidth < photoHeight)
        {
            Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (portrait)");
        }
        else if (photoWidth == photoHeight)
        {
            Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (square)");
        }
        else
        {
            Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (landscape)");
        }

    }
}