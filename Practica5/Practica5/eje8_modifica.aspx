<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="eje8_modifica.aspx.vb" Inherits="Practica5.eje8_modifica" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="labelid" runat="server" Text="Id localidad"></asp:Label>
    
        <asp:TextBox ID="txtidlocalidad" runat="server"></asp:TextBox>
    
    </div>
    <asp:Label ID="Label2" runat="server" Text="Cod Postal: "></asp:Label>
    <asp:TextBox ID="txtcodpostal" runat="server"></asp:TextBox>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Provincia: "></asp:Label>
        <asp:TextBox ID="txtprovincia" runat="server"></asp:TextBox>
    </p>
    <asp:Label ID="Label4" runat="server" Text="Descripcion: "></asp:Label>
    <asp:TextBox ID="txtdescripcion" runat="server"></asp:TextBox>
    <p>
        <asp:Button ID="Button1" runat="server" Height="29px" Text="Button" />
        <asp:Label ID="labelerror" runat="server"></asp:Label>
    </p>
    <p>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtidlocalidad" Display="None" 
            ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtcodpostal" Display="None" 
            ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="txtprovincia" Display="None" 
            ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ControlToValidate="txtdescripcion" Display="None" 
            ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
    </p>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
