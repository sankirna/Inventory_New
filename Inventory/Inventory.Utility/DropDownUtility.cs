using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Inventory.Utility
{
    public static class DropDownUtility
    {
        public static DropDownList BindDropDown(this DropDownList drpdown, object dataSouce, string TextField, string valueField)
        {
            drpdown.Items.Clear();
            drpdown.Items.Add(new ListItem { Text = "--Select--", Value = "0", Selected = true });
            drpdown.DataSource = dataSouce;
            drpdown.DataTextField = TextField;
            drpdown.DataValueField = valueField;
            drpdown.DataBind();

            return drpdown;
        }
    }
}