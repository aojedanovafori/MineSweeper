using System;
using System.Collections.Generic;
using System.Text;
using MineSweeper.Constants;

namespace MineSweeper.Model
{
    public class Board
    {
        private readonly int[,] _cells;
        private int _maxColumns { get; set; }
        private int _maxRows { get; set; }

        public int MaxRows
        {
            get { return _maxRows - 1; }
        }

        public int MaxColumns
        {
            get { return _maxColumns - 1; }
        }

        public Board(int maxRows, int maxColumns)
        {
            if (maxRows < 2 || maxColumns < 2)
            {
                throw new Exception("Rows and columns must be at least 2");
            }
            _maxRows = maxRows;
            _maxColumns = maxColumns;
            _cells = new int[maxRows, maxColumns];
        }

        public int this[Cell cellLocation]
        {
            get { return _cells[cellLocation.Row, cellLocation.Col]; }
            set { _cells[cellLocation.Row, cellLocation.Col] = value; }
        }

        public void IncrementCellValue(Cell cell)
        {
            var currentValue = this[cell];
            if (currentValue == BoardConstantValues.Mine)
                return;
            this[cell] = currentValue + 1;
        }
    }
}
