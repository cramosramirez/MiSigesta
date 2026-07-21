Imports SISPACAL.EL.Enumeradores

Partial Public Class cPROVEEDOR


    Public Function ObtenerCorrelativoProveedor() As Int32
        Try
            Return mDb.ObtenerCorrelativoProveedor()

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorNombreCompleto(ByVal NOMBRE_PROVEEDOR As String) As listaPROVEEDOR
        Try

            Return mDb.ObtenerListaPorNombreCompleto(NOMBRE_PROVEEDOR)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorNIT(ByVal NIT As String, Optional soloProveedores As Boolean = False) As listaPROVEEDOR
        Try
            Dim lCriterios As New List(Of Criteria)
            Dim listaProvee As listaPROVEEDOR
            Dim lProveedor As New PROVEEDOR


            If soloProveedores Then
                lCriterios.Add(New Criteria("NIT", "=", NIT, "AND"))
                lProveedor.NIT = NIT
                lCriterios.Add(New Criteria("CODISOCIO", "=", Utilerias.FormatoCODISOCIO(0), ""))
                lProveedor.CODISOCIO = Utilerias.FormatoCODISOCIO(0)
            Else
                lCriterios.Add(New Criteria("NIT", "=", NIT, ""))
                lProveedor.NIT = NIT
            End If

            listaProvee = Me.ObtenerListaPorBusqueda(lProveedor, lCriterios.ToArray)
            If listaProvee IsNot Nothing AndAlso listaProvee.Count > 0 Then
                Return listaProvee
            End If

            Return Nothing

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorDUI(ByVal DUI As String, Optional soloProveedores As Boolean = False) As listaPROVEEDOR
        Try
            Dim lCriterios As New List(Of Criteria)
            Dim listaProvee As listaPROVEEDOR
            Dim lProveedor As New PROVEEDOR

            If soloProveedores Then
                lCriterios.Add(New Criteria("DUI", "=", DUI, "AND"))
                lProveedor.DUI = DUI
                lCriterios.Add(New Criteria("CODISOCIO", "=", Utilerias.FormatoCODISOCIO(0), ""))
                lProveedor.CODISOCIO = Utilerias.FormatoCODISOCIO(0)
            Else
                lCriterios.Add(New Criteria("DUI", "=", DUI, ""))
                lProveedor.DUI = DUI
            End If

            listaProvee = Me.ObtenerListaPorBusqueda(lProveedor, lCriterios.ToArray)
            If listaProvee IsNot Nothing AndAlso listaProvee.Count > 0 Then
                Return listaProvee
            End If

            Return Nothing

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorNRC(ByVal NRC As String, Optional soloProveedores As Boolean = False) As listaPROVEEDOR
        Try
            Dim lCriterios As New List(Of Criteria)
            Dim listaProvee As listaPROVEEDOR
            Dim lProveedor As New PROVEEDOR

            If soloProveedores Then
                lCriterios.Add(New Criteria("CREDITFISCAL", "=", NRC, "AND"))
                lProveedor.CREDITFISCAL = NRC
                lCriterios.Add(New Criteria("CODISOCIO", "=", Utilerias.FormatoCODISOCIO(0), ""))
                lProveedor.CODISOCIO = Utilerias.FormatoCODISOCIO(0)
            Else
                lCriterios.Add(New Criteria("CREDITFISCAL", "=", NRC, ""))
                lProveedor.CREDITFISCAL = NRC
            End If

            listaProvee = Me.ObtenerListaPorBusqueda(lProveedor, lCriterios.ToArray)
            If listaProvee IsNot Nothing AndAlso listaProvee.Count > 0 Then
                Return listaProvee
            End If

            Return Nothing

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCriterios(ByVal CODIPROVEE As String, ByVal CODISOCIO As String,
                                             ByVal APELLIDOS As String, ByVal NOMBRES As String,
                                             ByVal DUI As String,
                                             ByVal NIT As String,
                                             ByVal CREDITFISCAL As String, ByVal ID_ZAFRA_CONTRATADA As Integer,
                                             Optional soloProveedoresConContrato As Boolean = False) As listaPROVEEDOR
        Try
            Dim mListaMAESTRO_LOTES As New listaMAESTRO_LOTES
            Return mDb.ObtenerListaPorCriterios(CODIPROVEE, CODISOCIO, APELLIDOS, NOMBRES, DUI, NIT, CREDITFISCAL, ID_ZAFRA_CONTRATADA, soloProveedoresConContrato)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Private Function Validar(ByVal aNuevo As Boolean, ByVal aEntidad As PROVEEDOR) As String
        If aEntidad.DUI <> String.Empty Then
            If Not Utilerias.EsDUI(aEntidad.DUI) Then
                Return "El numero de DUI del Proveedor no es valido"
            End If
        End If
        If aEntidad.DUI_APODERADO <> String.Empty Then
            If Not Utilerias.EsDUI(aEntidad.DUI_APODERADO) Then
                Return "El numero de DUI del Representante legal no es valido"
            End If
        End If
        If aEntidad.ID_TIPO_PERSONA = TipoPersona.Juridica AndAlso aEntidad.NIT <> String.Empty Then
            If Not Utilerias.EsNIT(aEntidad.NIT) Then
                Return "El numero de NIT no es valido"
            End If
        End If
        If aEntidad.NIT_APODERADO <> String.Empty Then
            If Not Utilerias.EsNIT(aEntidad.NIT_APODERADO) Then
                Return "El numero de NIT del Representate legal no es valido"
            End If
        End If
        If aEntidad.CODISOCIO = Utilerias.FormatoCODISOCIO(0) Then
            If (aEntidad.TIPO_CONTRIBUYENTE = 1 OrElse aEntidad.TIPO_CONTRIBUYENTE = 2) AndAlso aEntidad.CREDITFISCAL = "" Then
                Return "El No. de Registro de Contribuyente es obligatorio"
            End If
        End If
        If aNuevo Then
            'Verificar si ya existe un proveedor cn el mismo DUI / NIT / NRC
            Dim lProveedores As listaPROVEEDOR
            Dim lProveedor As PROVEEDOR

            If aEntidad.DUI <> "" AndAlso aEntidad.CODISOCIO = Utilerias.FormatoCODISOCIO(0) Then
                lProveedores = Me.ObtenerListaPorDUI(aEntidad.DUI, True)
                If lProveedores IsNot Nothing AndAlso lProveedores.Count > 0 Then
                    Return "Ya existe un proveedor con el mismo numero de DUI"
                End If
            End If

            If aEntidad.ID_TIPO_PERSONA = TipoPersona.Juridica AndAlso aEntidad.NIT <> "" AndAlso aEntidad.CODISOCIO = Utilerias.FormatoCODISOCIO(0) Then
                lProveedores = Me.ObtenerListaPorNIT(aEntidad.NIT, True)
                If lProveedores IsNot Nothing AndAlso lProveedores.Count > 0 Then
                    Return "Ya existe un proveedor con el mismo numero de NIT"
                End If
            End If

            If aEntidad.CREDITFISCAL <> "" AndAlso aEntidad.CODISOCIO = Utilerias.FormatoCODISOCIO(0) Then
                lProveedores = Me.ObtenerListaPorNRC(aEntidad.CREDITFISCAL, True)
                If lProveedores IsNot Nothing AndAlso lProveedores.Count > 0 Then
                    Return "Ya existe un proveedor con el mismo numero de CREDITO FISCAL"
                End If
            End If

            lProveedor = Me.ObtenerPROVEEDOR(aEntidad.CODIPROVEEDOR)
            If lProveedor IsNot Nothing Then
                Return "Ya existe un proveedor con el código " + lProveedor.CODIPROVEEDOR
            End If
        Else
            Dim lProveedores As listaPROVEEDOR
            If aEntidad.DUI <> "" AndAlso aEntidad.CODISOCIO = Utilerias.FormatoCODISOCIO(0) Then
                lProveedores = Me.ObtenerListaPorDUI(aEntidad.DUI, True)
                If lProveedores IsNot Nothing Then
                    For Each lProveedor As PROVEEDOR In lProveedores
                        If lProveedor.CODIPROVEEDOR <> aEntidad.CODIPROVEEDOR Then
                            Return "Ya existe un proveedor con el mismo numero de DUI"
                        End If
                    Next
                End If
            End If
            If aEntidad.ID_TIPO_PERSONA = TipoPersona.Juridica AndAlso aEntidad.NIT <> "" AndAlso aEntidad.CODISOCIO = Utilerias.FormatoCODISOCIO(0) Then
                lProveedores = Me.ObtenerListaPorNIT(aEntidad.NIT, True)
                If lProveedores IsNot Nothing Then
                    For Each lProveedor As PROVEEDOR In lProveedores
                        If lProveedor.CODIPROVEEDOR <> aEntidad.CODIPROVEEDOR Then
                            Return "Ya existe un proveedor con el mismo numero de NIT"
                        End If
                    Next
                End If
            End If
            If aEntidad.CREDITFISCAL <> "" AndAlso aEntidad.CODISOCIO = Utilerias.FormatoCODISOCIO(0) Then
                lProveedores = Me.ObtenerListaPorNRC(aEntidad.CREDITFISCAL, True)
                If lProveedores IsNot Nothing Then
                    For Each lProveedor As PROVEEDOR In lProveedores
                        If lProveedor.CODIPROVEEDOR <> aEntidad.CODIPROVEEDOR Then
                            Return "Ya existe un proveedor con el mismo numero de CREDITO FISCAL"
                        End If
                    Next
                End If
            End If
        End If
        Return ""
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro que recibe como parámetro.
    ''' </summary>
    ''' <remarks>Se reciben los parametros uno a uno para la entidad 
    ''' y son asignados a una entidad y se ejecuta el Metodo Actualizar
    ''' o Agregar mandando la entidad de parametro.</remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarPROVEEDOR(ByVal CODIPROVEEDOR As String, ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal APELLIDOS As String, ByVal NOMBRES As String, ByVal EDAD As String, ByVal DIRECCION As String, ByVal TELEFONO As String, ByVal CELULAR As String, ByVal DUI As String, ByVal NIT As String, ByVal CREDITFISCAL As String, ByVal PROFESION As String, ByVal NOMBRENIT As String, ByVal APODERADO As String, ByVal DUI_APODERADO As String, ByVal NIT_APODERADO As String, ByVal USER_CREA As Int32, ByVal FECHA_CREA As DateTime, ByVal USER_ACT As Int32, ByVal FECHA_ACT As DateTime, ByVal FECHA_NAC As DateTime, ByVal TIPO_CONTRIBUYENTE As Int32) As Integer
        Try
            Dim lEntidad As New PROVEEDOR
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.CODIPROVEE = CODIPROVEE
            lEntidad.CODISOCIO = CODISOCIO
            lEntidad.APELLIDOS = APELLIDOS
            lEntidad.NOMBRES = NOMBRES
            lEntidad.EDAD = EDAD
            lEntidad.DIRECCION = DIRECCION
            lEntidad.TELEFONO = TELEFONO
            lEntidad.CELULAR = CELULAR
            lEntidad.DUI = DUI
            lEntidad.NIT = NIT
            lEntidad.CREDITFISCAL = CREDITFISCAL
            lEntidad.PROFESION = PROFESION
            lEntidad.NOMBRENIT = NOMBRENIT
            lEntidad.APODERADO = APODERADO
            lEntidad.DUI_APODERADO = DUI_APODERADO
            lEntidad.NIT_APODERADO = NIT_APODERADO
            lEntidad.USER_CREA = USER_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USER_ACT = USER_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.FECHA_NAC = FECHA_NAC
            lEntidad.TIPO_CONTRIBUYENTE = TIPO_CONTRIBUYENTE
            Return Me.AgregarPROVEEDOR(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro de la Entidad que recibe como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados al menos los
    ''' valores de la Llave Primaria, para su inserción.</remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarPROVEEDOR(ByVal aEntidad As PROVEEDOR) As Integer
        Try
            Dim lRet As String = ""

            If Not (aEntidad.NIT.Trim = "12170804500018" OrElse aEntidad.NIT_APODERADO.Trim = "12170804500018" OrElse aEntidad.NIT.Trim = "06141810951022" OrElse aEntidad.NIT_APODERADO.Trim = "06141810951022" _
                    OrElse aEntidad.DUI.Trim = "021298082" OrElse aEntidad.DUI_APODERADO.Trim = "021298082" OrElse _
                    aEntidad.DUI.Trim = "019633860" OrElse aEntidad.NIT.Trim = "08190511641023") Then
                lRet = Validar(False, aEntidad)
            End If

            If lRet <> "" Then
                Me.sError = lRet
                Return -1
            End If
            Return mDb.Agregar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPROVEEDOR(ByVal aEntidad As PROVEEDOR) As Integer
        Try
            Return Me.ActualizarPROVEEDOR(aEntidad, EL.TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPROVEEDOR(ByVal aEntidad As PROVEEDOR, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lEntidadAntesAct As PROVEEDOR = Me.ObtenerPROVEEDOR(aEntidad.CODIPROVEEDOR)
            Dim lRet As String = ""

            If Not (aEntidad.NIT.Trim = "12170804500018" OrElse aEntidad.NIT_APODERADO.Trim = "12170804500018" OrElse aEntidad.NIT.Trim = "06141810951022" OrElse aEntidad.NIT_APODERADO.Trim = "06141810951022" _
                    OrElse aEntidad.DUI.Trim = "021298082" OrElse aEntidad.DUI_APODERADO.Trim = "021298082" OrElse _
                    aEntidad.DUI.Trim = "019633860" OrElse aEntidad.NIT.Trim = "08190511641023") Then
                lRet = Validar(False, aEntidad)
            End If

            If lRet <> "" Then
                Me.sError = lRet
                Return -1
            End If
            If aEntidad.APELLIDOS = "" Then aEntidad.APELLIDOS = " "

            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	16/06/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)>
    Public Function ActualizarPROVEEDOR(ByVal CODIPROVEEDOR As String, ByVal CODIPROVEE As String, ByVal CODISOCIO As String, ByVal APELLIDOS As String, ByVal NOMBRES As String, ByVal EDAD As String, ByVal DIRECCION As String, ByVal TELEFONO As String, ByVal CELULAR As String, ByVal DUI As String, ByVal NIT As String, ByVal CREDITFISCAL As String, ByVal PROFESION As String, ByVal NOMBRENIT As String, ByVal APODERADO As String, ByVal DUI_APODERADO As String, ByVal NIT_APODERADO As String, ByVal USER_CREA As Int32, ByVal FECHA_CREA As DateTime, ByVal USER_ACT As Int32, ByVal FECHA_ACT As DateTime, ByVal FECHA_NAC As DateTime, ByVal TIPO_CONTRIBUYENTE As Int32) As Integer
        Try
            Dim lEntidad As New PROVEEDOR
            lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
            lEntidad.CODIPROVEE = CODIPROVEE
            lEntidad.CODISOCIO = CODISOCIO
            lEntidad.APELLIDOS = APELLIDOS
            lEntidad.NOMBRES = NOMBRES
            lEntidad.EDAD = EDAD
            lEntidad.DIRECCION = DIRECCION
            lEntidad.TELEFONO = TELEFONO
            lEntidad.CELULAR = CELULAR
            lEntidad.DUI = DUI
            lEntidad.NIT = NIT
            lEntidad.CREDITFISCAL = CREDITFISCAL
            lEntidad.PROFESION = PROFESION
            lEntidad.NOMBRENIT = NOMBRENIT
            lEntidad.APODERADO = APODERADO
            lEntidad.DUI_APODERADO = DUI_APODERADO
            lEntidad.NIT_APODERADO = NIT_APODERADO
            lEntidad.USER_CREA = USER_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USER_ACT = USER_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.FECHA_NAC = FECHA_NAC
            lEntidad.TIPO_CONTRIBUYENTE = TIPO_CONTRIBUYENTE
            Return Me.ActualizarPROVEEDOR(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ReporteExcelConsultaProductoresPorZafra(ByVal ID_ZAFRA As Integer, ByVal conContrato As Boolean) As DataTable
        Try
            Return mDb.ReporteExcelConsultaProductoresPorZafra(ID_ZAFRA, conContrato)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
