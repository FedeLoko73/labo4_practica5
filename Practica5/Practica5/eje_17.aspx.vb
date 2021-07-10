Public Partial Class eje_17
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack = True Then
            Dim objtramites As New localidades
            Dim dts_tramites As New DataSet
            objtramites.RecuperaTramitesPendientesCambioModoPago(dts_tramites)

            gv_tramites.DataSource = dts_tramites.Tables("zf_tramites_modo_pago")
            gv_tramites.DataBind()



        End If
    End Sub

    Private Sub gv_tramites_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gv_tramites.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            If e.Row.Cells(3).Text = "APL" Then
                e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0e400")
                e.Row.FindControl("chkaplicar").Visible = False
            End If
        End If
    End Sub
End Class