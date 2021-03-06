﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewThread : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request["title"] != null && Request["description"] != null)
        {
            new DAO.Thread(Request["title"].ToString(), Request["description"].ToString(), Int32.Parse(Session["id"].ToString()));
            Response.Redirect("MainDashboard.aspx");
        }
    }
}