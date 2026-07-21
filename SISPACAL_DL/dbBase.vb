Imports System.Configuration
Imports System.Reflection
Imports System.Text
Imports System.ComponentModel

Public MustInherit Class dbBase

#Region " Protegidas "
    Protected _sError As String
    Protected _sql As SqlHelper
    Protected _cnnStr As New String(ConfigurationManager.ConnectionStrings("cn").ConnectionString)
    Protected _cnnStrGPS As New String(ConfigurationManager.ConnectionStrings("cnGPS").ConnectionString)
    Private _ConnectionStringName As String
#End Region

#Region " Propiedades "

    Protected Property ConnectionStringName() As String
        Get
            Return _ConnectionStringName
        End Get
        Set(ByVal value As String)
            _ConnectionStringName = value
        End Set
    End Property


    Protected Overridable Property sql() As SqlHelper
        Get
            Return Me._sql
        End Get
        Set(ByVal Value As SqlHelper)
            Me._sql = Value
        End Set
    End Property

    Protected Overridable Property sError() As String
        Get
            Return Me._sError
        End Get
        Set(ByVal Value As String)
            Me._sError = Value
        End Set
    End Property

    Protected Overridable Property cnnStr() As String
        Get
            If Not ConnectionStringName Is Nothing OrElse ConnectionStringName <> "" Then
                _cnnStr = New String(CType(ConfigurationManager.ConnectionStrings(ConnectionStringName).ConnectionString, Char()))
            End If
            Return Me._cnnStr
        End Get
        Set(ByVal Value As String)
            Me._cnnStr = Value
        End Set
    End Property

    Protected Overridable Property cnnStrGPS() As String
        Get
            Return Me._cnnStrGPS
        End Get
        Set(ByVal Value As String)
            Me._cnnStrGPS = Value
        End Set
    End Property

#End Region

#Region " Métodos Públicos "

    Public MustOverride Function Actualizar(ByVal aEntidad As entidadBase) As Integer
    'Funcion que se encarga de Actualizar los datos de la Entidad

    Public MustOverride Function Agregar(ByVal aEntidad As entidadBase) As Integer
    'Funcion que se encarga de Insertar los datos de la Entidad

    Public MustOverride Function Eliminar(ByVal aEntidad As entidadBase) As Integer
    'Funcion que se encarga de Eliminar los datos de la Entidad

    Public MustOverride Function Recuperar(ByVal aEntidad As entidadBase) As Integer
    'Funcion que se encarga de Recuperar los datos de la Entidad

    Public MustOverride Function ObtenerID(ByVal aEntidad As entidadBase) As Object
    'Funcion que se encarga de Obtener el Maximo ID de la Entidad.

#End Region

    Public Overloads Sub CargarEntidad(ByVal origen As IDataReader, ByRef destino As entidadBase)

        If origen Is Nothing Or destino Is Nothing Then Return

        Dim tipoDestino As Type = destino.GetType()

        For i As Integer = 0 To origen.FieldCount - 1
            Try
                If Not origen(i) Is System.DBNull.Value Then
                    Dim PropiedadDestino As PropertyInfo = tipoDestino.GetProperty(origen.GetName(i))
                    Dim PropiedadDestinoOld As PropertyInfo = tipoDestino.GetProperty(origen.GetName(i) + "Old")
                    PropiedadDestino.SetValue(destino, origen(i), Nothing)
                    If Not PropiedadDestinoOld Is Nothing Then
                        PropiedadDestinoOld.SetValue(destino, origen(i), Nothing)
                    End If
                Else
                    Dim PropiedadDestino As PropertyInfo = tipoDestino.GetProperty(origen.GetName(i))
                    If (PropiedadDestino.PropertyType.Name = "Int16") Or _
                            (PropiedadDestino.PropertyType.Name = "Int32") Or _
                            (PropiedadDestino.PropertyType.Name = "Int64") Or _
                            (PropiedadDestino.PropertyType.Name = "Integer") Or _
                            (PropiedadDestino.PropertyType.Name = "Decimal") Then
                        Dim PropiedadDestinoOld As PropertyInfo = tipoDestino.GetProperty(origen.GetName(i) + "Old")
                        Select Case PropiedadDestino.PropertyType.Name
                            Case "Int16", "Int32", "Int64", "Integer"
                                PropiedadDestino.SetValue(destino, -1, Nothing)
                            Case "Decimal"
                                PropiedadDestino.SetValue(destino, Decimal.Parse("-1"), Nothing)
                        End Select
                        If Not PropiedadDestinoOld Is Nothing Then
                            Select Case PropiedadDestinoOld.PropertyType.Name
                                Case "Int16", "Int32", "Int64", "Integer"
                                    PropiedadDestinoOld.SetValue(destino, -1, Nothing)
                                Case "Decimal"
                                    PropiedadDestinoOld.SetValue(destino, Decimal.Parse("-1"), Nothing)
                            End Select
                        End If
                    End If
                End If
            Catch ex As Exception
            End Try
        Next
    End Sub


    'Public Overloads Sub CargarEntidad(ByVal origen As IDataReader, ByRef destino As entidadBase)

    '    If origen Is Nothing Or destino Is Nothing Then Return

    '    Dim tipoDestino As Type = destino.GetType()

    '    For i As Integer = 0 To origen.FieldCount - 1
    '        Try
    '            If Not origen(i) Is System.DBNull.Value Then
    '                Dim PropiedadDestino As PropertyInfo = tipoDestino.GetProperty(origen.GetName(i))
    '                Dim PropiedadDestinoOld As PropertyInfo = tipoDestino.GetProperty(origen.GetName(i) + "Old")
    '                PropiedadDestino.SetValue(destino, origen(i), Nothing)
    '                If Not PropiedadDestinoOld Is Nothing Then
    '                    PropiedadDestinoOld.SetValue(destino, origen(i), Nothing)
    '                End If
    '            End If
    '        Catch ex As Exception
    '        End Try
    '    Next
    '    destino.IsDirty = False
    'End Sub

    Public Overloads Sub CargarEntidad(ByRef destino As entidadBase, ByVal origenDR As DataRow)

        If origenDR Is Nothing Or destino Is Nothing Then Return

        Dim tipoDestino As Type = destino.GetType()

        For i As Integer = 0 To origenDR.Table.Columns.Count - 1
            Try
                If Not origenDR(i) Is System.DBNull.Value Then
                    Dim PropiedadDestino As PropertyInfo = tipoDestino.GetProperty(origenDR.Table.Columns(i).ColumnName)
                    Dim PropiedadDestinoOld As PropertyInfo = tipoDestino.GetProperty(origenDR.Table.Columns(i).ColumnName + "Old")
                    PropiedadDestino.SetValue(destino, origenDR(origenDR.Table.Columns(i).ColumnName), Nothing)
                    If Not PropiedadDestinoOld Is Nothing Then
                        PropiedadDestinoOld.SetValue(destino, origenDR(origenDR.Table.Columns(i).ColumnName), Nothing)
                    End If
                End If
            Catch ex As Exception
            End Try
        Next
        destino.IsDirty = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Método que genera el Query de Update a partir de la entidad que recibe de parámetro
    ''' </summary>
    ''' <param name="entity"></param>
    ''' <param name="args"></param>
    ''' <param name="aTipoConcurrencia"></param>
    ''' <returns>Retorna el String del Query creado</returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    'Public Function QueryUpdate(ByVal entity As entidadBase, ByRef args() As SqlParameter, Optional ByVal aTipoConcurrencia As TipoConcurrencia = TipoConcurrencia.Pesimistica) As String

    '    Dim tipoEntidad As Type = entity.GetType()
    '    Dim tipoParametro As Type = args.GetType()
    '    Dim strSql As New StringBuilder
    '    Dim strSet As String = ""
    '    Dim strWhere As String = ""
    '    Dim countArgs As Integer = 0

    '    Dim atributoTabla As TableAttribute = _
    '    CType(Attribute.GetCustomAttribute(tipoEntidad, GetType(TableAttribute)), TableAttribute)

    '    strSql.Append(" UPDATE " + atributoTabla.Name + " " + vbCrLf)
    '    strSql.Append(" SET ")

    '    For Each PropiedadOrigen As PropertyInfo In tipoEntidad.GetProperties()

    '        Dim atributoColumna As ColumnAttribute
    '        Dim atributoDataObject As DataObjectFieldAttribute
    '        Dim PropiedadDestino As PropertyInfo = tipoEntidad.GetProperty(PropiedadOrigen.Name)
    '        atributoColumna = CType(Attribute.GetCustomAttribute(PropiedadOrigen, GetType(ColumnAttribute)), ColumnAttribute)
    '        atributoDataObject = CType(Attribute.GetCustomAttribute(PropiedadOrigen, GetType(DataObjectFieldAttribute)), DataObjectFieldAttribute)

    '        If Not PropiedadDestino Is Nothing And Not atributoColumna Is Nothing Then
    '            If PropiedadDestino.Name = "TRANSPORTE_PROPIO" Then Stop
    '            'entity()
    '            Dim PropiedadOld As PropertyInfo = Nothing
    '            Try
    '                PropiedadOld = tipoEntidad.GetProperty(PropiedadOrigen.Name + "Old")
    '            Catch ex As Exception

    '            End Try
    '            If Not PropiedadOld Is Nothing And aTipoConcurrencia = TipoConcurrencia.Optimistica Then
    '                If PropiedadOld.GetValue(entity, Nothing) <> PropiedadDestino.GetValue(entity, Nothing) Then
    '                    If strSet <> "" Then
    '                        If PropiedadDestino.Name.Length >= 30 Then
    '                            strSet += " , " + atributoColumna.Storage + " = @" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
    '                        Else
    '                            strSet += " , " + atributoColumna.Storage + " = @" + PropiedadDestino.Name + " " + vbCrLf
    '                        End If
    '                    Else
    '                        If PropiedadDestino.Name.Length >= 30 Then
    '                            strSet += " " + atributoColumna.Storage + " = @" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
    '                        Else
    '                            strSet += " " + atributoColumna.Storage + " = @" + PropiedadDestino.Name + " " + vbCrLf
    '                        End If
    '                    End If
    '                    countArgs += 1
    '                    Dim i As Integer = 0
    '                    If countArgs - 1 > 0 Then
    '                        Dim tempArgs As Object = args
    '                        ReDim args(countArgs - 1)
    '                        For Each arg As IDbDataParameter In tempArgs
    '                            args(i) = arg
    '                            i += 1
    '                        Next
    '                    End If
    '                    args(i) = Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", ""))
    '                    If PropiedadDestino.Name.Length >= 30 Then
    '                        args(i).ParameterName = "@" & PropiedadDestino.Name.Substring(0, 29)
    '                    Else
    '                        args(i).ParameterName = "@" & PropiedadDestino.Name
    '                    End If

    '                    If (PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
    '                      (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date")) OrElse _
    '                      (PropiedadDestino.GetValue(entity, Nothing) IsNot Nothing AndAlso _
    '                      (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date") AndAlso _
    '                      (DateTime.Compare(CDate(PropiedadDestino.GetValue(entity, Nothing)), #12:00:00 AM#)) = 0) Then
    '                        args(i).Value = DBNull.Value
    '                    ElseIf PropiedadDestino.GetValue(entity, Nothing) = Nothing And _
    '                        (PropiedadDestino.PropertyType.Name = "String") = -1 Then
    '                        args(i).Value = DBNull.Value
    '                    ElseIf (PropiedadDestino.PropertyType.Name = "Int16") Or _
    '                            (PropiedadDestino.PropertyType.Name = "Int32") Or _
    '                            (PropiedadDestino.PropertyType.Name = "Int64") Or _
    '                            (PropiedadDestino.PropertyType.Name = "Integer") Or _
    '                            (PropiedadDestino.PropertyType.Name = "Decimal") Then
    '                        args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
    '                        If args(i).Value = -1 Then
    '                            args(i).Value = DBNull.Value
    '                        End If
    '                    Else
    '                        args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
    '                    End If
    '                    args(i).SqlDbType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
    '                    If atributoColumna.DBType.ToUpper <> "TEXT" Then
    '                        Select Case args(i).SqlDbType
    '                            Case SqlDbType.Char, SqlDbType.NChar, SqlDbType.NVarChar, SqlDbType.VarChar
    '                                args(i).Size = atributoDataObject.Length
    '                                If atributoDataObject.Length > 0 Then
    '                                    If Not args(i).Value Is DBNull.Value AndAlso CType(args(i).Value, String).Length > atributoDataObject.Length Then
    '                                        Throw New Exception("El campo " + PropiedadDestino.Name + " en la tabla " + atributoTabla.Name + " tiene una longitud menor a la recibida.")
    '                                    End If
    '                                End If
    '                            Case Else
    '                        End Select
    '                    End If
    '                End If
    '            ElseIf Not atributoColumna.Id Then
    '                If strSet <> "" Then
    '                    If PropiedadDestino.Name.Length >= 30 Then
    '                        strSet += " , " + atributoColumna.Storage + " = @" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
    '                    Else
    '                        strSet += " , " + atributoColumna.Storage + " = @" + PropiedadDestino.Name + " " + vbCrLf
    '                    End If
    '                Else
    '                    If PropiedadDestino.Name.Length >= 30 Then
    '                        strSet += " " + atributoColumna.Storage + " = @" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
    '                    Else
    '                        strSet += " " + atributoColumna.Storage + " = @" + PropiedadDestino.Name + " " + vbCrLf
    '                    End If
    '                End If
    '                countArgs += 1
    '                Dim i As Integer = 0
    '                If countArgs - 1 > 0 Then
    '                    Dim tempArgs As Object = args
    '                    ReDim args(countArgs - 1)
    '                    For Each arg As IDbDataParameter In tempArgs
    '                        args(i) = arg
    '                        i += 1
    '                    Next
    '                End If
    '                args(i) = Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", ""))
    '                If PropiedadDestino.Name.Length >= 30 Then
    '                    args(i).ParameterName = "@" & PropiedadDestino.Name.Substring(0, 29)
    '                Else
    '                    args(i).ParameterName = "@" & PropiedadDestino.Name
    '                End If
    '                If (PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
    '                      (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date")) OrElse _
    '                      (PropiedadDestino.GetValue(entity, Nothing) IsNot Nothing AndAlso _
    '                      (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date") AndAlso _
    '                      (DateTime.Compare(CDate(PropiedadDestino.GetValue(entity, Nothing)), #12:00:00 AM#)) = 0) Then
    '                    args(i).Value = DBNull.Value
    '                ElseIf PropiedadDestino.GetValue(entity, Nothing) = Nothing And _
    '                    (PropiedadDestino.PropertyType.Name = "String") = -1 Then
    '                    args(i).Value = DBNull.Value
    '                ElseIf (PropiedadDestino.PropertyType.Name = "Int16") Or _
    '                        (PropiedadDestino.PropertyType.Name = "Int32") Or _
    '                        (PropiedadDestino.PropertyType.Name = "Int64") Or _
    '                        (PropiedadDestino.PropertyType.Name = "Integer") Or _
    '                        (PropiedadDestino.PropertyType.Name = "Decimal") Then
    '                    args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
    '                    If args(i).Value = -1 Then
    '                        args(i).Value = DBNull.Value
    '                    End If
    '                Else
    '                    args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
    '                End If
    '                args(i).SqlDbType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
    '                If atributoColumna.DBType.ToUpper <> "TEXT" Then
    '                    Select Case args(i).SqlDbType
    '                        Case SqlDbType.Char, SqlDbType.NChar, SqlDbType.NVarChar, SqlDbType.VarChar
    '                            args(i).Size = atributoDataObject.Length
    '                            If atributoDataObject.Length > 0 Then
    '                                If Not args(i).Value Is DBNull.Value AndAlso CType(args(i).Value, String).Length > atributoDataObject.Length Then
    '                                    Throw New Exception("El campo " + PropiedadDestino.Name + " en la tabla " + atributoTabla.Name + " tiene una longitud menor a la recibida.")
    '                                End If
    '                            End If
    '                        Case Else
    '                    End Select
    '                End If
    '            End If
    '            If aTipoConcurrencia = TipoConcurrencia.Pesimistica Then
    '                If atributoColumna.Id Then
    '                    If strWhere <> "" Then
    '                        strWhere += " AND "
    '                    Else
    '                        strWhere += " WHERE "
    '                    End If
    '                    If PropiedadDestino.Name.Length >= 30 Then
    '                        strWhere += atributoColumna.Storage + " = @" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
    '                    Else
    '                        strWhere += atributoColumna.Storage + " = @" + PropiedadDestino.Name + " " + vbCrLf
    '                    End If
    '                    countArgs += 1
    '                    Dim i As Integer = 0
    '                    If countArgs - 1 > 0 Then
    '                        Dim tempArgs As Object = args
    '                        ReDim args(countArgs - 1)
    '                        For Each arg As IDbDataParameter In tempArgs
    '                            args(i) = arg
    '                            i += 1
    '                        Next
    '                    End If
    '                    args(i) = Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", ""))
    '                    If PropiedadDestino.Name.Length >= 30 Then
    '                        args(i).ParameterName = "@" & PropiedadDestino.Name.Substring(0, 29)
    '                    Else
    '                        args(i).ParameterName = "@" & PropiedadDestino.Name
    '                    End If

    '                    If (PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
    '                       (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date")) OrElse _
    '                       (PropiedadDestino.GetValue(entity, Nothing) IsNot Nothing AndAlso _
    '                       (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date") AndAlso _
    '                       (DateTime.Compare(CDate(PropiedadDestino.GetValue(entity, Nothing)), #12:00:00 AM#)) = 0) Then
    '                        args(i).Value = DBNull.Value
    '                    ElseIf PropiedadDestino.GetValue(entity, Nothing) = Nothing And _
    '                        (PropiedadDestino.PropertyType.Name = "String") = -1 Then
    '                        args(i).Value = DBNull.Value
    '                    ElseIf (PropiedadDestino.PropertyType.Name = "Int16") Or _
    '                            (PropiedadDestino.PropertyType.Name = "Int32") Or _
    '                            (PropiedadDestino.PropertyType.Name = "Int64") Or _
    '                            (PropiedadDestino.PropertyType.Name = "Integer") Or _
    '                            (PropiedadDestino.PropertyType.Name = "Decimal") Then
    '                        args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
    '                        If args(i).Value = -1 Then
    '                            args(i).Value = DBNull.Value
    '                        End If
    '                    Else
    '                        args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
    '                    End If
    '                    args(i).SqlDbType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
    '                    If atributoColumna.DBType.ToUpper <> "TEXT" Then
    '                        Select Case args(i).SqlDbType
    '                            Case SqlDbType.Char, SqlDbType.NChar, SqlDbType.NVarChar, SqlDbType.VarChar
    '                                args(i).Size = atributoDataObject.Length
    '                                If atributoDataObject.Length > 0 Then
    '                                    If Not args(i).Value Is DBNull.Value AndAlso CType(args(i).Value, String).Length > atributoDataObject.Length Then
    '                                        Throw New Exception("El campo " + PropiedadDestino.Name + " en la tabla " + atributoTabla.Name + " tiene una longitud menor a la recibida.")
    '                                    End If
    '                                End If
    '                            Case Else
    '                        End Select
    '                    End If
    '                End If
    '            Else 'Si es Optimistico
    '                If atributoColumna.Id Then
    '                    If strWhere <> "" Then
    '                        strWhere += " AND "
    '                    Else
    '                        strWhere += " WHERE "
    '                    End If
    '                    If PropiedadDestino.Name.Length >= 30 Then
    '                        strWhere += atributoColumna.Storage + " = @" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
    '                    Else
    '                        strWhere += atributoColumna.Storage + " = @" + PropiedadDestino.Name + " " + vbCrLf
    '                    End If
    '                    countArgs += 1
    '                    Dim i As Integer = 0
    '                    If countArgs - 1 > 0 Then
    '                        Dim tempArgs As Object = args
    '                        ReDim args(countArgs - 1)
    '                        For Each arg As IDbDataParameter In tempArgs
    '                            args(i) = arg
    '                            i += 1
    '                        Next
    '                    End If
    '                    args(i) = Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", ""))
    '                    If PropiedadDestino.Name.Length >= 30 Then
    '                        args(i).ParameterName = "@" & PropiedadDestino.Name.Substring(0, 29)
    '                    Else
    '                        args(i).ParameterName = "@" & PropiedadDestino.Name
    '                    End If
    '                    If (PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
    '                       (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date")) OrElse _
    '                       (PropiedadDestino.GetValue(entity, Nothing) IsNot Nothing AndAlso _
    '                       (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date") AndAlso _
    '                       (DateTime.Compare(CDate(PropiedadDestino.GetValue(entity, Nothing)), #12:00:00 AM#)) = 0) Then
    '                        args(i).Value = DBNull.Value
    '                    ElseIf PropiedadDestino.GetValue(entity, Nothing) = Nothing And _
    '                        (PropiedadDestino.PropertyType.Name = "String") = -1 Then
    '                        args(i).Value = DBNull.Value
    '                    ElseIf (PropiedadDestino.PropertyType.Name = "Int16") Or _
    '                            (PropiedadDestino.PropertyType.Name = "Int32") Or _
    '                            (PropiedadDestino.PropertyType.Name = "Int64") Or _
    '                            (PropiedadDestino.PropertyType.Name = "Integer") Or _
    '                            (PropiedadDestino.PropertyType.Name = "Decimal") Then
    '                        args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
    '                        If args(i).Value = -1 Then
    '                            args(i).Value = DBNull.Value
    '                        End If
    '                    Else
    '                        args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
    '                    End If
    '                    args(i).SqlDbType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
    '                    If atributoColumna.DBType.ToUpper <> "TEXT" Then
    '                        Select Case args(i).SqlDbType
    '                            Case SqlDbType.Char, SqlDbType.NChar, SqlDbType.NVarChar, SqlDbType.VarChar
    '                                args(i).Size = atributoDataObject.Length
    '                                If atributoDataObject.Length > 0 Then
    '                                    If Not args(i).Value Is DBNull.Value AndAlso CType(args(i).Value, String).Length > atributoDataObject.Length Then
    '                                        Throw New Exception("El campo " + PropiedadDestino.Name + " en la tabla " + atributoTabla.Name + " tiene una longitud menor a la recibida.")
    '                                    End If
    '                                End If
    '                            Case Else
    '                        End Select
    '                    End If
    '                Else
    '                    If strWhere <> "" Then
    '                        strWhere += " AND "
    '                    Else
    '                        strWhere += " WHERE "
    '                    End If
    '                    If PropiedadDestino.Name.Length >= 30 Then
    '                        strWhere += atributoColumna.Storage + " = @" + PropiedadOld.Name + " " + vbCrLf
    '                    Else
    '                        strWhere += atributoColumna.Storage + " = @" + PropiedadOld.Name + " " + vbCrLf
    '                    End If
    '                    countArgs += 1
    '                    Dim i As Integer = 0
    '                    If countArgs - 1 > 0 Then
    '                        Dim tempArgs As Object = args
    '                        ReDim args(countArgs - 1)
    '                        For Each arg As IDbDataParameter In tempArgs
    '                            args(i) = arg
    '                            i += 1
    '                        Next
    '                    End If
    '                    args(i) = Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", ""))
    '                    If PropiedadDestino.Name.Length >= 30 Then
    '                        args(i).ParameterName = "@" & PropiedadOld.Name.Substring(0, 29)
    '                    Else
    '                        args(i).ParameterName = "@" & PropiedadOld.Name
    '                    End If
    '                    If (PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
    '                      (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date")) OrElse _
    '                      (PropiedadDestino.GetValue(entity, Nothing) IsNot Nothing AndAlso _
    '                      (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date") AndAlso _
    '                      (DateTime.Compare(CDate(PropiedadDestino.GetValue(entity, Nothing)), #12:00:00 AM#)) = 0) Then
    '                        args(i).Value = DBNull.Value
    '                    ElseIf PropiedadDestino.GetValue(entity, Nothing) = Nothing And _
    '                        (PropiedadDestino.PropertyType.Name = "String") = -1 Then
    '                        args(i).Value = DBNull.Value
    '                    ElseIf (PropiedadOld.PropertyType.Name = "Int16") Or _
    '                            (PropiedadOld.PropertyType.Name = "Int32") Or _
    '                            (PropiedadOld.PropertyType.Name = "Int64") Or _
    '                            (PropiedadDestino.PropertyType.Name = "Integer") Or _
    '                            (PropiedadDestino.PropertyType.Name = "Decimal") Then
    '                        args(i).Value = PropiedadOld.GetValue(entity, Nothing)
    '                        If args(i).Value = -1 Then
    '                            args(i).Value = DBNull.Value
    '                        End If
    '                    Else
    '                        args(i).Value = PropiedadOld.GetValue(entity, Nothing)
    '                    End If
    '                    args(i).SqlDbType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
    '                    If atributoColumna.DBType.ToUpper <> "TEXT" Then
    '                        Select Case args(i).SqlDbType
    '                            Case SqlDbType.Char, SqlDbType.NChar, SqlDbType.NVarChar, SqlDbType.VarChar
    '                                args(i).Size = atributoDataObject.Length
    '                                If atributoDataObject.Length > 0 Then
    '                                    If Not args(i).Value Is DBNull.Value AndAlso CType(args(i).Value, String).Length > atributoDataObject.Length Then
    '                                        Throw New Exception("El campo " + PropiedadDestino.Name + " en la tabla " + atributoTabla.Name + " tiene una longitud menor a la recibida.")
    '                                    End If
    '                                End If
    '                            Case Else
    '                        End Select
    '                    End If
    '                End If
    '            End If
    '        End If
    '    Next
    '    strSql.Append(strSet)
    '    strSql.Append(strWhere)
    '    Return strSql.ToString()
    'End Function


    Public Function QueryUpdate(ByVal entity As entidadBase, ByRef args() As SqlParameter, Optional ByVal aTipoConcurrencia As TipoConcurrencia = TipoConcurrencia.Pesimistica) As String

        Dim tipoEntidad As Type = entity.GetType()
        Dim tipoParametro As Type = args.GetType()
        Dim strSql As New StringBuilder
        Dim strSet As String = ""
        Dim strWhere As String = ""
        Dim countArgs As Integer = 0

        Dim atributoTabla As TableAttribute = _
        CType(Attribute.GetCustomAttribute(tipoEntidad, GetType(TableAttribute)), TableAttribute)

        strSql.Append(" UPDATE " + atributoTabla.Name + " " + vbCrLf)
        strSql.Append(" SET ")

        For Each PropiedadOrigen As PropertyInfo In tipoEntidad.GetProperties()

            Dim atributoColumna As ColumnAttribute
            Dim atributoDataObject As DataObjectFieldAttribute
            Dim PropiedadDestino As PropertyInfo = tipoEntidad.GetProperty(PropiedadOrigen.Name)
            atributoColumna = CType(Attribute.GetCustomAttribute(PropiedadOrigen, GetType(ColumnAttribute)), ColumnAttribute)
            atributoDataObject = CType(Attribute.GetCustomAttribute(PropiedadOrigen, GetType(DataObjectFieldAttribute)), DataObjectFieldAttribute)

            If Not PropiedadDestino Is Nothing And Not atributoColumna Is Nothing Then
                If aTipoConcurrencia = TipoConcurrencia.Pesimistica Then
                    If atributoColumna.Id Then
                        If strWhere <> "" Then
                            strWhere += " AND "
                        Else
                            strWhere += " WHERE "
                        End If
                        If PropiedadDestino.Name.Length >= 30 Then
                            strWhere += atributoColumna.Storage + " = @" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
                        Else
                            strWhere += atributoColumna.Storage + " = @" + PropiedadDestino.Name + " " + vbCrLf
                        End If
                        countArgs += 1
                        Dim i As Integer = 0
                        If countArgs - 1 > 0 Then
                            Dim tempArgs As Object = args
                            ReDim args(countArgs - 1)
                            For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                                args(i) = CType(arg, SqlParameter)
                                i += 1
                            Next
                        End If
                        args(i) = CType(Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", "")), SqlParameter)
                        If PropiedadDestino.Name.Length >= 30 Then
                            args(i).ParameterName = "@" & PropiedadDestino.Name.Substring(0, 29)
                        Else
                            args(i).ParameterName = "@" & PropiedadDestino.Name
                        End If

                        If (PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date")) OrElse _
                           (PropiedadDestino.GetValue(entity, Nothing) IsNot Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date") AndAlso _
                           (DateTime.Compare(CDate(PropiedadDestino.GetValue(entity, Nothing)), #12:00:00 AM#)) = 0) Then
                            args(i).Value = DBNull.Value
                        ElseIf PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                                (PropiedadDestino.PropertyType.Name = "String") Then
                            args(i).Value = DBNull.Value
                        ElseIf (PropiedadDestino.PropertyType.Name = "Int16") Or _
                                (PropiedadDestino.PropertyType.Name = "Int32") Or _
                                (PropiedadDestino.PropertyType.Name = "Int64") Or _
                                (PropiedadDestino.PropertyType.Name = "Integer") Or _
                                (PropiedadDestino.PropertyType.Name = "Decimal") Then
                            args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                            If args(i).Value.ToString().Equals("-1") Then
                                args(i).Value = DBNull.Value
                            End If
                        Else
                            args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                        End If
                        args(i).SqlDbType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
                        If atributoColumna.DBType.ToUpper <> "TEXT" Then
                            Select Case args(i).SqlDbType
                                Case SqlDbType.Char, SqlDbType.NChar, SqlDbType.NVarChar, SqlDbType.VarChar
                                    args(i).Size = atributoDataObject.Length
                                    If atributoDataObject.Length > 0 Then
                                        If Not args(i).Value Is DBNull.Value AndAlso CType(args(i).Value, String).Length > atributoDataObject.Length Then
                                            Throw New Exception("El campo " + PropiedadDestino.Name + " en la tabla " + atributoTabla.Name + " tiene una longitud menor a la recibida.")
                                        End If
                                    End If
                                Case Else
                            End Select
                        End If
                    Else
                        If strSet <> "" Then
                            If PropiedadDestino.Name.Length >= 30 Then
                                strSet += " , " + atributoColumna.Storage + " = @" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
                            Else
                                strSet += " , " + atributoColumna.Storage + " = @" + PropiedadDestino.Name + " " + vbCrLf
                            End If
                        Else
                            If PropiedadDestino.Name.Length >= 30 Then
                                strSet += " " + atributoColumna.Storage + " = @" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
                            Else
                                strSet += " " + atributoColumna.Storage + " = @" + PropiedadDestino.Name + " " + vbCrLf
                            End If
                        End If
                        countArgs += 1
                        Dim i As Integer = 0
                        If countArgs - 1 > 0 Then
                            Dim tempArgs As Object = args
                            ReDim args(countArgs - 1)
                            For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                                args(i) = CType(arg, SqlParameter)
                                i += 1
                            Next
                        End If
                        args(i) = CType(Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", "")), SqlParameter)
                        If PropiedadDestino.Name.Length >= 30 Then
                            args(i).ParameterName = "@" & PropiedadDestino.Name.Substring(0, 29)
                        Else
                            args(i).ParameterName = "@" & PropiedadDestino.Name
                        End If

                        If (PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date")) OrElse _
                           (PropiedadDestino.GetValue(entity, Nothing) IsNot Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date") AndAlso _
                           (DateTime.Compare(CDate(PropiedadDestino.GetValue(entity, Nothing)), #12:00:00 AM#)) = 0) Then
                            args(i).Value = DBNull.Value
                        ElseIf PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                                (PropiedadDestino.PropertyType.Name = "String") Then
                            args(i).Value = DBNull.Value
                        ElseIf (PropiedadDestino.PropertyType.Name = "Int16") Or _
                                (PropiedadDestino.PropertyType.Name = "Int32") Or _
                                (PropiedadDestino.PropertyType.Name = "Int64") Or _
                                (PropiedadDestino.PropertyType.Name = "Integer") Or _
                                (PropiedadDestino.PropertyType.Name = "Decimal") Then
                            args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                            If args(i).Value.ToString().Equals("-1") Then
                                args(i).Value = DBNull.Value
                            End If
                        Else
                            args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                        End If
                        args(i).SqlDbType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
                        If atributoColumna.DBType.ToUpper <> "TEXT" Then
                            Select Case args(i).SqlDbType
                                Case SqlDbType.Char, SqlDbType.NChar, SqlDbType.NVarChar, SqlDbType.VarChar
                                    args(i).Size = atributoDataObject.Length
                                    If atributoDataObject.Length > 0 Then
                                        If Not args(i).Value Is DBNull.Value AndAlso CType(args(i).Value, String).Length > atributoDataObject.Length Then
                                            Throw New Exception("El campo " + PropiedadDestino.Name + " en la tabla " + atributoTabla.Name + " tiene una longitud menor a la recibida.")
                                        End If
                                    End If
                                Case Else
                            End Select
                        End If
                    End If
                Else
                    Dim PropiedadOld As PropertyInfo = Nothing
                    Try
                        PropiedadOld = tipoEntidad.GetProperty(PropiedadOrigen.Name + "Old")
                    Catch ex As Exception

                    End Try

                    If Not PropiedadOld Is Nothing Then
                        If Not PropiedadOld.GetValue(entity, Nothing).Equals(PropiedadDestino.GetValue(entity, Nothing)) Then
                            If strSet <> "" Then
                                If PropiedadDestino.Name.Length >= 30 Then
                                    strSet += " , " + atributoColumna.Storage + " = @" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
                                Else
                                    strSet += " , " + atributoColumna.Storage + " = @" + PropiedadDestino.Name + " " + vbCrLf
                                End If
                            Else
                                If PropiedadDestino.Name.Length >= 30 Then
                                    strSet += " " + atributoColumna.Storage + " = @" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
                                Else
                                    strSet += " " + atributoColumna.Storage + " = @" + PropiedadDestino.Name + " " + vbCrLf
                                End If
                            End If
                            countArgs += 1
                            Dim i As Integer = 0
                            If countArgs - 1 > 0 Then
                                Dim tempArgs As Object = args
                                ReDim args(countArgs - 1)
                                For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                                    args(i) = CType(arg, SqlParameter)
                                    i += 1
                                Next
                            End If
                            args(i) = CType(Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", "")), SqlParameter)
                            If PropiedadDestino.Name.Length >= 30 Then
                                args(i).ParameterName = "@" & PropiedadDestino.Name.Substring(0, 29)
                            Else
                                args(i).ParameterName = "@" & PropiedadDestino.Name
                            End If

                            If (PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                               (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date")) OrElse _
                               (PropiedadDestino.GetValue(entity, Nothing) IsNot Nothing AndAlso _
                               (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date") AndAlso _
                               (DateTime.Compare(CDate(PropiedadDestino.GetValue(entity, Nothing)), #12:00:00 AM#)) = 0) Then
                                args(i).Value = DBNull.Value
                            ElseIf PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                                    (PropiedadDestino.PropertyType.Name = "String") Then
                                args(i).Value = DBNull.Value
                            ElseIf (PropiedadDestino.PropertyType.Name = "Int16") Or _
                                    (PropiedadDestino.PropertyType.Name = "Int32") Or _
                                    (PropiedadDestino.PropertyType.Name = "Int64") Or _
                                    (PropiedadDestino.PropertyType.Name = "Integer") Or _
                                    (PropiedadDestino.PropertyType.Name = "Decimal") Then
                                args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                                If args(i).Value.ToString().Equals("-1") Then
                                    args(i).Value = DBNull.Value
                                End If
                            Else
                                args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                            End If
                            args(i).SqlDbType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
                            If atributoColumna.DBType.ToUpper <> "TEXT" Then
                                Select Case args(i).SqlDbType
                                    Case SqlDbType.Char, SqlDbType.NChar, SqlDbType.NVarChar, SqlDbType.VarChar
                                        args(i).Size = atributoDataObject.Length
                                        If atributoDataObject.Length > 0 Then
                                            If Not args(i).Value Is DBNull.Value AndAlso CType(args(i).Value, String).Length > atributoDataObject.Length Then
                                                Throw New Exception("El campo " + PropiedadDestino.Name + " en la tabla " + atributoTabla.Name + " tiene una longitud menor a la recibida.")
                                            End If
                                        End If
                                    Case Else
                                End Select
                            End If
                        End If
                    ElseIf Not atributoColumna.Id Then
                        If strSet <> "" Then
                            If PropiedadDestino.Name.Length >= 30 Then
                                strSet += " , " + atributoColumna.Storage + " = @" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
                            Else
                                strSet += " , " + atributoColumna.Storage + " = @" + PropiedadDestino.Name + " " + vbCrLf
                            End If
                        Else
                            If PropiedadDestino.Name.Length >= 30 Then
                                strSet += " " + atributoColumna.Storage + " = @" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
                            Else
                                strSet += " " + atributoColumna.Storage + " = @" + PropiedadDestino.Name + " " + vbCrLf
                            End If
                        End If
                        countArgs += 1
                        Dim i As Integer = 0
                        If countArgs - 1 > 0 Then
                            Dim tempArgs As Object = args
                            ReDim args(countArgs - 1)
                            For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                                args(i) = CType(arg, SqlParameter)
                                i += 1
                            Next
                        End If
                        args(i) = CType(Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", "")), SqlParameter)
                        If PropiedadDestino.Name.Length >= 30 Then
                            args(i).ParameterName = "@" & PropiedadDestino.Name.Substring(0, 29)
                        Else
                            args(i).ParameterName = "@" & PropiedadDestino.Name
                        End If
                        If (PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date")) OrElse _
                           (PropiedadDestino.GetValue(entity, Nothing) IsNot Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date") AndAlso _
                           (DateTime.Compare(CDate(PropiedadDestino.GetValue(entity, Nothing)), #12:00:00 AM#)) = 0) Then
                            args(i).Value = DBNull.Value
                        ElseIf PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                                (PropiedadDestino.PropertyType.Name = "String") Then
                            args(i).Value = DBNull.Value
                        ElseIf (PropiedadDestino.PropertyType.Name = "Int16") Or _
                                (PropiedadDestino.PropertyType.Name = "Int32") Or _
                                (PropiedadDestino.PropertyType.Name = "Int64") Or _
                                (PropiedadDestino.PropertyType.Name = "Integer") Or _
                                (PropiedadDestino.PropertyType.Name = "Decimal") Then
                            args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                            If args(i).Value.ToString().Equals("-1") Then
                                args(i).Value = DBNull.Value
                            End If
                        Else
                            args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                        End If
                        args(i).SqlDbType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
                        If atributoColumna.DBType.ToUpper <> "TEXT" Then
                            Select Case args(i).SqlDbType
                                Case SqlDbType.Char, SqlDbType.NChar, SqlDbType.NVarChar, SqlDbType.VarChar
                                    args(i).Size = atributoDataObject.Length
                                    If atributoDataObject.Length > 0 Then
                                        If Not args(i).Value Is DBNull.Value AndAlso CType(args(i).Value, String).Length > atributoDataObject.Length Then
                                            Throw New Exception("El campo " + PropiedadDestino.Name + " en la tabla " + atributoTabla.Name + " tiene una longitud menor a la recibida.")
                                        End If
                                    End If
                                Case Else
                            End Select
                        End If
                    End If
                    If atributoColumna.Id Then
                        If strWhere <> "" Then
                            strWhere += " AND "
                        Else
                            strWhere += " WHERE "
                        End If
                        If PropiedadDestino.Name.Length >= 30 Then
                            strWhere += atributoColumna.Storage + " = @" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
                        Else
                            strWhere += atributoColumna.Storage + " = @" + PropiedadDestino.Name + " " + vbCrLf
                        End If
                        countArgs += 1
                        Dim i As Integer = 0
                        If countArgs - 1 > 0 Then
                            Dim tempArgs As Object = args
                            ReDim args(countArgs - 1)
                            For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                                args(i) = CType(arg, SqlParameter)
                                i += 1
                            Next
                        End If
                        args(i) = CType(Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", "")), SqlParameter)
                        If PropiedadDestino.Name.Length >= 30 Then
                            args(i).ParameterName = "@" & PropiedadDestino.Name.Substring(0, 29)
                        Else
                            args(i).ParameterName = "@" & PropiedadDestino.Name
                        End If
                        If (PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date")) OrElse _
                           (PropiedadDestino.GetValue(entity, Nothing) IsNot Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date") AndAlso _
                           (DateTime.Compare(CDate(PropiedadDestino.GetValue(entity, Nothing)), #12:00:00 AM#)) = 0) Then
                            args(i).Value = DBNull.Value
                        ElseIf PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                                (PropiedadDestino.PropertyType.Name = "String") Then
                            args(i).Value = DBNull.Value
                        ElseIf (PropiedadDestino.PropertyType.Name = "Int16") Or _
                                (PropiedadDestino.PropertyType.Name = "Int32") Or _
                                (PropiedadDestino.PropertyType.Name = "Int64") Or _
                                (PropiedadDestino.PropertyType.Name = "Integer") Or _
                                (PropiedadDestino.PropertyType.Name = "Decimal") Then
                            args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                            If args(i).Value.ToString().Equals("-1") Then
                                args(i).Value = DBNull.Value
                            End If
                        Else
                            args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                        End If
                        args(i).SqlDbType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
                        If atributoColumna.DBType.ToUpper <> "TEXT" Then
                            Select Case args(i).SqlDbType
                                Case SqlDbType.Char, SqlDbType.NChar, SqlDbType.NVarChar, SqlDbType.VarChar
                                    args(i).Size = atributoDataObject.Length
                                    If atributoDataObject.Length > 0 Then
                                        If Not args(i).Value Is DBNull.Value AndAlso CType(args(i).Value, String).Length > atributoDataObject.Length Then
                                            Throw New Exception("El campo " + PropiedadDestino.Name + " en la tabla " + atributoTabla.Name + " tiene una longitud menor a la recibida.")
                                        End If
                                    End If
                                Case Else
                            End Select
                        End If
                    Else
                        If strWhere <> "" Then
                            strWhere += " AND "
                        Else
                            strWhere += " WHERE "
                        End If
                        If PropiedadDestino.Name.Length >= 30 Then
                            strWhere += atributoColumna.Storage + " = @" + PropiedadOld.Name + " " + vbCrLf
                        Else
                            strWhere += atributoColumna.Storage + " = @" + PropiedadOld.Name + " " + vbCrLf
                        End If
                        countArgs += 1
                        Dim i As Integer = 0
                        If countArgs - 1 > 0 Then
                            Dim tempArgs As Object = args
                            ReDim args(countArgs - 1)
                            For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                                args(i) = CType(arg, SqlParameter)
                                i += 1
                            Next
                        End If
                        args(i) = CType(Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", "")), SqlParameter)
                        If PropiedadDestino.Name.Length >= 30 Then
                            args(i).ParameterName = "@" & PropiedadOld.Name.Substring(0, 29)
                        Else
                            args(i).ParameterName = "@" & PropiedadOld.Name
                        End If

                        If (PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date")) OrElse _
                           (PropiedadDestino.GetValue(entity, Nothing) IsNot Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date") AndAlso _
                           (DateTime.Compare(CDate(PropiedadDestino.GetValue(entity, Nothing)), #12:00:00 AM#)) = 0) Then
                            args(i).Value = DBNull.Value
                        ElseIf PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                                (PropiedadDestino.PropertyType.Name = "String") Then
                            args(i).Value = DBNull.Value
                        ElseIf (PropiedadOld.PropertyType.Name = "Int16") Or _
                                (PropiedadOld.PropertyType.Name = "Int32") Or _
                                (PropiedadOld.PropertyType.Name = "Int64") Or _
                                (PropiedadOld.PropertyType.Name = "Integer") Or _
                                (PropiedadOld.PropertyType.Name = "Decimal") Then
                            args(i).Value = PropiedadOld.GetValue(entity, Nothing)
                            If args(i).Value.ToString().Equals("-1") Then
                                args(i).Value = DBNull.Value
                            End If
                        Else
                            args(i).Value = PropiedadOld.GetValue(entity, Nothing)
                        End If
                        args(i).SqlDbType = Me.TipoParametro(PropiedadOld.PropertyType.FullName)
                        If atributoColumna.DBType.ToUpper <> "TEXT" Then
                            Select Case args(i).SqlDbType
                                Case SqlDbType.Char, SqlDbType.NChar, SqlDbType.NVarChar, SqlDbType.VarChar
                                    args(i).Size = atributoDataObject.Length
                                    If atributoDataObject.Length > 0 Then
                                        If Not args(i).Value Is DBNull.Value AndAlso CType(args(i).Value, String).Length > atributoDataObject.Length Then
                                            Throw New Exception("El campo " + PropiedadDestino.Name + " en la tabla " + atributoTabla.Name + " tiene una longitud menor a la recibida.")
                                        End If
                                    End If
                                Case Else
                            End Select
                        End If
                    End If
                End If
            End If
        Next
        strSql.Append(strSet)
        strSql.Append(strWhere)
        Return strSql.ToString()
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Método que genera el Query de Seleccion de Campos y el Where
    ''' </summary>
    ''' <param name="entity"></param>
    ''' <param name="args"></param>
    ''' <param name="tipoEntidad"></param>
    ''' <param name="tipoParametro"></param>
    ''' <param name="strCampos"></param>
    ''' <param name="strWhere"></param>
    ''' <param name="countArgs"></param>
    ''' <history>
    ''' 	[GenApp]	28/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub QuerySelectCampos(ByVal entity As entidadBase, ByRef args() As SqlParameter, ByVal tipoEntidad As Type, ByVal tipoParametro As Type, ByRef strCampos As String, ByRef strWhere As String, ByVal countArgs As Integer, Optional ByVal aliasTabla As String = "", Optional ByVal prefijoAliasColumna As String = "")
        For Each PropiedadOrigen As PropertyInfo In tipoEntidad.GetProperties()

            Dim atributoColumna As ColumnAttribute
            Dim PropiedadDestino As PropertyInfo = tipoEntidad.GetProperty(PropiedadOrigen.Name)
            atributoColumna = CType(Attribute.GetCustomAttribute(PropiedadOrigen, GetType(ColumnAttribute)), ColumnAttribute)

            If Not PropiedadDestino Is Nothing And Not atributoColumna Is Nothing Then
                'strSql.Append(" " + atributoColumna.Storage + " " + vbCrLf)
                If strCampos <> "" Then
                    If prefijoAliasColumna <> "" Then
                        strCampos += String.Format(" , {0}.{1} As {2}{3} {4}", aliasTabla, atributoColumna.Storage, prefijoAliasColumna, atributoColumna.Storage, vbCrLf)
                    Else
                        If aliasTabla <> "" Then
                            strCampos += String.Format(" , {0}.{1} {2}", aliasTabla, atributoColumna.Storage, vbCrLf)
                        Else
                            strCampos += String.Format(" , {0} {1}", atributoColumna.Storage, vbCrLf)
                        End If
                    End If
                Else
                    If prefijoAliasColumna <> "" Then
                        strCampos += String.Format(" {0}.{1} As {2}{3} {4}", aliasTabla, atributoColumna.Storage, prefijoAliasColumna, atributoColumna.Storage, vbCrLf)
                    Else
                        If aliasTabla <> "" Then
                            strCampos += String.Format(" {0}.{1} {2}", aliasTabla, atributoColumna.Storage, vbCrLf)
                        Else
                            strCampos += String.Format(" {0} {1}", atributoColumna.Storage, vbCrLf)
                        End If
                    End If
                End If
                If atributoColumna.Id And Not tipoParametro Is Nothing Then
                    If strWhere <> "" Then
                        strWhere += " AND "
                    Else
                        strWhere += " WHERE "
                    End If
                    If PropiedadDestino.Name.Length >= 30 Then
                        If aliasTabla <> "" Then
                            strWhere += String.Format("{0}.{1} = @{2} {3}", aliasTabla, atributoColumna.Storage, PropiedadDestino.Name.Substring(0, 29), vbCrLf)
                        Else
                            strWhere += String.Format("{0} = @{1} {2}", atributoColumna.Storage, PropiedadDestino.Name.Substring(0, 29), vbCrLf)
                        End If
                    Else
                        If aliasTabla <> "" Then
                            strWhere += String.Format("{0}.{1} = @{2} {3}", aliasTabla, atributoColumna.Storage, PropiedadDestino.Name, vbCrLf)
                        Else
                            strWhere += String.Format("{0} = @{1} {2}", atributoColumna.Storage, PropiedadDestino.Name, vbCrLf)
                        End If
                    End If
                    countArgs += 1
                    Dim i As Integer = 0
                    If countArgs - 1 > 0 Then
                        Dim tempArgs As Object = args
                        ReDim args(countArgs - 1)
                        For Each arg As IDbDataParameter In tempArgs
                            args(i) = arg
                            i += 1
                        Next
                    End If
                    args(i) = Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", ""))
                    args(i).SqlDbType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
                    If PropiedadDestino.Name.Length >= 30 Then
                        args(i).ParameterName = "@" & PropiedadDestino.Name.Substring(0, 29)
                    Else
                        args(i).ParameterName = "@" & PropiedadDestino.Name
                    End If
                    args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                End If
            End If
        Next
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Método que genera el Query de Select a partir de la entidad que recibe de parámetro
    ''' </summary>
    ''' <param name="entity"></param>
    ''' <param name="args"></param>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function QuerySelect(ByVal entity As entidadBase, Optional ByRef args() As SqlParameter = Nothing, Optional ByVal aliasTable As String = "") As String

        Dim tipoEntidad As Type = entity.GetType()
        Dim tipoParametro As Type
        If args IsNot Nothing Then
            tipoParametro = args.GetType()
        Else
            tipoParametro = Nothing
        End If
        Dim strSql As New StringBuilder
        Dim strCampos As String = ""
        Dim strWhere As String = ""
        Dim countArgs As Integer = 0

        Dim atributoTabla As TableAttribute = _
        CType(Attribute.GetCustomAttribute(tipoEntidad, GetType(TableAttribute)), TableAttribute)

        strSql.Append(" SELECT ")

        QuerySelectCampos(entity, args, tipoEntidad, tipoParametro, strCampos, strWhere, countArgs)

        strSql.Append(strCampos)

        If aliasTable <> "" Then
            strSql.Append(String.Format(" FROM {0} {1} {2}", atributoTabla.Name, aliasTable, vbCrLf))
        Else
            strSql.Append(String.Format(" FROM {0} {1}", atributoTabla.Name, vbCrLf))
        End If

        strSql.Append(strWhere)

        Return strSql.ToString()

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Método que genera el Query de Delete a partir de la entidad que recibe de parámetro
    ''' </summary>
    ''' <param name="entity"></param>
    ''' <param name="args"></param>
    ''' <param name="aTipoConcurrencia"></param>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function QueryDelete(ByVal entity As entidadBase, ByRef args() As SqlParameter, Optional ByVal aTipoConcurrencia As TipoConcurrencia = TipoConcurrencia.Pesimistica) As String

        Dim tipoEntidad As Type = entity.GetType()
        Dim tipoParametro As Type = args.GetType()
        Dim strSql As New StringBuilder
        Dim strWhere As String = ""
        Dim countArgs As Integer = 0

        Dim atributoTabla As TableAttribute = _
        CType(Attribute.GetCustomAttribute(tipoEntidad, GetType(TableAttribute)), TableAttribute)

        strSql.Append(" DELETE FROM " + atributoTabla.Name + " " + vbCrLf)

        For Each PropiedadOrigen As PropertyInfo In tipoEntidad.GetProperties()

            Dim atributoColumna As ColumnAttribute
            Dim PropiedadDestino As PropertyInfo = tipoEntidad.GetProperty(PropiedadOrigen.Name)
            atributoColumna = CType(Attribute.GetCustomAttribute(PropiedadOrigen, GetType(ColumnAttribute)), ColumnAttribute)

            If Not PropiedadDestino Is Nothing And Not atributoColumna Is Nothing Then
                'strSql.Append(" " + atributoColumna.Storage + " = @" + PropiedadDestino.Name + "" + vbCrLf)
                If aTipoConcurrencia = TipoConcurrencia.Pesimistica Then
                    If atributoColumna.Id Then
                        If strWhere <> "" Then
                            strWhere += " AND "
                        Else
                            strWhere += " WHERE "
                        End If
                        If PropiedadDestino.Name.Length >= 30 Then
                            strWhere += atributoColumna.Storage + " = @" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
                        Else
                            strWhere += atributoColumna.Storage + " = @" + PropiedadDestino.Name + " " + vbCrLf
                        End If
                        countArgs += 1
                        Dim i As Integer = 0
                        If countArgs - 1 > 0 Then
                            Dim tempArgs As Object = args
                            ReDim args(countArgs - 1)
                            For Each arg As IDbDataParameter In tempArgs
                                args(i) = arg
                                i += 1
                            Next
                        End If
                        args(i) = Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", ""))
                        If PropiedadDestino.Name.Length >= 30 Then
                            args(i).ParameterName = "@" & PropiedadDestino.Name.Substring(0, 29)
                        Else
                            args(i).ParameterName = "@" & PropiedadDestino.Name
                        End If
                        args(i).SqlDbType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
                        args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                    End If
                Else
                    Dim PropiedadOld As PropertyInfo = Nothing
                    Try
                        PropiedadOld = tipoEntidad.GetProperty(PropiedadOrigen.Name + "Old")
                    Catch ex As Exception
                    End Try
                    If strWhere <> "" Then
                        strWhere += " AND "
                    Else
                        strWhere += " WHERE "
                    End If
                    countArgs += 1
                    Dim i As Integer = 0
                    If countArgs - 1 > 0 Then
                        Dim tempArgs As Object = args
                        ReDim args(countArgs - 1)
                        For Each arg As IDbDataParameter In tempArgs
                            args(i) = arg
                            i += 1
                        Next
                    End If
                    If atributoColumna.Id Then
                        If PropiedadDestino.Name.Length >= 30 Then
                            strWhere += atributoColumna.Storage + " = @" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
                        Else
                            strWhere += atributoColumna.Storage + " = @" + PropiedadDestino.Name + " " + vbCrLf
                        End If
                        args(i) = Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", ""))
                        args(i).SqlDbType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
                        If PropiedadDestino.Name.Length >= 30 Then
                            args(i).ParameterName = "@" & PropiedadDestino.Name.Substring(0, 29)
                        Else
                            args(i).ParameterName = "@" & PropiedadDestino.Name
                        End If
                        args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                    Else
                        If PropiedadOld.Name.Length >= 30 Then
                            strWhere += atributoColumna.Storage + " = @" + PropiedadOld.Name.Substring(0, 26) + "Old" + vbCrLf
                        Else
                            strWhere += atributoColumna.Storage + " = @" + PropiedadOld.Name + vbCrLf
                        End If
                        args(i) = Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", ""))
                        args(i).SqlDbType = Me.TipoParametro(PropiedadOld.PropertyType.FullName)
                        If PropiedadOld.Name.Length >= 30 Then
                            args(i).ParameterName = "@" & PropiedadOld.Name.Substring(0, 26) + "Old"
                        Else
                            args(i).ParameterName = "@" & PropiedadOld.Name
                        End If
                        args(i).Value = PropiedadOld.GetValue(entity, Nothing)
                    End If

                End If
            End If
        Next
        strSql.Append(strWhere)
        Return strSql.ToString()
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Método que genera el Query de Insert a partir de la entidad que recibe de parámetro
    ''' </summary>
    ''' <param name="entity"></param>
    ''' <param name="args"></param>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function QueryInsert(ByVal entity As entidadBase, ByRef args() As SqlParameter) As String

        Dim tipoEntidad As Type = entity.GetType()
        Dim tipoParametro As Type = args.GetType()
        Dim strSql As New StringBuilder
        Dim strInsert As String = ""
        Dim strValues As String = ""
        Dim countArgs As Integer = 0

        Dim atributoTabla As TableAttribute = _
        CType(Attribute.GetCustomAttribute(tipoEntidad, GetType(TableAttribute)), TableAttribute)

        strSql.Append(" INSERT INTO " + atributoTabla.Name + " (" + vbCrLf)

        For Each PropiedadOrigen As PropertyInfo In tipoEntidad.GetProperties()

            Dim atributoColumna As ColumnAttribute
            Dim atributoDataObject As DataObjectFieldAttribute
            Dim PropiedadDestino As PropertyInfo = tipoEntidad.GetProperty(PropiedadOrigen.Name)
            atributoColumna = CType(Attribute.GetCustomAttribute(PropiedadOrigen, GetType(ColumnAttribute)), ColumnAttribute)
            atributoDataObject = CType(Attribute.GetCustomAttribute(PropiedadOrigen, GetType(DataObjectFieldAttribute)), DataObjectFieldAttribute)

            If Not PropiedadDestino Is Nothing And Not atributoColumna Is Nothing Then
                If Not atributoDataObject.IsIdentity Then
                    If strValues <> "" Then
                        strInsert += " , " + atributoColumna.Storage + " " + vbCrLf
                    Else
                        strInsert += atributoColumna.Storage + " " + vbCrLf
                    End If
                    If strValues <> "" Then
                        strValues += " , "
                    Else
                        strValues += " VALUES ( "
                    End If
                    If PropiedadDestino.Name.Length >= 30 Then
                        strValues += " @" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
                    Else
                        strValues += " @" + PropiedadDestino.Name + " " + vbCrLf
                    End If
                    countArgs += 1
                    Dim i As Integer = 0
                    If countArgs - 1 > 0 Then
                        Dim tempArgs As Object = args
                        ReDim args(countArgs - 1)
                        For Each arg As IDbDataParameter In tempArgs
                            args(i) = arg
                            i += 1
                        Next
                    End If
                    args(i) = Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", ""))
                    args(i).SqlDbType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
                    'If PropiedadDestino.Name.Length >= 30 Then
                    '    args(i).ParameterName = "@" & PropiedadDestino.Name.Substring(0, 29)
                    'Else
                    '    args(i).ParameterName = "@" & PropiedadDestino.Name
                    'End If
                    args(i).ParameterName = "@" & PropiedadDestino.Name

                    If (PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date")) OrElse _
                           (PropiedadDestino.GetValue(entity, Nothing) IsNot Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date") AndAlso _
                           (DateTime.Compare(CDate(PropiedadDestino.GetValue(entity, Nothing)), #12:00:00 AM#)) = 0) Then
                        args(i).Value = DBNull.Value
                    ElseIf PropiedadDestino.GetValue(entity, Nothing) = Nothing And _
                        (PropiedadDestino.PropertyType.Name = "String") = -1 Then
                        args(i).Value = DBNull.Value
                    ElseIf (PropiedadDestino.PropertyType.Name = "Int16") Or _
                            (PropiedadDestino.PropertyType.Name = "Int32") Or _
                            (PropiedadDestino.PropertyType.Name = "Int64") Or _
                            (PropiedadDestino.PropertyType.Name = "Integer") Or _
                            (PropiedadDestino.PropertyType.Name = "Decimal") Then
                        args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                        If args(i).Value = -1 Then
                            args(i).Value = DBNull.Value
                        End If
                    Else
                        args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                    End If
                    If atributoColumna.DBType.ToUpper <> "TEXT" Then

                        Select Case args(i).SqlDbType
                            Case SqlDbType.Char, SqlDbType.NChar, SqlDbType.NVarChar, SqlDbType.VarChar
                                args(i).Size = atributoDataObject.Length
                                If atributoDataObject.Length > 0 Then
                                    If Not args(i).Value Is DBNull.Value AndAlso CType(args(i).Value, String).Length > atributoDataObject.Length Then
                                        Throw New Exception("El campo " + PropiedadDestino.Name + " de la tabla " + atributoTabla.Name + " tiene una longitud menor a la recibida.")
                                    End If
                                End If
                            Case Else
                        End Select
                    End If
                End If
            End If
        Next
        strSql.Append(strInsert + " ) " + vbCrLf)
        strSql.Append(strValues + " ) " + vbCrLf)
        Return strSql.ToString()
    End Function

    Public Function UsuarioActualiza() As String
        Return configuracion.usuarioActualiza
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Método que devuelve el Tipo de Dato del Parametro segun el Tipo de Dato .Net recibido
    ''' </summary>
    ''' <param name="asTipo">Tipo de Dato .Net</param>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Function TipoParametro(ByVal asTipo As String) As SqlDbType
        Select Case asTipo
            Case "System.String"
                Return SqlDbType.VarChar
            Case "System.Decimal"
                Return SqlDbType.Decimal
            Case "System.Double"
                Return SqlDbType.Float
            Case "System.Date"
                Return SqlDbType.DateTime
            Case "System.DateTime"
                Return SqlDbType.DateTime
            Case "System.Boolean"
                Return SqlDbType.Bit
            Case "System.Integer", "System.Int32"
                Return SqlDbType.Int
            Case "System.Long"
                Return SqlDbType.Int
            Case "System.Int16"
                Return SqlDbType.SmallInt
            Case "System.Single"
                Return SqlDbType.Real
            Case "System.Byte[]"
                Return SqlDbType.Image
            Case "System.Byte"
                Return SqlDbType.TinyInt
            Case "System.Guid"
                Return SqlDbType.UniqueIdentifier
            Case Else
                Return SqlDbType.VarChar
        End Select
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve una lista basada en la entidad recibida, en base a los
    ''' criterios de recuperación del arreglo enviado
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/08/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorBusqueda(ByVal aEntidad As entidadBase, ByVal aCriterios() As Criteria) As listaBase
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(aEntidad))
        Dim tipoEntidad As Type = aEntidad.GetType()
        Dim strWhere As String = ""
        Dim args(0) As SqlParameter
        Dim countArgs As Integer = 0

        For x As Integer = 0 To aCriterios.Length - 1
            Dim lCriterio As Criteria = aCriterios(x)
            Dim atributoColumna As ColumnAttribute
            Dim PropiedadDestino As PropertyInfo = tipoEntidad.GetProperty(lCriterio.ColumnName)
            atributoColumna = CType(Attribute.GetCustomAttribute(PropiedadDestino, GetType(ColumnAttribute)), ColumnAttribute)
            If strWhere = "" Then
                strWhere += " WHERE "
            Else
                strWhere += " " + aCriterios(x - 1).QueryOperator + " "
            End If
            Select Case lCriterio.Compare
                Case "%*%", "*%", "%*"
                    strWhere += atributoColumna.Storage + " LIKE @" + PropiedadDestino.Name + " " + vbCrLf
                Case Else
                    strWhere += atributoColumna.Storage + " " + lCriterio.Compare + " @" + PropiedadDestino.Name + " " + vbCrLf
            End Select
            'strWhere += atributoColumna.Storage + "  @" + PropiedadDestino.Name + " " + vbCrLf
            countArgs += 1
            Dim i As Integer = 0
            If countArgs - 1 > 0 Then
                Dim tempArgs As Object = args
                ReDim args(countArgs - 1)
                For Each arg As IDbDataParameter In tempArgs
                    args(i) = arg
                    i += 1
                Next
            End If
            args(i) = Assembly.GetAssembly(GetType(SqlParameter)).CreateInstance(GetType(SqlParameter).FullName.Replace("[]", ""))
            args(i).ParameterName = PropiedadDestino.Name
            Select Case lCriterio.Compare
                Case "%*%"
                    args(i).Value = "%" + PropiedadDestino.GetValue(aEntidad, Nothing) + "%"
                Case "*%"
                    args(i).Value = PropiedadDestino.GetValue(aEntidad, Nothing) + "%"
                Case "%*"
                    args(i).Value = "%" + PropiedadDestino.GetValue(aEntidad, Nothing)
                Case Else
                    args(i).Value = PropiedadDestino.GetValue(aEntidad, Nothing)
            End Select
        Next
        strSQL.Append(strWhere)

        Dim dr As IDataReader
        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As listaBase = System.Reflection.Assembly.Load("SISPACAL_EL").CreateInstance("SISPACAL.EL.lista" + tipoEntidad.Name)

        Try
            Do While dr.Read()
                Dim mEntidad As entidadBase = System.Reflection.Assembly.Load("SISPACAL_EL").CreateInstance("SISPACAL.EL." + tipoEntidad.Name)
                Me.CargarEntidad(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            If Not dr Is Nothing Then dr.Close()
        End Try

        Return lista

    End Function

    Public Sub AgregarCondicion(ByRef sql As StringBuilder, ByVal condicion As String, Optional ByVal tipoCondicion As String = " WHERE ")
        If sql.Length = 0 Then sql.Append(tipoCondicion) Else sql.Append(" AND ")
        sql.AppendLine(condicion)
    End Sub
End Class
