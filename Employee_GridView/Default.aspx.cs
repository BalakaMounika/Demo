using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee_GridView
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lbInsert_Click(sender,e);
            //LinkButton lbInsert = new LinkButton();
            //lbInsert.Click += new EventHandler(lbInsert_Click);
        }
        protected void lbInsert_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            SqlDataSource1.InsertParameters["Name"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtName")).Text;
            SqlDataSource1.InsertParameters["Gender"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("ddlGender")).Text;
            SqlDataSource1.InsertParameters["City"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtCity")).Text;

            SqlDataSource1.Insert();
        }

    }
}
