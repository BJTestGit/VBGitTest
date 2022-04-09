Imports System.Threading

Public Class frmMain

    Private m_cts As CancellationTokenSource = New CancellationTokenSource

    Private Async Sub BtnAsyncStart_Click(sender As Object, e As EventArgs) Handles BtnAsyncStart.Click

        If Me.m_cts.IsCancellationRequested Then
            Return
        End If

        Label1.Text = ""
        Label2.Text = ""
        Dim progress = New Progress(Of ProgressInfo)()
        AddHandler progress.ProgressChanged, Sub(o, info)
                                                 Label1.Text = info.Data.ToString()
                                             End Sub

        Dim maskTask = Await Task.Factory.StartNew(Function() SumAsync(Me.m_cts.Token, progress))
        Dim status = String.Format("任務完成，完成狀態為：" & vbCrLf & "IsCanceled={0}" & vbCrLf & "IsCompleted={1}" & vbCrLf & "IsFaulted={2}" & vbCrLf, maskTask.IsCanceled, maskTask.IsCompleted, maskTask.IsFaulted)

        If Not maskTask.IsCanceled AndAlso Not maskTask.IsFaulted Then
            status += String.Format(vbCrLf & "計算結果:{0}", maskTask.Result)
        End If

        Label2.Text = status.ToString()


    End Sub

    Private Async Function SumAsync(ByVal cancellationToken As CancellationToken, ByVal progress As IProgress(Of ProgressInfo)) As Task(Of Long)
        Dim sum As Long = 0
        Dim info = New ProgressInfo()

        For i As Integer = 0 To 1000 - 1

            If cancellationToken.IsCancellationRequested Then
                cancellationToken.ThrowIfCancellationRequested()
            End If

            sum += 1

            If progress IsNot Nothing Then
                info.Data = sum
                progress.Report(info)
            End If

            SpinWait.SpinUntil(Function()

                                   If cancellationToken.IsCancellationRequested Then
                                       cancellationToken.ThrowIfCancellationRequested()
                                   End If

                                   Return False
                               End Function, 10)
        Next

        Return sum
    End Function

    Private Function SumAsync1(ByVal cancellationToken As CancellationToken, ByVal progress As IProgress(Of ProgressInfo)) As Task(Of Long)
        Dim taskObj = Task.Factory.StartNew(Function()
                                                Dim sum As Long = 0
                                                Dim info = New ProgressInfo()

                                                For i As Integer = 0 To 100 - 1

                                                    If cancellationToken.IsCancellationRequested Then
                                                        cancellationToken.ThrowIfCancellationRequested()
                                                    End If

                                                    sum += 1

                                                    If progress IsNot Nothing Then
                                                        info.Data = sum
                                                        progress.Report(info)
                                                    End If

                                                    SpinWait.SpinUntil(Function()

                                                                           If cancellationToken.IsCancellationRequested Then
                                                                               cancellationToken.ThrowIfCancellationRequested()
                                                                           End If

                                                                           Return False
                                                                       End Function, 10)
                                                Next

                                                Return sum
                                            End Function)
        Return taskObj
    End Function

    Private Sub BtnAsyncStop_Click(sender As Object, e As EventArgs) Handles BtnAsyncStop.Click
        If Me.m_cts.IsCancellationRequested Then
            Exit Sub
        End If

        Me.m_cts.Cancel()
        m_cts = New CancellationTokenSource()
    End Sub

    Private Sub btnSyncStart_Click(sender As Object, e As EventArgs) Handles btnSyncStart.Click
        Sum()
    End Sub

    Private Function Sum() As Long
        Dim lngsum As Long = 0
        Dim info = New ProgressInfo()

        For i As Integer = 0 To 1000 - 1
            lngsum += 1
            SpinWait.SpinUntil(Function() False, 10)
        Next

        Return Sum
    End Function

End Class

Friend Class ProgressInfo
    Public Property Data As Long
End Class