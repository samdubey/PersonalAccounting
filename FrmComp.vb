Imports System.IO
Public Class FrmCreateCompany
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
    Friend WithEvents XSchema1 As PersonnelAcc.XSchema
    Friend WithEvents BPanel As System.Windows.Forms.Panel
    Friend WithEvents CmdHelp As System.Windows.Forms.Button
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents CmdEdit As System.Windows.Forms.Button
    Friend WithEvents CmdSearch As System.Windows.Forms.Button
    Friend WithEvents CmdDelete As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents TxTCompName As System.Windows.Forms.TextBox
    Friend WithEvents lblCompName As System.Windows.Forms.Label
    Friend WithEvents TxTCompCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCompCode As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LblDisplay As System.Windows.Forms.Label
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents TxTKeyP As System.Windows.Forms.TextBox
    Friend WithEvents TxTTan As System.Windows.Forms.TextBox
    Friend WithEvents TxTTin As System.Windows.Forms.TextBox
    Friend WithEvents TxTPan As System.Windows.Forms.TextBox
    Friend WithEvents TxTWeb As System.Windows.Forms.TextBox
    Friend WithEvents TxTEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxTPhR As System.Windows.Forms.TextBox
    Friend WithEvents TxTPin As System.Windows.Forms.TextBox
    Friend WithEvents TxTPhO As System.Windows.Forms.TextBox
    Friend WithEvents TxTCity As System.Windows.Forms.TextBox
    Friend WithEvents TxTAddress As System.Windows.Forms.TextBox
    Friend WithEvents DtToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents EDPanel As System.Windows.Forms.Panel
    Friend WithEvents FromDT As System.Windows.Forms.TextBox
    Friend WithEvents ToDT As System.Windows.Forms.TextBox
    Friend WithEvents TxTDBName As System.Windows.Forms.TextBox
    Friend WithEvents TxTRDBPath As System.Windows.Forms.TextBox
    Friend WithEvents TxTADDBPath As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxTShortName As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.XSchema1 = New PersonnelAcc.XSchema
        Me.BPanel = New System.Windows.Forms.Panel
        Me.CmdHelp = New System.Windows.Forms.Button
        Me.CmdCancel = New System.Windows.Forms.Button
        Me.CmdExit = New System.Windows.Forms.Button
        Me.CmdSave = New System.Windows.Forms.Button
        Me.CmdEdit = New System.Windows.Forms.Button
        Me.CmdSearch = New System.Windows.Forms.Button
        Me.CmdDelete = New System.Windows.Forms.Button
        Me.CmdAdd = New System.Windows.Forms.Button
        Me.EDPanel = New System.Windows.Forms.Panel
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxTShortName = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.TxTDBName = New System.Windows.Forms.TextBox
        Me.TxTRDBPath = New System.Windows.Forms.TextBox
        Me.TxTADDBPath = New System.Windows.Forms.TextBox
        Me.TxTKeyP = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxTTan = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxTTin = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxTPan = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxTWeb = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxTEmail = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxTPhR = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxTPin = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxTPhO = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxTCity = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxTAddress = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxTCompName = New System.Windows.Forms.TextBox
        Me.lblCompName = New System.Windows.Forms.Label
        Me.TxTCompCode = New System.Windows.Forms.TextBox
        Me.lblCompCode = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DtToDate = New System.Windows.Forms.DateTimePicker
        Me.DtFromDate = New System.Windows.Forms.DateTimePicker
        Me.ToDT = New System.Windows.Forms.TextBox
        Me.FromDT = New System.Windows.Forms.TextBox
        Me.LblDisplay = New System.Windows.Forms.Label
        CType(Me.XSchema1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BPanel.SuspendLayout()
        Me.EDPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'XSchema1
        '
        Me.XSchema1.DataSetName = "XSchema"
        Me.XSchema1.Locale = New System.Globalization.CultureInfo("en-US")
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
        Me.BPanel.Location = New System.Drawing.Point(590, 24)
        Me.BPanel.Name = "BPanel"
        Me.BPanel.Size = New System.Drawing.Size(92, 455)
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
        'EDPanel
        '
        Me.EDPanel.Controls.Add(Me.Label14)
        Me.EDPanel.Controls.Add(Me.TxTShortName)
        Me.EDPanel.Controls.Add(Me.Label17)
        Me.EDPanel.Controls.Add(Me.TxTDBName)
        Me.EDPanel.Controls.Add(Me.TxTRDBPath)
        Me.EDPanel.Controls.Add(Me.TxTADDBPath)
        Me.EDPanel.Controls.Add(Me.TxTKeyP)
        Me.EDPanel.Controls.Add(Me.Label12)
        Me.EDPanel.Controls.Add(Me.TxTTan)
        Me.EDPanel.Controls.Add(Me.Label13)
        Me.EDPanel.Controls.Add(Me.TxTTin)
        Me.EDPanel.Controls.Add(Me.Label11)
        Me.EDPanel.Controls.Add(Me.TxTPan)
        Me.EDPanel.Controls.Add(Me.Label10)
        Me.EDPanel.Controls.Add(Me.TxTWeb)
        Me.EDPanel.Controls.Add(Me.Label8)
        Me.EDPanel.Controls.Add(Me.TxTEmail)
        Me.EDPanel.Controls.Add(Me.Label9)
        Me.EDPanel.Controls.Add(Me.TxTPhR)
        Me.EDPanel.Controls.Add(Me.Label7)
        Me.EDPanel.Controls.Add(Me.TxTPin)
        Me.EDPanel.Controls.Add(Me.Label6)
        Me.EDPanel.Controls.Add(Me.TxTPhO)
        Me.EDPanel.Controls.Add(Me.Label5)
        Me.EDPanel.Controls.Add(Me.TxTCity)
        Me.EDPanel.Controls.Add(Me.Label4)
        Me.EDPanel.Controls.Add(Me.TxTAddress)
        Me.EDPanel.Controls.Add(Me.Label3)
        Me.EDPanel.Controls.Add(Me.TxTCompName)
        Me.EDPanel.Controls.Add(Me.lblCompName)
        Me.EDPanel.Controls.Add(Me.TxTCompCode)
        Me.EDPanel.Controls.Add(Me.lblCompCode)
        Me.EDPanel.Controls.Add(Me.GroupBox1)
        Me.EDPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EDPanel.Location = New System.Drawing.Point(0, 24)
        Me.EDPanel.Name = "EDPanel"
        Me.EDPanel.Size = New System.Drawing.Size(682, 455)
        Me.EDPanel.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(200, 384)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 80)
        Me.Label14.TabIndex = 31
        '
        'TxTShortName
        '
        Me.TxTShortName.BackColor = System.Drawing.Color.White
        Me.TxTShortName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTShortName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.XSchema1, "CompanyInfo.ShortName"))
        Me.TxTShortName.Location = New System.Drawing.Point(112, 64)
        Me.TxTShortName.MaxLength = 5
        Me.TxTShortName.Name = "TxTShortName"
        Me.TxTShortName.Size = New System.Drawing.Size(120, 22)
        Me.TxTShortName.TabIndex = 5
        Me.TxTShortName.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(24, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 18)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "&Short Name:"
        '
        'TxTDBName
        '
        Me.TxTDBName.BackColor = System.Drawing.Color.White
        Me.TxTDBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTDBName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.XSchema1, "CompanyInfo.DBName"))
        Me.TxTDBName.Enabled = False
        Me.TxTDBName.Location = New System.Drawing.Point(224, 432)
        Me.TxTDBName.Name = "TxTDBName"
        Me.TxTDBName.Size = New System.Drawing.Size(8, 22)
        Me.TxTDBName.TabIndex = 30
        Me.TxTDBName.Text = ""
        '
        'TxTRDBPath
        '
        Me.TxTRDBPath.BackColor = System.Drawing.Color.White
        Me.TxTRDBPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTRDBPath.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.XSchema1, "CompanyInfo.RDBPath"))
        Me.TxTRDBPath.Enabled = False
        Me.TxTRDBPath.Location = New System.Drawing.Point(224, 408)
        Me.TxTRDBPath.Name = "TxTRDBPath"
        Me.TxTRDBPath.Size = New System.Drawing.Size(8, 22)
        Me.TxTRDBPath.TabIndex = 28
        Me.TxTRDBPath.Text = ""
        '
        'TxTADDBPath
        '
        Me.TxTADDBPath.BackColor = System.Drawing.Color.White
        Me.TxTADDBPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTADDBPath.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.XSchema1, "CompanyInfo.ADBPath"))
        Me.TxTADDBPath.Enabled = False
        Me.TxTADDBPath.Location = New System.Drawing.Point(224, 384)
        Me.TxTADDBPath.Name = "TxTADDBPath"
        Me.TxTADDBPath.Size = New System.Drawing.Size(8, 22)
        Me.TxTADDBPath.TabIndex = 26
        Me.TxTADDBPath.Text = ""
        '
        'TxTKeyP
        '
        Me.TxTKeyP.BackColor = System.Drawing.Color.White
        Me.TxTKeyP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTKeyP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.XSchema1, "CompanyInfo.KeyPerson"))
        Me.TxTKeyP.Location = New System.Drawing.Point(112, 296)
        Me.TxTKeyP.MaxLength = 25
        Me.TxTKeyP.Name = "TxTKeyP"
        Me.TxTKeyP.Size = New System.Drawing.Size(376, 22)
        Me.TxTKeyP.TabIndex = 23
        Me.TxTKeyP.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 296)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 18)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Key Person"
        '
        'TxTTan
        '
        Me.TxTTan.BackColor = System.Drawing.Color.White
        Me.TxTTan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTTan.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.XSchema1, "CompanyInfo.TANNo"))
        Me.TxTTan.Location = New System.Drawing.Point(112, 272)
        Me.TxTTan.MaxLength = 30
        Me.TxTTan.Name = "TxTTan"
        Me.TxTTan.Size = New System.Drawing.Size(376, 22)
        Me.TxTTan.TabIndex = 21
        Me.TxTTan.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 272)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 18)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "TAN No."
        '
        'TxTTin
        '
        Me.TxTTin.BackColor = System.Drawing.Color.White
        Me.TxTTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTTin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.XSchema1, "CompanyInfo.TINNo"))
        Me.TxTTin.Location = New System.Drawing.Point(112, 248)
        Me.TxTTin.MaxLength = 30
        Me.TxTTin.Name = "TxTTin"
        Me.TxTTin.Size = New System.Drawing.Size(376, 22)
        Me.TxTTin.TabIndex = 19
        Me.TxTTin.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 248)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 18)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "TIN No."
        '
        'TxTPan
        '
        Me.TxTPan.BackColor = System.Drawing.Color.White
        Me.TxTPan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTPan.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.XSchema1, "CompanyInfo.PANNo"))
        Me.TxTPan.Location = New System.Drawing.Point(112, 224)
        Me.TxTPan.MaxLength = 30
        Me.TxTPan.Name = "TxTPan"
        Me.TxTPan.Size = New System.Drawing.Size(376, 22)
        Me.TxTPan.TabIndex = 17
        Me.TxTPan.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 18)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "PAN No."
        '
        'TxTWeb
        '
        Me.TxTWeb.BackColor = System.Drawing.Color.White
        Me.TxTWeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTWeb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.XSchema1, "CompanyInfo.WebSite"))
        Me.TxTWeb.Location = New System.Drawing.Point(352, 200)
        Me.TxTWeb.MaxLength = 25
        Me.TxTWeb.Name = "TxTWeb"
        Me.TxTWeb.Size = New System.Drawing.Size(136, 22)
        Me.TxTWeb.TabIndex = 17
        Me.TxTWeb.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(264, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "&WebSite"
        '
        'TxTEmail
        '
        Me.TxTEmail.BackColor = System.Drawing.Color.White
        Me.TxTEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.XSchema1, "CompanyInfo.Email"))
        Me.TxTEmail.Location = New System.Drawing.Point(112, 200)
        Me.TxTEmail.MaxLength = 20
        Me.TxTEmail.Name = "TxTEmail"
        Me.TxTEmail.Size = New System.Drawing.Size(144, 22)
        Me.TxTEmail.TabIndex = 15
        Me.TxTEmail.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 18)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "&Email"
        '
        'TxTPhR
        '
        Me.TxTPhR.BackColor = System.Drawing.Color.White
        Me.TxTPhR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTPhR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.XSchema1, "CompanyInfo.PhoneR"))
        Me.TxTPhR.Location = New System.Drawing.Point(352, 176)
        Me.TxTPhR.MaxLength = 15
        Me.TxTPhR.Name = "TxTPhR"
        Me.TxTPhR.Size = New System.Drawing.Size(136, 22)
        Me.TxTPhR.TabIndex = 15
        Me.TxTPhR.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(264, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Phone(&Resi)"
        '
        'TxTPin
        '
        Me.TxTPin.BackColor = System.Drawing.Color.White
        Me.TxTPin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTPin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.XSchema1, "CompanyInfo.Pincode"))
        Me.TxTPin.Location = New System.Drawing.Point(352, 152)
        Me.TxTPin.MaxLength = 6
        Me.TxTPin.Name = "TxTPin"
        Me.TxTPin.Size = New System.Drawing.Size(136, 22)
        Me.TxTPin.TabIndex = 11
        Me.TxTPin.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(264, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "&Pincode"
        '
        'TxTPhO
        '
        Me.TxTPhO.BackColor = System.Drawing.Color.White
        Me.TxTPhO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTPhO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.XSchema1, "CompanyInfo.PhoneO"))
        Me.TxTPhO.Location = New System.Drawing.Point(112, 176)
        Me.TxTPhO.MaxLength = 15
        Me.TxTPhO.Name = "TxTPhO"
        Me.TxTPhO.Size = New System.Drawing.Size(144, 22)
        Me.TxTPhO.TabIndex = 13
        Me.TxTPhO.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Phone (&Off)"
        '
        'TxTCity
        '
        Me.TxTCity.BackColor = System.Drawing.Color.White
        Me.TxTCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.XSchema1, "CompanyInfo.City"))
        Me.TxTCity.Location = New System.Drawing.Point(112, 152)
        Me.TxTCity.MaxLength = 20
        Me.TxTCity.Name = "TxTCity"
        Me.TxTCity.Size = New System.Drawing.Size(144, 22)
        Me.TxTCity.TabIndex = 9
        Me.TxTCity.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Ci&ty "
        '
        'TxTAddress
        '
        Me.TxTAddress.BackColor = System.Drawing.Color.White
        Me.TxTAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.XSchema1, "CompanyInfo.CompanyAddress"))
        Me.TxTAddress.Location = New System.Drawing.Point(112, 88)
        Me.TxTAddress.MaxLength = 70
        Me.TxTAddress.Multiline = True
        Me.TxTAddress.Name = "TxTAddress"
        Me.TxTAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxTAddress.Size = New System.Drawing.Size(376, 56)
        Me.TxTAddress.TabIndex = 7
        Me.TxTAddress.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "&Address"
        '
        'TxTCompName
        '
        Me.TxTCompName.BackColor = System.Drawing.Color.White
        Me.TxTCompName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTCompName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.XSchema1, "CompanyInfo.CompanyName"))
        Me.TxTCompName.Location = New System.Drawing.Point(112, 40)
        Me.TxTCompName.MaxLength = 25
        Me.TxTCompName.Name = "TxTCompName"
        Me.TxTCompName.Size = New System.Drawing.Size(376, 22)
        Me.TxTCompName.TabIndex = 3
        Me.TxTCompName.Text = ""
        '
        'lblCompName
        '
        Me.lblCompName.AutoSize = True
        Me.lblCompName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompName.Location = New System.Drawing.Point(24, 40)
        Me.lblCompName.Name = "lblCompName"
        Me.lblCompName.Size = New System.Drawing.Size(45, 18)
        Me.lblCompName.TabIndex = 2
        Me.lblCompName.Text = "&Name"
        '
        'TxTCompCode
        '
        Me.TxTCompCode.BackColor = System.Drawing.Color.White
        Me.TxTCompCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTCompCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.XSchema1, "CompanyInfo.CompanyCode"))
        Me.TxTCompCode.Enabled = False
        Me.TxTCompCode.Location = New System.Drawing.Point(112, 16)
        Me.TxTCompCode.MaxLength = 10
        Me.TxTCompCode.Name = "TxTCompCode"
        Me.TxTCompCode.ReadOnly = True
        Me.TxTCompCode.Size = New System.Drawing.Size(144, 22)
        Me.TxTCompCode.TabIndex = 1
        Me.TxTCompCode.Text = ""
        '
        'lblCompCode
        '
        Me.lblCompCode.AutoSize = True
        Me.lblCompCode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompCode.Location = New System.Drawing.Point(24, 16)
        Me.lblCompCode.Name = "lblCompCode"
        Me.lblCompCode.Size = New System.Drawing.Size(39, 18)
        Me.lblCompCode.TabIndex = 0
        Me.lblCompCode.Text = "Code"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DtToDate)
        Me.GroupBox1.Controls.Add(Me.DtFromDate)
        Me.GroupBox1.Controls.Add(Me.ToDT)
        Me.GroupBox1.Controls.Add(Me.FromDT)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 328)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 56)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Financial &Year"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&From :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(304, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&To     :"
        '
        'DtToDate
        '
        Me.DtToDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.DtToDate.Checked = False
        Me.DtToDate.CustomFormat = "dd-MM-yyyy"
        Me.DtToDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtToDate.Location = New System.Drawing.Point(352, 24)
        Me.DtToDate.Name = "DtToDate"
        Me.DtToDate.Size = New System.Drawing.Size(104, 22)
        Me.DtToDate.TabIndex = 3
        Me.DtToDate.Value = New Date(2007, 3, 31, 0, 0, 0, 0)
        '
        'DtFromDate
        '
        Me.DtFromDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.DtFromDate.Checked = False
        Me.DtFromDate.CustomFormat = "dd-MM-yyyy"
        Me.DtFromDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtFromDate.Location = New System.Drawing.Point(72, 24)
        Me.DtFromDate.Name = "DtFromDate"
        Me.DtFromDate.Size = New System.Drawing.Size(104, 22)
        Me.DtFromDate.TabIndex = 1
        Me.DtFromDate.Value = New Date(2006, 4, 1, 0, 0, 0, 0)
        '
        'ToDT
        '
        Me.ToDT.AutoSize = False
        Me.ToDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToDT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.XSchema1, "CompanyInfo.ToDate"))
        Me.ToDT.Location = New System.Drawing.Point(304, 32)
        Me.ToDT.Name = "ToDT"
        Me.ToDT.Size = New System.Drawing.Size(16, 8)
        Me.ToDT.TabIndex = 5
        Me.ToDT.Text = ""
        '
        'FromDT
        '
        Me.FromDT.AutoSize = False
        Me.FromDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FromDT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.XSchema1, "CompanyInfo.FromDate"))
        Me.FromDT.Location = New System.Drawing.Point(40, 32)
        Me.FromDT.Name = "FromDT"
        Me.FromDT.Size = New System.Drawing.Size(16, 8)
        Me.FromDT.TabIndex = 4
        Me.FromDT.Text = ""
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
        Me.LblDisplay.Size = New System.Drawing.Size(682, 24)
        Me.LblDisplay.TabIndex = 69
        Me.LblDisplay.Text = "Company Master"
        Me.LblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmCreateCompany
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(682, 479)
        Me.Controls.Add(Me.BPanel)
        Me.Controls.Add(Me.EDPanel)
        Me.Controls.Add(Me.LblDisplay)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmCreateCompany"
        Me.ShowInTaskbar = False
        Me.Text = "Company Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.XSchema1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BPanel.ResumeLayout(False)
        Me.EDPanel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim _ADBPath As String
    Dim _DirectoryPath As String
    Dim _DBName As String
    Dim _CurrentDBPath As String
    Dim Opr As Operation
    Private Sub FrmCreateCompany_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If File.Exists(Application.StartupPath & "\DataBase\Companies.xml") = True Then
                XSchema1.Clear()
                XSchema1.ReadXml(Application.StartupPath & "\DataBase\Companies.xml", FileMode.Open)
                Me.XmlSchema1_PositionChanged()
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
        Me.KeyPreview = True
        EDPanel.Enabled = False
        E_D(True)
    End Sub
    Private Sub CmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSave.Click
        If Trim(TxTCompName.Text) = "" Then
            MsgBox("Please Enter Company Name", MsgBoxStyle.Information)
            TxTCompName.Focus()
            Exit Sub
        End If
        If Trim(TxTShortName.Text).Length < 1 Then
            MsgBox("Please Enter Short Name", MsgBoxStyle.Information)
            TxTShortName.Focus()
            Exit Sub
        End If
        FromDT.Text = DtFromDate.Value
        ToDT.Text = DtToDate.Value
        If Opr = ModMain.Operation.Add Then
            If GenerateCode() = False Then Exit Sub
        End If
        TxTCompCode.Text = _DBName
        Try
            Me.BindingContext(XSchema1, "CompanyInfo").EndCurrentEdit()
            XSchema1.GetChanges()
            XSchema1.AcceptChanges()
            XSchema1.WriteXml(Application.StartupPath & "\DataBase\Companies.xml")
            MsgBox("The Company Saved Sucessfully", MsgBoxStyle.Information, "Company Information")
        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            Opr = ModMain.Operation.None
            E_D(True)
            EDPanel.Enabled = False
        End Try
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
    Private Sub XmlSchema1_PositionChanged()
        Me.Text = "Company Master : " & (((Me.BindingContext(XSchema1, "CompanyInfo").Position + 1).ToString + " of  ") _
                    + Me.BindingContext(XSchema1, "CompanyInfo").Count.ToString)
    End Sub
    Private Sub SpcED(ByVal Flag As Boolean)
        TxTShortName.Enabled = Flag
        DtFromDate.Enabled = Flag
        DtToDate.Enabled = Flag
    End Sub
    Private Sub CmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        Try
            Opr = Operation.Add
            E_D(False)
            EDPanel.Enabled = True
            SpcED(True)
            Me.BindingContext(XSchema1, "CompanyInfo").EndCurrentEdit()
            Me.BindingContext(XSchema1, "CompanyInfo").AddNew()
            TxTCompName.Focus()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.XmlSchema1_PositionChanged()
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        If MsgBox("Are You Sure Want To Exit ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Quit") = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub
    Private Sub FrmCreateCompany_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
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
                        Me.BindingContext(XSchema1, "CompanyInfo").Position = 0
                        Me.XmlSchema1_PositionChanged()
                    Case ModMain.Navigation.MovePrevious
                        If Me.BindingContext(XSchema1, "CompanyInfo").Position >= 0 Then
                            Me.BindingContext(XSchema1, "CompanyInfo").Position = (Me.BindingContext(XSchema1, "CompanyInfo").Position - 1)
                            Me.XmlSchema1_PositionChanged()
                        End If
                    Case ModMain.Navigation.MoveNext
                        Me.BindingContext(XSchema1, "CompanyInfo").Position = (Me.BindingContext(XSchema1, "CompanyInfo").Position + 1)
                        Me.XmlSchema1_PositionChanged()
                    Case ModMain.Navigation.MoveLast
                        Me.BindingContext(XSchema1, "CompanyInfo").Position = (Me.XSchema1.Tables("CompanyInfo").Rows.Count - 1)
                        Me.XmlSchema1_PositionChanged()
                End Select
        End Select
    End Sub
    Private Sub CmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        Me.BindingContext(XSchema1, "CompanyInfo").CancelCurrentEdit()
        Me.XmlSchema1_PositionChanged()
        Opr = ModMain.Operation.None
        E_D(True)
        EDPanel.Enabled = False
    End Sub

    Private Sub CmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEdit.Click
        E_D(False)
        SpcED(False)
        Opr = Operation.Edit
        EDPanel.Enabled = True
        TxTCompName.Focus()
    End Sub

    Private Sub CmdSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        Opr = Operation.Search
        CallSearch()
    End Sub
    Private Sub CallSearch()
        MsgBox("The Search Is Under Developement Sorry")
    End Sub

    Private Sub CmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDelete.Click
        If System.Windows.Forms.MessageBox.Show("Are You Sure Want To Delete This Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.No Then
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Try
            If (Me.BindingContext(XSchema1, "Companyinfo").Count > 0) Then
                Me.BindingContext(XSchema1, "Companyinfo").RemoveAt(Me.BindingContext(XSchema1, "Companyinfo").Position)
                Me.XmlSchema1_PositionChanged()
            End If
            Me.BindingContext(XSchema1, "CompanyInfo").EndCurrentEdit()
            XSchema1.GetChanges()
            XSchema1.AcceptChanges()
            XSchema1.WriteXml(Application.StartupPath & "\DataBase\Companies.xml")
            MsgBox("The Record Deleted Sucessfully", MsgBoxStyle.Information, "Account Master")
        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub TxTCompName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxTCompName.LostFocus
        TxTCompName.Text = TxTCompName.Text.ToUpper
    End Sub

    Private Sub FromDT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FromDT.TextChanged
        If IsDate(FromDT.Text) = True Then
            DtFromDate.Value = FromDT.Text
        End If
    End Sub

    Private Sub ToDT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToDT.TextChanged
        If IsDate(ToDT.Text) = True Then
            DtToDate.Value = ToDT.Text
        End If
    End Sub
    Private Function GenerateCode() As Boolean
        Dim STRCODE As String
        Try
            STRCODE = TxTShortName.Text
            STRCODE += DtFromDate.Value.Year.ToString.Substring(2, 2) & DtToDate.Value.Year.ToString.Substring(2, 2)
            _DBName = STRCODE
            _DirectoryPath = Application.StartupPath & "\DataBase\" & _DBName
            _ADBPath = _DirectoryPath & "\" & _DBName & XTension
            If File.Exists(_ADBPath) Then
                MsgBox("The Company Already Exist", MsgBoxStyle.Information, "Can't Proceed")
                Return False
            End If
            'If Directory.Exists(_DirectoryPath) = True Then
            '    MsgBox("The Company Already Exist", MsgBoxStyle.Information, "Can't Proceed")
            '    Return False
            'End If
            _CurrentDBPath = Application.StartupPath & "\DataBase\" & "ACC" & XTension
            Directory.CreateDirectory(_DirectoryPath)
            File.Copy(_CurrentDBPath, _ADBPath)
            TxTADDBPath.Text = _ADBPath
            TxTRDBPath.Text = Application.StartupPath & "\DataBase\" & _DBName
            TxTDBName.Text = _DBName
            Return True
        Catch Ex As Exception
            MsgBox(Ex.Message)
            Return False
        End Try
    End Function
    Private Sub TxTShortName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxTShortName.TextChanged
        TxTCompCode.Text = TxTShortName.Text & DtFromDate.Value.Year.ToString.Substring(2, 2) & DtToDate.Value.Year.ToString.Substring(2, 2)
    End Sub

    Private Sub TxTShortName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxTShortName.KeyPress
        FnChar(e)
    End Sub

    Private Sub TxTShortName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxTShortName.LostFocus
        TxTShortName.Text = TxTShortName.Text.ToUpper
    End Sub

    Private Sub DtFromDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtFromDate.ValueChanged
        TxTCompCode.Text = TxTShortName.Text & DtFromDate.Value.Year.ToString.Substring(2, 2) & DtToDate.Value.Year.ToString.Substring(2, 2)
    End Sub

    Private Sub DtToDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtToDate.ValueChanged
        TxTCompCode.Text = TxTShortName.Text & DtFromDate.Value.Year.ToString.Substring(2, 2) & DtToDate.Value.Year.ToString.Substring(2, 2)
    End Sub
End Class
