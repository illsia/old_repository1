' 更新履歴
'-------------------------------------------------------------------------------
' 日付       |内容
'------------------------------------------------------------------
' 2011.03.02|新規作成
' 2011.06.09|日付の空白に対応
' 2011.06.10|KeyPressイベントを公開
' 2011.06.10|KeyPress時Enter入力フォーカス移動
' 2011.07.08|横型のレイアウトに対応
'*******************************************************************************
''' ------------------------<summary>
''' 
''' </summary>------------------------
''' <remarks></remarks>
Public Class CustomDateRangePicker

#Region "< 定数 >"
    ''' ----------------------------<summary>
    ''' フォーマット
    ''' </summary>---------------------------
    ''' <remarks></remarks>
    Protected Const CustomFormatDefault As String = "yyyy/MM/dd"
    ''' ----------------------------<summary>
    ''' フォーマット
    ''' </summary>---------------------------
    ''' <remarks></remarks>
    Protected Const CustomFormatBlank As String = " "
    ''' ----------------------------<summary>
    ''' 縦型レイアウトの場合の横幅
    ''' </summary>---------------------------
    ''' <remarks></remarks>
    Protected Const MeOrientationPortraitWidth As Integer = 120
    ''' ----------------------------<summary>
    ''' Labelの横幅
    ''' </summary>---------------------------
    ''' <remarks></remarks>
    Protected Const MeLabelWidth As Integer = 20
#End Region

#Region "< 公開データ >"
    ''' ------------------------------------------------<summary>
    ''' 戻り値
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public Class MyData
        ''' ------------------------------------------------<summary>
        ''' Fromがセットされているのか
        ''' </summary>-----------------------------------------------
        ''' <remarks></remarks>
        Public myIsFrom As Boolean
        ''' ------------------------------------------------<summary>
        ''' From
        ''' </summary>-----------------------------------------------
        ''' <remarks></remarks>
        Public myFrom As Date
        ''' ------------------------------------------------<summary>
        ''' Toがセットされているのか
        ''' </summary>-----------------------------------------------
        ''' <remarks></remarks>
        Public myIsTo As Boolean
        ''' ------------------------------------------------<summary>
        ''' To
        ''' </summary>-----------------------------------------------
        ''' <remarks></remarks>
        Public myTo As Date

        ''' ------------------------------------------------<summary>
        ''' コンストラクタ
        ''' </summary>-----------------------------------------------
        ''' <remarks></remarks>
        Public Sub New(ByVal inputIsFrom As Boolean _
                       , ByVal inputFrom As Date _
                       , ByVal inputIsTo As Boolean _
                       , ByVal inputTo As Date _
                       )
            Me.myIsFrom = inputIsFrom
            Me.myFrom = inputFrom
            Me.myIsTo = inputIsTo
            Me.myTo = inputTo
        End Sub
    End Class

    ''' ------------------------------------------------<summary>
    ''' From Checked
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public Property MyIsFromValue() As Boolean
        Get
            Return Me.FromDateTimePicker.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.FromDateTimePicker.Checked = value
        End Set
    End Property

    ''' ------------------------------------------------<summary>
    ''' From Value
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public Property MyFromValue() As Date
        Get
            Return Me.FromDateTimePicker.Value
        End Get
        Set(ByVal value As Date)
            Me.FromDateTimePicker.Value = value
        End Set
    End Property

    ''' ------------------------------------------------<summary>
    ''' To Checked
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public Property MyIsToValue() As Boolean
        Get
            Return Me.ToDateTimePicker.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.ToDateTimePicker.Checked = value
        End Set
    End Property

    ''' ------------------------------------------------<summary>
    ''' To Checked
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public Property MyToValue() As Date
        Get
            Return Me.ToDateTimePicker.Value
        End Get
        Set(ByVal value As Date)
            Me.ToDateTimePicker.Value = value
        End Set
    End Property

    ''' ------------------------------------------------<summary>
    ''' Data
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public Property MyDataValue() As MyData
        Get
            Dim newData As MyData
            newData = New MyData(Me.FromDateTimePicker.Checked _
                                 , Me.FromDateTimePicker.Value _
                                 , Me.ToDateTimePicker.Checked _
                                 , Me.ToDateTimePicker.Value _
                                 )
            Return newData
        End Get
        Set(ByVal value As MyData)
            Me.FromDateTimePicker.Checked = value.myIsFrom
            Me.FromDateTimePicker.Value = value.myFrom
            Me.ToDateTimePicker.Checked = value.myIsTo
            Me.ToDateTimePicker.Value = value.myTo
        End Set
    End Property

    ''' ------------------------------------------------<summary>
    ''' From-Toが有効な状態なのか
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public ReadOnly Property IsFromToComplete() As Boolean
        Get
            If Me.FromDateTimePicker.Checked = True And Me.ToDateTimePicker.Checked = True Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

#End Region

#Region "< FromとToのMinValueMaxValueがリンクするのか >"
    ''' ------------------------------------------------<summary>
    ''' FromとToのMinValueMaxValueがリンクするのか
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public _IsFromToLinkMinValueMaxValue As Boolean = False
    ''' ------------------------------------------------<summary>
    ''' FromとToのMinValueMaxValueがリンクするのか
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public Property IsFromToLinkMinValueMaxValue() As Boolean
        Get
            Return Me._IsFromToLinkMinValueMaxValue
        End Get
        Set(ByVal value As Boolean)
            Me._IsFromToLinkMinValueMaxValue = value
            If value = True Then
                Me.FromToLinkMinValueMaxValueSetting()
            Else
                Me.FromToLinkMinValueMaxValueSettingRelease()
            End If
        End Set
    End Property

    ''' ------------------------------------------------<summary>
    ''' FromとToのMinValueMaxValueリンク設定
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Protected Sub FromToLinkMinValueMaxValueSetting()
        Me.ToDateTimePicker.MinDate = Me.FromDateTimePicker.Value
        Me.FromDateTimePicker.MaxDate = Me.ToDateTimePicker.Value
        ''Me.FromDateTimePicker.MaxDate = Me.ToDateTimePicker.Value
        ''Me.ToDateTimePicker.MinDate = Me.FromDateTimePicker.Value
    End Sub

    ''' ------------------------------------------------<summary>
    ''' FromとToのMinValueMaxValueリンク設定解除
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Protected Sub FromToLinkMinValueMaxValueSettingRelease()
        Me.FromDateTimePicker.MaxDate = DateTime.MaxValue.AddYears(-1).AddDays(-1)
        Me.ToDateTimePicker.MinDate = DateTime.MinValue.AddYears(1800)
    End Sub

    ''' ------------------------------------------------<summary>
    ''' FromとToの値が変更された場合
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Private Sub DateTimePicker_ValueChanged(ByVal sender As Object _
                                            , ByVal e As EventArgs _
                                            ) Handles FromDateTimePicker.ValueChanged _
                                            , ToDateTimePicker.ValueChanged
        If Me.IsFromToComplete = False Then
            Me.FromToLinkMinValueMaxValueSettingRelease()
        ElseIf Me.IsFromToLinkMinValueMaxValue = True Then
            Me.FromToLinkMinValueMaxValueSetting()
        End If
    End Sub
#End Region

#Region "< Labelを表示するのか >"
    ''' ------------------------------------------------<summary>
    ''' Labelを表示するのか
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public _IsLabelVisible As Boolean = True
    ''' ------------------------------------------------<summary>
    ''' Labelを表示するのか
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public Property IsLabelVisible() As Boolean
        Get
            Return Me._IsLabelVisible
        End Get
        Set(ByVal value As Boolean)
            Me._IsLabelVisible = value
            Me.Label.Visible = value
            '-- コントロールサイズ再設定
            Me.ControlSizeSetting()
        End Set
    End Property

    ''' ------------------------------------------------<summary>
    ''' コントロールサイズ設定
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Protected Sub ControlSizeSetting()
        '-- Labelの横幅を設定
        Me.Label.Width = CustomDateRangePicker.MeLabelWidth
        '-- レイアウト
        Select Case Me.IsOrientation
            Case IsOrientationEnum.Portrait
                '縦型
                '-- Labelを表示するのか
                If Me.IsLabelVisible = True Then
                    'する
                    '-- ※横幅は固定値をセット
                    '　　 縦幅はFrom + To + Labelの値をセット
                    Me.Size = New Size(CustomDateRangePicker.MeOrientationPortraitWidth, Me.FromDateTimePicker.Height + Me.ToDateTimePicker.Height + Me.Label.Height + 1)
                Else
                    'しない
                    '-- ※横幅は固定値をセット
                    '　　 縦幅はFrom + Toの値をセット
                    Me.Size = New Size(CustomDateRangePicker.MeOrientationPortraitWidth, Me.FromDateTimePicker.Height + Me.ToDateTimePicker.Height + 1)
                End If
            Case IsOrientationEnum.Horizontal
                '横型
                '-- Labelを表示するのか
                If Me.IsLabelVisible = True Then
                    '-- する
                    '-- ※横幅はFrom + To + Labelの値をセット
                    '　　 縦幅はFromの値をセット
                    Me.Size = New Size(Me.FromDateTimePicker.Width + Me.Label.Width + Me.ToDateTimePicker.Width + 1, Me.FromDateTimePicker.Height)
                Else
                    '-- しない
                    '-- ※横幅はFrom + Toの値をセット
                    '　　 縦幅はFromの値をセット
                    Me.Size = New Size(Me.FromDateTimePicker.Width + Me.ToDateTimePicker.Width + 1, Me.FromDateTimePicker.Height)
                End If
        End Select
    End Sub
#End Region

#Region "< 日付の空白に対応 >"
    ''' ------------------------------------------------<summary>
    ''' 日付の空白を許可するのか
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public _IsDateTimePickerAllowSpace As Boolean = False

    ''' ------------------------------------------------<summary>
    ''' 日付の空白を許可するのか
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public Property IsDateTimePickerAllowSpace() As Boolean
        Get
            Return Me._IsDateTimePickerAllowSpace
        End Get
        Set(ByVal value As Boolean)
            Me._IsDateTimePickerAllowSpace = value
            Me.DateTimePickerAllowSpace(value)
        End Set
    End Property

    ''' ------------------------------------------------<summary>
    ''' 日付の空白許可の切り替え
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Protected Sub DateTimePickerAllowSpace(ByVal input As Boolean)

        If input = True Then
            With Me.FromDateTimePicker
                .ShowCheckBox = True
                .IsDeleteKeyOrBackSpaceKeyEnable = True
            End With
            With Me.ToDateTimePicker
                .ShowCheckBox = True
                .IsDeleteKeyOrBackSpaceKeyEnable = True
            End With
        Else
            With Me.FromDateTimePicker
                .ShowCheckBox = False
                .IsDeleteKeyOrBackSpaceKeyEnable = False
            End With
            With Me.ToDateTimePicker
                .ShowCheckBox = False
                .IsDeleteKeyOrBackSpaceKeyEnable = False
            End With
        End If

        '-- 日付の空白が無効の場合は、
        '　 必ず日付を表示させる設定にする
        If input = False Then
            Me.MyIsFromValue = True
            Me.MyIsToValue = True
        End If
    End Sub
#End Region

#Region "< KeyPressイベントを公開 >"

    Public Event KeyPressFrom(ByVal sender As Object, ByVal e As KeyPressEventArgs)
    Public Event KeyPressTo(ByVal sender As Object, ByVal e As KeyPressEventArgs)

    Private Sub FromDateTimePicker_KeyPress(ByVal sender As Object _
                                            , ByVal e As KeyPressEventArgs _
                                            ) Handles FromDateTimePicker.KeyPress
        RaiseEvent KeyPressFrom(sender, e)
    End Sub

    Private Sub ToDateTimePicker_KeyPress(ByVal sender As Object _
                                          , ByVal e As KeyPressEventArgs _
                                          ) Handles ToDateTimePicker.KeyPress
        RaiseEvent KeyPressTo(sender, e)
    End Sub

#End Region

#Region "< KeyPress時Enterキー入力でフォーカス移動 >"

    Protected _IsKeyPressEnterToFocusMove As Boolean = False

    Public Property IsKeyPressEnterToFocusMove() As Boolean
        Get
            Return Me._IsKeyPressEnterToFocusMove
        End Get
        Set(ByVal value As Boolean)
            Me._IsKeyPressEnterToFocusMove = value
        End Set
    End Property

    Private Sub KeyPressEnterToFocusMove(ByVal sender As Object _
                                         , ByVal e As KeyPressEventArgs _
                                         ) Handles FromDateTimePicker.KeyPress
        If Me.IsKeyPressEnterToFocusMove = True Then
            Select Case DirectCast(sender, Control).Name
                Case Me.FromDateTimePicker.Name
                    Me.ToDateTimePicker.Focus()
            End Select
        End If
    End Sub


#End Region

#Region "< レイアウト設定 >"
    ''' ----------------------------<summary>
    ''' レイアウト
    ''' </summary>---------------------------
    ''' <remarks></remarks>
    Public Enum IsOrientationEnum
        ''' ----------------------------<summary>
        ''' 縦
        ''' </summary>---------------------------
        ''' <remarks></remarks>
        Portrait
        ''' ----------------------------<summary>
        ''' 横
        ''' </summary>---------------------------
        ''' <remarks></remarks>
        Horizontal
    End Enum

    ''' ----------------------------<summary>
    ''' プロパティ変数 ※デフォルトは縦
    ''' </summary>---------------------------
    ''' <remarks></remarks>
    Public _IsOrientation As IsOrientationEnum = IsOrientationEnum.Portrait

    ''' ----------------------------<summary>
    ''' プロパティ
    ''' </summary>---------------------------
    ''' <remarks></remarks>
    Public Property IsOrientation() As IsOrientationEnum
        Get
            Return Me._IsOrientation
        End Get
        Set(ByVal value As IsOrientationEnum)
            Me._IsOrientation = value
            Me.OrientationChange()
        End Set
    End Property

    ''' ----------------------------<summary>
    ''' レイアウト変更
    ''' </summary>---------------------------
    ''' <remarks></remarks>
    Protected Sub OrientationChange()
        '-- レイアウト
        Select Case Me.IsOrientation
            Case IsOrientationEnum.Portrait
                '縦
                '-- DockStyleを Top に設定
                Me.FromDateTimePicker.Dock = DockStyle.Top
                Me.Label.Dock = DockStyle.Top
                Me.ToDateTimePicker.Dock = DockStyle.Top
            Case IsOrientationEnum.Horizontal
                '横
                '-- DockStyleを Left に設定
                Me.FromDateTimePicker.Dock = DockStyle.Left
                Me.Label.Dock = DockStyle.Left
                Me.ToDateTimePicker.Dock = DockStyle.Left
        End Select
        '-- ControlSize再設定
        Me.ControlSizeSetting()
    End Sub
#End Region

End Class
