Imports System.Data.OleDb
Imports System.Math
Public Class FrmAM
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
    Friend WithEvents TxtTin As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CmbGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Credit As System.Windows.Forms.RadioButton
    Friend WithEvents Debit As System.Windows.Forms.RadioButton
    Friend WithEvents TxTOpAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxTMob As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxTFax As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxTPhResi As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxTPhOff As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxTPincode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxTCity As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxTAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbInitials As System.Windows.Forms.ComboBox
    Friend WithEvents TxTAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxTAcName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxTAcCode As System.Windows.Forms.TextBox
    Friend WithEvents lblAcCode As System.Windows.Forms.Label
    Friend WithEvents LblDisplay As System.Windows.Forms.Label
    Friend WithEvents BPanel As System.Windows.Forms.Panel
    Friend WithEvents CmdHelp As System.Windows.Forms.Button
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents CmdEdit As System.Windows.Forms.Button
    Friend WithEvents CmdSearch As System.Windows.Forms.Button
    Friend WithEvents CmdDelete As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents OleDA As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DSet As PersonnelAcc.DSet
    Friend WithEvents TxTAmt As System.Windows.Forms.TextBox
    Friend WithEvents GPBX As System.Windows.Forms.Panel
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleCon As System.Data.OleDb.OleDbConnection
    Friend WithEvents LST As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GPBX = New System.Windows.Forms.Panel
        Me.TxTAmt = New System.Windows.Forms.TextBox
        Me.TxtTin = New System.Windows.Forms.TextBox
        Me.DSet = New PersonnelAcc.DSet
        Me.Label13 = New System.Windows.Forms.Label
        Me.CmbGroup = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Credit = New System.Windows.Forms.RadioButton
        Me.Debit = New System.Windows.Forms.RadioButton
        Me.TxTOpAmt = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxTMob = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxTFax = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxTPhResi = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxTPhOff = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxTPincode = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxTCity = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxTAddress2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbInitials = New System.Windows.Forms.ComboBox
        Me.TxTAddress1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxTAcName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxTAcCode = New System.Windows.Forms.TextBox
        Me.lblAcCode = New System.Windows.Forms.Label
        Me.LST = New System.Windows.Forms.ListBox
        Me.LblDisplay = New System.Windows.Forms.Label
        Me.BPanel = New System.Windows.Forms.Panel
        Me.CmdHelp = New System.Windows.Forms.Button
        Me.CmdCancel = New System.Windows.Forms.Button
        Me.CmdExit = New System.Windows.Forms.Button
        Me.CmdSave = New System.Windows.Forms.Button
        Me.CmdEdit = New System.Windows.Forms.Button
        Me.CmdSearch = New System.Windows.Forms.Button
        Me.CmdDelete = New System.Windows.Forms.Button
        Me.CmdAdd = New System.Windows.Forms.Button
        Me.OleDA = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleCon = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.GPBX.SuspendLayout()
        CType(Me.DSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GPBX
        '
        Me.GPBX.BackColor = System.Drawing.Color.Transparent
        Me.GPBX.Controls.Add(Me.TxTAmt)
        Me.GPBX.Controls.Add(Me.TxtTin)
        Me.GPBX.Controls.Add(Me.Label13)
        Me.GPBX.Controls.Add(Me.CmbGroup)
        Me.GPBX.Controls.Add(Me.Label12)
        Me.GPBX.Controls.Add(Me.Credit)
        Me.GPBX.Controls.Add(Me.Debit)
        Me.GPBX.Controls.Add(Me.TxTOpAmt)
        Me.GPBX.Controls.Add(Me.Label10)
        Me.GPBX.Controls.Add(Me.Label11)
        Me.GPBX.Controls.Add(Me.TxTMob)
        Me.GPBX.Controls.Add(Me.Label8)
        Me.GPBX.Controls.Add(Me.TxTFax)
        Me.GPBX.Controls.Add(Me.Label9)
        Me.GPBX.Controls.Add(Me.TxTPhResi)
        Me.GPBX.Controls.Add(Me.Label6)
        Me.GPBX.Controls.Add(Me.TxTPhOff)
        Me.GPBX.Controls.Add(Me.Label7)
        Me.GPBX.Controls.Add(Me.TxTPincode)
        Me.GPBX.Controls.Add(Me.Label5)
        Me.GPBX.Controls.Add(Me.TxTCity)
        Me.GPBX.Controls.Add(Me.Label4)
        Me.GPBX.Controls.Add(Me.TxTAddress2)
        Me.GPBX.Controls.Add(Me.Label3)
        Me.GPBX.Controls.Add(Me.CmbInitials)
        Me.GPBX.Controls.Add(Me.TxTAddress1)
        Me.GPBX.Controls.Add(Me.Label2)
        Me.GPBX.Controls.Add(Me.TxTAcName)
        Me.GPBX.Controls.Add(Me.Label1)
        Me.GPBX.Controls.Add(Me.TxTAcCode)
        Me.GPBX.Controls.Add(Me.lblAcCode)
        Me.GPBX.Controls.Add(Me.LST)
        Me.GPBX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GPBX.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GPBX.Location = New System.Drawing.Point(0, 24)
        Me.GPBX.Name = "GPBX"
        Me.GPBX.Size = New System.Drawing.Size(570, 499)
        Me.GPBX.TabIndex = 0
        '
        'TxTAmt
        '
        Me.TxTAmt.BackColor = System.Drawing.Color.White
        Me.TxTAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTAmt.Location = New System.Drawing.Point(120, 255)
        Me.TxTAmt.MaxLength = 15
        Me.TxTAmt.Name = "TxTAmt"
        Me.TxTAmt.Size = New System.Drawing.Size(104, 22)
        Me.TxTAmt.TabIndex = 23
        Me.TxTAmt.Text = ""
        Me.TxTAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTin
        '
        Me.TxtTin.BackColor = System.Drawing.Color.White
        Me.TxtTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DSet, "GLMast.TIN"))
        Me.TxtTin.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTin.Location = New System.Drawing.Point(120, 280)
        Me.TxtTin.MaxLength = 20
        Me.TxtTin.Name = "TxtTin"
        Me.TxtTin.Size = New System.Drawing.Size(352, 21)
        Me.TxtTin.TabIndex = 29
        Me.TxtTin.Text = ""
        '
        'DSet
        '
        Me.DSet.DataSetName = "DSet"
        Me.DSet.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(16, 280)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 16)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "&Tin :"
        '
        'CmbGroup
        '
        Me.CmbGroup.BackColor = System.Drawing.Color.White
        Me.CmbGroup.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DSet, "GLMast.IndCode"))
        Me.CmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGroup.ForeColor = System.Drawing.Color.Black
        Me.CmbGroup.Location = New System.Drawing.Point(120, 224)
        Me.CmbGroup.Name = "CmbGroup"
        Me.CmbGroup.Size = New System.Drawing.Size(352, 22)
        Me.CmbGroup.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(248, 256)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "&Type :"
        '
        'Credit
        '
        Me.Credit.ForeColor = System.Drawing.Color.Black
        Me.Credit.Location = New System.Drawing.Point(384, 256)
        Me.Credit.Name = "Credit"
        Me.Credit.Size = New System.Drawing.Size(64, 24)
        Me.Credit.TabIndex = 27
        Me.Credit.Text = "&Credit"
        '
        'Debit
        '
        Me.Debit.Checked = True
        Me.Debit.ForeColor = System.Drawing.Color.Black
        Me.Debit.Location = New System.Drawing.Point(312, 256)
        Me.Debit.Name = "Debit"
        Me.Debit.Size = New System.Drawing.Size(64, 24)
        Me.Debit.TabIndex = 26
        Me.Debit.TabStop = True
        Me.Debit.Text = "&Debit"
        '
        'TxTOpAmt
        '
        Me.TxTOpAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTOpAmt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DSet, "GLMast.Amount"))
        Me.TxTOpAmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTOpAmt.Location = New System.Drawing.Point(120, 255)
        Me.TxTOpAmt.Name = "TxTOpAmt"
        Me.TxTOpAmt.Size = New System.Drawing.Size(8, 21)
        Me.TxTOpAmt.TabIndex = 29
        Me.TxTOpAmt.Text = ""
        Me.TxTOpAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 255)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "&Op Amount :"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(16, 223)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 16)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "&Group :"
        '
        'TxTMob
        '
        Me.TxTMob.BackColor = System.Drawing.Color.White
        Me.TxTMob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTMob.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DSet, "GLMast.Mobile"))
        Me.TxTMob.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTMob.Location = New System.Drawing.Point(352, 191)
        Me.TxTMob.MaxLength = 10
        Me.TxTMob.Name = "TxTMob"
        Me.TxTMob.Size = New System.Drawing.Size(120, 21)
        Me.TxTMob.TabIndex = 20
        Me.TxTMob.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(248, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "&Mobile"
        '
        'TxTFax
        '
        Me.TxTFax.BackColor = System.Drawing.Color.White
        Me.TxTFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTFax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DSet, "GLMast.Fax"))
        Me.TxTFax.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTFax.Location = New System.Drawing.Point(120, 191)
        Me.TxTFax.MaxLength = 15
        Me.TxTFax.Name = "TxTFax"
        Me.TxTFax.Size = New System.Drawing.Size(120, 21)
        Me.TxTFax.TabIndex = 18
        Me.TxTFax.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(16, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "&Fax:"
        '
        'TxTPhResi
        '
        Me.TxTPhResi.BackColor = System.Drawing.Color.White
        Me.TxTPhResi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTPhResi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DSet, "GLMast.PhR"))
        Me.TxTPhResi.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTPhResi.Location = New System.Drawing.Point(352, 167)
        Me.TxTPhResi.MaxLength = 15
        Me.TxTPhResi.Name = "TxTPhResi"
        Me.TxTPhResi.Size = New System.Drawing.Size(120, 21)
        Me.TxTPhResi.TabIndex = 16
        Me.TxTPhResi.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(248, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Phone (&Resi) :"
        '
        'TxTPhOff
        '
        Me.TxTPhOff.BackColor = System.Drawing.Color.White
        Me.TxTPhOff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTPhOff.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DSet, "GLMast.PhO"))
        Me.TxTPhOff.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTPhOff.Location = New System.Drawing.Point(120, 167)
        Me.TxTPhOff.MaxLength = 15
        Me.TxTPhOff.Name = "TxTPhOff"
        Me.TxTPhOff.Size = New System.Drawing.Size(120, 21)
        Me.TxTPhOff.TabIndex = 14
        Me.TxTPhOff.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Phone(&Off) :"
        '
        'TxTPincode
        '
        Me.TxTPincode.BackColor = System.Drawing.Color.White
        Me.TxTPincode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTPincode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DSet, "GLMast.Pin"))
        Me.TxTPincode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTPincode.ForeColor = System.Drawing.Color.Black
        Me.TxTPincode.Location = New System.Drawing.Point(352, 143)
        Me.TxTPincode.MaxLength = 6
        Me.TxTPincode.Name = "TxTPincode"
        Me.TxTPincode.Size = New System.Drawing.Size(120, 21)
        Me.TxTPincode.TabIndex = 12
        Me.TxTPincode.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(248, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "&Pincode :"
        '
        'TxTCity
        '
        Me.TxTCity.BackColor = System.Drawing.Color.White
        Me.TxTCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DSet, "GLMast.City"))
        Me.TxTCity.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTCity.Location = New System.Drawing.Point(120, 143)
        Me.TxTCity.MaxLength = 10
        Me.TxTCity.Name = "TxTCity"
        Me.TxTCity.Size = New System.Drawing.Size(120, 21)
        Me.TxTCity.TabIndex = 10
        Me.TxTCity.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Ci&ty :"
        '
        'TxTAddress2
        '
        Me.TxTAddress2.BackColor = System.Drawing.Color.White
        Me.TxTAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTAddress2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DSet, "GLMast.Add2"))
        Me.TxTAddress2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTAddress2.Location = New System.Drawing.Point(120, 119)
        Me.TxTAddress2.MaxLength = 70
        Me.TxTAddress2.Name = "TxTAddress2"
        Me.TxTAddress2.Size = New System.Drawing.Size(352, 21)
        Me.TxTAddress2.TabIndex = 8
        Me.TxTAddress2.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Address2 :"
        '
        'CmbInitials
        '
        Me.CmbInitials.BackColor = System.Drawing.Color.White
        Me.CmbInitials.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DSet, "GLMast.GName"))
        Me.CmbInitials.ForeColor = System.Drawing.Color.Black
        Me.CmbInitials.Items.AddRange(New Object() {"", "Mr.", "Mrs.", "Miss.", "Smt.", "Shri.", "Sau."})
        Me.CmbInitials.Location = New System.Drawing.Point(120, 55)
        Me.CmbInitials.Name = "CmbInitials"
        Me.CmbInitials.Size = New System.Drawing.Size(72, 22)
        Me.CmbInitials.TabIndex = 3
        '
        'TxTAddress1
        '
        Me.TxTAddress1.BackColor = System.Drawing.Color.White
        Me.TxTAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTAddress1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DSet, "GLMast.Add1"))
        Me.TxTAddress1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTAddress1.Location = New System.Drawing.Point(120, 95)
        Me.TxTAddress1.MaxLength = 70
        Me.TxTAddress1.Name = "TxTAddress1"
        Me.TxTAddress1.Size = New System.Drawing.Size(352, 21)
        Me.TxTAddress1.TabIndex = 6
        Me.TxTAddress1.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Address1 :"
        '
        'TxTAcName
        '
        Me.TxTAcName.BackColor = System.Drawing.Color.White
        Me.TxTAcName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTAcName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DSet, "GLMast.Part"))
        Me.TxTAcName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTAcName.Location = New System.Drawing.Point(200, 55)
        Me.TxTAcName.MaxLength = 50
        Me.TxTAcName.Name = "TxTAcName"
        Me.TxTAcName.Size = New System.Drawing.Size(272, 21)
        Me.TxTAcName.TabIndex = 4
        Me.TxTAcName.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Account &Name :"
        '
        'TxTAcCode
        '
        Me.TxTAcCode.BackColor = System.Drawing.Color.White
        Me.TxTAcCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTAcCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DSet, "GLMast.GLcode"))
        Me.TxTAcCode.Enabled = False
        Me.TxTAcCode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTAcCode.Location = New System.Drawing.Point(120, 31)
        Me.TxTAcCode.Name = "TxTAcCode"
        Me.TxTAcCode.ReadOnly = True
        Me.TxTAcCode.Size = New System.Drawing.Size(72, 21)
        Me.TxTAcCode.TabIndex = 1
        Me.TxTAcCode.Text = ""
        Me.TxTAcCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAcCode
        '
        Me.lblAcCode.Location = New System.Drawing.Point(16, 31)
        Me.lblAcCode.Name = "lblAcCode"
        Me.lblAcCode.Size = New System.Drawing.Size(96, 16)
        Me.lblAcCode.TabIndex = 0
        Me.lblAcCode.Text = "Account &Code :"
        '
        'LST
        '
        Me.LST.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LST.Enabled = False
        Me.LST.ItemHeight = 14
        Me.LST.Location = New System.Drawing.Point(48, 280)
        Me.LST.Name = "LST"
        Me.LST.Size = New System.Drawing.Size(40, 14)
        Me.LST.TabIndex = 30
        Me.LST.TabStop = False
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
        Me.LblDisplay.Size = New System.Drawing.Size(662, 24)
        Me.LblDisplay.TabIndex = 67
        Me.LblDisplay.Text = "Account Master"
        Me.LblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.BPanel.Location = New System.Drawing.Point(570, 24)
        Me.BPanel.Name = "BPanel"
        Me.BPanel.Size = New System.Drawing.Size(92, 499)
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
        'OleDA
        '
        Me.OleDA.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDA.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDA.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDA.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GLMast", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Add1", "Add1"), New System.Data.Common.DataColumnMapping("Add2", "Add2"), New System.Data.Common.DataColumnMapping("Amount", "Amount"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Email", "Email"), New System.Data.Common.DataColumnMapping("Fax", "Fax"), New System.Data.Common.DataColumnMapping("GLcode", "GLcode"), New System.Data.Common.DataColumnMapping("GName", "GName"), New System.Data.Common.DataColumnMapping("IndCode", "IndCode"), New System.Data.Common.DataColumnMapping("Mobile", "Mobile"), New System.Data.Common.DataColumnMapping("PAN", "PAN"), New System.Data.Common.DataColumnMapping("Part", "Part"), New System.Data.Common.DataColumnMapping("PhO", "PhO"), New System.Data.Common.DataColumnMapping("PhR", "PhR"), New System.Data.Common.DataColumnMapping("Pin", "Pin"), New System.Data.Common.DataColumnMapping("Site", "Site"), New System.Data.Common.DataColumnMapping("TIN", "TIN"), New System.Data.Common.DataColumnMapping("UserID", "UserID")})})
        Me.OleDA.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM GLMast WHERE (GLcode = ?) AND (Add1 = ? OR ? IS NULL AND Add1 IS NULL" & _
        ") AND (Add2 = ? OR ? IS NULL AND Add2 IS NULL) AND (Amount = ? OR ? IS NULL AND " & _
        "Amount IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND (Email = ? OR ?" & _
        " IS NULL AND Email IS NULL) AND (Fax = ? OR ? IS NULL AND Fax IS NULL) AND (GNam" & _
        "e = ? OR ? IS NULL AND GName IS NULL) AND (IndCode = ? OR ? IS NULL AND IndCode " & _
        "IS NULL) AND (Mobile = ? OR ? IS NULL AND Mobile IS NULL) AND (PAN = ? OR ? IS N" & _
        "ULL AND PAN IS NULL) AND (Part = ? OR ? IS NULL AND Part IS NULL) AND (PhO = ? O" & _
        "R ? IS NULL AND PhO IS NULL) AND (PhR = ? OR ? IS NULL AND PhR IS NULL) AND (Pin" & _
        " = ? OR ? IS NULL AND Pin IS NULL) AND (Site = ? OR ? IS NULL AND Site IS NULL) " & _
        "AND (TIN = ? OR ? IS NULL AND TIN IS NULL) AND (UserID = ? OR ? IS NULL AND User" & _
        "ID IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleCon
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_GLcode", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GLcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Add1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Add1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Add11", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Add1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Add2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Add2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Add21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Add2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Amount", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Amount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Amount1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Amount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fax", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fax1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_GName", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_GName1", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IndCode", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IndCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IndCode1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IndCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Mobile", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mobile", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Mobile1", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mobile", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PAN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PAN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PAN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PAN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Part", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Part", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Part1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Part", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhR", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhR", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhR1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhR", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Pin", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pin", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Pin1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pin", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Site", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Site", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Site1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Site", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TIN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TIN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TIN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TIN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserID", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserID1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserID", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO GLMast(Add1, Add2, Amount, City, Email, Fax, GLcode, GName, IndCode, " & _
        "Mobile, PAN, Part, PhO, PhR, Pin, Site, TIN, UserID) VALUES (?, ?, ?, ?, ?, ?, ?" & _
        ", ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleCon
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Add1", System.Data.OleDb.OleDbType.VarWChar, 50, "Add1"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Add2", System.Data.OleDb.OleDbType.VarWChar, 50, "Add2"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Amount", System.Data.OleDb.OleDbType.Double, 0, "Amount"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 20, "City"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarWChar, 30, "Email"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 20, "Fax"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("GLcode", System.Data.OleDb.OleDbType.Integer, 0, "GLcode"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("GName", System.Data.OleDb.OleDbType.VarWChar, 6, "GName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("IndCode", System.Data.OleDb.OleDbType.VarWChar, 2, "IndCode"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Mobile", System.Data.OleDb.OleDbType.VarWChar, 12, "Mobile"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PAN", System.Data.OleDb.OleDbType.VarWChar, 50, "PAN"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Part", System.Data.OleDb.OleDbType.VarWChar, 50, "Part"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PhO", System.Data.OleDb.OleDbType.VarWChar, 20, "PhO"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PhR", System.Data.OleDb.OleDbType.VarWChar, 20, "PhR"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Pin", System.Data.OleDb.OleDbType.VarWChar, 10, "Pin"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Site", System.Data.OleDb.OleDbType.VarWChar, 30, "Site"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TIN", System.Data.OleDb.OleDbType.VarWChar, 50, "TIN"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserID", System.Data.OleDb.OleDbType.VarWChar, 3, "UserID"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Add1, Add2, Amount, City, Email, Fax, GLcode, GName, IndCode, Mobile, PAN," & _
        " Part, PhO, PhR, Pin, Site, TIN, UserID FROM GLMast"
        Me.OleDbSelectCommand1.Connection = Me.OleCon
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE GLMast SET Add1 = ?, Add2 = ?, Amount = ?, City = ?, Email = ?, Fax = ?, G" & _
        "Lcode = ?, GName = ?, IndCode = ?, Mobile = ?, PAN = ?, Part = ?, PhO = ?, PhR =" & _
        " ?, Pin = ?, Site = ?, TIN = ?, UserID = ? WHERE (GLcode = ?) AND (Add1 = ? OR ?" & _
        " IS NULL AND Add1 IS NULL) AND (Add2 = ? OR ? IS NULL AND Add2 IS NULL) AND (Amo" & _
        "unt = ? OR ? IS NULL AND Amount IS NULL) AND (City = ? OR ? IS NULL AND City IS " & _
        "NULL) AND (Email = ? OR ? IS NULL AND Email IS NULL) AND (Fax = ? OR ? IS NULL A" & _
        "ND Fax IS NULL) AND (GName = ? OR ? IS NULL AND GName IS NULL) AND (IndCode = ? " & _
        "OR ? IS NULL AND IndCode IS NULL) AND (Mobile = ? OR ? IS NULL AND Mobile IS NUL" & _
        "L) AND (PAN = ? OR ? IS NULL AND PAN IS NULL) AND (Part = ? OR ? IS NULL AND Par" & _
        "t IS NULL) AND (PhO = ? OR ? IS NULL AND PhO IS NULL) AND (PhR = ? OR ? IS NULL " & _
        "AND PhR IS NULL) AND (Pin = ? OR ? IS NULL AND Pin IS NULL) AND (Site = ? OR ? I" & _
        "S NULL AND Site IS NULL) AND (TIN = ? OR ? IS NULL AND TIN IS NULL) AND (UserID " & _
        "= ? OR ? IS NULL AND UserID IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleCon
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Add1", System.Data.OleDb.OleDbType.VarWChar, 50, "Add1"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Add2", System.Data.OleDb.OleDbType.VarWChar, 50, "Add2"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Amount", System.Data.OleDb.OleDbType.Double, 0, "Amount"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 20, "City"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarWChar, 30, "Email"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 20, "Fax"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("GLcode", System.Data.OleDb.OleDbType.Integer, 0, "GLcode"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("GName", System.Data.OleDb.OleDbType.VarWChar, 6, "GName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("IndCode", System.Data.OleDb.OleDbType.VarWChar, 2, "IndCode"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Mobile", System.Data.OleDb.OleDbType.VarWChar, 12, "Mobile"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PAN", System.Data.OleDb.OleDbType.VarWChar, 50, "PAN"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Part", System.Data.OleDb.OleDbType.VarWChar, 50, "Part"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PhO", System.Data.OleDb.OleDbType.VarWChar, 20, "PhO"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PhR", System.Data.OleDb.OleDbType.VarWChar, 20, "PhR"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Pin", System.Data.OleDb.OleDbType.VarWChar, 10, "Pin"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Site", System.Data.OleDb.OleDbType.VarWChar, 30, "Site"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TIN", System.Data.OleDb.OleDbType.VarWChar, 50, "TIN"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserID", System.Data.OleDb.OleDbType.VarWChar, 3, "UserID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_GLcode", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GLcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Add1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Add1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Add11", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Add1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Add2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Add2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Add21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Add2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Amount", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Amount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Amount1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Amount", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fax", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Fax1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_GName", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_GName1", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IndCode", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IndCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IndCode1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IndCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Mobile", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mobile", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Mobile1", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mobile", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PAN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PAN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PAN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PAN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Part", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Part", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Part1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Part", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhR", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhR", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhR1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhR", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Pin", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pin", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Pin1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Pin", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Site", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Site", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Site1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Site", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TIN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TIN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TIN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TIN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserID", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserID1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserID", System.Data.DataRowVersion.Original, Nothing))
        '
        'FrmAM
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(662, 523)
        Me.Controls.Add(Me.GPBX)
        Me.Controls.Add(Me.BPanel)
        Me.Controls.Add(Me.LblDisplay)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "FrmAM"
        Me.Text = "Account Master"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GPBX.ResumeLayout(False)
        CType(Me.DSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region
    Dim Opr As Operation
    Dim StrTempAcName As String
    Dim Ob() As String
    Private Sub FrmAM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OleCon.ConnectionString = ConStr
        OleCon.Open()
        DSet.Clear()
        OleDA.Fill(DSet)
        Dim Ds As New DataSet
        Dim Da As New OleDbDataAdapter("SELECT Part,IndCode,BsGroup From BsHead order by Part", OleCon)
        Da.Fill(Ds, "A")
        CmbGroup.DataSource = Ds
        CmbGroup.DisplayMember = "A.Part"
        CmbGroup.ValueMember = "A.IndCode"
        LST.DataSource = Ds
        LST.DisplayMember = "A.IndCode"
        LST.ValueMember = "A.BsGroup"
        OleCon.Close()
        Me.KeyPreview = True
        E_D(True)
        Me.DSet_PositionChanged()
        GPBX.Enabled = False
    End Sub
    Function GetMaxAcCode() As Integer
        Dim Cmd As New OleDbCommand
        Dim iAcCode As Integer
        Cmd.CommandText = "NewGLCode"
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.Connection = OleCon
        OleCon.Open()
        iAcCode = CType(Cmd.ExecuteScalar, Integer)
        OleCon.Close()
        Return iAcCode
    End Function
    Private Sub CmbInitials_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbInitials.GotFocus
        SendKeys.Send("{f4}")
    End Sub
    Private Sub CmbInitials_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbInitials.KeyPress
        If e.KeyChar = Chr(13) Then SendKeys.Send("{TAB}")
    End Sub
    Private Sub CmbGroup_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbGroup.GotFocus
        SendKeys.Send("{F4}")
    End Sub
    Private Sub CmbInitials_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbInitials.Validated
        If CmbInitials.FindStringExact(CmbInitials.Text) = -1 Then
            CmbInitials.Focus()
            Exit Sub
        End If
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
        Opr = Operation.Add
        Try
            'Clear out the current edits
            Me.BindingContext(DSet, "GLMast").EndCurrentEdit()
            Me.BindingContext(DSet, "GLMast").AddNew()
            TxTAcCode.Text = Format(GetMaxAcCode, "0000")
            GPBX.Enabled = True
            TxTAcName.Enabled = True
            CmbGroup.Enabled = True
            CmbInitials.Focus()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.DSet_PositionChanged()
    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.BindingContext(DSet, "GlMast").EndCurrentEdit()
        Close()
    End Sub

    Private Sub CmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSave.Click
        If TxTAcName.Text = "" Then
            MsgBox("Please Enter Accont Name")
            TxTAcName.Focus()
            Exit Sub
        End If
        If IsDBNull(CmbGroup.SelectedValue) = True Then
            MsgBox("Please Select Group")
            CmbGroup.Focus()
            Exit Sub
        End If
        If CmbGroup.SelectedIndex = -1 Then
            MsgBox("Please Select Group")
            CmbGroup.Focus()
            Exit Sub
        End If
        Try
            If Opr = ModMain.Operation.Add Or (Opr = ModMain.Operation.Edit And TxTAcName.Text <> StrTempAcName) Then
                Dim Con As New OleDbConnection(ConStr)
                Dim Cmd As New OleDbCommand
                Dim P As New OleDbParameter
                Dim StrAcName As String
                Cmd.CommandText = "checkAcName"
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Con
                P.ParameterName = "@AcName"
                P.DbType = DbType.String
                P.Direction = ParameterDirection.Input
                P.Value = TxTAcName.Text
                Cmd.Parameters.Add(P)
                If Con.State Then Con.Close()
                Con.Open()
                StrAcName = Cmd.ExecuteScalar
                If Not StrAcName Is Nothing Then
                    MsgBox("Can't Save Duplicate A/c Name")
                    TxTAcName.SelectAll()
                    TxTAcName.Focus()
                    Exit Sub
                End If
                Con.Close()
            End If
            If Debit.Checked = True Then
                TxTOpAmt.Text = Val(TxTAmt.Text)
            Else
                TxTOpAmt.Text = -1 * Val(TxTAmt.Text)
            End If
            'Attempt to update the datasource.
            Me.UpdateDataSet()
            InsertOpBalance()
            Me.DSet_PositionChanged()
            System.Windows.Forms.MessageBox.Show("Record Is Sucessfully Saved!!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            Opr = Operation.None
            E_D(True)
            GPBX.Enabled = False
        Catch eUpdate As System.Data.OleDb.OleDbException
            MsgBox("Please Select Group")
            CmbGroup.Focus()
            Exit Sub
        End Try
    End Sub
    Private Sub InsertOpBalance()
        Dim Cmd As New OleDbCommand
        Dim CmdDelete As OleDbCommand
        Try
            Cmd.CommandText = "INS_OPBAL"
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = OleCon
            Dim p As New OleDbParameter
            p.ParameterName = "@Vno"
            p.Direction = ParameterDirection.Input
            p.DbType = DbType.String
            p.Value = "OP" & Format(CInt(TxTAcCode.Text), "0000")
            Cmd.Parameters.Add(p)
            p = New OleDbParameter
            p.ParameterName = "@TDate"
            p.Direction = ParameterDirection.Input
            p.DbType = DbType.Date
            p.Value = DateAdd(DateInterval.Day, -1, FromDate)
            Cmd.Parameters.Add(p)
            p = New OleDbParameter
            p.ParameterName = "@Amt"
            p.Direction = ParameterDirection.Input
            p.DbType = DbType.Double
            p.Value = Val(TxTOpAmt.Text)
            Cmd.Parameters.Add(p)
            p = New OleDbParameter
            p.ParameterName = "@GlCode"
            p.Direction = ParameterDirection.Input
            p.DbType = DbType.Int16
            p.Value = CInt(TxTAcCode.Text)
            Cmd.Parameters.Add(p)
            p = New OleDbParameter
            p.ParameterName = "@UserID"
            p.Direction = ParameterDirection.Input
            p.DbType = DbType.String
            p.Value = imUser.GetUserID
            Cmd.Parameters.Add(p)
            OleCon.Open()
            CmdDelete = New OleDbCommand("DELETE * FROM GenGL WHERE GlCode=" & Val(TxTAcCode.Text) & " AND BOOK='OP'", OleCon)
            CmdDelete.ExecuteNonQuery()
            Cmd.ExecuteNonQuery()
        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            OleCon.Close()
        End Try
    End Sub
    Private Sub CmdCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        E_D(True)
        Me.BindingContext(DSet, "GLMast").CancelCurrentEdit()
        DSet.RejectChanges()
        Opr = Operation.None
        Me.DSet_PositionChanged()
        GPBX.Enabled = False
    End Sub
    Private Sub FrmAM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
                        Me.BindingContext(DSet, "GLMast").Position = 0
                        Me.DSet_PositionChanged()
                    Case ModMain.Navigation.MovePrevious
                        If Me.BindingContext(DSet, "GlMast").Position >= 0 Then
                            Me.BindingContext(DSet, "GLMast").Position = (Me.BindingContext(DSet, "GLMast").Position - 1)
                            Me.DSet_PositionChanged()
                        End If
                    Case ModMain.Navigation.MoveNext
                        Me.BindingContext(DSet, "GLMast").Position = (Me.BindingContext(DSet, "GLMast").Position + 1)
                        Me.DSet_PositionChanged()
                    Case ModMain.Navigation.MoveLast
                        Me.BindingContext(DSet, "GLMast").Position = (Me.DSet.Tables("GLMast").Rows.Count - 1)
                        Me.DSet_PositionChanged()
                End Select
        End Select
    End Sub
    Private Sub DSet_PositionChanged()
        Me.Text = "Account Master : " & (((Me.BindingContext(DSet, "GLMast").Position + 1).ToString + " of  ") _
                    + Me.BindingContext(DSet, "GLMast").Count.ToString)
        TxTAmt.Text = Abs(Val(TxTOpAmt.Text))
        If Val(TxTOpAmt.Text) < 0 Then
            Credit.Checked = True
            Debit.Checked = False
        Else
            Debit.Checked = True
            Credit.Checked = False
        End If
    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As DSet = New DSet
        'Stop any current edits.
        Me.BindingContext(DSet, "GLMast").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(DSet.GetChanges, DSet)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                DSet.Merge(objDataSetChanges)
                DSet.AcceptChanges()
            Catch eUpdate As System.Exception
                'Add your error handling code here.

                Throw eUpdate
            End Try
            'Add your code to check the returned dataset for any errors that may have been
            'pushed into the row object's error.
        End If
    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As DSet)
        Try
            'The data source only needs to be updated if there are changes pending.
            If (Not (ChangedRows) Is Nothing) Then
                'Open the connection.
                Me.OleCon.Open()
                'Attempt to update the data source.
                OleDA.Update(ChangedRows)
            End If
        Catch updateException As System.Exception
            'Add your error handling code here.
            Throw updateException
        Finally
            'Close the connection whether or not the exception was thrown.
            Me.OleCon.Close()
        End Try
    End Sub
    Private Sub CmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDelete.Click
        If Val(TxTAcCode.Text) = 1 Then
            MsgBox("Can't Delete Cash Account", MsgBoxStyle.Critical, "Can't Delete")
            Exit Sub
        End If
        If System.Windows.Forms.MessageBox.Show("Are You Sure Want To Delete This Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.No Then
            Exit Sub
        End If
        If Val(TxTAmt.Text) <> 0 Then
            MsgBox("Opening Amount Is Not Zero ! ! !", MsgBoxStyle.Critical, "Can't Delete")
            Exit Sub
        End If
        If CheckTrans(Val(TxTAcCode.Text)) = True Then
            MsgBox("Transaction Exist For This Account" & ControlChars.CrLf & "You First Delete Transaction That Are Exist For This Account", MsgBoxStyle.Critical, "Can't Delete")
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        If (Me.BindingContext(DSet, "GLMast").Count > 0) Then
            Me.BindingContext(DSet, "GLMast").RemoveAt(Me.BindingContext(DSet, "GLMast").Position)
            Me.DSet_PositionChanged()
            Me.UpdateDataSet()
        End If
        Me.Cursor = Cursors.Default
        MsgBox("The Record Deleted Sucessfully", MsgBoxStyle.Information, "Account Master")
    End Sub
    Private Function CheckTrans(ByVal iAcCode As Long) As Boolean
        Dim Cmd As New OleDbCommand("SELECT Vno From GenGl Where GlCode=" & iAcCode & " AND BOOK <> 'OP'", OleCon)
        If OleCon.State = ConnectionState.Open Then OleCon.Close()
        OleCon.Open()
        Dim dr As OleDbDataReader = Cmd.ExecuteReader
        If dr.HasRows = True Then
            dr.Close()
            OleCon.Close()
            Return True
        End If
        dr.Close()
        OleCon.Close()
        Return False
    End Function
    Private Sub CmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEdit.Click
        E_D(False)
        Opr = Operation.Edit
        GPBX.Enabled = True
        StrTempAcName = TxTAcName.Text
        CmbInitials.Focus()
        If Val(TxTAcCode.Text) = 1 Then
            TxTAcName.Enabled = False
            CmbGroup.Enabled = False
        Else
            TxTAcName.Enabled = True
            CmbGroup.Enabled = True
        End If
    End Sub
    Private Sub TxTPincode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxTPincode.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            If e.KeyChar = Chr(8) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        Opr = Operation.Search
        CallSearch()
    End Sub
    Private Sub CallSearch()
        Dim strSQL As String
        strSQL = "SELECT G.GlCode as AcCode,G.Part as AcHead,B.Part as Gr,G.Amount as Amt,G.City,G.pin,G.Tin From GlMast G,BsHead B Where B.IndCode=G.IndCode And G.Part &  B.Part &  G.Amount & G.City & G.Pin & G.Tin like"
        Dim NewSearch As New FrmSearch(CallFrom.AccountMaster, strSQL)
        NewSearch.MdiParent = Me.MdiParent
        NewSearch.Show()
    End Sub
    Private Sub TxTAmt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxTAmt.KeyPress
        'If Char.IsDigit(e.KeyChar) = False Then
        '    If e.KeyChar = Chr(8) Or e.KeyChar = "." Then
        '        If InStr(TxTAmt.Text, ".") > 0 Then
        '            e.Handled = True
        '        Else
        '            e.Handled = False
        '        End If
        '    Else
        '        e.Handled = True
        '    End If
        'End If
        FnAmount(e, TxTAmt.Text)
    End Sub

    Private Sub FrmAM_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If Opr = Operation.Search Then
            Opr = Operation.None
            Dim Dv As DataView = New DataView(DSet.GLMast, "", "GlCode", DataViewRowState.CurrentRows)
            Dim RowIndex As Integer = Dv.Find(Val(StrSearchResult))
            If RowIndex <> -1 Then
                Me.BindingContext(DSet, "GLMast").Position = RowIndex
                Me.KeyPreview = True
                TxTAmt.Text = Abs(Val(TxTOpAmt.Text))
            End If
        End If
    End Sub
    Private Sub CmbGroup_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbGroup.TextChanged
        Dim z As Int16 = CmbGroup.Text.Length
        CmbGroup.SelectedIndex = CmbGroup.FindString(CmbGroup.Text)
        CmbGroup.SelectedIndex = CmbGroup.SelectedIndex
        If CmbGroup.SelectedIndex > -1 Then
            CmbGroup.Text = CmbGroup.GetItemText(CmbGroup.SelectedItem)
            If CmbGroup.Text.Length >= z Then
                CmbGroup.Select(z, CmbGroup.Text.Length - z)
            End If
        End If
    End Sub
    Private Sub TxTPhOff_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxTPhOff.KeyPress
        If Char.IsDigit(e.KeyChar) = False Then
            If e.KeyChar = Chr(8) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxTCity_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxTCity.LostFocus
        TxTCity.Text = TxTCity.Text.ToUpper
    End Sub

    Private Sub TxTAddress2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxTAddress2.LostFocus
        TxTAddress2.Text = TxTAddress2.Text.ToUpper
    End Sub

    Private Sub TxTAddress1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxTAddress1.LostFocus
        TxTAddress1.Text = TxTAddress1.Text.ToUpper
    End Sub

    Private Sub TxTAcName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxTAcName.LostFocus
        TxTAcName.Text = TxTAcName.Text.ToUpper
    End Sub
    Private Sub TxTPhResi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxTPhResi.KeyPress
        If Char.IsDigit(e.KeyChar) = False Then
            If e.KeyChar = Chr(8) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxTFax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxTFax.TextChanged

    End Sub

    Private Sub TxTFax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxTFax.KeyPress
        If Char.IsDigit(e.KeyChar) = False Then
            If e.KeyChar = Chr(8) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub TxTMob_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxTMob.KeyPress
        If Char.IsDigit(e.KeyChar) = False Then
            If e.KeyChar = Chr(8) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub TxTAmt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxTAmt.LostFocus
        TxTAmt.Text = Round(Val(TxTAmt.Text), 2)
    End Sub

    Private Sub TxTAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxTAmt.TextChanged

    End Sub

    Private Sub CmbGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbGroup.SelectedIndexChanged
        If Opr = ModMain.Operation.Add Or Opr = ModMain.Operation.Edit Then

        End If
    End Sub

    Private Sub LST_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LST.SelectedIndexChanged
        If Opr = ModMain.Operation.Add Or Opr = ModMain.Operation.Edit Then
            Select Case LST.SelectedValue
                Case "AS"
                    Debit.Checked = True
                Case "LB"
                    Credit.Checked = True
            End Select
        End If
    End Sub

    Private Sub BPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles BPanel.Paint

    End Sub
End Class
