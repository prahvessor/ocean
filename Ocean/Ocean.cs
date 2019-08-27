using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean
{
    class Ocean
    {
        #region fields
        private int _maxCols = 70;
        private int _maxRows = 25;
        private Cell[,] cells;
        private int _size;
        private int _numPrey = 150;
        private int _numPredators = 20;
        private int _numObstacles = 75;
        private static Random random = new Random();

        #endregion

        #region props
        public int Size
        {
            get {return _size; }
        }
        public int NumPrey
        {
            get { return _numPrey; }
            set { _numPrey = value; }
        }

        public int NumPredators
        {
            get { return _numPredators; }
            set { _numPredators = value; }
        }
        public int NumObstacles
        {
            get { return _numObstacles; }
            set { _numObstacles = value; }
        }
        #endregion

        #region ctors
        public Ocean()
        {
            _size = _maxCols * _maxRows;
            cells = new Cell[_maxRows, _maxCols];
        }

        public Ocean(int numCols, int numRows)
        {
            this._maxCols = numCols;
            this._maxRows = numRows;
            cells = new Cell[_maxRows, _maxCols];
        }
        #endregion

        #region override
        public override string ToString()
        {
            return string.Format("Ocean has size {0}x{1} cells", _maxCols, _maxRows);
        }
        #endregion

        #region methods
        public void initialise()
        {
            for (int i = 0; i < _maxRows; i++)
            {
                for (int j = 0; j < _maxCols; j++)
                {
                    cells[i,j] = new Cell();
                }
            }
        }

        public void display()
        {
            for (int i = 0; i < _maxRows; i++)
            {
                for (int j = 0; j < _maxCols; j++)
                {
                    Console.Write(cells[i,j].DefaultImage);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < _maxCols; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
            Console.WriteLine(
              "  Iteration number: {0}, Obstacles: {1}, Predators: {2}, Preys: {3}", 
              _size, _numObstacles, _numPredators, _numPrey);
        }
        #endregion
    }
}
