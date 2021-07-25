using MineSweeper.Constants;
using MineSweeper.Model;
namespace MineSweeper.Service
{
    public class AdjacentCalculator : IAdjacentCalculator
    {
        private readonly Board _board;
        public AdjacentCalculator(Board board)
        {
            _board = board;

        }

        public void CalculateBelowAdjacent(Cell cell)
        {
            if (cell.Row >= _board.MaxRows)
                return;

            var adjacentLocation = new Cell
            {
                Row = GetRowDownIndex(cell.Row),
                Col = cell.Col
            };

            _board.IncrementCellValue(adjacentLocation);
        }

        public void CalculateBelowLeftAdjacent(Cell cell)
        {
            if (cell.Row >= _board.MaxRows ||
                cell.Col <= BoardConstantValues.MinCol ||
                GetRowDownIndex(cell.Row) > _board.MaxRows || 
                GetColumnLeftIndex(cell.Col) < BoardConstantValues.MinCol)
            {
                return;               
            }
            _board.IncrementCellValue(new Cell
            {
                Row = GetRowDownIndex(cell.Row),
                Col = GetColumnLeftIndex(cell.Col)
            });
        }

        public void CalculateBelowRightAdjacent(Cell cell)
        {
            if (cell.Row < _board.MaxRows && cell.Col < _board.MaxColumns)
            {
                _board.IncrementCellValue(new Cell
                {
                    Row = GetRowDownIndex(cell.Row),
                    Col = GetColumnRightIndex(cell.Col)
                });
            }
        }

        public void CalculateLeftAdjacent(Cell cell)
        {
            if (cell.Col <= BoardConstantValues.MinCol)
                return;

            _board.IncrementCellValue(new Cell
            {
                Row = cell.Row,
                Col = GetColumnLeftIndex(cell.Col)
            });
        }

        public void CalculateRightAdjacent(Cell cell)
        {
            if (cell.Col >= _board.MaxColumns)
                return;

            var adjacentLocation = new Cell
            {
                Row = cell.Row,
                Col = GetColumnRightIndex(cell.Col)
            };

            _board.IncrementCellValue(adjacentLocation);
        }

        public void CalculateUpperAdjacent(Cell cell)
        {
            if (cell.Row <= BoardConstantValues.MinRow)
                return;

            var adjacentLocation = new Cell
            {
                Row = GetRowUpIndex(cell.Row),
                Col = cell.Col
            };

            _board.IncrementCellValue(adjacentLocation);
        }

        public void CalculateUpperLeftAdjacent(Cell cell)
        {
            if (cell.Row > BoardConstantValues.MinRow &&
                cell.Col > BoardConstantValues.MinCol)
            {
                _board.IncrementCellValue(new Cell
                {
                    Row = GetRowUpIndex(cell.Row),
                    Col = GetColumnLeftIndex(cell.Col)
                });
            }
        }

        public void CalculateUpperRightAdjacent(Cell cell)
        {
            if (cell.Row > BoardConstantValues.MinRow &&
                cell.Col < _board.MaxColumns)
            {
                _board.IncrementCellValue(new Cell
                {
                    Row = GetRowUpIndex(cell.Row),
                    Col = GetColumnRightIndex(cell.Col)
                });
            }
        }

        private static int GetRowUpIndex(int row)
        {
            return --row;
        }

        private static int GetRowDownIndex(int row)
        {
            return ++row;
        }

        private static int GetColumnRightIndex(int column)
        {
            return ++column;
        }

        private static int GetColumnLeftIndex(int column)
        {
            return --column;
        }
    }
}