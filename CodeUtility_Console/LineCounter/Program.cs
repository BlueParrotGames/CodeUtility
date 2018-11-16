using System;
using BPS.LineCounter;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the path of your master directory here: ");
        string directory = Console.ReadLine();

        Console.Write("Do you the program to also read your sub-folders for files? (y/n):");
        string subFolderCheck = Console.ReadLine();

        Console.Clear();

        if (subFolderCheck.ToLower() == "y") Counter.CountLines(directory, true);
        else if (subFolderCheck.ToLower() == "n") Counter.CountLines(directory, false);

        Console.ReadKey();
    }
}
