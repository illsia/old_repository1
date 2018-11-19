Imports System.ComponentModel
'-- 和暦表示のため追加
Imports System.Globalization
''' ------------------------<summary>
''' CustomDateTimePicker
''' </summary>------------------------
''' <remarks></remarks>
Public Class CustomDateTimePicker
    Inherits DateTimePicker

#Region "プロパティ"
    '****************************************
    ' DefaultCustomFormatプロパティ隠蔽
    '****************************************
    Private defaultCustomFormat_P As String
    <Browsable(True), _
     EditorBrowsable(EditorBrowsableState.Always), _
     DefaultValue("yyyy/MM/dd")> _
    Public Property DefaultCustomFormat() As String
        Get
            Return Me.defaultCustomFormat_P
        End Get
        Set(ByVal value As String)
            Me.defaultCustomFormat_P = value
            If Me.Checked = True Then
                MyBase.CustomFormat = value
            End If
        End Set
    End Property

    '****************************************
    ' Checkedプロパティ
    '****************************************
    Public Overloads Property Checked() As Boolean
        Get
            Return MyBase.Checked
        End Get
        Set(ByVal value As Boolean)
            MyBase.Checked = value
            If value = True Then
                MyBase.CustomFormat = Me.DefaultCustomFormat
            Else
                MyBase.CustomFormat = " "
            End If
        End Set
    End Property

    '****************************************
    ' Formatプロパティ隠蔽
    '****************************************
    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never)> _
    Public Shadows Property Format() As DateTimePickerFormat
        Get
            Return MyBase.Format
        End Get
        Set(ByVal value As DateTimePickerFormat)
            MyBase.Format = value
        End Set
    End Property

    '****************************************
    ' CustomFormatプロパティ隠蔽
    '****************************************
    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never)> _
    Public Shadows Property CustomFormat() As String
        Get
            Return MyBase.CustomFormat
        End Get
        Set(ByVal value As String)
            MyBase.CustomFormat = value
        End Set
    End Property
#End Region

#Region "コンストラクタ"
    '****************************************
    ' コンストラクタ
    '****************************************
    Public Sub New()
        MyBase.Format = DateTimePickerFormat.Custom
    End Sub
#End Region

#Region "< 日付非表示 >"
    '****************************************
    ' 日付変更
    '****************************************
    Private Sub CustomDateTimePicker_ValueChanged(ByVal sender As Object, _
                                                  ByVal e As System.EventArgs) Handles Me.ValueChanged
        If Me.Checked = True Then
            MyBase.CustomFormat = Me.DefaultCustomFormat
        Else
            MyBase.CustomFormat = " "
        End If
    End Sub
#End Region

#Region "< Delete・BackSpaceキーで値を削除 >"
    ''' ------------------------------------------------<summary>
    ''' KeyPress
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Private Sub Me_KeyPress(ByVal sender As Object _
                            , ByVal e As KeyPressEventArgs _
                            ) Handles Me.KeyPress
        '-- 読み取り専用なのか
        If Me.IsReadOnly = True Then
            Exit Sub
        End If
        '-- DeleteキーBackSpaceキーは有効なのか
        If Me.IsDeleteKeyOrBackSpaceKeyEnable = False Then
            Exit Sub
        End If

        '-- 押されたキーは何か
        Select Case e.KeyChar
            Case Chr(Keys.Back)
                '-- BackSpace
                Me.Checked = False
            Case Else
        End Select

    End Sub

    ''' ------------------------------------------------<summary>
    ''' PreviewKeyDown
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Private Sub Me_PreviewKeyDown(ByVal sender As Object _
                                  , ByVal e As PreviewKeyDownEventArgs _
                                  ) Handles Me.PreviewKeyDown
        '-- 読み取り専用なのか
        If Me.IsReadOnly = True Then
            Exit Sub
        End If
        '-- DeleteキーBackSpaceキーは有効なのか
        If Me.IsDeleteKeyOrBackSpaceKeyEnable = False Then
            Exit Sub
        End If

        '-- 押されたキーは何か
        Select Case e.KeyCode
            Case Keys.Delete
                '-- Delete
                Me.Checked = False
            Case Else
        End Select

    End Sub
#End Region

#Region "< 和暦表示 >"
    ''' ------------------------------------------------<summary>
    ''' _IsJapaneseCalender
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public _IsJapaneseCalender As Boolean = False

    ''' ------------------------------------------------<summary>
    ''' IsJapaneseCalenderプロパティ
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public Property IsJapaneseCalender() As Boolean
        Get
            Return Me._IsJapaneseCalender
        End Get
        Set(ByVal value As Boolean)
            Me._IsJapaneseCalender = value
            If value = True Then
                Me.JapaneseCalenderChange()
            End If
        End Set
    End Property

    ''' ------------------------------------------------<summary>
    ''' 値が変わった場合にカレンダーフォーマットの再設定
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Private Sub Me_ValueChanged() Handles Me.ValueChanged
        If Me.IsJapaneseCalender = True Then
            Me.JapaneseCalenderChange()
        End If
    End Sub

    ''' ------------------------------------------------<summary>
    ''' カレンダーフォーマットの再設定
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Protected Sub JapaneseCalenderChange()
        Dim jpCalendar As New JapaneseCalendar()
        Dim cultureInfo As New CultureInfo("ja-JP")
        cultureInfo.DateTimeFormat.Calendar = jpCalendar

        Me.Format = DateTimePickerFormat.Custom
        Me.CustomFormat = Me.Value.ToString("gg yy", cultureInfo) & "年MM月dd日"
    End Sub
#End Region

#Region "< OnEnter時点の値を保持 >"

    ''' ------------------------------------------------<summary>
    ''' OnEnter時点の値を保持されているか
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public IsOnEnterPointInTimeValue As Boolean = False

    ''' ------------------------------------------------<summary>
    ''' OnEnter時点の値を保持
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public OnEnterPointInTimeValue As Date
    ''' ------------------------------------------------<summary>
    ''' Enter
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public Sub MyBase_Enter(ByVal sender As Object _
                            , ByVal e As EventArgs _
                            ) Handles MyBase.Enter
        Me.IsOnEnterPointInTimeValue = True
        Me.OnEnterPointInTimeValue = Me.Value
    End Sub
#End Region

#Region "< 読み取り専用 >"
    ''' ------------------------------------------------<summary>
    ''' 固定する値を保持
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Protected _FixedValue As Date
    ''' ------------------------------------------------<summary>
    ''' 固定する値をセット
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public WriteOnly Property SetFixedValue() As Date
        Set(ByVal value As Date)
            Me._FixedValue = value
            Me.Value = value
        End Set
    End Property

    ''' ------------------------------------------------<summary>
    ''' 読み取り専用なのかを保持
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Protected _IsReadOnly As Boolean = False
    ''' ------------------------------------------------<summary>
    ''' 読み取り専用なのか
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public Property IsReadOnly() As Boolean
        Get
            Return Me._IsReadOnly
        End Get
        Set(ByVal value As Boolean)
            Me._IsReadOnly = value
        End Set
    End Property

    ''' ------------------------------------------------<summary>
    ''' ValueChanged
    ''' ※値が変わる瞬間に、保持している値に摩り替える
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Private Sub Me_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Me.ValueChanged
        '-- 読み取り専用なのか
        If Me.IsReadOnly = True Then
            Me.Value = Me._FixedValue
        End If
    End Sub

    ''' ------------------------------------------------<summary>
    ''' MouseDown
    ''' ※ｸﾘｯｸ時にフォーカスを親コントロールへ移し、操作を無効にする
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Private Sub CustomDateTimePicker_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        '-- 読み取り専用なのか
        If Me.IsReadOnly = True Then
            Me.Parent.Focus()
        End If
    End Sub

#End Region

#Region "< Deleteキー、BackSpaceキーは有効なのか >"
    ''' ------------------------------------------------<summary>
    ''' Deleteキー、BackSpaceキーは有効なのかを保持
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Protected _IsDeleteKeyOrBackSpaceKeyEnable As Boolean = True

    ''' ------------------------------------------------<summary>
    ''' Deleteキー、BackSpaceキーは有効なのか
    ''' </summary>-----------------------------------------------
    ''' <remarks></remarks>
    Public Property IsDeleteKeyOrBackSpaceKeyEnable() As Boolean
        Get
            Return Me._IsDeleteKeyOrBackSpaceKeyEnable
        End Get
        Set(ByVal value As Boolean)
            Me._IsDeleteKeyOrBackSpaceKeyEnable = value
        End Set
    End Property
#End Region

End Class
