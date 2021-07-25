

using MindSweeper.Tests;
using MineSweeper.Constants;
using MineSweeper.Model;
using MineSweeper.Service;
using NUnit.Framework;

namespace MineSweeper.Tests
{

    public class AdjacentCalculatorTests
    {
        private int[,] _board = new int[,]
            {
                { BoardConstantValues.Mine, 0, 0 },
                { 0, 0, BoardConstantValues.Mine }
            };
        
        private IAdjacentCalculator _adjacentCalculator { get; set; }

        public void AdjacentCalculator()
        {
            _adjacentCalculator = new AdjacentCalculator(new Board(0, 0));
        }

        [Test]
        public void CalculateBelowAdjacentMethod_FindsTheBelowCellAndIncrementsTheCellValue_SetsTheBoardToNewCorrectStatus()
        {
            // Arrange
            var actualBoard = new Board(2, 3);

            TestTool.ArrangeInputs(actualBoard, _board);

            // Act
            _adjacentCalculator = new AdjacentCalculator(actualBoard);
            _adjacentCalculator.CalculateBelowAdjacent(new Cell { Row = 0, Col = 0 });

            // Assert
            var expectedBoard = new int[,]
            {
                { BoardConstantValues.Mine, 0, 0 },
                { 1, 0, BoardConstantValues.Mine }
            };

            TestTool.AssertOutputs(actualBoard, expectedBoard);
        }

        [Test]
        public void CalculateBelowAdjacentMethod__ShouldNotIncrementCellValue_WhenCellOutOfBounds()
        {
            // Arrange
            var actualBoard = new Board(2, 3);

            TestTool.ArrangeInputs(actualBoard, _board);

            // Act
            _adjacentCalculator = new AdjacentCalculator(actualBoard);
            _adjacentCalculator.CalculateBelowAdjacent(new Cell { Row = 1, Col = 0 });

            // Assert
            var expectedBoard = new int[,]
            {
                { BoardConstantValues.Mine, 0, 0 },
                { 0, 0, BoardConstantValues.Mine }
            };

            TestTool.AssertOutputs(actualBoard, expectedBoard);
        }

        [Test]
        public void CalculateBelowRightAdjacentMethod__ShouldNotIncrementCellValue_WhenCellOutOfBounds()
        {
            // Arrange
            var actualBoard = new Board(2, 3);

            TestTool.ArrangeInputs(actualBoard, _board);

            // Act
            _adjacentCalculator = new AdjacentCalculator(actualBoard);
            _adjacentCalculator.CalculateBelowAdjacent(new Cell { Row = 0, Col = 2 });

            // Assert
            var expectedBoard = new int[,]
            {
                { BoardConstantValues.Mine, 0, 0 },
                { 0, 0, BoardConstantValues.Mine }
            };

            TestTool.AssertOutputs(actualBoard, expectedBoard);
        }

        [Test]
        public void CalculateBelowRightAdjacentMethod__FindsTheBelowRightCellAndIncrementsTheCellValue_SetsTheBoardToNewCorrectStatus()
        {
            // Arrange
            var actualBoard = new Board(2, 3);

            TestTool.ArrangeInputs(actualBoard, _board);

            // Act
            _adjacentCalculator = new AdjacentCalculator(actualBoard);
            _adjacentCalculator.CalculateBelowRightAdjacent(new Cell { Row = 0, Col = 0 });

            // Assert
            var expectedBoard = new int[,]
            {
                { BoardConstantValues.Mine, 0, 0 },
                { 0, 1, BoardConstantValues.Mine }
            };

            TestTool.AssertOutputs(actualBoard, expectedBoard);
        }


        [Test]
        public void CalculateRightAdjacentMethod_FindsTheRightCellAndIncrementsTheCellValue_SetsTheBoardToNewCorrectStatus()
        {
            // Arrange
            var actualBoard = new Board(2, 3);

            TestTool.ArrangeInputs(actualBoard, _board);

            // Act
            _adjacentCalculator = new AdjacentCalculator(actualBoard);
            _adjacentCalculator.CalculateRightAdjacent(new Cell { Row = 0, Col = 0 });

            // Assert
            var expectedBoard = new int[,]
            {
                { BoardConstantValues.Mine, 1, 0 },
                { 0, 0, BoardConstantValues.Mine }
            };

            TestTool.AssertOutputs(actualBoard, expectedBoard);
        }

        [Test]
        public void CalculateRightAdjacentMethody_ShouldNotIncrementCellValue_WhenCellOutOfBounds()
        {
            // Arrange          
            var actualBoard = new Board(2, 3);

            TestTool.ArrangeInputs(actualBoard, _board);

            // Act
            _adjacentCalculator = new AdjacentCalculator(actualBoard);
            _adjacentCalculator.CalculateRightAdjacent(new Cell { Row = 0, Col = 2 });

            // Assert
            var expectedBoard = new int[,]
            {
                { BoardConstantValues.Mine, 0, 0 },
                { 0, 0, BoardConstantValues.Mine }
            };

            TestTool.AssertOutputs(actualBoard, expectedBoard);
        }

        [Test]
        public void CalculateBelowLeftAdjacentMethod_ShouldNotIncrementCellValue_WhenCellOutOfBounds()
        {
            // Arrange
            var actualBoard = new Board(2, 3);

            TestTool.ArrangeInputs(actualBoard, _board);

            // Act
            _adjacentCalculator = new AdjacentCalculator(actualBoard);
            _adjacentCalculator.CalculateBelowLeftAdjacent(new Cell { Row = 0, Col = 0 });

            // Assert
            var expectedBoard = new int[,]
            {
                { BoardConstantValues.Mine, 0, 0 },
                { 0, 0, BoardConstantValues.Mine }
            };

            TestTool.AssertOutputs(actualBoard, expectedBoard);
        }

        [Test]
        public void CalculateBelowLeftAdjacentMethod_FindsTheLeftCellAndIncrementsTheCellValue_SetsTheBoardToNewCorrectStatus()
        {
            // Arrange
            var actualBoard = new Board(2, 3);

            TestTool.ArrangeInputs(actualBoard, _board);

            // Act
            _adjacentCalculator = new AdjacentCalculator(actualBoard);
            _adjacentCalculator.CalculateBelowLeftAdjacent(new Cell { Row = 0, Col = 2 });

            // Assert
            var expectedBoard = new int[,]
            {
                { BoardConstantValues.Mine, 0, 0 },
                { 0, 1, BoardConstantValues.Mine }
            };

            TestTool.AssertOutputs(actualBoard, expectedBoard);
        }

    }
}
