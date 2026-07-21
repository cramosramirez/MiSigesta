Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleCONTRATO_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CONTRATO_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	22/09/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCONTRATO_TRANS
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CONTRA_TRANS As Int32
    Public Property ID_CONTRA_TRANS() As Int32
        Get
            If Me.ViewState("ID_CONTRA_TRANS") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_CONTRA_TRANS"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_CONTRA_TRANS") = Value
            Me.lblREFERENCIA.Text = Guid.NewGuid.ToString
            If Value > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property CODTRANSPORT As Int32
        Get
            If Me.ViewState("CODTRANSPORT") IsNot Nothing Then
                Return CInt(Me.ViewState("CODTRANSPORT"))
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.ViewState("CODTRANSPORT") = value
        End Set
    End Property


    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cCONTRATO_TRANS
    Private mEntidad As CONTRATO_TRANS
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
        If Not Me.ViewState("ID_CONTRA_TRANS") Is Nothing Then Me._ID_CONTRA_TRANS = Me.ViewState("ID_CONTRA_TRANS")

    End Sub

    Public Sub LimpiarSesion()
        If lblREFERENCIA.Text <> "" Then
            If Session(lblREFERENCIA.Text) IsNot Nothing Then
                Session.Remove(lblREFERENCIA.Text)
            End If
        End If
    End Sub

    Public Sub CargarDetalleDocumentoEnca()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaCONTRATO_TRANS_VEHI1.CargarDatosCache(Me.lblREFERENCIA.Text)
        End If
    End Sub

    Public Property LISTA_CONTRATO_TRANS_VEHI As listaCONTRATO_TRANS_VEHI
        Set(value As listaCONTRATO_TRANS_VEHI)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaCONTRATO_TRANS_VEHI) Else Return New listaCONTRATO_TRANS_VEHI
        End Get
    End Property

    Public Sub CargarInfoTransportista(ByVal CODTRANSPORT As Int32)
        Dim lEntidad As TRANSPORTISTA
        lEntidad = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(CODTRANSPORT)
        If lEntidad IsNot Nothing Then
            Me.CODTRANSPORT = lEntidad.CODTRANSPORT
            Me.txtNOMBRE_TRANS.Text = lEntidad.NOMBRES + " " + lEntidad.APELLIDOS
            Me.txtDUI.Text = lEntidad.DUI
            Me.txtNIT.Text = lEntidad.NIT
            Me.CargarTodosVehiculos(lEntidad.CODTRANSPORT, Me.LISTA_CONTRATO_TRANS_VEHI)
        Else
            Me.CODTRANSPORT = -1
            Me.speCODTRANSPORT.Value = Nothing
            Me.txtNOMBRE_TRANS.Text = ""
            Me.txtDUI.Text = ""
            Me.txtNIT.Text = ""
            Me.LISTA_CONTRATO_TRANS_VEHI = New listaCONTRATO_TRANS_VEHI
        End If
        Me.CargarDetalleDocumentoEnca()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla CONTRATO_TRANS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim lTransportista As TRANSPORTISTA
        Dim sError As New String("")
        mEntidad = New CONTRATO_TRANS
        mEntidad.ID_CONTRA_TRANS = ID_CONTRA_TRANS
 
        If mComponente.ObtenerCONTRATO_TRANS(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtNO_CONTRATO.Value = mEntidad.NO_CONTRATO
        Me.cbxZAFRA.Value = mEntidad.ID_ZAFRA
        Me.dteFECINI.Value = mEntidad.FECINI
        Me.dteFECFIN.Value = mEntidad.FECFIN
        Me.txtLUGAR_CORTE.Text = mEntidad.LUGAR_CORTE
        Me.dteFECHA_CONTRA.Date = mEntidad.FECHA_CONTRA
        Me.speCODTRANSPORT.Value = mEntidad.CODTRANSPORT
        Me.CODTRANSPORT = mEntidad.CODTRANSPORT
        Me.txtNOMBRE_TRANS.Text = mEntidad.NOMBRE_TRANS
        Me.txtNIT.Text = mEntidad.NIT_TRANS
        lTransportista = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(mEntidad.CODTRANSPORT)
        If lTransportista IsNot Nothing Then
            Me.txtDUI.Text = lTransportista.DUI
        End If

        Me.LISTA_CONTRATO_TRANS_VEHI = (New cCONTRATO_TRANS_VEHI).ObtenerListaPorCONTRATO_TRANS(Me.ID_CONTRA_TRANS)
        If Me.LISTA_CONTRATO_TRANS_VEHI Is Nothing Then Me.LISTA_CONTRATO_TRANS_VEHI = New listaCONTRATO_TRANS_VEHI
        For Each lEntidad As CONTRATO_TRANS_VEHI In Me.LISTA_CONTRATO_TRANS_VEHI
            lEntidad.ES_CONTRATADO = True
        Next
        Me.CargarDetalleDocumentoEnca()
    End Sub

    Public Sub CargarTodosVehiculos(ByVal CODTRANSPORT As Int32, ByRef listaActual As listaCONTRATO_TRANS_VEHI)
        Dim listaTransporte As listaTRANSPORTE = (New cTRANSPORTE).ObtenerListaPorTRANSPORTISTA(CODTRANSPORT)
        Dim listaIdContra As New List(Of Int32)

        If listaActual Is Nothing Then listaActual = New listaCONTRATO_TRANS_VEHI
        If listaActual IsNot Nothing AndAlso listaActual.Count > 0 Then
            For i As Int32 = 0 To listaActual.Count - 1
                listaIdContra.Add(listaActual(i).ID_TRANSPORTE)
            Next
        End If

        If listaTransporte IsNot Nothing AndAlso listaTransporte.Count > 0 Then
            For i As Int32 = 0 To listaTransporte.Count - 1
                If Not listaIdContra.Contains(listaTransporte(i).ID_TRANSPORTE) Then
                    Dim lEntidad As New CONTRATO_TRANS_VEHI
                    lEntidad.ID_CONTRA_TRANS_VEHI = ObtenerIdTrans(Me.LISTA_CONTRATO_TRANS_VEHI)
                    lEntidad.ID_CONTRA_TRANS = Me.ID_CONTRA_TRANS
                    lEntidad.ID_TRANSPORTE = listaTransporte(i).ID_TRANSPORTE
                    lEntidad.ID_TIPOTRANS = listaTransporte(i).ID_TIPOTRANS
                    lEntidad.REMOLQUE = listaTransporte(i).REMOLQUE
                    lEntidad.PLACA = listaTransporte(i).PLACA
                    lEntidad.CAPACIDAD = If(listaTransporte(i).CAPACIDAD < 0, 0, listaTransporte(i).CAPACIDAD)
                    lEntidad.MARCA = listaTransporte(i).MARCA
                    lEntidad.ANIO = listaTransporte(i).ANIO
                    lEntidad.ES_CONTRATADO = False
                    lEntidad.USUARIO_CREA = Me.ObtenerUsuario
                    lEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    lEntidad.USUARIO_ACT = Me.ObtenerUsuario
                    lEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    lEntidad.REFERENCIA = Me.lblREFERENCIA.Text

                    listaActual.Add(lEntidad)
                End If
            Next
        End If

        Me.CargarDetalleDocumentoEnca()
    End Sub

    Private Function ObtenerIdTrans(ByVal lista As listaCONTRATO_TRANS_VEHI) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_CONTRA_TRANS_VEHI > Id Then
                Id = lista(i).ID_CONTRA_TRANS_VEHI
            End If
        Next
        Return (Id + 1)
    End Function
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxZAFRA.ClientEnabled = False
        Me.txtNO_CONTRATO.ClientEnabled = False
        Me.speCODTRANSPORT.ClientEnabled = _nuevo
        Me.txtNOMBRE_TRANS.ClientEnabled = False
        Me.txtDUI.ClientEnabled = _nuevo
        Me.txtNIT.ClientEnabled = _nuevo
        Me.dteFECHA_CONTRA.ClientEnabled = _nuevo
        Me.txtLUGAR_CORTE.ClientEnabled = _nuevo
        Me.dteFECINI.ClientEnabled = _nuevo
        Me.dteFECFIN.ClientEnabled = _nuevo
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        If lZafraActiva IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafraActiva.ID_ZAFRA
            Me.dteFECINI.Date = New DateTime(2018, 11, 19)
            Me.dteFECFIN.Date = New DateTime(2019, 3, 20)
        Else
            Me.dteFECINI.Value = Nothing
            Me.dteFECFIN.Value = Nothing
        End If
        Me.txtNO_CONTRATO.Text = ""
        Me.speCODTRANSPORT.Value = Nothing
        Me.txtNOMBRE_TRANS.Text = ""
        Me.txtDUI.Text = ""
        Me.txtNIT.Text = ""
        Me.dteFECHA_CONTRA.Value = cFechaHora.ObtenerFecha
        Me.txtLUGAR_CORTE.Text = "ZONA DE INFLUENCIA DE INJIBOA, S.A."
        Me.LISTA_CONTRATO_TRANS_VEHI = New listaCONTRATO_TRANS_VEHI
        Me.CargarDetalleDocumentoEnca()
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla CONTRATO_TRANS
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/09/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        Dim listaDeta As listaCONTRATO_TRANS_VEHI
        Dim bContraTransDeta As New cCONTRATO_TRANS_VEHI
        Dim bTranspo As New cTRANSPORTISTA
        Dim lTranspo As TRANSPORTISTA

        mEntidad = New CONTRATO_TRANS

        If Me.cbxZAFRA.Value Is Nothing Then
            Return "* Seleccione la zafra"
        End If
        If Me.speCODTRANSPORT.Value Is Nothing Then
            Return "* Ingrese el codigo de transportista"
        End If
        lTranspo = bTranspo.ObtenerTRANSPORTISTA(Me.speCODTRANSPORT.Value)
        If lTranspo Is Nothing Then
            Return "* Codigo de transportista invalido"
        Else
            If lTranspo.ID_TIPO_PERSONA = Enumeradores.TipoPersona.Natural AndAlso Me.txtDUI.Text = "" Then
                Return "* Ingrese el DUI del transportista"
            End If
        End If
        If Me.txtNIT.Text = "" Then
            Return "* Ingrese el NIT del transportista"
        End If
        If Me.dteFECHA_CONTRA.Value = Nothing Then
            Return "* Ingrese la fecha del contrato"
        End If
        If Me.dteFECINI.Value = Nothing OrElse Me.dteFECFIN.Value = Nothing Then
            Return "* Ingrese el periodo de contratacion"
        End If
        listaDeta = Me.LISTA_CONTRATO_TRANS_VEHI
        If listaDeta Is Nothing OrElse listaDeta.Count = 0 Then
            Return "* No existen vehiculos contratados"
        Else
            'Verificar si hay contratados
            Dim existeContra As Boolean = False
            For Each lEntidad As CONTRATO_TRANS_VEHI In listaDeta
                If lEntidad.ES_CONTRATADO Then
                    existeContra = True
                    Exit For
                End If
            Next

            If Not existeContra Then
                Return "* No existen vehiculos contratados"
            End If

            For Each lEntidad As CONTRATO_TRANS_VEHI In listaDeta
                If lEntidad.ES_CONTRATADO AndAlso lEntidad.CAPACIDAD <= 0 Then
                    Return "* Ingrese la capacidad para la placa " + lEntidad.PLACA
                End If
                If lEntidad.ES_CONTRATADO AndAlso lEntidad.ID_TIPOTRANS <= 0 Then
                    Return "* Seleccione el tipo de transporte para la placa " + lEntidad.PLACA
                End If
                If lEntidad.ES_CONTRATADO AndAlso lEntidad.MARCA = Nothing Then
                    Return "* Seleccione la marca para la placa " + lEntidad.PLACA
                End If
                If lEntidad.ES_CONTRATADO AndAlso lEntidad.ANIO = Nothing Then
                    Return "* Seleccione el anio para la placa " + lEntidad.PLACA
                End If
            Next
        End If


        If Me._nuevo Then
            mEntidad.ID_CONTRA_TRANS = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora

            'Actualizar información del transportista
            If lTranspo IsNot Nothing Then
                lTranspo.DUI = Me.txtDUI.Text
                lTranspo.NIT = Me.txtNIT.Text
                bTranspo.ActualizarTRANSPORTISTA(lTranspo)
            End If
        Else
            mEntidad = mComponente.ObtenerCONTRATO_TRANS(Me.ID_CONTRA_TRANS)
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.ID_ZAFRA = Me.cbxZAFRA.Value
        mEntidad.FECINI = Me.dteFECINI.Date
        mEntidad.FECFIN = Me.dteFECFIN.Date
        mEntidad.LUGAR_CORTE = Me.txtLUGAR_CORTE.Text.Trim.ToUpper
        mEntidad.FECHA_CONTRA = Me.dteFECHA_CONTRA.Date
        mEntidad.CODTRANSPORT = Me.speCODTRANSPORT.Value
        mEntidad.NOMBRE_TRANS = Me.txtNOMBRE_TRANS.Text
        mEntidad.NIT_TRANS = Me.txtNIT.Text

        If mComponente.ActualizarCONTRATO_TRANS(mEntidad) < 0 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If

        'Eliminar los vehiculos no contratados en caso existan
        If listaDeta IsNot Nothing AndAlso listaDeta.Count > 0 Then
            For Each lEntidad As CONTRATO_TRANS_VEHI In listaDeta
                If Not lEntidad.ES_CONTRATADO Then
                    Dim delLista As listaCONTRATO_TRANS_VEHI = (New cCONTRATO_TRANS_VEHI).ObtenerListaPorCriterios(mEntidad.ID_ZAFRA, mEntidad.ID_CONTRA_TRANS, lEntidad.ID_TRANSPORTE, -1)
                    If delLista IsNot Nothing AndAlso delLista.Count > 0 Then
                        For j As Int32 = 0 To delLista.Count - 1
                            bContraTransDeta.EliminarCONTRATO_TRANS_VEHI(delLista(j).ID_CONTRA_TRANS_VEHI)
                        Next
                    End If
                End If
            Next
        End If

        'Guardar transporte contratado
        If listaDeta IsNot Nothing AndAlso listaDeta.Count > 0 Then
            For Each lEntidad As CONTRATO_TRANS_VEHI In listaDeta
                If lEntidad.ES_CONTRATADO Then
                    Dim saveLista As listaCONTRATO_TRANS_VEHI = (New cCONTRATO_TRANS_VEHI).ObtenerListaPorCriterios(mEntidad.ID_ZAFRA, mEntidad.ID_CONTRA_TRANS, lEntidad.ID_TRANSPORTE, -1)
                    If saveLista IsNot Nothing AndAlso saveLista.Count > 0 Then
                        lEntidad.ID_CONTRA_TRANS_VEHI = saveLista(0).ID_CONTRA_TRANS_VEHI
                        lEntidad.ID_CONTRA_TRANS = mEntidad.ID_CONTRA_TRANS
                        lEntidad.USUARIO_ACT = Me.ObtenerUsuario
                        lEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    Else
                        lEntidad.ID_CONTRA_TRANS_VEHI = 0
                        lEntidad.ID_CONTRA_TRANS = mEntidad.ID_CONTRA_TRANS
                        lEntidad.USUARIO_CREA = Me.ObtenerUsuario
                        lEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
                        lEntidad.USUARIO_ACT = Me.ObtenerUsuario
                        lEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    End If

                    bContraTransDeta.ActualizarCONTRATO_TRANS_VEHI(lEntidad)
                End If
            Next
        End If

        If Me._nuevo Then ScriptManager.RegisterClientScriptBlock(Me, Page.GetType, "script", "MostrarContratoTransporte(" + mEntidad.ID_CONTRA_TRANS.ToString + ")", True)

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub speCODTRANSPORT_ValueChanged(sender As Object, e As EventArgs) Handles speCODTRANSPORT.ValueChanged
        Me.CargarInfoTransportista(speCODTRANSPORT.Value)
    End Sub
End Class
