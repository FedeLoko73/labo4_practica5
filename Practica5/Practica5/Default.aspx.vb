Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Me.DataBind()
            Me.ddlprovincias.Items.Insert(0, "Seleccione...")
        End If
    End Sub

    Protected Sub ddlprovincias_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddlprovincias.SelectedIndexChanged
        Dim objlocalidades As New localidades
        Dim dtslocalidades As New DataSet
        Dim intresultado As Integer
        Dim strprovincia As String

        strprovincia = Me.ddlprovincias.SelectedValue
        intresultado = objlocalidades.recuperalocalidadesporprovincia(dtslocalidades, strprovincia)

        If intresultado > 0 Then
            Me.lblocalidades.DataTextField = "Descripcion"
            Me.lblocalidades.DataValueField = "codpostal"
            Me.lblocalidades.DataSource = dtslocalidades.Tables("Localidades")
            Me.lblocalidades.DataBind()

        End If
    End Sub

    Protected Sub SqlDataSource1_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles SqlDataSource1.Selecting

    End Sub
End Class