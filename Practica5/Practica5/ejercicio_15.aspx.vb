Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Partial Public Class ejercicio_15
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.lblhoracarga.Text = DateTime.Now.ToLongTimeString
        Me.lblhoracargapanel.Text = DateTime.Now.ToLongTimeString


    End Sub

    Protected Sub txtfecnac_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtfecnac.TextChanged
        Me.lbledad.Text = DateDiff(DateInterval.Year, CDate(txtfecnac.Text), Today())

    End Sub

    Protected Sub txtCp_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCp.TextChanged
        Dim objlocalidades As New localidades
        Dim dtslocalidades As New DataSet
        Dim intresultado As Integer
        Dim strlocalidades As String

        strlocalidades = Me.txtCp.Text
        intresultado = objlocalidades.RecuperaPorCodPostal(dtslocalidades, strlocalidades)

        If intresultado > 0 Then
            Me.lblLocalidad.Text = dtslocalidades.Tables("localidades").Rows(0).Item("descripcion")
        End If
    End Sub
End Class