Imports System.Threading

Public Class AsyncHelper
    Private Shared ReadOnly _myTaskFactory As TaskFactory = New TaskFactory(CancellationToken.None, TaskCreationOptions.None, TaskContinuationOptions.None, TaskScheduler.[Default])

    Public Shared Function RunSync(Of TResult)(ByVal func As Func(Of Task(Of TResult))) As TResult
        Return _myTaskFactory.StartNew(func).Unwrap().GetAwaiter().GetResult()
    End Function

    Public Shared Sub RunSync(ByVal func As Func(Of Task))
        _myTaskFactory.StartNew(func).Unwrap().GetAwaiter().GetResult()
    End Sub

End Class