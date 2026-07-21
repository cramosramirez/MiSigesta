Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports System.IO
Imports SISPACAL.DL

Public Class frmArchivoEntregaCana

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Function IdUltimaCatorcena(ByVal ID_ZAFRA As Integer) As Integer
        Dim lEntidad As CATORCENA_ZAFRA

        lEntidad = (New cCATORCENA_ZAFRA).ObtenerUltimaCatorcenaCerradaZafra(ID_ZAFRA)
        If lEntidad IsNot Nothing Then
            Return lEntidad.ID_CATORCENA
        End If
        Return -1
    End Function

    Private Sub Inicializar()
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.CbxZAFRA1.Recuperar()
        If lZafraActiva IsNot Nothing Then Me.CbxZAFRA1.SelectedValue = lZafraActiva.ID_ZAFRA
        If Me.CbxZAFRA1.SelectedValue IsNot Nothing Then
            Me.CbxCATORCENA_ZAFRA1.RecuperarPorZAFRA(Me.CbxZAFRA1.SelectedValue)
            Me.CbxCATORCENA_ZAFRA1.SelectedValue = IdUltimaCatorcena(Me.CbxZAFRA1.SelectedValue)
        End If
    End Sub

    Private Sub frmArchivoEntregaCana_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPrincipalRibbon.Habilitar(True)
    End Sub

    Private Sub frmArchivoEntregaCana_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Inicializar()
    End Sub

    Private Sub CbxZAFRA1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbxZAFRA1.SelectedIndexChanged
        Me.CbxCATORCENA_ZAFRA1.RecuperarPorZAFRA(Me.CbxZAFRA1.SelectedValue)
        Me.CbxCATORCENA_ZAFRA1.SelectedValue = IdUltimaCatorcena(Me.CbxZAFRA1.SelectedValue)
    End Sub

    Private Sub btnSeleccionarDirectorio_Click(sender As System.Object, e As System.EventArgs) Handles btnSeleccionarDirectorio.Click
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath <> "" Then
            txtDirectorio.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnGenerarArchivos_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerarArchivos.Click
        If txtDirectorio.Text.Trim = "" Then
            MsgBox("Seleccione un directorio", vbCritical, Application.ProductName)
            txtDirectorio.Focus()
            Return
        End If
        If Not My.Computer.FileSystem.DirectoryExists(txtDirectorio.Text.Trim) Then
            MsgBox("El directorio no existe", vbCritical, Application.ProductName)
            txtDirectorio.Focus()
            Return
        End If

        Dim lCatorcena As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(Me.CbxCATORCENA_ZAFRA1.SelectedValue)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Try

            'Crear archivo de entrega de caña
            Dim dtEntregaCana As New DS_CATORCENA.ArchivoEntregaCanaDataTable
            Dim daEntregaCana As New DS_CATORCENATableAdapters.ArchivoEntregaCanaTableAdapter
            Dim strDirectorio As String = Me.txtDirectorio.Text.Trim
            Dim bRet As Boolean = False

            daEntregaCana.FillPorZafraCatorcena(dtEntregaCana, Me.CbxZAFRA1.SelectedValue, Convert.ToInt32(Me.CbxCATORCENA_ZAFRA1.Text))
            If Microsoft.VisualBasic.Right(strDirectorio, 1) <> "\" Then
                strDirectorio = strDirectorio & "\"
            End If

            If dtEntregaCana.Rows.Count > 0 Then
                bRet = Me.ExportarExcel(dtEntregaCana, strDirectorio & "Movimientos" & lCatorcena.CATORCENA.ToString("00") & ".xlsx", "Movimientos" & lCatorcena.CATORCENA.ToString("00"))
                If bRet Then
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Me.txtDirectorio.Text = ""
                    MsgBox("El archivo de entrega de caña se generó con éxito", vbInformation, Application.ProductName)
                Else
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    MsgBox("Error al generar el archivo de entrega de caña", vbInformation, Application.ProductName)
                End If
            Else
                Me.Cursor = System.Windows.Forms.Cursors.Default
            End If

        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox(ex.Message, vbCritical, Application.ProductName)
            ExceptionManager.Publish(ex)
        End Try
    End Sub

    Function ExportarExcel(ByVal DT As DataTable, ByVal nombreArchivo As String, ByVal nombreHoja As String) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Dim existeHoja As Boolean = False
        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exApp.DisplayAlerts = False
            If My.Computer.FileSystem.FileExists(nombreArchivo) Then
                My.Computer.FileSystem.DeleteFile(nombreArchivo)
            End If
            exLibro = exApp.Workbooks.Add
            exLibro.SaveAs(nombreArchivo)
            exLibro = Nothing
            exLibro = exApp.Workbooks.Open(nombreArchivo)
            exHoja = exLibro.Worksheets.Add()
            exHoja.Name = nombreHoja

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = DT.Columns.Count
            Dim NRow As Integer = DT.Rows.Count
            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DT.Columns(i - 1).ColumnName.ToString
                'exHoja.Cells.AutoFormat(vFormato)
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    If Col = 9 OrElse Col = 10 OrElse Col = 11 OrElse Col = 14 OrElse Col = 15 OrElse Col = 16 _
                        OrElse Col = 17 OrElse Col = 18 Then
                        exHoja.Cells.Item(Fila + 2, Col + 1).NumberFormat = "###,##0.00"
                    End If
                    If Col = 12 Then
                        exHoja.Cells.Item(Fila + 2, Col + 1).NumberFormat = "###,##0.0000"
                    End If
                    If Col = 13 Then
                        exHoja.Cells.Item(Fila + 2, Col + 1).NumberFormat = "###,##0.00000"
                    End If
                    If Col = 5 OrElse Col = 6 OrElse Col = 19 OrElse Col = 21 Then
                        exHoja.Cells.Item(Fila + 2, Col + 1).NumberFormat = "@"
                    End If
                    If Col = 7 OrElse Col = 26 OrElse Col = 27 Then
                        exHoja.Cells.Item(Fila + 2, Col + 1).NumberFormat = "dd/mm/yy hh:mm AM/PM"
                    End If
                    exHoja.Cells.Item(Fila + 2, Col + 1) = DT.Rows(Fila).Item(Col).ToString()
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()

            'Aplicación visible
            'exApp.Application.Visible = True
            exLibro.Save()
            exLibro.Close()
            exApp.DisplayAlerts = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
            Return True

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            MsgBox(ex.Message, vbCritical, Application.ProductName)
            exApp.DisplayAlerts = True
            If exLibro IsNot Nothing Then
                exLibro.Save()
                exLibro.Close()
                exApp.DisplayAlerts = True
                exHoja = Nothing
                exLibro = Nothing
                exApp = Nothing
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return False
        End Try
        Return True
    End Function
End Class