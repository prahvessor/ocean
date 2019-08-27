using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean
{
    class Obstacle : Cell
    {
        #region fields
        private char _obstacleImage = '#';
        #endregion
        #region props
        public char ObstacleImage { get; }
        #endregion
    }
}
