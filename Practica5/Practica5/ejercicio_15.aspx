<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ejercicio_15.aspx.vb" Inherits="Practica5.ejercicio_15" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
        <asp:Label ID="Label1" runat="server" Text="Hora carga: "></asp:Label>
        <asp:Label ID="lblhoracarga" runat="server"></asp:Label>
        </br>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    
    <asp:Label ID="Label2" runat="server" Text="Fecha de nacimiento: "></asp:Label>
    
    <asp:TextBox ID="txtfecnac" runat="server" AutoPostBack="True"></asp:TextBox>
    <asp:Label ID="lbledad" runat="server"></asp:Label>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Hora de carga panel: "></asp:Label>
        <asp:Label ID="lblhoracargapanel" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="txtfecnac" ErrorMessage="Fecha invalida" 
            ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((19|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"></asp:RegularExpressionValidator>
    </p>
    </ContentTemplate>
    </asp:UpdatePanel>
    <br /><br /><br /><br />
    
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
        
        cp: 
            <asp:TextBox ID="txtCp" runat="server" AutoPostBack="True"></asp:TextBox>
            
            <asp:Label ID="lblLocalidad" runat="server" Text=""></asp:Label>
        </ContentTemplate>
        </asp:UpdatePanel>
    
    
    </div>
    
    </form>
    
</body>
</html>
