using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ParseTreeTests
{
    public class ParseTreeTests
    {
        [Fact]
        public void EvaluarTest()
        {
            ParseTree.ParseTree sut = new ParseTree.ParseTree("6+5*7+4");
            sut.Expandir();
            Assert.Equal(45, sut.Evaluar());
        }
    }
}
