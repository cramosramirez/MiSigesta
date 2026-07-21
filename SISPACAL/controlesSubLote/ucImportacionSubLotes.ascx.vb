Imports System.Data
Imports ClosedXML.Excel
Imports SISPACAL.EL.Enumeradores
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports System.IO
Imports DevExpress.Web
Imports System.Globalization

Partial Class controlesSubLote_ucImportacionSubLotes
    Inherits ucBase

    Private Const DirectorioUpload As String = "~/SubidosExcelCosecha/"

    Public Property LIBRO_EXCEL As XLWorkbook
        Set(value As XLWorkbook)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), XLWorkbook) Else Return Nothing
        End Get
    End Property

    Public Enum OrdenCols
        ID_SUBLOTES = 1
        FECHA_COSECHA = 26
        ZONA_RAMSAR = 30
        AREA_EFECTIVA = 43
        TM_HA_EFECTIVA = 44
        TM_EFEC = 45
        REPARA_ACCESO = 55
    End Enum


    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.lblREFERENCIA.Text = Guid.NewGuid.ToString
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Private Sub uploadArchivo_FileUploadComplete(sender As Object, e As FileUploadCompleteEventArgs) Handles uploadArchivo.FileUploadComplete
        Dim ruta As String = Server.MapPath(DirectorioUpload) & e.UploadedFile.FileName
        Dim lResultado As KeyValuePair(Of Integer, String)

        If (Not String.IsNullOrEmpty(e.UploadedFile.FileName)) AndAlso e.UploadedFile.IsValid Then
            e.UploadedFile.SaveAs(ruta, True)
            lResultado = Importar_desde_Excel(ruta)
            If lResultado.Key = 0 Then
                e.IsValid = True
                e.CallbackData = lResultado.Value
            Else
                e.IsValid = False
                e.ErrorText = lResultado.Value
            End If
        End If
    End Sub

    Private Function Importar_desde_Excel(ByVal archivo As String) As KeyValuePair(Of Integer, String)
        Dim libro As XLWorkbook
        Dim lResultado As KeyValuePair(Of Integer, String)
        Dim hojaDatos As IXLRange
        Dim filaEnca As IXLRangeRow
        Dim numeroFilaActual As Integer = 1
        Dim lRet As New StringBuilder

        Try
            libro = New XLWorkbook(archivo)

            hojaDatos = libro.Worksheets(0).RangeUsed
            filaEnca = hojaDatos.FirstRow

            'Campos a actualizar de la tabla SUBLOTES
            Dim id_sublotes As Integer
            Dim fecha_cosecha As DateTime
            Dim zona_ramsar As Boolean
            Dim area_efectiva As Decimal
            Dim tm_ha_efectiva As Decimal
            Dim tm_efec As Decimal
            Dim repara_acceso As Boolean
            Dim lEntidadSubLotes As New SUBLOTES
            Dim cEntidadSubLotes As New cSUBLOTES

            For Each fila As IXLRangeRow In hojaDatos.Rows
                If numeroFilaActual > 1 AndAlso Not String.IsNullOrEmpty(fila.Cell(OrdenCols.ID_SUBLOTES).Value.ToString) Then ' A partir de la segunda fila deben tomarse datos y siempre que la llave no sea nula
                    id_sublotes = Convert.ToInt32(fila.Cell(OrdenCols.ID_SUBLOTES).Value.ToString.Trim)
                    If fila.Cell(OrdenCols.FECHA_COSECHA).Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(fila.Cell(OrdenCols.FECHA_COSECHA).Value.ToString) Then
                        fecha_cosecha = Convert.ToDateTime(fila.Cell(OrdenCols.FECHA_COSECHA).Value)
                    Else
                        fecha_cosecha = Nothing
                    End If
                    If fila.Cell(OrdenCols.ZONA_RAMSAR).Value IsNot Nothing Then
                        If fila.Cell(OrdenCols.ZONA_RAMSAR).Value.ToString.ToUpper.Trim = "SI" Then zona_ramsar = True Else zona_ramsar = False
                    Else
                        zona_ramsar = False
                    End If

                    If fila.Cell(OrdenCols.AREA_EFECTIVA).Value IsNot Nothing AndAlso IsNumeric(fila.Cell(OrdenCols.AREA_EFECTIVA).Value) Then area_efectiva = Convert.ToDecimal(fila.Cell(OrdenCols.AREA_EFECTIVA).Value) Else area_efectiva = 0
                    If fila.Cell(OrdenCols.TM_HA_EFECTIVA).Value IsNot Nothing AndAlso IsNumeric(fila.Cell(OrdenCols.TM_HA_EFECTIVA).Value) Then tm_ha_efectiva = Convert.ToDecimal(fila.Cell(OrdenCols.TM_HA_EFECTIVA).Value) Else tm_ha_efectiva = 0
                    If fila.Cell(OrdenCols.TM_EFEC).Value IsNot Nothing AndAlso IsNumeric(fila.Cell(OrdenCols.TM_EFEC).Value) Then tm_efec = Convert.ToDecimal(fila.Cell(OrdenCols.TM_EFEC).Value) Else tm_efec = 0
                    If fila.Cell(OrdenCols.REPARA_ACCESO).Value IsNot Nothing Then
                        If fila.Cell(OrdenCols.REPARA_ACCESO).Value.ToString.ToUpper.Trim = "SI" Then repara_acceso = True Else repara_acceso = False
                    Else
                        repara_acceso = False
                    End If

                    lEntidadSubLotes = cEntidadSubLotes.ObtenerSUBLOTES(id_sublotes)
                    If lEntidadSubLotes IsNot Nothing Then
                        lEntidadSubLotes.FECHA_COSECHA = fecha_cosecha
                        lEntidadSubLotes.ZONA_RAMSAR = zona_ramsar
                        lEntidadSubLotes.AREA_EFEC = area_efectiva
                        lEntidadSubLotes.TC_MZ_EFEC = tm_ha_efectiva
                        lEntidadSubLotes.TC_EFEC = tm_efec
                        lEntidadSubLotes.REPARA_ACCESO = repara_acceso
                        lEntidadSubLotes.ES_CERRADO = 0
                        cEntidadSubLotes.ActualizarSUBLOTES(lEntidadSubLotes)

                        If cEntidadSubLotes.sError <> "" Then
                            lRet.AppendLine(cEntidadSubLotes.sError)
                        End If
                    End If
                End If

                numeroFilaActual += 1
            Next

            If lRet.ToString <> "" Then
                lResultado = New KeyValuePair(Of Integer, String)(-1, "Error en ACTUALIZAR_ESTICANA_X_SUBLOTE: " + lRet.ToString)
                Return lResultado
            End If

            lResultado = New KeyValuePair(Of Integer, String)(0, "Información subida al sistema exitosamente")
            Return lResultado

        Catch ex As Exception
            lResultado = New KeyValuePair(Of Integer, String)(-1, "Num. fila: " + numeroFilaActual.ToString + " " + ex.Message)
            Return lResultado

        End Try
    End Function


End Class
