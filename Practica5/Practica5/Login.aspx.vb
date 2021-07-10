Public Partial Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    

    Protected Sub Login1_Authenticate(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.AuthenticateEventArgs) Handles Login1.Authenticate
        Dim strPWDBD As String
        Dim objseguridad As New seguridad
        Dim dtsusuario As New DataSet
        Dim intresultado As Integer
        Dim strusuario As String
        strusuario = Me.Login1.UserName

        intresultado = objseguridad.recuperausuario(dtsusuario, Me.Login1.UserName)

        If intresultado = 1 Then
            strPWDBD = dtsusuario.Tables("zf_usuarios").Rows(0).Item("clave").ToString.Trim
            If Me.Login1.Password = strPWDBD Then
                FormsAuthentication.RedirectFromLoginPage(strusuario, True)
                Session("usuario") = strusuario

            End If
        End If
    End Sub
End Class