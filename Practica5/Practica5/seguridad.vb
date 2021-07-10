Public Class seguridad
    Inherits CladPadre
    
    Public Function recuperausuario(ByRef dtsUsuario As DataSet, ByVal strUsuario As String) As Integer
        Dim strsql As String
        Dim intresultado As Integer
        strsql = "select * from zf_usuarios where usuario = '" + strUsuario + "'"
        intresultado = Me.RecuperaDataSet(dtsUsuario, strsql, "zf_usuarios")
        Return intresultado
    End Function


End Class
