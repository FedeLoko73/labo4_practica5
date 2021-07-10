Public Class localidades
    Inherits CladPadre

    Public Function recuperalocalidadesporprovincia(ByRef dts As DataSet, ByVal strprovincia As String) As Integer
        Dim strsql As String
        Dim intresultado As Integer
        strsql = "select * from localidades where provincia='" + strprovincia + "'"
        intresultado = Me.RecuperaDataSet(dts, strsql, "localidades")
        Return intresultado
    End Function

    Public Function recuperarporlocalidades(ByRef dts As DataSet, ByVal strlocalides As String) As Integer
        Dim strsql As String
        Dim intresultado As Integer
        strsql = "select * from localidades where descripcion like '" + strlocalides + "%'"
        intresultado = Me.RecuperaDataSet(dts, strsql, "localidades")
        Return intresultado
    End Function

    Public Function RecuperaPorCodPostal(ByRef dts As DataSet, ByVal strcodpostal As String) As Integer
        Dim strsql As String
        Dim intresultado As Integer
        strsql = "select * from localidades where codpostal = '" + strcodpostal + "'"
        intresultado = Me.RecuperaDataSet(dts, strsql, "localidades")
        Return intresultado
    End Function
    Public Function RecuperaTramitesPendientesCambioModoPago(ByVal dtsDataSet As DataSet) As Integer
        Dim strSql As String
        Dim intResultado As Integer
        Dim dtFechaHoy As DateTime

        dtFechaHoy = CDate("11/09/2018")


        strSql = "Select zf_tramites_modo_pago.nro_tramite ,   " & "zf_tramites_modo_pago.fecha_tramite,   " & "(zf_clientes.apellido_razon_social + ' ' + zf_clientes.nombre) as apynom,   " & "zf_tramites_modo_pago.modo_pago,   " & _
         "zf_tramites_modo_pago.estado  " & _
         "FROM zf_clientes, " & _
         "zf_tramites_modo_pago " & _
         "WHERE ( zf_clientes.nro_cliente = zf_tramites_modo_pago.nro_cliente ) And  " & _
         "( ( zf_tramites_modo_pago.estado = 'PEN' ) OR  " & _
         "( dateadd(month,1, zf_tramites_modo_pago.fecha_aplicacion ) > getdate()  ) )"
        '' " + CStr(dtFechaHoy) + "'
        intResultado = Me.RecuperaDataSet(dtsDataSet, strSql, "zf_tramites_modo_pago")

        Return intResultado

    End Function

    


End Class
