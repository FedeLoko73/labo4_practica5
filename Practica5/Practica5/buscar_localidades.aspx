<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="buscar_localidades.aspx.vb" Inherits="Practica5.buscar_localidades" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Buscar: "></asp:Label>
        <asp:TextBox ID="txtbuscar" runat="server"></asp:TextBox>
        <asp:Button ID="btnbuscar" runat="server" Text="Buscar" />
    
    </div>
    <asp:GridView ID="gvlocalidaes" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" 
        BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" 
        PageSize="5" Width="309px">
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <Columns>
            <asp:BoundField DataField="codpostal" />
            <asp:BoundField DataField="Provincia" />
            <asp:HyperLinkField DataNavigateUrlFields="codpostal" 
                DataNavigateUrlFormatString="eje8_modifica.aspx?codpostal={0}" 
                DataTextField="descripcion" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="Gainsboro" />
    </asp:GridView>
    </form>
</body>
</html>
