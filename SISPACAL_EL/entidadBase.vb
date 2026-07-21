<Serializable()> Public MustInherit Class entidadBase
    Implements INotifyPropertyChanged

#Region " Privadas "
    Private _IsDirty As Boolean = False
#End Region

#Region " Properties "
    Public Property IsDirty() As Boolean
        Get
            Return Me._IsDirty
        End Get
        Set(ByVal value As Boolean)
            Me._IsDirty = value
        End Set
    End Property
#End Region

    Public Event PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(ByVal propertyName As String)
        Me.IsDirty = True
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

End Class
