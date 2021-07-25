
using MineSweeper.Model;

namespace MineSweeper.Service
{
    public interface IAdjacentCalculator
    {
        public void CalculateBelowAdjacent(Cell mineCell);
        public void CalculateBelowLeftAdjacent(Cell mineCell);
        void CalculateBelowRightAdjacent(Cell mineCell);
        void CalculateLeftAdjacent(Cell mineCell);
        void CalculateRightAdjacent(Cell mineCell);
        void CalculateUpperAdjacent(Cell mineCell);
        void CalculateUpperLeftAdjacent(Cell mineCell);
        void CalculateUpperRightAdjacent(Cell mineCell);
    }
}
