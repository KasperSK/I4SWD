using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStocking
{
    public interface IBtnHandler
    {
        void StartBtnPushed();
        void StopBtnPushed();
    }


    public class StockingCtrl : IBtnHandler
    {
        private readonly ICompressionCtrl _compressionCtrl;
        private bool _stateOfCompression;

        public StockingCtrl(ICompressionCtrl compressionCtrl)
        {
            _compressionCtrl = compressionCtrl;
            _stateOfCompression = false;
        }


        // From IBtnHandler
        public void StartBtnPushed()
        {
            if (!_stateOfCompression)
            {
                _compressionCtrl.Compress();
                _stateOfCompression = true;
            }
        }

        public void StopBtnPushed()
        {
            if (_stateOfCompression)
            {
                _compressionCtrl.Decompress();
                _stateOfCompression = false;
            }
        }


    }
}
