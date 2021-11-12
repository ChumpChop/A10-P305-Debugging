Public Class Computer
    Implements IDisposable

    Private disposedValue As Boolean

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects)
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
            ' TODO: set large fields to null
            disposedValue = True
        End If
    End Sub

    ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
    ' Protected Overrides Sub Finalize()
    '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
    '     Dispose(disposing:=False)
    '     MyBase.Finalize()
    ' End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub

    Public ReadOnly Property FreeMemory() As String
        Get
            'Using the My namespace
            Return Format((
            My.Computer.Info.AvailablePhysicalMemory.ToString _
            / 1024),
            "#,###,##0") & " K"
        End Get
    End Property
    Public ReadOnly Property TotalMemory() As String
        Get
            'Using the My namespace
            Return Format(
            My.Computer.Info.TotalPhysicalMemory.ToString / 1024,
            "#,###,##0") & " K"
        End Get
    End Property
End Class
