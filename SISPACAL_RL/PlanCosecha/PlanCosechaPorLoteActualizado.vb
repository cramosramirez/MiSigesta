Imports System.Text
Imports SISPACAL.EL
Imports SISPACAL.DL.DS_SIGESTA
Imports SISPACAL.DL.DS_SIGESTATableAdapters
Imports SISPACAL.BL

Public Class PlanCosechaPorLoteActualizado
    Private mZONA As String
    Private mID_CICLO As Int32
    Private mSEMANA As Int32
    Private mCATORCENA As Int32
    Private mTERCIO As Int32
    Private mSUB_TERCIO As String

    Public Sub CargarDatos(ByVal ZONA As String, ByVal SUB_ZONA As String, _
                           ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, _
                           ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal CODIVARIEDAD As String, _
                           ByVal ID_TIPO_CANA As Int32, ByVal SEMANA As Int32, ByVal CATORCENA As Int32, ByVal TERCIO As Int32, _
                           ByVal NOMBRE_PROVEEDOR As String, ByVal ID_ZAFRA As Int32, ByVal HORAS_AJUSTE As Int32, _
                           ByVal ID_CICLO As Int32, ByVal SUB_TERCIO As String, ByVal ID_SUB_TIPO_CANA As Int32, _
                           ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime)

        Criterios(ZONA, SUB_ZONA, _
                            CODI_DEPTO, CODI_MUNI, _
                            CODIPROVEE, CODISOCIO, CODIVARIEDAD, _
                            ID_TIPO_CANA, #12:00:00 AM#, #12:00:00 AM#, _
                            SEMANA, CATORCENA, TERCIO, _
                            NOMBRE_PROVEEDOR, ID_ZAFRA, HORAS_AJUSTE, _
                            ID_CICLO, SUB_TERCIO, ID_SUB_TIPO_CANA, _
                            USUARIO_CREA, FECHA_CREA)
        NOMBRE_PROVEEDOR = NOMBRE_PROVEEDOR.Replace(" ", "%")
        Me.PlAN_COSECHA_ACTUALTableAdapter1.FillPorLote(Me.DS_SIGESTA1.PLAN_COSECHA_ACTUAL, USUARIO_CREA, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODIPROVEE, CODISOCIO, CODIVARIEDAD, ID_TIPO_CANA, ID_SUB_TIPO_CANA, NOMBRE_PROVEEDOR, SEMANA, CATORCENA, SUB_TERCIO, TERCIO, ID_ZAFRA, FECHA_CREA)
        Me.AsignarTitulo(ID_CICLO)
    End Sub

    Public Sub CargarDatosPorFecha(ByVal ZONA As String, ByVal SUB_ZONA As String, _
                           ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, _
                           ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal CODIVARIEDAD As String, _
                           ByVal ID_TIPO_CANA As Int32, ByVal FECHA1 As DateTime, ByVal FECHA2 As DateTime, _
                           ByVal SEMANA As Int32, ByVal CATORCENA As Int32, ByVal TERCIO As Int32, _
                           ByVal NOMBRE_PROVEEDOR As String, ByVal ID_ZAFRA As Int32, ByVal HORAS_AJUSTE As Int32, _
                           ByVal ID_CICLO As Int32, ByVal SUB_TERCIO As String, ByVal ID_SUB_TIPO_CANA As Int32, _
                           ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime)

        Criterios(ZONA, SUB_ZONA, _
                            CODI_DEPTO, CODI_MUNI, _
                            CODIPROVEE, CODISOCIO, CODIVARIEDAD, _
                            ID_TIPO_CANA, FECHA1, FECHA2, _
                            SEMANA, CATORCENA, TERCIO, _
                            NOMBRE_PROVEEDOR, ID_ZAFRA, HORAS_AJUSTE, _
                            ID_CICLO, SUB_TERCIO, ID_SUB_TIPO_CANA, _
                            USUARIO_CREA, FECHA_CREA)
        NOMBRE_PROVEEDOR = NOMBRE_PROVEEDOR.Replace(" ", "%")
        Me.PlAN_COSECHA_ACTUALTableAdapter1.FillPorLoteFecha(Me.DS_SIGESTA1.PLAN_COSECHA_ACTUAL, USUARIO_CREA, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODIPROVEE, CODISOCIO, CODIVARIEDAD, ID_TIPO_CANA, ID_SUB_TIPO_CANA, FECHA1, FECHA2, NOMBRE_PROVEEDOR, SEMANA, CATORCENA, SUB_TERCIO, TERCIO, ID_ZAFRA, FECHA_CREA)
        Me.AsignarTitulo(ID_CICLO)
    End Sub

    Private Sub AsignarTitulo(ByVal ID_CICLO As Int32)
        Dim lCiclo As CICLO = (New cCICLO).ObtenerCICLO(ID_CICLO)
        If lCiclo IsNot Nothing Then
            Me.txtTITULO.Text = "DATOS ENVIOS PLAN DE COSECHA - " + lCiclo.NOM_CICLO
        End If
    End Sub

    Private Sub Criterios(ByVal ZONA As String, ByVal SUB_ZONA As String, _
                           ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, _
                           ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal CODIVARIEDAD As String, _
                           ByVal ID_TIPO_CANA As Int32, ByVal FECHA1 As DateTime, ByVal FECHA2 As DateTime, _
                           ByVal SEMANA As Int32, ByVal CATORCENA As Int32, ByVal TERCIO As Int32, _
                           ByVal NOMBRE_PROVEEDOR As String, ByVal ID_ZAFRA As Int32, ByVal HORAS_AJUSTE As Int32, _
                           ByVal ID_CICLO As Int32, ByVal SUB_TERCIO As String, ByVal ID_SUB_TIPO_CANA As Int32, _
                           ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime)
        Dim sCriterios As New StringBuilder
        Dim bCenso As New cCENSO

        mZONA = ZONA
        mID_CICLO = ID_CICLO
        mSEMANA = SEMANA
        mCATORCENA = CATORCENA
        mTERCIO = TERCIO
        mSUB_TERCIO = SUB_TERCIO

        If ZONA <> "" Then sCriterios.Append("Zona:" + ZONA + ", ")
        If SUB_ZONA <> "" Then sCriterios.Append("Sub zona:" + SUB_ZONA + ", ")
        If CODI_DEPTO <> "" Then
            Dim lDepto As DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(CODI_DEPTO)
            If lDepto IsNot Nothing Then
                sCriterios.Append("Depto.:" + lDepto.NOMBRE_DEPTO + ", ")
            End If
        End If
        If CODI_MUNI <> "" Then
            Dim lMuni As MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(CODI_DEPTO, CODI_MUNI)
            If lMuni IsNot Nothing Then
                sCriterios.Append("Muni.:" + lMuni.NOMBRE_MUNI + ", ")
            End If
        End If
        If USUARIO_CREA <> "" Then
            Dim sCantones As New StringBuilder
            Dim lFiltros As listaFILTRO_CANTON
            lFiltros = (New cFILTRO_CANTON).ObtenerListaPorUsuarioFecha(USUARIO_CREA, FECHA_CREA)

            If lFiltros IsNot Nothing AndAlso lFiltros.Count > 0 Then
                sCantones.Append("Cantones:")
                For i As Int32 = 0 To lFiltros.Count - 1
                    Dim lCanton As CANTON
                    Dim bCanton As New cCANTON

                    lCanton = bCanton.ObtenerCANTON(lFiltros(i).CODI_CANTON, lFiltros(i).CODI_DEPTO, lFiltros(i).CODI_MUNI)
                    If lCanton IsNot Nothing Then
                        If i = 0 Then sCantones.Append(lCanton.NOMBRE_CANTON) Else sCantones.Append("," + lCanton.NOMBRE_CANTON)
                    End If
                Next
                sCantones.Append(", ")
                sCriterios.Append(sCantones.ToString)
            End If
        End If
        If CODIPROVEE <> "" Then sCriterios.Append("Código Provee:" + CODIPROVEE + ", ")
        If CODISOCIO <> "" Then sCriterios.Append("Socio:" + CODISOCIO + ", ")
        If CODIVARIEDAD <> "" Then
            Dim lVariedad As VARIEDAD = (New cVARIEDAD).ObtenerVARIEDAD(CODIVARIEDAD)
            If lVariedad IsNot Nothing Then
                sCriterios.Append("Variedad.:" + lVariedad.NOM_VARIEDAD + ", ")
            End If
        End If
        If ID_TIPO_CANA <> -1 Then
            Dim lEntidad As TIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(ID_TIPO_CANA)
            sCriterios.Append("Tipo Caña:" + lEntidad.NOM_TIPO + ", ")
        End If
        If ID_SUB_TIPO_CANA <> -1 Then
            Dim lEntidad As TIPOS_GENERALES = (New cTIPOS_GENERALES).ObtenerTIPOS_GENERALES(ID_SUB_TIPO_CANA)
            sCriterios.Append("Sub Tipo Caña:" + lEntidad.NOM_TIPO + ", ")
        End If
        If FECHA1 <> #12:00:00 AM# Then sCriterios.AppendLine("Periodo Roza del:" + FECHA1.ToString("dd/MM/yy") + " al " + FECHA2.ToString("dd/MM/yy") + ", ")
        If SEMANA <> -1 Then sCriterios.Append("Semana:" + SEMANA.ToString + ", ")
        If CATORCENA <> -1 Then sCriterios.Append("Catorcena:" + CATORCENA.ToString + ", ")
        If SUB_TERCIO <> "" Then sCriterios.Append("Sub Tercio:" + SUB_TERCIO + ", ")
        If TERCIO <> -1 Then sCriterios.Append("Tercio:" + TERCIO.ToString + ", ")
        If NOMBRE_PROVEEDOR <> "" Then sCriterios.Append("Proveedor:" + NOMBRE_PROVEEDOR + ", ")
        If HORAS_AJUSTE <> 0 Then sCriterios.Append("Horas ajuste:" + HORAS_AJUSTE.ToString + ", ")

        If sCriterios.ToString.Length > 0 Then
            Me.txtEncaCriterios.Visible = True
            Me.txtCRITERIOS.Text = Strings.Left(sCriterios.ToString, sCriterios.ToString.Length - 2)
        End If
        Me.xrNombrePlanCosecha.Text = "PLAN DE COSECHA AL " + cFechaHora.ObtenerFecha.ToString("dd/MM/yyyy")
    End Sub

    Private Sub ReportFooter_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles ReportFooter.BeforePrint
        If mZONA = "" Then
            Dim dtPlan() As System.Data.DataRow
            Dim dt As New REQUERIMIENTO_FABRICADataTable
            Dim adapter As New REQUERIMIENTO_FABRICATableAdapter
            Dim fabriToneladas As Decimal = 0
            Dim planToneladas As Decimal = 0
            Dim difToneladas As Decimal = 0

            adapter.FillPorCriterios(dt, mID_CICLO, mSEMANA, mCATORCENA, mSUB_TERCIO, mTERCIO)
            If dt IsNot Nothing Then
                fabriToneladas = Convert.ToInt32(dt.Rows(0)(0))
            End If

            dtPlan = Me.DS_SIGESTA1.PLAN_COSECHA_ACTUAL.Select("NOT TONEL_CENSO IS NULL")
            If dtPlan IsNot Nothing Then
                For Each fila As System.Data.DataRow In dtPlan
                    planToneladas += fila("TONEL_CENSO")
                Next
            End If
            Me.xrtFabriToneladas.Text = fabriToneladas.ToString("#,##0.00")
            Me.xrtDifToneladas.Text = (planToneladas - fabriToneladas).ToString("#,##0.00")
        Else
            xrtRequerimientoFabrica.Visible = False
        End If
    End Sub
End Class