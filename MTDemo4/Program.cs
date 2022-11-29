using System.Diagnostics;
using System.Drawing;

namespace MTDemo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Image Flipping App");
            Console.WriteLine("Rotating Images seq...");
            Stopwatch sw = Stopwatch.StartNew();
            RotateImage1();
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine("Rotating Images Parallel....");
            sw.Restart();
            Parallel.Invoke(RotateImage2);
            Console.WriteLine(sw.ElapsedMilliseconds);

        }

        static void RotateImage1()
        {
            var images = Directory.GetFiles("E:\\pictures");
            foreach (var img in images) // Seq
            {
                Bitmap bmp = new Bitmap(img);
                bmp.RotateFlip(RotateFlipType.Rotate180FlipX);
                FileInfo finfo = new FileInfo(img);
                bmp.Save($"E:\\rotatedpictures\\{finfo.Name}");
            }
        }

        static void RotateImage2()
        {
            var images = Directory.GetFiles("E:\\pictures");
            //foreach (var img in images) // Seq
            Parallel.ForEach(images, img =>
            {
                Bitmap bmp = new Bitmap(img);
                bmp.RotateFlip(RotateFlipType.Rotate180FlipX);
                FileInfo finfo = new FileInfo(img);
                bmp.Save($"E:\\rotatedpictures\\{finfo.Name}");
            });
        }
    }
}