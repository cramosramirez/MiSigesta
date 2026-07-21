Imports System.Data
Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCREFISCAL_PROVEEDOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CREFISCAL_PROVEEDOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/11/2023	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCREFISCAL_PROVEEDOR
    Inherits ucBase

#Region "Propiedades"

    Private _ID_CCF As Int32
    Public Property ID_CCF() As Int32
        Get
            If Me.ViewState("ID_CCF") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_CCF"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_CCF") = Value
        End Set
    End Property

    Public Property ID_COMPROB_ENCA As Integer
        Get
            If Me.ViewState("ID_COMPROB_ENCA") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_COMPROB_ENCA"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_COMPROB_ENCA") = Value
            AsignarContribuyente()
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
    Private mComponente As New cCREFISCAL_PROVEEDOR
    Private mEntidad As CREFISCAL_PROVEEDOR
    Public Event ErrorEvent(ByVal errorMessage As String)

    Private Sub AsignarContribuyente()
        Dim bEntidad As New cCOMPROB_ENCA
        Dim lEntidad As COMPROB_ENCA

        lEntidad = bEntidad.ObtenerCOMPROB_ENCA(Me.ID_COMPROB_ENCA)
        If lEntidad IsNot Nothing Then
            Me.txtCONTRIBUYENTE.Text = lEntidad.NOMBRES + " " + lEntidad.APELLIDOS
            Me.txtNIT.Text = Utilerias.FormatearNIT(lEntidad.NIT)
        Else
            Me.txtCONTRIBUYENTE.Text = ""
            Me.txtNIT.Text = ""
        End If
    End Sub

    Private Sub SugerirDatosCCF()
        Dim bEntidad As New cCOMPROB_ENCA
        Dim lEntidad As COMPROB_ENCA

        lEntidad = bEntidad.ObtenerCOMPROB_ENCA(Me.ID_COMPROB_ENCA)
        If lEntidad IsNot Nothing Then
            Dim lstPlanilla As listaPLANILLA = (New cPLANILLA).ObtenerListaPorCRITERIOS(lEntidad.ID_CATORCENA, lEntidad.ID_TIPO_PLANILLA, lEntidad.CODIGO, "")
            If lstPlanilla IsNot Nothing AndAlso lstPlanilla.Count > 0 Then
                Dim lDatosCCF As DataSet = (New cCREFISCAL_PROVEEDOR).ObtenerDatosUltimoCCF(lstPlanilla(0).CODIPROVEEDOR_TRANSPORTISTA, lstPlanilla(0).ID_TIPO_PROVEEDOR)

                If lDatosCCF IsNot Nothing AndAlso lDatosCCF.Tables.Count > 0 Then
                    If lDatosCCF.Tables(0).Rows.Count > 0 Then
                        Me.txtNUMERO.Text = lDatosCCF.Tables(0).Rows(0)("NUMERO")
                        Me.txtSELLO_RECEPCION.Text = lDatosCCF.Tables(0).Rows(0)("SELLO_RECEPCION")
                    End If
                End If
            End If
        End If
    End Sub

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
        If Not Me.ViewState("ID_CCF") Is Nothing Then Me._ID_CCF = Me.ViewState("ID_CCF")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla CREFISCAL_PROVEEDOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        Dim listaCredFisProvee As listaCREFISCAL_PROVEEDOR

        listaCredFisProvee = (New cCREFISCAL_PROVEEDOR).ObtenerListaPorCOMPROB_ENCA(Me.ID_COMPROB_ENCA)

        If listaCredFisProvee IsNot Nothing AndAlso listaCredFisProvee.Count > 0 Then
            Me.ID_CCF = listaCredFisProvee(0).ID_CCF
            Me.txtNUMERO.Text = listaCredFisProvee(0).NUMERO
            Me.dteFECHA.Value = listaCredFisProvee(0).FECHA
            Me.txtCODI_GENERACION.Text = listaCredFisProvee(0).CODI_GENERACION
            Me.txtSELLO_RECEPCION.Text = listaCredFisProvee(0).SELLO_RECEPCION
        Else
            Me.Nuevo()
            Me.SugerirDatosCCF()
            Me.ID_CCF = 0
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.dteFECHA.ClientEnabled = edicion
        Me.txtNUMERO.ClientEnabled = edicion
        Me.txtCODI_GENERACION.ClientEnabled = edicion
        Me.txtSELLO_RECEPCION.ClientEnabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Me.txtNUMERO.Text = ""
        Me.dteFECHA.Value = Nothing
        Me.txtCODI_GENERACION.Text = ""
        Me.txtSELLO_RECEPCION.Text = ""
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla CREFISCAL_PROVEEDOR
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/11/2023	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New CREFISCAL_PROVEEDOR

        mEntidad.ID_CCF = CInt(Me.ID_CCF)
        mEntidad.ID_COMPROB_ENCA = ID_COMPROB_ENCA

        If Me.txtNUMERO.Text = "" Then
            Return "* Ingrese el numero del comprobante"
        End If
        If dteFECHA.Value = Nothing Then
            Return "* Ingrese la fecha del comprobante"
        End If
        If Me.txtCODI_GENERACION.Text = "" Then
            Return "* N° Documento / Código de generación"
        End If
        If Me.txtSELLO_RECEPCION.Text = "" Then
            Return "* Serie / Sello de recepción"
        End If
        If Me.txtNUMERO.Text = "" Then
            Return "* Resolucion / N° de Control"
        End If
        If Me.dteFECHA.Value Is Nothing Then
            Return "* Ingrese la fecha del documento"
        End If
        ' Validaciones del documento electronico
        If Me.txtNUMERO.Text.Trim.ToUpper.Length >= 3 AndAlso Me.txtNUMERO.Text.Substring(0, 3).ToUpper = "DTE" Then
            If Me.txtNUMERO.Text.Trim.Length <> 31 Then
                Return "* Numero de control debe contener 31 caracteres"
            End If
            If Me.txtCODI_GENERACION.Text.Trim.Length <> 36 Then
                Return "* Código de generacion debe contener 36 caracteres"
            End If
            If Me.txtSELLO_RECEPCION.Text.Trim.Length <> 40 Then
                Return "* Sello de recepcion debe contener 40 caracteres"
            End If
        End If
        'Validar si ya se registro un CCF por doble-clic del usuario
        Dim listaCredFisProvee As listaCREFISCAL_PROVEEDOR
        listaCredFisProvee = (New cCREFISCAL_PROVEEDOR).ObtenerListaPorCOMPROB_ENCA(Me.ID_COMPROB_ENCA)
        If listaCredFisProvee IsNot Nothing AndAlso listaCredFisProvee.Count > 0 Then
            mEntidad = listaCredFisProvee(0)
        End If
        If Me.txtNUMERO.Text.Trim.Length >= 3 AndAlso Me.txtNUMERO.Text.Substring(0, 3).ToUpper = "DTE" Then
            mEntidad.ID_TIPO_COMPROB = 11
        Else
            mEntidad.ID_TIPO_COMPROB = 1
        End If
        mEntidad.CODI_GENERACION = Me.txtCODI_GENERACION.Text.Trim.ToUpper
        mEntidad.SELLO_RECEPCION = Me.txtSELLO_RECEPCION.Text.Trim.ToUpper
        mEntidad.FECHA = Me.dteFECHA.Value
        mEntidad.NUMERO = Me.txtNUMERO.Text.Trim.ToUpper
        mEntidad.SERIE = ""
        mEntidad.USUARIO_CREA = Me.ObtenerUsuario
        mEntidad.FECHA_CREA = Now

        If mComponente.ActualizarCREFISCAL_PROVEEDOR(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
