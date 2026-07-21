Imports SISPACAL.BL
Imports SISPACAL.EL
Imports System.Text

Public Class ContratoPersonaNatural

    Public Sub CargarDatos(ByVal CODICONTRATO As String)
        Dim sCad As StringBuilder
        Dim lContrato As CONTRATO = (New cCONTRATO).ObtenerCONTRATO(CODICONTRATO)
        Dim listaContratoZafras As listaCONTRATO_ZAFRAS = (New cCONTRATO_ZAFRAS).ObtenerListaPorCONTRATO(CODICONTRATO, False, "ID_ZAFRA")
        Dim lLotes As listaLOTES = (New cLOTES).ObtenerListaPorCONTRATO(CODICONTRATO)

        Me.CONTRATO_ZAFRATableAdapter1.SetCommandTimeOut(900000)
        Me.CONTRATO_ZAFRATableAdapter1.FillPorContrato(Me.DS_SIGESTA1.CONTRATO_ZAFRA, CODICONTRATO)

        For i As Int32 = 0 To Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows.Count - 1
            If Not IsDBNull(Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("NIT")) Then Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("NIT") = Utilerias.FormatearNIT(Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("NIT"))
            If Not IsDBNull(Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("DUI")) Then Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("DUI") = Utilerias.FormatearDUI(Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("DUI"))
            If Not IsDBNull(Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("NIT_APODERADO")) Then Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("NIT_APODERADO") = Utilerias.FormatearNIT(Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("NIT_APODERADO"))
            If Not IsDBNull(Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("DUI_APODERADO")) Then Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("DUI_APODERADO") = Utilerias.FormatearDUI(Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("DUI_APODERADO"))
        Next

        If listaContratoZafras IsNot Nothing AndAlso listaContratoZafras.Count > 0 Then
            sCad = New StringBuilder
            For i As Int32 = 0 To listaContratoZafras.Count - 1
                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(listaContratoZafras(i).ID_ZAFRA)
                sCad.Append(lZafra.NOMBRE_ZAFRA)
                If i < listaContratoZafras.Count - 1 Then
                    sCad.Append(";")
                End If
            Next
            Me.xrZafra.Text = sCad.ToString
        End If

        If lLotes IsNot Nothing AndAlso lLotes.Count > 0 Then
            Dim l As New List(Of String)
            For i As Int32 = 0 To lLotes.Count - 1
                If Not l.Contains(lLotes(i).ZONA.Trim) Then
                    l.Add(lLotes(i).ZONA.Trim)
                End If
            Next
            l.Sort()
            sCad = New StringBuilder
            For i As Int32 = 0 To l.Count - 1
                sCad.Append(l(i))
                If i < l.Count - 1 Then
                    sCad.Append(";")
                End If
            Next
            Me.xrZona.Text = sCad.ToString
        End If

        For i As Int32 = 0 To lContrato.OBSERVACIONES_CONTRATOCB.Length - 1
            If IsNumeric(lContrato.OBSERVACIONES_CONTRATOCB.Substring(i, 1)) Then
                xrOIP_Porc.Text += lContrato.OBSERVACIONES_CONTRATOCB.Substring(i, 1)
            End If
        Next
    End Sub


    Public Sub CargarDatosContratoLegal(ByVal CODICONTRATO As String)
        Dim sCad As StringBuilder
        Dim lContrato As CONTRATO_LG = (New cCONTRATO_LG).ObtenerCONTRATO_LG(CODICONTRATO)
        Dim listaContratoZafras As listaCONTRATO_ZAFRAS_LG = (New cCONTRATO_ZAFRAS_LG).ObtenerListaPorCONTRATO_LG(CODICONTRATO, False, "ID_ZAFRA")
        Dim lLotes As listaLOTES_LG = (New cLOTES_LG).ObtenerListaPorCONTRATO_LG(CODICONTRATO)

        Me.CONTRATO_ZAFRATableAdapter1.SetCommandTimeOut(900000)
        Me.CONTRATO_ZAFRATableAdapter1.FillPorContratoLegal(Me.DS_SIGESTA1.CONTRATO_ZAFRA, CODICONTRATO)

        For i As Int32 = 0 To Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows.Count - 1
            If Not IsDBNull(Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("NIT")) Then Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("NIT") = Utilerias.FormatearNIT(Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("NIT"))
            If Not IsDBNull(Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("DUI")) Then Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("DUI") = Utilerias.FormatearDUI(Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("DUI"))
            If Not IsDBNull(Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("NIT_APODERADO")) Then Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("NIT_APODERADO") = Utilerias.FormatearNIT(Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("NIT_APODERADO"))
            If Not IsDBNull(Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("DUI_APODERADO")) Then Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("DUI_APODERADO") = Utilerias.FormatearDUI(Me.DS_SIGESTA1.CONTRATO_ZAFRA.Rows(i)("DUI_APODERADO"))
        Next

        If listaContratoZafras IsNot Nothing AndAlso listaContratoZafras.Count > 0 Then
            sCad = New StringBuilder
            For i As Int32 = 0 To listaContratoZafras.Count - 1
                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(listaContratoZafras(i).ID_ZAFRA)
                sCad.Append(lZafra.NOMBRE_ZAFRA)
                If i < listaContratoZafras.Count - 1 Then
                    sCad.Append(";")
                End If
            Next
            Me.xrZafra.Text = sCad.ToString
        End If

        If lLotes IsNot Nothing AndAlso lLotes.Count > 0 Then
            Dim l As New List(Of String)
            For i As Int32 = 0 To lLotes.Count - 1
                If Not l.Contains(lLotes(i).ZONA.Trim) Then
                    l.Add(lLotes(i).ZONA.Trim)
                End If
            Next
            l.Sort()
            sCad = New StringBuilder
            For i As Int32 = 0 To l.Count - 1
                sCad.Append(l(i))
                If i < l.Count - 1 Then
                    sCad.Append(";")
                End If
            Next
            Me.xrZona.Text = sCad.ToString
        End If

        For i As Int32 = 0 To lContrato.OBSERVACIONES_CONTRATOCB.Length - 1
            If IsNumeric(lContrato.OBSERVACIONES_CONTRATOCB.Substring(i, 1)) Then
                xrOIP_Porc.Text += lContrato.OBSERVACIONES_CONTRATOCB.Substring(i, 1)
            End If
        Next
    End Sub
End Class