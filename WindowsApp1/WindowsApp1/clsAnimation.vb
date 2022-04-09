'動畫效果
Public Class clsAnimation

    Dim lstFrames As List(Of clsAnimFrame)
    Dim intCurrentFrameIndex As Integer
    Dim lngAnimTime As Long
    Dim lngTotalDuration As Long


    Public Sub AddFrame(ByVal Image As Image, ByVal Time As Long)
        If IsNothing(Image) Then
            Throw New Exception("圖形資料不存在無法加入")
        End If
        If Time <= 0 Then
            Throw New Exception("圖形顯示時間設定錯誤")
        End If
        lngTotalDuration += Time
        lstFrames.Add(New clsAnimFrame(Image, Time))
    End Sub

    Public Sub Start()
        lngAnimTime = 0
        intCurrentFrameIndex = 0
    End Sub

    Public Sub Update(ByVal ElapsedTime As Long)
        If lstFrames.Count > 1 Then
            lngAnimTime += ElapsedTime

            If lngAnimTime >= lngTotalDuration Then
                lngAnimTime = lngAnimTime Mod lngTotalDuration
                intCurrentFrameIndex = 0
            End If

            While lngAnimTime > funGetFrame(intCurrentFrameIndex).EndTime
                intCurrentFrameIndex += 1
            End While

        End If
    End Sub

    Public Function GetImage() As Image
        If lstFrames.Count = 0 Then
            Throw New Exception("圖片資源不存在")
        Else
            Return funGetFrame(intCurrentFrameIndex).Image
        End If
    End Function

    Private Function funGetFrame(ByVal CurrentFrameIndex As Integer) As clsAnimFrame
        If CurrentFrameIndex < lstFrames.Count Then
            Return lstFrames(CurrentFrameIndex)
        Else
            Throw New Exception("圖片資源不存在")
        End If
    End Function



End Class
