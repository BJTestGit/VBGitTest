'動畫的框格
Public Class clsAnimFrame

    Public ReadOnly Property Image As Image
    Public ReadOnly Property EndTime As Long

    Public Sub New(ByVal Image As Image, ByVal EndTime As Long)
        Me.Image = Image
        Me.EndTime = EndTime
    End Sub

End Class
