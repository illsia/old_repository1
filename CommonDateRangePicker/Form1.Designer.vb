<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.CustomDateRangePicker2 = New CommonDateRangePicker.CustomDateRangePicker
        Me.CustomDateRangePicker3 = New CommonDateRangePicker.CustomDateRangePicker
        Me.CustomDateRangePicker1 = New CommonDateRangePicker.CustomDateRangePicker
        Me.SuspendLayout()
        '
        'CustomDateRangePicker2
        '
        Me.CustomDateRangePicker2.IsDateTimePickerAllowSpace = False
        Me.CustomDateRangePicker2.IsFromToLinkMinValueMaxValue = False
        Me.CustomDateRangePicker2.IsKeyPressEnterToFocusMove = False
        Me.CustomDateRangePicker2.IsLabelVisible = True
        Me.CustomDateRangePicker2.IsOrientation = CommonDateRangePicker.CustomDateRangePicker.IsOrientationEnum.Portrait
        Me.CustomDateRangePicker2.Location = New System.Drawing.Point(40, 188)
        Me.CustomDateRangePicker2.MyFromValue = New Date(2011, 3, 2, 11, 11, 24, 482)
        Me.CustomDateRangePicker2.MyIsFromValue = True
        Me.CustomDateRangePicker2.MyIsToValue = True
        Me.CustomDateRangePicker2.MyToValue = New Date(2011, 3, 2, 11, 11, 24, 482)
        Me.CustomDateRangePicker2.Name = "CustomDateRangePicker2"
        Me.CustomDateRangePicker2.Size = New System.Drawing.Size(118, 51)
        Me.CustomDateRangePicker2.TabIndex = 1
        '
        'CustomDateRangePicker3
        '
        Me.CustomDateRangePicker3.IsDateTimePickerAllowSpace = True
        Me.CustomDateRangePicker3.IsFromToLinkMinValueMaxValue = True
        Me.CustomDateRangePicker3.IsKeyPressEnterToFocusMove = True
        Me.CustomDateRangePicker3.IsLabelVisible = True
        Me.CustomDateRangePicker3.IsOrientation = CommonDateRangePicker.CustomDateRangePicker.IsOrientationEnum.Horizontal
        Me.CustomDateRangePicker3.Location = New System.Drawing.Point(38, 101)
        Me.CustomDateRangePicker3.MyFromValue = New Date(2011, 3, 2, 11, 11, 24, 482)
        Me.CustomDateRangePicker3.MyIsFromValue = True
        Me.CustomDateRangePicker3.MyIsToValue = True
        Me.CustomDateRangePicker3.MyToValue = New Date(2011, 3, 2, 11, 11, 24, 482)
        Me.CustomDateRangePicker3.Name = "CustomDateRangePicker3"
        Me.CustomDateRangePicker3.Size = New System.Drawing.Size(261, 19)
        Me.CustomDateRangePicker3.TabIndex = 0
        '
        'CustomDateRangePicker1
        '
        Me.CustomDateRangePicker1.IsDateTimePickerAllowSpace = True
        Me.CustomDateRangePicker1.IsFromToLinkMinValueMaxValue = True
        Me.CustomDateRangePicker1.IsKeyPressEnterToFocusMove = True
        Me.CustomDateRangePicker1.IsLabelVisible = True
        Me.CustomDateRangePicker1.IsOrientation = CommonDateRangePicker.CustomDateRangePicker.IsOrientationEnum.Portrait
        Me.CustomDateRangePicker1.Location = New System.Drawing.Point(38, 28)
        Me.CustomDateRangePicker1.MyFromValue = New Date(2011, 3, 2, 11, 11, 24, 482)
        Me.CustomDateRangePicker1.MyIsFromValue = True
        Me.CustomDateRangePicker1.MyIsToValue = True
        Me.CustomDateRangePicker1.MyToValue = New Date(2011, 3, 2, 11, 11, 24, 482)
        Me.CustomDateRangePicker1.Name = "CustomDateRangePicker1"
        Me.CustomDateRangePicker1.Size = New System.Drawing.Size(120, 51)
        Me.CustomDateRangePicker1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 264)
        Me.Controls.Add(Me.CustomDateRangePicker2)
        Me.Controls.Add(Me.CustomDateRangePicker3)
        Me.Controls.Add(Me.CustomDateRangePicker1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CustomDateRangePicker1 As CommonDateRangePicker.CustomDateRangePicker
    Friend WithEvents CustomDateRangePicker2 As CommonDateRangePicker.CustomDateRangePicker
    Friend WithEvents CustomDateRangePicker3 As CommonDateRangePicker.CustomDateRangePicker

End Class
