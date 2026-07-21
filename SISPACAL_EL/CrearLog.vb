Imports System.IO

Public Class CrearLog

    Public DIRECTORIO_ARCHIVO As String


    Public Sub crea_archivo(ByVal strArchivo As String, ByVal strMetodo As String, ByVal iDireccion As Integer, ByVal strMensaje As String, ByVal strDescError As String)
        Dim strDia As String
        Dim strMes As String
        Dim strAnio As String
        Dim FechaHoy As DateTime = DateTime.Now()
        Dim ruta As String
        Dim escritor As StreamWriter
        Dim strTextoFinal As String
        Dim strInput As String
        Dim strArchivoHoras As String = getFileName(strArchivo)

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
            ruta = ruta & "\" & strArchivoHoras
        Else
            ruta = ruta & "\" & strArchivoHoras
        End If

        Select Case iDireccion
            Case 0
                strInput = " - INPUT: "
            Case 1
                strInput = " - OUTPUT: "
            Case Else
                strInput = " - DESCONOCIDO: "
        End Select

        strTextoFinal = FechaHoy.ToString("dd/MM/yyyy HH:mm:ss") & " - METODO: " & strMetodo & strInput & strMensaje & " - USUARIO: " & Utilerias.ObtenerUsuario

        If strDescError <> "" Then strTextoFinal = strTextoFinal & " - ERROR: " & strDescError

        escritor = File.AppendText(ruta)
        escritor.WriteLine(strTextoFinal)
        escritor.Flush()
        escritor.Close()

    End Sub

    Private Shared Function getFileName(ByVal nombreArchivo As String) As String
        Dim hora As Integer = DateTime.Now.Hour
        Dim inferior, superior As Integer
        Dim limiteInferior, limiteSuperior As String

        If hora Mod 2 = 0 Then
            If hora = 24 Then
                inferior = 0
            Else
                inferior = hora
            End If
        Else
            inferior = hora - 1
        End If
        superior = inferior + 2

        limiteInferior = inferior.ToString("#0")
        limiteSuperior = superior.ToString("#0")

        Return String.Format("{0} {1}-{2}Hrs.txt", Replace(nombreArchivo, ".txt", ""), limiteInferior, limiteSuperior)
    End Function
End Class

