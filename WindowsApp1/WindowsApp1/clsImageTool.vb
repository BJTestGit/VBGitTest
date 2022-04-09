'圖形工具
Public Class clsImageTool

    Private dicAnimation As Dictionary(Of String, clsAnimation)
    Private doubleBufferImage As Image

    Public Sub LoadAnimations()
        dicAnimation = New Dictionary(Of String, clsAnimation)
        dicAnimation.Clear()

        Dim strAnimName As String = "Animation1"
        Dim objAnimation As New clsAnimation
        Dim lstImageNames As New List(Of String)
        Dim lstAnimEndTime As New List(Of Long)
        For i As Integer = 0 To lstImageNames.Count - 1
            Dim img As Image = funGetImage(lstImageNames(i))
            objAnimation.AddFrame(img, lstAnimEndTime(i))
        Next
        dicAnimation.Add(strAnimName, objAnimation)

    End Sub

    Private Function funGetImage(ByVal FileName As String) As Image
        '可以在此檢查圖片是否存在, 提供預設圖檔
        '可以在縮放圖片, 並進行特效處理
        Return Image.FromFile(FileName)
    End Function

    Public Sub Draw(ByVal g As Graphics)
        '畫背景, 再畫物件
        'g.DrawImage(bgImage, 0, 0)
        'g.DrawImage(anim.getImage, 0, 0)
    End Sub

End Class
