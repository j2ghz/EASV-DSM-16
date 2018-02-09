using System;
using Kalaha.Models;
using Xunit;

namespace Kalaha.UnitTest
{
    public class BoardTests
    {
        readonly Board board = new Board(6,4);
        [Fact]
        public void HousesHaveOpposites()
        {
            Assert.All(board.South.Houses,h=> Assert.NotNull(h.Opposite));
            Assert.All(board.North.Houses, h => Assert.NotNull(h.Opposite));
        }
        [Fact]
        public void HousesHaveNexts()
        {
            Assert.All(board.South.Houses, h => Assert.NotNull(h.Next));
            Assert.All(board.North.Houses, h => Assert.NotNull(h.Next));
        }
        [Fact]
        public void StoresHaveNexts()
        {
            Assert.NotNull(board.South.Store.Next);
            Assert.NotNull(board.North.Store.Next);
        }
    }
}
