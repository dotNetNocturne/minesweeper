using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Minesweeper;
using NUnit.Framework;

namespace Minesweeper_Test
{
    [TestFixture]
    public class CellTest
    {
        private ICell cell = null;

        [SetUp]
        public void setup()
        {
        }

        [Test]
        public void CellStateShouldBeNormal()
        {
            cell = new Cell();
            cell.State.Should().Be(CellState.Normal);
        }

        [Test]
        public void CellStateShouldBeFlagged()
        {
            cell = new Cell();
            cell.CycleFlagState();
            cell.State.Should().Be(CellState.Flagged);
        }

        [Test]
        public void CellStateShouldBeMaybe()
        {
            cell = new Cell();
            cell.CycleFlagState();
            cell.CycleFlagState();
            cell.State.Should().Be(CellState.Maybe);
        }

        [Test]
        public void CellStateShouldReturnToNormal()
        {
            cell = new Cell();
            cell.CycleFlagState();
            cell.CycleFlagState(); 
            cell.CycleFlagState();
            cell.State.Should().Be(CellState.Normal);
        }
    }
}
