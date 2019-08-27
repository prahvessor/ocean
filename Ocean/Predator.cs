using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean
{
    class Predator : Prey
    {
        #region fields
        private int _timeToFeed = 6;
        private char _defaultPredImage = 'S';
        #endregion
        #region props
        public int TimeToFeed
        {
            get { return _timeToFeed; }
            set { _timeToFeed = value; }
        }
        public char DefaultPredImage { get; }
        #endregion
    }
}
