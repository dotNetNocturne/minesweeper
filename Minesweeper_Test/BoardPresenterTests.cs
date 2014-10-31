using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minesweeper;
using NUnit.Framework;


namespace Minesweeper_Test
{
    [TestFixture]
    public class BoardPresenterTests
    {
        [Test]
        public void InitBoard_WithOneRowOneColumn()
        {

            
            var boardPresenter = new BoardPresenter();
            

            Assert.AreEqual(1, boardPresenter.CellsCount);
            
        }

        [Test]
        public void InitBoard_WithOneRowAnd2Colums()
        {
            var boardPresenter = new BoardPresenter();
            boardPresenter.Init(1, 2);
            Assert.AreEqual(2, boardPresenter.CellsCount);
        }

        
    }
}
