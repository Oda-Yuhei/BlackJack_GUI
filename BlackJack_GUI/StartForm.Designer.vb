<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StratButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'StratButton
        '
        Me.StratButton.Location = New System.Drawing.Point(368, 360)
        Me.StratButton.Name = "StratButton"
        Me.StratButton.Size = New System.Drawing.Size(151, 66)
        Me.StratButton.TabIndex = 0
        Me.StratButton.Text = "Start"
        Me.StratButton.UseVisualStyleBackColor = True
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 524)
        Me.Controls.Add(Me.StratButton)
        Me.Name = "StartForm"
        Me.Text = "StartForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StratButton As Button
End Class
