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
        public static int absoluteLines;

        public static void CountLines(string[] directories, bool useCSS, bool useHTML, bool usePHP, bool useCS, bool useJS)
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

                if(useCS && extension.Equals(".cs"))
                {
                    csFiles.Add(new FileInfo(fileName, lineCount));
                }

                if (usePHP && extension.Equals(".php"))
                {
                    phpFiles.Add(new FileInfo(fileName, lineCount));
                }

                if ( useJS && extension.Equals(".js"))
                {
                    jsFiles.Add(new FileInfo(fileName, lineCount));
                }

                if (useHTML && extension.Equals(".html"))
                {
                    htmlFiles.Add(new FileInfo(fileName, lineCount));
                }

                if (useCSS && extension.Equals(".css"))
                {
                    cssFiles.Add(new FileInfo(fileName, lineCount));
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
            absoluteLines = csLines + phpLines + jsLines + htmlLines + cssLines;
            Console.WriteLine("\n Absolute Total Lines: " + absoluteLines);

            DBConnection dbConn = new DBConnection();
            dbConn.Initialise();
            dbConn.Update(absoluteLines);
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
