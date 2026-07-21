Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class RutaDiariaCosecha

    Public Sub CargarDatos(ByVal ID_ZAFRA As Int32, ByVal FECHA As String)
        Me.DS_SIFAG1.Clear()
        Dim fec As DateTime = New DateTime(Strings.Left(FECHA, 4), Strings.Mid(FECHA, 5, 2), Strings.Right(FECHA, 2))

        txtFECHA.Text = fec.ToString("dd/MM/yyyy")
        Me.RUTA_DIARIA_COSECHATableAdapter1.FillPorFecha(DS_SIFAG1.RUTA_DIARIA_COSECHA, ID_ZAFRA, fec)
    End Sub
End Class