Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

Public Class Proforma

    Public Sub CargarProforma(ByVal ID_PROFORMA As Int32)
        Dim lProforma As SISPACAL.EL.PROFORMA = (New cPROFORMA).ObtenerPROFORMA(ID_PROFORMA)
        If lProforma IsNot Nothing Then
            Dim lProveedorRoza As PROVEEDOR_ROZA = (New cPROVEEDOR_ROZA).ObtenerPROVEEDOR_ROZA(lProforma.ID_PROVEEDOR_ROZA)
            Dim lCargadora As CARGADORA = (New cCARGADORA).ObtenerCARGADORA(lProforma.ID_CARGADORA)
            Dim lCargador As CARGADOR = (New cCARGADOR).ObtenerCARGADOR(lProforma.ID_CARGADOR)
            Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(lProforma.ACCESLOTE, lProforma.ID_ZAFRA)
            Dim lAgronomo As AGRONOMO
            Dim lUsuario As USUARIO = (New cUSUARIO).ObtenerUSUARIO(lProforma.USUARIO_CREA)
            Dim lTransporte As TRANSPORTE = (New cTRANSPORTE).ObtenerTRANSPORTEPorTRANSPORTISTA_PLACA(lProforma.CODTRANSPORT, lProforma.PLACAVEHIC)
            Dim lProveeQuerqueo As PROVEEDOR_QUERQUEO = (New cPROVEEDOR_QUERQUEO).ObtenerPROVEEDOR_QUERQUEO(lProforma.ID_PROVEE_QQ)


            If lTransporte IsNot Nothing Then
                Dim lTipoTrans As TIPO_TRANSPORTE = (New cTIPO_TRANSPORTE).ObtenerTIPO_TRANSPORTE(lTransporte.ID_TIPOTRANS)
                If lTipoTrans IsNot Nothing Then
                    xrTipoTransporte.Text = lTipoTrans.NOMBRE
                End If
            End If
            If lUsuario IsNot Nothing Then
                xrNOMBRE_USUARIO.Text = lUsuario.NOMBRE.ToUpper
            End If
            If lLoteCosecha IsNot Nothing Then
                xrEDAD_LOTE.Text = lLoteCosecha.EDAD_LOTE
                lAgronomo = (New cAGRONOMO).ObtenerAGRONOMO(lLoteCosecha.CODIAGRON)
                If lAgronomo IsNot Nothing Then xrTecnico.Text = "TECNICO: " + lAgronomo.NOMBRE_AGRONOMO + " " + lAgronomo.APELLIDO_AGRONOMO

                Dim lLote As LOTES = (New cLOTES).ObtenerLOTES(lLoteCosecha.ACCESLOTE)
                If lLote IsNot Nothing Then
                    Dim lMaestro As MAESTRO_LOTES = (New cMAESTRO_LOTES).ObtenerMAESTRO_LOTES(lLote.ID_MAESTRO)
                    If lMaestro IsNot Nothing Then
                        Me.xrHacienda.Text = lMaestro.HACIENDA
                    End If
                End If
            End If

            'ROZA
            If lProforma.ID_TIPO_ROZA = CAT.TipoRoza.RozaManualParticular OrElse _
               lProforma.ID_TIPO_ROZA = CAT.TipoRoza.RozaManualProductor Then
                'Manual
                xrROZA_MANUAL.Text = "X"
                If lProveedorRoza IsNot Nothing Then
                    xrROZA_MANUAL_CODI.Text = lProveedorRoza.ID_PROVEEDOR_ROZA
                    xrROZA_MANUAL_NOM.Text = lProveedorRoza.NOMBRE_PROVEEDOR_ROZA
                End If
                Select Case True
                    Case lProforma.ID_TIPO_ROZA = CAT.TipoRoza.RozaManualParticular
                        xrROZA_MANUAL_PARTICULAR.Text = "X"
                        If lProveedorRoza IsNot Nothing Then
                            'xrROZA_OPERADOR_CODI.Text = lProveedorRoza.ID_PROVEEDOR_ROZA
                            xrROZA_OPERADOR_NOM.Text = lProveedorRoza.NOMBRE_PROVEEDOR_ROZA
                        End If
                    Case lProforma.ID_TIPO_ROZA = CAT.TipoRoza.RozaManualProductor
                        xrROZA_MANUAL_PRODUCTOR.Text = "X"
                        If lProveedorRoza IsNot Nothing Then
                            'xrROZA_OPERADOR_CODI.Text = lProveedorRoza.ID_PROVEEDOR_ROZA
                            xrROZA_OPERADOR_NOM.Text = lProveedorRoza.NOMBRE_PROVEEDOR_ROZA
                        End If
                End Select
            Else
                'Cosechadora
                xrROZA_COSECHADORA.Text = "X"
                If lCargadora IsNot Nothing Then
                    xrROZA_COSECHADORA_CODI.Text = lCargadora.ID_CARGADORA
                    xrROZA_COSECHADORA_NOM.Text = lCargadora.NOMBRE
                End If
                Select Case True
                    Case lProforma.ID_TIPO_ALZA = CAT.TipoAlza.AlzaCosechadoraJiboa
                        xrROZA_COSECHADORA_JIBOA.Text = "X"
                    Case lProforma.ID_TIPO_ALZA = CAT.TipoAlza.AlzaCosechadoraParticular
                        xrROZA_COSECHADORA_PARTICULAR.Text = "X"
                    Case lProforma.ID_TIPO_ALZA = CAT.TipoAlza.AlzaCosechadoraProductor
                        xrROZA_COSECHADORA_PRODUCTOR.Text = "X"
                End Select
                If lProveedorRoza IsNot Nothing Then
                    'xrROZA_OPERADOR_CODI.Text = lProveedorRoza.ID_PROVEEDOR_ROZA
                    xrROZA_OPERADOR_NOM.Text = lProveedorRoza.NOMBRE_PROVEEDOR_ROZA
                End If
            End If


            'CARGA
            Select Case True
                Case lProforma.ID_TIPO_ALZA = CAT.TipoAlza.AlzaCosechadoraJiboa, lProforma.ID_TIPO_ALZA = CAT.TipoAlza.AlzaCargadoraJiboa
                    xrCARGA_CARGADORA.Text = "X"
                    xrCARGA_CARGADORA_JIBOA.Text = "X"
                    If lCargadora IsNot Nothing Then
                        xrCARGA_CARGADORA_CODI.Text = lCargadora.ID_CARGADORA
                        xrCARGA_CARGADORA_NOM.Text = lCargadora.NOMBRE
                    End If
                    If lCargador IsNot Nothing Then
                        xrCARGA_OPERADOR_CODI.Text = lCargador.ID_CARGADOR
                        xrCARGA_OPERADOR_NOM.Text = lCargador.NOMBRE_CARGADOR
                    End If
                Case lProforma.ID_TIPO_ALZA = CAT.TipoAlza.AlzaCosechadoraParticular, lProforma.ID_TIPO_ALZA = CAT.TipoAlza.AlzaCargadoraParticular
                    xrCARGA_CARGADORA.Text = "X"
                    xrCARGA_CARGADORA_PARTICULAR.Text = "X"
                    If lCargadora IsNot Nothing Then
                        xrCARGA_CARGADORA_CODI.Text = lCargadora.ID_CARGADORA
                        xrCARGA_CARGADORA_NOM.Text = lCargadora.NOMBRE
                    End If
                    If lCargador IsNot Nothing Then
                        xrCARGA_OPERADOR_CODI.Text = lCargador.ID_CARGADOR
                        xrCARGA_OPERADOR_NOM.Text = lCargador.NOMBRE_CARGADOR
                    End If
                Case lProforma.ID_TIPO_ALZA = CAT.TipoAlza.AlzaCosechadoraProductor, lProforma.ID_TIPO_ALZA = CAT.TipoAlza.AlzaCargadoraProductor
                    xrCARGA_CARGADORA.Text = "X"
                    xrCARGA_CARGADORA_PRODUCTOR.Text = "X"
                    If lCargadora IsNot Nothing Then
                        xrCARGA_CARGADORA_CODI.Text = lCargadora.ID_CARGADORA
                        xrCARGA_CARGADORA_NOM.Text = lCargadora.NOMBRE
                    End If
                    If lCargador IsNot Nothing Then
                        xrCARGA_OPERADOR_CODI.Text = lCargador.ID_CARGADOR
                        xrCARGA_OPERADOR_NOM.Text = lCargador.NOMBRE_CARGADOR
                    End If
                Case lProforma.ID_TIPO_ALZA = CAT.TipoAlza.AlzaManualParticular
                    xrCARGA_MANUAL.Text = "X"
                    xrCARGA_MANUAL_PARTICULAR.Text = "X"
                    If lCargadora IsNot Nothing Then
                        xrCARGA_MANUAL_CODI.Text = lCargadora.ID_CARGADORA
                        xrCARGA_MANUAL_NOM.Text = lCargadora.NOMBRE
                    End If
                    If lCargador IsNot Nothing Then
                        xrCARGA_OPERADOR_CODI.Text = lCargador.ID_CARGADOR
                        xrCARGA_OPERADOR_NOM.Text = lCargador.NOMBRE_CARGADOR
                    End If
                Case lProforma.ID_TIPO_ALZA = CAT.TipoAlza.AlzaManualProductor
                    xrCARGA_MANUAL.Text = "X"
                    xrCARGA_MANUAL_PRODUCTOR.Text = "X"
                    If lCargadora IsNot Nothing Then
                        xrCARGA_MANUAL_CODI.Text = lCargadora.ID_CARGADORA
                        xrCARGA_MANUAL_NOM.Text = lCargadora.NOMBRE
                    End If
                    If lCargador IsNot Nothing Then
                        xrCARGA_OPERADOR_CODI.Text = lCargador.ID_CARGADOR
                        xrCARGA_OPERADOR_NOM.Text = lCargador.NOMBRE_CARGADOR
                    End If
            End Select
            If Not lProforma.CANA_VERDE AndAlso lProforma.FECHA_QUEMA <> #12:00:00 AM# Then
                Me.xrQUEMA_DIA.Text = lProforma.FECHA_QUEMA.Day.ToString("00")
                Me.xrQUEMA_MES.Text = lProforma.FECHA_QUEMA.Month.ToString("00")
                Me.xrQUEMA_ANIO.Text = lProforma.FECHA_QUEMA.Year.ToString("0000")
                Me.xrQUEMA_HORA.Text = lProforma.FECHA_QUEMA.ToString("hh:mm tt")
            End If

            Me.xrROZA_DIA.Text = lProforma.FECHA_ROZA.Day.ToString("00")
            Me.xrROZA_MES.Text = lProforma.FECHA_ROZA.Month.ToString("00")
            Me.xrROZA_ANIO.Text = lProforma.FECHA_ROZA.Year.ToString("0000")
            Me.xrROZA_HORA.Text = lProforma.FECHA_ROZA.ToString("hh:mm tt")

            Me.xtrNOMBRE_MES.Text = Utilerias.NombreMes(lProforma.FECHA_CREA.Month)
            Me.xrES_QUERQUEO.Text = If(lProforma.ES_QUERQUEO, "X", "")
            Me.xrES_BARRIDO.Text = If(lProforma.ES_BARRIDA, "X", "")
            If lProveeQuerqueo IsNot Nothing Then
                Me.lblFrenteQuerqueo.Text = lProveeQuerqueo.CODISIS + "-" + lProveeQuerqueo.NOMBRES + " " + lProveeQuerqueo.APELLIDOS
            End If

        End If
        Me.DS_SIGESTA1.Clear()
        Me.ProformaTableAdapter1.FillPorIdProforma(Me.DS_SIGESTA1.PROFORMA, ID_PROFORMA)

        Me.DisplayName = "PROFORMA"
    End Sub
End Class