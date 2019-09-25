<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GenerateImage.aspx.cs" Inherits="SlideImageGenerator.GenerateImage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>File Manger</title>
    <script src="scripts/jquery-3.3.1.js" type="text/javascript"></script>
    <script src="scripts/jquery-3.3.1.min.js" type="text/javascript"></script>

    <script src="scripts/bootstrap.min.js" type="text/javascript"></script>
    <script src="scripts/bootstrap.js" type="text/javascript"></script>
    <link href="Content/bootstrap.min.css" type="text/css" rel="stylesheet" />
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js" type="text/javascript"></script>
<style>
a {
  text-decoration: none;
  display: inline-block;
  padding: 8px 16px;
}

a:hover {
  background-color: #ddd;
  color: black;
}

.previous {
  background-color: #f1f1f1;
  color: black;
}

.next {
  background-color: #f1f1f1;
  color: black;
}

.round {
  border-radius: 50%;
}
}
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
         
<div class="navbar navbar-inverse navbar-fixed-top">
 <div align="left" style="margin-top: 10%">
      <asp:Label ID="LabelTitle" runat="server" Text="Image Generator" style="font-size: x-large; font-weight: 700; color: #FFFFFF; "></asp:Label>
       
 </div>
 </div> 
    <div class="container body-content">
        <div align="left" style="margin-top: 20%"> 
        
       <div align="left">

        <asp:Label ID="LabelAuthor" runat="server" Text="Author Information      :   " style="font-weight: 700" TabIndex="-1"></asp:Label>
        <asp:TextBox ID="TextBoxAuthor" runat="server" Width="350px" TabIndex="1"></asp:TextBox>
     </div>
                 
       <div align="left"style="margin-top: 5%">

        <asp:Label ID="Label1" runat="server" Text="Session Information:   " style="font-weight: 700" TabIndex="-1"></asp:Label>
        <asp:TextBox ID="TextBoxSession" runat="server" Width="350px" TabIndex="2"></asp:TextBox>
    
           <asp:Button ID="ImageGenerator" runat="server" Text="Generate Image" OnClick="ImageGenerate" TabIndex="3" />     </div>
         </div> 


       </div> 
       
       
</form>

</body>
    
</html>

