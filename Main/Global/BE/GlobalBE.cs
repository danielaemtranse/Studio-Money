using System;
using System.Collections.Generic;
using System.Text;

namespace StudioByte.StudioMoney.Global.BE
{
    public static class GlobalBE
    {

        public static String _sOpenedItem;

        public static String sOpenedItem
        {
            get
            {
                return _sOpenedItem;
            }
            set
            {
                _sOpenedItem = value;
            }
        }

    }
}
