<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomDateRangePicker
    Inherits System.Windows.Forms.UserControl

    'UserControl はコンポーネント一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FromDateTimePicker = New CommonDateRangePicker.CustomDateTimePicker
        Me.Label = New System.Windows.Forms.Label
        Me.ToDateTimePicker = New CommonDateRangePicker.CustomDateTimePicker
        Me.SuspendLayout()
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.DefaultCustomFormat = Nothing
        Me.FromDateTimePicker.Dock = System.Windows.Forms.DockStyle.Top
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.IsDeleteKeyOrBackSpaceKeyEnable = True
        Me.FromDateTimePicker.IsJapaneseCalender = False
        Me.FromDateTimePicker.IsReadOnly = False
        Me.FromDateTimePicker.Location = New System.Drawing.Point(0, 0)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(120, 19)
        Me.FromDateTimePicker.TabIndex = 0
        '
        'Label
        '
        Me.Label.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label.Location = New System.Drawing.Point(0, 19)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(120, 12)
        Me.Label.TabIndex = 1
        Me.Label.Text = "～"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.DefaultCustomFormat = Nothing
        Me.ToDateTimePicker.Dock = System.Windows.Forms.DockStyle.Top
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.IsDeleteKeyOrBackSpaceKeyEnable = True
        Me.ToDateTimePicker.IsJapaneseCalender = False
        Me.ToDateTimePicker.IsReadOnly = False
        Me.ToDateTimePicker.Location = New System.Drawing.Point(0, 31)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(120, 19)
        Me.ToDateTimePicker.TabIndex = 2
        '
        'CustomDateRangePicker2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.FromDateTimePicker)
        Me.Name = "CustomDateRangePicker2"
        Me.Size = New System.Drawing.Size(120, 55)
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents FromDateTimePicker As CustomDateTimePicker
    Protected WithEvents Label As System.Windows.Forms.Label
    Protected WithEvents ToDateTimePicker As CustomDateTimePicker

End Class
