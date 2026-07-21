Partial Class DS_SIGESTA_MAPA
    Partial Class MapaTerciosDataTable

        Private Sub MapaTerciosDataTable_ColumnChanging(sender As System.Object, e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.TONELColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class
