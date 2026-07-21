Imports SISPACAL.RL
Imports SISPACAL.EL.Enumeradores

Public Class frmReporteDevExpress

    Public Sub New(ByVal ID_CATORCENA As Integer, ByVal ID_TIPO_PLANILLA As Integer, ByVal TIPO_DOCUMENTO As Integer, ByVal ID_COMPROB_CONCE As Integer, ByVal NO_DOCTO_INI As Integer, ByVal NO_DOCTO_FIN As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Select Case TIPO_DOCUMENTO
            Case 1
                Dim lReporte As ComprobanteRetencionContribuyente = New ComprobanteRetencionContribuyente
                lReporte.Cargar(ID_CATORCENA, ID_TIPO_PLANILLA, TiposComprobantes.ComprobanteRetencion, 1, ID_COMPROB_CONCE, NO_DOCTO_INI, NO_DOCTO_FIN)
                Me.DocumentViewer1.DocumentSource = lReporte
                lReporte.CreateDocument()

            Case 2
                Dim lReporte As ComprobanteRetencionNoContribuyente = New ComprobanteRetencionNoContribuyente
                lReporte.Cargar(ID_CATORCENA, ID_TIPO_PLANILLA, TiposComprobantes.ComprobanteRetencion, 0, ID_COMPROB_CONCE, NO_DOCTO_INI, NO_DOCTO_FIN)
                Me.DocumentViewer1.DocumentSource = lReporte
                lReporte.CreateDocument()

            Case 3
                Dim lReporte As CCFCana = New CCFCana
                lReporte.Cargar(ID_CATORCENA, ID_TIPO_PLANILLA, TiposComprobantes.ComprobanteCreditoFiscal, 1, ID_COMPROB_CONCE, NO_DOCTO_INI, NO_DOCTO_FIN)
                Me.DocumentViewer1.DocumentSource = lReporte
                lReporte.CreateDocument()

            Case 4
                Dim lReporte As FacturaCana = New FacturaCana
                lReporte.Cargar(ID_CATORCENA, ID_TIPO_PLANILLA, TiposComprobantes.Factura, 0, ID_COMPROB_CONCE, NO_DOCTO_INI, NO_DOCTO_FIN)
                Me.DocumentViewer1.DocumentSource = lReporte
                lReporte.CreateDocument()

            Case 5
                If ID_TIPO_PLANILLA = TipoPlanilla.Cañeros OrElse ID_TIPO_PLANILLA = TipoPlanilla.ComplementoValorFinalPago OrElse ID_TIPO_PLANILLA = TipoPlanilla.AnticipoCaneros OrElse _
                    ID_TIPO_PLANILLA = TipoPlanilla.IncentivoProductores Then
                    Dim lReporte As SujetoExcluidoNoContribuyenteCana = New SujetoExcluidoNoContribuyenteCana
                    lReporte.Cargar(ID_CATORCENA, ID_TIPO_PLANILLA, TiposComprobantes.FacturaSujetoExcluido, 0, ID_COMPROB_CONCE, NO_DOCTO_INI, NO_DOCTO_FIN)
                    Me.DocumentViewer1.DocumentSource = lReporte
                    lReporte.CreateDocument()

                ElseIf ID_TIPO_PLANILLA = TipoPlanilla.Transportistas Then
                    Dim lReporte As SujetoExcluidoNoContribuyenteTransporte = New SujetoExcluidoNoContribuyenteTransporte
                    lReporte.Cargar(ID_CATORCENA, ID_TIPO_PLANILLA, TiposComprobantes.FacturaSujetoExcluido, 0, ID_COMPROB_CONCE, NO_DOCTO_INI, NO_DOCTO_FIN)
                    Me.DocumentViewer1.DocumentSource = lReporte
                    lReporte.CreateDocument()
                End If

            Case 6
                Dim lReporte As CCFCana = New CCFCana
                lReporte.Cargar(ID_CATORCENA, ID_TIPO_PLANILLA, TiposComprobantes.ComprobanteCreditoFiscal, 1, ID_COMPROB_CONCE, NO_DOCTO_INI, NO_DOCTO_FIN)
                Me.DocumentViewer1.DocumentSource = lReporte
                lReporte.CreateDocument()

            Case 7
                Dim lReporte As FacturaCana = New FacturaCana
                lReporte.Cargar(ID_CATORCENA, ID_TIPO_PLANILLA, TiposComprobantes.Factura, 0, ID_COMPROB_CONCE, NO_DOCTO_INI, NO_DOCTO_FIN)
                Me.DocumentViewer1.DocumentSource = lReporte
                lReporte.CreateDocument()
        End Select

    End Sub
End Class