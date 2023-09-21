using System;
using System.Drawing;

class Program
{
    static int count = 1;
    static void Main()
    {
        int start = 1;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("press enter");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Enter:
                    captureScreen();
                    break;
                case ConsoleKey.Escape:
                    showFiles();
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
    static void  showFiles()
    {
        int temp = 1;
        while (temp != count)
        {
            Console.WriteLine(Path.GetFileNameWithoutExtension("C:\\Users\\user\\Desktop\\Imagefolder\\Image" + temp + ".png"));
            ++temp;
        }
        

    }
    static void captureScreen()
    {
        using Bitmap sc = new(1920, 1080);
        using Graphics gr = Graphics.FromImage(sc);
        gr.CopyFromScreen(0, 0, 0, 0,new Size(1920,1080));
        sc.Save("C:\\Users\\user\\Desktop\\Imagefolder\\Image" + count+++".png");
    }
}