
Imports System.Data
Imports ClosedXML.Excel
Imports SISPACAL.EL.Enumeradores
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports System.IO
Imports DevExpress.Web
Imports System.Globalization

Partial Class controlesCenso_ucExportacionExcel
    Inherits ucBase

    Private Variables As VariablesXLSX
    Private Const DirectorioUpload As String = "~/SubidosExcelCosecha/"

    Public Property LIBRO_EXCEL As XLWorkbook
        Set(value As XLWorkbook)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), XLWorkbook) Else Return Nothing
        End Get
    End Property

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.lblREFERENCIA.Text = Guid.NewGuid.ToString
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Private Function FormatearNombreZafra(ByVal nombre As String) As String
        Return Mid(nombre, 3, 2) & "-" & Mid(nombre, 8, 2)
    End Function

    Private Function Exportar_a_Excel() As KeyValuePair(Of Integer, String)
        Dim libro As XLWorkbook = New XLWorkbook
        Dim bLotesCosecha As New cLOTES_COSECHA
        Dim lResultado As KeyValuePair(Of Integer, String)
        Dim ds As DataSet
        Dim hoja As IXLWorksheet
        Dim hojaParam As IXLWorksheet
        Dim lZafraAnt As ZAFRA
        Dim lZafraActiva As ZAFRA
        Dim nombreHoja As String
        Dim nombreArchivo As String
        Dim filaTotal As Integer
        Dim listaColumnas As List(Of Integer)
        Dim nombre_z1 As String
        Dim nombre_z2 As String

        Try
            lZafraActiva = (New cZAFRA).ObtenerZafraActiva
            lZafraAnt = (New cZAFRA).ObtenerZAFRA(lZafraActiva.ID_ZAFRA - 1)
            nombreHoja = "ESTICAÑA ACTUAL AL " & Now.ToString("ddMMyyyy")
            nombreArchivo = "ESTICAÑA COMPARATIVO ZAFRAS " & lZafraAnt.NOMBRE_ZAFRA.Replace("/", "-") & " Y " &
                lZafraActiva.NOMBRE_ZAFRA.Replace("/", "-") & " AL " & Now.ToString("ddMMyyyy HH_mm_ss") & ".xlsx"

            ds = bLotesCosecha.execXLS_COMPARATIVO_ZAFRA_ACTUAL_VS_ANTERIOR(lZafraActiva.ID_ZAFRA - 1, lZafraActiva.ID_ZAFRA)
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                'Renombrar columnas
                nombre_z1 = FormatearNombreZafra(lZafraAnt.NOMBRE_ZAFRA)
                nombre_z2 = FormatearNombreZafra(lZafraActiva.NOMBRE_ZAFRA)
                RenombrarColumnas(ds.Tables(0), nombre_z1, nombre_z2)

                'Agregando datatable como hoja
                hoja = libro.Worksheets.Add(ds.Tables(0), nombreHoja)
                'Agregando hoja de parametros
                hojaParam = libro.Worksheets.Add("PARAMETROS")
                hojaParam.Cell(1, 1).Value = nombre_z1
                hojaParam.Cell(1, 2).Value = nombre_z2
                hojaParam.Cell(1, 3).Value = lZafraActiva.ID_ZAFRA
                hojaParam.Hide()

                'Incrementando alto de la fila y centrando texto
                hoja.Rows.Style.Font.FontSize = 9
                hoja.FirstRow.Height = 32
                hoja.FirstRow.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center
                hoja.FirstRow.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                hoja.FirstRow.Style.Font.FontSize = 10
                hoja.SheetView.FreezeRows(1)

                'Fila Totales
                listaColumnas = Columnas_a_totalizar()
                filaTotal = ds.Tables(0).Rows.Count + 2
                hoja.Cell(filaTotal, 7).Value = "TOTALES"
                hoja.Cell(filaTotal, 7).Style.Font.FontSize = 12
                For i As Integer = 0 To listaColumnas.Count - 1
                    hoja.Cell(filaTotal, listaColumnas(i)).FormulaR1C1 = "=SUM(R[-" & ds.Tables(0).Rows.Count.ToString & "]C:R[-1]C)"
                    hoja.Cell(filaTotal, listaColumnas(i)).Style.NumberFormat.Format = "#,###,##0.00"
                    hoja.Cell(filaTotal, listaColumnas(i)).Style.Font.FontSize = 12
                Next
                For i As Integer = 1 To ds.Tables(0).Columns.Count
                    hoja.Cell(filaTotal, i).Style.Fill.BackgroundColor = XLColor.LightGray
                    hoja.Cell(filaTotal, i).Style.Border.TopBorder = XLBorderStyleValues.Thin
                    hoja.Cell(filaTotal, i).Style.Border.BottomBorder = XLBorderStyleValues.Thin
                    hoja.Cell(filaTotal, i).Style.Border.RightBorder = XLBorderStyleValues.Thin
                    hoja.Cell(filaTotal, i).Style.Border.LeftBorder = XLBorderStyleValues.Thin
                    hoja.Cell(filaTotal, i).Style.Font.Bold = True
                Next
                For i As Integer = 0 To ds.Tables(0).Columns.Count - 1
                    If ds.Tables(0).Columns(i).DataType.Equals(System.Type.GetType("System.DateTime")) Then
                        hoja.Columns(i + 1).CellsUsed.Style.DateFormat.Format = "dd/MM/yyyy"
                    End If
                Next
                ResaltarEncabezadoColumnasGestion(hoja)
                hoja.ColumnsUsed().AdjustToContents()
                '-------------------------------------------
                LIBRO_EXCEL = libro
                lResultado = New KeyValuePair(Of Integer, String)(0, "Esticaña comparativo generado con exito.")
            Else
                lResultado = New KeyValuePair(Of Integer, String)(-1, "No se encontraron dato para procesar.")
            End If

            Return lResultado

        Catch ex As Exception
            lResultado = New KeyValuePair(Of Integer, String)(-1, "Error al generar esticaña comparativo: " & ex.Message.ToString)
            Return lResultado

        End Try
    End Function

    Private Sub ResaltarEncabezadoColumnasGestion(ByRef hoja As IXLWorksheet)
        hoja.Cell(1, 7).Style.Fill.BackgroundColor = XLColor.FromArgb(1, 226, 107, 10) '[Z1] GRUPO
        hoja.Cell(1, 19).Style.Fill.BackgroundColor = XLColor.FromArgb(1, 226, 107, 10) '[Z1] HA
        hoja.Cell(1, 20).Style.Fill.BackgroundColor = XLColor.FromArgb(1, 226, 107, 10) '[Z1] TC
        hoja.Cell(1, 21).Style.Fill.BackgroundColor = XLColor.FromArgb(1, 226, 107, 10) '[Z1] TCH

        hoja.Cell(1, 29).Style.Fill.BackgroundColor = XLColor.FromArgb(1, 226, 107, 10) '[Z2] GRUPO
        hoja.Cell(1, 56).Style.Fill.BackgroundColor = XLColor.FromArgb(1, 226, 107, 10) '[Z2] HA EFECTIVAS
        hoja.Cell(1, 57).Style.Fill.BackgroundColor = XLColor.FromArgb(1, 226, 107, 10) '[Z2] TCH
        hoja.Cell(1, 58).Style.Fill.BackgroundColor = XLColor.FromArgb(1, 226, 107, 10) '[Z2] TC
    End Sub

    Private Sub DescargaLibroExcel()
        Dim lZafraAnt As ZAFRA
        Dim lZafraActiva As ZAFRA
        Dim nombreArchivo As String
        Dim memStream As MemoryStream
        Dim libro As XLWorkbook = Me.LIBRO_EXCEL

        If libro IsNot Nothing Then
            lZafraActiva = (New cZAFRA).ObtenerZafraActiva
            lZafraAnt = (New cZAFRA).ObtenerZAFRA(lZafraActiva.ID_ZAFRA - 1)
            nombreArchivo = "ESTICAÑA COMPARATIVO ZAFRAS " & lZafraAnt.NOMBRE_ZAFRA.Replace("/", "-") & " Y " &
                lZafraActiva.NOMBRE_ZAFRA.Replace("/", "-") & " AL " & Now.ToString("ddMMyyyy HH_mm_ss") & ".xlsx"

            Response.Clear()
            Response.Buffer = True
            Response.Charset = ""
            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            Response.AddHeader("content-disposition", "attachment;filename=" & nombreArchivo)
            memStream = New MemoryStream
            libro.SaveAs(memStream)
            Response.BinaryWrite(memStream.ToArray)
            Response.Flush()
            Response.SuppressContent = True
            Response.End()
            Session.Remove(lblREFERENCIA.Text)
        End If
    End Sub
    Private Function Columnas_a_totalizar() As List(Of Integer)
        Dim lista As List(Of Integer)

        lista = New List(Of Integer)(New Integer() {14, 15, 16, 17, 19, 20, 21, 22, 40, 41, 42, 43, 44, 45, 46, 47, 48, 52, 53, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64})
        For i As Integer = 82 To 213
            lista.Add(i)
        Next
        Return lista
    End Function

    Private Sub RenombrarColumnas(ByRef dt As DataTable, ByVal z1 As String, ByVal z2 As String)

        Try

            For i As Integer = 0 To dt.Columns.Count - 1
                If Left(dt.Columns(i).ColumnName, 1) = "C" AndAlso dt.Columns(i).ColumnName.Length <= 4 Then
                    dt.Columns(i).ColumnName = Replace(dt.Columns(i).ColumnName, "C", "")
                Else
                    If i <= 17 AndAlso i <> 6 Then
                        dt.Columns(i).ColumnName = z1 & " " & dt.Columns(i).ColumnName
                    End If
                End If
            Next
            dt.Columns(17).ColumnName = z1 & " TC/MZ"
            dt.Columns(22).ColumnName = z1 & " REND. REAL LBS/TC"
            dt.Columns("ACCESLOTE_Z").ColumnName = z2 & " ACCESLOTE"
            dt.Columns("ZAFRA_Z").ColumnName = z2 & " ZAFRA"
            dt.Columns("ZONA_Z").ColumnName = z2 & " ZONA"
            dt.Columns("CODIGO_Z").ColumnName = z2 & " CODIGO"
            dt.Columns("SOCIO_Z").ColumnName = z2 & " SOCIO"
            dt.Columns("PRODUCTOR_Z").ColumnName = z2 & " PRODUCTOR"
            dt.Columns("VIENE_MULTI_Z").ColumnName = "VIENE MULTIZAFRAS ANTERIORES"
            dt.Columns("NO_CONTRATO_Z").ColumnName = z2 & " No CONTRATO"
            dt.Columns("CODILOTE_Z").ColumnName = z2 & " CODILOTE"
            dt.Columns("NOMBLOTE_Z").ColumnName = z2 & " NOMBLOTE"
            dt.Columns("ESTADO_LOTE_Z").ColumnName = z2 & " ESTADO"
            dt.Columns("FECHA_CIERRE_Z").ColumnName = z2 & " FECHA CIERRE"
            dt.Columns("OB_PROD_INTERNA").ColumnName = "OBSERVACIONES PRODUCCION INTERNA GRUPO JD"
            dt.Columns("OB_PERSO_TEC").ColumnName = "OBSERVACIONES PERSONAL TECNICO"
            dt.Columns("MZ_PERDIDA").ColumnName = "AREA PERDIDA"
            dt.Columns("TC_PERDIDA").ColumnName = z2 & " TC PERDIDAS"
            dt.Columns("SIEMBRA_NUEVA").ColumnName = "SIEMBRAS NUEVAS"
            dt.Columns("SIEMBRA_PROYE").ColumnName = "PROYECCION DE SIEMBRA"
            dt.Columns("MZ_PENDIENTE").ColumnName = "PENDIENTE DE CONTRATAR MZ"
            dt.Columns("TC_PENDIENTE").ColumnName = "PENDIENTE DE CONTRATAR TC"
            dt.Columns("SEMILLA_MZ").ColumnName = "SEMILLA MZ"
            dt.Columns("SEMILLA_TC").ColumnName = "SEMILLA TC"
            dt.Columns("TIPO_ROZA").ColumnName = "TIPO ROZA"
            dt.Columns("TIPO_TRANSPORTE").ColumnName = "TIPO TRANSPORTE"
            dt.Columns("TIPO_QUEMA").ColumnName = "TIPO QUEMA"
            dt.Columns("MZ_CONTRA_Z").ColumnName = z2 & " MZ CONTRATADAS"
            dt.Columns("MZ_ESTI_Z").ColumnName = z2 & " MZ ESTICAÑA"
            dt.Columns("TC_MZ_ESTI_Z").ColumnName = z2 & " TC/MZ ESTICAÑA"
            dt.Columns("TC_ESTI_Z").ColumnName = z2 & " TOTAL TC ESTICAÑA"
            dt.Columns("TC_ENTREGADO_Z").ColumnName = z2 & " TOTAL TC ENTREGADA"
            dt.Columns("TC_ENTREGAR_Z").ColumnName = z2 & " TOTAL TC POR ENTREGAR"
            dt.Columns("TC_ENTREGADO2").ColumnName = z1 & " TC ENTREGADO"
            dt.Columns("TC_ESTI_Z2").ColumnName = z2 & " TC ESTICAÑA"
            dt.Columns("TC_MENOS").ColumnName = z2 & " TC DE MENOS"
            dt.Columns("TC_MAS").ColumnName = z2 & " TC DE MAS"
            dt.Columns("EJEC_MADURANTE").ColumnName = z1 & " MADURANTE APLICADO"
            dt.Columns("EJEC_MADURANTE_DOSIS").ColumnName = z1 & " MADURANTE APLICADO DOSIS"
            dt.Columns("EJEC_FECHA_APLI").ColumnName = z1 & " FECHA APLICACION"
            dt.Columns("EJEC_FECHA_ROZA").ColumnName = z1 & " FECHA ROZA VENTANA"
            dt.Columns("FEC_PRIM_VIAJE").ColumnName = z1 & " FECHA PRIMER VIAJE"
            dt.Columns("FEC_ULT_VIAJE").ColumnName = z1 & " FECHA ULTIMO VIAJE"
            dt.Columns("LBS_ENTREGADO").ColumnName = z1 & " LBS_ENTREGADO"
            dt.Columns("FEC_PRIM_VIAJE_MAS12").ColumnName = z2 & " CICLO " & z1 & "(PRIMER VIAJE + 12 MESES)"
            dt.Columns("FECHA_ROZA_TECNICO").ColumnName = z2 & " MADURANTE ESTICAÑA"
            dt.Columns("MESES_EN_COSECHARA_LOTE").ColumnName = z2 & " FECHA APLICACION ESTICAÑA"
            dt.Columns("MAD_PROD_XEJE").ColumnName = z2 & " FECHA ROZA VENTANA ESTICAÑA"
            dt.Columns("MAD_FECPROG_XEJE").ColumnName = z2 & " FECHA PRIMER VIAJE"
            dt.Columns("FECHA_APLI_Z").ColumnName = z2 & " FECHA ULTIMO VIAJE"
            dt.Columns("MAD_FECROZA_XEJE").ColumnName = z2 & " MESES CON LOS QUE SE COSECHARA EL LOTE"
            dt.Columns("TC_ENTREGADO3").ColumnName = "TOTAL TC " & z1
            dt.Columns("VARIEDAD_Z").ColumnName = "CAÑA VARIEDAD"
            dt.Columns("TIPO_Z").ColumnName = "CAÑA TIPO"
            dt.Columns("SUBTIPO_Z").ColumnName = "CAÑA SUBTIPO"
            dt.Columns("TERCIO_Z").ColumnName = "TERCIO"
            dt.Columns("SUBTERCIO_Z").ColumnName = "SUBTERCIO"
            dt.Columns("CONCEPTO").ColumnName = "CONCEPTO"
            dt.Columns("EQUIPO_ANTERIOR").ColumnName = z1 & " EQUIPO"
            dt.Columns("AREA_ANTERIOR").ColumnName = z1 & " AREA"
            dt.Columns("MAD_APLI_DOSIS_ACTUAL").ColumnName = z2 & " MADURANTE APLICADO DOSIS"
            dt.Columns("EQUIPO_ACTUAL").ColumnName = z2 & " EQUIPO"

            dt.Columns("GRUPO_Z1").ColumnName = z1 & " GRUPO"
            dt.Columns("HA_Z1").ColumnName = z1 & " HA"
            dt.Columns("TC_Z1").ColumnName = z1 & " TC"
            dt.Columns("TCH_Z1").ColumnName = z1 & " TCH"

            dt.Columns("GRUPO_Z2").ColumnName = z2 & " GRUPO"
            dt.Columns("HA_EFEC_Z2").ColumnName = z2 & " HA EFECTIVAS"
            dt.Columns("TCH_Z2").ColumnName = z2 & " TCH"
            dt.Columns("TC_Z2").ColumnName = z2 & " TC"

        Catch ex As Exception
            Exit Sub

        End Try
    End Sub

    Protected Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim lResultado As KeyValuePair(Of Integer, String)

        lResultado = Me.Exportar_a_Excel()
        Me.pcCosechaExcel.ShowOnPageLoad = False
        If lResultado.Key = 0 Then
            Me.pcDescargarCosecha.ShowOnPageLoad = True
        Else
            Me.AsignarMensaje(lResultado.Value, False, True, True)
        End If

    End Sub


    Private Function Importar_desde_Excel(ByVal archivo As String) As KeyValuePair(Of Integer, String)
        Dim libro As XLWorkbook
        Dim lResultado As KeyValuePair(Of Integer, String)
        Dim hojaDatos As IXLRange
        Dim hojaParam As IXLRange
        Dim filaEnca As IXLRangeRow
        Dim z1 As String
        Dim z2 As String
        Dim idZafra As Integer
        Dim cantCols As Integer
        Dim listaCols As Dictionary(Of String, Integer)
        Dim iColLlave As Integer
        Dim bLotesCosecha As New cLOTES_COSECHA
        Dim sAccesLote As String
        Dim sAccesLoteZafraAntetior As String
        Dim sZona As String
        Dim bLotes As New cLOTES
        Dim bLoteGestion As New cLOTES_COSECHA_GESTION
        Dim bEstiXlsEnca As New cESTICANA_XLS_ENCA
        Dim bEstiXlsDeta As New cESTICANA_XLS_DETA
        Dim lEstiXlsEnca As ESTICANA_XLS_ENCA
        Dim lEstiXlsDeta As ESTICANA_XLS_DETA
        Dim idEncaEstiXls As Integer
        Dim iConta As Integer = 0
        Dim esAmarillo As Boolean = False
        Dim lRet As String

        Try
            libro = New XLWorkbook(archivo)
            If libro.Worksheets.Count <> 2 Then
                lResultado = New KeyValuePair(Of Integer, String)(-1, "El archivo de Excel debe contener dos hojas una de DATOS y otra de PARAMETROS")
                Return lResultado
            End If
            For i As Integer = 0 To libro.Worksheets.Count - 1
                If libro.Worksheets(i).Name.ToUpper = "PARAMETROS" Then
                    hojaParam = libro.Worksheets(1).RangeUsed
                Else
                    hojaDatos = libro.Worksheets(0).RangeUsed
                End If
            Next
            filaEnca = hojaDatos.FirstRow
            cantCols = hojaDatos.ColumnCount
            z1 = hojaParam.Rows(1).Cells(0).Value
            z2 = hojaParam.Rows(1).Cells(1).Value
            idZafra = hojaParam.Rows(1).Cells(2).Value

            'Obteniendo los nombres de las columnas a procesar y sus indices
            listaCols = Me.ObtenerColumnasProcesar(z1, z2, filaEnca)
            iColLlave = listaCols(Variables.ACCESLOTE)

            'Crear encabezado de importación
            '*******************************
            lEstiXlsEnca = New ESTICANA_XLS_ENCA
            lEstiXlsEnca.ID_ENCA = 0
            lEstiXlsEnca.FECHA_CARGA = cFechaHora.ObtenerFecha
            lEstiXlsEnca.NOMBRE_ARCHIVO = archivo
            lEstiXlsEnca.FECHA_CREA = cFechaHora.ObtenerFechaHora
            lEstiXlsEnca.USUARIO_CREA = Me.ObtenerUsuario
            If bEstiXlsEnca.ActualizarESTICANA_XLS_ENCA(lEstiXlsEnca) > 0 Then
                idEncaEstiXls = lEstiXlsEnca.ID_ENCA
            End If
            '*******************************

            For Each fila As IXLRangeRow In hojaDatos.Rows
                iConta = iConta + 1
                sAccesLote = fila.Cell(iColLlave).Value.ToString.Trim
                sZona = fila.Cell(listaCols(Variables.ZONA)).Value.ToString.Trim
                sAccesLoteZafraAntetior = fila.Cell(listaCols(Variables.ACCESLOTE_ANT)).Value.ToString.Trim
                If (Not fila.IsEmpty AndAlso (Not String.IsNullOrEmpty(sZona)) AndAlso iConta > 1) OrElse (Not fila.IsEmpty AndAlso (Not String.IsNullOrEmpty(sAccesLoteZafraAntetior)) AndAlso iConta > 1) Then
                    lEstiXlsDeta = New ESTICANA_XLS_DETA
                    lEstiXlsDeta.ID_DETA = 0
                    lEstiXlsDeta.ID_ENCA = idEncaEstiXls
                    lEstiXlsDeta.ACCESLOTE = sAccesLote
                    lEstiXlsDeta.ZONA = sZona

                    'esAmarillo = hojaDatos.FirstRow.Cell(listaCols(Variables.MZ_ESTICANA)).Style.Fill.BackgroundColor = XLColor.Yellow
                    If IsNumeric(fila.Cell(listaCols(Variables.MZ_ESTICANA)).Value) Then
                        lEstiXlsDeta.MZ = Convert.ToDecimal(fila.Cell(listaCols(Variables.MZ_ESTICANA)).Value)
                    Else
                        lEstiXlsDeta.MZ = 0
                    End If
                    If IsNumeric(fila.Cell(listaCols(Variables.TC_MZ_ESTICANA)).Value) Then
                        lEstiXlsDeta.TC_MZ = Convert.ToDecimal(fila.Cell(listaCols(Variables.TC_MZ_ESTICANA)).Value)
                    Else
                        lEstiXlsDeta.TC_MZ = 0
                    End If
                    If IsNumeric(fila.Cell(listaCols(Variables.TOTAL_TC_ESTICANA)).Value) Then
                        lEstiXlsDeta.TC = Convert.ToDecimal(fila.Cell(listaCols(Variables.TOTAL_TC_ESTICANA)).Value)
                    Else
                        lEstiXlsDeta.TC = 0
                    End If
                    lEstiXlsDeta.OB_PROD_INTERNA = fila.Cell(listaCols(Variables.OBSERVACIONES_PRODUCCION_INTERNA_GRUPO_JD)).Value.ToString.Trim
                    lEstiXlsDeta.OB_PERSO_TEC = fila.Cell(listaCols(Variables.OBSERVACIONES_PERSONAL_TECNICO)).Value.ToString.Trim
                    If IsNumeric(fila.Cell(listaCols(Variables.AREA_PERDIDA)).Value) Then
                        lEstiXlsDeta.MZ_PERDIDA = Convert.ToDecimal(fila.Cell(listaCols(Variables.AREA_PERDIDA)).Value)
                    End If
                    If IsNumeric(fila.Cell(listaCols(Variables.TC_PERDIDAS)).Value) Then
                        lEstiXlsDeta.TC_PERDIDA = Convert.ToDecimal(fila.Cell(listaCols(Variables.TC_PERDIDAS)).Value)
                    End If
                    If IsNumeric(fila.Cell(listaCols(Variables.RENOVACION)).Value) Then
                        lEstiXlsDeta.RENOVACION = Convert.ToDecimal(fila.Cell(listaCols(Variables.RENOVACION)).Value)
                    End If
                    If IsNumeric(fila.Cell(listaCols(Variables.SIEMBRAS_NUEVAS)).Value) Then
                        lEstiXlsDeta.SIEMBRA_NUEVA = Convert.ToDecimal(fila.Cell(listaCols(Variables.SIEMBRAS_NUEVAS)).Value)
                    End If
                    If IsNumeric(fila.Cell(listaCols(Variables.PROYECCION_DE_SIEMBRA)).Value) Then
                        lEstiXlsDeta.SIEMBRA_PROYE = Convert.ToDecimal(fila.Cell(listaCols(Variables.PROYECCION_DE_SIEMBRA)).Value)
                    End If
                    If IsNumeric(fila.Cell(listaCols(Variables.PENDIENTE_DE_CONTRATAR_MZ)).Value) Then
                        lEstiXlsDeta.MZ_PENDIENTE = Convert.ToDecimal(fila.Cell(listaCols(Variables.PENDIENTE_DE_CONTRATAR_MZ)).Value)
                    End If
                    If IsNumeric(fila.Cell(listaCols(Variables.PENDIENTE_DE_CONTRATAR_TC)).Value) Then
                        lEstiXlsDeta.TC_PENDIENTE = Convert.ToDecimal(fila.Cell(listaCols(Variables.PENDIENTE_DE_CONTRATAR_TC)).Value)
                    End If
                    If IsNumeric(fila.Cell(listaCols(Variables.SEMILLA_MZ)).Value) Then
                        lEstiXlsDeta.SEMILLA_MZ = Convert.ToDecimal(fila.Cell(listaCols(Variables.SEMILLA_MZ)).Value)
                    End If
                    If IsNumeric(fila.Cell(listaCols(Variables.SEMILLA_TC)).Value) Then
                        lEstiXlsDeta.SEMILLA_TC = Convert.ToDecimal(fila.Cell(listaCols(Variables.SEMILLA_TC)).Value)
                    End If
                    lEstiXlsDeta.TIPO_ROZA = fila.Cell(listaCols(Variables.TIPO_ROZA)).Value.ToString.Trim
                    lEstiXlsDeta.TIPO_TRANSPORTE = fila.Cell(listaCols(Variables.TIPO_TRANSPORTE)).Value.ToString.Trim
                    lEstiXlsDeta.TIPO_QUEMA = fila.Cell(listaCols(Variables.TIPO_QUEMA)).Value.ToString.Trim
                    lEstiXlsDeta.MAD_APLICAR = fila.Cell(listaCols(Variables.MADURANTE_APLICADO)).Value.ToString.Trim
                    If IsNumeric(fila.Cell(listaCols(Variables.MADURANTE_APLICADO_DOSIS)).Value) Then
                        lEstiXlsDeta.MAD_DOSIS = Convert.ToDecimal(fila.Cell(listaCols(Variables.MADURANTE_APLICADO_DOSIS)).Value)
                    End If
                    If IsDate(fila.Cell(listaCols(Variables.FECHA_APLICACION)).Value) Then
                        lEstiXlsDeta.MAD_FECHA_APLI = Convert.ToDateTime(fila.Cell(listaCols(Variables.FECHA_APLICACION)).Value)
                    End If
                    lEstiXlsDeta.CANA_VARIEDAD = fila.Cell(listaCols(Variables.CANA_VARIEDAD)).Value.ToString.Trim

                    lEstiXlsDeta.CONCEPTO = fila.Cell(listaCols(Variables.CONCEPTO)).Value.ToString.Trim
                    lEstiXlsDeta.EQUIPO_ANTERIOR = fila.Cell(listaCols(Variables.EQUIPO_ANTERIOR)).Value.ToString.Trim
                    If IsNumeric(fila.Cell(listaCols(Variables.AREA_ANTERIOR)).Value) Then
                        lEstiXlsDeta.AREA_ANTERIOR = Convert.ToDecimal(fila.Cell(listaCols(Variables.AREA_ANTERIOR)).Value)
                    End If
                    If IsNumeric(fila.Cell(listaCols(Variables.MAD_APLI_DOSIS_ACTUAL)).Value) Then
                        lEstiXlsDeta.MAD_APLI_DOSIS_ACTUAL = Convert.ToDecimal(fila.Cell(listaCols(Variables.MAD_APLI_DOSIS_ACTUAL)).Value)
                    End If
                    lEstiXlsDeta.EQUIPO_ACTUAL = fila.Cell(listaCols(Variables.EQUIPO_ACTUAL)).Value.ToString.Trim
                    lEstiXlsDeta.ACCESLOTE_ANT = sAccesLoteZafraAntetior

                    lEstiXlsDeta.GRUPO_Z1 = fila.Cell(listaCols(Variables.GRUPO_Z1)).Value.ToString.Trim
                    lEstiXlsDeta.HA_Z1 = Convert.ToDecimal(fila.Cell(listaCols(Variables.HA_Z1)).Value)
                    lEstiXlsDeta.TC_Z1 = Convert.ToDecimal(fila.Cell(listaCols(Variables.TC_Z1)).Value)
                    lEstiXlsDeta.TCH_Z1 = Convert.ToInt32(fila.Cell(listaCols(Variables.TCH_Z1)).Value)
                    lEstiXlsDeta.GRUPO_Z2 = fila.Cell(listaCols(Variables.GRUPO_Z2)).Value.ToString.Trim
                    lEstiXlsDeta.HA_EFEC_Z2 = Convert.ToDecimal(fila.Cell(listaCols(Variables.HA_EFEC_Z2)).Value)
                    lEstiXlsDeta.TCH_Z2 = Convert.ToInt32(fila.Cell(listaCols(Variables.TCH_Z2)).Value)
                    lEstiXlsDeta.TC_Z2 = Convert.ToDecimal(fila.Cell(listaCols(Variables.TC_Z2)).Value)
                    bEstiXlsDeta.ActualizarESTICANA_XLS_DETA(lEstiXlsDeta)
                End If
            Next

            lRet = bLotesCosecha.Actualizar_LOTES_COSECHA_Import_Excel(idZafra, idEncaEstiXls)
            If lRet <> "" Then
                lRet = "Error en SP ACTUALIZAR_LOTES_COSECHA_IMPORT_EXCEL: " + lRet
                lResultado = New KeyValuePair(Of Integer, String)(-1, lRet)
                Return lResultado
            End If

            lResultado = New KeyValuePair(Of Integer, String)(0, "Información subida al sistema exitosamente")
            Return lResultado

        Catch ex As Exception
            lResultado = New KeyValuePair(Of Integer, String)(-1, ex.Message)
            Return lResultado

        End Try
    End Function


    'Devuelve una coleccion de pares (clave/valor) siendo la clave el Nombre de columna del Excel a importar y valor el índice de la columna de Excel
    Private Function ObtenerColumnasProcesar(ByVal z1 As String, ByVal z2 As String, ByVal filaEncabezado As IXLRangeRow) As Dictionary(Of String, Integer)
        Dim lista As New Dictionary(Of String, Integer)
        Dim listaNomColu As New List(Of String)
        Dim i As Integer

        'Asignar a "Variables" los nombres de columna únicos (solo columnas que importaran datos) 
        listaNomColu.Add(z2 & " ACCESLOTE")
        Variables.ACCESLOTE = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add("OBSERVACIONES PRODUCCION INTERNA GRUPO JD")
        Variables.OBSERVACIONES_PRODUCCION_INTERNA_GRUPO_JD = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add("OBSERVACIONES PERSONAL TECNICO")
        Variables.OBSERVACIONES_PERSONAL_TECNICO = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add("AREA PERDIDA")
        Variables.AREA_PERDIDA = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add(z2 & " TC PERDIDAS")
        Variables.TC_PERDIDAS = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add("RENOVACION")
        Variables.RENOVACION = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add("SIEMBRAS NUEVAS")
        Variables.SIEMBRAS_NUEVAS = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add("PROYECCION DE SIEMBRA")
        Variables.PROYECCION_DE_SIEMBRA = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add("PENDIENTE DE CONTRATAR MZ")
        Variables.PENDIENTE_DE_CONTRATAR_MZ = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add("PENDIENTE DE CONTRATAR TC")
        Variables.PENDIENTE_DE_CONTRATAR_TC = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add("SEMILLA MZ")
        Variables.SEMILLA_MZ = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add("SEMILLA TC")
        Variables.SEMILLA_TC = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add(z2 & " MZ ESTICAÑA")
        Variables.MZ_ESTICANA = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add(z2 & " TC/MZ ESTICAÑA")
        Variables.TC_MZ_ESTICANA = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add(z2 & " TOTAL TC ESTICAÑA")
        Variables.TOTAL_TC_ESTICANA = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add(z1 & " MADURANTE APLICADO")
        Variables.MADURANTE_APLICADO = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add(z1 & " MADURANTE APLICADO DOSIS")
        Variables.MADURANTE_APLICADO_DOSIS = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add(z1 & " FECHA APLICACION")
        Variables.FECHA_APLICACION = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add(z2 & " ZONA")
        Variables.ZONA = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add("TIPO ROZA")
        Variables.TIPO_ROZA = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add("TIPO TRANSPORTE")
        Variables.TIPO_TRANSPORTE = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add("TIPO QUEMA")
        Variables.TIPO_QUEMA = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add("CAÑA VARIEDAD")
        Variables.CANA_VARIEDAD = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add("CONCEPTO")
        Variables.CONCEPTO = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add(z1 & " EQUIPO")
        Variables.EQUIPO_ANTERIOR = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add(z1 & " AREA")
        Variables.AREA_ANTERIOR = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add(z2 & " MADURANTE APLICADO DOSIS")
        Variables.MAD_APLI_DOSIS_ACTUAL = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add(z2 & " EQUIPO")
        Variables.EQUIPO_ACTUAL = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add("ACCESLOTE")
        Variables.ACCESLOTE_ANT = listaNomColu(listaNomColu.Count - 1)

        listaNomColu.Add(z1 & " GRUPO")
        Variables.GRUPO_Z1 = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add(z1 & " HA")
        Variables.HA_Z1 = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add(z1 & " TC")
        Variables.TC_Z1 = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add(z1 & " TCH")
        Variables.TCH_Z1 = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add(z2 & " GRUPO")
        Variables.GRUPO_Z2 = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add(z2 & " HA EFECTIVAS")
        Variables.HA_EFEC_Z2 = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add(z2 & " TCH")
        Variables.TCH_Z2 = listaNomColu(listaNomColu.Count - 1)
        listaNomColu.Add(z2 & " TC")
        Variables.TC_Z2 = listaNomColu(listaNomColu.Count - 1)

        For Each celda As IXLCell In filaEncabezado.Cells
            i += 1
            If listaNomColu.Contains(celda.Value.ToString) Then
                lista.Add(celda.Value.ToString, i)
            End If
        Next
        Return lista
    End Function

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

    Private Structure VariablesXLSX
        Public ACCESLOTE As String
        Public OBSERVACIONES_PRODUCCION_INTERNA_GRUPO_JD As String
        Public OBSERVACIONES_PERSONAL_TECNICO As String
        Public AREA_PERDIDA As String
        Public TC_PERDIDAS As String
        Public RENOVACION As String
        Public SIEMBRAS_NUEVAS As String
        Public PROYECCION_DE_SIEMBRA As String
        Public PENDIENTE_DE_CONTRATAR_MZ As String
        Public PENDIENTE_DE_CONTRATAR_TC As String
        Public SEMILLA_MZ As String
        Public SEMILLA_TC As String
        Public MZ_ESTICANA As String
        Public TC_MZ_ESTICANA As String
        Public TOTAL_TC_ESTICANA As String
        Public MADURANTE_APLICADO As String
        Public MADURANTE_APLICADO_DOSIS As String
        Public FECHA_APLICACION As String
        Public ZONA As String
        Public TIPO_ROZA As String
        Public TIPO_TRANSPORTE As String
        Public TIPO_QUEMA As String
        Public CANA_VARIEDAD As String

        Public CONCEPTO As String
        Public EQUIPO_ANTERIOR As String
        Public AREA_ANTERIOR As String
        Public MAD_APLI_DOSIS_ACTUAL As String
        Public EQUIPO_ACTUAL As String
        Public ACCESLOTE_ANT As String

        Public GRUPO_Z1 As String
        Public HA_Z1 As String
        Public TC_Z1 As String
        Public TCH_Z1 As String
        Public GRUPO_Z2 As String
        Public HA_EFEC_Z2 As String
        Public TCH_Z2 As String
        Public TC_Z2 As String
    End Structure

    Protected Sub btnDescargarCosecha_Click(sender As Object, e As EventArgs) Handles btnDescargarCosecha.Click
        Me.DescargaLibroExcel()
    End Sub
End Class
