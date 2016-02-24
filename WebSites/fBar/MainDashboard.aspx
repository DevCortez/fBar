<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainDashboard.aspx.cs" Inherits="MainDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" integrity="sha384-1q8mTJOASx8j1Au+a5WDVnPi2lkFfwwEAa8hDDdjZlpLegxhjVME1fgjWPGmkzs7" crossorigin="anonymous">
  <style>
      .navbar-xs { min-height:22px; border-radius:0} 
.navbar-xs .navbar-brand{ padding: 2px 8px;font-size: 14px;line-height: 14px; } 
.navbar-xs .navbar-nav > li > a { border-right:1px solid #ddd; padding-top: 2px; padding-bottom: 2px; line-height: 16px }
  </style>
      <title>Principal</title>

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
    <a class="navbar-brand" href="#"><b>f</b>bar</a>
  </div>

  <!-- Collect the nav links, forms, and other content for toggling -->
  <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
    <ul class="nav navbar-nav">
      <li><a href="#"><i class="glyphicon glyphicon-adjust"></i></a></li>
      <li><a href="#"><i class="glyphicon glyphicon-bell"></i></a></li>
      <li><a href="#"><i class="glyphicon glyphicon-user"></i></a></li>
      <li class="dropdown">
        <a href="#" class="dropdown-toggle" data-toggle="dropdown"><b class="caret"></b></a>
        <ul class="dropdown-menu">
          <li><a href="#">Action</a></li>
          <li><a href="#">Another action</a></li>
          <li><a href="#">Something else here</a></li>
          <li class="divider"></li>
          <li><a href="#">Separated link</a></li>
          <li class="divider"></li>
          <li><a href="#">One more separated link</a></li>
        </ul>
      </li>
    </ul>
  </div><!-- /.navbar-collapse -->
</nav>
</div>


</head>
<body>
    <form id="form1" runat="server">
    <div>
    </br>


        <link rel="stylesheet" href="http://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.1.0/css/font-awesome.min.css"/>
<div class="container">
  <asp:PlaceHolder runat="server" ID="threads">

  </asp:PlaceHolder>
  
   
  </div>
</div>

    </div>
    </form>
</body>
</html>
