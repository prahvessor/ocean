using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean
{
    class Cell
    {
        #region fields
        private Coordinate offset;
        private char _defaultImage = '~';
        #endregion
        #region props
        public char DefaultImage
        {
            get { return _defaultImage; }
        }
        #endregion
        public void display()
        {
            Console.Write(DefaultImage);
        }
    }
}
