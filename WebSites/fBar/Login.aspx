<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" integrity="sha384-1q8mTJOASx8j1Au+a5WDVnPi2lkFfwwEAa8hDDdjZlpLegxhjVME1fgjWPGmkzs7" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div class="container" style="margin-top:30px">
<div class="col-md-4">
    <div class="panel panel-default">
  <div class="panel-heading"><h3 class="panel-title"><strong>Sign In</strong></h3></div>
  <div class="panel-body">
   <form role="form" action="Login.aspx" method="post">
  <div class="form-group">
    <label for="exampleInputEmail1">Usr</label>
    <input type="text" class="form-control" name="user" id="exampleInputEmail1" placeholder="Enter email">
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Pwd</label>
    <input type="password" class="form-control" name="pwd" id="exampleInputPassword1" placeholder="Password">
  </div>
  <button type="submit" class="btn btn-sm btn-default">Enter</button>
</form>
  </div>
</div>
</div>

    </div>
    </form>
</body>
</html>
