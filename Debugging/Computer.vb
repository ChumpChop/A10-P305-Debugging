Public Class Computer
    Implements IDisposable

    Private disposedValue As Boolean = False    ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: free other state (managed objects).
            End If

            ' TODO: free your own state (unmanaged objects).
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement
    ' the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in
        ' Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

    Public ReadOnly Property FreeMemory() As String
        Get
            'Using the My namespace
            Return Format(( _
                My.Computer.Info.AvailablePhysicalMemory.ToString \ 1024), _
                "#,###,##0") & " K"
        End Get
    End Property

    Public ReadOnly Property TotalMemory() As String
        Get
            'Using the My namespace
            Return Format(( _
                My.Computer.Info.TotalPhysicalMemory.ToString \ 1024), _
                "#,###,##0") & " K"
        End Get
    End Property

End Class
