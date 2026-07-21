Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleLABFAB_ANALISISXDIA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla LABFAB_ANALISISXDIA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleLABFAB_ANALISISXDIA
    Inherits ucBase

#Region "Propiedades"

    Private _ID_ANALISISXDIA As Int32
    Public Property ID_ANALISISXDIA() As Int32
        Get
            If Me.ViewState("ID_ANALISISXDIA") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_ANALISISXDIA"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_ANALISISXDIA") = Value
            Me.lblREFERENCIA.Text = Guid.NewGuid.ToString

            Me._ID_ANALISISXDIA = Value
            Me.txtID_ANALISISXDIA.Text = CStr(Value)
            If Me._ID_ANALISISXDIA > 0 Then
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

    Public Property LISTA_LABFAB_VARSXANALISIS As listaLABFAB_VARSXANALISIS
        Set(value As listaLABFAB_VARSXANALISIS)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaLABFAB_VARSXANALISIS) Else Return New listaLABFAB_VARSXANALISIS
        End Get
    End Property

    Public Property NO_ANALISIS() As Int32
        Get
            If Me.txtNO_ANALISIS.Value Is Nothing Then Return -1
            Return CInt(Me.txtNO_ANALISIS.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtNO_ANALISIS.Value = value
        End Set
    End Property

    Public Property VALOR() As Decimal
        Get
            If Me.txtVALOR.Value Is Nothing Then Return -1
            Return Me.txtVALOR.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtVALOR.Value = value
        End Set
    End Property

    Public Sub CargarVariables()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaLABFAB_VARSXANALISIS1.CargarDatosCache(Me.lblREFERENCIA.Text)
        End If
    End Sub


    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cLABFAB_ANALISISXDIA
    Private mEntidad As LABFAB_ANALISISXDIA
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
        If Not Me.ViewState("ID_ANALISISXDIA") Is Nothing Then Me._ID_ANALISISXDIA = Me.ViewState("ID_ANALISISXDIA")
        Me.CargarVariables()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla LABFAB_ANALISISXDIA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Dim listaVars As listaLABFAB_VARSXANALISIS
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New LABFAB_ANALISISXDIA
        mEntidad.ID_ANALISISXDIA = ID_ANALISISXDIA

        If mComponente.ObtenerLABFAB_ANALISISXDIA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If

        listaVars = (New cLABFAB_VARSXANALISIS).ObtenerListaPorLABFAB_ANALISISXDIA(mEntidad.ID_ANALISISXDIA)
        For i = 0 To listaVars.Count - 1
            listaVars(i).REFERENCIA = Me.lblREFERENCIA.Text
        Next
        Me.LISTA_LABFAB_VARSXANALISIS = listaVars
        Me.CargarVariables()
        Me.txtID_ANALISISXDIA.Text = mEntidad.ID_ANALISISXDIA.ToString()
        Me.cbxZAFRA.Value = mEntidad.ID_ZAFRA
        Me.speDIAZAFRA.Value = mEntidad.DIAZAFRA

        Dim lEtapa As LABFAB_ETAPA = (New cLABFAB_ETAPA).ObtenerETAPA_PorANALISISXDIA(mEntidad.ID_ANALISISXDIA)
        Dim lMuestra As LABFAB_MUESTRA
        Dim lAnalisis As LABFAB_ANALISIS
        If lEtapa IsNot Nothing Then
            lAnalisis = (New cLABFAB_ANALISIS).ObtenerLABFAB_ANALISIS(mEntidad.ID_ANALISIS)
            Me.cbxLABFAB_ETAPA.Value = lEtapa.ID_ETAPA
            Me.CargarMuestras()
            lMuestra = (New cLABFAB_MUESTRA).ObtenerMUESTRA_PorANALISIS(mEntidad.ID_ANALISIS)
            Me.cbxLABFAB_MUESTRA.Value = lMuestra.ID_MUESTRA
            Me.CargarAnalisis()
            Me.cbxLABFAB_ANALISIS.Value = mEntidad.ID_ANALISIS
            Me.txtNO_ANALISIS.Value = mEntidad.NO_ANALISIS + "/" + lAnalisis.CANT_ANALISIS.ToString
            Me.txtVALOR.Value = IIf(mEntidad.VALOR = -1, Nothing, mEntidad.VALOR)
        End If


        'Me.ddlLABFAB_DIAZAFRAID_DIAZAFRA.Recuperar()
        'Me.ddlLABFAB_DIAZAFRAID_DIAZAFRA.SelectedValue = mEntidad.ID_DIAZAFRA
        'Me.txtID_ZAFRA.Value = mEntidad.ID_ZAFRA
        'Me.txtDIAZAFRA.Value = mEntidad.DIAZAFRA
        'Me.ddlLABFAB_ANALISISID_ANALISIS.Recuperar()
        'Me.ddlLABFAB_ANALISISID_ANALISIS.SelectedValue = mEntidad.ID_ANALISIS
        'Me.txtNO_ANALISIS.Value = mEntidad.NO_ANALISIS
        'Me.txtVALOR.Value = mEntidad.VALOR
        'Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        'Me.deFECHA_CREA.Value = mEntidad.FECHA_CREA
        'Me.txtUSUARIO_ACT.Text = mEntidad.USUARIO_ACT
        'Me.deFECHA_ACT.Value = mEntidad.FECHA_ACT
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxZAFRA.ClientEnabled = False
        Me.speDIAZAFRA.ClientEnabled = False
        Me.txtNO_ANALISIS.ClientEnabled = False
        Me.txtVALOR.ClientEnabled = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Dim lZafraActiva As ZAFRA
        Dim lDiaZafra As DIA_ZAFRA

        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        lZafraActiva = (New cZAFRA).ObtenerZafraActiva
        If lZafraActiva IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafraActiva.ID_ZAFRA
            lDiaZafra = (New cDIA_ZAFRA).ObtenerDiaZafraActivo(lZafraActiva.ID_ZAFRA)
            If lDiaZafra IsNot Nothing Then
                Me.speDIAZAFRA.Value = lDiaZafra.DIAZAFRA
            End If
        End If
        Me.cbxLABFAB_ETAPA.Value = Nothing
        Me.CargarMuestras()
        Me.CargarAnalisis()
        Me.txtNO_ANALISIS.Value = Nothing
        Me.txtVALOR.Value = Nothing

        Me.LISTA_LABFAB_VARSXANALISIS = New listaLABFAB_VARSXANALISIS
        Me.CargarVariables()
        Me.ucListaLABFAB_VARSXANALISIS1.Visible = False

        'Me.ddlLABFAB_DIAZAFRAID_DIAZAFRA.Recuperar()
        'Me.ddlLABFAB_ANALISISID_ANALISIS.Recuperar()
        'Me.txtID_ZAFRA.Value = Nothing
        'Me.txtDIAZAFRA.Value = Nothing
        'Me.txtNO_ANALISIS.Value = Nothing
        'Me.txtVALOR.Value = Nothing
        'Me.txtUSUARIO_CREA.Text = ""
        'Me.deFECHA_CREA.Value = Nothing
        'Me.txtUSUARIO_ACT.Text = ""
        'Me.deFECHA_ACT.Value = Nothing
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

    Private Sub CargarAnalisis()
        Dim lista As listaLABFAB_ANALISIS
        If Me.cbxLABFAB_MUESTRA.Value IsNot Nothing Then
            lista = (New cLABFAB_ANALISIS).ObtenerListaPorLABFAB_MUESTRA(CInt(Me.cbxLABFAB_MUESTRA.Value))
        Else
            lista = New listaLABFAB_ANALISIS
        End If
        Me.cbxLABFAB_ANALISIS.Text = ""
        Me.cbxLABFAB_ANALISIS.DataSource = lista
        Me.cbxLABFAB_ANALISIS.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla LABFAB_ANALISISXDIA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim lRet As Int32 = 0
        Dim sError As New String("")
        Dim alDatos As New ArrayList

        mEntidad = New LABFAB_ANALISISXDIA
        If Me._nuevo Then
            mEntidad.ID_ANALISISXDIA = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = mComponente.ObtenerLABFAB_ANALISISXDIA(CInt(Me.txtID_ANALISISXDIA.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.ID_DIAZAFRA = -1
        mEntidad.ID_ZAFRA = Me.cbxZAFRA.Value
        mEntidad.DIAZAFRA = Me.speDIAZAFRA.Value
        mEntidad.ID_ANALISIS = Me.cbxLABFAB_ANALISIS.Value
        mEntidad.NO_ANALISIS = 0
        mEntidad.VALOR = If(Me.txtVALOR.ClientEnabled, Me.txtVALOR.Value, -1)

        If Me.cbxLABFAB_ANALISIS.Value Is Nothing OrElse Me.cbxLABFAB_ANALISIS.Value = 0 Then
            Return "* Ingrese el valor del analisis"
        End If

        lRet = mComponente.ActualizarLABFAB_ANALISISXDIA(mEntidad)
        If lRet <> 1 Then
            Return "Error al Guardar registro. " + mComponente.sError
        End If

        Dim lVarAnalisisDia As LABFAB_VARSXANALISIS
        Dim bVarAnalisisDia As New cLABFAB_VARSXANALISIS
        If Me.LISTA_LABFAB_VARSXANALISIS IsNot Nothing AndAlso Me.LISTA_LABFAB_VARSXANALISIS.Count > 0 Then
            For Each lEntidad As LABFAB_VARSXANALISIS In Me.LISTA_LABFAB_VARSXANALISIS
                If Me._nuevo Then
                    lVarAnalisisDia = New LABFAB_VARSXANALISIS
                    lVarAnalisisDia.ID_VARXANALISIS = 0
                    lVarAnalisisDia.ID_ANALISISXDIA = mEntidad.ID_ANALISISXDIA
                    lVarAnalisisDia.ID_VAR = lEntidad.ID_VAR
                    lVarAnalisisDia.NOMBRE_VAR = lEntidad.NOMBRE_VAR.Trim.ToUpper
                    Dim lVar As LABFAB_VAR = (New cLABFAB_VAR).ObtenerLABFAB_VAR(lEntidad.ID_VAR)
                    If lVar.ID_TIPOVAR <> TipoLabFabVariable.MedicionDirecta AndAlso _
                        lVar.ID_TIPOVAR <> TipoLabFabVariable.Digitado Then
                        lVarAnalisisDia.VALOR = -1
                    Else
                        lVarAnalisisDia.VALOR = If(lEntidad.VALOR = 0, -1, lEntidad.VALOR)
                    End If
                    lVarAnalisisDia.USUARIO_CREA = Me.ObtenerUsuario
                    lVarAnalisisDia.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    lVarAnalisisDia.USUARIO_ACT = Me.ObtenerUsuario
                    lVarAnalisisDia.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    bVarAnalisisDia.ActualizarLABFAB_VARSXANALISIS(lVarAnalisisDia)
                Else
                    lVarAnalisisDia = (New cLABFAB_VARSXANALISIS).ObtenerLABFAB_VARSXANALISIS(lEntidad.ID_VARXANALISIS)
                    lVarAnalisisDia.ID_ANALISISXDIA = mEntidad.ID_ANALISISXDIA
                    lVarAnalisisDia.ID_VAR = lEntidad.ID_VAR
                    lVarAnalisisDia.NOMBRE_VAR = lEntidad.NOMBRE_VAR.Trim.ToUpper
                    lVarAnalisisDia.VALOR = lEntidad.VALOR
                    lVarAnalisisDia.USUARIO_ACT = Me.ObtenerUsuario
                    lVarAnalisisDia.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    bVarAnalisisDia.ActualizarLABFAB_VARSXANALISIS(lVarAnalisisDia)
                End If
            Next
        End If

        If mEntidad.ID_ANALISISXDIA > 0 Then mComponente.GenerarValoresAnalisisEnSerie(mEntidad.ID_ANALISISXDIA)

        Me.txtID_ANALISISXDIA.Text = mEntidad.ID_ANALISISXDIA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.AsignarMensaje("El analisis de " + cbxLABFAB_ANALISIS.Text + " ha sido registrado", False, True, True)
        Return ""
    End Function

    Protected Sub cbxLABFAB_ETAPA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxLABFAB_ETAPA.ValueChanged
        Me.CargarMuestras()
        Me.CargarAnalisis()
    End Sub

    Protected Sub cbxLABFAB_MUESTRA_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxLABFAB_MUESTRA.ValueChanged
        Me.CargarAnalisis()
    End Sub

    Protected Sub cbxLABFAB_ANALISIS_ValueChanged(sender As Object, e As System.EventArgs) Handles cbxLABFAB_ANALISIS.ValueChanged
        Dim lEntidad As LABFAB_ANALISIS
        Dim NoAnalisisEnDia As Int32 = 0

        lEntidad = (New cLABFAB_ANALISIS).ObtenerLABFAB_ANALISIS(Me.cbxLABFAB_ANALISIS.Value)
        If lEntidad IsNot Nothing Then
            NoAnalisisEnDia = mComponente.ObtenerNoAnalisisDiaZafra(Me.cbxLABFAB_ANALISIS.Value, Me.cbxZAFRA.Value, Me.speDIAZAFRA.Value)
            Me.txtNO_ANALISIS.Text = NoAnalisisEnDia.ToString + "/" + lEntidad.CANT_ANALISIS.ToString
            Me.InicializarVariables(cbxLABFAB_ANALISIS.Value)
        End If
    End Sub

    Private Sub InicializarVariables(ByVal ID_ANALISIS As Int32)
        Dim listaVars As listaLABFAB_VAR = (New cLABFAB_VAR).ObtenerListaPorLABFAB_ANALISIS(ID_ANALISIS)
        Dim listaVarsDia As New listaLABFAB_VARSXANALISIS
        Dim j As Int32 = 1

        If listaVars IsNot Nothing AndAlso listaVars.Count > 0 Then
            For i As Int32 = 0 To listaVars.Count - 1
                Dim lEntidad As New LABFAB_VARSXANALISIS
                lEntidad.ID_VARXANALISIS = j
                lEntidad.ID_ANALISISXDIA = 1
                lEntidad.ID_VAR = listaVars(i).ID_VAR
                lEntidad.NOMBRE_VAR = listaVars(i).NOMBRE_VAR
                lEntidad.VALOR = 0
                lEntidad.REFERENCIA = Me.lblREFERENCIA.Text
                listaVarsDia.Add(lEntidad)

                j += 1
            Next
        End If
        Me.LISTA_LABFAB_VARSXANALISIS = listaVarsDia
        Me.CargarVariables()

        Me.txtVALOR.Value = Nothing
        If listaVarsDia Is Nothing OrElse listaVarsDia.Count = 0 Then
            Me.txtVALOR.ClientEnabled = True
            Me.ucListaLABFAB_VARSXANALISIS1.Visible = False
        Else
            Me.txtVALOR.ClientEnabled = False
            Me.ucListaLABFAB_VARSXANALISIS1.Visible = True
        End If
    End Sub

    Private Sub CargarVariables(ByVal ID_ANALISIS As Int32)
        Dim listaVars As listaLABFAB_VAR = (New cLABFAB_VAR).ObtenerListaPorLABFAB_ANALISIS(ID_ANALISIS)
        Dim listaVarsDia As New listaLABFAB_VARSXANALISIS
        Dim j As Int32 = 1

        If listaVars IsNot Nothing AndAlso listaVars.Count > 0 Then
            For i As Int32 = 0 To listaVars.Count - 1
                Dim lEntidad As New LABFAB_VARSXANALISIS
                lEntidad.ID_VARXANALISIS = j
                lEntidad.ID_ANALISISXDIA = 1
                lEntidad.ID_VAR = listaVars(i).ID_VAR
                lEntidad.NOMBRE_VAR = listaVars(i).NOMBRE_VAR
                lEntidad.VALOR = 0
                lEntidad.REFERENCIA = Me.lblREFERENCIA.Text
                listaVarsDia.Add(lEntidad)

                j += 1
            Next
        End If
        Me.LISTA_LABFAB_VARSXANALISIS = listaVarsDia
        Me.CargarVariables()

        Me.txtVALOR.Value = Nothing
        If listaVarsDia Is Nothing OrElse listaVarsDia.Count = 0 Then
            Me.txtVALOR.ClientEnabled = True
            Me.ucListaLABFAB_VARSXANALISIS1.Visible = False
        Else
            Me.txtVALOR.ClientEnabled = False
            Me.ucListaLABFAB_VARSXANALISIS1.Visible = True
        End If
    End Sub
End Class
