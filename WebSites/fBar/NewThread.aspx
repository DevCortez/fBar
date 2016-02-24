<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewThread.aspx.cs" Inherits="NewThread" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" integrity="sha384-1q8mTJOASx8j1Au+a5WDVnPi2lkFfwwEAa8hDDdjZlpLegxhjVME1fgjWPGmkzs7" crossorigin="anonymous">
    <title>Starting a new thread</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>


        <div class="container">
	<div class="row">
		<div class="span4 well" style="padding-bottom:0">
            <form accept-charset="UTF-8" action="" method="POST">
                <textarea class="span4" id="new_message" name="new_message"
                placeholder="Type in your message" rows="5"></textarea>
                <h6 class="pull-right">320 characters remaining</h6>
                <button class="btn btn-info" type="submit">Post New Message</button>
            </form>
        </div>
	</div>
</div>

    </div>
    </form>
</body>
</html>
