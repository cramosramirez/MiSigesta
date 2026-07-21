Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class DoctoIngresoBodegaPorTransf

    Public Sub Cargar(ByVal ID_DOCENTRA_ENCA As Int32)
        Dim lEntidad As DOCUMENTO_ENTRADA_ENCA = (New cDOCUMENTO_ENTRADA_ENCA).ObtenerDOCUMENTO_ENTRADA_ENCA(ID_DOCENTRA_ENCA)

        Me.DS_SIFAG1.Clear()
        Me.DOCUMENTO_INGRESO_BODEGATableAdapter1.FillPorId(Me.DS_SIFAG1.DOCUMENTO_INGRESO_BODEGA, ID_DOCENTRA_ENCA)

        If lEntidad IsNot Nothing Then
            If lEntidad.ID_TIPO_MOVTO = 1 Then
                XrTableRow1.DeleteCell(Me.xrDetaProveedor1)
                XrTableRow2.DeleteCell(Me.xrDetaProveedor2)
            End If
            If lEntidad.ID_TIPO_MOVTO = 2 Then
                xrNoSalidaLabel.Visible = True
                xrNoSalidaText.Visible = True
            End If
        End If
        Me.DisplayName = "DcoumentoIngresoPorTransferencia"
    End Sub
End Class