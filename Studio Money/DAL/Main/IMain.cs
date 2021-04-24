using System.Data;
using StudioMoney.BE;

namespace StudioMoney.DAL.Main
{
    interface IMain
    {

        MainBE ObjMainBE
        {
            get;
            set;

        }

        DataTable fnGetFields();
    }
}
