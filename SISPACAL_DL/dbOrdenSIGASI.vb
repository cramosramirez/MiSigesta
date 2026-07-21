Public Class dbOrdenSIGASI

    Public Function AgregarValesx(codibarra As String, femision As DateTime, hemision As String, codigo As Decimal, idorden As Int32, placa As String, valor As Decimal, _
                                  fecha As Date, numero As Int32, total As Decimal, _
                                  actualiza As Boolean, nrc As String, nit As String, nombre As String, nocuenta As String) As Int32
        Dim adapter As New DS_DS1TableAdapters.valesxTableAdapter
        Return adapter.Insert(codibarra, femision, hemision, codigo, idorden, placa, valor, fecha, numero, total, actualiza, nrc, nit, nombre, nocuenta)
    End Function

    Public Function ActualizarPorLoteORDEN_COMSUSTIBLE() As Integer
        Dim lEntidad As ORDEN_COMBUSTIBLE
        Dim lRet As Integer = 0
        Dim cambios As Boolean = False
        Dim dbEntidad As New dbORDEN_COMBUSTIBLE
        Dim adapter As New DS_DS1TableAdapters.valesxTableAdapter
        Dim dt As New DS_DS1.valesxDataTable
        Dim dbFechaH As New dbFechaHora
        adapter.FillNoActualizados(dt)

        For Each fila As DS_DS1.valesxRow In dt.Rows
            lEntidad = New ORDEN_COMBUSTIBLE
            lEntidad.ID_ORDEN_COMBUS = fila.idorden
            dbEntidad.Recuperar(lEntidad)
            If lEntidad IsNot Nothing AndAlso lEntidad.ID_ORDEN_COMBUS > 0 Then
                lEntidad.FECHA_DESPACHO = fila.fecha
                lEntidad.NO_FACTURA_CCF = fila.numero
                lEntidad.TOTAL = fila.total
                lEntidad.ESTADO = "F"
                lEntidad.FECHA_ACT = dbFechaH.ObtenerFechaHora
                lRet = dbEntidad.Actualizar(lEntidad)

                If lRet > 0 Then
                    adapter.Actualizar(True, fila.idorden)
                End If
            End If
        Next
        Return 1
    End Function
End Class
