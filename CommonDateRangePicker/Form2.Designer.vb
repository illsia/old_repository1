<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CustomDateRangePicker1 = New CommonDateRangePicker.CustomDateRangePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.IsAllowSpaceCheckBox = New System.Windows.Forms.CheckBox
        Me.IsFromToLinkCheckBox = New System.Windows.Forms.CheckBox
        Me.IsKeyPressEnterToFocusMoveCheckBox = New System.Windows.Forms.CheckBox
        Me.IsLabelVisibleCheckBox = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomDateRangePicker1
        '
        Me.CustomDateRangePicker1.IsDateTimePickerAllowSpace = False
        Me.CustomDateRangePicker1.IsFromToLinkMinValueMaxValue = False
        Me.CustomDateRangePicker1.IsKeyPressEnterToFocusMove = False
        Me.CustomDateRangePicker1.IsLabelVisible = True
        Me.CustomDateRangePicker1.IsOrientation = CommonDateRangePicker.CustomDateRangePicker.IsOrientationEnum.Portrait
        Me.CustomDateRangePicker1.Location = New System.Drawing.Point(12, 12)
        Me.CustomDateRangePicker1.MyFromValue = New Date(2011, 10, 19, 11, 14, 49, 618)
        Me.CustomDateRangePicker1.MyIsFromValue = True
        Me.CustomDateRangePicker1.MyIsToValue = True
        Me.CustomDateRangePicker1.MyToValue = New Date(2011, 10, 19, 11, 14, 49, 602)
        Me.CustomDateRangePicker1.Name = "CustomDateRangePicker1"
        Me.CustomDateRangePicker1.Size = New System.Drawing.Size(120, 51)
        Me.CustomDateRangePicker1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(116, 70)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "IsOrientation"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(14, 40)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(74, 16)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.Text = "Horizontal"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(14, 18)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(61, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Portrait"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'IsAllowSpaceCheckBox
        '
        Me.IsAllowSpaceCheckBox.AutoSize = True
        Me.IsAllowSpaceCheckBox.Location = New System.Drawing.Point(134, 91)
        Me.IsAllowSpaceCheckBox.Name = "IsAllowSpaceCheckBox"
        Me.IsAllowSpaceCheckBox.Size = New System.Drawing.Size(94, 16)
        Me.IsAllowSpaceCheckBox.TabIndex = 2
        Me.IsAllowSpaceCheckBox.Text = "日付欄の空白"
        Me.IsAllowSpaceCheckBox.UseVisualStyleBackColor = True
        '
        'IsFromToLinkCheckBox
        '
        Me.IsFromToLinkCheckBox.AutoSize = True
        Me.IsFromToLinkCheckBox.Location = New System.Drawing.Point(134, 113)
        Me.IsFromToLinkCheckBox.Name = "IsFromToLinkCheckBox"
        Me.IsFromToLinkCheckBox.Size = New System.Drawing.Size(105, 16)
        Me.IsFromToLinkCheckBox.TabIndex = 2
        Me.IsFromToLinkCheckBox.Text = "FromとToがリンク"
        Me.IsFromToLinkCheckBox.UseVisualStyleBackColor = True
        '
        'IsKeyPressEnterToFocusMoveCheckBox
        '
        Me.IsKeyPressEnterToFocusMoveCheckBox.AutoSize = True
        Me.IsKeyPressEnterToFocusMoveCheckBox.Location = New System.Drawing.Point(134, 135)
        Me.IsKeyPressEnterToFocusMoveCheckBox.Name = "IsKeyPressEnterToFocusMoveCheckBox"
        Me.IsKeyPressEnterToFocusMoveCheckBox.Size = New System.Drawing.Size(145, 16)
        Me.IsKeyPressEnterToFocusMoveCheckBox.TabIndex = 2
        Me.IsKeyPressEnterToFocusMoveCheckBox.Text = "Enter押下でﾌｫｰｶｽ移動"
        Me.IsKeyPressEnterToFocusMoveCheckBox.UseVisualStyleBackColor = True
        '
        'IsLabelVisibleCheckBox
        '
        Me.IsLabelVisibleCheckBox.AutoSize = True
        Me.IsLabelVisibleCheckBox.Location = New System.Drawing.Point(134, 157)
        Me.IsLabelVisibleCheckBox.Name = "IsLabelVisibleCheckBox"
        Me.IsLabelVisibleCheckBox.Size = New System.Drawing.Size(85, 16)
        Me.IsLabelVisibleCheckBox.TabIndex = 2
        Me.IsLabelVisibleCheckBox.Text = "ラベルを表示"
        Me.IsLabelVisibleCheckBox.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 199)
        Me.Controls.Add(Me.IsLabelVisibleCheckBox)
        Me.Controls.Add(Me.IsKeyPressEnterToFocusMoveCheckBox)
        Me.Controls.Add(Me.IsFromToLinkCheckBox)
        Me.Controls.Add(Me.IsAllowSpaceCheckBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CustomDateRangePicker1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomDateRangePicker1 As CommonDateRangePicker.CustomDateRangePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents IsAllowSpaceCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IsFromToLinkCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IsKeyPressEnterToFocusMoveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IsLabelVisibleCheckBox As System.Windows.Forms.CheckBox
End Class
