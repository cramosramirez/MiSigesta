Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleBASE_PROVEEDORES_MH
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla BASE_PROVEEDORES_MH
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/10/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleBASE_PROVEEDORES_MH
    Inherits ucBase

#Region "Propiedades"

    Private _ID_BASE_PROVEE As Int32
    Public Property ID_BASE_PROVEE() As Int32
        Get
            If Me.ViewState("ID_BASE_PROVEE") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_BASE_PROVEE"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_BASE_PROVEE") = Value
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
    Private mComponente As New cBASE_PROVEEDORES_MH
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
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_BASE_PROVEE") Is Nothing Then Me._ID_BASE_PROVEE = Me.ViewState("ID_BASE_PROVEE")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla BASE_PROVEEDORES_MH
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        Dim lEntidad As BASE_PROVEEDORES_MH = mComponente.ObtenerBASE_PROVEEDORES_MH(Me.ID_BASE_PROVEE)

        If lEntidad IsNot Nothing Then
            Me.cbxTIPO_PERSONA.Value = lEntidad.ID_TIPO_PERSONA
            Me.txtDUI.Text = lEntidad.DUI
            Me.txtNIT.Text = lEntidad.NIT
            Me.txtNOMBRES.Text = lEntidad.NOMBRES.Trim.ToUpper
            Me.txtAPELLIDOS.Text = lEntidad.APELLIDOS.Trim.ToUpper
            Me.txtTELEFONO.Text = lEntidad.TELEFONO
            Me.txtDIRECCION.Text = lEntidad.DIRECCION.Trim.ToUpper
            Me.txtCORREO.Text = lEntidad.CORREO
            Me.txtNRC.Text = lEntidad.NRC
            Me.txtACTIVIDAD.Text = lEntidad.ACTIVIDAD.Trim.ToUpper
            Me.cbxDEPARTAMENTO.Value = lEntidad.CODI_DEPTO
            Me.CargarMunicipios()
            Me.cbxMUNICIPIO.Value = lEntidad.CODI_MUNI
        End If
        Me.cbxTIPO_PERSONA.Focus()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxTIPO_PERSONA.ClientEnabled = Me._nuevo
        If Me.cbxTIPO_PERSONA.Value = Nothing Then
            Me.txtDUI.ClientEnabled = False
            Me.txtNIT.ClientEnabled = False
            Me.txtNOMBRES.ClientEnabled = edicion
            Me.txtAPELLIDOS.ClientEnabled = False
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
        Me.txtACTIVIDAD.ClientEnabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/10/2022	Created
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
        Me.txtACTIVIDAD.Text = ""
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla BASE_PROVEEDORES_MH
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/10/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New StringBuilder("")
        Dim alDatos As New ArrayList
        Dim mEntidad As New BASE_PROVEEDORES_MH

        If Me.cbxTIPO_PERSONA.Value = Nothing Then
            sError.AppendLine("* Seleccione el tipo de persona")
        Else
            If Me.cbxTIPO_PERSONA.Value = TipoPersona.Natural Then
                If Me.txtDUI.Text.Trim = "" OrElse Me.txtDUI.Text.Trim.Length <> 9 Then
                    sError.AppendLine("* DUI no valido")
                End If
                If Me.txtNOMBRES.Text.Trim = "" Then
                    sError.AppendLine("* Ingrese los nombres de la persona")
                End If
                If Me.txtAPELLIDOS.Text.Trim = "" Then
                    sError.AppendLine("* Ingrese los apellidos de la persona")
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
            mEntidad.ID_BASE_PROVEE = 0
        Else
            mEntidad.ID_BASE_PROVEE = Me.ID_BASE_PROVEE
        End If
        If Me.cbxTIPO_PERSONA.Value = TipoPersona.Natural Then
            mEntidad.DUI = Me.txtDUI.Text
            ' mEntidad.NIT = Utilerias.RellenarIzquierda(Me.txtDUI.Text.Trim, 14, "0")
        ElseIf Me.cbxTIPO_PERSONA.Value = TipoPersona.Juridica Then
            mEntidad.DUI = ""
            mEntidad.NIT = Me.txtNIT.Text
        End If
        mEntidad.DUI = Me.txtDUI.Text
        mEntidad.NIT = Me.txtNIT.Text
        mEntidad.NOMBRES = Me.txtNOMBRES.Text.Trim.ToUpper
        mEntidad.APELLIDOS = Me.txtAPELLIDOS.Text.Trim.ToUpper
        mEntidad.TELEFONO = Me.txtTELEFONO.Text
        mEntidad.DIRECCION = Me.txtDIRECCION.Text.Trim.ToUpper
        mEntidad.CODI_DEPTO = Me.cbxDEPARTAMENTO.Value
        mEntidad.CODI_MUNI = Me.cbxMUNICIPIO.Value
        mEntidad.CORREO = Me.txtCORREO.Text.Trim.ToLower
        mEntidad.NRC = Me.txtNRC.Text
        mEntidad.ACTIVIDAD = Me.txtACTIVIDAD.Text.Trim.ToUpper
        mEntidad.ID_TIPO_PERSONA = Me.cbxTIPO_PERSONA.Value

        If mComponente.ActualizarBASE_PROVEEDORES_MH(mEntidad) <= 0 Then
            Return mComponente.sError
        End If
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ViewState("ID_BASE_PROVEE") = mEntidad.ID_BASE_PROVEE
        Return ""
    End Function

    Protected Sub cbxTIPO_PERSONA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTIPO_PERSONA.SelectedIndexChanged
        Me.ConfigurarTipoPersona()
    End Sub

    Private Sub ConfigurarTipoPersona()
        If Me.cbxTIPO_PERSONA.Value = TipoPersona.Natural Then
            Me.txtDUI.ClientEnabled = True
            Me.txtNIT.ClientEnabled = True
            Me.txtAPELLIDOS.ClientEnabled = True
            Me.txtNIT.Text = ""
        ElseIf Me.cbxTIPO_PERSONA.Value = TipoPersona.Juridica Then
            Me.txtDUI.Text = ""
            Me.txtDUI.ClientEnabled = False
            Me.txtNIT.ClientEnabled = True
            Me.txtAPELLIDOS.Text = ""
            Me.txtAPELLIDOS.ClientEnabled = False
        End If
    End Sub
    Private Sub CargarMunicipios()
        Me.odsMunicipio.SelectParameters("CODI_DEPTO").DefaultValue = cbxDEPARTAMENTO.Value
        Me.odsMunicipio.SelectParameters("agregarVacio").DefaultValue = True
        Me.odsMunicipio.SelectParameters("agregarTodos").DefaultValue = False
        Me.odsMunicipio.SelectParameters("conPresencia").DefaultValue = False
        Me.cbxMUNICIPIO.DataBind()
        Me.cbxMUNICIPIO.Focus()
    End Sub

    'Protected Sub txtDUI_ValueChanged(sender As Object, e As EventArgs) Handles txtDUI.ValueChanged
    '    If Me.txtDUI.Text.Length = 9 Then
    '        Me.txtNIT.Text = Utilerias.RellenarIzquierda(Me.txtDUI.Text.Trim, 14, "0")
    '    Else
    '        Me.txtNIT.Text = ""
    '    End If
    'End Sub

    Private Sub cbxDEPARTAMENTO_ValueChanged(sender As Object, e As EventArgs) Handles cbxDEPARTAMENTO.ValueChanged
        Me.CargarMunicipios()
    End Sub

End Class
