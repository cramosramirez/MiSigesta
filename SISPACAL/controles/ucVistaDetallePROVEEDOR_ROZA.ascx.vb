Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetallePROVEEDOR_ROZA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PROVEEDOR_ROZA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetallePROVEEDOR_ROZA
    Inherits ucBase

#Region "Propiedades"

    Private _ID_PROVEEDOR_ROZA As Int32
    Public Property ID_PROVEEDOR_ROZA() As Int32
        Get
            If Me.ViewState("ID_PROVEEDOR_ROZA") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_PROVEEDOR_ROZA"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_PROVEEDOR_ROZA") = Value
            If Value > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property


    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cPROVEEDOR_ROZA
    Private mEntidad As PROVEEDOR_ROZA
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
        If Not Me.ViewState("ID_PROVEEDOR_ROZA") Is Nothing Then Me._ID_PROVEEDOR_ROZA = Me.ViewState("ID_PROVEEDOR_ROZA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla PROVEEDOR_ROZA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        Dim lEntidad As PROVEEDOR_ROZA = mComponente.ObtenerPROVEEDOR_ROZA(Me.ID_PROVEEDOR_ROZA)

        If lEntidad IsNot Nothing Then
            Me.cbxTIPO_PERSONA.Value = lEntidad.ID_TIPO_PERSONA
            Me.txtDUI.Text = lEntidad.DUI
            Me.txtNIT.Text = lEntidad.NIT
            Me.txtNOMBRES.Text = lEntidad.NOMBRE_PROVEEDOR_ROZA
            Me.txtAPELLIDOS.Text = lEntidad.APELLIDOS
            Me.txtTELEFONO.Text = lEntidad.TELEFONO
            Me.txtDIRECCION.Text = lEntidad.DIRECCION
            Me.txtCORREO.Text = lEntidad.CORREO
            Me.txtNRC.Text = lEntidad.CREDITO_FISCAL
            Me.txtACTIVIDAD.Text = lEntidad.ACTIVIDAD.Trim.ToUpper
            Me.cbxDEPARTAMENTO.Value = lEntidad.CODI_DEPTO
            Me.CargarMunicipios()
            Me.cbxMUNICIPIO.Value = lEntidad.CODI_MUNI
            Me.chkACTIVO.Checked = lEntidad.ACTIVO
            Me.txtCODIGO.Text = lEntidad.CODIGO
        End If
        Me.cbxTIPO_PERSONA.Focus()
    End Sub

    Private Sub CargarMunicipios()
        Me.odsMunicipio.SelectParameters("CODI_DEPTO").DefaultValue = cbxDEPARTAMENTO.Value
        Me.odsMunicipio.SelectParameters("agregarVacio").DefaultValue = True
        Me.odsMunicipio.SelectParameters("agregarTodos").DefaultValue = False
        Me.odsMunicipio.SelectParameters("conPresencia").DefaultValue = False
        Me.cbxMUNICIPIO.DataBind()
        Me.cbxMUNICIPIO.Focus()
    End Sub

    Private Sub cbxDEPARTAMENTO_ValueChanged(sender As Object, e As EventArgs) Handles cbxDEPARTAMENTO.ValueChanged
        Me.CargarMunicipios()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxTIPO_PERSONA.ClientEnabled = Me._nuevo
        If Me.cbxTIPO_PERSONA.Value = Nothing Then
            Me.txtDUI.ClientEnabled = False
            Me.txtNIT.ClientEnabled = True
            Me.txtNOMBRES.ClientEnabled = edicion
            Me.txtAPELLIDOS.ClientEnabled = edicion
        ElseIf Me.cbxTIPO_PERSONA.Value = TipoPersona.Natural Then
            Me.txtDUI.ClientEnabled = edicion
            Me.txtNIT.ClientEnabled = edicion
            Me.txtNOMBRES.ClientEnabled = edicion
            Me.txtAPELLIDOS.ClientEnabled = edicion
        ElseIf Me.cbxTIPO_PERSONA.Value = TipoPersona.Juridica Then
            Me.txtDUI.ClientEnabled = False
            Me.txtNIT.ClientEnabled = edicion
            Me.txtNOMBRES.ClientEnabled = edicion
            Me.txtAPELLIDOS.ClientEnabled = False
        End If
        Me.cbxDEPARTAMENTO.ClientEnabled = edicion
        Me.cbxMUNICIPIO.ClientEnabled = edicion
        Me.txtTELEFONO.ClientEnabled = edicion
        Me.txtDIRECCION.ClientEnabled = edicion
        Me.txtCORREO.ClientEnabled = edicion
        Me.txtNRC.ClientEnabled = edicion
        Me.txtCODIGO.ClientEnabled = edicion
        Me.chkACTIVO.ClientEnabled = edicion
        Me.txtACTIVIDAD.ClientEnabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.cbxTIPO_PERSONA.Value = Nothing
        Me.cbxDEPARTAMENTO.Value = Nothing
        Me.cbxMUNICIPIO.Value = Nothing
        Me.txtDUI.Text = ""
        Me.txtNIT.Text = ""
        Me.txtNOMBRES.Text = ""
        Me.txtAPELLIDOS.Text = ""
        Me.txtTELEFONO.Text = ""
        Me.txtDIRECCION.Text = ""
        Me.txtCORREO.Text = ""
        Me.txtNRC.Text = ""
        Me.chkACTIVO.Checked = True
        Me.txtCODIGO.Text = ""
        Me.txtACTIVIDAD.Text = ""
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla PROVEEDOR_ROZA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New StringBuilder("")
        Dim alDatos As New ArrayList
        Dim mEntidad As New PROVEEDOR_ROZA

        If Me.cbxTIPO_PERSONA.Value = Nothing Then
            sError.AppendLine("* Seleccione el tipo de persona")
        Else
            If Me.cbxTIPO_PERSONA.Value = TipoPersona.Natural Then
                If Me.txtDUI.Text.Trim = "" OrElse Me.txtDUI.Text.Trim.Length <> 9 Then
                    sError.AppendLine("* DUI no valido")
                End If
                If Me.txtNOMBRES.Text.Trim = "" Then
                    sError.AppendLine("* Ingrese los nombres")
                End If
                If Me.txtAPELLIDOS.Text.Trim = "" Then
                    sError.AppendLine("* Ingrese los apellidos")
                End If
            ElseIf Me.cbxTIPO_PERSONA.Value = TipoPersona.Juridica Then
                If Me.txtNIT.Text.Trim = "" OrElse Me.txtNIT.Text.Trim.Length <> 14 Then
                    sError.AppendLine("* NIT no valido")
                End If
                If Me.txtNOMBRES.Text.Trim = "" Then
                    sError.AppendLine("* Ingrese el nombre de la entidad")
                End If
            End If
        End If
        If Me.txtTELEFONO.Text.Trim = "" Then
            sError.AppendLine("* Ingrese el telefono de contacto")
        End If
        If Me.txtDIRECCION.Text.Trim = "" Then
            sError.AppendLine("* Ingrese la direccion")
        End If
        If Me.txtCODIGO.Text.Trim = "" Then
            sError.AppendLine("* Ingrese el codigo de proveedor con formato RZ[Correlativo]")
        End If
        If Me.txtNRC.Text.Trim <> "" AndAlso Me.txtACTIVIDAD.Text.Trim = "" Then
            sError.AppendLine("* Ingrese la actividad primaria")
        End If
        If Me.txtNRC.Text.Trim = "" AndAlso Me.txtACTIVIDAD.Text.Trim <> "" Then
            sError.AppendLine("* Ingrese el NRC")
        End If
        If Me.cbxDEPARTAMENTO.Value = Nothing Then
            sError.AppendLine("* Seleccione departamento")
        End If
        If Me.cbxMUNICIPIO.Value = Nothing Then
            sError.AppendLine("* Seleccione municipio")
        End If

        If sError.ToString <> "" Then
            Return sError.ToString
        End If
        If Me._nuevo Then
            mEntidad.ID_PROVEEDOR_ROZA = 0
            mEntidad.ID_TIPO_ROZA = 21
            mEntidad.FACTOR_PAGO = 1
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = (New cPROVEEDOR_ROZA).ObtenerPROVEEDOR_ROZA(Me.ID_PROVEEDOR_ROZA)
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        If Me.cbxTIPO_PERSONA.Value = TipoPersona.Natural Then
            mEntidad.DUI = Me.txtDUI.Text
        ElseIf Me.cbxTIPO_PERSONA.Value = TipoPersona.Juridica Then
            mEntidad.DUI = ""
        End If
        mEntidad.NIT = Me.txtNIT.Text
        mEntidad.NOMBRE_PROVEEDOR_ROZA = Me.txtNOMBRES.Text.Trim.ToUpper
        mEntidad.APELLIDOS = Me.txtAPELLIDOS.Text.Trim.ToUpper
        mEntidad.TELEFONO = Me.txtTELEFONO.Text
        mEntidad.DIRECCION = Me.txtDIRECCION.Text.Trim.ToUpper
        mEntidad.CODI_DEPTO = Me.cbxDEPARTAMENTO.Value
        mEntidad.CODI_MUNI = Me.cbxMUNICIPIO.Value
        mEntidad.CORREO = Me.txtCORREO.Text.Trim.ToLower
        mEntidad.CREDITO_FISCAL = Me.txtNRC.Text.Trim
        mEntidad.ID_TIPO_PERSONA = Me.cbxTIPO_PERSONA.Value
        mEntidad.CODIGO = Me.txtCODIGO.Text.Trim.ToUpper
        mEntidad.ACTIVO = Me.chkACTIVO.Checked
        mEntidad.ACTIVIDAD = Me.txtACTIVIDAD.Text.Trim.ToUpper

        If Me.txtNRC.Text.Trim = "" Then
            mEntidad.ES_CONTRIBUYENTE = False
        Else
            mEntidad.ES_CONTRIBUYENTE = True
        End If

        If mComponente.ActualizarPROVEEDOR_ROZA(mEntidad) <= 0 Then
            Return mComponente.sError
        End If
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ViewState("ID_PROVEEDOR_ROZA") = mEntidad.ID_PROVEEDOR_ROZA
        Return ""
    End Function

    Private Sub cbxTIPO_PERSONA_ValueChanged(sender As Object, e As EventArgs) Handles cbxTIPO_PERSONA.ValueChanged
        If cbxTIPO_PERSONA.Value IsNot Nothing AndAlso Convert.ToInt32(cbxTIPO_PERSONA.Value) = TipoPersona.Natural Then
            Me.txtDUI.ClientEnabled = True
        ElseIf cbxTIPO_PERSONA.Value IsNot Nothing AndAlso Convert.ToInt32(cbxTIPO_PERSONA.Value) = TipoPersona.Juridica Then
            Me.txtDUI.ClientEnabled = False
            Me.txtDUI.Text = ""
        End If
    End Sub
End Class
