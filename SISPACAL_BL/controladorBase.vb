Imports System.Reflection
Public Class controladorBase
    'Inherits System.EnterpriseServices.ServicedComponent
    Public sError As String
    Public sErrorTecnico As String

    Public Function ObtenerListaPorBusqueda(ByVal aEntidad As entidadBase, ByVal aCriterios() As Criteria) As ListaBase
        Try
            Dim tipoEntidad As Type = aEntidad.GetType()
            Dim lDB As dbBase = System.Reflection.Assembly.Load("SISPACAL_DL").CreateInstance("SISPACAL.DL.db" + tipoEntidad.Name)
            Return lDB.ObtenerListaPorBusqueda(aEntidad, aCriterios)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
