Public Class Form2

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Select Case Me.CustomDateRangePicker1.IsOrientation
            Case CustomDateRangePicker.IsOrientationEnum.Portrait
                Me.RadioButton1.Checked = True
            Case CustomDateRangePicker.IsOrientationEnum.Horizontal
                Me.RadioButton2.Checked = True
        End Select

        If Me.CustomDateRangePicker1.IsDateTimePickerAllowSpace Then
            Me.IsAllowSpaceCheckBox.Checked = True
        End If
        If Me.CustomDateRangePicker1.IsFromToLinkMinValueMaxValue Then
            Me.IsFromToLinkCheckBox.Checked = True
        End If
        If Me.CustomDateRangePicker1.IsKeyPressEnterToFocusMove Then
            Me.IsKeyPressEnterToFocusMoveCheckBox.Checked = True
        End If
        If Me.CustomDateRangePicker1.IsLabelVisible Then
            Me.IsLabelVisibleCheckBox.Checked = True
        End If
    End Sub

    Private Sub RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged

        If Me.RadioButton1.Checked = True Then
            Me.CustomDateRangePicker1.IsOrientation = CustomDateRangePicker.IsOrientationEnum.Portrait
        ElseIf Me.RadioButton2.Checked = True Then
            Me.CustomDateRangePicker1.IsOrientation = CustomDateRangePicker.IsOrientationEnum.Horizontal
        End If

    End Sub

    Private Sub CheckBox_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles IsAllowSpaceCheckBox.CheckedChanged, IsFromToLinkCheckBox.CheckedChanged, IsKeyPressEnterToFocusMoveCheckBox.CheckedChanged, IsLabelVisibleCheckBox.CheckedChanged
        If Me.IsAllowSpaceCheckBox.Checked = True Then
            Me.CustomDateRangePicker1.IsDateTimePickerAllowSpace = True
        Else
            Me.CustomDateRangePicker1.IsDateTimePickerAllowSpace = False
        End If
        If Me.IsFromToLinkCheckBox.Checked = True Then
            Me.CustomDateRangePicker1.IsFromToLinkMinValueMaxValue = True
        Else
            Me.CustomDateRangePicker1.IsFromToLinkMinValueMaxValue = False
        End If
        If Me.IsKeyPressEnterToFocusMoveCheckBox.Checked = True Then
            Me.CustomDateRangePicker1.IsKeyPressEnterToFocusMove = True
        Else
            Me.CustomDateRangePicker1.IsKeyPressEnterToFocusMove = False
        End If
        If Me.IsLabelVisibleCheckBox.Checked = True Then
            Me.CustomDateRangePicker1.IsLabelVisible = True
        Else
            Me.CustomDateRangePicker1.IsLabelVisible = False
        End If
    End Sub


End Class