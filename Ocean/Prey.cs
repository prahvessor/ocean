using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean
{
    class Prey : Cell
    {
        #region fields
        private int _timeToReproduse = 6;
        private char _defaultPreyImage = 'f';
        #endregion

        #region props
        public int timeToReproduse
        {
            get { return _timeToReproduse; }
            set { _timeToReproduse = value; }
        }
        public char DefaultPreyImage { get; }
        #endregion
    }
}
