using System;

namespace StudioMoney.BE
{
    public class MainBE
    {

        private Object _oConnection;
        private String _sItem;

        public MainBE()
        {

        }

        public Object oConnection
        {
            get
            {
                return _oConnection;
            }
            set
            {
                _oConnection = value;
            }
        }

        public String sItem
        {
            get
            {
                return _sItem;
            }
            set
            {
                _sItem = value;
            }
        }

    }
}
