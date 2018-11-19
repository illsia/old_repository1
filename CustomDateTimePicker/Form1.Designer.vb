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
        Me.CustomDateTimePicker1 = New CustomDateTimePicker
        Me.SuspendLayout()
        '
        'CustomDateTimePicker1
        '
        Me.CustomDateTimePicker1.CustomFormat = "yyyyy/MM"
        Me.CustomDateTimePicker1.DefaultCustomFormat = "yyyyy/MM"
        Me.CustomDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CustomDateTimePicker1.Location = New System.Drawing.Point(44, 45)
        Me.CustomDateTimePicker1.Name = "CustomDateTimePicker1"
        Me.CustomDateTimePicker1.Size = New System.Drawing.Size(200, 19)
        Me.CustomDateTimePicker1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 264)
        Me.Controls.Add(Me.CustomDateTimePicker1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents CustomDateTimePicker1 As CustomDateTimePicker

End Class
