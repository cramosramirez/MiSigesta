Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleREMESA_ENCA_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla REMESA_ENCA_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/01/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleREMESA_ENCA_TRANS
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_REMESA_ENCA As Int32
    Public Property ID_REMESA_ENCA() As Int32
        Get
            If Me.ViewState("ID_REMESA_ENCA") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_REMESA_ENCA"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("ID_REMESA_ENCA") = Value
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
   

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cREMESA_ENCA_TRANS
    Private mEntidad As REMESA_ENCA_TRANS
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
        If Not Me.ViewState("ID_REMESA_ENCA") Is Nothing Then Me._ID_REMESA_ENCA = Me.ViewState("ID_REMESA_ENCA")
    End Sub

    Public Sub LimpiarSesion()
        If lblREFERENCIA.Text <> "" Then
            If Session(lblREFERENCIA.Text) IsNot Nothing Then
                Session.Remove(lblREFERENCIA.Text)
            End If
        End If
    End Sub

    Public Property LISTA_REMESA_DETA_TRANS As listaREMESA_DETA_TRANS
        Set(value As listaREMESA_DETA_TRANS)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaREMESA_DETA_TRANS) Else Return New listaREMESA_DETA_TRANS
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla REMESA_ENCA_TRANS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New REMESA_ENCA_TRANS
        mEntidad.ID_REMESA_ENCA = ID_REMESA_ENCA

        If mComponente.ObtenerREMESA_ENCA_TRANS(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_REMESA_ENCA.Text = mEntidad.ID_REMESA_ENCA.ToString()
        Me.speCODTRANSPORT.Value = mEntidad.CODTRANSPORT
        Me.CargarInfoTransportista(mEntidad.CODTRANSPORT)
        Me.cbxBANCO.Value = mEntidad.CODIBANCO
        Me.txtNO_REMESA.Text = mEntidad.NO_REMESA
        Me.dteFECHA_REMESA.Date = mEntidad.FECHA_REMESA
        Me.txtOBSERVACION.Text = mEntidad.OBSERVACION
        Me.LISTA_REMESA_DETA_TRANS = (New cREMESA_DETA_TRANS).ObtenerListaPorREMESA_ENCA_TRANS(Me.ID_REMESA_ENCA)
        Me.CargarDetalleDocumentoEnca()
        Me.ucListaREMESA_DETA_TRANS1.PermitirEditarInline = False
        Me.ucListaREMESA_DETA_TRANS1.PermitirEditarInline2 = False
        Me.ucListaREMESA_DETA_TRANS1.PermitirEliminar = False
        Me.ucListaREMESA_DETA_TRANS1.Visible = True
    End Sub

    Private Sub CargarInfoTransportista(ByVal sCODTRANSPORT As Int32)
        Dim lEntidad As TRANSPORTISTA
        lEntidad = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(sCODTRANSPORT)
        If lEntidad IsNot Nothing Then
            Me.txtNOMBRE_TRANSPORTISTA.Text = lEntidad.NOMBRES + " " + lEntidad.APELLIDOS
        Else
            Me.txtNOMBRE_TRANSPORTISTA.Text = ""
        End If
    End Sub

    Public Sub CargarDetalleDocumentoEnca()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaREMESA_DETA_TRANS1.CargarDatosCache(Me.lblREFERENCIA.Text)
            Me.SetearSubTotalIvaTotal()
        End If
    End Sub

    Public Sub SetearSubTotalIvaTotal()
        Dim dAbonoCapital As Decimal = 0
        Dim dAbonoInteres As Decimal = 0
        Dim dAbonoInteresIva As Decimal = 0
        Dim dTotal As Decimal = 0
        Dim listaRemesaDeta As listaREMESA_DETA_TRANS = Me.LISTA_REMESA_DETA_TRANS


        If listaRemesaDeta IsNot Nothing AndAlso listaRemesaDeta.Count > 0 Then
            For Each lDeta As REMESA_DETA_TRANS In listaRemesaDeta
                dAbonoCapital += lDeta.ABONO_CAPITAL
                dAbonoInteres += lDeta.ABONO_INTERES
                dAbonoInteresIva += lDeta.ABONO_INTERES_IVA
            Next
            dTotal = dAbonoCapital + dAbonoInteres + dAbonoInteresIva
        End If
        Me.speABONO_CAPITAL.Value = dAbonoCapital
        Me.speABONO_INTERES.Value = dAbonoInteres
        Me.speABONO_INTERES_IVA.Value = dAbonoInteresIva
        Me.speTOTAL.Value = dTotal
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtID_REMESA_ENCA.ClientEnabled = False
        Me.speCODTRANSPORT.ClientEnabled = Me._nuevo
        Me.txtNOMBRE_TRANSPORTISTA.ClientEnabled = False
        Me.cbxBANCO.ClientEnabled = Me._nuevo
        Me.txtNO_REMESA.ClientEnabled = Me._nuevo
        Me.dteFECHA_REMESA.ClientEnabled = Me._nuevo
        Me.txtOBSERVACION.ClientEnabled = Me._nuevo
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
         Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Me.speCODTRANSPORT.Value = Nothing
        Me.txtNOMBRE_TRANSPORTISTA.Text = ""
        Me.cbxBANCO.Value = Nothing
        Me.txtNO_REMESA.Text = ""
        Me.dteFECHA_REMESA.Value = Nothing
        Me.txtOBSERVACION.Text = ""

        Me.LISTA_REMESA_DETA_TRANS = New listaREMESA_DETA_TRANS
        Me.CargarDetalleDocumentoEnca()
        Me.SetearSubTotalIvaTotal()
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla REMESA_ENCA_TRANS
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/01/2018	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim listaDetalle As listaREMESA_DETA_TRANS
        Dim bDocumentoDeta As New cREMESA_DETA_TRANS

        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New REMESA_ENCA_TRANS
        If Me._nuevo Then
            mEntidad.ID_REMESA_ENCA = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFecha
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFecha

            If Me.cbxBANCO.Value Is Nothing OrElse Me.cbxBANCO.Value <= 0 Then
                Return "* Seleccione el Banco"
            End If
            If Me.speCODTRANSPORT.Value Is Nothing OrElse Me.speCODTRANSPORT.Value <= 0 Then
                Return "* Ingrese el Codigo de Transportista"
            End If
            If Me.txtNO_REMESA.Text = "" Then
                Return "* Ingrese el No. de Remesa"
            End If
            If Me.dteFECHA_REMESA.Value Is Nothing Then
                Return "* Ingrese la Fecha de la Remesa"
            End If

            listaDetalle = Me.LISTA_REMESA_DETA_TRANS
            If listaDetalle Is Nothing OrElse listaDetalle.Count = 0 Then
                Return "* El monto de la remesa no puede ser cero"
            End If
            Dim dTotal As Decimal = 0
            For j As Int32 = 0 To listaDetalle.Count - 1
                If listaDetalle(j).TOTAL > 0 Then
                    Dim lCredito As CREDITO_ENCA_TRANS = (New cCREDITO_ENCA_TRANS).ObtenerCREDITO_ENCA_TRANS(listaDetalle(j).ID_CREDITO_ENCA)
                    If lCredito IsNot Nothing AndAlso lCredito.SALDO < listaDetalle(j).ABONO_CAPITAL Then
                        Return "* El abono al saldo es mayor que el saldo mismo"
                    End If
                    dTotal += listaDetalle(j).TOTAL
                End If
            Next
            If dTotal = 0 Then
                Return "* El monto de la remesa no puede ser cero"
            End If
            mEntidad.CODTRANSPORT = Me.speCODTRANSPORT.Value
            mEntidad.CODIBANCO = Me.cbxBANCO.Value
            mEntidad.NO_REMESA = Me.txtNO_REMESA.Text
            mEntidad.FECHA_REMESA = dteFECHA_REMESA.Date
            mEntidad.OBSERVACION = Me.txtOBSERVACION.Text.ToUpper
            mEntidad.UID_REMESA_ENCA = Guid.NewGuid

            If mComponente.ActualizarREMESA_ENCA_TRANS(mEntidad) < 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If

            For Each lEntidad As REMESA_DETA_TRANS In listaDetalle
                If lEntidad.TOTAL > 0 Then
                    lEntidad.ID_REMESA_DETA = If(Me._nuevo, 0, lEntidad.ID_REMESA_DETA)
                    lEntidad.UID_REMESA_DETA = Guid.NewGuid
                    lEntidad.ID_REMESA_ENCA = mEntidad.ID_REMESA_ENCA
                    bDocumentoDeta.ActualizarREMESA_DETA_TRANS(lEntidad)
                End If
            Next
        Else
            mEntidad = mComponente.ObtenerREMESA_ENCA_TRANS(CInt(Me.txtID_REMESA_ENCA.Text))
        End If

        Me.txtID_REMESA_ENCA.Text = mEntidad.ID_REMESA_ENCA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub speCODTRANSPORT_ValueChanged(sender As Object, e As EventArgs) Handles speCODTRANSPORT.ValueChanged
        Me.CargarInfoTransportista(speCODTRANSPORT.Value)
        Me.IniciarDetalleCCF_DETA()
    End Sub

    Private Sub IniciarDetalleCCF_DETA()
        Me.LISTA_REMESA_DETA_TRANS = New listaREMESA_DETA_TRANS

        If Me.speCODTRANSPORT.Value IsNot Nothing AndAlso Me.speCODTRANSPORT.Value > 0 Then
            Dim lista As listaCREDITO_ENCA_TRANS = (New cCREDITO_ENCA_TRANS).ObtenerListaPorTRANSPORTISTA(Me.speCODTRANSPORT.Value)
            If lista IsNot Nothing AndAlso lista.Count > 0 Then
                For Each lEntidad As CREDITO_ENCA_TRANS In lista
                    If lEntidad.SALDO > 0 Then
                        Dim lDeta As New REMESA_DETA_TRANS

                        lDeta.ID_REMESA_DETA = Me.ObtenerIdProd(Me.LISTA_REMESA_DETA_TRANS)
                        lDeta.ID_REMESA_ENCA = 0
                        lDeta.ID_CREDITO_ENCA = lEntidad.ID_CREDITO_ENCA
                        lDeta.UID_REMESA_DETA = Guid.NewGuid
                        lDeta.ABONO_CAPITAL = 0
                        lDeta.ABONO_INTERES = 0
                        lDeta.ABONO_INTERES_IVA = 0
                        lDeta.TOTAL = 0
                        lDeta.REFERENCIA = Me.lblREFERENCIA.Text

                        Me.LISTA_REMESA_DETA_TRANS.Add(lDeta)
                    End If
                Next
            End If
        End If
        Me.CargarDetalleDocumentoEnca()
        Me.SetearSubTotalIvaTotal()
    End Sub

    Private Function ObtenerIdProd(ByVal lista As listaREMESA_DETA_TRANS) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_REMESA_DETA > Id Then
                Id = lista(i).ID_REMESA_DETA
            End If
        Next
        Return (Id + 1)
    End Function
End Class
