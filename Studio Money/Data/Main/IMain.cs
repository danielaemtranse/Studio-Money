using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using StudioByte.StudioMoney.Main.BE;

namespace StudioByte.StudioMoney.Main.Data
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
