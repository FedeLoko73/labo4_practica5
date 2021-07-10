Public Partial Class buscar_localidades
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnbuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnbuscar.Click
        recuperalocalides()
    End Sub

    Private Sub gvlocalidaes_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvlocalidaes.PageIndexChanging
        gvlocalidaes.PageIndex = e.NewPageIndex
        recuperalocalides()

    End Sub
    Private Sub recuperalocalides()
        Dim objlocalidades As New localidades
        Dim dtslocalidades As New DataSet
        Dim intresultado As Integer
        Dim strlocalidades As String

        strlocalidades = Me.txtbuscar.Text
        intresultado = objlocalidades.recuperarporlocalidades(dtslocalidades, strlocalidades)

        If intresultado > 0 Then

            Me.gvlocalidaes.DataSource = dtslocalidades.Tables("Localidades")
            Me.gvlocalidaes.DataBind()

        End If
    End Sub

    Protected Sub txtbuscar_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbuscar.TextChanged

    End Sub

    Protected Sub gvlocalidaes_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gvlocalidaes.SelectedIndexChanged

    End Sub
End Class