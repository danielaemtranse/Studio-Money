using System;

namespace StudioMoney.BE
{
    public class BankBE
    {

        private Object _oConnection;
        private Int32 _nBank;
        private String _sBank;
        private String _sSearchCommand;

        public BankBE()
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

        public Int32 nBank
        {
            get
            {
                return _nBank;
            }
            set
            {
                _nBank = value;
            }
        }

        public String sBank
        {
            get
            {
                return _sBank;
            }
            set
            {
                _sBank = value;
            }
        }

        public String sSearchCommand
        {
            get
            {
                return _sSearchCommand;
            }
            set
            {
                _sSearchCommand = value;
            }
        }

    }
}
