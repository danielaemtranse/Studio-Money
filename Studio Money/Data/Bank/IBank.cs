using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using StudioByte.StudioMoney.Bank.BE;

namespace StudioByte.StudioMoney.Bank.Data
{
    interface IBank
    {

        BankBE ObjBankBE
        {
            get;
            set;

        }

        DataTable fnGetBank();
        DataTable fnSearchBank();
        Int32 fnDeleteBank();
        Int32 fnSaveBank();
    }
}
