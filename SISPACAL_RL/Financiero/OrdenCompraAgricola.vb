Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class OrdenCompraAgricola

    Public Sub CargarDatos(ByVal ID_SOLICITUD As Int32)
        DS_SIFAG1.Clear()
        REPO_ORDEN_COMPRA_AGRICOLATableAdapter1.FillPorSolicitud(DS_SIFAG1.REPO_ORDEN_COMPRA_AGRICOLA, ID_SOLICITUD)
    End Sub

    Public Sub CargarDatosPorOrden(ByVal ID_ORDEN As Int32)
        DS_SIFAG1.Clear()
        REPO_ORDEN_COMPRA_AGRICOLATableAdapter1.FillPorOrden(DS_SIFAG1.REPO_ORDEN_COMPRA_AGRICOLA, ID_ORDEN)
    End Sub

    Private Sub ConfigPiePag(ByVal ID_ORDEN As Int32)
        Dim conFlete As Boolean = False
        Dim listaOrdenDeta As listaORDEN_DETA_AGRI = (New cORDEN_DETA_AGRI).ObtenerListaPorORDEN_COMPRA_AGRI(ID_ORDEN)
        If listaOrdenDeta IsNot Nothing AndAlso listaOrdenDeta.Count > 0 Then
            For i As Int32 = 0 To listaOrdenDeta.Count - 1
                If listaOrdenDeta(i).NOMBRE_PRODUCTO.ToUpper.Contains("FLETE") Then
                    conFlete = True
                End If
            Next
        End If

        Me.xrObservaciones1.Visible = conFlete
        Me.xrObservaciones2.Visible = conFlete
        Me.xrLugarEntrega1.Visible = conFlete
        Me.xrLugarEntrega2.Visible = conFlete
        Me.xrContacto1.Visible = conFlete
        Me.xrContacto2.Visible = conFlete
    End Sub

    Private Sub GroupFooter1_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles GroupFooter1.BeforePrint
        If GetCurrentColumnValue("ID_ORDEN") IsNot DBNull.Value Then
            Me.ConfigPiePag(CInt(GetCurrentColumnValue("ID_ORDEN")))
        End If
    End Sub
End Class