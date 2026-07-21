Imports System.IO
Imports System.Configuration
Imports System.Configuration.ConfigurationManager
Public Class cCREAR_ARCHIVO_LOG
    Const DIRECTORIO_ARCHIVO_R As String = "DIRECTORIO_RECHAZOS"
    Public RutaRechazo As String
    Public DIRECTORIO_ARCHIVO As String

    Public Enum Direccion
        Input = 0
        Output = 1
        Desconocido = 2
    End Enum
    Public Sub crea_archivo(ByVal strArchivo As String, ByVal strMetodo As String, ByVal strXML As String, ByVal direct As Direccion, ByVal strDescError As String)
        Dim strDia As String
        Dim strMes As String
        Dim strAnio As String
        Dim FechaHoy As DateTime = DateTime.Now()
        Dim ruta As String
        Dim escritor As StreamWriter
        Dim strTextoFinal As String
        Dim strInput As String

        strDia = FechaHoy.Day.ToString
        strMes = FechaHoy.Month.ToString
        strAnio = FechaHoy.Year.ToString

        'Direccion 0 - Entrada ; 1 - Salida

        ruta = DIRECTORIO_ARCHIVO & "\" & strAnio

        'Directorio para el Año

        If Not Directory.Exists(ruta) Then
            Directory.CreateDirectory(ruta)
            ruta = ruta & "\" & strMes
        Else
            ruta = ruta & "\" & strMes
        End If

        'Directorio para el Mes
        If Not Directory.Exists(ruta) Then
            Directory.CreateDirectory(ruta)
            ruta = ruta & "\" & strDia
        Else
            ruta = ruta & "\" & strDia
        End If

        'Directorio par el dia
        If Not Directory.Exists(ruta) Then
            Directory.CreateDirectory(ruta)
            ruta = ruta & "\" & strArchivo
        Else
            ruta = ruta & "\" & strArchivo
        End If

        Select Case direct
            Case Direccion.Input
                strInput = " - INPUT: "
            Case Direccion.Output
                strInput = " - OUTPUT: "
            Case Else
                strInput = " - DESCONOCIDO: "
        End Select

        strTextoFinal = FechaHoy.ToString("dd/MM/yyyy") & " " & FechaHoy.ToString("hh:mm:ss tt") & " - METODO: " & strMetodo & strInput & strXML

        If strDescError <> "" Then strTextoFinal = strTextoFinal & " - ERROR: " & strDescError

        escritor = File.AppendText(ruta)
        escritor.WriteLine(strTextoFinal)
        escritor.Flush()
        escritor.Close()

    End Sub

End Class
