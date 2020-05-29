using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Features.Examples
{
    public sealed class AsyncStreams
    {
        private readonly string filePath = @"C:\Users\tylavay\Documents\SampleText";

        public async Task<IEnumerable<string>> GetFileContentsOld()
        {
            //Notice the using declarations??? ;)
            using var streamReader = File.OpenText(this.filePath);
            var lines = new List<string>();

            string line = null;
            while ((line = await streamReader.ReadLineAsync()) != null)
            {
                lines.Add(line);
            }

            return lines;
        }

        //1. It's declared with the async modifier.
        //2. It returns an IAsyncEnumerable<T>.
        //3. The method contains yield return statements to return successive elements in the asynchronous stream.
        public async IAsyncEnumerable<string> GetFileContentsNew()
        {
            using var streamReader = File.OpenText(this.filePath);

            string readText = null;
            while ((readText = await streamReader.ReadLineAsync()) != null)
            {
                yield return readText;
            }
        }
    }
}
