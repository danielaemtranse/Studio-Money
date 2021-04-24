using System;

namespace StudioMoney.DAL.Bank
{
    static class SBank
    {
        public static IBank GetDataClass(Object _oConnection)
        {

            return new BankSQL();

        }

    }
}
