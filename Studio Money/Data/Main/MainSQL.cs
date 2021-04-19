using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using StudioByte.StudioMoney.Main.BE;
using StudioByte.StudioMoney.Main.Data;

namespace StudioByte.StudioMoney.Main.Data
{

    public class MainSQL : IMain
    {
        private MainBE objMainBE;
        private FbDataAdapter da;
        private FbCommand cm;
        private DataTable dt = new DataTable();

        public MainSQL()
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

            // Initializate
            cm = new FbCommand();
            dt = new DataTable();

            // Command attributes
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "spFields_SEL";
            cm.Connection = (FbConnection)objMainBE.oConnection;

            // Stored Procedure Atributtes
            if (ObjMainBE.sItem == "")
            {
                cm.Parameters.AddWithValue("@w_sItem", DBNull.Value);
            }

            else
            {
                cm.Parameters.Add("@w_sItem", ObjMainBE.sItem);
            }

            try
            {

                // Execute
                da = new FbDataAdapter(cm);
                da.Fill(dt);
                da.Dispose();

                return dt;

            }

            finally
            {

                cm.Dispose();
                dt.Dispose();

            }

        }


    }

}
