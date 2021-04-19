using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using StudioByte.StudioMoney.Main.BE;
using StudioByte.StudioMoney.Main.Data;

namespace StudioByte.StudioMoney.Main.Business
{
    public class Main
    {

        private MainBE objMainBE;

        public Main()
        {

        }

        public virtual void Dispose()
        {

        }

        public MainBE ObjMainBE
        {
            get
            {
                return objMainBE;
            }
            set
            {
                objMainBE = value;
            }

        }

        public DataTable fnGetFields()
        {

            // Determine what data class will be used according to connection type
            IMain objData = SMain.GetDataClass(ObjMainBE.oConnection);

            // Fill Business Entity (BE) of data class 
            objData.ObjMainBE = this.ObjMainBE;

            // Execute data class method
            return objData.fnGetFields();

        }
    }
}
