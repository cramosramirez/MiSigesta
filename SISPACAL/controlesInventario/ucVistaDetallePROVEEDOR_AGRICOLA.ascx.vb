Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetallePROVEEDOR_AGRICOLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PROVEEDOR_AGRICOLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetallePROVEEDOR_AGRICOLA
    Inherits ucBase

#Region "Propiedades"

    Private _ID_PROVEE As Int32
    Public Property ID_PROVEE() As Int32
        Get
            If Me.ViewState("_ID_PROVEE") IsNot Nothing Then
                Return CInt(Me.ViewState("_ID_PROVEE"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("_ID_PROVEE") = Value
            If Value > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property



    Public Property VerTARIFA_VUELO() As Boolean
        Get
            Return Me.trTARIFAS_VUELO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTARIFAS_VUELO.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cPROVEEDOR_AGRICOLA
    Private mEntidad As PROVEEDOR_AGRICOLA
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
        If Not Me.ViewState("ID_PROVEE") Is Nothing Then Me._ID_PROVEE = Me.ViewState("ID_PROVEE")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla PROVEEDOR_AGRICOLA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        Dim lEntidad As PROVEEDOR_AGRICOLA = mComponente.ObtenerPROVEEDOR_AGRICOLA(Me.ID_PROVEE)

        If lEntidad IsNot Nothing Then
            Me.cbxTIPO_PERSONA.Value = lEntidad.ID_TIPO_PERSONA
            Me.txtDUI.Text = lEntidad.DUI
            Me.txtNIT.Text = lEntidad.NIT
            Me.txtNOMBRES.Text = lEntidad.NOMBRE
            Me.txtAPELLIDOS.Text = lEntidad.APELLIDOS
            Me.txtTELEFONO.Text = lEntidad.TELEFONO
            Me.txtDIRECCION.Text = lEntidad.DIRECCION
            Me.txtCORREO.Text = lEntidad.CORREO
            Me.txtNRC.Text = lEntidad.NRC
            Me.txtACTIVIDAD.Text = lEntidad.ACTIVIDAD.Trim.ToUpper
            Me.cbxDEPARTAMENTO.Value = lEntidad.CODI_DEPTO
            Me.CargarMunicipios()
            Me.cbxMUNICIPIO.Value = lEntidad.CODI_MUNI
            Me.chkES_CASA_COMERCIAL.Checked = lEntidad.ES_CASA_COMER
            Me.chkES_PROVEEDOR_VUELO.Checked = lEntidad.ES_PROVEE_VUELO
            If lEntidad.ES_PROVEE_VUELO Then
                CargarTarifasVuelo(lEntidad.ID_PROVEE)
                VerTARIFA_VUELO = True
            Else
                VerTARIFA_VUELO = False
            End If
            Me.txtID_PROVEE.Text = lEntidad.ID_PROVEE
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

    Private Sub CargarTarifasVuelo(ByVal ID_PROVEE As Integer)
        Dim lstTarifas As listaTARIFA_VUELO = (New cTARIFA_VUELO).ObtenerListaPorPROVEEDOR_AGRICOLA(ID_PROVEE)

        Me.speTARIFA_AVION.Value = 0
        Me.speTARIFA_DRON.Value = 0
        Me.speTARIFA_HELICOPTERO.Value = 0
        If lstTarifas IsNot Nothing AndAlso lstTarifas.Count > 0 Then
            For i As Integer = 0 To lstTarifas.Count - 1
                If lstTarifas(i).MEDIO_APLICA.Equals("A") Then
                    Me.speTARIFA_AVION.Value = lstTarifas(i).PRECIO
                ElseIf lstTarifas(i).MEDIO_APLICA.Equals("D") Then
                    Me.speTARIFA_DRON.Value = lstTarifas(i).PRECIO
                ElseIf lstTarifas(i).MEDIO_APLICA.Equals("H") Then
                    Me.speTARIFA_HELICOPTERO.Value = lstTarifas(i).PRECIO
                End If
            Next
        End If
    End Sub

    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtID_PROVEE.ClientEnabled = False
        Me.cbxTIPO_PERSONA.ClientEnabled = Me._nuevo
        If Me.cbxTIPO_PERSONA.Value = Nothing Then
            Me.txtDUI.ClientEnabled = False
            Me.txtNIT.ClientEnabled = False
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
        Me.chkES_CASA_COMERCIAL.ClientEnabled = edicion
        Me.chkES_PROVEEDOR_VUELO.ClientEnabled = edicion
        Me.txtACTIVIDAD.ClientEnabled = edicion
    End Sub

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
        Me.chkES_CASA_COMERCIAL.Checked = False
        Me.chkES_PROVEEDOR_VUELO.Checked = False
        Me.txtID_PROVEE.Text = ""
        Me.txtACTIVIDAD.Text = ""
        Me.trTARIFAS_VUELO.Visible = False
        Me.speTARIFA_AVION.Value = 0
        Me.speTARIFA_DRON.Value = 0
        Me.speTARIFA_HELICOPTERO.Value = 0
    End Sub

    Public Function Actualizar() As String
        Dim sError As New StringBuilder("")
        Dim alDatos As New ArrayList
        Dim mEntidad As New PROVEEDOR_AGRICOLA

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
        If Not chkES_CASA_COMERCIAL.Checked AndAlso Not chkES_PROVEEDOR_VUELO.Checked Then
            sError.AppendLine("* Indique si el proveedor es una casa comercial o proveedor de vuelo")
        End If

        If sError.ToString <> "" Then
            Return sError.ToString
        End If
        If Me._nuevo Then
            mEntidad.ID_PROVEE = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = (New cPROVEEDOR_AGRICOLA).ObtenerPROVEEDOR_AGRICOLA(Me.ID_PROVEE)
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        If Me.cbxTIPO_PERSONA.Value = TipoPersona.Natural Then
            mEntidad.DUI = Me.txtDUI.Text
        ElseIf Me.cbxTIPO_PERSONA.Value = TipoPersona.Juridica Then
            mEntidad.DUI = ""
        End If
        mEntidad.NIT = Me.txtNIT.Text
        mEntidad.NOMBRE = Me.txtNOMBRES.Text.Trim.ToUpper
        mEntidad.APELLIDOS = Me.txtAPELLIDOS.Text.Trim.ToUpper
        mEntidad.NOMBRE_LEGAL = Me.txtNOMBRES.Text.Trim.ToUpper + " " + Me.txtAPELLIDOS.Text.Trim.ToUpper
        mEntidad.TELEFONO = Me.txtTELEFONO.Text
        mEntidad.DIRECCION = Me.txtDIRECCION.Text.Trim.ToUpper
        mEntidad.CODI_DEPTO = Me.cbxDEPARTAMENTO.Value
        mEntidad.CODI_MUNI = Me.cbxMUNICIPIO.Value
        mEntidad.CORREO = Me.txtCORREO.Text.Trim.ToLower
        mEntidad.NRC = Me.txtNRC.Text.Trim
        mEntidad.ID_TIPO_PERSONA = Me.cbxTIPO_PERSONA.Value
        mEntidad.ACTIVIDAD = Me.txtACTIVIDAD.Text.Trim.ToUpper
        mEntidad.ES_CASA_COMER = Me.chkES_CASA_COMERCIAL.Checked
        mEntidad.ES_PROVEE_VUELO = Me.chkES_PROVEEDOR_VUELO.Checked
        mEntidad.ZAFRA = (New cZAFRA).ObtenerZafraActiva.NOMBRE_ZAFRA

        If mComponente.ActualizarPROVEEDOR_AGRICOLA(mEntidad) <= 0 Then
            Return mComponente.sError
        End If

        'Actualizar tarifas
        Dim bTarifas_vuelo As New cTARIFA_VUELO
        Dim lstTarifas_vuelo As listaTARIFA_VUELO
        Dim lstMedios As New List(Of String)
        Dim lEntidadTarifa As New TARIFA_VUELO

        lstTarifas_vuelo = bTarifas_vuelo.ObtenerListaPorPROVEEDOR_AGRICOLA(mEntidad.ID_PROVEE)
        If lstTarifas_vuelo IsNot Nothing AndAlso lstTarifas_vuelo.Count > 0 Then
            For i As Integer = 0 To lstTarifas_vuelo.Count - 1
                bTarifas_vuelo.EliminarTARIFA_VUELO(lstTarifas_vuelo(i).ID_TARIFA)
            Next
        End If

        If Me.chkES_PROVEEDOR_VUELO.Checked Then
            If Convert.ToDecimal(Me.speTARIFA_AVION.Value) > 0 Then
                lEntidadTarifa.ID_TARIFA = 0
                lEntidadTarifa.ID_PROVEE = mEntidad.ID_PROVEE
                lEntidadTarifa.MEDIO_APLICA = "A"
                lEntidadTarifa.PRECIO = Convert.ToDecimal(Me.speTARIFA_AVION.Value)
                lEntidadTarifa.OTRO_CARGO = 0
                lEntidadTarifa.USUARIO_CREA = Me.ObtenerUsuario
                lEntidadTarifa.FECHA_CREA = cFechaHora.ObtenerFechaHora
                lEntidadTarifa.USUARIO_ACT = Me.ObtenerUsuario
                lEntidadTarifa.FECHA_ACT = cFechaHora.ObtenerFechaHora
                lEntidadTarifa.ZAFRA = mEntidad.ZAFRA
                bTarifas_vuelo.ActualizarTARIFA_VUELO(lEntidadTarifa)
            End If
            If Convert.ToDecimal(Me.speTARIFA_DRON.Value) > 0 Then
                lEntidadTarifa.ID_TARIFA = 0
                lEntidadTarifa.ID_PROVEE = mEntidad.ID_PROVEE
                lEntidadTarifa.MEDIO_APLICA = "D"
                lEntidadTarifa.PRECIO = Convert.ToDecimal(Me.speTARIFA_DRON.Value)
                lEntidadTarifa.OTRO_CARGO = 0
                lEntidadTarifa.USUARIO_CREA = Me.ObtenerUsuario
                lEntidadTarifa.FECHA_CREA = cFechaHora.ObtenerFechaHora
                lEntidadTarifa.USUARIO_ACT = Me.ObtenerUsuario
                lEntidadTarifa.FECHA_ACT = cFechaHora.ObtenerFechaHora
                lEntidadTarifa.ZAFRA = mEntidad.ZAFRA
                bTarifas_vuelo.ActualizarTARIFA_VUELO(lEntidadTarifa)
            End If
            If Convert.ToDecimal(Me.speTARIFA_HELICOPTERO.Value) > 0 Then
                lEntidadTarifa.ID_TARIFA = 0
                lEntidadTarifa.ID_PROVEE = mEntidad.ID_PROVEE
                lEntidadTarifa.MEDIO_APLICA = "H"
                lEntidadTarifa.PRECIO = Convert.ToDecimal(Me.speTARIFA_HELICOPTERO.Value)
                lEntidadTarifa.OTRO_CARGO = 0
                lEntidadTarifa.USUARIO_CREA = Me.ObtenerUsuario
                lEntidadTarifa.FECHA_CREA = cFechaHora.ObtenerFechaHora
                lEntidadTarifa.USUARIO_ACT = Me.ObtenerUsuario
                lEntidadTarifa.FECHA_ACT = cFechaHora.ObtenerFechaHora
                lEntidadTarifa.ZAFRA = mEntidad.ZAFRA
                bTarifas_vuelo.ActualizarTARIFA_VUELO(lEntidadTarifa)
            End If
        End If
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ViewState("ID_PROVEE") = mEntidad.ID_PROVEE
        Return ""
    End Function

    Private Sub cbxTIPO_PERSONA_ValueChanged(sender As Object, e As EventArgs) Handles cbxTIPO_PERSONA.ValueChanged
        If cbxTIPO_PERSONA.Value IsNot Nothing AndAlso Convert.ToInt32(cbxTIPO_PERSONA.Value) = TipoPersona.Natural Then
            Me.txtDUI.ClientEnabled = True
            Me.txtNIT.ClientEnabled = True
        ElseIf cbxTIPO_PERSONA.Value IsNot Nothing AndAlso Convert.ToInt32(cbxTIPO_PERSONA.Value) = TipoPersona.Juridica Then
            Me.txtNIT.ClientEnabled = True
            Me.txtDUI.ClientEnabled = False
            Me.txtDUI.Text = ""
        End If
    End Sub

    Private Sub CargarDatosBaseMH(ByVal IdTipoPersona As Integer, ByVal documento As String)
        Dim bBaseMH As New cBASE_PROVEEDORES_MH
        Dim listaBaseMH As New listaBASE_PROVEEDORES_MH
        Dim lEntidad As BASE_PROVEEDORES_MH

        If IdTipoPersona = TipoPersona.Natural Then
            listaBaseMH = bBaseMH.ObtenerListaPorCriterios("", "", documento, "", "")
        ElseIf IdTipoPersona = TipoPersona.Juridica Then
            listaBaseMH = bBaseMH.ObtenerListaPorCriterios("", "", "", documento, "")
        End If

        If listaBaseMH IsNot Nothing AndAlso listaBaseMH.Count > 0 Then
            lEntidad = listaBaseMH(0)
            Me.txtDUI.Text = lEntidad.DUI
            Me.txtNIT.Text = lEntidad.NIT
            Me.txtNOMBRES.Text = lEntidad.NOMBRES
            Me.txtAPELLIDOS.Text = lEntidad.APELLIDOS
            Me.txtTELEFONO.Text = lEntidad.TELEFONO
            Me.txtDIRECCION.Text = lEntidad.DIRECCION
            Me.txtCORREO.Text = lEntidad.CORREO
            Me.txtNRC.Text = lEntidad.NRC
            Me.txtACTIVIDAD.Text = lEntidad.ACTIVIDAD
            Me.cbxDEPARTAMENTO.Value = lEntidad.CODI_DEPTO
            Me.CargarMunicipios()
            Me.cbxMUNICIPIO.Value = lEntidad.CODI_MUNI
        End If
    End Sub

    Private Sub txtDUI_ValueChanged(sender As Object, e As EventArgs) Handles txtDUI.ValueChanged
        Me.CargarDatosBaseMH(Me.cbxTIPO_PERSONA.Value, txtDUI.Text.Trim)
    End Sub

    Private Sub txtNIT_ValueChanged(sender As Object, e As EventArgs) Handles txtNIT.ValueChanged
        Me.CargarDatosBaseMH(Me.cbxTIPO_PERSONA.Value, txtNIT.Text.Trim)
    End Sub

    Private Sub chkES_PROVEEDOR_VUELO_CheckedChanged(sender As Object, e As EventArgs) Handles chkES_PROVEEDOR_VUELO.CheckedChanged
        VerTARIFA_VUELO = chkES_PROVEEDOR_VUELO.Checked
    End Sub
End Class
