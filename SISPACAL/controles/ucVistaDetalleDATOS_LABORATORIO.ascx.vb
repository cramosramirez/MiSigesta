Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleDATOS_LABORATORIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla DATOS_LABORATORIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleDATOS_LABORATORIO
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_DATOS_LAB As Int32
    Public Property ID_DATOS_LAB() As Int32
        Get
            Return Me.txtID_DATOS_LAB.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_DATOS_LAB = Value
            Me.txtID_DATOS_LAB.Text = CStr(Value)
            If Me._ID_DATOS_LAB > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_ANALISIS() As Int32
        Get
            Return Me.ddlANALISISID_ANALISIS.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlANALISISID_ANALISIS.Items.FindByValue(value) Is Nothing Then
                Me.ddlANALISISID_ANALISIS.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ANALISTA() As String
        Get
            Return Me.txtANALISTA.Text
        End Get
        Set(ByVal value As String)
            Me.txtANALISTA.Text = value.ToString()
        End Set
    End Property

    Public Property LBS_MUESTRA() As Decimal
        Get
            If Me.txtLBS_MUESTRA.Text ="" Then Return -1
            Return Me.txtLBS_MUESTRA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtLBS_MUESTRA.Text = value.ToString()
        End Set
    End Property

    Public Property LBS_PUNTAS_TIERNA() As Decimal
        Get
            If Me.txtLBS_PUNTAS_TIERNA.Text ="" Then Return -1
            Return Me.txtLBS_PUNTAS_TIERNA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtLBS_PUNTAS_TIERNA.Text = value.ToString()
        End Set
    End Property

    Public Property LBS_CANA_SECA() As Decimal
        Get
            If Me.txtLBS_CANA_SECA.Text ="" Then Return -1
            Return Me.txtLBS_CANA_SECA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtLBS_CANA_SECA.Text = value.ToString()
        End Set
    End Property

    Public Property LBS_MAMONES() As Decimal
        Get
            If Me.txtLBS_MAMONES.Text ="" Then Return -1
            Return Me.txtLBS_MAMONES.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtLBS_MAMONES.Text = value.ToString()
        End Set
    End Property

    Public Property LBS_BAJERA() As Decimal
        Get
            If Me.txtLBS_BAJERA.Text ="" Then Return -1
            Return Me.txtLBS_BAJERA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtLBS_BAJERA.Text = value.ToString()
        End Set
    End Property

    Public Property LBS_TIERRA_RAICES() As Decimal
        Get
            If Me.txtLBS_TIERRA_RAICES.Text ="" Then Return -1
            Return Me.txtLBS_TIERRA_RAICES.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtLBS_TIERRA_RAICES.Text = value.ToString()
        End Set
    End Property

    Public Property LBS_PIEDRA() As Decimal
        Get
            If Me.txtLBS_PIEDRA.Text ="" Then Return -1
            Return Me.txtLBS_PIEDRA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtLBS_PIEDRA.Text = value.ToString()
        End Set
    End Property

    Public Property LBS_CANA_LIMPIA() As Decimal
        Get
            If Me.txtLBS_CANA_LIMPIA.Text ="" Then Return -1
            Return Me.txtLBS_CANA_LIMPIA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtLBS_CANA_LIMPIA.Text = value.ToString()
        End Set
    End Property

    Public Property OBSERVACION() As String
        Get
            Return Me.txtOBSERVACION.Text
        End Get
        Set(ByVal value As String)
            Me.txtOBSERVACION.Text = value.ToString()
        End Set
    End Property

    Public Property PORC_PUNTAS_TIERNA() As Decimal
        Get
            If Me.txtPORC_PUNTAS_TIERNA.Text ="" Then Return -1
            Return Me.txtPORC_PUNTAS_TIERNA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtPORC_PUNTAS_TIERNA.Text = value.ToString()
        End Set
    End Property

    Public Property PORC_CANA_SECA() As Decimal
        Get
            If Me.txtPORC_CANA_SECA.Text ="" Then Return -1
            Return Me.txtPORC_CANA_SECA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtPORC_CANA_SECA.Text = value.ToString()
        End Set
    End Property

    Public Property PORC_MAMONES() As Decimal
        Get
            If Me.txtPORC_MAMONES.Text ="" Then Return -1
            Return Me.txtPORC_MAMONES.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtPORC_MAMONES.Text = value.ToString()
        End Set
    End Property

    Public Property PORC_BAJERA() As Decimal
        Get
            If Me.txtPORC_BAJERA.Text ="" Then Return -1
            Return Me.txtPORC_BAJERA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtPORC_BAJERA.Text = value.ToString()
        End Set
    End Property

    Public Property PORC_TIERRA_RAICES() As Decimal
        Get
            If Me.txtPORC_TIERRA_RAICES.Text ="" Then Return -1
            Return Me.txtPORC_TIERRA_RAICES.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtPORC_TIERRA_RAICES.Text = value.ToString()
        End Set
    End Property

    Public Property PORC_PIEDRA() As Decimal
        Get
            If Me.txtPORC_PIEDRA.Text ="" Then Return -1
            Return Me.txtPORC_PIEDRA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtPORC_PIEDRA.Text = value.ToString()
        End Set
    End Property

    Public Property PORC_CANA_LIMPIA() As Decimal
        Get
            If Me.txtPORC_CANA_LIMPIA.Text ="" Then Return -1
            Return Me.txtPORC_CANA_LIMPIA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtPORC_CANA_LIMPIA.Text = value.ToString()
        End Set
    End Property

    Public Property PORC_MATERIA_EXTRA() As Decimal
        Get
            If Me.txtPORC_MATERIA_EXTRA.Text ="" Then Return -1
            Return Me.txtPORC_MATERIA_EXTRA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtPORC_MATERIA_EXTRA.Text = value.ToString()
        End Set
    End Property

    Public Property ABSORVANCIA() As Decimal
        Get
            If Me.txtABSORVANCIA.Text ="" Then Return -1
            Return Me.txtABSORVANCIA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtABSORVANCIA.Text = value.ToString()
        End Set
    End Property

    Public Property DEXTRANA() As Decimal
        Get
            If Me.txtDEXTRANA.Text ="" Then Return -1
            Return Me.txtDEXTRANA.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtDEXTRANA.Text = value.ToString()
        End Set
    End Property

    Public Property ACIDEZ() As Decimal
        Get
            If Me.txtACIDEZ.Text ="" Then Return -1
            Return Me.txtACIDEZ.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtACIDEZ.Text = value.ToString()
        End Set
    End Property

    Public Property REDUCTORES() As Decimal
        Get
            If Me.txtREDUCTORES.Text ="" Then Return -1
            Return Me.txtREDUCTORES.Text
        End Get
        Set(ByVal value As Decimal)
            Me.txtREDUCTORES.Text = value.ToString()
        End Set
    End Property

    Public Property USUARIO_CREA() As String
        Get
            Return Me.txtUSUARIO_CREA.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSUARIO_CREA.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_CREA() As DateTime
        Get
            Return Me.txtFECHA_CREA.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_CREA.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property USUARIO_ACT() As String
        Get
            Return Me.txtUSUARIO_ACT.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSUARIO_ACT.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_ACT() As DateTime
        Get
            Return Me.txtFECHA_ACT.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_ACT.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property VerID_DATOS_LAB() As Boolean
        Get
            Return Me.trID_DATOS_LAB.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_DATOS_LAB.Visible = value
        End Set
    End Property

    Public Property VerID_ANALISIS() As Boolean
        Get
            Return Me.trID_ANALISIS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ANALISIS.Visible = value
        End Set
    End Property

    Public Property VerANALISTA() As Boolean
        Get
            Return Me.trANALISTA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trANALISTA.Visible = value
        End Set
    End Property

    Public Property VerLBS_MUESTRA() As Boolean
        Get
            Return Me.trLBS_MUESTRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLBS_MUESTRA.Visible = value
        End Set
    End Property

    Public Property VerLBS_PUNTAS_TIERNA() As Boolean
        Get
            Return Me.trLBS_PUNTAS_TIERNA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLBS_PUNTAS_TIERNA.Visible = value
        End Set
    End Property

    Public Property VerLBS_CANA_SECA() As Boolean
        Get
            Return Me.trLBS_CANA_SECA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLBS_CANA_SECA.Visible = value
        End Set
    End Property

    Public Property VerLBS_MAMONES() As Boolean
        Get
            Return Me.trLBS_MAMONES.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLBS_MAMONES.Visible = value
        End Set
    End Property

    Public Property VerLBS_BAJERA() As Boolean
        Get
            Return Me.trLBS_BAJERA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLBS_BAJERA.Visible = value
        End Set
    End Property

    Public Property VerLBS_TIERRA_RAICES() As Boolean
        Get
            Return Me.trLBS_TIERRA_RAICES.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLBS_TIERRA_RAICES.Visible = value
        End Set
    End Property

    Public Property VerLBS_PIEDRA() As Boolean
        Get
            Return Me.trLBS_PIEDRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLBS_PIEDRA.Visible = value
        End Set
    End Property

    Public Property VerLBS_CANA_LIMPIA() As Boolean
        Get
            Return Me.trLBS_CANA_LIMPIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLBS_CANA_LIMPIA.Visible = value
        End Set
    End Property

    Public Property VerOBSERVACION() As Boolean
        Get
            Return Me.trOBSERVACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOBSERVACION.Visible = value
        End Set
    End Property

    Public Property VerPORC_PUNTAS_TIERNA() As Boolean
        Get
            Return Me.trPORC_PUNTAS_TIERNA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPORC_PUNTAS_TIERNA.Visible = value
        End Set
    End Property

    Public Property VerPORC_CANA_SECA() As Boolean
        Get
            Return Me.trPORC_CANA_SECA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPORC_CANA_SECA.Visible = value
        End Set
    End Property

    Public Property VerPORC_MAMONES() As Boolean
        Get
            Return Me.trPORC_MAMONES.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPORC_MAMONES.Visible = value
        End Set
    End Property

    Public Property VerPORC_BAJERA() As Boolean
        Get
            Return Me.trPORC_BAJERA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPORC_BAJERA.Visible = value
        End Set
    End Property

    Public Property VerPORC_TIERRA_RAICES() As Boolean
        Get
            Return Me.trPORC_TIERRA_RAICES.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPORC_TIERRA_RAICES.Visible = value
        End Set
    End Property

    Public Property VerPORC_PIEDRA() As Boolean
        Get
            Return Me.trPORC_PIEDRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPORC_PIEDRA.Visible = value
        End Set
    End Property

    Public Property VerPORC_CANA_LIMPIA() As Boolean
        Get
            Return Me.trPORC_CANA_LIMPIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPORC_CANA_LIMPIA.Visible = value
        End Set
    End Property

    Public Property VerPORC_MATERIA_EXTRA() As Boolean
        Get
            Return Me.trPORC_MATERIA_EXTRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPORC_MATERIA_EXTRA.Visible = value
        End Set
    End Property

    Public Property VerABSORVANCIA() As Boolean
        Get
            Return Me.trABSORVANCIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trABSORVANCIA.Visible = value
        End Set
    End Property

    Public Property VerDEXTRANA() As Boolean
        Get
            Return Me.trDEXTRANA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDEXTRANA.Visible = value
        End Set
    End Property

    Public Property VerACIDEZ() As Boolean
        Get
            Return Me.trACIDEZ.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trACIDEZ.Visible = value
        End Set
    End Property

    Public Property VerREDUCTORES() As Boolean
        Get
            Return Me.trREDUCTORES.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trREDUCTORES.Visible = value
        End Set
    End Property

    Public Property VerUSUARIO_CREA() As Boolean
        Get
            Return Me.trUSUARIO_CREA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSUARIO_CREA.Visible = value
        End Set
    End Property

    Public Property VerFECHA_CREA() As Boolean
        Get
            Return Me.trFECHA_CREA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_CREA.Visible = value
        End Set
    End Property

    Public Property VerUSUARIO_ACT() As Boolean
        Get
            Return Me.trUSUARIO_ACT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSUARIO_ACT.Visible = value
        End Set
    End Property

    Public Property VerFECHA_ACT() As Boolean
        Get
            Return Me.trFECHA_ACT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_ACT.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cDATOS_LABORATORIO
    Private mEntidad As DATOS_LABORATORIO
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
        If Not Me.ViewState("ID_DATOS_LAB") Is Nothing Then Me._ID_DATOS_LAB = Me.ViewState("ID_DATOS_LAB")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla DATOS_LABORATORIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New DATOS_LABORATORIO
        mEntidad.ID_DATOS_LAB = ID_DATOS_LAB
 
        If mComponente.ObtenerDATOS_LABORATORIO(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_DATOS_LAB.Text = mEntidad.ID_DATOS_LAB.ToString()
        Me.ddlANALISISID_ANALISIS.Recuperar()
        Me.ddlANALISISID_ANALISIS.SelectedValue = mEntidad.ID_ANALISIS
        Me.txtANALISTA.Text = mEntidad.ANALISTA
        Me.txtLBS_MUESTRA.Text = mEntidad.LBS_MUESTRA
        Me.txtLBS_PUNTAS_TIERNA.Text = mEntidad.LBS_PUNTAS_TIERNA
        Me.txtLBS_CANA_SECA.Text = mEntidad.LBS_CANA_SECA
        Me.txtLBS_MAMONES.Text = mEntidad.LBS_MAMONES
        Me.txtLBS_BAJERA.Text = mEntidad.LBS_BAJERA
        Me.txtLBS_TIERRA_RAICES.Text = mEntidad.LBS_TIERRA_RAICES
        Me.txtLBS_PIEDRA.Text = mEntidad.LBS_PIEDRA
        Me.txtLBS_CANA_LIMPIA.Text = mEntidad.LBS_CANA_LIMPIA
        Me.txtOBSERVACION.Text = mEntidad.OBSERVACION
        Me.txtPORC_PUNTAS_TIERNA.Text = mEntidad.PORC_PUNTAS_TIERNA
        Me.txtPORC_CANA_SECA.Text = mEntidad.PORC_CANA_SECA
        Me.txtPORC_MAMONES.Text = mEntidad.PORC_MAMONES
        Me.txtPORC_BAJERA.Text = mEntidad.PORC_BAJERA
        Me.txtPORC_TIERRA_RAICES.Text = mEntidad.PORC_TIERRA_RAICES
        Me.txtPORC_PIEDRA.Text = mEntidad.PORC_PIEDRA
        Me.txtPORC_CANA_LIMPIA.Text = mEntidad.PORC_CANA_LIMPIA
        Me.txtPORC_MATERIA_EXTRA.Text = mEntidad.PORC_MATERIA_EXTRA
        Me.txtABSORVANCIA.Text = mEntidad.ABSORVANCIA
        Me.txtDEXTRANA.Text = mEntidad.DEXTRANA
        Me.txtACIDEZ.Text = mEntidad.ACIDEZ
        Me.txtREDUCTORES.Text = mEntidad.REDUCTORES
        Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        Me.txtFECHA_CREA.Text = IIf(Not mEntidad.FECHA_CREA = Nothing, Format(mEntidad.FECHA_CREA, "dd/MM/yyyy"), "")
        Me.txtUSUARIO_ACT.Text = mEntidad.USUARIO_ACT
        Me.txtFECHA_ACT.Text = IIf(Not mEntidad.FECHA_ACT = Nothing, Format(mEntidad.FECHA_ACT, "dd/MM/yyyy"), "")
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlANALISISID_ANALISIS.Enabled = edicion
        Me.txtANALISTA.Enabled = edicion
        Me.txtLBS_MUESTRA.Enabled = edicion
        Me.txtLBS_PUNTAS_TIERNA.Enabled = edicion
        Me.txtLBS_CANA_SECA.Enabled = edicion
        Me.txtLBS_MAMONES.Enabled = edicion
        Me.txtLBS_BAJERA.Enabled = edicion
        Me.txtLBS_TIERRA_RAICES.Enabled = edicion
        Me.txtLBS_PIEDRA.Enabled = edicion
        Me.txtLBS_CANA_LIMPIA.Enabled = edicion
        Me.txtOBSERVACION.Enabled = edicion
        Me.txtPORC_PUNTAS_TIERNA.Enabled = edicion
        Me.txtPORC_CANA_SECA.Enabled = edicion
        Me.txtPORC_MAMONES.Enabled = edicion
        Me.txtPORC_BAJERA.Enabled = edicion
        Me.txtPORC_TIERRA_RAICES.Enabled = edicion
        Me.txtPORC_PIEDRA.Enabled = edicion
        Me.txtPORC_CANA_LIMPIA.Enabled = edicion
        Me.txtPORC_MATERIA_EXTRA.Enabled = edicion
        Me.txtABSORVANCIA.Enabled = edicion
        Me.txtDEXTRANA.Enabled = edicion
        Me.txtACIDEZ.Enabled = edicion
        Me.txtREDUCTORES.Enabled = edicion
        Me.txtUSUARIO_CREA.Enabled = edicion
        Me.txtFECHA_CREA.Enabled = edicion
        Me.txtUSUARIO_ACT.Enabled = edicion
        Me.txtFECHA_ACT.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlANALISISID_ANALISIS.Recuperar()
        Me.txtANALISTA.Text = ""
        Me.txtLBS_MUESTRA.Text = ""
        Me.txtLBS_PUNTAS_TIERNA.Text = ""
        Me.txtLBS_CANA_SECA.Text = ""
        Me.txtLBS_MAMONES.Text = ""
        Me.txtLBS_BAJERA.Text = ""
        Me.txtLBS_TIERRA_RAICES.Text = ""
        Me.txtLBS_PIEDRA.Text = ""
        Me.txtLBS_CANA_LIMPIA.Text = ""
        Me.txtOBSERVACION.Text = ""
        Me.txtPORC_PUNTAS_TIERNA.Text = ""
        Me.txtPORC_CANA_SECA.Text = ""
        Me.txtPORC_MAMONES.Text = ""
        Me.txtPORC_BAJERA.Text = ""
        Me.txtPORC_TIERRA_RAICES.Text = ""
        Me.txtPORC_PIEDRA.Text = ""
        Me.txtPORC_CANA_LIMPIA.Text = ""
        Me.txtPORC_MATERIA_EXTRA.Text = ""
        Me.txtABSORVANCIA.Text = ""
        Me.txtDEXTRANA.Text = ""
        Me.txtACIDEZ.Text = ""
        Me.txtREDUCTORES.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla DATOS_LABORATORIO
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New DATOS_LABORATORIO
        If Me._nuevo Then
            mEntidad.ID_DATOS_LAB = 0
        Else
            mEntidad.ID_DATOS_LAB = CInt(Me.txtID_DATOS_LAB.Text)
        End If
        mEntidad.ID_ANALISIS = Me.ddlANALISISID_ANALISIS.SelectedValue
        mEntidad.ANALISTA = Me.txtANALISTA.Text
        mEntidad.LBS_MUESTRA = Val(Me.txtLBS_MUESTRA.Text)
        mEntidad.LBS_PUNTAS_TIERNA = Val(Me.txtLBS_PUNTAS_TIERNA.Text)
        mEntidad.LBS_CANA_SECA = Val(Me.txtLBS_CANA_SECA.Text)
        mEntidad.LBS_MAMONES = Val(Me.txtLBS_MAMONES.Text)
        mEntidad.LBS_BAJERA = Val(Me.txtLBS_BAJERA.Text)
        mEntidad.LBS_TIERRA_RAICES = Val(Me.txtLBS_TIERRA_RAICES.Text)
        mEntidad.LBS_PIEDRA = Val(Me.txtLBS_PIEDRA.Text)
        mEntidad.LBS_CANA_LIMPIA = Val(Me.txtLBS_CANA_LIMPIA.Text)
        mEntidad.OBSERVACION = Me.txtOBSERVACION.Text
        mEntidad.PORC_PUNTAS_TIERNA = Val(Me.txtPORC_PUNTAS_TIERNA.Text)
        mEntidad.PORC_CANA_SECA = Val(Me.txtPORC_CANA_SECA.Text)
        mEntidad.PORC_MAMONES = Val(Me.txtPORC_MAMONES.Text)
        mEntidad.PORC_BAJERA = Val(Me.txtPORC_BAJERA.Text)
        mEntidad.PORC_TIERRA_RAICES = Val(Me.txtPORC_TIERRA_RAICES.Text)
        mEntidad.PORC_PIEDRA = Val(Me.txtPORC_PIEDRA.Text)
        mEntidad.PORC_CANA_LIMPIA = Val(Me.txtPORC_CANA_LIMPIA.Text)
        mEntidad.PORC_MATERIA_EXTRA = Val(Me.txtPORC_MATERIA_EXTRA.Text)
        mEntidad.ABSORVANCIA = Val(Me.txtABSORVANCIA.Text)
        mEntidad.DEXTRANA = Val(Me.txtDEXTRANA.Text)
        mEntidad.ACIDEZ = Val(Me.txtACIDEZ.Text)
        mEntidad.REDUCTORES = Val(Me.txtREDUCTORES.Text)
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        If Me.txtFECHA_CREA.Text <> "" Then mEntidad.FECHA_CREA = System.DateTime.Parse(Me.txtFECHA_CREA.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        If Me.txtFECHA_ACT.Text <> "" Then mEntidad.FECHA_ACT = System.DateTime.Parse(Me.txtFECHA_ACT.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If mComponente.ActualizarDATOS_LABORATORIO(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_DATOS_LAB.Text = mEntidad.ID_DATOS_LAB.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
