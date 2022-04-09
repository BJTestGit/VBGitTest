<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnAsyncStart = New System.Windows.Forms.Button()
        Me.BtnAsyncStop = New System.Windows.Forms.Button()
        Me.btnSyncStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnAsyncStart
        '
        Me.BtnAsyncStart.Location = New System.Drawing.Point(34, 24)
        Me.BtnAsyncStart.Name = "BtnAsyncStart"
        Me.BtnAsyncStart.Size = New System.Drawing.Size(121, 41)
        Me.BtnAsyncStart.TabIndex = 0
        Me.BtnAsyncStart.Text = "btnAsyncStart"
        Me.BtnAsyncStart.UseVisualStyleBackColor = True
        '
        'BtnAsyncStop
        '
        Me.BtnAsyncStop.Location = New System.Drawing.Point(34, 71)
        Me.BtnAsyncStop.Name = "BtnAsyncStop"
        Me.BtnAsyncStop.Size = New System.Drawing.Size(121, 41)
        Me.BtnAsyncStop.TabIndex = 1
        Me.BtnAsyncStop.Text = "BtnAsyncStop"
        Me.BtnAsyncStop.UseVisualStyleBackColor = True
        '
        'btnSyncStart
        '
        Me.btnSyncStart.Location = New System.Drawing.Point(161, 24)
        Me.btnSyncStart.Name = "btnSyncStart"
        Me.btnSyncStart.Size = New System.Drawing.Size(121, 41)
        Me.btnSyncStart.TabIndex = 2
        Me.btnSyncStart.Text = "btnSyncStart"
        Me.btnSyncStart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 393)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSyncStart)
        Me.Controls.Add(Me.BtnAsyncStop)
        Me.Controls.Add(Me.BtnAsyncStart)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnAsyncStart As Button
    Friend WithEvents BtnAsyncStop As Button
    Friend WithEvents btnSyncStart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
