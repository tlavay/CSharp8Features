using CSharp8Features.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ExampleTests
{
    public class Examples
    {
        [Fact]
        public async Task AsyncStreams_GetFileContentsOld()
        {
            //Arrange
            var asyncStreamsExample = new AsyncStreams();

            //Act
            var linesNotDeffered = await asyncStreamsExample.GetFileContentsOld();
            var linesDeffered = asyncStreamsExample.GetFileContentsNew();

            var lines = new List<string>();
            await foreach (var line in linesDeffered)
            {
                lines.Add(line);
            }

            //Assert
            var oldWay = string.Join(" ", linesNotDeffered);
            var newWay = string.Join(" ", lines);
            Assert.Equal(oldWay, newWay);
        }


        [Fact]
        public async Task AsyncStreams_GetFileContentsOld_WhyThisIsCool()
        {
            //Arrange
            var asyncStreamsExample = new AsyncStreams();

            //Act
            var resultsOld = await asyncStreamsExample.GetFileContentsOld();
            var resultsNew = asyncStreamsExample.GetFileContentsNew();

            resultsOld.Any2(e => e == "Async");
            await DeferedLinq.Any3(resultsNew, e => e == "Async");
        }

        [Fact]
        public void InterfaceExample_MethodA()
        {
            //Arrange
            var interfaceExample = new InterfaceExample();

            //Act
            Execute(interfaceExample);
        }

        private void Execute(IInterfaceExample interfaceExample)
        {
            var result = interfaceExample.MethodB();
        }
    }
}
