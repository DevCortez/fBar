<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Discussion.aspx.cs" Inherits="Discussion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" integrity="sha384-1q8mTJOASx8j1Au+a5WDVnPi2lkFfwwEAa8hDDdjZlpLegxhjVME1fgjWPGmkzs7" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="css/Composer.css"> 
    <style>
      .navbar-xs { min-height:22px; border-radius:0} 
.navbar-xs .navbar-brand{ padding: 2px 8px;font-size: 14px;line-height: 14px; } 
.navbar-xs .navbar-nav > li > a { border-right:1px solid #ddd; padding-top: 2px; padding-bottom: 2px; line-height: 16px }
  </style>

    <div class="container">
    <nav class="navbar navbar-default navbar-xs" role="navigation">
  <!-- Brand and toggle get grouped for better mobile display -->
  <div class="navbar-header">
    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
      <span class="sr-only">Main dashboard</span>
      <span class="icon-bar"></span>
      <span class="icon-bar"></span>
      <span class="icon-bar"></span>
    </button>
    <a class="navbar-brand" href="MainDashboard.aspx">f<b>bar</b></a>
  </div>

  <!-- Collect the nav links, forms, and other content for toggling -->
  <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
    <ul class="nav navbar-nav">
      <li><a href="NewThread.aspx"><i class="glyphicon glyphicon-comment"></i> Nova discussão</a></li>
      <li><a href="#"><i class="glyphicon glyphicon-user"></i> <asp:Literal runat="server" ID="loggedUser"></asp:Literal></a> </li>
      <li><a href="MainDashboard.aspx"><i class="glyphicon glyphicon-arrow-left"></i> Retornar</a></li>
         
    </ul>
  </div><!-- /.navbar-collapse -->
</nav>
</div>


</head>
<body>
    <form id="form1" runat="server">
    <div>
    



        <div class="container">
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <span class="glyphicon glyphicon-comment"></span> Discussion
                    <div class="btn-group pull-right">


                    </div>
                </div>


                <div class="panel-body">
                    <ul class="chat">

                        <asp:PlaceHolder runat="server" ID="posts">


        </asp:PlaceHolder>
                       
                        
                    </ul>
                </div>
                <div class="panel-footer">
                    <div class="input-group">
                        <form action="Discussion.aspx">
                        <input name="msg" id="btn-input" type="text" class="form-control input-sm" placeholder="Reply" />
                        <span class="input-group-btn">
                            <button type="submit" class="btn btn-warning btn-sm" id="btn-chat">
                                Send</button>
                        </span>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>




        

    </div>
    </form>
</body>
</html>
