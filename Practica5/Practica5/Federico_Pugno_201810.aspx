<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Federico_Pugno_201810.aspx.vb" Inherits="Practica5.Federico_Pugno_201810" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Tipo Embaracion: "></asp:Label>
        <asp:DropDownList ID="ddl_tipo" runat="server" AutoPostBack="True">
            <asp:ListItem Value="LAN">LANCHA</asp:ListItem>
            <asp:ListItem Value="YAT">YATE</asp:ListItem>
            <asp:ListItem Value="VEL">VELERO</asp:ListItem>
        </asp:DropDownList>
    
    </div>
    <asp:Label ID="Label2" runat="server" Text="Cobertura: "></asp:Label>
    <p>
        <asp:RadioButtonList ID="rblis_cobertura" runat="server" AutoPostBack="True">
            <asp:ListItem Value="A">Cob. A</asp:ListItem>
            <asp:ListItem Value="B">Cob. B</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <asp:Label ID="lbl_cob_a" runat="server"></asp:Label>
    <asp:Label ID="lbl_cob_b" runat="server"></asp:Label>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Suma Asegurada: "></asp:Label>
        <asp:TextBox ID="txt_suma" runat="server"></asp:TextBox>
    </p>
    <asp:Label ID="Label4" runat="server" Text="Premio Anual: "></asp:Label>
    <asp:TextBox ID="txt_premio" runat="server" Enabled="False"></asp:TextBox>
    <p>
        <asp:Button ID="btn_calcular" runat="server" Text="Calcular" />
    </p>
    </form>
</body>
</html>
