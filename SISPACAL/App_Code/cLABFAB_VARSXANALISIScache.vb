Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

<System.ComponentModel.DataObject()> _
Public Class cLABFAB_VARSXANALISIScache
    Private _SESION As HttpSessionState

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerLista(ByVal nombreSesion As String) As listaLABFAB_VARSXANALISIS
        Try
            Dim lista As listaLABFAB_VARSXANALISIS
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion) Is Nothing Then Return New listaLABFAB_VARSXANALISIS
            lista = TryCast(_SESION(nombreSesion), listaLABFAB_VARSXANALISIS)
            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function Eliminar(ByVal ID_VARXANALISIS As Int32,
                             ByVal REFERENCIA As String) As Integer

        Try
            _SESION = HttpContext.Current.Session
            Dim mVars As listaLABFAB_VARSXANALISIS = _SESION(REFERENCIA)

            If ID_VARXANALISIS > 0 AndAlso mVars IsNot Nothing Then
                For i As Integer = 0 To mVars.Count - 1
                    If mVars(i).ID_VARXANALISIS = ID_VARXANALISIS Then
                        mVars.RemoveAt(i)
                    End If
                Next
            End If
            _SESION(REFERENCIA) = mVars
            Return 1
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function Actualizar(ByVal ID_VARXANALISIS As Int32, ByVal ID_ANALISISXDIA As Int32, _
                                    ByVal ID_VAR As Int32, ByVal NOMBRE_VAR As String, _
                                    ByVal VALOR As Decimal, _
                                    ByVal REFERENCIA As String) As Int32

        Try
            Dim lVar As LABFAB_VAR = (New cLABFAB_VAR).ObtenerLABFAB_VAR(ID_VAR)
            Dim lEntidad As New LABFAB_VARSXANALISIS
            lEntidad.ID_VARXANALISIS = ID_VARXANALISIS
            lEntidad.ID_ANALISISXDIA = ID_ANALISISXDIA
            lEntidad.ID_VAR = ID_VAR
            lEntidad.NOMBRE_VAR = NOMBRE_VAR
            If lVar IsNot Nothing AndAlso (lVar.ID_TIPOVAR = 1 OrElse lVar.ID_TIPOVAR = 2) Then
                lEntidad.VALOR = Math.Round(VALOR, 2)
            End If
            lEntidad.REFERENCIA = REFERENCIA

            _SESION = HttpContext.Current.Session
            Dim mVars As listaLABFAB_VARSXANALISIS = _SESION(REFERENCIA)

            If mVars IsNot Nothing Then
                For i As Integer = 0 To mVars.Count - 1
                    If mVars(i).ID_VARXANALISIS = lEntidad.ID_VARXANALISIS Then
                        mVars(i) = lEntidad
                    End If
                Next
            End If

            _SESION(REFERENCIA) = mVars
            Return 1

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function Agregar(ByVal ID_VARXANALISIS As Int32, ByVal ID_ANALISISXDIA As Int32, _
                                    ByVal ID_VAR As Int32, ByVal NOMBRE_VAR As String, _
                                    ByVal VALOR As Decimal, _
                                    ByVal REFERENCIA As String) As Int32
        Try
            Dim Id As Int32 = 1
            Dim lTipoVar As LABFAB_VAR = (New cLABFAB_VAR).ObtenerLABFAB_VAR(ID_VAR)
            Dim lEntidad As New LABFAB_VARSXANALISIS
            lEntidad.ID_VARXANALISIS = ID_VARXANALISIS
            lEntidad.ID_ANALISISXDIA = ID_ANALISISXDIA
            lEntidad.ID_VAR = ID_VAR
            lEntidad.NOMBRE_VAR = NOMBRE_VAR
            If lTipoVar IsNot Nothing AndAlso lTipoVar.ID_TIPOVAR <> 1 AndAlso lTipoVar.ID_TIPOVAR <> 2 Then
                lEntidad.VALOR = Math.Round(VALOR, 2)
            End If
            lEntidad.REFERENCIA = REFERENCIA

            _SESION = HttpContext.Current.Session
            Dim mVars As listaLABFAB_VARSXANALISIS = _SESION(REFERENCIA)

            If mVars IsNot Nothing Then
                If mVars.Count > 0 Then
                    For i As Integer = 0 To mVars.Count - 1
                        If mVars(i).ID_VARXANALISIS > Id Then
                            Id = mVars(i).ID_VARXANALISIS
                        End If
                    Next
                    Id += 1
                End If
            End If
            lEntidad.ID_VARXANALISIS = Id
            mVars.Add(lEntidad)

            _SESION(REFERENCIA) = mVars
            Return 1
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
