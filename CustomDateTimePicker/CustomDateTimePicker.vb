Imports System.ComponentModel
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

#Region "処理メソッド"
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
        Select Case e.KeyCode
            Case Keys.Delete
                Me.Checked = False
            Case Else
        End Select

    End Sub
#End Region
End Class
