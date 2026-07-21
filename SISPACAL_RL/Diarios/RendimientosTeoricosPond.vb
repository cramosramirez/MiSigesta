Imports SISPACAL.EL
Imports SISPACAL.BL

Public Class RendimientosTeoricosPond
    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal FECHA_INI As Date, ByVal FECHA_FIN As Date)
        Me.REND_TEORICOS_PONDERADOSTableAdapter1.FillPorZafraFechasCorte(DS_DS11.REND_TEORICOS_PONDERADOS, FECHA_INI, FECHA_FIN, ID_ZAFRA)
        Me.xrlPERIODO.Text = "PERIODO: DEL " + FECHA_INI.ToString("dd-MM-yyyy") + " AL " + FECHA_FIN.ToString("dd-MM-yyyy")
        Me.DisplayName = "RENDIMIENTOS TEORICOS PONDERADOS " + Me.xrlPERIODO.Text
    End Sub
End Class