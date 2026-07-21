Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleLABFAB_ANALISIS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla LABFAB_ANALISIS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleLABFAB_ANALISIS
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_ANALISIS As Int32
    Public Property ID_ANALISIS() As Int32
        Get
            If Me.ViewState("ID_ANALISIS") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_ANALISIS"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_ANALISIS") = Value
            Me.lblREFERENCIA.Text = Guid.NewGuid.ToString

            Me._ID_ANALISIS = Value
            Me.txtID_ANALISIS.Text = CStr(Value)
            If Me._ID_ANALISIS > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Sub LimpiarSesion()
        If lblREFERENCIA.Text <> "" Then
            If Session(lblREFERENCIA.Text) IsNot Nothing Then
                Session.Remove(lblREFERENCIA.Text)
            End If
        End If
    End Sub

    Public Property LISTA_LABFAB_VAR As listaLABFAB_VAR
        Set(value As listaLABFAB_VAR)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaLABFAB_VAR) Else Return New listaLABFAB_VAR
        End Get
    End Property



    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cLABFAB_ANALISIS
    Private mEntidad As LABFAB_ANALISIS
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
        If Not Me.ViewState("ID_ANALISIS") Is Nothing Then Me._ID_ANALISIS = Me.ViewState("ID_ANALISIS")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla LABFAB_ANALISIS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Dim lMuestra As LABFAB_MUESTRA
        Dim listaVars As listaLABFAB_VAR
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New LABFAB_ANALISIS
        mEntidad.ID_ANALISIS = ID_ANALISIS

        If mComponente.ObtenerLABFAB_ANALISIS(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_ANALISIS.Text = mEntidad.ID_ANALISIS.ToString()

        lMuestra = (New cLABFAB_MUESTRA).ObtenerLABFAB_MUESTRA(mEntidad.ID_MUESTRA)
        If lMuestra IsNot Nothing Then
            Me.cbxLABFAB_ETAPA.Value = lMuestra.ID_ETAPA
        End If
        CargarMuestras()
        Me.cbxLABFAB_MUESTRA.Value = mEntidad.ID_MUESTRA
        Me.txtNOMBRE_ANALISIS.Text = mEntidad.NOMBRE_ANALISIS
        Me.txtFORMULA.Text = mEntidad.FORMULA
        Me.txtOBSERVACIONES.Text = mEntidad.OBSERVACIONES
        Me.txtCANT_ANALISIS.Value = mEntidad.CANT_ANALISIS
        Me.txtORDEN_EJEC.Value = mEntidad.ORDEN_EJEC

        Session("ID_MUESTRAsesion") = mEntidad.ID_MUESTRA
        listaVars = (New cLABFAB_VAR).ObtenerListaPorLABFAB_ANALISIS(mEntidad.ID_ANALISIS)
        For i = 0 To listaVars.Count - 1
            listaVars(i).REFERENCIA = Me.lblREFERENCIA.Text
        Next
        Me.LISTA_LABFAB_VAR = listaVars
        Me.CargarVariables()
        Me.ucListaLABFAB_VAR1.Visible = True
    End Sub

    Public Sub CargarVariables()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaLABFAB_VAR1.CargarDatosCache(Me.lblREFERENCIA.Text)
        End If
    End Sub

    Private Sub CargarMuestras()
        Dim lista As listaLABFAB_MUESTRA
        If Me.cbxLABFAB_ETAPA.Value IsNot Nothing Then
            lista = (New cLABFAB_MUESTRA).ObtenerListaPorLABFAB_ETAPA(CInt(Me.cbxLABFAB_ETAPA.Value))
        Else
            lista = New listaLABFAB_MUESTRA
        End If
        Me.cbxLABFAB_MUESTRA.Text = ""
        Me.cbxLABFAB_MUESTRA.DataSource = lista
        Me.cbxLABFAB_MUESTRA.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxLABFAB_ETAPA.ClientEnabled = Me._nuevo
        Me.cbxLABFAB_MUESTRA.ClientEnabled = Me._nuevo
        Me.txtNOMBRE_ANALISIS.ClientEnabled = edicion
        Me.txtFORMULA.ClientEnabled = edicion
        Me.txtOBSERVACIONES.ClientEnabled = edicion
        Me.txtCANT_ANALISIS.ClientEnabled = edicion
        Me.txtUSUARIO_CREA.ClientEnabled = edicion
        Me.deFECHA_CREA.ClientEnabled = edicion
        Me.txtUSUARIO_ACT.ClientEnabled = edicion
        Me.deFECHA_ACT.ClientEnabled = edicion
        Me.txtORDEN_EJEC.ClientEnabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.cbxLABFAB_ETAPA.Value = Nothing
        Me.cbxLABFAB_MUESTRA.Value = Nothing
        Me.txtNOMBRE_ANALISIS.Text = ""
        Me.txtFORMULA.Text = ""
        Me.txtOBSERVACIONES.Text = ""
        Me.txtCANT_ANALISIS.Value = Nothing
        Me.txtUSUARIO_CREA.Text = ""
        Me.deFECHA_CREA.Value = Nothing
        Me.txtUSUARIO_ACT.Text = ""
        Me.deFECHA_ACT.Value = Nothing
        Me.txtORDEN_EJEC.Value = Nothing
        Me.ucListaLABFAB_VAR1.Visible = False
        Me.LISTA_LABFAB_VAR = New listaLABFAB_VAR
        Me.CargarVariables()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla LABFAB_ANALISIS
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim lEntidadActual As LABFAB_ANALISIS
        Dim bVariable As New cLABFAB_VAR
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New LABFAB_ANALISIS
        If Me._nuevo Then
            mEntidad.ID_ANALISIS = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = mComponente.ObtenerLABFAB_ANALISIS(CInt(Me.txtID_ANALISIS.Text))
            lEntidadActual = mComponente.ObtenerLABFAB_ANALISIS(CInt(Me.txtID_ANALISIS.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If

        mEntidad.ID_MUESTRA = Me.cbxLABFAB_MUESTRA.Value
        mEntidad.NOMBRE_ANALISIS = Me.txtNOMBRE_ANALISIS.Text.Trim.ToUpper
        mEntidad.FORMULA = If(Me.txtFORMULA.Text.Trim.ToUpper = Nothing, " ", Me.txtFORMULA.Text.Trim.ToUpper)
        mEntidad.OBSERVACIONES = If(Me.txtOBSERVACIONES.Text = Nothing, " ", Me.txtOBSERVACIONES.Text.Trim.ToUpper)
        mEntidad.CANT_ANALISIS = Me.txtCANT_ANALISIS.Value
        mEntidad.ORDEN_EJEC = Me.txtORDEN_EJEC.Value
        If mComponente.ActualizarLABFAB_ANALISIS(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If

        Dim lVariable As LABFAB_VAR
        If Me.LISTA_LABFAB_VAR IsNot Nothing AndAlso Me.LISTA_LABFAB_VAR.Count > 0 AndAlso mEntidad.FORMULA <> "" Then
            If lEntidadActual IsNot Nothing AndAlso lEntidadActual.FORMULA <> mEntidad.FORMULA Then
                Return ""
            End If
            For Each lEntidad As LABFAB_VAR In Me.LISTA_LABFAB_VAR
                If Me._nuevo Then
                    lVariable = New LABFAB_VAR
                    lVariable.ID_VAR = 0
                    lVariable.ID_ANALISIS = mEntidad.ID_ANALISIS
                    lVariable.ID_TIPOVAR = lEntidad.ID_TIPOVAR
                    lVariable.NOMBRE_VAR = lEntidad.NOMBRE_VAR.Trim.ToUpper
                    lVariable.DESCRIP_VAR = lEntidad.DESCRIP_VAR.Trim.ToUpper
                    lVariable.ID_ANALISIS_REF = lEntidad.ID_ANALISIS_REF
                    lVariable.TABLA_REF = If(lEntidad.TABLA_REF = "", Nothing, lEntidad.TABLA_REF)
                    lVariable.COLUM1_REF = If(lEntidad.COLUM1_REF = "", Nothing, lEntidad.COLUM1_REF)
                    lVariable.COLUM2_REF = If(lEntidad.COLUM2_REF = "", Nothing, lEntidad.COLUM2_REF)
                    lVariable.COLUM_VALOR_REF = If(lEntidad.COLUM_VALOR_REF = "", Nothing, lEntidad.COLUM_VALOR_REF)
                    lVariable.USUARIO_CREA = Me.ObtenerUsuario
                    lVariable.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    lVariable.USUARIO_ACT = Me.ObtenerUsuario
                    lVariable.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    bVariable.ActualizarLABFAB_VAR(lVariable)
                Else
                    lVariable = (New cLABFAB_VAR).ObtenerLABFAB_VAR(lEntidad.ID_VAR)
                    lVariable.ID_TIPOVAR = lEntidad.ID_TIPOVAR
                    lVariable.NOMBRE_VAR = lEntidad.NOMBRE_VAR.Trim.ToUpper
                    lVariable.DESCRIP_VAR = lEntidad.DESCRIP_VAR.Trim.ToUpper
                    lVariable.ID_ANALISIS_REF = If(lEntidad.ID_ANALISIS_REF = 0, -1, lEntidad.ID_ANALISIS_REF)
                    lVariable.TABLA_REF = If(lEntidad.TABLA_REF = "", Nothing, lEntidad.TABLA_REF)
                    lVariable.COLUM1_REF = If(lEntidad.COLUM1_REF = "", Nothing, lEntidad.COLUM1_REF)
                    lVariable.COLUM2_REF = If(lEntidad.COLUM2_REF = "", Nothing, lEntidad.COLUM2_REF)
                    lVariable.COLUM_VALOR_REF = If(lEntidad.COLUM_VALOR_REF = "", Nothing, lEntidad.COLUM_VALOR_REF)
                    lVariable.USUARIO_ACT = Me.ObtenerUsuario
                    lVariable.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    bVariable.ActualizarLABFAB_VAR(lVariable)
                End If
            Next
        End If

        Me.txtID_ANALISIS.Text = mEntidad.ID_ANALISIS.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub cbxLABFAB_ETAPA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxLABFAB_ETAPA.ValueChanged
        Me.CargarMuestras()
    End Sub
End Class
