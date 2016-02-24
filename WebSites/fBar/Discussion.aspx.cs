using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Discussion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null)
            Response.Redirect("Login.aspx");

        loggedUser.Text = new DAO.Login(Int32.Parse(Session["id"].ToString())).Name;

        if(Request["msg"] != null)
        {
            new DAO.Message(Request["msg"].ToString(), Int32.Parse(Session["id"].ToString()), Int32.Parse(ViewState["thread"].ToString()));
        }

        ViewState["thread"] = Request["thread"].ToString();

        foreach (DAO.Message a in DAO.Message.FromThread(Int32.Parse(Request["thread"].ToString())))
        {
            LiteralControl message = new LiteralControl();
            message.Text = string.Format(@"     <li class=""left clearfix"">
                            
                            <div class=""chat-body clearfix"">
                                <div class=""header"">
                                    <strong class=""primary-font""> {0}</strong> <small class=""pull-right text-muted"">
                                        <span class=""glyphicon glyphicon-time""></span> {1} minutes ago</small>
                                </div>
                                <p>
                                    {2}
                                </p>
                            </div>
                        </li>", a.Author, ((int)(DateTime.Now - a.TimeSent).TotalMinutes).ToString(), a.Text);

            posts.Controls.Add(message);            
        }

    }
}