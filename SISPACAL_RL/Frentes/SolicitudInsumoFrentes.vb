Imports SISPACAL.EL
Imports SISPACAL.BL

Public Class SolicitudInsumoFrentes

    Public Sub CargarDatos(ByVal ID_SOLICITUD As Int32)
        Me.DS_SIFAG1.Clear()
        Me.RPT_SOLICITUD_FRENTETableAdapter1.FillPorSolicitud(Me.DS_SIFAG1.RPT_SOLICITUD_FRENTE, ID_SOLICITUD)

        Dim lEntidad As SOLIC_ENCA_FRENTE = (New cSOLIC_ENCA_FRENTE).ObtenerSOLIC_ENCA_FRENTE(ID_SOLICITUD)
        If lEntidad IsNot Nothing Then
            If lEntidad.ID_TIPO_PROVEEDOR = Enumeradores.TipoProveedor.FrenteRoza Then
                Me.lblRepresentante.Text = "NOMBRE DEL PROVEEDOR DE ROZA:"
                Me.xrTituloFrente.Text = "FRENTES DE ROZA"
            ElseIf lEntidad.ID_TIPO_PROVEEDOR = Enumeradores.TipoProveedor.FrenteQuerqueo Then
                Me.lblRepresentante.Text = "NOMBRE DEL PROVEEDOR DE QUERQUEO:"
                Me.xrTituloFrente.Text = "FRENTES DE QUERQUEO"
            End If
        End If
    End Sub
End Class