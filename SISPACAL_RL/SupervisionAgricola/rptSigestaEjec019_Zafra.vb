Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class rptSigestaEjec019_Zafra
    Dim ftoDecimal As String = "#,###,##0.00"
    Dim ftoPorc As String = "0.00%"


    Public Sub CargarDatos(ByVal TIPO As String, _
                      ByVal ZONA As String, ByVal SUB_ZONA As String, _
                      ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, _
                      ByVal CODIPROVEE As String, ByVal CODISOCIO As String, _
                      ByVal NOMBRE_PROVEEDOR As String, ByVal ID_ZAFRA As Int32, _
                      ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, _
                      ByVal CODIGOS_RELACIONADOS As Boolean)
        Dim sCodiProvee As String = ""
        Dim sCodiSocio As String = ""
        Dim sNombreProveedor As String = ""
        Dim sCodiProveedor As String = ""

        If CODIGOS_RELACIONADOS Then
            sCodiProveedor = Utilerias.RellenarIzquierda(CODIPROVEE, 6) + Utilerias.RellenarIzquierda(CODISOCIO, 4)
        End If

        sNombreProveedor = NOMBRE_PROVEEDOR.ToUpper.Trim.Replace(" ", "%")

        Me.RpT_SIGESTA_EJEC019_PLAN_COSECHATableAdapter1.FillPorCriterios(DS_SIGESTA1.RPT_SIGESTA_EJEC019_PLAN_COSECHA, TIPO, ID_ZAFRA, USUARIO_CREA, FECHA_CREA, ZONA, _
                                                            SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODIPROVEE, CODISOCIO, sNombreProveedor, CODIGOS_RELACIONADOS, sCodiProveedor)

        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        Dim diaZafra As DIA_ZAFRA = (New cDIA_ZAFRA).ObtenerDiaZafraActivo(ID_ZAFRA)

        If lZafra IsNot Nothing Then
            Me.xrZAFRA.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA
        End If

        If Not CODIGOS_RELACIONADOS Then
            GroupFooter2.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            If DS_SIGESTA1.RPT_SIGESTA_EJEC019_PLAN_COSECHA.Rows.Count > 0 AndAlso _
               CODIPROVEE <> "" AndAlso CODISOCIO = "" AndAlso _
               DS_SIGESTA1.RPT_SIGESTA_EJEC019_PLAN_COSECHA.Rows(0)("CODISOCIO") <> "" Then
                Me.xrtTotalGeneral.Visible = True
            End If
        Else
            If DS_SIGESTA1.RPT_SIGESTA_EJEC019_PLAN_COSECHA.Rows.Count > 0 Then xrtTotalGeneral.Visible = True
        End If
    End Sub
End Class