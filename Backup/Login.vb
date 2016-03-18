Imports System.Data.OleDb
Public Class Login
    Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxTUser As System.Windows.Forms.TextBox
    Friend WithEvents TxTPass As System.Windows.Forms.TextBox
    Friend WithEvents CmdLogin As System.Windows.Forms.Button
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents CDT As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CmdLogin = New System.Windows.Forms.Button
        Me.CmdExit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxTUser = New System.Windows.Forms.TextBox
        Me.TxTPass = New System.Windows.Forms.TextBox
        Me.CDT = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'CmdLogin
        '
        Me.CmdLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdLogin.Location = New System.Drawing.Point(104, 96)
        Me.CmdLogin.Name = "CmdLogin"
        Me.CmdLogin.Size = New System.Drawing.Size(80, 24)
        Me.CmdLogin.TabIndex = 4
        Me.CmdLogin.Text = "&Ok"
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdExit.Location = New System.Drawing.Point(192, 96)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(80, 24)
        Me.CmdExit.TabIndex = 5
        Me.CmdExit.Text = "&Cancel"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "&UserID :"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Password   :"
        '
        'TxTUser
        '
        Me.TxTUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxTUser.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTUser.Location = New System.Drawing.Point(88, 16)
        Me.TxTUser.MaxLength = 3
        Me.TxTUser.Name = "TxTUser"
        Me.TxTUser.Size = New System.Drawing.Size(184, 23)
        Me.TxTUser.TabIndex = 7
        Me.TxTUser.Text = "ADM"
        '
        'TxTPass
        '
        Me.TxTPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxTPass.Font = New System.Drawing.Font("Wingdings", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.TxTPass.Location = New System.Drawing.Point(88, 40)
        Me.TxTPass.Name = "TxTPass"
        Me.TxTPass.PasswordChar = Microsoft.VisualBasic.ChrW(108)
        Me.TxTPass.Size = New System.Drawing.Size(184, 21)
        Me.TxTPass.TabIndex = 1
        Me.TxTPass.Text = ""
        '
        'CDT
        '
        Me.CDT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CDT.CustomFormat = "dd-MM-yyyy"
        Me.CDT.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CDT.Location = New System.Drawing.Point(88, 64)
        Me.CDT.Name = "CDT"
        Me.CDT.ShowUpDown = True
        Me.CDT.Size = New System.Drawing.Size(184, 23)
        Me.CDT.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Date :"
        '
        'Login
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(282, 127)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CDT)
        Me.Controls.Add(Me.TxTPass)
        Me.Controls.Add(Me.TxTUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.CmdLogin)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CDT.MinDate = FromDate
        CDT.MaxDate = ToDate
        TxTPass.Focus()
    End Sub

    Private Sub Login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLogin.Click
        If Trim(TxTUser.Text).Length = 0 Then
            MsgBox("Please Enter User Name", MsgBoxStyle.Information, "User Name")
            TxTUser.Focus()
            TxTUser.SelectAll()
            Exit Sub
        End If
        If Trim(TxTPass.Text).Length = 0 Then
            MsgBox("Please Enter Password", MsgBoxStyle.Information, "User Name")
            TxTPass.Focus()
            TxTPass.SelectAll()
            Exit Sub
        End If
        If InitLogin() = True Then
            Close()
        Else
            MsgBox("Invalid User Name Or Password", MsgBoxStyle.Critical)
            TxTUser.Focus()
            TxTUser.SelectAll()
            Exit Sub
        End If
    End Sub
    Private Function InitLogin() As Boolean
        Dim Con As New OleDbConnection(ConStr)
        Dim Cmd As New OleDbCommand
        Dim Dr As OleDbDataReader
        Cmd.CommandText = "SELECT * FROM UserList WHERE UserID='" & UCase(Trim(TxTUser.Text)) & "'"
        Cmd.CommandType = CommandType.Text
        Cmd.Connection = Con
        Try
            Con.Open()
            Dr = Cmd.ExecuteReader()
            If Dr.HasRows = True Then
                Dr.Read()
                If Dr.Item("Password") = TxTPass.Text Then
                    imUser = New UserLogin(Dr.Item("UserID"), Dr.Item("UserName"), Dr.Item("ULevel"), Dr.Item("Password"))
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            Con.Close()
        End Try
    End Function

    Private Sub TxTPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxTPass.TextChanged

    End Sub

    Private Sub TxTPass_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxTPass.GotFocus
        TxTPass.SelectAll()
        TxTPass.BackColor = Color.LightCyan
    End Sub
    Private Sub TxTUser_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxTUser.GotFocus
        TxTUser.SelectAll()
        TxTUser.BackColor = Color.LightCyan
    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        End
    End Sub

    Private Sub TxTUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxTUser.KeyPress
        FnChar(e, False)
    End Sub

    Private Sub TxTUser_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxTUser.LostFocus
        TxTUser.BackColor = Color.White
    End Sub

    Private Sub TxTUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxTUser.TextChanged

    End Sub

    Private Sub TxTPass_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxTPass.LostFocus
        TxTPass.BackColor = Color.White
    End Sub

    Private Sub CDT_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CDT.ValueChanged

    End Sub

    Private Sub CDT_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CDT.GotFocus
        CDT.BackColor = Color.LightGray
    End Sub

    Private Sub CDT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CDT.LostFocus
        CDT.BackColor = Color.White
    End Sub
End Class
