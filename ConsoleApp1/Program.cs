using System;
using System.Diagnostics;
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
                case ConsoleKey.End:
                    showFiles();
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
    static void  showFiles()
    {

        string[] imageFiles = Directory.GetFiles(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Imagefolder"));
        foreach (var item in imageFiles)
        {
            Process.Start("mspaint.exe", item);

        }



    }
    static void captureScreen()
    {
        using Bitmap sc = new(1920, 1080);
        using Graphics gr = Graphics.FromImage(sc);
        gr.CopyFromScreen(0, 0, 0, 0, new Size(1920, 1080));
     
        if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\Imagefolder"))
            Directory.CreateDirectory("C:\\Users\\Agaye_jz58\\Desktop\\Imagefolder");
        sc.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Imagefolder\\Image" + count+++".png");
    }
}