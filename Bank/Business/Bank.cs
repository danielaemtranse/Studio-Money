using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using StudioByte.StudioMoney.Bank.BE;
using StudioByte.StudioMoney.Bank.Data;

namespace StudioByte.StudioMoney.Bank.Business
{
    public class Bank
    {

        private BankBE objBankBE;

        public Bank()
        {

        }

        public virtual void Dispose()
        {

        }

        public BankBE ObjBankBE
        {
            get
            {
                return objBankBE;
            }
            set
            {
                objBankBE = value;
            }

        }

        public DataTable fnGetBank()
        {

            // Determine what data class will be used according to connection type
            IBank objData = SBank.GetDataClass(ObjBankBE.oConnection);

            // Fill Business Entity (BE) of data class 
            objData.ObjBankBE = this.ObjBankBE;

            // Execute data class method
            return objData.fnGetBank();

        }

        public DataTable fnSearchBank()
        {

            // Determine what data class will be used according to connection type
            IBank objData = SBank.GetDataClass(ObjBankBE.oConnection);

            // Fill Business Entity (BE) of data class 
            objData.ObjBankBE = this.ObjBankBE;

            // Execute data class method
            return objData.fnSearchBank();
        }

        public Int32 fnDeleteBank()
        {

            // Determine what data class will be used according to connection type
            IBank objData = SBank.GetDataClass(ObjBankBE.oConnection);

            // Fill Business Entity (BE) of data class 
            objData.ObjBankBE = this.ObjBankBE;

            // Execute data class method
            return objData.fnDeleteBank();

        }

        public Int32 fnSaveBank()
        {

            // Determine what data class will be used according to connection type
            IBank objData = SBank.GetDataClass(ObjBankBE.oConnection);

            // Fill Business Entity (BE) of data class 
            objData.ObjBankBE = this.ObjBankBE;

            // Execute data class method
            return objData.fnSaveBank();

        }
    }
}
