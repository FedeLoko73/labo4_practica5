<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="eje_17.aspx.vb" Inherits="Practica5.eje_17" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gv_tramites" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="aplicar">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkaplicar" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="apynom" HeaderText="apynomb" />
                <asp:BoundField DataField="modo_pago" HeaderText="modo_pago" />
                <asp:BoundField DataField="estado" HeaderText="estado" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
