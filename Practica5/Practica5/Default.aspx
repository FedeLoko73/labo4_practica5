<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Practica5._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Provincias: "></asp:Label>
        <asp:DropDownList ID="ddlprovincias" runat="server" AutoPostBack="True" 
            DataSourceID="SqlDataSource1" DataTextField="descripcion" 
            DataValueField="provincia">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:Labo4_pugnoConnectionString %>" 
            SelectCommand="SELECT [provincia], [descripcion] FROM [provincias]">
        </asp:SqlDataSource>
    
    </div>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Localidades"></asp:Label>
        <asp:ListBox ID="lblocalidades" runat="server" Width="210px"></asp:ListBox>
    </p>
    </form>
</body>
</html>
