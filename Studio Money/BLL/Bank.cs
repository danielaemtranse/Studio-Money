using System;
using System.Data;
using StudioMoney.BE;
using StudioMoney.DAL.Bank;

namespace StudioMoney.BLL
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
