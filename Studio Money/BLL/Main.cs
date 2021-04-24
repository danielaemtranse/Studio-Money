using System.Data;
using StudioMoney.BE;
using StudioMoney.DAL.Main;

namespace StudioMoney.BLL
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
