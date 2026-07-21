Partial Public Class cAGRONOMO
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorESTADO(ByVal ESTADO_AGRONOMO As Int32, ByVal AgregarTodos As Boolean, ByVal AgregarVacio As Boolean, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaAGRONOMO
        Try
            Dim mListaAGRONOMO As New listaAGRONOMO
            Dim lAgronomo As AGRONOMO
            mListaAGRONOMO = mDb.ObtenerListaPorESTADO(ESTADO_AGRONOMO, asColumnaOrden, asTipoOrden)

            If AgregarTodos Then
                lAgronomo = New AGRONOMO
                lAgronomo.CODIAGRON = ""
                lAgronomo.NOMBRE_AGRONOMO = "[Todos]"
                lAgronomo.APELLIDO_AGRONOMO = ""
                mListaAGRONOMO.Insertar(0, lAgronomo)
            End If
            If AgregarVacio Then
                lAgronomo = New AGRONOMO
                lAgronomo.CODIAGRON = ""
                lAgronomo.NOMBRE_AGRONOMO = ""
                lAgronomo.APELLIDO_AGRONOMO = ""
                mListaAGRONOMO.Insertar(0, lAgronomo)
            End If

            Return mListaAGRONOMO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
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
    ''' 	[GenApp]	25/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarAGRONOMO(ByVal aEntidad As AGRONOMO) As Integer
        Try
            Dim lRet As String = ValidarDatos(aEntidad, True)
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
    ''' 	[GenApp]	25/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarAGRONOMO(ByVal aEntidad As AGRONOMO) As Integer
        Try
            Return Me.ActualizarAGRONOMO(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	25/09/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarAGRONOMO(ByVal aEntidad As AGRONOMO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim lRet As String = ValidarDatos(aEntidad, False)
            If lRet <> "" Then
                Me.sError = lRet
                Return -1
            End If
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function RecuperarLista(ByVal AgregarTodos As Boolean, ByVal AgregarVacio As Boolean, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaAGRONOMO
        Try
            Dim mListaAGRONOMO As New listaAGRONOMO
            Dim lAgronomo As AGRONOMO
            mListaAGRONOMO = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)

            If AgregarTodos Then
                lAgronomo = New AGRONOMO
                lAgronomo.CODIAGRON = ""
                lAgronomo.NOMBRE_AGRONOMO = "[Todos]"
                lAgronomo.APELLIDO_AGRONOMO = ""
                mListaAGRONOMO.Insertar(0, lAgronomo)
            End If
            If AgregarVacio Then
                lAgronomo = New AGRONOMO
                lAgronomo.CODIAGRON = ""
                lAgronomo.NOMBRE_AGRONOMO = ""
                lAgronomo.APELLIDO_AGRONOMO = ""
                mListaAGRONOMO.Insertar(0, lAgronomo)
            End If

            Return mListaAGRONOMO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Function ValidarDatos(ByRef aEntidad As AGRONOMO, ByVal aEsNuevo As Boolean) As String
        If aEntidad.CODIAGRON.Trim = "" Then
            Return "El codigo de agronomo es obligatorio"
        End If
        aEntidad.CODIAGRON = Utilerias.RellenarIzquierda(aEntidad.CODIAGRON, 8)
        If aEsNuevo Then
            Dim lAgronomo As AGRONOMO = (New cAGRONOMO).ObtenerAGRONOMO(aEntidad.CODIAGRON)
            If lAgronomo IsNot Nothing Then
                Return "El codigo de agronomo ya esta asignado"
            End If
        End If
        'Validar si existe el usuario
        If aEntidad.USUARIO_SIGESTA <> Nothing Then aEntidad.USUARIO_SIGESTA = aEntidad.USUARIO_SIGESTA.Trim
        If aEntidad.USUARIO_SIGESTA <> "" Then
            Dim lUsuario As USUARIO = (New cUSUARIO).ObtenerUSUARIO(aEntidad.USUARIO_SIGESTA)
            If lUsuario Is Nothing Then
                Return "El usuario SIGESTA no es valido"
            End If

            'Validar que el usuario SIGESTA no este asignado a otro técnico
            If aEsNuevo Then
                Dim listaAgro As listaAGRONOMO = (New cAGRONOMO).ObtenerListaPorUSUARIO(aEntidad.USUARIO_SIGESTA)
                If listaAgro IsNot Nothing AndAlso listaAgro.Count > 0 Then
                    Return "El usuario SIGESTA ya esta asignado a otro tecnico"
                End If
            Else
                Dim listaAgro As listaAGRONOMO = (New cAGRONOMO).ObtenerListaPorUSUARIO(aEntidad.USUARIO_SIGESTA)
                If listaAgro IsNot Nothing AndAlso listaAgro.Count > 0 Then
                    For Each lAgro As AGRONOMO In listaAgro
                        If lAgro.CODIAGRON <> aEntidad.CODIAGRON Then
                            Return "El usuario SIGESTA ya esta asignado a otro tecnico"
                        End If
                    Next
                End If
            End If
        End If
        
        Return ""
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaParaContrato(ByVal asColumnaOrden As String, ByVal asTipoOrden As String) As listaAGRONOMO
        Try
            Return mDb.ObtenerListaParaContrato(asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
