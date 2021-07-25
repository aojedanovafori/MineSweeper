using MineSweeper.Constants;
using MineSweeper.Model;
using NUnit.Framework;

namespace MindSweeper.Tests
{
    public static class TestTool
    {
        public static void AssertOutputs(Board actualBoard, int[,] expectedBoard)
        {
            for (var row = BoardConstantValues.MinRow; row <= actualBoard.MaxRows; row++)
            {
                for (var col = BoardConstantValues.MinCol; col <= actualBoard.MaxColumns; col++)
                {
                    Assert.AreEqual(expectedBoard[row, col],
                    actualBoard[new Cell() { Row = row, Col = col }]);
                }
            }
        }

        public static void ArrangeInputs(Board actualBoard, int[,] array)
        {
            for (var row = 0; row <= actualBoard.MaxRows; row++)
            {
                for (var col = 0; col <= actualBoard.MaxColumns; col++)
                {
                    var cell = new Cell() { Row = row, Col = col };

                    actualBoard[cell] = array[row, col];
                }
            }
        }
    }
}