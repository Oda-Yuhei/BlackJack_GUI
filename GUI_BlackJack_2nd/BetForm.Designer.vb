<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BetForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BetForm))
        Me.betcoinTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BetenterButton = New System.Windows.Forms.Button()
        Me.mycoinLabel = New System.Windows.Forms.Label()
        Me.NowBetcoinLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'betcoinTextBox
        '
        Me.betcoinTextBox.Location = New System.Drawing.Point(17, 91)
        Me.betcoinTextBox.Name = "betcoinTextBox"
        Me.betcoinTextBox.Size = New System.Drawing.Size(135, 22)
        Me.betcoinTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Coin"
        '
        'BetenterButton
        '
        Me.BetenterButton.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BetenterButton.Location = New System.Drawing.Point(81, 136)
        Me.BetenterButton.Name = "BetenterButton"
        Me.BetenterButton.Size = New System.Drawing.Size(89, 36)
        Me.BetenterButton.TabIndex = 2
        Me.BetenterButton.Text = "BET"
        Me.BetenterButton.UseVisualStyleBackColor = True
        '
        'mycoinLabel
        '
        Me.mycoinLabel.AutoSize = True
        Me.mycoinLabel.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.mycoinLabel.Location = New System.Drawing.Point(13, 13)
        Me.mycoinLabel.Name = "mycoinLabel"
        Me.mycoinLabel.Size = New System.Drawing.Size(98, 22)
        Me.mycoinLabel.TabIndex = 3
        Me.mycoinLabel.Text = "所持コイン："
        '
        'NowBetcoinLabel
        '
        Me.NowBetcoinLabel.AutoSize = True
        Me.NowBetcoinLabel.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.NowBetcoinLabel.Location = New System.Drawing.Point(13, 48)
        Me.NowBetcoinLabel.Name = "NowBetcoinLabel"
        Me.NowBetcoinLabel.Size = New System.Drawing.Size(108, 22)
        Me.NowBetcoinLabel.TabIndex = 4
        Me.NowBetcoinLabel.Text = "現在のBET："
        '
        'BetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 184)
        Me.Controls.Add(Me.NowBetcoinLabel)
        Me.Controls.Add(Me.mycoinLabel)
        Me.Controls.Add(Me.BetenterButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.betcoinTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BetForm"
        Me.Text = "BetForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents betcoinTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BetenterButton As Button
    Friend WithEvents mycoinLabel As Label
    Friend WithEvents NowBetcoinLabel As Label
End Class
