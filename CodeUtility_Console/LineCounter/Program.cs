using System;
using System.IO;
using BPS.LineCounter;

class Program
{
    static void Main(string[] args)
    {
        string dir;
        string[] trackedDirs;
        bool multiPath = true;
        bool subFolderCheck = true;

        // Checking files!
        if (File.Exists("trackedfiles.txt"))
        {
            Console.WriteLine("I found the file!");
        }
        else
        {
            Console.WriteLine("The file isn't there! :( I'll create it!");
            File.Create("trackedfiles.txt");
        }

        Console.ReadKey();

        // Check for single or multi path
        Console.WriteLine("Use your tracked paths (trackedfiles.txt) or single path (t/s)");
        if(Console.ReadLine().ToLower() == "t")
            multiPath = true;

        else if(Console.ReadLine().ToLower() == "s")
            multiPath = false;


        Console.Write("Do you the program to also read your sub-folders for files? (y/n):");
        if (Console.ReadLine().ToLower() == "y")
            subFolderCheck = true;

        else if (Console.ReadLine().ToLower() == "n")
            subFolderCheck = false;


        if(multiPath)
        {
            Console.WriteLine("Using tracked paths!");
            trackedDirs = File.ReadAllLines("trackedfiles.txt");
            Console.WriteLine("Here are all your currently tracked directories: ");

            for (int i = 0; i < trackedDirs.Length; i++)
            {
                string d = trackedDirs[i];
                Console.WriteLine(d);
            }

            Counter.CountLines(trackedDirs, subFolderCheck);

        }
        else if(!multiPath)
        {
            Console.Write("Enter the path of your master directory here: ");
            dir = Console.ReadLine();
            Counter.CountLines(dir, subFolderCheck);
        }

        //string subFolderCheck = Console.ReadLine();

        //if (subFolderCheck.ToLower() == "y")
        //    Counter.CountLines(directory, true);

        //else if (subFolderCheck.ToLower() == "n")
        //    Counter.CountLines(directory, false);

        Console.WriteLine("\nEnter to close app");

        Console.ReadKey();
    }
}
