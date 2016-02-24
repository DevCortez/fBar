<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewThread.aspx.cs" Inherits="NewThread" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" integrity="sha384-1q8mTJOASx8j1Au+a5WDVnPi2lkFfwwEAa8hDDdjZlpLegxhjVME1fgjWPGmkzs7" crossorigin="anonymous">
    <title>Starting a new thread</title>
    <link rel="stylesheet" type="text/css" href="css/Composer.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>


 <link rel="stylesheet" href="http://fontawesome.io/assets/font-awesome/css/font-awesome.css">
<div class="container">
	<div class="row">
		<h3>Start new discussion</h3>
	</div>
    
    <div class="row">
    
    <div class="col-md-6">
    						<div class="widget-area no-padding blank">
								<div class="status-upload">
									<form action="NewThread.aspx">
										<input name="title" type="text" class="form-control" placeholder="Discussion title" aria-describedby="basic-addon1">
                                        
                                        <textarea name="description" style="width:100%" placeholder="Discussion description" ></textarea>

										</br><button type="submit" class="btn btn-success green"><i class="fa fa-share"></i> Start discussion</button>
									</form>
								</div><!-- Status Upload  -->
							</div><!-- Widget Area -->
						</div>        
    </div>
</div>

    </div>
    </form>
</body>
</html>
