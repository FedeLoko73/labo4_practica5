Public Partial Class eje8_modifica
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim strcodpostal As String
            strcodpostal = Request.QueryString("codpostal")
            Me.labelid.Text = strcodpostal

            Dim objLocalidades As New localidades
            Dim dtsCodPostal As New DataSet
            Dim intResultado As Integer

            intResultado = objLocalidades.RecuperaPorCodPostal(dtsCodPostal, strcodpostal)

            If intResultado > 0 Then

                Me.txtcodpostal.Text = dtsCodPostal.Tables("Localidades").Rows(0).Item("codpostal").ToString.Trim()
                Me.txtidlocalidad.Text = dtsCodPostal.Tables("localidades").Rows(0).Item("idlocalidad").ToString.Trim()
                Me.txtprovincia.Text = dtsCodPostal.Tables("localidades").Rows(0).Item("provincia").ToString.Trim()
                Me.txtdescripcion.Text = dtsCodPostal.Tables("localidades").Rows(0).Item("descripcion").ToString.Trim()

            End If
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Protected Sub txb_codpostal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodpostal.TextChanged
        Call ValidarCodPostal()
    End Sub

    Private Sub ValidarCodPostal()

        Dim codpostal = Request.QueryString("codpostal")

        Dim objLocalidades As New Localidades
        Dim dtsCodPostal As New DataSet
        Dim intResultado As Integer

        intResultado = objLocalidades.RecuperaPorCodPostal(dtsCodPostal, codpostal)

        If intResultado > 0 Then
            labelerror.Text = "Ya Existe"
        Else
            labelerror.Text = ""

        End If

    End Sub

    Protected Sub txtidlocalidad_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtidlocalidad.TextChanged

    End Sub
End Class
