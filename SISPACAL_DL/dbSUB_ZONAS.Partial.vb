Partial Public Class dbSUB_ZONAS
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista() As listaSUB_ZONAS
        Dim args As New List(Of SqlParameter)
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * FROM SUB_ZONAS ORDER BY ZONA, SUB_ZONA")

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaSUB_ZONAS

        Try
            Do While dr.Read()
                Dim mEntidad As New SUB_ZONAS
                dbAsignarEntidades.AsignarSUB_ZONAS(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function
End Class
