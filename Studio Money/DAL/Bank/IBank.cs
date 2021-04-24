using System;
using System.Data;
using StudioMoney.BE;

namespace StudioMoney.DAL.Bank
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
