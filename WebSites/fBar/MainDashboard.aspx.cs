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

        foreach(Thread thread in Thread.GetAll())
        {
            LiteralControl threadControl = new LiteralControl();
            threadControl.Text = string.Format(@"<div class=""well"">
      < div class=""media"">
      	<a class=""pull-left"" href=""#"">
  		</a>
  		<div class=""media-body"">
    		<h4 class=""media-heading""><a href = ""{0}"" >< b > {1}</b></a></h4>
          <p class=""text-right""><b></b>Started by {2}</b></p>
          <p>{3}
          </p>
          <ul class=""list-inline list-unstyled"">
  			<li><span><i class=""glyphicon glyphicon-calendar""></i> Last active {4} ago</span></li>
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
  </div>", thread.Id, thread.Title, thread.Author, thread.Description, (DateTime.Now - thread.LastActive).ToString(), thread.Id, thread.MessageCount);
        }

        /*
        <div class="well">
      <div class="media">
      	<a class="pull-left" href="#">
  		</a>
  		<div class="media-body">
    		<h4 class="media-heading"><a href="#"><b>Discussão 1</b></a></h4>
          <p class="text-right"><b></b>Carlos</b></p>
          <p>VAIDAMERDA
              GLUGLU
              YEAH YEAH
          </p>
          <ul class="list-inline list-unstyled">
  			<li><span><i class="glyphicon glyphicon-calendar"></i> 2 days, 8 hours </span></li>
            <li>|</li>
            <span><i class="glyphicon glyphicon-comment"></i><a href="#"> 2 comments</a></span>
            <li></li>
            <li>
            </li>
            <li></li>
            <li>
            </li>
			</ul>
       </div>
    </div>
  </div>
  */
    }
}
 