Public Partial Class Federico_Pugno_201810
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



    End Sub


  
    Protected Sub rblis_cobertura_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rblis_cobertura.SelectedIndexChanged
        Dim objcoberturas As New Cotizaciones
        Dim dtscoberturas As New DataSet
        Dim strtipo_cobertura As String
        Dim intresultado As Integer
        If rblis_cobertura.SelectedValue = "A" Then

            strtipo_cobertura = "A"
            lbl_cob_a.Visible = True
            lbl_cob_b.Visible = False
            intresultado = objcoberturas.RecuperaCoberturaporTipo(dtscoberturas, strtipo_cobertura)
            If intresultado > 0 Then
                Me.lbl_cob_a.Text = dtscoberturas.Tables("zf_cot_casco_coberturas").Rows(0).Item("descripcion")
            End If
        ElseIf rblis_cobertura.SelectedValue = "B" Then

            strtipo_cobertura = "B"
            lbl_cob_a.Visible = False
            lbl_cob_b.Visible = True
            intresultado = objcoberturas.RecuperaCoberturaporTipo(dtscoberturas, strtipo_cobertura)
            If intresultado > 0 Then
                Me.lbl_cob_b.Text = dtscoberturas.Tables("zf_cot_casco_coberturas").Rows(0).Item("descripcion")
            End If
        End If

    End Sub

   
    Protected Sub btn_calcular_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_calcular.Click
        Dim objtasacobertura As New Cotizaciones
        Dim dtstasacobertura As New DataSet
        Dim strtipo_cobertura As String
        Dim strtipo_casco As String
        Dim intresultado As Integer
        Dim tasa As Decimal
        Dim sumas As Decimal = Convert.ToDecimal(txt_suma.Text)




        If ddl_tipo.SelectedValue = "LAN" Then
            strtipo_cobertura = rblis_cobertura.SelectedValue
            strtipo_casco = ddl_tipo.SelectedValue
            intresultado = objtasacobertura.RecuperaTasas(dtstasacobertura, strtipo_cobertura, strtipo_casco)
            If intresultado > 0 Then
                tasa = dtstasacobertura.Tables("zf_cot_casco_coberturas_tasas").Rows(0).Item("tasa")
                txt_premio.Text = (tasa * sumas / 1000).ToString
            End If
        ElseIf ddl_tipo.SelectedValue = "YAT" Then
            strtipo_cobertura = rblis_cobertura.SelectedValue
            strtipo_casco = ddl_tipo.SelectedValue
            intresultado = objtasacobertura.RecuperaTasas(dtstasacobertura, strtipo_cobertura, strtipo_casco)
            If intresultado > 0 Then
                tasa = dtstasacobertura.Tables("zf_cot_casco_coberturas_tasas").Rows(0).Item("tasa")
                txt_premio.Text = (tasa * sumas / 1000).ToString
            End If
        ElseIf ddl_tipo.SelectedValue = "VEL" Then
            strtipo_cobertura = rblis_cobertura.SelectedValue
            strtipo_casco = ddl_tipo.SelectedValue
            intresultado = objtasacobertura.RecuperaTasas(dtstasacobertura, strtipo_cobertura, strtipo_casco)
            If intresultado > 0 Then
                tasa = dtstasacobertura.Tables("zf_cot_casco_coberturas_tasas").Rows(0).Item("tasa")
                txt_premio.Text = (tasa * sumas / 1000).ToString
            End If

        End If

    End Sub
End Class