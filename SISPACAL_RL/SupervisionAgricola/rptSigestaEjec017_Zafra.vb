Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class rptSigestaEjec017_Zafra
    Dim ftoDecimal As String = "#,###,##0.00"
    Dim ftoPorc As String = "0.00%"


    Public Sub CargarDatos(ByVal TIPO As String, _
                      ByVal ZONA As String, ByVal SUB_ZONA As String, _
                      ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, _
                      ByVal CODIPROVEE As String, ByVal CODISOCIO As String, _
                      ByVal NOMBRE_PROVEEDOR As String, ByVal ID_ZAFRA As Int32, _
                      ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime)
        Dim sCodiProvee As String = ""
        Dim sCodiSocio As String = ""
        Dim sNombreProveedor As String = ""

        sNombreProveedor = NOMBRE_PROVEEDOR.ToUpper.Trim.Replace(" ", "%")

        Me.RpT_SIGESTA_EJEC017_PLAN_COSECHATableAdapter1.FillPorCriterios(DS_SIGESTA1.RPT_SIGESTA_EJEC017_PLAN_COSECHA, TIPO, ID_ZAFRA, USUARIO_CREA, FECHA_CREA, ZONA, _
                                                            SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODIPROVEE, CODISOCIO, sNombreProveedor)

        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        Dim diaZafra As DIA_ZAFRA = (New cDIA_ZAFRA).ObtenerDiaZafraActivo(ID_ZAFRA)

        If lZafra IsNot Nothing Then
            Me.xrZAFRA.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA
        End If
        If diaZafra IsNot Nothing Then Me.lblDiaZafra.Text = diaZafra.DIAZAFRA.ToString
    End Sub
End Class