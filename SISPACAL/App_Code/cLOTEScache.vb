Imports Microsoft.VisualBasic
Imports SISPACAL.BL
Imports SISPACAL.EL

<System.ComponentModel.DataObject()> _
Public Class cLOTEScache
    Private _SESION As HttpSessionState

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal nombreSesion As String) As listaLOTES
        Try
            _SESION = HttpContext.Current.Session
            If _SESION(nombreSesion) Is Nothing Then Return New listaLOTES
            Return TryCast(_SESION(nombreSesion), listaLOTES)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarLOTES(ByVal ACCESLOTE As String, ByVal ANIOZAFRA As String, ByVal CODIPROVEEDOR As String, _
                                    ByVal CODILOTE As String, ByVal CODIAGRON As String, ByVal CODIVARIEDA As String, _
                                    ByVal CODIUBICACION As String, ByVal CODICONTRATO As String, ByVal NOMBLOTE As String, _
                                    ByVal AREA As Decimal, ByVal TONELADAS As Decimal, ByVal TONEL_TC As Decimal, _
                                    ByVal ZONA As String, ByVal SUB_ZONA As String, ByVal EDAD_LOTE As Decimal, ByVal USER_CREA As Int32, _
                                    ByVal FECHA_CREA As DateTime, ByVal USER_ACT As Int32, ByVal FECHA_ACT As DateTime, _
                                    ByVal ID_MAESTRO As Int32, ByVal TIPO_DERECHO As Int32, ByVal REFERENCIA As String, _
                                    ByVal CODISOCIO As String, ByVal ID_LOTE_TRASPASO As Int32, ByVal AREA_CANA As Decimal, _
                                    ByVal RIESGO_PIEDRA As Boolean, ByVal REPARA_ACCESO As Boolean, ByVal SIN_ACCESO_PROPIO As Boolean) As Integer

        Dim lEntidad As New LOTES
        lEntidad.ACCESLOTE = ACCESLOTE
        lEntidad.ANIOZAFRA = ANIOZAFRA
        lEntidad.CODIPROVEEDOR = CODIPROVEEDOR
        lEntidad.CODILOTE = CODILOTE
        lEntidad.CODIAGRON = CODIAGRON
        lEntidad.CODIVARIEDA = CODIVARIEDA
        lEntidad.CODIUBICACION = CODIUBICACION
        lEntidad.CODICONTRATO = CODICONTRATO
        lEntidad.NOMBLOTE = NOMBLOTE
        lEntidad.AREA = Math.Round(AREA, 2)
        lEntidad.TONELADAS = Math.Round(TONELADAS, 2)
        lEntidad.TONEL_TC = Math.Round(AREA * TONELADAS, 2)
        lEntidad.ZONA = ZONA
        lEntidad.SUB_ZONA = SUB_ZONA
        lEntidad.EDAD_LOTE = EDAD_LOTE
        lEntidad.USER_CREA = USER_CREA
        lEntidad.FECHA_CREA = FECHA_CREA
        lEntidad.USER_ACT = USER_ACT
        lEntidad.FECHA_ACT = FECHA_ACT
        lEntidad.ID_MAESTRO = ID_MAESTRO
        lEntidad.TIPO_DERECHO = TIPO_DERECHO
        lEntidad.ID_LOTE_TRASPASO = ID_LOTE_TRASPASO
        lEntidad.AREA_CANA = AREA_CANA
        lEntidad.RIESGO_PIEDRA = RIESGO_PIEDRA
        lEntidad.REPARA_ACCESO = REPARA_ACCESO
        lEntidad.SIN_ACCESO_PROPIO = SIN_ACCESO_PROPIO
        lEntidad.REFERENCIA = REFERENCIA

        If (lEntidad.AREA = 0 OrElse lEntidad.TONELADAS) = 0 Then
            Return -1
        End If
        If CODISOCIO <> "" Then
            lEntidad.CODISOCIO = CODISOCIO
            Dim lCodisocio As String = Left(CODIPROVEEDOR, 6) + Utilerias.FormatoCODISOCIO(lEntidad.CODISOCIO)
            Dim lSocio As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lCodisocio)
            If lSocio Is Nothing Then
                lEntidad.CODISOCIO = ""
            Else
                lEntidad.CODIPROVEEDOR = lSocio.CODIPROVEEDOR
            End If
        End If
        _SESION = HttpContext.Current.Session
        Dim mLotes As listaLOTES = _SESION(REFERENCIA)
        For i As Integer = 0 To mLotes.Count - 1
            If mLotes(i).ACCESLOTE = lEntidad.ACCESLOTE Then
                mLotes(i) = lEntidad
            End If
        Next
        _SESION(REFERENCIA) = mLotes
        Return 1
    End Function
End Class
