Public Class Cotizaciones
    Inherits CladPadre
    Public Function RecuperaCoberturaporTipo(ByRef dts As DataSet, ByVal strtipo_cobertura As String) As Integer
        Dim strsql As String
        Dim intresultado As Integer
        strsql = "select * from zf_cot_casco_coberturas where cobertura  = '" + strtipo_cobertura + "'"
        intresultado = Me.RecuperaDataSet(dts, strsql, "zf_cot_casco_coberturas")
        Return intresultado
    End Function
    Public Function RecuperaTasas(ByRef dts As DataSet, ByVal strtipo_cobertura As String, ByVal strtipo_casco As String) As Integer
        Dim strsql As String
        Dim intresultado As Integer
        strsql = "select * from zf_cot_casco_coberturas_tasas where cobertura = '" + strtipo_cobertura + "' and tipo_casco = '" + strtipo_casco + "'"
        intresultado = Me.RecuperaDataSet(dts, strsql, "zf_cot_casco_coberturas_tasas")
        Return intresultado
    End Function

End Class
