using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BPS.LineCounter
{
    class Counter
    {
        public static void CountLines(string directory, bool TakeInChildDirectories)
        {
            List<FileInfo> csFiles = new List<FileInfo>();
            List<FileInfo> phpFiles = new List<FileInfo>();
            List<FileInfo> jsFiles = new List<FileInfo>();
            List<FileInfo> htmlFiles = new List<FileInfo>();
            List<FileInfo> cssFiles = new List<FileInfo>();

            List<string> childPaths = new List<string>();

            childPaths.AddRange(Directory.GetFiles(directory, "*", SearchOption.AllDirectories).Where(s => s.EndsWith(".cs") || s.EndsWith(".php") || s.EndsWith(".js") || s.EndsWith(".html") || s.EndsWith(".css")));

            for (int i = 0; i < childPaths.Count; i++)
            {
                string fileName = Path.GetFileName(childPaths[i]);
                string extension = Path.GetExtension(childPaths[i]);

                int lineCount = 0;
                using (StreamReader sr = new StreamReader(childPaths[i]))
                {
                    while (sr.Peek() >= 0)
                    {
                        lineCount++;
                        sr.ReadLine();
                    }
                }

                switch (extension)
                {
                    case ".cs":
                        csFiles.Add(new FileInfo(fileName, lineCount));
                        break;

                    case ".php":
                        phpFiles.Add(new FileInfo(fileName, lineCount));
                        break;

                    case ".js":
                        jsFiles.Add(new FileInfo(fileName, lineCount));
                        break;

                    case ".html":
                        htmlFiles.Add(new FileInfo(fileName, lineCount));
                        break;

                    case ".css":
                        cssFiles.Add(new FileInfo(fileName, lineCount));
                        break;
                }
            }

            //C# INFO
            int totalLines = 0;
            Console.WriteLine(" -- C# FILES: --\n");
            for (int i = 0; i < csFiles.Count; i++)
            {
                Console.WriteLine("> " + csFiles[i].ToString());
                totalLines += csFiles[i].LineCount;
            }
            Console.WriteLine("\n Total c# lines: " + totalLines);
            Console.WriteLine("\n\n");

            //PHP INFO
            totalLines = 0;
            Console.WriteLine("-- PHP FILES: --\n");
            for (int i = 0; i < phpFiles.Count; i++)
            {
                Console.WriteLine("> " + phpFiles[i].ToString());
                totalLines += phpFiles[i].LineCount;
            }
            Console.WriteLine("\n Total php lines: " + totalLines);
            Console.WriteLine("\n\n");

            //JAVASCRIPT INFO
            totalLines = 0;
            Console.WriteLine("-- JAVASCRIPT FILES: --\n");
            for (int i = 0; i < jsFiles.Count; i++)
            {
                Console.WriteLine("> " + jsFiles[i].ToString());
                totalLines += jsFiles[i].LineCount;
            }
            Console.WriteLine("\n Total javascript lines: " + totalLines);
            Console.WriteLine("\n\n");

            //HTML INFO
            totalLines = 0;
            Console.WriteLine("-- HTML FILES: --\n");
            for (int i = 0; i < htmlFiles.Count; i++)
            {
                Console.WriteLine(">" + htmlFiles[i].ToString());
                totalLines += htmlFiles[i].LineCount;
            }
            Console.WriteLine("\n Total html lines: " + totalLines);
            Console.WriteLine("\n\n");

            //CSS INFO
            totalLines = 0;
            Console.WriteLine("-- CSS FILES: --\n");
            for (int i = 0; i < cssFiles.Count; i++)
            {
                Console.WriteLine(">" + cssFiles[i].ToString());
                totalLines += cssFiles[i].LineCount;
            }
            Console.WriteLine("\n Total css lines: " + totalLines);
        }

        public static void CountLines(string[] directories, bool TakeInChildDirectories)
        {
            List<FileInfo> csFiles = new List<FileInfo>();
            List<FileInfo> phpFiles = new List<FileInfo>();
            List<FileInfo> jsFiles = new List<FileInfo>();
            List<FileInfo> htmlFiles = new List<FileInfo>();
            List<FileInfo> cssFiles = new List<FileInfo>();

            List<string> childPaths = new List<string>();

            for (int i = 0; i < directories.Length; i++)
            {
                childPaths.AddRange(Directory.GetFiles(directories[i], "*", SearchOption.AllDirectories).Where(s => s.EndsWith(".cs") || s.EndsWith(".php") || s.EndsWith(".js") || s.EndsWith(".html") || s.EndsWith(".css")));
            }

            for (int i = 0; i < childPaths.Count; i++)
            {
                string fileName = Path.GetFileName(childPaths[i]);
                string extension = Path.GetExtension(childPaths[i]);

                int lineCount = 0;
                using (StreamReader sr = new StreamReader(childPaths[i]))
                {
                    while (sr.Peek() >= 0)
                    {
                        lineCount++;
                        sr.ReadLine();
                    }
                }

                switch (extension)
                {
                    case ".cs": csFiles.Add(new FileInfo(fileName, lineCount)); break;
                    case ".php": phpFiles.Add(new FileInfo(fileName, lineCount)); break;
                    case ".js": jsFiles.Add(new FileInfo(fileName, lineCount)); break;
                    case ".html": htmlFiles.Add(new FileInfo(fileName, lineCount)); break;
                    case ".css": cssFiles.Add(new FileInfo(fileName, lineCount)); break;
                }
            }

            //C# INFO
            int csLines = 0;
            Console.WriteLine(" -- C# FILES: --\n");
            for (int i = 0; i < csFiles.Count; i++)
            {
                Console.WriteLine("> " + csFiles[i].ToString());
                csLines += csFiles[i].LineCount;
            }
            Console.WriteLine("\n Total c# lines: " + csLines);
            Console.WriteLine("\n\n");

            //PHP INFO
            int phpLines = 0;
            Console.WriteLine("-- PHP FILES: --\n");
            for (int i = 0; i < phpFiles.Count; i++)
            {
                Console.WriteLine("> " + phpFiles[i].ToString());
                phpLines += phpFiles[i].LineCount;
            }
            Console.WriteLine("\n Total php lines: " + phpLines);
            Console.WriteLine("\n\n");

            //JAVASCRIPT INFO
            int jsLines = 0;
            Console.WriteLine("-- JAVASCRIPT FILES: --\n");
            for (int i = 0; i < jsFiles.Count; i++)
            {
                Console.WriteLine("> " + jsFiles[i].ToString());
                jsLines += jsFiles[i].LineCount;
            }
            Console.WriteLine("\n Total javascript lines: " + jsLines);
            Console.WriteLine("\n\n");

            //HTML INFO
            int htmlLines = 0;
            Console.WriteLine("-- HTML FILES: --\n");
            for (int i = 0; i < htmlFiles.Count; i++)
            {
                Console.WriteLine(">" + htmlFiles[i].ToString());
                htmlLines += htmlFiles[i].LineCount;
            }
            Console.WriteLine("\n Total html lines: " + htmlLines);
            Console.WriteLine("\n\n");

            //CSS INFO
            int cssLines = 0;
            Console.WriteLine("-- CSS FILES: --\n");
            for (int i = 0; i < cssFiles.Count; i++)
            {
                Console.WriteLine(">" + cssFiles[i].ToString());
                cssLines += cssFiles[i].LineCount;
            }
            Console.WriteLine("\n Total css lines: " + cssLines + "\n");

            Console.WriteLine("------------------------");
            int absoluteLines = csLines + phpLines + jsLines + htmlLines + cssLines;
            Console.WriteLine("\n Absolute Total Lines: " + absoluteLines);

        }

        struct FileInfo
        {
            public readonly string Path;
            public readonly int LineCount;

            public FileInfo(string path, int lineCount)
            {
                Path = path;
                LineCount = lineCount;
            }

            public override string ToString()
            {
                return (Path + ": " + LineCount + " lines");
            }
        }
    }
}
