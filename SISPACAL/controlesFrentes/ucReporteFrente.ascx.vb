Imports SISPACAL.BL
Imports SISPACAL.RL
Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports SISPACAL.EL.Enumeradores
Partial Class controlesFrentes_ucReporteFrente
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
    Private Property PARAMETROS As Dictionary(Of String, String)
        Get
            If Me.ViewState("PARAMETROS") Is Nothing Then
                Return Nothing
            Else
                Return Me.ViewState("PARAMETROS")
            End If
        End Get
        Set(value As Dictionary(Of String, String))
            Me.ViewState("PARAMETROS") = value
        End Set
    End Property


    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Inicializar()
        Else
            CargarDatosReporte()
        End If
    End Sub

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
                Me.ucCriteriosFrentes1.VerZAFRA = True
                Me.ucCriteriosFrentes1.VerTIPO_FRENTE = True
                Me.ucCriteriosFrentes1.VerFRENTE = True
                Me.ucCriteriosFrentes1.VerCUENTA_FINAN = True
                Me.lblTitulo.Text = "REPORTE DE ESTADO DE CUENTA FRENTE"


        End Select
    End Sub

    Public Sub CargarDatosReporte()
        Try
            Select Case Me.ID_REPORTE
                Case 1
                    If Parametros Is Nothing Then Return

                    Dim reporte As New EstadoCtaFrente
                    reporte.CargarDatos(CInt(PARAMETROS("ID_ZAFRA")), CInt(PARAMETROS("ID_TIPO_PROVEEDOR")), CInt(PARAMETROS("ID_FRENTE")), CInt(PARAMETROS("ID_CUENTA_FINAN")))
                    reporte.ResumeLayout()
                    Me.ucVisorReporte1.CargarDatos(reporte)

            End Select
        Catch ex As Exception
            ExceptionManager.Publish(ex)
        End Try
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "VerReporte" Then
            Me.PARAMETROS = New Dictionary(Of String, String)

            Select Case Me.ID_REPORTE
                Case 1
                    If Me.ucCriteriosFrentes1.ID_ZAFRA = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione una zafra", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_ZAFRA", Me.ucCriteriosFrentes1.ID_ZAFRA)
                    End If
                    If Me.ucCriteriosFrentes1.ID_TIPO_FRENTE = -1 Then
                        Me.PARAMETROS = Nothing : Me.AsignarMensaje("Seleccione un tipo de frente", False, True, True)
                        Return
                    Else
                        Me.PARAMETROS.Add("ID_TIPO_PROVEEDOR", Me.ucCriteriosFrentes1.ID_TIPO_FRENTE)
                    End If
                    Me.PARAMETROS.Add("ID_FRENTE", Me.ucCriteriosFrentes1.ID_FRENTE)
                    Me.PARAMETROS.Add("ID_CUENTA_FINAN", Me.ucCriteriosFrentes1.ID_CUENTA_FINAN)

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
