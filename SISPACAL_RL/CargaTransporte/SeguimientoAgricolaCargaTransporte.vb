Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class SeguimientoAgricolaCargaTransporte

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal DIA As Int32, ByVal ZONA As String)
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        Dim fechaActual As DateTime = cFechaHora.ObtenerFechaHora
        Me.xrlFECHA.Text = fechaActual.ToString("dddd, dd").ToUpper + " DE " + fechaActual.ToString("MMMMM yyyy").ToUpper
        Me.xrlHORA.Text = fechaActual.ToString("HH:mm")

        If lZafra IsNot Nothing Then txtTITULO.Text = "SEGUIMIENTO Y PROGRAMACION DE EQUIPO AGRICOLA Y TRANSPORTE ZAFRA " + lZafra.NOMBRE_ZAFRA
        Me.RPT_SIGESTA_SEGUIMIENTO_TRANSPORTETableAdapter1.FillPorCriterios(DS_SIGESTA1.RPT_SIGESTA_SEGUIMIENTO_TRANSPORTE, ID_ZAFRA, DIA, ZONA)
        Me.DisplayName = "Seguimiento y programacion de equipo agricola y transporte zafra"
    End Sub
End Class