using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;

public partial class MainDashboard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null)
            Response.Redirect("Login.aspx");

        loggedUser.Text = new DAO.Login(Int32.Parse(Session["id"].ToString())).Name;

        foreach(Thread thread in Thread.GetAll())
        {
            LiteralControl threadControl = new LiteralControl();
            threadControl.Text = string.Format(@"<div class=""well"">
      	<a class=""pull-left"" href=""#"">
  		</a>
  		<div class=""media-body"">
    		<h4 class=""media-heading""><a href = ""{0}"" ><b> {1}</b></a></h4>
          <p class=""text-right""><b></b>Started by {2}</b></p>
          <p>{3}
          </p>
          <ul class=""list-inline list-unstyled"">
  			<li><span><i class=""glyphicon glyphicon-calendar""></i> Last active {4} minute(s) ago</span></li>
            <li>|</li>
            <span><i class=""glyphicon glyphicon-comment""></i><a href = ""{5}"" > {6} messages</a></span>
            <li></li>
            <li>
            </li>
            <li></li>
            <li>
            </li>
			</ul>
       </div>
    </div>
  ", "Discussion.aspx?thread=" + thread.Id, thread.Title, thread.Author, thread.Description, ((int)(DateTime.Now - thread.LastActive).TotalMinutes).ToString(), "Discussion.aspx?thread=" + thread.Id, thread.MessageCount);
            threads.Controls.Add(threadControl);
        }
    }
}
 