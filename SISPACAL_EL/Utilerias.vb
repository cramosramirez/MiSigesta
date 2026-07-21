Imports System.Text
Imports SISPACAL.EL.Enumeradores
Imports System.Security.Cryptography

Public Class Utilerias
    Private Const TipoAlgoritmo As String = "SHA1"

    Public Shared ReadOnly Property TasaIva() As Decimal
        Get
            Return 0.13
        End Get
    End Property

    Public Shared ReadOnly Property ImpuestoCESC() As Decimal
        Get
            Return 0.05
        End Get
    End Property

    Public Shared Function ObtenerUsuario() As String
        Return System.Threading.Thread.CurrentPrincipal.Identity.Name
    End Function


    Public Shared Function EsDADA_Y_CIA(ByVal nombre As String) As Boolean
        If nombre.Contains("DADA Y CIA") Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function EsNumeroEntero(ByVal cadena As String) As Boolean
        If Not IsNumeric(cadena) Then
            Return False
        End If
        If Not (Val(cadena) Mod 1) = 0 Then
            Return False
        End If
        Return True
    End Function

    Public Shared Function ObtenerEdad(ByVal fechaNac As DateTime, Optional ByVal fechaActual As DateTime = #12:00:00 AM#) As Int32
        Dim edad As Int32
        Dim hoy As Date = Today

        If fechaActual <> #12:00:00 AM# Then
            hoy = fechaActual
        End If

        If fechaNac >= hoy Then Return 0

        edad = hoy.Year - fechaNac.Year
        If fechaNac.Month > hoy.Month Then
            edad -= 1
        ElseIf fechaNac.Month = hoy.Month Then
            If fechaNac.Day > hoy.Day Then
                edad -= 1
            End If
        End If

        Return edad
    End Function

    Public Shared Function FormatoDecimal(ByVal valor As Decimal, Optional numDecimales As Integer = 2) As String
        If numDecimales = 0 Then
            Return valor.ToString("###,###,##0")
        Else
            Return valor.ToString("###,###,##0" + "." + RellenarDerecha("", numDecimales))
        End If
    End Function

    Public Shared Function NombreMes(ByVal mes As Int32, Optional EnMinuscula As Boolean = False) As String
        Select Case mes
            Case 1
                Return If(EnMinuscula, "Enero", "ENERO")
            Case 2
                Return If(EnMinuscula, "Febrero", "FEBRERO")
            Case 3
                Return If(EnMinuscula, "Marzo", "MARZO")
            Case 4
                Return If(EnMinuscula, "Abril", "ABRIL")
            Case 5
                Return If(EnMinuscula, "Mayo", "MAYO")
            Case 6
                Return If(EnMinuscula, "Junio", "JUNIO")
            Case 7
                Return If(EnMinuscula, "Julio", "JULIO")
            Case 8
                Return If(EnMinuscula, "Agosto", "AGOSTO")
            Case 9
                Return If(EnMinuscula, "Septiembre", "SEPTIEMBRE")
            Case 10
                Return If(EnMinuscula, "Octubre", "OCTUBRE")
            Case 11
                Return If(EnMinuscula, "Noviembre", "NOVIEMBRE")
            Case 12
                Return If(EnMinuscula, "Diciembre", "DICIEMBRE")
            Case Else
                Return ""
        End Select
    End Function

    Public Shared Function EsDUI(ByVal dui As String) As Boolean
        Dim digitos As New List(Of Integer)
        Dim suma As String
        Dim digitoVerificador As String
        Dim lRet As Int32

        If dui.Length <> 9 Then
            Return False
        End If
        digitos.Add(CInt(dui.Substring(0, 1)) * 9)
        digitos.Add(CInt(dui.Substring(1, 1)) * 8)
        digitos.Add(CInt(dui.Substring(2, 1)) * 7)
        digitos.Add(CInt(dui.Substring(3, 1)) * 6)
        digitos.Add(CInt(dui.Substring(4, 1)) * 5)
        digitos.Add(CInt(dui.Substring(5, 1)) * 4)
        digitos.Add(CInt(dui.Substring(6, 1)) * 3)
        digitos.Add(CInt(dui.Substring(7, 1)) * 2)
        digitos.Add(CInt(dui.Substring(8, 1)))
        suma = Convert.ToString(digitos(0) + digitos(1) + digitos(2) + digitos(3) + digitos(4) + digitos(5) + digitos(6) + digitos(7))

        digitoVerificador = suma.Substring(suma.Length - 1, 1)
        If Convert.ToInt32(digitoVerificador) = 0 Then
            lRet = 0
        Else
            lRet = 10 - Convert.ToInt32(digitoVerificador)
        End If
        If lRet = digitos(8) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function EsNIT(ByVal nit As String) As Boolean
        Dim lValor As String
        Dim lSuma As Int32
        Dim lDigVer As Int32
        Dim lFactor As Int32
        Dim lResiduo As Int32

        If nit.Length <> 14 Then
            Return False
        End If
        lValor = nit.Substring(0, 13)

        If Convert.ToInt32(lValor.Substring(10, 3)) <= 100 Then
            For i As Integer = 1 To 13
                lSuma += (Convert.ToInt32(lValor.Substring(i - 1, 1)) * (15 - i))
            Next
            lDigVer = lSuma Mod 11
            If lDigVer = 10 Then lDigVer = 0
        Else
            For i As Integer = 1 To 13
                lFactor = (3 + 6 * Math.Truncate((i + 4) / 6)) - i
                lSuma += (Convert.ToInt32(lValor.Substring(i - 1, 1)) * lFactor)
            Next

            lResiduo = lSuma Mod 11
            If lResiduo > 1 Then lDigVer = 11 - lResiduo Else lDigVer = 0
        End If

        If lDigVer.ToString = nit.Substring(13, 1) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function NombreTipoContribuyente(ByVal tipo As Int32) As String
        Select Case tipo
            Case Enumeradores.TipoContribuyente.NoContribuyente
                Return "NO CONTRIBUYENTE"
            Case Enumeradores.TipoContribuyente.Contribuyente
                Return "CONTRIBUYENTE"
            Case Enumeradores.TipoContribuyente.GranContribuyente
                Return "GRAN CONTRIBUYENTE"
            Case Else
                Return ""
        End Select
    End Function

    Public Shared Function NombreEstadoSolicAgricola(ByVal tipo As Int32) As String
        Select Case tipo
            Case Enumeradores.EstadoSolicAgricola.Pendiente
                Return "PENDIENTE"
            Case Enumeradores.EstadoSolicAgricola.Aceptada
                Return "ACEPTADA"
            Case Enumeradores.EstadoSolicAgricola.Anulada
                Return "ANULADA"
            Case Enumeradores.EstadoSolicAgricola.Finalizada
                Return "FINALIZADA"
            Case Else
                Return ""
        End Select
    End Function

    Public Shared Function NombreCondicionCompra(ByVal tipo As Int32) As String
        Select Case tipo
            Case Enumeradores.CondicionCompra.Credito
                Return "CREDITO"
            Case Enumeradores.CondicionCompra.Contado
                Return "CONTADO"
            Case Enumeradores.CondicionCompra.Consignacion
                Return "CONSIGNACION"
            Case Else
                Return ""
        End Select
    End Function

    Public Shared Function FormatearNIT(ByVal cadena As String) As String
        cadena = cadena.Trim.Replace("-", "")
        If cadena.Length = 14 Then
            Dim nit As New StringBuilder
            nit.Append(cadena.Substring(0, 4))
            nit.Append("-")
            nit.Append(cadena.Substring(4, 6))
            nit.Append("-")
            nit.Append(cadena.Substring(10, 3))
            nit.Append("-")
            nit.Append(cadena.Substring(13, 1))
            Return nit.ToString
        Else
            Return cadena
        End If
    End Function

    Public Shared Function FormatearDUI(ByVal cadena As String) As String
        cadena = cadena.Trim.Replace("-", "")
        If cadena.Length = 9 Then
            Dim dui As New StringBuilder
            dui.Append(cadena.Substring(0, 8))
            dui.Append("-")
            dui.Append(cadena.Substring(8, 1))
            Return dui.ToString
        Else
            Return cadena
        End If
    End Function

    Public Shared Function FormatearCODIPROVEEDOR(ByVal cadena As Integer) As String
        If cadena.ToString.Length >= 10 Then
            Return cadena.ToString
        End If
        Return RellenarIzquierda(cadena.ToString, 6) + RellenarDerecha("", 4)
    End Function

    Public Shared Function CODICONTRATOsinFormato(ByVal cadena As String) As Integer
        If cadena.Length <= 9 Then
            Return 0
        End If
        Return Convert.ToInt32(cadena.Substring(9, 4))
    End Function

    Public Shared Function RecuperarCODIPROVEE(ByVal cadena As String) As String
        If cadena.ToString.Length = 10 Then
            Return CInt(cadena.Substring(0, 6)).ToString
        Else
            Return ""
        End If
    End Function

    Public Shared Function RecuperarCODISOCIO(ByVal cadena As String) As String
        If cadena.Length = 10 Then
            If cadena.Substring(6, 4) = FormatoCODISOCIO(0) Then
                Return ""
            Else
                Return CInt(cadena.Substring(6, 4)).ToString
            End If
        Else
            Return ""
        End If
    End Function

    Public Shared Function FormatoCODIPROVEE(ByVal cadena As Integer) As String
        If cadena.ToString.Length >= 6 Then
            Return cadena.ToString
        End If
        Return RellenarIzquierda(cadena.ToString, 6)
    End Function

    Public Shared Function FormatoCODISOCIO(ByVal cadena As Integer) As String
        If cadena.ToString.Length >= 4 Then
            Return cadena.ToString
        End If
        Return RellenarIzquierda(cadena.ToString, 4)
    End Function

    Public Shared Function RellenarIzquierda(ByVal cadena As String, ByVal longitud As Integer, Optional caracter As String = "0") As String
        cadena = cadena.Trim
        If longitud < cadena.Length Then
            Return cadena
        End If
        Return Strings.Replace(Strings.Space(longitud - cadena.Length), " ", caracter) + cadena
    End Function

    Public Shared Function RellenarDerecha(ByVal cadena As String, ByVal longitud As Integer, Optional caracter As String = "0") As String
        cadena = cadena.Trim
        If longitud < cadena.Length Then
            Return cadena
        End If
        Return cadena + Strings.Replace(Strings.Space(longitud - cadena.Length), " ", caracter)
    End Function

    Public Shared Function CifrarClave(ByVal clave As String) As String
        Dim algoritmo As HashAlgorithm = HashAlgorithm.Create(TipoAlgoritmo)
        Dim result As Byte() = Nothing

        If algoritmo IsNot Nothing Then
            result = algoritmo.ComputeHash(Encoding.UTF8.GetBytes(clave))
        End If
        Return Convert.ToBase64String(result)
    End Function
End Class
