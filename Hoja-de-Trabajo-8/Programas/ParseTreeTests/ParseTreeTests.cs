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
            ParseTree.ParseTree sut = new ParseTree.ParseTree("1+3*2+8");
            sut.Expandir();
            Assert.Equal(15, sut.Evaluar());
        }
    }
}
