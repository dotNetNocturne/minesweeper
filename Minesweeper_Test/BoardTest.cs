using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using Minesweeper;
using NUnit.Framework;

namespace Minesweeper_Test
{
    [TestFixture]
    public class BoardTest
    {

        private BoardBuilder _boardBuilder;

        [SetUp]
        public void setup()
        {
            _boardBuilder = new BoardBuilder();
        }

        [Test]
        public void Board_Size_ShouldBeSpecifiedSize()
        {
            var w = 5;
            var h = 6;
            var board = _boardBuilder.SetWidth(w).SetHeight(h).Build();

            board.Width.Should().Be(w);
            board.Height.Should().Be(h);
        }

        /// <summary>
        /// For user story 2
        /// </summary>
        [Test]
        public void OverlapMinesTest()
        {
            var boardComponent = new BoardComponent();
            const int width = 5;
            const int height = 5;
            const int minesToAdd = 5;

            _boardBuilder.SetHeight(width);
            _boardBuilder.SetWidth(height);

            var board = _boardBuilder.Build();
            boardComponent.GenerateMines(board, minesToAdd);

            var minesFound = 0;
            for (int i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    var cell = board.GetCellAt(i, j);
                    if (cell.HasMine)
                        minesFound++;
                }
            }

            Assert.AreEqual(minesToAdd, minesFound);
        }

        [Test]
        public void OverlapMinesTest2()
        {
            var boardComponent = new BoardComponent();
            const int width = 5;
            const int height = 5;
            const int minesToAdd = 26;

            _boardBuilder.SetHeight(width);
            _boardBuilder.SetWidth(height);

            try
            {
                var board = _boardBuilder.Build();
                boardComponent.GenerateMines(board, minesToAdd);

                var minesFound = 0;
                for (int i = 0; i < height; i++)
                {
                    for (var j = 0; j < width; j++)
                    {
                        var cell = board.GetCellAt(i, j);
                        if (cell.HasMine)
                            minesFound++;
                    }
                }
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Mine number excedes total number of cells");
            }

        }
    }
}
