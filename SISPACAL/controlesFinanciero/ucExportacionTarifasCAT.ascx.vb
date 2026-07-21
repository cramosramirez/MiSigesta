
Imports System.Data
Imports System.IO
Imports ClosedXML.Excel
Imports SISPACAL.BL
Imports SISPACAL.EL

Partial Class controlesFinanciero_ucExportacionTarifasCAT
    Inherits ucBase

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

    Private Sub controlesFinanciero_ucExportacionTarifasCAT_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
            If lZafra IsNot Nothing Then Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
            Me.spePRECORTE.Text = ""
            Me.Inicializar()
        End If
    End Sub

    Private Function Exportar_a_Excel() As KeyValuePair(Of Integer, String)
        Dim libro As New XLWorkbook
        Dim bLotesCosecha As New cLOTES_COSECHA
        Dim lResultado As KeyValuePair(Of Integer, String)
        Dim ds As DataSet
        Dim hoja As IXLWorksheet
        Dim lZafra As ZAFRA
        Dim iCorte As Integer
        Dim nombreHoja As String

        Try
            If Me.cbxZAFRA.Value Is Nothing Then
                lResultado = New KeyValuePair(Of Integer, String)(1, "Seleccione una zafra.")
                Return lResultado
            End If
            If Me.spePRECORTE.Text = "" Then
                lResultado = New KeyValuePair(Of Integer, String)(1, "Ingrese el numero de precorte (Corte en ejecución).")
                Return lResultado
            End If

            lZafra = (New cZAFRA).ObtenerZAFRA(Me.cbxZAFRA.Value)
            iCorte = Convert.ToInt32(Me.spePRECORTE.Value)


            ' ***********************************
            '          HOJA TARIFA FLETE
            ' ***********************************
            nombreHoja = "TARIFA_FLETE"
            ds = bLotesCosecha.execXLS_APLICACION_TARIFA_FLETE_PRECORTE(lZafra.ID_ZAFRA, iCorte)
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                hoja = libro.Worksheets.Add(ds.Tables(0), nombreHoja)
                'hoja.ColumnsUsed().AdjustToContents()

            End If
            ' ***********************************
            '          HOJA TARIFA CARGA-COSECHA
            ' ***********************************
            nombreHoja = "TARIFA_CARGA_COSECHA"
            ds = bLotesCosecha.execXLS_APLICACION_TARIFA_CARGA_COSECHA_PRECORTE(lZafra.ID_ZAFRA, iCorte)
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                hoja = libro.Worksheets.Add(ds.Tables(0), nombreHoja)
                'hoja.ColumnsUsed().AdjustToContents()
            End If

            LIBRO_EXCEL = libro

            lResultado = New KeyValuePair(Of Integer, String)(0, "Archivo generado con exito.")
            Return lResultado

        Catch ex As Exception
            lResultado = New KeyValuePair(Of Integer, String)(-1, "Error al generar archivo de tarifas: " & ex.Message.ToString)
            Return lResultado

        End Try
    End Function

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

    Private Sub DescargaLibroExcel()
        Dim memStream As MemoryStream
        Dim libro As XLWorkbook = Me.LIBRO_EXCEL
        Dim nombreArchivo As String
        Dim lZafra As ZAFRA
        Dim iCorte As Integer

        If libro IsNot Nothing Then
            lZafra = (New cZAFRA).ObtenerZAFRA(Me.cbxZAFRA.Value)
            iCorte = Convert.ToInt32(Me.spePRECORTE.Value)
            nombreArchivo = "ZAFRA " & lZafra.NOMBRE_ZAFRA.Replace("/", "-") & " PRECORTE No " & iCorte.ToString & " APLICACION DE TARIFAS AL " & Now.ToString("ddMMyyyy HH_mm_ss") & ".xlsx"

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

    Protected Sub btnDescargarCosecha_Click(sender As Object, e As EventArgs) Handles btnDescargarCosecha.Click
        Me.DescargaLibroExcel()
    End Sub
End Class
