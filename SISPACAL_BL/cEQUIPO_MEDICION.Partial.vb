Imports System.Text

Partial Public Class cEQUIPO_MEDICION

    '   Personalizar procesamiento de lectura de acuerdo a cada equipo
    '   tomar como base la tabla: EQUIPO_MEDICION
    Public Function ProcesarLectura(ByVal ID_EQUIPO As Integer, ByVal LECTURA As String, Optional BRIX As Decimal = 0) As List(Of Decimal)
        Dim listaValores As New List(Of Decimal)
        Dim lResult As String
        Dim lArreglo() As String
        Dim densidad As Integer = 0
        Dim pesoesp As Decimal = 0
        Dim polCorregido As Decimal = 0
        Dim polLectura As Decimal = 0

        Try
            LECTURA = Trim(LECTURA)
            Select Case ID_EQUIPO
                Case 1  ' Ohaus Bagazo
                    lResult = Trim(Replace(LECTURA, "g", ""))
                    listaValores.Add(Convert.ToDecimal(lResult))
                Case 2 ' Anton Paar/Polarimetro
                    lArreglo = LECTURA.Split(",")
                    polLectura = Convert.ToDecimal(lArreglo(2))
                    densidad = Convert.ToInt32(Math.Round(Convert.ToDecimal(lArreglo(5)), 0)) * 10 + 1
                    pesoesp = (New cAJUSTE_POL).ObtenerAJUSTE_POL(densidad).PESOESP
                    polCorregido = (Convert.ToDecimal(lArreglo(2)) * 26D) / (99.718D * pesoesp)

                    listaValores.Add(Math.Round(polCorregido, 2))
                    listaValores.Add(Convert.ToDecimal(lArreglo(5)))
                    listaValores.Add(polLectura)
                Case 3
                    listaValores.Add(Convert.ToDecimal(LECTURA))
                Case 4
                    If BRIX > 0 Then
                        polLectura = ExtraerCantidad(Left(LECTURA, 7))
                        densidad = Convert.ToInt32(Math.Round(BRIX, 0)) * 10 + 1
                        pesoesp = (New cAJUSTE_POL).ObtenerAJUSTE_POL(densidad).PESOESP
                        polCorregido = (polLectura * 26D) / (99.718D * pesoesp)

                        listaValores.Add(polCorregido)
                        listaValores.Add(polLectura)
                    Else
                        listaValores.Add(Convert.ToDecimal(LECTURA))
                    End If
                Case 5, 6
                    listaValores.Add(Convert.ToDecimal(LECTURA.Trim))
                Case 7 ' Midt Pol
                    If BRIX > 0 Then
                        polLectura = ExtraerCantidad(LECTURA)
                        densidad = Convert.ToInt32(Math.Round(BRIX, 0)) * 10 + 1
                        pesoesp = (New cAJUSTE_POL).ObtenerAJUSTE_POL(densidad).PESOESP
                        polCorregido = (polLectura * 26D) / (99.718D * pesoesp)

                        listaValores.Add(polCorregido)
                        listaValores.Add(polLectura)
                    Else
                        listaValores.Add(Convert.ToDecimal(LECTURA))
                    End If
                Case 8 ' Midt Brix
                    listaValores.Add(Convert.ToDecimal(LECTURA))
            End Select

            Return listaValores

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Private Function ExtraerCantidad(ByVal cadena As String) As Decimal
        Dim arreglo() As Char = cadena.ToCharArray
        Dim lRet As New StringBuilder

        For i As Integer = 0 To arreglo.Length - 1
            If Char.IsDigit(arreglo(i)) OrElse arreglo(i) = "."c Then
                lRet.Append(arreglo(i))
            End If
        Next
        If lRet.Length > 0 Then
            Return Convert.ToDecimal(lRet.ToString)
        Else
            Return 0
        End If
    End Function
End Class
