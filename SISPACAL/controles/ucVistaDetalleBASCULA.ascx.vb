Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleBASCULA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla BASCULA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	11/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleBASCULA
    Inherits ucBase
 
#Region"Propiedades"

    Public Property ID_BASCULA() As Int32
        Get
            If Me.ViewState("ID_BASCULA") Is Nothing Then
                Return -1
            Else
                Return CInt(Me.ViewState("ID_BASCULA"))
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_BASCULA") = Value
            If Value > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Private Property ID_ENVIO() As Int32
        Get
            If Me.ViewState("ID_ENVIO") Is Nothing Then
                Return -1
            Else
                Return CInt(Me.ViewState("ID_ENVIO"))
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_ENVIO") = Value
        End Set
    End Property

    Public Property TIPO_OPERACION As TipoOperacion
        Get
            If Me.ViewState("TIPO_OPERACION") Is Nothing Then
                Return TipoOperacion.Recepcion
            Else
                Return Me.ViewState("TIPO_OPERACION")
            End If
        End Get
        Set(ByVal value As TipoOperacion)
            Me.ViewState("TIPO_OPERACION") = value
            If value = TipoOperacion.Edicion OrElse value = TipoOperacion.Consulta Then
                Me.LimpiarControles()
                Me.Nuevo()
                Me.HabilitarEdicion(False)
            End If
            Me.txtNROBOLETA.Focus()
        End Set
    End Property

    Private Sub ConfigurarEncabezado()
        Dim entZafra As New ZAFRA
        entZafra = (New cZAFRA).ObtenerZafraActiva()
        If entZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = entZafra.ID_ZAFRA
            If Me.TIPO_OPERACION <> TipoOperacion.Consulta Then
                Me.txtCATORCENA_ZAFRA.Text = entZafra.CATORCENA.ToString
                Me.txtDIAZAFRA.Text = entZafra.DIAZAFRA.ToString
            End If
        End If
    End Sub
    

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cBASCULA
    Private mEntidad As BASCULA
    Public Event ErrorEvent(ByVal errorMessage As String)

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property
 
    Public Property Enabled() As Boolean
        Get
            Return Me._Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me._Enabled = Value
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla BASCULA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New BASCULA
        mEntidad.ID_BASCULA = ID_BASCULA
 
        If mComponente.ObtenerBASCULA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If

        Dim lEnvio As ENVIO = (New cENVIO).ObtenerENVIO(mEntidad.ID_ENVIO)
        If lEnvio IsNot Nothing Then
            Me.ID_ENVIO = lEnvio.ID_ENVIO
            cbxZAFRA.Value = lEnvio.ID_ZAFRA
            txtCATORCENA_ZAFRA.Text = lEnvio.CATORCENA.ToString
            txtDIAZAFRA.Text = lEnvio.DIAZAFRA.ToString
            If lEnvio.NUMRECIBO_CANA > -1 Then txtNUMRECIBO_CANA.Text = lEnvio.NUMRECIBO_CANA Else txtNUMRECIBO_CANA.Text = ""
        End If
        Me.speBRUTO.Value = IIf(mEntidad.BRUTO = -1, Nothing, mEntidad.BRUTO)
        Me.dteFECHA_LEE_BRUTO.Value = IIf(mEntidad.FECHA_LEE_BRUTO = #12:00:00 AM#, Nothing, mEntidad.FECHA_LEE_BRUTO)
        Me.cbxUSUARIO_BRUTO.Value = IIf(mEntidad.USUARIO_LEE_BRUTO = "", "", mEntidad.USUARIO_LEE_BRUTO)

        Me.speTARA.Value = IIf(mEntidad.TARA = -1, Nothing, mEntidad.TARA)
        Me.dteFECHA_LEE_TARA.Value = IIf(mEntidad.FECHA_LEE_TARA = #12:00:00 AM#, Nothing, mEntidad.FECHA_LEE_TARA)
        Me.cbxUSUARIO_TARA.Value = IIf(mEntidad.USUARIO_LEE_TARA = "", "", mEntidad.USUARIO_LEE_TARA)

        Me.speNETOLIBRAS.Value = IIf(mEntidad.NETOLIBRAS = -1, Nothing, mEntidad.NETOLIBRAS)
        Me.speNETOTONEL.Value = IIf(mEntidad.NETOTONEL = -1, Nothing, mEntidad.NETOTONEL)
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxZAFRA.ClientEnabled = False
        Me.txtCATORCENA_ZAFRA.ClientEnabled = False
        Me.txtDIAZAFRA.ClientEnabled = False

        Me.txtNROBOLETA.ClientEnabled = True
        Me.txtNUMRECIBO_CANA.ClientEnabled = True

        Me.speBRUTO.ClientEnabled = True
        Me.dteFECHA_LEE_BRUTO.ClientEnabled = True
        Me.cbxUSUARIO_BRUTO.ClientEnabled = True

        Me.speTARA.ClientEnabled = True
        Me.dteFECHA_LEE_TARA.ClientEnabled = True
        Me.cbxUSUARIO_TARA.ClientEnabled = True

        Me.speNETOLIBRAS.ClientEnabled = False
        Me.speNETOTONEL.ClientEnabled = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        Me.cbxZAFRA.Value = Nothing
        Me.txtCATORCENA_ZAFRA.Text = ""
        Me.txtDIAZAFRA.Text = ""
        Me.ConfigurarEncabezado()
        Me.txtNROBOLETA.Value = Nothing
        Me.txtNUMRECIBO_CANA.Value = Nothing
        Me.speBRUTO.Value = Nothing
        Me.dteFECHA_LEE_BRUTO.Value = Nothing
        Me.cbxUSUARIO_BRUTO.Value = Nothing
        Me.speTARA.Value = Nothing
        Me.dteFECHA_LEE_TARA.Value = Nothing
        Me.cbxUSUARIO_TARA.Value = Nothing
        Me.speNETOLIBRAS.Value = Nothing
        Me.speNETOTONEL.Value = Nothing

        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.AsignarMensaje("", False, False)
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla BASCULA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New BASCULA
        If Me._nuevo Then
            mEntidad.ID_BASCULA = 0
        Else
            mEntidad = (New cBASCULA).ObtenerBASCULA(Me.ID_BASCULA)
        End If

        If Me.speBRUTO.Value = Nothing Then
            Me.AsignarMensaje("* Debe ingresar por lo menos el peso Bruto.", True)
            Return "Error"
        Else
            If Me.dteFECHA_LEE_BRUTO.Value = Nothing Then
                Me.AsignarMensaje("* Ingrese la fecha/hora de captura del peso Bruto.", True)
                Return "Error"
            End If
            If Me.cbxUSUARIO_BRUTO.Value = Nothing Then
                Me.AsignarMensaje("* Seleccione el usuario que capturo el peso Bruto.", True)
                Return "Error"
            End If
        End If
        If Me.speTARA.Value <> Nothing Then
            If Me.txtNUMRECIBO_CANA.Value = Nothing Then
                Me.AsignarMensaje("* Ingrese el numero de recibo de cana.", True)
                Return "Error"
            End If
            If Me.dteFECHA_LEE_TARA.Value = Nothing Then
                Me.AsignarMensaje("* Ingrese la fecha/hora de captura del peso Tara.", True)
                Return "Error"
            End If
            If Me.cbxUSUARIO_TARA.Value = Nothing Then
                Me.AsignarMensaje("* Seleccione el usuario que capturo el peso Tara.", True)
                Return "Error"
            End If

            If Me.dteFECHA_LEE_BRUTO.Date >= Me.dteFECHA_LEE_TARA.Date Then
                Me.AsignarMensaje("* La fecha de captura del peso Bruto no puede ser mayor o igual al peso Tara.", True)
                Return "Error"
            End If
        End If

        mEntidad.ID_ENVIO = Me.ID_ENVIO
        mEntidad.BRUTO = Convert.ToDecimal(Me.speBRUTO.Value)
        mEntidad.FECHA_LEE_BRUTO = Me.dteFECHA_LEE_BRUTO.Date
        mEntidad.USUARIO_LEE_BRUTO = Me.cbxUSUARIO_BRUTO.Value

        If Me.speTARA.Value IsNot Nothing Then
            mEntidad.TARA = Convert.ToDecimal(Me.speTARA.Value)
            mEntidad.FECHA_LEE_TARA = Me.dteFECHA_LEE_TARA.Date
            mEntidad.USUARIO_LEE_TARA = Me.cbxUSUARIO_TARA.Value
            SetearPesoNeto()
            mEntidad.NETOLIBRAS = Convert.ToDecimal(Me.speNETOLIBRAS.Value)
            mEntidad.NETOTONEL = Convert.ToDecimal(Me.speNETOTONEL.Value)
        Else
            mEntidad.NETOLIBRAS = -1
            mEntidad.NETOTONEL = -1
            mEntidad.TARA = -1
            mEntidad.FECHA_LEE_TARA = #12:00:00 AM#
            mEntidad.USUARIO_LEE_TARA = Nothing
        End If

        If mComponente.ActualizarBASCULA(mEntidad) < 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True)
            Return "Error al Guardar registro."
        End If

        'Actualizar nÃºmero de recibo de caÃ±a si es necesario
        Dim bEnvio As New cENVIO
        Dim lEnvio As ENVIO = bEnvio.ObtenerENVIO(Me.ID_ENVIO)
        If lEnvio IsNot Nothing Then
            Dim numRecibo As Integer
            If Me.txtNUMRECIBO_CANA.Value = Nothing Then
                numRecibo = -1
            Else
                numRecibo = Convert.ToInt32(Me.txtNUMRECIBO_CANA.Value)
            End If
            If numRecibo <> lEnvio.NUMRECIBO_CANA Then
                lEnvio.NUMRECIBO_CANA = numRecibo
                lEnvio.USUARIO_ACT = Me.ObtenerUsuario
                lEnvio.FECHA_ACT = cFechaHora.ObtenerFechaHora
                bEnvio.ActualizarENVIO(lEnvio)
            End If
        End If
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.MostrarMensaje("Registro guardado!")
        Return ""
    End Function

    Protected Sub txtNROBOLETA_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNROBOLETA.ValueChanged
        If TIPO_OPERACION = TipoOperacion.Edicion OrElse TIPO_OPERACION = TipoOperacion.Consulta Then
            'Recuperar datos del taco
            Dim lista As listaBASCULA
            Dim bBascula As New cBASCULA

            Me.txtNUMRECIBO_CANA.Value = Nothing
            Me.speBRUTO.Value = Nothing
            Me.dteFECHA_LEE_BRUTO.Value = Nothing
            Me.cbxUSUARIO_BRUTO.Value = Nothing
            Me.speTARA.Value = Nothing
            Me.dteFECHA_LEE_TARA.Value = Nothing
            Me.cbxUSUARIO_TARA.Value = Nothing
            Me.speNETOLIBRAS.Value = Nothing
            Me.speNETOTONEL.Value = Nothing

            If txtNROBOLETA.Value IsNot Nothing Then
                lista = bBascula.ObtenerListaPorBOLETA(Me.cbxZAFRA.Value, Me.txtNROBOLETA.Value)
                Me.Enabled = (TIPO_OPERACION = TipoOperacion.Edicion)

                If lista IsNot Nothing AndAlso lista.Count > 0 Then
                    Me.ID_BASCULA = lista(0).ID_BASCULA
                Else
                    Me._nuevo = True
                    Dim lstEnvio As listaENVIO = (New cENVIO).ObtenerListaPorBOLETA(Me.cbxZAFRA.Value, Me.txtNROBOLETA.Value)
                    If lstEnvio IsNot Nothing AndAlso lstEnvio.Count > 0 Then
                        Me.ID_ENVIO = lstEnvio(0).ID_ENVIO
                    End If
                    Me.ViewState("ID_BASCULA") = Nothing
                End If
            Else
                Me.AsignarMensaje(" * El No. de Taco no existe en la zafra " + Me.cbxZAFRA.Text, True)
                Return
            End If
        End If
    End Sub

    Protected Sub CALC_PESO_NETO_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles speBRUTO.ValueChanged, speTARA.ValueChanged
        SetearPesoNeto()
    End Sub

    Private Sub SetearPesoNeto()
        If IsNumeric(Me.speBRUTO.Value) AndAlso IsNumeric(Me.speTARA.Value) Then
            Me.speNETOLIBRAS.Value = Math.Round(Convert.ToDecimal(Me.speBRUTO.Value) - Convert.ToDecimal(Me.speTARA.Text), 2).ToString
            Me.speNETOTONEL.Value = Math.Round(Convert.ToDecimal(Me.speNETOLIBRAS.Value) / 1000D, 2).ToString
        Else
            Me.speNETOLIBRAS.Value = Nothing
            Me.speNETOTONEL.Value = Nothing
        End If
    End Sub
   
End Class
