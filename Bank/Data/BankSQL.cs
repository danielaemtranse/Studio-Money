using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using StudioByte.StudioMoney.Bank.BE;
using StudioByte.StudioMoney.Bank.Data;

namespace StudioByte.StudioMoney.Bank.Data
{

    public class BankSQL : IBank
    {
        private BankBE objBankBE;
        private FbDataAdapter da;
        private FbCommand cm;
        private DataTable dt = new DataTable();

        public BankSQL()
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

        public DataTable fnSearchBank()
        {

            // Initializate
            cm = new FbCommand();
            dt = new DataTable();

            // Command attributes
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "spBank_SEL_ALL";
            cm.Connection = (FbConnection)objBankBE.oConnection;

            // Stored Procedure Atributtes
            if (ObjBankBE.nBank == 0)
            {
                cm.Parameters.AddWithValue("@sCommand", DBNull.Value);
            }

            else
            {
                cm.Parameters.Add("@sCommand", FbDbType.Char).Value = objBankBE.sSearchCommand;
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

        public DataTable fnGetBank()
        {

            // Initializate
            cm = new FbCommand();
            dt = new DataTable();

            // Command attributes
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "spBank_SEL";
            cm.Connection = (FbConnection)objBankBE.oConnection;

            // Stored Procedure Atributtes
            if (ObjBankBE.nBank == 0)
            {
                cm.Parameters.AddWithValue("@nBank", DBNull.Value);
            }

            else
            {
                cm.Parameters.Add("@nBank", FbDbType.Integer).Value = objBankBE.nBank;
            }

            if (objBankBE.sBank == null)
            {
                cm.Parameters.AddWithValue("@sBank", DBNull.Value);
            }

            else
            {
                cm.Parameters.AddWithValue("@sBank", ObjBankBE.sBank);
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

        public Int32 fnDeleteBank()
        {

            // Initializate
            cm = new FbCommand();

            // Command attributes
            cm.Connection = (FbConnection)objBankBE.oConnection; 
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "spBank_DEL";

            // Stored Procedure Atributtes
            if (ObjBankBE.nBank == 0)
            {
                cm.Parameters.AddWithValue("@w_nBank", DBNull.Value);
            }

            else
            {
                cm.Parameters.Add("@w_nBank", FbDbType.Integer).Value = objBankBE.nBank;
            }

            cm.Parameters.Add("@w_nError", FbDbType.Integer).Direction = ParameterDirection.Output;

            try
            {

                // Execute
                cm.Connection.Open();
                cm.ExecuteNonQuery();

                return (Int32)cm.Parameters["@w_nError"].Value;

            }

            finally
            {

                cm.Dispose();

            }

        }

        public Int32 fnSaveBank()
        {

            // Initializate
            cm = new FbCommand();
            dt = new DataTable();

            // Command attributes
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "SPBANK_IU";
            cm.Connection = (FbConnection)objBankBE.oConnection;

            // Stored Procedure Atributtes
            if (ObjBankBE.nBank == 0)
            {
                cm.Parameters.AddWithValue("@W_NBANK", DBNull.Value);
            }

            else
            {
                cm.Parameters.Add("@W_NBANK", FbDbType.Integer).Value = objBankBE.nBank;
            }

            if (objBankBE.sBank == null)
            {
                cm.Parameters.AddWithValue("@W_SBANK", DBNull.Value);
            }

            else
            {
                cm.Parameters.Add("@W_SBANK", FbDbType.VarChar, 50).Value = objBankBE.sBank;
            }

            cm.Parameters.Add("@W_NERROR", FbDbType.Integer).Direction = ParameterDirection.Output;

            try
            {

                // Execute
                da = new FbDataAdapter(cm);
                da.Fill(dt);
                da.Dispose();

                return Int32.Parse(((DataRow)(dt.Rows[0]))[0].ToString());

            }

            catch (Exception ex)
            {
                return 3;
            }

            finally
            {

                cm.Dispose();
                dt.Dispose();

            }

        }

    }

}
