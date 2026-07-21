Public Class frmFormulaDextrana 
    Private mEntidad As PARAM_PRECOSECHA
    Private bFechaHora As New cFechaHora

    Private Sub frmFormulaDextrana_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPrincipalRibbon.Habilitar(True)
    End Sub

    Private Sub frmFormulaDextrana_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim lParametrosCosecha As listaPARAM_PRECOSECHA

        If lZafra IsNot Nothing Then
            txtZafra.Text = lZafra.NOMBRE_ZAFRA
            lParametrosCosecha = (New cPARAM_PRECOSECHA).ObtenerListaPorZAFRA(lZafra.ID_ZAFRA)
            If lParametrosCosecha IsNot Nothing AndAlso lParametrosCosecha.Count > 0 Then
                mEntidad = lParametrosCosecha(0)
                Me.speConstanteA.Value = mEntidad.CTE_A_DEXTRA
                Me.speConstanteB.Value = mEntidad.CTE_B_DEXTRA
            Else
                mEntidad = New PARAM_PRECOSECHA
                mEntidad.ID_PARAM_PRECOSECHA = 0
                mEntidad.ID_ZAFRA = lZafra.ID_ZAFRA
                mEntidad.USUARIO_CREA = configuracion.usuarioActualiza
                mEntidad.FECHA_CREA = bFechaHora.ObtenerFechaHora
                mEntidad.USUARIO_ACT = configuracion.usuarioActualiza
                mEntidad.FECHA_CT = bFechaHora.ObtenerFechaHora
                Me.speConstanteA.Value = 0
                Me.speConstanteB.Value = 0
            End If
        Else
            MessageBox.Show("No se encontró ninguna zafra activa", "Validación", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            btnAceptar.Enabled = False
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Dim bParametro As New cPARAM_PRECOSECHA

        If Me.speConstanteA.Value = 0 Then
            MessageBox.Show("El valor de la Constante A no puede ser cero", "Validación", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.speConstanteB.Value = 0 Then
            MessageBox.Show("El valor de la Constante B no puede ser cero", "Validación", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        mEntidad.CTE_A_DEXTRA = speConstanteA.Value
        mEntidad.CTE_B_DEXTRA = speConstanteB.Value
        If mEntidad.ID_PARAM_PRECOSECHA > 0 Then
            mEntidad.USUARIO_ACT = configuracion.usuarioActualiza
            mEntidad.FECHA_CT = bFechaHora.ObtenerFechaHora
        End If
        bParametro.ActualizarPARAM_PRECOSECHA(mEntidad, TipoConcurrencia.Pesimistica)
        Me.Close()
    End Sub

End Class