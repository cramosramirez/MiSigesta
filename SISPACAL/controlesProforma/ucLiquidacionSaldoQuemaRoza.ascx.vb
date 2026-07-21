
Partial Class controlesProforma_ucLiquidacionSaldoQuemaRoza
    Inherits ucBase
    Public Event LiquidandoSaldoQuema(ByVal ID_CONTROL_QUEMA As Int32)
    Public Event LiquidandoSaldoRoza(ByVal ID_ROZA_SALDO As Int32)

    Public Property ID_ROZA_SALDO As Int32
        Get
            If Me.ViewState("ID_ROZA_SALDO") IsNot Nothing Then
                Return Me.ViewState("ID_ROZA_SALDO")
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.ViewState("ID_ROZA_SALDO") = value
            Me.lblMensaje.Text = "¿Está seguro(a) de liquidar el saldo de roza?"
        End Set
    End Property

    Public Property ID_CONTROL_QUEMA As Int32
        Get
            If Me.ViewState("ID_CONTROL_QUEMA") IsNot Nothing Then
                Return Me.ViewState("ID_CONTROL_QUEMA")
            Else
                Return -1
            End If
        End Get
        Set(value As Int32)
            Me.ViewState("ID_CONTROL_QUEMA") = value
            Me.lblMensaje.Text = "¿Está seguro(a) de liquidar el saldo de quema?"
        End Set
    End Property

    
End Class
