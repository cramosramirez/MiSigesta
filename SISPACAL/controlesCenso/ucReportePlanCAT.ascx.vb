Imports SISPACAL.EL
Imports SISPACAL.BL
Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports SISPACAL.RL
Imports SISPACAL.EL.Enumeradores

Partial Class controlesCenso_ucReportePlanCAT
    Inherits ucBase

    Private Property ID_REPORTE As Integer
        Get
            If Me.ViewState("ID_REPORTE") Is Nothing Then
                Return 0
            Else
                Return Me.ViewState("ID_REPORTE")
            End If
        End Get
        Set(ByVal value As Integer)
            Me.ViewState("ID_REPORTE") = value
        End Set
    End Property

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Inicializar()
        Else
            CargarDatosReporte()
        End If
    End Sub

    Private Property PARAMETROS As Dictionary(Of String, Object)
        Get
            If Me.ViewState("PARAMETROS") Is Nothing Then
                Return Nothing
            Else
                Return Me.ViewState("PARAMETROS")
            End If
        End Get
        Set(value As Dictionary(Of String, Object))
            Me.ViewState("PARAMETROS") = value
        End Set
    End Property

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False

        Me.ucBarraNavegacion1.CrearOpcion("VerReporte", "Ver reporte", False, "reports_groupheader_16x16", "", "", True)
        Me.ucBarraNavegacion1.VerOpcion("VerReporte", True)
        Me.ucBarraNavegacion1.CargarOpciones()

        If Me.Request.QueryString("n").ToString <> "" AndAlso IsNumeric(Me.Request.QueryString("n").ToString) Then
            Me.ID_REPORTE = Convert.ToInt32(Me.Request.QueryString("n").ToString)
        Else
            Me.ID_REPORTE = 0
        End If

        Select Case Me.ID_REPORTE
            Case 1
                Me.lblTitulo.Text = "REPORTE: PLANEACION DE CAT"
                Me.ucCriterios1.VerID_ZAFRA = True
                Me.ucCriterios1.VerZONA = True
                Me.ucCriterios1.VerCODIPROVEEDOR = True
                Me.ucCriterios1.VerVARIEDAD = True
                Me.ucCriterios1.VerTERCIO = True
                Me.ucCriterios1.VerTIPO_DETALLE = True
                Me.ucCriterios1.VerMULTICANTON = True
           
        End Select

    End Sub

    Public Sub CargarDatosReporte()
        Try
            If PARAMETROS Is Nothing Then Return

            Select Case Me.ID_REPORTE
                Case 1
                    Dim lZafra As ZAFRA
                    lZafra = (New cZAFRA).ObtenerZAFRA(Me.ucCriterios1.ID_ZAFRA)

                    If Me.ucCriterios1.TIPO_DETALLE = 1 Then
                        Select Case CInt(PARAMETROS("SERVICIO_CAT"))
                            Case CAT.TipoCAT.Roza
                                Dim reporte As New PlanCATRozaPorLote
                                If PARAMETROS.ContainsKey("FECHA1") Then
                                    reporte.CargarDatosPorFecha(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"), CDate(PARAMETROS("FECHA1")), CDate(PARAMETROS("FECHA2")))
                                Else
                                    reporte.CargarDatos(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"))
                                End If
                                reporte.ResumeLayout()
                                Me.ucVisorReporte1.CargarDatos(reporte)
                            Case CAT.TipoCAT.Alza
                                Dim reporte As New PlanCATAlzaPorLote
                                If PARAMETROS.ContainsKey("FECHA1") Then
                                    reporte.CargarDatosPorFecha(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"), CDate(PARAMETROS("FECHA1")), CDate(PARAMETROS("FECHA2")))
                                Else
                                    reporte.CargarDatos(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), -1, CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"))
                                End If
                                reporte.ResumeLayout()
                                Me.ucVisorReporte1.CargarDatos(reporte)
                            Case CAT.TipoCAT.Transporte
                                Dim reporte As New PlanCATTransPorLote
                                If PARAMETROS.ContainsKey("FECHA1") Then
                                    reporte.CargarDatosPorFecha(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"), CDate(PARAMETROS("FECHA1")), CDate(PARAMETROS("FECHA2")))
                                Else
                                    reporte.CargarDatos(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), -1, -1, CInt(PARAMETROS("SERVICIO_POR_CAT")), CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"))
                                End If
                                reporte.ResumeLayout()
                                Me.ucVisorReporte1.CargarDatos(reporte)
                        End Select
                    End If

                    If Me.ucCriterios1.TIPO_DETALLE = 2 Then
                        Select Case CInt(PARAMETROS("SERVICIO_CAT"))
                            Case CAT.TipoCAT.Roza
                                Dim reporte As New PlanCATRozaPorZona
                                If PARAMETROS.ContainsKey("FECHA1") Then
                                    reporte.CargarDatosPorFecha(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"), CDate(PARAMETROS("FECHA1")), CDate(PARAMETROS("FECHA2")))
                                Else
                                    reporte.CargarDatos(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"))
                                End If
                                reporte.ResumeLayout()
                                Me.ucVisorReporte1.CargarDatos(reporte)
                            Case CAT.TipoCAT.Alza
                                Dim reporte As New PlanCATAlzaPorZona
                                If PARAMETROS.ContainsKey("FECHA1") Then
                                    reporte.CargarDatosPorFecha(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"), CDate(PARAMETROS("FECHA1")), CDate(PARAMETROS("FECHA2")))
                                Else
                                    reporte.CargarDatos(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), -1, CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"))
                                End If
                                reporte.ResumeLayout()
                                Me.ucVisorReporte1.CargarDatos(reporte)
                            Case CAT.TipoCAT.Transporte
                                Dim reporte As New PlanCATTransPorZona
                                If PARAMETROS.ContainsKey("FECHA1") Then
                                    reporte.CargarDatosPorFecha(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"), CDate(PARAMETROS("FECHA1")), CDate(PARAMETROS("FECHA2")))
                                Else
                                    reporte.CargarDatos(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), -1, -1, CInt(PARAMETROS("SERVICIO_POR_CAT")), CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"))
                                End If
                                reporte.ResumeLayout()
                                Me.ucVisorReporte1.CargarDatos(reporte)
                        End Select
                    End If
                    If Me.ucCriterios1.TIPO_DETALLE = 3 Then
                        Select Case CInt(PARAMETROS("SERVICIO_CAT"))
                            Case CAT.TipoCAT.Roza
                                Dim reporte As New PlanCATRozaPorSubZona
                                If PARAMETROS.ContainsKey("FECHA1") Then
                                    reporte.CargarDatosPorFecha(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"), CDate(PARAMETROS("FECHA1")), CDate(PARAMETROS("FECHA2")))
                                Else
                                    reporte.CargarDatos(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"))
                                End If
                                reporte.ResumeLayout()
                                Me.ucVisorReporte1.CargarDatos(reporte)
                            Case CAT.TipoCAT.Alza
                                Dim reporte As New PlanCATAlzaPorSubZona
                                If PARAMETROS.ContainsKey("FECHA1") Then
                                    reporte.CargarDatosPorFecha(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"), CDate(PARAMETROS("FECHA1")), CDate(PARAMETROS("FECHA2")))
                                Else
                                    reporte.CargarDatos(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), -1, CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"))
                                End If
                                reporte.ResumeLayout()
                                Me.ucVisorReporte1.CargarDatos(reporte)
                            Case CAT.TipoCAT.Transporte
                                Dim reporte As New PlanCATTransPorSubZona
                                If PARAMETROS.ContainsKey("FECHA1") Then
                                    reporte.CargarDatosPorFecha(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"), CDate(PARAMETROS("FECHA1")), CDate(PARAMETROS("FECHA2")))
                                Else
                                    reporte.CargarDatos(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), -1, -1, CInt(PARAMETROS("SERVICIO_POR_CAT")), CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"))
                                End If
                                reporte.ResumeLayout()
                                Me.ucVisorReporte1.CargarDatos(reporte)
                        End Select
                    End If

                    If Me.ucCriterios1.TIPO_DETALLE = 4 Then
                        Select Case CInt(PARAMETROS("SERVICIO_CAT"))
                            Case CAT.TipoCAT.Roza
                                Dim reporte As New PlanCATRozaPorCanton
                                If PARAMETROS.ContainsKey("FECHA1") Then
                                    reporte.CargarDatosPorFecha(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"), CDate(PARAMETROS("FECHA1")), CDate(PARAMETROS("FECHA2")))
                                Else
                                    reporte.CargarDatos(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"))
                                End If
                                reporte.ResumeLayout()
                                Me.ucVisorReporte1.CargarDatos(reporte)
                            Case CAT.TipoCAT.Alza
                                Dim reporte As New PlanCATAlzaPorCanton
                                If PARAMETROS.ContainsKey("FECHA1") Then
                                    reporte.CargarDatosPorFecha(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"), CDate(PARAMETROS("FECHA1")), CDate(PARAMETROS("FECHA2")))
                                Else
                                    reporte.CargarDatos(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), -1, CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"))
                                End If
                                reporte.ResumeLayout()
                                Me.ucVisorReporte1.CargarDatos(reporte)
                            Case CAT.TipoCAT.Transporte
                                Dim reporte As New PlanCATTransPorCanton
                                If PARAMETROS.ContainsKey("FECHA1") Then
                                    reporte.CargarDatosPorFecha(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), CInt(PARAMETROS("SERVICIO_POR_CAT")), -1, -1, CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"), CDate(PARAMETROS("FECHA1")), CDate(PARAMETROS("FECHA2")))
                                Else
                                    reporte.CargarDatos(PARAMETROS("USUARIO_CREA"), PARAMETROS("ZONA"), PARAMETROS("SUB_ZONA"), PARAMETROS("CODI_DEPTO"), PARAMETROS("CODI_MUNI"), PARAMETROS("CODIPROVEE"), PARAMETROS("CODISOCIO"), PARAMETROS("NOMBRE_PROVEEDOR"), CInt(PARAMETROS("ID_TIPO_CANA")), -1, -1, CInt(PARAMETROS("SERVICIO_POR_CAT")), CInt(PARAMETROS("SEMANA")), CInt(PARAMETROS("CATORCENA")), PARAMETROS("SUB_TERCIO"), CInt(PARAMETROS("TERCIO")), CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_CICLO")), PARAMETROS("FECHA_CREA"))
                                End If
                                reporte.ResumeLayout()
                                Me.ucVisorReporte1.CargarDatos(reporte)
                        End Select
                    End If

                Case 2
                    
            End Select
        Catch ex As Exception
            ExceptionManager.Publish(ex)
        End Try
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "VerReporte" Then
            If Me.ucCriterios1.ID_ZAFRA = -1 Then
                Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                Return
            End If
            If Me.ucCriterios1.SERVICIO_CAT = -1 Then
                Me.AsignarMensaje("Seleccione un tipo de CAT", False, True, True)
                Return
            End If
            If Me.ucCriterios1.TIPO_DETALLE = -1 OrElse Me.ucCriterios1.TIPO_DETALLE = 0 Then
                Me.AsignarMensaje("Seleccione el tipo de reporte a mostrar", False, True, True)
                Return
            End If
            Me.PARAMETROS = New Dictionary(Of String, Object)
            Select Case Me.ID_REPORTE
                Case 1
                    Me.PARAMETROS = New Dictionary(Of String, Object)
                    Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriterios1.ID_ZAFRA)
                    Me.PARAMETROS.Add("ZONA", Me.ucCriterios1.ZONA)
                    Me.PARAMETROS.Add("SUB_ZONA", Me.ucCriterios1.SUB_ZONA) : Me.PARAMETROS.Add("CODI_DEPTO", Me.ucCriterios1.CODI_DEPTO)
                    Me.PARAMETROS.Add("CODI_MUNI", Me.ucCriterios1.CODI_MUNI)
                    Me.PARAMETROS.Add("CODIPROVEE", Me.ucCriterios1.CODIPROVEE) : Me.PARAMETROS.Add("CODISOCIO", Me.ucCriterios1.CODISOCIO)
                    If Me.ucCriterios1.FECHA1 <> #12:00:00 AM# AndAlso Me.ucCriterios1.FECHA2 <> #12:00:00 AM# Then
                        Me.PARAMETROS.Add("FECHA1", Me.ucCriterios1.FECHA1.ToString("yyyy/MM/dd")) : Me.PARAMETROS.Add("FECHA2", Me.ucCriterios1.FECHA2.ToString("yyyy/MM/dd"))
                    Else
                        If (Me.ucCriterios1.FECHA1 <> #12:00:00 AM# AndAlso Me.ucCriterios1.FECHA2 = #12:00:00 AM#) OrElse _
                        (Me.ucCriterios1.FECHA1 = #12:00:00 AM# AndAlso Me.ucCriterios1.FECHA2 <> #12:00:00 AM#) Then
                            Me.AsignarMensaje("Si filtra por Periodo de roza debe ingresar ambas fechas", False, True, True)
                            Return
                        End If
                    End If
                    Me.PARAMETROS.Add("SERVICIO_CAT", Me.ucCriterios1.SERVICIO_CAT)
                    Me.PARAMETROS.Add("ID_TIPO_CANA", Me.ucCriterios1.TIPO_CANA)
                    Me.PARAMETROS.Add("SERVICIO_POR_CAT", Me.ucCriterios1.SERVICIO_POR_CAT)
                    Me.PARAMETROS.Add("SEMANA", Me.ucCriterios1.SEMANA)
                    Me.PARAMETROS.Add("CATORCENA", Me.ucCriterios1.CATORCENA)
                    Me.PARAMETROS.Add("SUB_TERCIO", Me.ucCriterios1.SUB_TERCIO)
                    Me.PARAMETROS.Add("TERCIO", Me.ucCriterios1.TERCIO)
                    Me.PARAMETROS.Add("NOMBRE_PROVEEDOR", Me.ucCriterios1.NOMBRE_PROVEEDOR.ToUpper)
                    Me.PARAMETROS.Add("ID_CICLO", Me.ucCriterios1.ID_CICLO)

                    If Me.ucCriterios1.CANTONES.Count > 0 Then
                        Dim fechaHora As DateTime = cFechaHora.ObtenerFechaHora
                        Dim bFiltro As New cFILTRO_CANTON

                        'Eliminar filtros de hace una hora
                        bFiltro.EliminarFiltroPorUsuarioFecha(Me.ObtenerUsuario, fechaHora.AddHours(-1))

                        'Agregar filtros seleccionados
                        For Each lCanton As CANTON In Me.ucCriterios1.CANTONES
                            Dim lFiltro As New FILTRO_CANTON
                            lFiltro.ID_FILTRO_CANTON = 0
                            lFiltro.USUARIO_CREA = Me.ObtenerUsuario
                            lFiltro.FECHA_CREA = fechaHora
                            lFiltro.CODI_DEPTO = lCanton.CODI_DEPTO
                            lFiltro.CODI_MUNI = lCanton.CODI_MUNI
                            lFiltro.CODI_CANTON = lCanton.CODI_CANTON

                            bFiltro.ActualizarFILTRO_CANTON(lFiltro)
                        Next

                        Me.PARAMETROS.Add("USUARIO_CREA", Me.ObtenerUsuario)
                        Me.PARAMETROS.Add("FECHA_CREA", fechaHora)
                    Else
                        Me.PARAMETROS.Add("USUARIO_CREA", "")
                        Me.PARAMETROS.Add("FECHA_CREA", Now)
                    End If

            End Select
            Me.CargarDatosReporte()
        End If
        If CommandName = "CerrarVentana" Then
            Dim strscript As String = "<script language=javascript>window.top.close();</script>"
            If Not Page.ClientScript.IsStartupScriptRegistered("clientScript") Then
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "clientScript", strscript)
            End If
        End If
    End Sub
End Class
