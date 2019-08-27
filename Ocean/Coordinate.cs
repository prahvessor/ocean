﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean
{
    struct Coordinate
    {
        #region fields
        private int _x;
        private int _y;
        #endregion
        #region props
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        #endregion
    }

}
