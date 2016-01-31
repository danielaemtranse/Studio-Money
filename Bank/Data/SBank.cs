using System;
using System.Collections.Generic;
using System.Text;

namespace StudioByte.StudioMoney.Bank.Data
{
    static class SBank
    {
        public static IBank GetDataClass(Object _oConnection)
        {

            return new BankSQL();

        }

    }
}
