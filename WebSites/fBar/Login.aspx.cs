using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {       
        if ((Request["user"] != null) && (Request["pwd"] != null))
        {
            Session["id"] = new DAO.Login(Request["user"].ToString(), Request["pwd"].ToString()).Id.ToString();
        }

        if (Session["id"] != null)
        {
            Response.Redirect("MainDashboard.aspx");
        }
    }
}