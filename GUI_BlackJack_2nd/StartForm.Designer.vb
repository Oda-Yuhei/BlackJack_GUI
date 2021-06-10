<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MyCoinTextBox = New System.Windows.Forms.TextBox()
        Me.MyCoinLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MinimumTextBox = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.GUI_BlackJack_2nd.My.Resources.Resources.Strat_button
        Me.PictureBox1.Location = New System.Drawing.Point(333, 393)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {""})
        Me.ComboBox1.Location = New System.Drawing.Point(333, 347)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(207, 27)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.Text = "対戦人数を選択してください"
        '
        'MyCoinTextBox
        '
        Me.MyCoinTextBox.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MyCoinTextBox.Location = New System.Drawing.Point(333, 195)
        Me.MyCoinTextBox.Name = "MyCoinTextBox"
        Me.MyCoinTextBox.Size = New System.Drawing.Size(207, 29)
        Me.MyCoinTextBox.TabIndex = 2
        '
        'MyCoinLabel
        '
        Me.MyCoinLabel.AutoSize = True
        Me.MyCoinLabel.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.MyCoinLabel.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MyCoinLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MyCoinLabel.Location = New System.Drawing.Point(311, 160)
        Me.MyCoinLabel.Name = "MyCoinLabel"
        Me.MyCoinLabel.Size = New System.Drawing.Size(293, 22)
        Me.MyCoinLabel.TabIndex = 3
        Me.MyCoinLabel.Text = "所持コインを設定してください。(100以上)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(311, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Minimum Bet"
        '
        'MinimumTextBox
        '
        Me.MinimumTextBox.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MinimumTextBox.Location = New System.Drawing.Point(333, 288)
        Me.MinimumTextBox.Name = "MinimumTextBox"
        Me.MinimumTextBox.ReadOnly = True
        Me.MinimumTextBox.Size = New System.Drawing.Size(207, 29)
        Me.MinimumTextBox.TabIndex = 5
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GUI_BlackJack_2nd.My.Resources.Resources.backimage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(878, 525)
        Me.Controls.Add(Me.MinimumTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MyCoinLabel)
        Me.Controls.Add(Me.MyCoinTextBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "StartForm"
        Me.Text = "StartForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MyCoinTextBox As TextBox
    Friend WithEvents MyCoinLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MinimumTextBox As TextBox
End Class
