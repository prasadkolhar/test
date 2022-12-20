<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Addcategory.aspx.cs" Inherits="Addcategory" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;Catagory ID&nbsp;&nbsp; :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Catagory Name :<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;<asp:Button ID="Button1" runat="server" Height="29px" onclick="Button1_Click" 
            Text="Add" Width="120px" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Add_Product.aspx">Product</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
