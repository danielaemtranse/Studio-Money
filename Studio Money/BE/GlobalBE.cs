using System;

namespace StudioMoney.BE
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
