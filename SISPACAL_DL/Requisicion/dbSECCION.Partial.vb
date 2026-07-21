Partial Public Class dbSECCION


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaParaRequisicion() As listaSECCION
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM SECCION ")
        strSQL.Append("WHERE VER_REQUISICION = 1 ")
        strSQL.Append("ORDER BY NOMBRE_SECCION")

        Dim dr As IDataReader


        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())


        Dim lista As New listaSECCION

        Try
            Do While dr.Read()
                Dim mEntidad As New SECCION
                dbAsignarEntidades.AsignarSECCION(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaParaOrdenCombustible() As listaSECCION
        Dim args As New List(Of SqlParameter)
        Dim arg As SqlParameter
        Dim strSQL As New StringBuilder
        Dim strCond As New StringBuilder
        strSQL.Append("SELECT * ")
        strSQL.Append("FROM SECCION ")
        strSQL.Append("WHERE VER_ORDEN_COMB = 1 ")
        strSQL.Append("ORDER BY NOMBRE_SECCION")

        Dim dr As IDataReader


        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())


        Dim lista As New listaSECCION

        Try
            Do While dr.Read()
                Dim mEntidad As New SECCION
                dbAsignarEntidades.AsignarSECCION(dr, mEntidad)
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
