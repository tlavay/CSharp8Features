using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharp8Features
{
    public static class UsingDeclarationsExample
    {
        //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/using
        static int WriteLinesToFile(IEnumerable<string> lines)
        {
            // We must declare the variable outside of the using block
            // so that it is in scope to be returned.
            int skippedLines = 0;
            using (var file = new System.IO.StreamWriter("WriteLines2.txt"))
            {
                foreach (string line in lines)
                {
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                    else
                    {
                        skippedLines++;
                    }
                }
            } // file is disposed here
            return skippedLines;
        }
        static int WriteLinesToFileILCode(IEnumerable<string> lines)
        {
            int skippedLines = 0;
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter("WriteLines2.txt");
                foreach (string line in lines)
                {
                    if (!line.Contains("Second"))
                    {
                        streamWriter.WriteLine(line);
                    }
                    else
                    {
                        skippedLines++;
                    }
                }
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Dispose();
                }
            }

            return skippedLines;
        }
        static int WriteLinesToFileNew(IEnumerable<string> lines)
        {
            using var file = new StreamWriter("WriteLines2.txt");
            // Notice how we declare skippedLines after the using statement.
            int skippedLines = 0;
            foreach (string line in lines)
            {
                if (!line.Contains("Second"))
                {
                    file.WriteLine(line);
                }
                else
                {
                    skippedLines++;
                }
            }
            // Notice how skippedLines is in scope here.
            return skippedLines;
            // file is disposed here
        }
    }
}
