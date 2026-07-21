Imports SISPACAL.EL
Imports SISPACAL.BL

Partial Class controlesBodega_ucCriteriosSolicitudesProductoConsignacion
    Inherits ucBase

    Protected Sub cbxPERIODO_ValueChanged(sender As Object, e As EventArgs) Handles cbxPERIODO.ValueChanged
        Me.dteFECHA_INICIAL.Value = Nothing
        Me.dteFECHA_FINAL.Value = Nothing
        If Me.cbxPERIODO.Value = 1 Then
            Me.dteFECHA_INICIAL.ClientEnabled = False
            Me.dteFECHA_FINAL.ClientEnabled = False
        Else
            Dim hoy As Date = cFechaHora.ObtenerFecha
            Dim f1 As Date
            Dim f2 As Date

            f1 = New DateTime(hoy.Year, hoy.Month, 1)
            f2 = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, f1))
            Me.dteFECHA_INICIAL.ClientEnabled = True
            Me.dteFECHA_FINAL.ClientEnabled = True
            Me.dteFECHA_INICIAL.Date = f1
            Me.dteFECHA_FINAL.Date = f2
        End If
    End Sub

    Public Property VerZAFRA As Boolean
        Get
            Return Me.trZAFRA.Visible
        End Get
        Set(value As Boolean)
            Me.trZAFRA.Visible = value
        End Set
    End Property

    Public Property VerPROVEEDOR As Boolean
        Get
            Return Me.trPROVEEDOR.Visible
        End Get
        Set(value As Boolean)
            Me.trPROVEEDOR.Visible = value
        End Set
    End Property

    Public Property VerCUENTA_FINANCIAMIENTO As Boolean
        Get
            Return Me.trCUENTA_FINANCIAMIENTO.Visible
        End Get
        Set(value As Boolean)
            Me.trCUENTA_FINANCIAMIENTO.Visible = value
        End Set
    End Property

    Public Property VerPROVEEDOR_AGRICOLA As Boolean
        Get
            Return Me.trPROVEEDOR_AGRICOLA.Visible
        End Get
        Set(value As Boolean)
            Me.trPROVEEDOR_AGRICOLA.Visible = value
        End Set
    End Property

    Public Property VerPERIODO As Boolean
        Get
            Return Me.trPERIODO.Visible
        End Get
        Set(value As Boolean)
            Me.trPERIODO.Visible = value
        End Set
    End Property

    Public Property VerPERIODO_RANGO As Boolean
        Get
            Return VerPERIODO
        End Get
        Set(value As Boolean)
            VerPERIODO = value
            If value Then
                Me.cbxPERIODO.Value = 2
                Me.cbxPERIODO.ClientEnabled = False
                cbxPERIODO_ValueChanged(Me, New System.EventArgs)
            Else
                Me.cbxPERIODO.Value = Nothing
                Me.cbxPERIODO.ClientEnabled = True
            End If
        End Set
    End Property

    Public Property ID_CUENTA_FINAN As Int32
        Get
            If Me.cbxCUENTA_FINANCIAMIENTO.Value IsNot Nothing Then
                Return CInt(Me.cbxCUENTA_FINANCIAMIENTO.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxCUENTA_FINANCIAMIENTO.Value = value
        End Set
    End Property
    
    Public Property ID_ZAFRA As Int32
        Get
            If Me.cbxZAFRA.Value IsNot Nothing Then
                Return CInt(Me.cbxZAFRA.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxZAFRA.Value = value
        End Set
    End Property

    Public Property NUM_SOLICITUD As Int32
        Get
            If Me.speNUM_SOLICITUD.Value IsNot Nothing Then
                Return CInt(Me.speNUM_SOLICITUD.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.speNUM_SOLICITUD.Value = value
        End Set
    End Property

    Public Property NO_DOCUMENTO As Int32
        Get
            If Me.speNO_DOCUMENTO.Value IsNot Nothing Then
                Return CInt(Me.speNO_DOCUMENTO.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.speNO_DOCUMENTO.Value = value
        End Set
    End Property

    Public Property CODIPROVEEDOR() As String
        Get
            If Me.speCODIPROVEE.Value Is Nothing Then
                Return ""
            Else
                Return Utilerias.FormatearCODIPROVEEDOR(Me.speCODIPROVEE.Value)
            End If
        End Get
        Set(ByVal value As String)
            Me.speCODIPROVEE.Value = value
        End Set
    End Property

    Public Property ID_PROVEEDOR_AGRICOLA As Int32
        Get
            If Me.cbxPROVEEDOR_AGRICOLA.Value IsNot Nothing Then
                Return CInt(Me.cbxPROVEEDOR_AGRICOLA.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxPROVEEDOR_AGRICOLA.Value = value
        End Set
    End Property

    Public Property ID_ESTADO As Int32
        Get
            If Me.cbxESTADO.Value IsNot Nothing Then
                Return CInt(Me.cbxESTADO.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxESTADO.Value = value
        End Set
    End Property

    Public ReadOnly Property FECHA_INICIAL As String
        Get
            If Me.dteFECHA_INICIAL.Value <> #12:00:00 AM# Then
                Return Me.dteFECHA_INICIAL.Date.ToString("dd/MM/yyyy")
            Else
                Return ""
            End If
        End Get
    End Property

    Public ReadOnly Property FECHA_FINAL As String
        Get
            If Me.dteFECHA_FINAL.Value <> #12:00:00 AM# Then
                Return Me.dteFECHA_FINAL.Date.ToString("dd/MM/yyyy")
            Else
                Return ""
            End If
        End Get
    End Property

    Public Property PERIODO As Int32
        Get
            If Me.cbxPERIODO.Value IsNot Nothing Then
                Return CInt(Me.cbxPERIODO.Value)
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.cbxPERIODO.Value = value
        End Set
    End Property

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.ucBusquedaProveedor1.Inicializar()
        Me.pcBusquedaProveedor.ShowOnPageLoad = True
    End Sub

    Protected Sub ucBusquedaProveedor1_Aceptar(CODIPROVEEDOR As String) Handles ucBusquedaProveedor1.Aceptar
        Dim lProveedor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(CODIPROVEEDOR)

        If lProveedor IsNot Nothing Then
            Me.speCODIPROVEE.Text = Utilerias.RecuperarCODIPROVEE(lProveedor.CODIPROVEEDOR)
            Me.txtNOMBRE_PROVEEDOR.Text = lProveedor.NOMBRES + " " + lProveedor.APELLIDOS
        End If
        Me.pcBusquedaProveedor.ShowOnPageLoad = False
    End Sub

    Protected Sub ucBusquedaProveedor1_Cancelar() Handles ucBusquedaProveedor1.Cancelar
        Me.pcBusquedaProveedor.ShowOnPageLoad = False
    End Sub
End Class
