Imports System.Data.OleDb
Public Class UserCre
    Inherits System.Windows.Forms.Form
    Dim Con As OleDbConnection
    Dim Da As OleDbDataAdapter
    Dim Ds As New DataSet
    Dim Opr As Operation
    Dim CmB As OleDbCommandBuilder
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
    Friend WithEvents DGrid As System.Windows.Forms.DataGrid
    Friend WithEvents BPanel As System.Windows.Forms.Panel
    Friend WithEvents CmdHelp As System.Windows.Forms.Button
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents CmdEdit As System.Windows.Forms.Button
    Friend WithEvents CmdSearch As System.Windows.Forms.Button
    Friend WithEvents CmdDelete As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents LblDisplay As System.Windows.Forms.Label
    Friend WithEvents UPanel As System.Windows.Forms.Panel
    Friend WithEvents LUID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxTUserLevel As System.Windows.Forms.DomainUpDown
    Friend WithEvents TxTPASS As System.Windows.Forms.TextBox
    Friend WithEvents TxTUNAME As System.Windows.Forms.TextBox
    Friend WithEvents TxTUID As System.Windows.Forms.TextBox
    Friend WithEvents UserList As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents UserID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents UName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Pass As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents UserLevel As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Showlevel As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DGrid = New System.Windows.Forms.DataGrid
        Me.UserList = New System.Windows.Forms.DataGridTableStyle
        Me.UserID = New System.Windows.Forms.DataGridTextBoxColumn
        Me.UName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Pass = New System.Windows.Forms.DataGridTextBoxColumn
        Me.UserLevel = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Showlevel = New System.Windows.Forms.DataGridTextBoxColumn
        Me.BPanel = New System.Windows.Forms.Panel
        Me.CmdHelp = New System.Windows.Forms.Button
        Me.CmdCancel = New System.Windows.Forms.Button
        Me.CmdExit = New System.Windows.Forms.Button
        Me.CmdSave = New System.Windows.Forms.Button
        Me.CmdEdit = New System.Windows.Forms.Button
        Me.CmdSearch = New System.Windows.Forms.Button
        Me.CmdDelete = New System.Windows.Forms.Button
        Me.CmdAdd = New System.Windows.Forms.Button
        Me.LblDisplay = New System.Windows.Forms.Label
        Me.UPanel = New System.Windows.Forms.Panel
        Me.TxTUserLevel = New System.Windows.Forms.DomainUpDown
        Me.TxTPASS = New System.Windows.Forms.TextBox
        Me.TxTUNAME = New System.Windows.Forms.TextBox
        Me.TxTUID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LUID = New System.Windows.Forms.Label
        CType(Me.DGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BPanel.SuspendLayout()
        Me.UPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGrid
        '
        Me.DGrid.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DGrid.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DGrid.BackgroundColor = System.Drawing.Color.LightGray
        Me.DGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGrid.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DGrid.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DGrid.CaptionText = "User Details"
        Me.DGrid.DataMember = ""
        Me.DGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGrid.FlatMode = True
        Me.DGrid.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DGrid.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DGrid.GridLineColor = System.Drawing.Color.Gainsboro
        Me.DGrid.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DGrid.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DGrid.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DGrid.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DGrid.LinkColor = System.Drawing.Color.Teal
        Me.DGrid.Location = New System.Drawing.Point(0, 269)
        Me.DGrid.Name = "DGrid"
        Me.DGrid.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DGrid.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DGrid.ReadOnly = True
        Me.DGrid.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DGrid.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DGrid.Size = New System.Drawing.Size(680, 200)
        Me.DGrid.TabIndex = 1
        Me.DGrid.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.UserList})
        '
        'UserList
        '
        Me.UserList.AlternatingBackColor = System.Drawing.Color.MintCream
        Me.UserList.BackColor = System.Drawing.Color.LightCyan
        Me.UserList.DataGrid = Me.DGrid
        Me.UserList.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.UserID, Me.UName, Me.Pass, Me.UserLevel, Me.Showlevel})
        Me.UserList.GridLineColor = System.Drawing.Color.Azure
        Me.UserList.HeaderBackColor = System.Drawing.Color.LightBlue
        Me.UserList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.UserList.MappingName = "UL"
        '
        'UserID
        '
        Me.UserID.Format = ""
        Me.UserID.FormatInfo = Nothing
        Me.UserID.HeaderText = "User ID"
        Me.UserID.MappingName = "UserID"
        Me.UserID.NullText = ""
        Me.UserID.Width = 75
        '
        'UName
        '
        Me.UName.Format = ""
        Me.UName.FormatInfo = Nothing
        Me.UName.HeaderText = "User Name"
        Me.UName.MappingName = "UserName"
        Me.UName.NullText = ""
        Me.UName.Width = 250
        '
        'Pass
        '
        Me.Pass.Format = "*"
        Me.Pass.FormatInfo = Nothing
        Me.Pass.HeaderText = "Password"
        Me.Pass.MappingName = "Password"
        Me.Pass.NullText = ""
        Me.Pass.Width = 0
        '
        'UserLevel
        '
        Me.UserLevel.Format = ""
        Me.UserLevel.FormatInfo = Nothing
        Me.UserLevel.HeaderText = "Level"
        Me.UserLevel.MappingName = "Level"
        Me.UserLevel.NullText = ""
        Me.UserLevel.Width = 0
        '
        'Showlevel
        '
        Me.Showlevel.Format = ""
        Me.Showlevel.FormatInfo = Nothing
        Me.Showlevel.HeaderText = "Level"
        Me.Showlevel.MappingName = "ShowLevel"
        Me.Showlevel.NullText = ""
        Me.Showlevel.Width = 150
        '
        'BPanel
        '
        Me.BPanel.BackColor = System.Drawing.Color.Transparent
        Me.BPanel.Controls.Add(Me.CmdHelp)
        Me.BPanel.Controls.Add(Me.CmdCancel)
        Me.BPanel.Controls.Add(Me.CmdExit)
        Me.BPanel.Controls.Add(Me.CmdSave)
        Me.BPanel.Controls.Add(Me.CmdEdit)
        Me.BPanel.Controls.Add(Me.CmdSearch)
        Me.BPanel.Controls.Add(Me.CmdDelete)
        Me.BPanel.Controls.Add(Me.CmdAdd)
        Me.BPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.BPanel.Location = New System.Drawing.Point(588, 24)
        Me.BPanel.Name = "BPanel"
        Me.BPanel.Size = New System.Drawing.Size(92, 245)
        Me.BPanel.TabIndex = 0
        '
        'CmdHelp
        '
        Me.CmdHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdHelp.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CmdHelp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmdHelp.Location = New System.Drawing.Point(8, 208)
        Me.CmdHelp.Name = "CmdHelp"
        Me.CmdHelp.TabIndex = 7
        Me.CmdHelp.Text = "&Help"
        '
        'CmdCancel
        '
        Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdCancel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmdCancel.Location = New System.Drawing.Point(8, 148)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.TabIndex = 5
        Me.CmdCancel.Text = "&Cancel"
        '
        'CmdExit
        '
        Me.CmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdExit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdExit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmdExit.Location = New System.Drawing.Point(8, 177)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.TabIndex = 6
        Me.CmdExit.Text = "E&xit"
        '
        'CmdSave
        '
        Me.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdSave.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CmdSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmdSave.Location = New System.Drawing.Point(8, 120)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.TabIndex = 4
        Me.CmdSave.Text = "&Save"
        '
        'CmdEdit
        '
        Me.CmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdEdit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CmdEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmdEdit.Location = New System.Drawing.Point(8, 35)
        Me.CmdEdit.Name = "CmdEdit"
        Me.CmdEdit.TabIndex = 1
        Me.CmdEdit.Text = "&Edit"
        '
        'CmdSearch
        '
        Me.CmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdSearch.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CmdSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmdSearch.Location = New System.Drawing.Point(8, 92)
        Me.CmdSearch.Name = "CmdSearch"
        Me.CmdSearch.TabIndex = 3
        Me.CmdSearch.Text = "Sea&rch"
        '
        'CmdDelete
        '
        Me.CmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdDelete.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CmdDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmdDelete.Location = New System.Drawing.Point(8, 64)
        Me.CmdDelete.Name = "CmdDelete"
        Me.CmdDelete.TabIndex = 2
        Me.CmdDelete.Text = "&Delete"
        '
        'CmdAdd
        '
        Me.CmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdAdd.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmdAdd.Location = New System.Drawing.Point(8, 8)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.TabIndex = 0
        Me.CmdAdd.Text = "&Add"
        '
        'LblDisplay
        '
        Me.LblDisplay.BackColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.LblDisplay.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblDisplay.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDisplay.ForeColor = System.Drawing.Color.White
        Me.LblDisplay.Location = New System.Drawing.Point(0, 0)
        Me.LblDisplay.Name = "LblDisplay"
        Me.LblDisplay.Size = New System.Drawing.Size(680, 24)
        Me.LblDisplay.TabIndex = 3
        Me.LblDisplay.Text = "User Master"
        Me.LblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UPanel
        '
        Me.UPanel.Controls.Add(Me.TxTUserLevel)
        Me.UPanel.Controls.Add(Me.TxTPASS)
        Me.UPanel.Controls.Add(Me.TxTUNAME)
        Me.UPanel.Controls.Add(Me.TxTUID)
        Me.UPanel.Controls.Add(Me.Label3)
        Me.UPanel.Controls.Add(Me.Label2)
        Me.UPanel.Controls.Add(Me.Label1)
        Me.UPanel.Controls.Add(Me.LUID)
        Me.UPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UPanel.Location = New System.Drawing.Point(0, 24)
        Me.UPanel.Name = "UPanel"
        Me.UPanel.Size = New System.Drawing.Size(588, 245)
        Me.UPanel.TabIndex = 2
        '
        'TxTUserLevel
        '
        Me.TxTUserLevel.BackColor = System.Drawing.Color.White
        Me.TxTUserLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTUserLevel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTUserLevel.Items.Add("OPERATOR")
        Me.TxTUserLevel.Items.Add("SUPERVISOR")
        Me.TxTUserLevel.Items.Add("OWNER")
        Me.TxTUserLevel.Location = New System.Drawing.Point(96, 88)
        Me.TxTUserLevel.Name = "TxTUserLevel"
        Me.TxTUserLevel.ReadOnly = True
        Me.TxTUserLevel.Size = New System.Drawing.Size(144, 22)
        Me.TxTUserLevel.TabIndex = 7
        '
        'TxTPASS
        '
        Me.TxTPASS.BackColor = System.Drawing.Color.White
        Me.TxTPASS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTPASS.Font = New System.Drawing.Font("Wingdings", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.TxTPASS.Location = New System.Drawing.Point(96, 64)
        Me.TxTPASS.MaxLength = 20
        Me.TxTPASS.Name = "TxTPASS"
        Me.TxTPASS.PasswordChar = Microsoft.VisualBasic.ChrW(108)
        Me.TxTPASS.Size = New System.Drawing.Size(144, 21)
        Me.TxTPASS.TabIndex = 6
        Me.TxTPASS.Text = ""
        '
        'TxTUNAME
        '
        Me.TxTUNAME.BackColor = System.Drawing.Color.White
        Me.TxTUNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTUNAME.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTUNAME.Location = New System.Drawing.Point(96, 40)
        Me.TxTUNAME.MaxLength = 20
        Me.TxTUNAME.Name = "TxTUNAME"
        Me.TxTUNAME.Size = New System.Drawing.Size(144, 22)
        Me.TxTUNAME.TabIndex = 5
        Me.TxTUNAME.Text = ""
        '
        'TxTUID
        '
        Me.TxTUID.BackColor = System.Drawing.Color.White
        Me.TxTUID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTUID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTUID.Location = New System.Drawing.Point(96, 16)
        Me.TxTUID.MaxLength = 3
        Me.TxTUID.Name = "TxTUID"
        Me.TxTUID.Size = New System.Drawing.Size(56, 22)
        Me.TxTUID.TabIndex = 4
        Me.TxTUID.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Level :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User Name :"
        '
        'LUID
        '
        Me.LUID.AutoSize = True
        Me.LUID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUID.Location = New System.Drawing.Point(16, 16)
        Me.LUID.Name = "LUID"
        Me.LUID.Size = New System.Drawing.Size(59, 19)
        Me.LUID.TabIndex = 0
        Me.LUID.Text = "User ID :"
        '
        'UserCre
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(680, 469)
        Me.Controls.Add(Me.UPanel)
        Me.Controls.Add(Me.BPanel)
        Me.Controls.Add(Me.DGrid)
        Me.Controls.Add(Me.LblDisplay)
        Me.KeyPreview = True
        Me.Name = "UserCre"
        Me.Text = "User Creation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BPanel.ResumeLayout(False)
        Me.UPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ShowUserDetails()
        Try
            Con = New OleDbConnection(ConStr)
            Da = New OleDbDataAdapter("SELECT UserID,UserName,Password,ULevel,IIF(ULevel=0,'OPERATOR',IIF(ULevel=1,'SUPERVISOR','OWNER')) as ShowLevel FROM USERLIST", Con)
            Ds.Clear()
            Da.Fill(Ds, "UL")
            CmB = New OleDbCommandBuilder(Da)
            DGrid.DataSource = Ds
            DGrid.DataMember = "UL"
        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub
    Private Sub UserCre_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowUserDetails()
        E_D(True)
        UPanel.Enabled = False
        Ds_PositionChanged()
        If imUser.GetUserLevel = UserLogin.UserLevel.[OPERATOR] Then
            CmdAdd.Enabled = False
            CmdEdit.Enabled = False
            CmdHelp.Enabled = False
            CmdDelete.Enabled = False
            CmdSearch.Enabled = False
            CmdExit.Enabled = True
        End If
    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Close()
    End Sub
    Private Sub E_D(ByVal Flag As Boolean)
        CmdAdd.Enabled = Flag
        CmdDelete.Enabled = Flag
        CmdSearch.Enabled = Flag
        CmdExit.Enabled = Flag
        CmdEdit.Enabled = Flag
        CmdHelp.Enabled = Flag
        CmdSave.Enabled = Not Flag
        CmdCancel.Enabled = Not Flag
    End Sub

    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        E_D(False)
        Opr = ModMain.Operation.Add
        UPanel.Enabled = True
        DGrid.Enabled = False
        ClearAll()
        TxTUID.Focus()
    End Sub
    Private Sub ClearAll()
        TxTUNAME.Text = ""
        TxTPASS.Text = ""
        TxTUID.Text = ""
        TxTUserLevel.SelectedIndex = -1
    End Sub

    Private Sub CmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEdit.Click
        E_D(False)
        Opr = ModMain.Operation.Edit
        UPanel.Enabled = Not UPanel.Enabled
        DGrid.Enabled = False
        TxTUID.Focus()
    End Sub

    Private Sub CmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSave.Click
        If TxTUID.Text.Length < 3 Then
            MsgBox("Please Enter The UserID")
            TxTUID.Focus()
            TxTUID.SelectAll()
            Exit Sub
        End If
        If Trim(TxTUNAME.Text).Length = 0 Then
            MsgBox("Please Enter The User Name")
            TxTUNAME.Focus()
            TxTUNAME.SelectAll()
            Exit Sub
        End If
        If Trim(TxTPASS.Text).Length = 0 Then
            MsgBox("Please Enter The Password")
            TxTPASS.Focus()
            TxTPASS.SelectAll()
            Exit Sub
        End If
        If TxTUserLevel.SelectedIndex = -1 Then
            MsgBox("Please Select The User Level")
            TxTUserLevel.Focus()
            TxTUserLevel.SelectedIndex = 0
            Exit Sub
        End If
        Try
            If Opr = ModMain.Operation.Edit Then
                Ds.Tables("UL").Rows.Item(Me.BindingContext(Ds, "UL").Position).Item(0) = TxTUID.Text
                Ds.Tables("UL").Rows.Item(Me.BindingContext(Ds, "UL").Position).Item(1) = TxTUNAME.Text
                Ds.Tables("UL").Rows.Item(Me.BindingContext(Ds, "UL").Position).Item(2) = TxTPASS.Text
                Ds.Tables("UL").Rows.Item(Me.BindingContext(Ds, "UL").Position).Item(3) = TxTUserLevel.SelectedIndex
                Ds.Tables("UL").Rows.Item(Me.BindingContext(Ds, "UL").Position).Item(4) = TxTUserLevel.SelectedItem
                Dim DT As DataTable
                DT = Ds.Tables("UL").GetChanges(DataRowState.Modified)
                Da.Update(DT)
                Ds.AcceptChanges()
            End If
            If Opr = ModMain.Operation.Add Then
                Dim Dr As DataRow
                Dr = Ds.Tables("UL").NewRow
                Dr.Item(0) = TxTUID.Text
                Dr.Item(1) = TxTUNAME.Text
                Dr.Item(2) = TxTPASS.Text
                Dr.Item(3) = TxTUserLevel.SelectedIndex
                Dr.Item(4) = TxTUserLevel.Text
                Ds.Tables("UL").Rows.Add(Dr)
                Ds.AcceptChanges()
                Da.Update(Ds, "UL")
                Dim Cmd As New OleDbCommand
                Cmd.CommandText = "INSERT INTO USERLIST Values(@UID,@UNAME,@Pass,@ULEVEL)"
                Cmd.CommandType = CommandType.Text
                Cmd.Connection = Con
                Dim P As New OleDbParameter
                P.ParameterName = "@UID"
                P.DbType = DbType.String
                P.Direction = ParameterDirection.Input
                P.Value = TxTUID.Text
                Cmd.Parameters.Add(P)
                P = New OleDbParameter
                P.ParameterName = "@UName"
                P.DbType = DbType.String
                P.Direction = ParameterDirection.Input
                P.Value = TxTUNAME.Text
                Cmd.Parameters.Add(P)
                P = New OleDbParameter
                P.ParameterName = "@Pass"
                P.DbType = DbType.String
                P.Direction = ParameterDirection.Input
                P.Value = TxTPASS.Text
                Cmd.Parameters.Add(P)
                P = New OleDbParameter
                P.ParameterName = "@ULevel"
                P.DbType = DbType.Byte
                P.Direction = ParameterDirection.Input
                P.Value = TxTUserLevel.SelectedIndex
                Cmd.Parameters.Add(P)
                Con.Open()
                Cmd.ExecuteNonQuery()
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            Con.Close()
            Opr = ModMain.Operation.None
        End Try
        E_D(True)
        UPanel.Enabled = False
        DGrid.Enabled = True
    End Sub

    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        E_D(True)
        UPanel.Enabled = False
        DGrid.Enabled = True
        Opr = ModMain.Operation.None
    End Sub

    Private Sub UserCre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
        If Not Opr = Operation.None Then Exit Sub
        Select Case e.KeyCode
            Case Keys.PageUp
                StrNavigation = ModMain.Navigation.MovePrevious
                SendKeys.Send("{f2}")
            Case Keys.PageDown
                StrNavigation = ModMain.Navigation.MoveNext
                SendKeys.Send("{f2}")
            Case Keys.Home
                StrNavigation = ModMain.Navigation.MoveFirst
                SendKeys.Send("{f2}")
            Case Keys.End
                StrNavigation = ModMain.Navigation.MoveLast
                SendKeys.Send("{f2}")
            Case Keys.F2
                Select Case StrNavigation
                    Case ModMain.Navigation.MoveFirst
                        Me.BindingContext(Ds, "UL").Position = 0
                        Me.Ds_PositionChanged()
                    Case ModMain.Navigation.MovePrevious
                        If Me.BindingContext(Ds, "UL").Position >= 0 Then
                            Me.BindingContext(Ds, "UL").Position = (Me.BindingContext(Ds, "UL").Position - 1)
                            Me.Ds_PositionChanged()
                        End If
                    Case ModMain.Navigation.MoveNext
                        Me.BindingContext(Ds, "UL").Position = (Me.BindingContext(Ds, "UL").Position + 1)
                        Me.Ds_PositionChanged()
                    Case ModMain.Navigation.MoveLast
                        Me.BindingContext(Ds, "UL").Position = (Me.Ds.Tables("UL").Rows.Count - 1)
                        Me.Ds_PositionChanged()
                End Select
        End Select
    End Sub

    Private Sub TxTUID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxTUID.TextChanged

    End Sub

    Private Sub TxTUID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxTUID.KeyPress
        FnChar(e)
    End Sub

    Private Sub TxTUNAME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxTUNAME.TextChanged

    End Sub
    Private Sub DGrid_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DGrid.Navigate

    End Sub
    Private Sub Ds_PositionChanged()
        TxTUID.Text = Ds.Tables("UL").Rows(Me.BindingContext(Ds, "UL").Position).Item(0)
        TxTUNAME.Text = Ds.Tables("UL").Rows(Me.BindingContext(Ds, "UL").Position).Item(1)
        TxTPASS.Text = Ds.Tables("UL").Rows(Me.BindingContext(Ds, "UL").Position).Item(2)
        TxTUserLevel.SelectedIndex = Ds.Tables("UL").Rows(Me.BindingContext(Ds, "UL").Position).Item(3)
        Me.Text = "User Master : " & (((Me.BindingContext(Ds, "UL").Position + 1).ToString + " of  ") _
                + Me.BindingContext(Ds, "UL").Count.ToString)
    End Sub
    Private Sub CmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDelete.Click
        If MsgBox("Are you sure want to delete user " & TxTUID.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Delete User") = MsgBoxResult.Yes Then
        End If
    End Sub
    Private Sub DGrid_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGrid.CurrentCellChanged
        If DGrid.VisibleRowCount > 0 Then
            If DGrid.CurrentRowIndex >= 0 Then
                Me.BindingContext(Ds, "UL").Position = DGrid.CurrentRowIndex
            End If
        End If
        TxTUID.Text = Ds.Tables("UL").Rows(Me.BindingContext(Ds, "UL").Position).Item(0)
        TxTUNAME.Text = Ds.Tables("UL").Rows(Me.BindingContext(Ds, "UL").Position).Item(1)
        TxTPASS.Text = Ds.Tables("UL").Rows(Me.BindingContext(Ds, "UL").Position).Item(2)
        TxTUserLevel.SelectedIndex = Ds.Tables("UL").Rows(Me.BindingContext(Ds, "UL").Position).Item(3)
        Me.Ds_PositionChanged()
    End Sub

    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click

    End Sub
End Class
