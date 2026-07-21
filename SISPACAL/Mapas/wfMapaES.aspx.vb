Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web
Imports System.Configuration.ConfigurationManager
Imports System.Data

Partial Class Mapas_wfMapaES
    Inherits System.Web.UI.Page

    Dim lOpciones As listaOPCION
    Dim Capas As New Dictionary(Of String, String)
    Dim CapaDepartamentos As New Dictionary(Of String, String)
    Dim CapaMunicipios As New Dictionary(Of String, String)
    Dim CapaCantones As New Dictionary(Of String, String)

    Private Sub CargarMenu()
        Dim lOpciones As listaOPCION

        If Context.User.Identity.Name = String.Empty Then
            Exit Sub
        End If
        If Utilerias.ObtenerUsuario = "jm" OrElse Utilerias.ObtenerUsuario = "chris" Then
            lOpciones = (New cOPCION).ObtenerListaPorUSUARIO(Utilerias.ObtenerUsuario, True)
        Else
            lOpciones = (New cOPCION).ObtenerListaPorUSUARIO(Utilerias.ObtenerUsuario, False)
        End If
        Me.ASPxMenu1.Items.Clear()
        If lOpciones IsNot Nothing AndAlso lOpciones.Count > 0 Then
            For Each lOpcion As OPCION In lOpciones
                If lOpcion.ID_OPCION_PADRE.Equals(-1) Then
                    Dim mnuMenuItem As New MenuItem
                    mnuMenuItem.Name = lOpcion.ID_OPCION
                    mnuMenuItem.Text = lOpcion.NOMBRE_OPCION

                    'Agregar item al menú principal
                    Me.ASPxMenu1.Items.Add(mnuMenuItem)

                    'Generar el árbol de menú
                    AddMenuItem(mnuMenuItem, lOpciones)
                End If
            Next
        End If
    End Sub

    Private Sub AddMenuItem(ByRef mnuMenuItem As MenuItem, ByVal lOpciones As listaOPCION)
        'Recorremos cada elemento de la lista para poder determinar cuales son elementos hijos
        'del menuitem dado pasado como parametro ByRef.
        For Each lOpcion As OPCION In lOpciones
            If lOpcion.ID_OPCION_PADRE.ToString.Equals(mnuMenuItem.Name) Then
                Dim mnuNewMenuItem As New MenuItem
                mnuNewMenuItem.Name = lOpcion.ID_OPCION
                mnuNewMenuItem.Text = lOpcion.NOMBRE_OPCION
                mnuNewMenuItem.NavigateUrl = lOpcion.URL

                'Agregamos el Nuevo MenuItem al MenuItem que viene de un nivel superior.
                'If mnuMenuItem.ChildItems.Count = 0 Then mnuMenuItem.Text += " >>"
                mnuMenuItem.Items.Add(mnuNewMenuItem)

                'llamada recursiva para ver si el nuevo menú ítem aun tiene elementos hijos.
                AddMenuItem(mnuNewMenuItem, lOpciones)
            End If
        Next
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarMenu()
    End Sub

    Protected Sub LoginStatus_LoggedOut(ByVal sender As Object, ByVal e As System.EventArgs)
        Session.RemoveAll()
        Session.Abandon()
    End Sub

    Protected Sub cpMapa_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cpMapa.Callback
        Dim Parametros As String()
        Parametros = e.Parameter.Split(";")
        cpMapa.JSProperties.Clear()
        If Not Me.cpMapa.JSProperties.ContainsKey("cpResultCallback") Then Me.cpMapa.JSProperties.Add("cpResultCallback", "") Else Me.cpMapa.JSProperties("cpResultCallback") = ""

        Select Case Parametros(0)
            Case "ProcesarContratos"
                Dim i As Integer = 0
                Dim j As Integer = 0
                Dim lLotes As listaLOTES
                Dim lDepartamentos As listaDEPARTAMENTO
                Dim lMunicipios As listaMUNICIPIO
                Dim strCad As StringBuilder
                Dim esDeptoContrato As Boolean
                Dim esMuniContrato As Boolean

                Capas.Add(0, "CapaDepartamentos")
                Capas.Add(1, "CapaMunicipios")
                lDepartamentos = (New cDEPARTAMENTO).ObtenerLista(False, "CODI_DEPTO", "ASC")
                For Each eDepartamento As DEPARTAMENTO In lDepartamentos
                    strCad = New StringBuilder()
                    strCad.Append(eDepartamento.CODI_DEPTO + ";")
                    strCad.Append(eDepartamento.NOMBRE_DEPTO + ";")
                    strCad.Append(";")
                    strCad.Append(";")
                    strCad.Append(eDepartamento.COORDENADAS + ";")
                    strCad.Append("2;")
                    strCad.Append("azul_oscuro;")
                    strCad.Append("1;")
                    strCad.Append("naranja;")
                    lLotes = (New cMapa).ObtenerListaPorUBICACION_GEOGRAFICA("2013/2014", eDepartamento.CODI_DEPTO, "", "")
                    If lLotes IsNot Nothing AndAlso lLotes.Count > 0 Then
                        strCad.Append("0.1;")
                        esDeptoContrato = True
                    Else
                        strCad.Append("0.0;")
                        esDeptoContrato = False
                    End If
                    strCad.Append("false;")
                    strCad.Append(";")
                    strCad.Append("D")
                    CapaDepartamentos.Add(i, strCad.ToString)

                    lMunicipios = (New cMUNICIPIO).ObtenerLista(eDepartamento.CODI_DEPTO, False, False, "CODI_MUNI", "ASC")
                    For Each eMunicipio As MUNICIPIO In lMunicipios
                        lLotes = (New cMapa).ObtenerListaPorUBICACION_GEOGRAFICA("2013/2014", eMunicipio.CODI_DEPTO, eMunicipio.CODI_MUNI, "")
                        If lLotes IsNot Nothing AndAlso lLotes.Count > 0 Then
                            esMuniContrato = True
                        Else
                            esMuniContrato = False
                        End If
                        If (eMunicipio.POSICION_GEO IsNot Nothing AndAlso eMunicipio.POSICION_GEO <> "") AndAlso esMuniContrato Then
                            strCad = New StringBuilder()
                            strCad.Append(eMunicipio.CODI_DEPTO + "." + eMunicipio.CODI_MUNI + ";")
                            strCad.Append(eMunicipio.NOMBRE_MUNI + ";")
                            strCad.Append(AppSettings("iconMapMunicipio") + ";")
                            strCad.Append(eMunicipio.POSICION_GEO + ";")
                            strCad.Append(eMunicipio.COORDENADAS + ";")
                            strCad.Append("1;")
                            strCad.Append("negro;")
                            strCad.Append("0.5;")
                            strCad.Append("gris;")
                            strCad.Append("0.0;")
                            strCad.Append("true;")
                            strCad.Append("verde;")
                            strCad.Append("M")
                            CapaMunicipios.Add(j, strCad.ToString)
                            j += 1
                        End If
                    Next
                    i += 1
                Next

                cpMapa.JSProperties.Add("cpCapas", Capas)
                cpMapa.JSProperties.Add("cpCapaDepartamentos", CapaDepartamentos)
                cpMapa.JSProperties.Add("cpCapaMunicipios", CapaMunicipios)
                Me.cpMapa.JSProperties("cpResultCallback") = "LlenarMapa"

            Case "ProcesarTipoCana"
                Dim i As Integer = 0
                Dim j As Integer = 0
                Dim lLotes As listaLOTES
                Dim lDepartamentos As listaDEPARTAMENTO
                Dim lMunicipios As listaMUNICIPIO
                Dim strCad As StringBuilder
                Dim esDeptoContrato As Boolean

                Capas.Add(0, "CapaDepartamentos")
                Capas.Add(1, "CapaMunicipios")
                lDepartamentos = (New cDEPARTAMENTO).ObtenerLista(False, "CODI_DEPTO", "ASC")
                For Each eDepartamento As DEPARTAMENTO In lDepartamentos
                    strCad = New StringBuilder()
                    strCad.Append(eDepartamento.CODI_DEPTO + ".;")
                    strCad.Append(eDepartamento.NOMBRE_DEPTO + ";")
                    strCad.Append(";")
                    strCad.Append(";")
                    strCad.Append(eDepartamento.COORDENADAS + ";")
                    strCad.Append("2;")
                    strCad.Append("azul_oscuro;")
                    strCad.Append("1;")
                    strCad.Append("naranja;")
                    lLotes = (New cMapa).ObtenerListaPorUBICACION_GEOGRAFICA("2013/2014", eDepartamento.NOMBRE_DEPTO, "", "", True)
                    If lLotes IsNot Nothing AndAlso lLotes.Count > 0 Then
                        strCad.Append("0.1;")
                        esDeptoContrato = True
                    Else
                        strCad.Append("0.0;")
                        esDeptoContrato = False
                    End If
                    strCad.Append("false;")
                    strCad.Append(";")
                    strCad.Append("D")
                    CapaDepartamentos.Add(i, strCad.ToString)

                    lMunicipios = (New cMUNICIPIO).ObtenerLista(eDepartamento.CODI_DEPTO, False, False, "CODI_MUNI", "ASC")
                    For Each eMunicipio As MUNICIPIO In lMunicipios
                        If (eMunicipio.POSICION_GEO IsNot Nothing AndAlso eMunicipio.POSICION_GEO <> "") OrElse esDeptoContrato Then
                            Dim lPorcCanaQuemada As Decimal = (New cMapa).ObtenerPorcentajeCanaQuemada(1, "", eMunicipio.NOMBRE_MUNI, "", "")
                            strCad = New StringBuilder()
                            strCad.Append(eMunicipio.CODI_DEPTO + "." + eMunicipio.CODI_MUNI + ";")
                            strCad.Append(eMunicipio.NOMBRE_MUNI + ";")
                            If eMunicipio.NOMBRE_MUNI = "SANTIAGO NONUALCO" OrElse eMunicipio.NOMBRE_MUNI = "TECOLUCA" Then
                                strCad.Append(AppSettings("iconMapCanaQuemada") + ";")
                            Else
                                strCad.Append(AppSettings("iconMapCanaCruda") + ";")
                            End If
                            strCad.Append(eMunicipio.POSICION_GEO + ";")
                            strCad.Append(eMunicipio.COORDENADAS + ";")
                            strCad.Append("1;")
                            strCad.Append("negro;")
                            strCad.Append("0.5;")
                            strCad.Append("gris;")
                            strCad.Append("0.0;")
                            strCad.Append("true;")
                            If eMunicipio.NOMBRE_MUNI = "SANTIAGO NONUALCO" OrElse eMunicipio.NOMBRE_MUNI = "TECOLUCA" Then
                                strCad.Append("rojo;")
                            Else
                                strCad.Append("azul;")
                            End If
                            strCad.Append("M")

                            CapaMunicipios.Add(j, strCad.ToString)
                            j += 1
                        End If
                    Next
                    i += 1
                Next

                cpMapa.JSProperties.Add("cpCapas", Capas)
                cpMapa.JSProperties.Add("cpCapaDepartamentos", CapaDepartamentos)
                cpMapa.JSProperties.Add("cpCapaMunicipios", CapaMunicipios)
                Me.cpMapa.JSProperties("cpResultCallback") = "LlenarMapa"

            Case "ProcesarArchivo"
                Try
                    ' Create an instance of StreamReader to read from a file.
                    Using sr As IO.StreamReader = New IO.StreamReader("C:\SOFTWARE\KML_zip_20140520084230.kml")
                        Dim CODI_DEPTO As String = ""
                        Dim CODI_MUNI As String = ""
                        Dim NOMBRE_DEPTO As String = ""
                        Dim NOMBRE_MUNI As String = ""
                        Dim COORDENADAS As String
                        Dim lRet As String
                        Dim pos As Integer
                        Dim pos2 As Integer
                        Dim line As String
                        Dim arreglo As String()


                        ' Read and display the lines from the file until the end 
                        ' of the file is reached.
                        Do
                            line = sr.ReadLine().Trim

                            'Verificar si es linea de departamento
                            If line.Contains("NOM_DPTO") AndAlso Not line.Contains("type=") Then
                                CODI_DEPTO = ""
                                CODI_MUNI = ""
                                pos = ("<SimpleData name=""NOM_DPTO"">").Length
                                pos2 = line.LastIndexOf("</SimpleData>")
                                NOMBRE_DEPTO = line.Substring(pos, line.Length - pos - ("</SimpleData>").Length).Trim

                                'Obtener el código del departamento
                                Dim lCriterios As New List(Of Criteria)
                                Dim lDepto As New DEPARTAMENTO
                                Dim lDeptos As listaDEPARTAMENTO
                                lDepto.NOMBRE_DEPTO = NOMBRE_DEPTO
                                lCriterios.Add(New Criteria("NOMBRE_DEPTO", "=", NOMBRE_DEPTO, ""))
                                lDeptos = (New cDEPARTAMENTO).ObtenerListaPorBusqueda(lDepto, lCriterios.ToArray)
                                If lDeptos IsNot Nothing AndAlso lDeptos.Count > 0 Then
                                    CODI_DEPTO = lDeptos(0).CODI_DEPTO
                                End If
                            End If
                            'Verificar si es linea de municipio
                            If line.Contains("NOM_MUN") AndAlso Not line.Contains("type=") AndAlso CODI_DEPTO <> "" Then
                                CODI_MUNI = ""
                                pos = ("<SimpleData name=""NOM_MUN"">").Length
                                pos2 = line.LastIndexOf("</SimpleData>")
                                NOMBRE_MUNI = line.Substring(pos, line.Length - pos - ("</SimpleData>").Length).Trim

                                'Obtener el código del municipio
                                Dim lCriterios As New List(Of Criteria)
                                Dim lMuni As New MUNICIPIO
                                Dim lMunis As listaMUNICIPIO
                                lMuni.CODI_DEPTO = CODI_DEPTO
                                lMuni.NOMBRE_MUNI = NOMBRE_MUNI
                                lCriterios.Add(New Criteria("CODI_DEPTO", "=", CODI_DEPTO, "AND"))
                                lCriterios.Add(New Criteria("NOMBRE_MUNI", "=", NOMBRE_MUNI, ""))
                                lMunis = (New cMUNICIPIO).ObtenerListaPorBusqueda(lMuni, lCriterios.ToArray)
                                If lMunis IsNot Nothing AndAlso lMunis.Count > 0 Then
                                    CODI_MUNI = lMunis(0).CODI_MUNI
                                End If
                            End If
                            If line.Contains("<coordinates>") AndAlso CODI_DEPTO <> "" AndAlso CODI_MUNI <> "" Then
                                Dim posicion As New StringBuilder
                                Dim lMuni As MUNICIPIO
                                Dim bMuni As New cMUNICIPIO

                                COORDENADAS = line.Substring(line.LastIndexOf("<coordinates>") + 13)
                                lRet = COORDENADAS.Remove(COORDENADAS.LastIndexOf("</coordinates>"))
                                arreglo = lRet.Split(" ")

                                For i As Integer = 0 To arreglo.Length - 1
                                    Dim elemento As String() = arreglo(i).Split(",")
                                    posicion.Append("(")
                                    posicion.Append(elemento(1))
                                    posicion.Append(",")
                                    posicion.Append(elemento(0))
                                    posicion.Append(")")
                                Next

                                lMuni = bMuni.ObtenerMUNICIPIO(CODI_DEPTO, CODI_MUNI)
                                If lMuni IsNot Nothing Then
                                    lMuni.COORDENADAS = posicion.ToString
                                End If
                                bMuni.ActualizarMUNICIPIO(lMuni)
                                CODI_DEPTO = ""
                                CODI_MUNI = ""
                            End If

                        Loop Until line Is Nothing
                        sr.Close()
                    End Using
                Catch ex As Exception
                    ' Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:")
                    Console.WriteLine(ex.Message)
                End Try
                Me.cpMapa.JSProperties("cpResultCallback") = ""

                'Try
                '    ' Create an instance of StreamReader to read from a file.
                '    Using sr As IO.StreamReader = New IO.StreamReader("C:\SOFTWARE\KML_zip_20140520084230.kml")
                '        Dim CODI_DEPTO As String = ""
                '        Dim CODI_MUNI As String = ""
                '        Dim NOMBRE_DEPTO As String = ""
                '        Dim NOMBRE_MUNI As String = ""
                '        Dim COORDENADAS As String
                '        Dim lRet As String
                '        Dim pos As Integer
                '        Dim pos2 As Integer
                '        Dim line As String
                '        Dim arreglo As String()


                '        ' Read and display the lines from the file until the end 
                '        ' of the file is reached.
                '        Do
                '            line = sr.ReadLine().Trim

                '            'Verificar si es linea de departamento
                '            If line.Contains("NOM_DPTO") AndAlso Not line.Contains("type=") Then
                '                CODI_DEPTO = ""
                '                CODI_MUNI = ""
                '                pos = ("<SimpleData name=""NOM_DPTO"">").Length
                '                pos2 = line.LastIndexOf("</SimpleData>")
                '                NOMBRE_DEPTO = line.Substring(pos, line.Length - pos - ("</SimpleData>").Length).Trim

                '                'Obtener el código del departamento
                '                Dim lCriterios As New List(Of Criteria)
                '                Dim lDepto As New DEPARTAMENTO
                '                Dim lDeptos As listaDEPARTAMENTO
                '                lDepto.NOMBRE_DEPTO = NOMBRE_DEPTO
                '                lCriterios.Add(New Criteria("NOMBRE_DEPTO", "=", NOMBRE_DEPTO, ""))
                '                lDeptos = (New cDEPARTAMENTO).ObtenerListaPorBusqueda(lDepto, lCriterios.ToArray)
                '                If lDeptos IsNot Nothing AndAlso lDeptos.Count > 0 Then
                '                    CODI_DEPTO = lDeptos(0).CODI_DEPTO
                '                End If
                '            End If
                '            'Verificar si es linea de municipio
                '            If line.Contains("NOM_MUN") AndAlso Not line.Contains("type=") AndAlso CODI_DEPTO <> "" Then
                '                CODI_MUNI = ""
                '                pos = ("<SimpleData name=""NOM_MUN"">").Length
                '                pos2 = line.LastIndexOf("</SimpleData>")
                '                NOMBRE_MUNI = line.Substring(pos, line.Length - pos - ("</SimpleData>").Length).Trim

                '                'Obtener el código del municipio
                '                Dim lCriterios As New List(Of Criteria)
                '                Dim lMuni As New MUNICIPIO
                '                Dim lMunis As listaMUNICIPIO
                '                lMuni.CODI_DEPTO = CODI_DEPTO
                '                lMuni.NOMBRE_MUNI = NOMBRE_MUNI
                '                lCriterios.Add(New Criteria("CODI_DEPTO", "=", CODI_DEPTO, "AND"))
                '                lCriterios.Add(New Criteria("NOMBRE_MUNI", "=", NOMBRE_MUNI, ""))
                '                lMunis = (New cMUNICIPIO).ObtenerListaPorBusqueda(lMuni, lCriterios.ToArray)
                '                If lMunis IsNot Nothing AndAlso lMunis.Count > 0 Then
                '                    CODI_MUNI = lMunis(0).CODI_MUNI
                '                End If
                '            End If
                '            If line.Contains("<coordinates>") AndAlso CODI_DEPTO <> "" AndAlso CODI_MUNI <> "" Then
                '                Dim posicion As New StringBuilder
                '                Dim lMuni As MUNICIPIO
                '                Dim bMuni As New cMUNICIPIO

                '                COORDENADAS = line.Substring(line.LastIndexOf("<coordinates>") + 13)
                '                lRet = COORDENADAS.Remove(COORDENADAS.LastIndexOf("</coordinates>"))
                '                arreglo = lRet.Split(" ")

                '                For i As Integer = 0 To arreglo.Length - 1
                '                    Dim elemento As String() = arreglo(i).Split(",")
                '                    posicion.Append("(")
                '                    posicion.Append(elemento(1))
                '                    posicion.Append(",")
                '                    posicion.Append(elemento(0))
                '                    posicion.Append(")")
                '                Next

                '                lMuni = bMuni.ObtenerMUNICIPIO(CODI_DEPTO, CODI_MUNI)
                '                If lMuni IsNot Nothing Then
                '                    lMuni.COORDENADAS = posicion.ToString
                '                End If
                '                bMuni.ActualizarMUNICIPIO(lMuni)
                '                CODI_DEPTO = ""
                '                CODI_MUNI = ""
                '            End If

                '        Loop Until line Is Nothing
                '        sr.Close()
                '    End Using
                'Catch ex As Exception
                '    ' Let the user know what went wrong.
                '    Console.WriteLine("The file could not be read:")
                '    Console.WriteLine(ex.Message)
                'End Try
                'Me.cpMapa.JSProperties("cpResultCallback") = ""


                'Try
                '    ' Create an instance of StreamReader to read from a file.
                '    Using sr As IO.StreamReader = New IO.StreamReader("C:\SOFTWARE\KML_zip_20140514092812.kml")
                '        Dim CODI_DEPTO As String = ""
                '        Dim COORDENADAS As String
                '        Dim lRet As String
                '        Dim pos As Integer
                '        Dim line As String
                '        Dim arreglo As String()


                '        ' Read and display the lines from the file until the end 
                '        ' of the file is reached.
                '        Do
                '            line = sr.ReadLine().Trim

                '            'Verificar si es linea de departamento
                '            If line.Contains("COD_DPTO") AndAlso Not line.Contains("type=") Then
                '                pos = line.LastIndexOf("<SimpleData name=""COD_DPTO"">")
                '                CODI_DEPTO = line.Substring(28, 2)
                '            End If
                '            If line.Contains("<coordinates>") Then
                '                Dim posicion As New StringBuilder
                '                Dim lDepto As DEPARTAMENTO
                '                Dim bDepto As New cDEPARTAMENTO

                '                COORDENADAS = line.Substring(line.LastIndexOf("<coordinates>") + 13)
                '                lRet = COORDENADAS.Remove(COORDENADAS.LastIndexOf("</coordinates>"))
                '                arreglo = lRet.Split(" ")

                '                For i As Integer = 0 To arreglo.Length - 1
                '                    Dim elemento As String() = arreglo(i).Split(",")
                '                    posicion.Append("(")
                '                    posicion.Append(elemento(1))
                '                    posicion.Append(",")
                '                    posicion.Append(elemento(0))
                '                    posicion.Append(")")
                '                Next

                '                lDepto = bDepto.ObtenerDEPARTAMENTO(CODI_DEPTO)
                '                If lDepto IsNot Nothing Then
                '                    lDepto.COORDENADAS = posicion.ToString
                '                End If
                '                bDepto.ActualizarDEPARTAMENTO(lDepto)
                '            End If

                '        Loop Until line Is Nothing
                '        sr.Close()
                '    End Using
                'Catch ex As Exception
                '    ' Let the user know what went wrong.
                '    Console.WriteLine("The file could not be read:")
                '    Console.WriteLine(ex.Message)
                'End Try
                'Me.cpMapa.JSProperties("cpResultCallback") = ""

            Case "PopupInfo"
                Dim codigo As String()
                Dim lRet As New Dictionary(Of String, Object)

                Select Case Parametros(1)
                    Case "D"
                        lRet = (New cMapa).ObtenerInfoContratadoEntregado("2013/2014", Parametros(2), "", "", "", "")
                        Dim lDepto As DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(Parametros(2))
                        Me.CargarGraficoEntregaCana("2013/2014", Parametros(2), "", "", "", "")
                        Me.CargarGraficoRendimientoCana("2013/2014", Parametros(2), "", "", "", "")
                        Me.popupInfo.HeaderText = "DEPARTAMENTO: " + lDepto.NOMBRE_DEPTO

                    Case "M"
                        codigo = Parametros(2).Split(".")
                        lRet = (New cMapa).ObtenerInfoContratadoEntregado("2013/2014", codigo(0), codigo(1), "", "", "")
                        Dim lDepto As DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(codigo(0))
                        Dim lMuni As MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(codigo(0), codigo(1))
                        Me.CargarGraficoEntregaCana("2013/2014", codigo(0), codigo(1), "", "", "")
                        Me.CargarGraficoRendimientoCana("2013/2014", codigo(0), codigo(1), "", "", "")
                        Me.popupInfo.HeaderText = "MUNICIPIO: " + lMuni.NOMBRE_MUNI + ", " + lDepto.NOMBRE_DEPTO

                    Case "C"
                        codigo = Parametros(2).Split(".")
                        lRet = (New cMapa).ObtenerInfoContratadoEntregado("2013/2014", codigo(0), codigo(1), codigo(2), "", "")
                        Dim lDepto As DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(codigo(0))
                        Dim lMuni As MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(codigo(0), codigo(1))
                        Dim lCanton As CANTON = (New cCANTON).ObtenerCANTON(codigo(0), codigo(1), codigo(2))
                        Me.CargarGraficoEntregaCana("2013/2014", codigo(0), codigo(1), codigo(2), "", "")
                        Me.CargarGraficoRendimientoCana("2013/2014", codigo(0), codigo(1), codigo(2), "", "")
                        Me.popupInfo.HeaderText = "CANTON: " + lCanton.NOMBRE_CANTON + "," + lMuni.NOMBRE_MUNI + ", " + lDepto.NOMBRE_DEPTO
                End Select

                Me.lblCaneros.Text = ""
                Me.lblContratos.Text = ""
                Me.lblLotes.Text = ""
                Me.lblArea_Contratada.Text = ""
                Me.lblTc_Mz_Contratada.Text = ""
                Me.lblTC_Contratada.Text = ""
                Me.lblArea_Censo.Text = ""
                Me.lblTc_Mz_Censo.Text = ""
                Me.lblTC_Censo.Text = ""
                Me.lblArea_Entregada.Text = ""
                Me.lblTc_Mz_Entregada.Text = ""
                Me.lblTC_Entregada.Text = ""

                If lRet IsNot Nothing Then
                    Me.lblCaneros.Text = Format(lRet("CANEROS"), "#,##0")
                    Me.lblContratos.Text = Format(lRet("CONTRATOS"), "#,##0")
                    Me.lblLotes.Text = Format(lRet("LOTES"), "#,##0")
                    Me.lblArea_Contratada.Text = Format(lRet("MZ_CONTRATADO"), "#,##0.00")
                    Me.lblTc_Mz_Contratada.Text = Format(lRet("TC_MZ_CONTRATADO"), "#,##0.00")
                    Me.lblTC_Contratada.Text = Format(lRet("TONEL_CONTRATADO"), "#,##0.00")

                    Me.lblArea_Censo.Text = Format(lRet("MZ_CENSO"), "#,##0.00")
                    Me.lblTc_Mz_Censo.Text = Format(lRet("TC_MZ_CENSO"), "#,##0.00")
                    Me.lblTC_Censo.Text = Format(lRet("TONEL_CENSO"), "#,##0.00")

                    Me.lblArea_Entregada.Text = Format(lRet("MZ_ENTREGADO"), "#,##0.00")
                    Me.lblTc_Mz_Entregada.Text = Format(lRet("TC_MZ_ENTREGADO"), "#,##0.00")
                    Me.lblTC_Entregada.Text = Format(lRet("TONEL_ENTREGADO"), "#,##0.00")
                End If
                Me.cpMapa.JSProperties("cpResultCallback") = "PopupInfo"
        End Select
    End Sub


    Private Sub CargarGraficoEntregaCana(ByVal NOMBRE_ZAFRA As String, _
                                        ByVal CODI_DEPTO As String, _
                                        ByVal CODI_MUNI As String, _
                                        ByVal CODI_CANTON As String, _
                                        ByVal ZONA As String, _
                                        ByVal SUB_ZONA As String)
        Me.odsGrafico.SelectParameters("NOMBRE_ZAFRA").DefaultValue = NOMBRE_ZAFRA
        Me.odsGrafico.SelectParameters("CODI_DEPTO").DefaultValue = CODI_DEPTO
        Me.odsGrafico.SelectParameters("CODI_MUNI").DefaultValue = CODI_MUNI
        Me.odsGrafico.SelectParameters("CODI_CANTON").DefaultValue = CODI_CANTON
        Me.odsGrafico.SelectParameters("ZONA").DefaultValue = ZONA
        Me.odsGrafico.SelectParameters("SUB_ZONA").DefaultValue = SUB_ZONA
        Me.chartEntregaCanaCatorcena.DataBind()
    End Sub

    Private Sub CargarGraficoRendimientoCana(ByVal NOMBRE_ZAFRA As String, _
                                        ByVal CODI_DEPTO As String, _
                                        ByVal CODI_MUNI As String, _
                                        ByVal CODI_CANTON As String, _
                                        ByVal ZONA As String, _
                                        ByVal SUB_ZONA As String)
        Me.odsRendimiento.SelectParameters("NOMBRE_ZAFRA").DefaultValue = NOMBRE_ZAFRA
        Me.odsRendimiento.SelectParameters("CODI_DEPTO").DefaultValue = CODI_DEPTO
        Me.odsRendimiento.SelectParameters("CODI_MUNI").DefaultValue = CODI_MUNI
        Me.odsRendimiento.SelectParameters("CODI_CANTON").DefaultValue = CODI_CANTON
        Me.odsRendimiento.SelectParameters("ZONA").DefaultValue = ZONA
        Me.odsRendimiento.SelectParameters("SUB_ZONA").DefaultValue = SUB_ZONA
        Me.chartRendCatorcena.DataBind()
    End Sub
End Class
