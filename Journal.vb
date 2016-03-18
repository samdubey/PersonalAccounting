Imports System.Data.OleDb
Imports Microsoft.VisualBasic.Compatibility
Imports System.Math
Public Class Journal
    Inherits System.Windows.Forms.Form
    'ADO.NET
    Dim OleDbcn As OleDbConnection
    Dim OleDA As OleDbDataAdapter
    Dim Ds As New DataSet
    Dim Dst As New DataSet
    Dim DtRow As Long
    Dim DT As DataTable
    Dim Opr As Operation = Operation.None
    Dim StrVno As String
    Dim CallFromAcExt As Boolean
    Dim Flag As Boolean = False
    Private Enum Operation
        None = 0
        Add = 1
        Edit = 2
        Search = 3
    End Enum
    Private Enum Column
        SrNo = 0
        AChead = 1
        Debit = 2
        Credit = 3
        Narration = 4
        GlCode = 5
    End Enum
    Private Sub FillNo()
        Dim i As Int16
        For i = 1 To FGrid.Rows - 1
            FGrid.set_TextMatrix(i, Column.SrNo, i)
        Next
    End Sub
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub
    Public Sub New(ByVal iStrVno As String, ByVal StrVtype As String)
        MyBase.New()
        InitializeComponent()
        StrVno = iStrVno
        Me.Tag = StrVtype
        CallFromAcExt = True
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
    Friend WithEvents LblDisplay As System.Windows.Forms.Label
    Friend WithEvents IDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxTVNo As System.Windows.Forms.TextBox
    Friend WithEvents TxT As System.Windows.Forms.TextBox
    Friend WithEvents FGrid As AxMSFlexGridLib.AxMSFlexGrid
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents CmdDelete As System.Windows.Forms.Button
    Friend WithEvents CmdSearch As System.Windows.Forms.Button
    Friend WithEvents CmdEdit As System.Windows.Forms.Button
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents CmdHelp As System.Windows.Forms.Button
    Friend WithEvents BPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxTRef As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LBLCr As System.Windows.Forms.Label
    Friend WithEvents LBLDr As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LPart As System.Windows.Forms.ListBox
    Friend WithEvents CmdCopy As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Journal))
        Me.LblDisplay = New System.Windows.Forms.Label
        Me.IDate = New System.Windows.Forms.DateTimePicker
        Me.lblDay = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxTRef = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxTVNo = New System.Windows.Forms.TextBox
        Me.TxT = New System.Windows.Forms.TextBox
        Me.FGrid = New AxMSFlexGridLib.AxMSFlexGrid
        Me.BPanel = New System.Windows.Forms.Panel
        Me.CmdCopy = New System.Windows.Forms.Button
        Me.CmdHelp = New System.Windows.Forms.Button
        Me.CmdCancel = New System.Windows.Forms.Button
        Me.CmdExit = New System.Windows.Forms.Button
        Me.CmdSave = New System.Windows.Forms.Button
        Me.CmdEdit = New System.Windows.Forms.Button
        Me.CmdSearch = New System.Windows.Forms.Button
        Me.CmdDelete = New System.Windows.Forms.Button
        Me.CmdAdd = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LBLCr = New System.Windows.Forms.Label
        Me.LBLDr = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LPart = New System.Windows.Forms.ListBox
        Me.Panel1.SuspendLayout()
        CType(Me.FGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblDisplay
        '
        Me.LblDisplay.AccessibleDescription = resources.GetString("LblDisplay.AccessibleDescription")
        Me.LblDisplay.AccessibleName = resources.GetString("LblDisplay.AccessibleName")
        Me.LblDisplay.Anchor = CType(resources.GetObject("LblDisplay.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.LblDisplay.AutoSize = CType(resources.GetObject("LblDisplay.AutoSize"), Boolean)
        Me.LblDisplay.BackColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.LblDisplay.Dock = CType(resources.GetObject("LblDisplay.Dock"), System.Windows.Forms.DockStyle)
        Me.LblDisplay.Enabled = CType(resources.GetObject("LblDisplay.Enabled"), Boolean)
        Me.LblDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblDisplay.Font = CType(resources.GetObject("LblDisplay.Font"), System.Drawing.Font)
        Me.LblDisplay.ForeColor = System.Drawing.Color.White
        Me.LblDisplay.Image = CType(resources.GetObject("LblDisplay.Image"), System.Drawing.Image)
        Me.LblDisplay.ImageAlign = CType(resources.GetObject("LblDisplay.ImageAlign"), System.Drawing.ContentAlignment)
        Me.LblDisplay.ImageIndex = CType(resources.GetObject("LblDisplay.ImageIndex"), Integer)
        Me.LblDisplay.ImeMode = CType(resources.GetObject("LblDisplay.ImeMode"), System.Windows.Forms.ImeMode)
        Me.LblDisplay.Location = CType(resources.GetObject("LblDisplay.Location"), System.Drawing.Point)
        Me.LblDisplay.Name = "LblDisplay"
        Me.LblDisplay.RightToLeft = CType(resources.GetObject("LblDisplay.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.LblDisplay.Size = CType(resources.GetObject("LblDisplay.Size"), System.Drawing.Size)
        Me.LblDisplay.TabIndex = CType(resources.GetObject("LblDisplay.TabIndex"), Integer)
        Me.LblDisplay.Text = resources.GetString("LblDisplay.Text")
        Me.LblDisplay.TextAlign = CType(resources.GetObject("LblDisplay.TextAlign"), System.Drawing.ContentAlignment)
        Me.LblDisplay.Visible = CType(resources.GetObject("LblDisplay.Visible"), Boolean)
        '
        'IDate
        '
        Me.IDate.AccessibleDescription = resources.GetString("IDate.AccessibleDescription")
        Me.IDate.AccessibleName = resources.GetString("IDate.AccessibleName")
        Me.IDate.Anchor = CType(resources.GetObject("IDate.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.IDate.BackgroundImage = CType(resources.GetObject("IDate.BackgroundImage"), System.Drawing.Image)
        Me.IDate.CalendarFont = CType(resources.GetObject("IDate.CalendarFont"), System.Drawing.Font)
        Me.IDate.CustomFormat = "dd/MM/yyyy"
        Me.IDate.Dock = CType(resources.GetObject("IDate.Dock"), System.Windows.Forms.DockStyle)
        Me.IDate.DropDownAlign = CType(resources.GetObject("IDate.DropDownAlign"), System.Windows.Forms.LeftRightAlignment)
        Me.IDate.Enabled = CType(resources.GetObject("IDate.Enabled"), Boolean)
        Me.IDate.Font = CType(resources.GetObject("IDate.Font"), System.Drawing.Font)
        Me.IDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.IDate.ImeMode = CType(resources.GetObject("IDate.ImeMode"), System.Windows.Forms.ImeMode)
        Me.IDate.Location = CType(resources.GetObject("IDate.Location"), System.Drawing.Point)
        Me.IDate.Name = "IDate"
        Me.IDate.RightToLeft = CType(resources.GetObject("IDate.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.IDate.Size = CType(resources.GetObject("IDate.Size"), System.Drawing.Size)
        Me.IDate.TabIndex = CType(resources.GetObject("IDate.TabIndex"), Integer)
        Me.IDate.Value = New Date(2006, 5, 18, 10, 0, 43, 453)
        Me.IDate.Visible = CType(resources.GetObject("IDate.Visible"), Boolean)
        '
        'lblDay
        '
        Me.lblDay.AccessibleDescription = resources.GetString("lblDay.AccessibleDescription")
        Me.lblDay.AccessibleName = resources.GetString("lblDay.AccessibleName")
        Me.lblDay.Anchor = CType(resources.GetObject("lblDay.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblDay.AutoSize = CType(resources.GetObject("lblDay.AutoSize"), Boolean)
        Me.lblDay.Dock = CType(resources.GetObject("lblDay.Dock"), System.Windows.Forms.DockStyle)
        Me.lblDay.Enabled = CType(resources.GetObject("lblDay.Enabled"), Boolean)
        Me.lblDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDay.Font = CType(resources.GetObject("lblDay.Font"), System.Drawing.Font)
        Me.lblDay.Image = CType(resources.GetObject("lblDay.Image"), System.Drawing.Image)
        Me.lblDay.ImageAlign = CType(resources.GetObject("lblDay.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblDay.ImageIndex = CType(resources.GetObject("lblDay.ImageIndex"), Integer)
        Me.lblDay.ImeMode = CType(resources.GetObject("lblDay.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblDay.Location = CType(resources.GetObject("lblDay.Location"), System.Drawing.Point)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.RightToLeft = CType(resources.GetObject("lblDay.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblDay.Size = CType(resources.GetObject("lblDay.Size"), System.Drawing.Size)
        Me.lblDay.TabIndex = CType(resources.GetObject("lblDay.TabIndex"), Integer)
        Me.lblDay.Text = resources.GetString("lblDay.Text")
        Me.lblDay.TextAlign = CType(resources.GetObject("lblDay.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblDay.Visible = CType(resources.GetObject("lblDay.Visible"), Boolean)
        '
        'Panel1
        '
        Me.Panel1.AccessibleDescription = resources.GetString("Panel1.AccessibleDescription")
        Me.Panel1.AccessibleName = resources.GetString("Panel1.AccessibleName")
        Me.Panel1.Anchor = CType(resources.GetObject("Panel1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = CType(resources.GetObject("Panel1.AutoScroll"), Boolean)
        Me.Panel1.AutoScrollMargin = CType(resources.GetObject("Panel1.AutoScrollMargin"), System.Drawing.Size)
        Me.Panel1.AutoScrollMinSize = CType(resources.GetObject("Panel1.AutoScrollMinSize"), System.Drawing.Size)
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxTRef)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxTVNo)
        Me.Panel1.Controls.Add(Me.IDate)
        Me.Panel1.Controls.Add(Me.lblDay)
        Me.Panel1.Dock = CType(resources.GetObject("Panel1.Dock"), System.Windows.Forms.DockStyle)
        Me.Panel1.Enabled = CType(resources.GetObject("Panel1.Enabled"), Boolean)
        Me.Panel1.Font = CType(resources.GetObject("Panel1.Font"), System.Drawing.Font)
        Me.Panel1.ImeMode = CType(resources.GetObject("Panel1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Panel1.Location = CType(resources.GetObject("Panel1.Location"), System.Drawing.Point)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = CType(resources.GetObject("Panel1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Panel1.Size = CType(resources.GetObject("Panel1.Size"), System.Drawing.Size)
        Me.Panel1.TabIndex = CType(resources.GetObject("Panel1.TabIndex"), Integer)
        Me.Panel1.Text = resources.GetString("Panel1.Text")
        Me.Panel1.Visible = CType(resources.GetObject("Panel1.Visible"), Boolean)
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = resources.GetString("Label1.AccessibleDescription")
        Me.Label1.AccessibleName = resources.GetString("Label1.AccessibleName")
        Me.Label1.Anchor = CType(resources.GetObject("Label1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = CType(resources.GetObject("Label1.AutoSize"), Boolean)
        Me.Label1.Dock = CType(resources.GetObject("Label1.Dock"), System.Windows.Forms.DockStyle)
        Me.Label1.Enabled = CType(resources.GetObject("Label1.Enabled"), Boolean)
        Me.Label1.Font = CType(resources.GetObject("Label1.Font"), System.Drawing.Font)
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = CType(resources.GetObject("Label1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label1.ImageIndex = CType(resources.GetObject("Label1.ImageIndex"), Integer)
        Me.Label1.ImeMode = CType(resources.GetObject("Label1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label1.Location = CType(resources.GetObject("Label1.Location"), System.Drawing.Point)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = CType(resources.GetObject("Label1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label1.Size = CType(resources.GetObject("Label1.Size"), System.Drawing.Size)
        Me.Label1.TabIndex = CType(resources.GetObject("Label1.TabIndex"), Integer)
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = CType(resources.GetObject("Label1.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label1.Visible = CType(resources.GetObject("Label1.Visible"), Boolean)
        '
        'TxTRef
        '
        Me.TxTRef.AccessibleDescription = resources.GetString("TxTRef.AccessibleDescription")
        Me.TxTRef.AccessibleName = resources.GetString("TxTRef.AccessibleName")
        Me.TxTRef.Anchor = CType(resources.GetObject("TxTRef.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TxTRef.AutoSize = CType(resources.GetObject("TxTRef.AutoSize"), Boolean)
        Me.TxTRef.BackColor = System.Drawing.Color.White
        Me.TxTRef.BackgroundImage = CType(resources.GetObject("TxTRef.BackgroundImage"), System.Drawing.Image)
        Me.TxTRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTRef.Dock = CType(resources.GetObject("TxTRef.Dock"), System.Windows.Forms.DockStyle)
        Me.TxTRef.Enabled = CType(resources.GetObject("TxTRef.Enabled"), Boolean)
        Me.TxTRef.Font = CType(resources.GetObject("TxTRef.Font"), System.Drawing.Font)
        Me.TxTRef.ImeMode = CType(resources.GetObject("TxTRef.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TxTRef.Location = CType(resources.GetObject("TxTRef.Location"), System.Drawing.Point)
        Me.TxTRef.MaxLength = CType(resources.GetObject("TxTRef.MaxLength"), Integer)
        Me.TxTRef.Multiline = CType(resources.GetObject("TxTRef.Multiline"), Boolean)
        Me.TxTRef.Name = "TxTRef"
        Me.TxTRef.PasswordChar = CType(resources.GetObject("TxTRef.PasswordChar"), Char)
        Me.TxTRef.RightToLeft = CType(resources.GetObject("TxTRef.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TxTRef.ScrollBars = CType(resources.GetObject("TxTRef.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.TxTRef.Size = CType(resources.GetObject("TxTRef.Size"), System.Drawing.Size)
        Me.TxTRef.TabIndex = CType(resources.GetObject("TxTRef.TabIndex"), Integer)
        Me.TxTRef.TabStop = False
        Me.TxTRef.Text = resources.GetString("TxTRef.Text")
        Me.TxTRef.TextAlign = CType(resources.GetObject("TxTRef.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.TxTRef.Visible = CType(resources.GetObject("TxTRef.Visible"), Boolean)
        Me.TxTRef.WordWrap = CType(resources.GetObject("TxTRef.WordWrap"), Boolean)
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = resources.GetString("Label2.AccessibleDescription")
        Me.Label2.AccessibleName = resources.GetString("Label2.AccessibleName")
        Me.Label2.Anchor = CType(resources.GetObject("Label2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = CType(resources.GetObject("Label2.AutoSize"), Boolean)
        Me.Label2.Dock = CType(resources.GetObject("Label2.Dock"), System.Windows.Forms.DockStyle)
        Me.Label2.Enabled = CType(resources.GetObject("Label2.Enabled"), Boolean)
        Me.Label2.Font = CType(resources.GetObject("Label2.Font"), System.Drawing.Font)
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = CType(resources.GetObject("Label2.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label2.ImageIndex = CType(resources.GetObject("Label2.ImageIndex"), Integer)
        Me.Label2.ImeMode = CType(resources.GetObject("Label2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label2.Location = CType(resources.GetObject("Label2.Location"), System.Drawing.Point)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = CType(resources.GetObject("Label2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label2.Size = CType(resources.GetObject("Label2.Size"), System.Drawing.Size)
        Me.Label2.TabIndex = CType(resources.GetObject("Label2.TabIndex"), Integer)
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = CType(resources.GetObject("Label2.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label2.Visible = CType(resources.GetObject("Label2.Visible"), Boolean)
        '
        'TxTVNo
        '
        Me.TxTVNo.AccessibleDescription = resources.GetString("TxTVNo.AccessibleDescription")
        Me.TxTVNo.AccessibleName = resources.GetString("TxTVNo.AccessibleName")
        Me.TxTVNo.Anchor = CType(resources.GetObject("TxTVNo.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TxTVNo.AutoSize = CType(resources.GetObject("TxTVNo.AutoSize"), Boolean)
        Me.TxTVNo.BackColor = System.Drawing.Color.White
        Me.TxTVNo.BackgroundImage = CType(resources.GetObject("TxTVNo.BackgroundImage"), System.Drawing.Image)
        Me.TxTVNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTVNo.Dock = CType(resources.GetObject("TxTVNo.Dock"), System.Windows.Forms.DockStyle)
        Me.TxTVNo.Enabled = CType(resources.GetObject("TxTVNo.Enabled"), Boolean)
        Me.TxTVNo.Font = CType(resources.GetObject("TxTVNo.Font"), System.Drawing.Font)
        Me.TxTVNo.ImeMode = CType(resources.GetObject("TxTVNo.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TxTVNo.Location = CType(resources.GetObject("TxTVNo.Location"), System.Drawing.Point)
        Me.TxTVNo.MaxLength = CType(resources.GetObject("TxTVNo.MaxLength"), Integer)
        Me.TxTVNo.Multiline = CType(resources.GetObject("TxTVNo.Multiline"), Boolean)
        Me.TxTVNo.Name = "TxTVNo"
        Me.TxTVNo.PasswordChar = CType(resources.GetObject("TxTVNo.PasswordChar"), Char)
        Me.TxTVNo.RightToLeft = CType(resources.GetObject("TxTVNo.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TxTVNo.ScrollBars = CType(resources.GetObject("TxTVNo.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.TxTVNo.Size = CType(resources.GetObject("TxTVNo.Size"), System.Drawing.Size)
        Me.TxTVNo.TabIndex = CType(resources.GetObject("TxTVNo.TabIndex"), Integer)
        Me.TxTVNo.TabStop = False
        Me.TxTVNo.Text = resources.GetString("TxTVNo.Text")
        Me.TxTVNo.TextAlign = CType(resources.GetObject("TxTVNo.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.TxTVNo.Visible = CType(resources.GetObject("TxTVNo.Visible"), Boolean)
        Me.TxTVNo.WordWrap = CType(resources.GetObject("TxTVNo.WordWrap"), Boolean)
        '
        'TxT
        '
        Me.TxT.AcceptsReturn = True
        Me.TxT.AcceptsTab = True
        Me.TxT.AccessibleDescription = resources.GetString("TxT.AccessibleDescription")
        Me.TxT.AccessibleName = resources.GetString("TxT.AccessibleName")
        Me.TxT.Anchor = CType(resources.GetObject("TxT.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TxT.AutoSize = CType(resources.GetObject("TxT.AutoSize"), Boolean)
        Me.TxT.BackColor = System.Drawing.Color.LemonChiffon
        Me.TxT.BackgroundImage = CType(resources.GetObject("TxT.BackgroundImage"), System.Drawing.Image)
        Me.TxT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxT.Dock = CType(resources.GetObject("TxT.Dock"), System.Windows.Forms.DockStyle)
        Me.TxT.Enabled = CType(resources.GetObject("TxT.Enabled"), Boolean)
        Me.TxT.Font = CType(resources.GetObject("TxT.Font"), System.Drawing.Font)
        Me.TxT.ImeMode = CType(resources.GetObject("TxT.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TxT.Location = CType(resources.GetObject("TxT.Location"), System.Drawing.Point)
        Me.TxT.MaxLength = CType(resources.GetObject("TxT.MaxLength"), Integer)
        Me.TxT.Multiline = CType(resources.GetObject("TxT.Multiline"), Boolean)
        Me.TxT.Name = "TxT"
        Me.TxT.PasswordChar = CType(resources.GetObject("TxT.PasswordChar"), Char)
        Me.TxT.RightToLeft = CType(resources.GetObject("TxT.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TxT.ScrollBars = CType(resources.GetObject("TxT.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.TxT.Size = CType(resources.GetObject("TxT.Size"), System.Drawing.Size)
        Me.TxT.TabIndex = CType(resources.GetObject("TxT.TabIndex"), Integer)
        Me.TxT.Text = resources.GetString("TxT.Text")
        Me.TxT.TextAlign = CType(resources.GetObject("TxT.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.TxT.Visible = CType(resources.GetObject("TxT.Visible"), Boolean)
        Me.TxT.WordWrap = CType(resources.GetObject("TxT.WordWrap"), Boolean)
        '
        'FGrid
        '
        Me.FGrid.AccessibleDescription = resources.GetString("FGrid.AccessibleDescription")
        Me.FGrid.AccessibleName = resources.GetString("FGrid.AccessibleName")
        Me.FGrid.Anchor = CType(resources.GetObject("FGrid.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.FGrid.BackgroundImage = CType(resources.GetObject("FGrid.BackgroundImage"), System.Drawing.Image)
        Me.FGrid.ContainingControl = Me
        Me.FGrid.Dock = CType(resources.GetObject("FGrid.Dock"), System.Windows.Forms.DockStyle)
        Me.FGrid.ImeMode = CType(resources.GetObject("FGrid.ImeMode"), System.Windows.Forms.ImeMode)
        Me.FGrid.Location = CType(resources.GetObject("FGrid.Location"), System.Drawing.Point)
        Me.FGrid.Name = "FGrid"
        Me.FGrid.OcxState = CType(resources.GetObject("FGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FGrid.Size = CType(resources.GetObject("FGrid.Size"), System.Drawing.Size)
        Me.FGrid.TabIndex = CType(resources.GetObject("FGrid.TabIndex"), Integer)
        Me.FGrid.Visible = CType(resources.GetObject("FGrid.Visible"), Boolean)
        '
        'BPanel
        '
        Me.BPanel.AccessibleDescription = resources.GetString("BPanel.AccessibleDescription")
        Me.BPanel.AccessibleName = resources.GetString("BPanel.AccessibleName")
        Me.BPanel.Anchor = CType(resources.GetObject("BPanel.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.BPanel.AutoScroll = CType(resources.GetObject("BPanel.AutoScroll"), Boolean)
        Me.BPanel.AutoScrollMargin = CType(resources.GetObject("BPanel.AutoScrollMargin"), System.Drawing.Size)
        Me.BPanel.AutoScrollMinSize = CType(resources.GetObject("BPanel.AutoScrollMinSize"), System.Drawing.Size)
        Me.BPanel.BackColor = System.Drawing.Color.Ivory
        Me.BPanel.BackgroundImage = CType(resources.GetObject("BPanel.BackgroundImage"), System.Drawing.Image)
        Me.BPanel.Controls.Add(Me.CmdCopy)
        Me.BPanel.Controls.Add(Me.CmdHelp)
        Me.BPanel.Controls.Add(Me.CmdCancel)
        Me.BPanel.Controls.Add(Me.CmdExit)
        Me.BPanel.Controls.Add(Me.CmdSave)
        Me.BPanel.Controls.Add(Me.CmdEdit)
        Me.BPanel.Controls.Add(Me.CmdSearch)
        Me.BPanel.Controls.Add(Me.CmdDelete)
        Me.BPanel.Controls.Add(Me.CmdAdd)
        Me.BPanel.Dock = CType(resources.GetObject("BPanel.Dock"), System.Windows.Forms.DockStyle)
        Me.BPanel.Enabled = CType(resources.GetObject("BPanel.Enabled"), Boolean)
        Me.BPanel.Font = CType(resources.GetObject("BPanel.Font"), System.Drawing.Font)
        Me.BPanel.ImeMode = CType(resources.GetObject("BPanel.ImeMode"), System.Windows.Forms.ImeMode)
        Me.BPanel.Location = CType(resources.GetObject("BPanel.Location"), System.Drawing.Point)
        Me.BPanel.Name = "BPanel"
        Me.BPanel.RightToLeft = CType(resources.GetObject("BPanel.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.BPanel.Size = CType(resources.GetObject("BPanel.Size"), System.Drawing.Size)
        Me.BPanel.TabIndex = CType(resources.GetObject("BPanel.TabIndex"), Integer)
        Me.BPanel.Text = resources.GetString("BPanel.Text")
        Me.BPanel.Visible = CType(resources.GetObject("BPanel.Visible"), Boolean)
        '
        'CmdCopy
        '
        Me.CmdCopy.AccessibleDescription = resources.GetString("CmdCopy.AccessibleDescription")
        Me.CmdCopy.AccessibleName = resources.GetString("CmdCopy.AccessibleName")
        Me.CmdCopy.Anchor = CType(resources.GetObject("CmdCopy.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.CmdCopy.BackgroundImage = CType(resources.GetObject("CmdCopy.BackgroundImage"), System.Drawing.Image)
        Me.CmdCopy.Dock = CType(resources.GetObject("CmdCopy.Dock"), System.Windows.Forms.DockStyle)
        Me.CmdCopy.Enabled = CType(resources.GetObject("CmdCopy.Enabled"), Boolean)
        Me.CmdCopy.FlatStyle = CType(resources.GetObject("CmdCopy.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.CmdCopy.Font = CType(resources.GetObject("CmdCopy.Font"), System.Drawing.Font)
        Me.CmdCopy.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCopy.Image = CType(resources.GetObject("CmdCopy.Image"), System.Drawing.Image)
        Me.CmdCopy.ImageAlign = CType(resources.GetObject("CmdCopy.ImageAlign"), System.Drawing.ContentAlignment)
        Me.CmdCopy.ImageIndex = CType(resources.GetObject("CmdCopy.ImageIndex"), Integer)
        Me.CmdCopy.ImeMode = CType(resources.GetObject("CmdCopy.ImeMode"), System.Windows.Forms.ImeMode)
        Me.CmdCopy.Location = CType(resources.GetObject("CmdCopy.Location"), System.Drawing.Point)
        Me.CmdCopy.Name = "CmdCopy"
        Me.CmdCopy.RightToLeft = CType(resources.GetObject("CmdCopy.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.CmdCopy.Size = CType(resources.GetObject("CmdCopy.Size"), System.Drawing.Size)
        Me.CmdCopy.TabIndex = CType(resources.GetObject("CmdCopy.TabIndex"), Integer)
        Me.CmdCopy.Text = resources.GetString("CmdCopy.Text")
        Me.CmdCopy.TextAlign = CType(resources.GetObject("CmdCopy.TextAlign"), System.Drawing.ContentAlignment)
        Me.CmdCopy.Visible = CType(resources.GetObject("CmdCopy.Visible"), Boolean)
        '
        'CmdHelp
        '
        Me.CmdHelp.AccessibleDescription = resources.GetString("CmdHelp.AccessibleDescription")
        Me.CmdHelp.AccessibleName = resources.GetString("CmdHelp.AccessibleName")
        Me.CmdHelp.Anchor = CType(resources.GetObject("CmdHelp.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.CmdHelp.BackgroundImage = CType(resources.GetObject("CmdHelp.BackgroundImage"), System.Drawing.Image)
        Me.CmdHelp.Dock = CType(resources.GetObject("CmdHelp.Dock"), System.Windows.Forms.DockStyle)
        Me.CmdHelp.Enabled = CType(resources.GetObject("CmdHelp.Enabled"), Boolean)
        Me.CmdHelp.FlatStyle = CType(resources.GetObject("CmdHelp.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.CmdHelp.Font = CType(resources.GetObject("CmdHelp.Font"), System.Drawing.Font)
        Me.CmdHelp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdHelp.Image = CType(resources.GetObject("CmdHelp.Image"), System.Drawing.Image)
        Me.CmdHelp.ImageAlign = CType(resources.GetObject("CmdHelp.ImageAlign"), System.Drawing.ContentAlignment)
        Me.CmdHelp.ImageIndex = CType(resources.GetObject("CmdHelp.ImageIndex"), Integer)
        Me.CmdHelp.ImeMode = CType(resources.GetObject("CmdHelp.ImeMode"), System.Windows.Forms.ImeMode)
        Me.CmdHelp.Location = CType(resources.GetObject("CmdHelp.Location"), System.Drawing.Point)
        Me.CmdHelp.Name = "CmdHelp"
        Me.CmdHelp.RightToLeft = CType(resources.GetObject("CmdHelp.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.CmdHelp.Size = CType(resources.GetObject("CmdHelp.Size"), System.Drawing.Size)
        Me.CmdHelp.TabIndex = CType(resources.GetObject("CmdHelp.TabIndex"), Integer)
        Me.CmdHelp.Text = resources.GetString("CmdHelp.Text")
        Me.CmdHelp.TextAlign = CType(resources.GetObject("CmdHelp.TextAlign"), System.Drawing.ContentAlignment)
        Me.CmdHelp.Visible = CType(resources.GetObject("CmdHelp.Visible"), Boolean)
        '
        'CmdCancel
        '
        Me.CmdCancel.AccessibleDescription = resources.GetString("CmdCancel.AccessibleDescription")
        Me.CmdCancel.AccessibleName = resources.GetString("CmdCancel.AccessibleName")
        Me.CmdCancel.Anchor = CType(resources.GetObject("CmdCancel.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.CmdCancel.BackgroundImage = CType(resources.GetObject("CmdCancel.BackgroundImage"), System.Drawing.Image)
        Me.CmdCancel.Dock = CType(resources.GetObject("CmdCancel.Dock"), System.Windows.Forms.DockStyle)
        Me.CmdCancel.Enabled = CType(resources.GetObject("CmdCancel.Enabled"), Boolean)
        Me.CmdCancel.FlatStyle = CType(resources.GetObject("CmdCancel.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.CmdCancel.Font = CType(resources.GetObject("CmdCancel.Font"), System.Drawing.Font)
        Me.CmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCancel.Image = CType(resources.GetObject("CmdCancel.Image"), System.Drawing.Image)
        Me.CmdCancel.ImageAlign = CType(resources.GetObject("CmdCancel.ImageAlign"), System.Drawing.ContentAlignment)
        Me.CmdCancel.ImageIndex = CType(resources.GetObject("CmdCancel.ImageIndex"), Integer)
        Me.CmdCancel.ImeMode = CType(resources.GetObject("CmdCancel.ImeMode"), System.Windows.Forms.ImeMode)
        Me.CmdCancel.Location = CType(resources.GetObject("CmdCancel.Location"), System.Drawing.Point)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.RightToLeft = CType(resources.GetObject("CmdCancel.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.CmdCancel.Size = CType(resources.GetObject("CmdCancel.Size"), System.Drawing.Size)
        Me.CmdCancel.TabIndex = CType(resources.GetObject("CmdCancel.TabIndex"), Integer)
        Me.CmdCancel.Text = resources.GetString("CmdCancel.Text")
        Me.CmdCancel.TextAlign = CType(resources.GetObject("CmdCancel.TextAlign"), System.Drawing.ContentAlignment)
        Me.CmdCancel.Visible = CType(resources.GetObject("CmdCancel.Visible"), Boolean)
        '
        'CmdExit
        '
        Me.CmdExit.AccessibleDescription = resources.GetString("CmdExit.AccessibleDescription")
        Me.CmdExit.AccessibleName = resources.GetString("CmdExit.AccessibleName")
        Me.CmdExit.Anchor = CType(resources.GetObject("CmdExit.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.BackgroundImage = CType(resources.GetObject("CmdExit.BackgroundImage"), System.Drawing.Image)
        Me.CmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdExit.Dock = CType(resources.GetObject("CmdExit.Dock"), System.Windows.Forms.DockStyle)
        Me.CmdExit.Enabled = CType(resources.GetObject("CmdExit.Enabled"), Boolean)
        Me.CmdExit.FlatStyle = CType(resources.GetObject("CmdExit.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.CmdExit.Font = CType(resources.GetObject("CmdExit.Font"), System.Drawing.Font)
        Me.CmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdExit.Image = CType(resources.GetObject("CmdExit.Image"), System.Drawing.Image)
        Me.CmdExit.ImageAlign = CType(resources.GetObject("CmdExit.ImageAlign"), System.Drawing.ContentAlignment)
        Me.CmdExit.ImageIndex = CType(resources.GetObject("CmdExit.ImageIndex"), Integer)
        Me.CmdExit.ImeMode = CType(resources.GetObject("CmdExit.ImeMode"), System.Windows.Forms.ImeMode)
        Me.CmdExit.Location = CType(resources.GetObject("CmdExit.Location"), System.Drawing.Point)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.RightToLeft = CType(resources.GetObject("CmdExit.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.CmdExit.Size = CType(resources.GetObject("CmdExit.Size"), System.Drawing.Size)
        Me.CmdExit.TabIndex = CType(resources.GetObject("CmdExit.TabIndex"), Integer)
        Me.CmdExit.Text = resources.GetString("CmdExit.Text")
        Me.CmdExit.TextAlign = CType(resources.GetObject("CmdExit.TextAlign"), System.Drawing.ContentAlignment)
        Me.CmdExit.Visible = CType(resources.GetObject("CmdExit.Visible"), Boolean)
        '
        'CmdSave
        '
        Me.CmdSave.AccessibleDescription = resources.GetString("CmdSave.AccessibleDescription")
        Me.CmdSave.AccessibleName = resources.GetString("CmdSave.AccessibleName")
        Me.CmdSave.Anchor = CType(resources.GetObject("CmdSave.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.CmdSave.BackgroundImage = CType(resources.GetObject("CmdSave.BackgroundImage"), System.Drawing.Image)
        Me.CmdSave.Dock = CType(resources.GetObject("CmdSave.Dock"), System.Windows.Forms.DockStyle)
        Me.CmdSave.Enabled = CType(resources.GetObject("CmdSave.Enabled"), Boolean)
        Me.CmdSave.FlatStyle = CType(resources.GetObject("CmdSave.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.CmdSave.Font = CType(resources.GetObject("CmdSave.Font"), System.Drawing.Font)
        Me.CmdSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdSave.Image = CType(resources.GetObject("CmdSave.Image"), System.Drawing.Image)
        Me.CmdSave.ImageAlign = CType(resources.GetObject("CmdSave.ImageAlign"), System.Drawing.ContentAlignment)
        Me.CmdSave.ImageIndex = CType(resources.GetObject("CmdSave.ImageIndex"), Integer)
        Me.CmdSave.ImeMode = CType(resources.GetObject("CmdSave.ImeMode"), System.Windows.Forms.ImeMode)
        Me.CmdSave.Location = CType(resources.GetObject("CmdSave.Location"), System.Drawing.Point)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.RightToLeft = CType(resources.GetObject("CmdSave.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.CmdSave.Size = CType(resources.GetObject("CmdSave.Size"), System.Drawing.Size)
        Me.CmdSave.TabIndex = CType(resources.GetObject("CmdSave.TabIndex"), Integer)
        Me.CmdSave.Text = resources.GetString("CmdSave.Text")
        Me.CmdSave.TextAlign = CType(resources.GetObject("CmdSave.TextAlign"), System.Drawing.ContentAlignment)
        Me.CmdSave.Visible = CType(resources.GetObject("CmdSave.Visible"), Boolean)
        '
        'CmdEdit
        '
        Me.CmdEdit.AccessibleDescription = resources.GetString("CmdEdit.AccessibleDescription")
        Me.CmdEdit.AccessibleName = resources.GetString("CmdEdit.AccessibleName")
        Me.CmdEdit.Anchor = CType(resources.GetObject("CmdEdit.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.CmdEdit.BackgroundImage = CType(resources.GetObject("CmdEdit.BackgroundImage"), System.Drawing.Image)
        Me.CmdEdit.Dock = CType(resources.GetObject("CmdEdit.Dock"), System.Windows.Forms.DockStyle)
        Me.CmdEdit.Enabled = CType(resources.GetObject("CmdEdit.Enabled"), Boolean)
        Me.CmdEdit.FlatStyle = CType(resources.GetObject("CmdEdit.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.CmdEdit.Font = CType(resources.GetObject("CmdEdit.Font"), System.Drawing.Font)
        Me.CmdEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdEdit.Image = CType(resources.GetObject("CmdEdit.Image"), System.Drawing.Image)
        Me.CmdEdit.ImageAlign = CType(resources.GetObject("CmdEdit.ImageAlign"), System.Drawing.ContentAlignment)
        Me.CmdEdit.ImageIndex = CType(resources.GetObject("CmdEdit.ImageIndex"), Integer)
        Me.CmdEdit.ImeMode = CType(resources.GetObject("CmdEdit.ImeMode"), System.Windows.Forms.ImeMode)
        Me.CmdEdit.Location = CType(resources.GetObject("CmdEdit.Location"), System.Drawing.Point)
        Me.CmdEdit.Name = "CmdEdit"
        Me.CmdEdit.RightToLeft = CType(resources.GetObject("CmdEdit.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.CmdEdit.Size = CType(resources.GetObject("CmdEdit.Size"), System.Drawing.Size)
        Me.CmdEdit.TabIndex = CType(resources.GetObject("CmdEdit.TabIndex"), Integer)
        Me.CmdEdit.Text = resources.GetString("CmdEdit.Text")
        Me.CmdEdit.TextAlign = CType(resources.GetObject("CmdEdit.TextAlign"), System.Drawing.ContentAlignment)
        Me.CmdEdit.Visible = CType(resources.GetObject("CmdEdit.Visible"), Boolean)
        '
        'CmdSearch
        '
        Me.CmdSearch.AccessibleDescription = resources.GetString("CmdSearch.AccessibleDescription")
        Me.CmdSearch.AccessibleName = resources.GetString("CmdSearch.AccessibleName")
        Me.CmdSearch.Anchor = CType(resources.GetObject("CmdSearch.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.CmdSearch.BackgroundImage = CType(resources.GetObject("CmdSearch.BackgroundImage"), System.Drawing.Image)
        Me.CmdSearch.Dock = CType(resources.GetObject("CmdSearch.Dock"), System.Windows.Forms.DockStyle)
        Me.CmdSearch.Enabled = CType(resources.GetObject("CmdSearch.Enabled"), Boolean)
        Me.CmdSearch.FlatStyle = CType(resources.GetObject("CmdSearch.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.CmdSearch.Font = CType(resources.GetObject("CmdSearch.Font"), System.Drawing.Font)
        Me.CmdSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdSearch.Image = CType(resources.GetObject("CmdSearch.Image"), System.Drawing.Image)
        Me.CmdSearch.ImageAlign = CType(resources.GetObject("CmdSearch.ImageAlign"), System.Drawing.ContentAlignment)
        Me.CmdSearch.ImageIndex = CType(resources.GetObject("CmdSearch.ImageIndex"), Integer)
        Me.CmdSearch.ImeMode = CType(resources.GetObject("CmdSearch.ImeMode"), System.Windows.Forms.ImeMode)
        Me.CmdSearch.Location = CType(resources.GetObject("CmdSearch.Location"), System.Drawing.Point)
        Me.CmdSearch.Name = "CmdSearch"
        Me.CmdSearch.RightToLeft = CType(resources.GetObject("CmdSearch.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.CmdSearch.Size = CType(resources.GetObject("CmdSearch.Size"), System.Drawing.Size)
        Me.CmdSearch.TabIndex = CType(resources.GetObject("CmdSearch.TabIndex"), Integer)
        Me.CmdSearch.Text = resources.GetString("CmdSearch.Text")
        Me.CmdSearch.TextAlign = CType(resources.GetObject("CmdSearch.TextAlign"), System.Drawing.ContentAlignment)
        Me.CmdSearch.Visible = CType(resources.GetObject("CmdSearch.Visible"), Boolean)
        '
        'CmdDelete
        '
        Me.CmdDelete.AccessibleDescription = resources.GetString("CmdDelete.AccessibleDescription")
        Me.CmdDelete.AccessibleName = resources.GetString("CmdDelete.AccessibleName")
        Me.CmdDelete.Anchor = CType(resources.GetObject("CmdDelete.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.CmdDelete.BackgroundImage = CType(resources.GetObject("CmdDelete.BackgroundImage"), System.Drawing.Image)
        Me.CmdDelete.Dock = CType(resources.GetObject("CmdDelete.Dock"), System.Windows.Forms.DockStyle)
        Me.CmdDelete.Enabled = CType(resources.GetObject("CmdDelete.Enabled"), Boolean)
        Me.CmdDelete.FlatStyle = CType(resources.GetObject("CmdDelete.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.CmdDelete.Font = CType(resources.GetObject("CmdDelete.Font"), System.Drawing.Font)
        Me.CmdDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdDelete.Image = CType(resources.GetObject("CmdDelete.Image"), System.Drawing.Image)
        Me.CmdDelete.ImageAlign = CType(resources.GetObject("CmdDelete.ImageAlign"), System.Drawing.ContentAlignment)
        Me.CmdDelete.ImageIndex = CType(resources.GetObject("CmdDelete.ImageIndex"), Integer)
        Me.CmdDelete.ImeMode = CType(resources.GetObject("CmdDelete.ImeMode"), System.Windows.Forms.ImeMode)
        Me.CmdDelete.Location = CType(resources.GetObject("CmdDelete.Location"), System.Drawing.Point)
        Me.CmdDelete.Name = "CmdDelete"
        Me.CmdDelete.RightToLeft = CType(resources.GetObject("CmdDelete.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.CmdDelete.Size = CType(resources.GetObject("CmdDelete.Size"), System.Drawing.Size)
        Me.CmdDelete.TabIndex = CType(resources.GetObject("CmdDelete.TabIndex"), Integer)
        Me.CmdDelete.Text = resources.GetString("CmdDelete.Text")
        Me.CmdDelete.TextAlign = CType(resources.GetObject("CmdDelete.TextAlign"), System.Drawing.ContentAlignment)
        Me.CmdDelete.Visible = CType(resources.GetObject("CmdDelete.Visible"), Boolean)
        '
        'CmdAdd
        '
        Me.CmdAdd.AccessibleDescription = resources.GetString("CmdAdd.AccessibleDescription")
        Me.CmdAdd.AccessibleName = resources.GetString("CmdAdd.AccessibleName")
        Me.CmdAdd.Anchor = CType(resources.GetObject("CmdAdd.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.CmdAdd.BackgroundImage = CType(resources.GetObject("CmdAdd.BackgroundImage"), System.Drawing.Image)
        Me.CmdAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdAdd.Dock = CType(resources.GetObject("CmdAdd.Dock"), System.Windows.Forms.DockStyle)
        Me.CmdAdd.Enabled = CType(resources.GetObject("CmdAdd.Enabled"), Boolean)
        Me.CmdAdd.FlatStyle = CType(resources.GetObject("CmdAdd.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.CmdAdd.Font = CType(resources.GetObject("CmdAdd.Font"), System.Drawing.Font)
        Me.CmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdAdd.Image = CType(resources.GetObject("CmdAdd.Image"), System.Drawing.Image)
        Me.CmdAdd.ImageAlign = CType(resources.GetObject("CmdAdd.ImageAlign"), System.Drawing.ContentAlignment)
        Me.CmdAdd.ImageIndex = CType(resources.GetObject("CmdAdd.ImageIndex"), Integer)
        Me.CmdAdd.ImeMode = CType(resources.GetObject("CmdAdd.ImeMode"), System.Windows.Forms.ImeMode)
        Me.CmdAdd.Location = CType(resources.GetObject("CmdAdd.Location"), System.Drawing.Point)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.RightToLeft = CType(resources.GetObject("CmdAdd.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.CmdAdd.Size = CType(resources.GetObject("CmdAdd.Size"), System.Drawing.Size)
        Me.CmdAdd.TabIndex = CType(resources.GetObject("CmdAdd.TabIndex"), Integer)
        Me.CmdAdd.Text = resources.GetString("CmdAdd.Text")
        Me.CmdAdd.TextAlign = CType(resources.GetObject("CmdAdd.TextAlign"), System.Drawing.ContentAlignment)
        Me.CmdAdd.Visible = CType(resources.GetObject("CmdAdd.Visible"), Boolean)
        '
        'Panel2
        '
        Me.Panel2.AccessibleDescription = resources.GetString("Panel2.AccessibleDescription")
        Me.Panel2.AccessibleName = resources.GetString("Panel2.AccessibleName")
        Me.Panel2.Anchor = CType(resources.GetObject("Panel2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = CType(resources.GetObject("Panel2.AutoScroll"), Boolean)
        Me.Panel2.AutoScrollMargin = CType(resources.GetObject("Panel2.AutoScrollMargin"), System.Drawing.Size)
        Me.Panel2.AutoScrollMinSize = CType(resources.GetObject("Panel2.AutoScrollMinSize"), System.Drawing.Size)
        Me.Panel2.BackColor = System.Drawing.Color.Khaki
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.LBLCr)
        Me.Panel2.Controls.Add(Me.LBLDr)
        Me.Panel2.Dock = CType(resources.GetObject("Panel2.Dock"), System.Windows.Forms.DockStyle)
        Me.Panel2.Enabled = CType(resources.GetObject("Panel2.Enabled"), Boolean)
        Me.Panel2.Font = CType(resources.GetObject("Panel2.Font"), System.Drawing.Font)
        Me.Panel2.ImeMode = CType(resources.GetObject("Panel2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Panel2.Location = CType(resources.GetObject("Panel2.Location"), System.Drawing.Point)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RightToLeft = CType(resources.GetObject("Panel2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Panel2.Size = CType(resources.GetObject("Panel2.Size"), System.Drawing.Size)
        Me.Panel2.TabIndex = CType(resources.GetObject("Panel2.TabIndex"), Integer)
        Me.Panel2.Text = resources.GetString("Panel2.Text")
        Me.Panel2.Visible = CType(resources.GetObject("Panel2.Visible"), Boolean)
        '
        'LBLCr
        '
        Me.LBLCr.AccessibleDescription = resources.GetString("LBLCr.AccessibleDescription")
        Me.LBLCr.AccessibleName = resources.GetString("LBLCr.AccessibleName")
        Me.LBLCr.Anchor = CType(resources.GetObject("LBLCr.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.LBLCr.AutoSize = CType(resources.GetObject("LBLCr.AutoSize"), Boolean)
        Me.LBLCr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLCr.Dock = CType(resources.GetObject("LBLCr.Dock"), System.Windows.Forms.DockStyle)
        Me.LBLCr.Enabled = CType(resources.GetObject("LBLCr.Enabled"), Boolean)
        Me.LBLCr.Font = CType(resources.GetObject("LBLCr.Font"), System.Drawing.Font)
        Me.LBLCr.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LBLCr.Image = CType(resources.GetObject("LBLCr.Image"), System.Drawing.Image)
        Me.LBLCr.ImageAlign = CType(resources.GetObject("LBLCr.ImageAlign"), System.Drawing.ContentAlignment)
        Me.LBLCr.ImageIndex = CType(resources.GetObject("LBLCr.ImageIndex"), Integer)
        Me.LBLCr.ImeMode = CType(resources.GetObject("LBLCr.ImeMode"), System.Windows.Forms.ImeMode)
        Me.LBLCr.Location = CType(resources.GetObject("LBLCr.Location"), System.Drawing.Point)
        Me.LBLCr.Name = "LBLCr"
        Me.LBLCr.RightToLeft = CType(resources.GetObject("LBLCr.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.LBLCr.Size = CType(resources.GetObject("LBLCr.Size"), System.Drawing.Size)
        Me.LBLCr.TabIndex = CType(resources.GetObject("LBLCr.TabIndex"), Integer)
        Me.LBLCr.Text = resources.GetString("LBLCr.Text")
        Me.LBLCr.TextAlign = CType(resources.GetObject("LBLCr.TextAlign"), System.Drawing.ContentAlignment)
        Me.LBLCr.Visible = CType(resources.GetObject("LBLCr.Visible"), Boolean)
        '
        'LBLDr
        '
        Me.LBLDr.AccessibleDescription = resources.GetString("LBLDr.AccessibleDescription")
        Me.LBLDr.AccessibleName = resources.GetString("LBLDr.AccessibleName")
        Me.LBLDr.Anchor = CType(resources.GetObject("LBLDr.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.LBLDr.AutoSize = CType(resources.GetObject("LBLDr.AutoSize"), Boolean)
        Me.LBLDr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLDr.Dock = CType(resources.GetObject("LBLDr.Dock"), System.Windows.Forms.DockStyle)
        Me.LBLDr.Enabled = CType(resources.GetObject("LBLDr.Enabled"), Boolean)
        Me.LBLDr.Font = CType(resources.GetObject("LBLDr.Font"), System.Drawing.Font)
        Me.LBLDr.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LBLDr.Image = CType(resources.GetObject("LBLDr.Image"), System.Drawing.Image)
        Me.LBLDr.ImageAlign = CType(resources.GetObject("LBLDr.ImageAlign"), System.Drawing.ContentAlignment)
        Me.LBLDr.ImageIndex = CType(resources.GetObject("LBLDr.ImageIndex"), Integer)
        Me.LBLDr.ImeMode = CType(resources.GetObject("LBLDr.ImeMode"), System.Windows.Forms.ImeMode)
        Me.LBLDr.Location = CType(resources.GetObject("LBLDr.Location"), System.Drawing.Point)
        Me.LBLDr.Name = "LBLDr"
        Me.LBLDr.RightToLeft = CType(resources.GetObject("LBLDr.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.LBLDr.Size = CType(resources.GetObject("LBLDr.Size"), System.Drawing.Size)
        Me.LBLDr.TabIndex = CType(resources.GetObject("LBLDr.TabIndex"), Integer)
        Me.LBLDr.Text = resources.GetString("LBLDr.Text")
        Me.LBLDr.TextAlign = CType(resources.GetObject("LBLDr.TextAlign"), System.Drawing.ContentAlignment)
        Me.LBLDr.Visible = CType(resources.GetObject("LBLDr.Visible"), Boolean)
        '
        'Panel3
        '
        Me.Panel3.AccessibleDescription = resources.GetString("Panel3.AccessibleDescription")
        Me.Panel3.AccessibleName = resources.GetString("Panel3.AccessibleName")
        Me.Panel3.Anchor = CType(resources.GetObject("Panel3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Panel3.AutoScroll = CType(resources.GetObject("Panel3.AutoScroll"), Boolean)
        Me.Panel3.AutoScrollMargin = CType(resources.GetObject("Panel3.AutoScrollMargin"), System.Drawing.Size)
        Me.Panel3.AutoScrollMinSize = CType(resources.GetObject("Panel3.AutoScrollMinSize"), System.Drawing.Size)
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.TxT)
        Me.Panel3.Controls.Add(Me.LPart)
        Me.Panel3.Controls.Add(Me.FGrid)
        Me.Panel3.Dock = CType(resources.GetObject("Panel3.Dock"), System.Windows.Forms.DockStyle)
        Me.Panel3.Enabled = CType(resources.GetObject("Panel3.Enabled"), Boolean)
        Me.Panel3.Font = CType(resources.GetObject("Panel3.Font"), System.Drawing.Font)
        Me.Panel3.ImeMode = CType(resources.GetObject("Panel3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Panel3.Location = CType(resources.GetObject("Panel3.Location"), System.Drawing.Point)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.RightToLeft = CType(resources.GetObject("Panel3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Panel3.Size = CType(resources.GetObject("Panel3.Size"), System.Drawing.Size)
        Me.Panel3.TabIndex = CType(resources.GetObject("Panel3.TabIndex"), Integer)
        Me.Panel3.Text = resources.GetString("Panel3.Text")
        Me.Panel3.Visible = CType(resources.GetObject("Panel3.Visible"), Boolean)
        '
        'LPart
        '
        Me.LPart.AccessibleDescription = resources.GetString("LPart.AccessibleDescription")
        Me.LPart.AccessibleName = resources.GetString("LPart.AccessibleName")
        Me.LPart.Anchor = CType(resources.GetObject("LPart.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.LPart.BackColor = System.Drawing.Color.LemonChiffon
        Me.LPart.BackgroundImage = CType(resources.GetObject("LPart.BackgroundImage"), System.Drawing.Image)
        Me.LPart.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LPart.ColumnWidth = CType(resources.GetObject("LPart.ColumnWidth"), Integer)
        Me.LPart.Dock = CType(resources.GetObject("LPart.Dock"), System.Windows.Forms.DockStyle)
        Me.LPart.Enabled = CType(resources.GetObject("LPart.Enabled"), Boolean)
        Me.LPart.Font = CType(resources.GetObject("LPart.Font"), System.Drawing.Font)
        Me.LPart.HorizontalExtent = CType(resources.GetObject("LPart.HorizontalExtent"), Integer)
        Me.LPart.HorizontalScrollbar = CType(resources.GetObject("LPart.HorizontalScrollbar"), Boolean)
        Me.LPart.ImeMode = CType(resources.GetObject("LPart.ImeMode"), System.Windows.Forms.ImeMode)
        Me.LPart.IntegralHeight = CType(resources.GetObject("LPart.IntegralHeight"), Boolean)
        Me.LPart.ItemHeight = CType(resources.GetObject("LPart.ItemHeight"), Integer)
        Me.LPart.Location = CType(resources.GetObject("LPart.Location"), System.Drawing.Point)
        Me.LPart.Name = "LPart"
        Me.LPart.RightToLeft = CType(resources.GetObject("LPart.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.LPart.ScrollAlwaysVisible = CType(resources.GetObject("LPart.ScrollAlwaysVisible"), Boolean)
        Me.LPart.Size = CType(resources.GetObject("LPart.Size"), System.Drawing.Size)
        Me.LPart.TabIndex = CType(resources.GetObject("LPart.TabIndex"), Integer)
        Me.LPart.Visible = CType(resources.GetObject("LPart.Visible"), Boolean)
        '
        'Journal
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.Add(Me.BPanel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblDisplay)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "Journal"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.FGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Journal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OleDbcn = New OleDbConnection(ConStr)
        Dim OleDaPart As New OleDbDataAdapter("SELECT Part,GlCode FROM GlMast WHERE IndCode<>'BB' order by Part", OleDbcn)
        OleDaPart.Fill(Ds, "A")
        LPart.DataSource = Ds
        LPart.DisplayMember = "A.Part"
        LPart.ValueMember = "A.GlCode"
        IDate.MinDate = FromDate
        IDate.MaxDate = ToDate
        If Today >= FromDate And Today <= ToDate Then
            IDate.Value = Today
        End If
        TxT.Visible = False
        LPart.Visible = False
        FGrid.set_ColWidth(Column.GlCode, 0)
        Me.KeyPreview = True
        E_D(True)
        EnaDis(False)
        InitTable()
        Me.KeyPreview = True
        If CallFromAcExt = True Then
            SearchDisplay(StrVno)
        Else
            If DT.Rows.Count > 0 Then
                DtRow = DT.Rows.Count - 1
                Display(DtRow)
            End If
        End If
    End Sub
    Private Sub EnaDis(ByVal Flag As Boolean)
        Panel1.Enabled = Flag
        Panel3.Enabled = Flag
    End Sub
    Private Sub IDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IDate.ValueChanged
        lblDay.Text = Format(IDate.Value, "ddddd")
    End Sub

    Private Sub Journal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
                        If DT.Rows.Count > 0 Then
                            DtRow = 0
                            Display(DtRow)
                        End If
                    Case ModMain.Navigation.MovePrevious
                        If DtRow > 0 Then
                            DtRow = DtRow - 1
                            Display(DtRow)
                        End If
                    Case ModMain.Navigation.MoveNext
                        If DtRow < DT.Rows.Count - 1 Then
                            DtRow = DtRow + 1
                            Display(DtRow)
                        End If
                    Case ModMain.Navigation.MoveLast
                        If DT.Rows.Count > 0 Then
                            DtRow = DT.Rows.Count - 1
                            Display(DtRow)
                        End If
                End Select
        End Select
    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub
    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        E_D(True)
        EnaDis(False)
    End Sub

    Private Sub CmdExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        TxT.Hide()
        LPart.Hide()
        Me.Close()
    End Sub
    Private Sub CmdAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        Dim i As Int16
        Opr = Operation.Add
        E_D(False)
        EnaDis(True)
        If Today >= FromDate And Today <= ToDate Then
            IDate.Value = Today
        End If
        TxTRef.Text = ""
        TxTVNo.Text = Vno(Me.Tag)
        LBLCr.Text = "0.00"
        LBLDr.Text = "0.00"
        FGrid.Rows = 2
        For i = 0 To FGrid.Cols - 1
            FGrid.set_TextMatrix(1, i, "")
        Next
        IDate.Focus()
        'FGrid.Row = FGrid.Rows - 1
        'FGrid.Col = Column.AChead
        'TxT.SetBounds(FGrid.Left + VB6.TwipsToPixelsX(FGrid.CellLeft), FGrid.Top + VB6.TwipsToPixelsY(FGrid.CellTop), VB6.TwipsToPixelsX(FGrid.CellWidth), VB6.TwipsToPixelsY(FGrid.CellHeight))
        'TxT.Show()
        'TxT.Focus()
    End Sub
    Private Sub E_D(ByVal Flag As Boolean)
        CmdAdd.Enabled = Flag
        CmdDelete.Enabled = Flag
        CmdEdit.Enabled = Flag
        CmdExit.Enabled = Flag
        CmdHelp.Enabled = Flag
        CmdSearch.Enabled = Flag
        CmdSave.Enabled = Not Flag
        CmdCancel.Enabled = Not Flag
    End Sub

    Private Sub CmdCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        CmdCopy.Visible = False
        E_D(True)
        EnaDis(False)
        Opr = Operation.None
        If DT.Rows.Count > 0 Then
            DtRow = DT.Rows.Count - 1
            Display(DtRow)
        End If
    End Sub
    Private Sub TxT_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxT.GotFocus
        TxT.Text = FGrid.Text
        TxT.SelectAll()
    End Sub
    Private Sub TxT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxT.LostFocus
        Try
            If FGrid.Col = Column.Credit Or FGrid.Col = Column.Debit Then
                FGrid.Text = Format(Val(TxT.Text), "0.00")
            Else
                FGrid.Text = TxT.Text
            End If
            TxT.Hide()
            If FGrid.Col = Column.AChead Then
                FGrid.set_TextMatrix(FGrid.Row, Column.GlCode, LPart.SelectedValue)
            End If
            If FGrid.Col = Column.Credit Then
                If Val(FGrid.get_TextMatrix(FGrid.Row, Column.Debit)) = 0 And Val(FGrid.get_TextMatrix(FGrid.Row, Column.Credit)) = 0 Then
                    FGrid.Col = Column.Credit
                    Exit Sub
                End If
            End If
            If FGrid.Col < Column.Narration Then
                FGrid.Col = FGrid.Col + 1
            Else
                If FGrid.get_TextMatrix(FGrid.Row, Column.AChead) = "" Then
                    FGrid.Col = Column.AChead
                    Exit Sub
                End If
                If Val(FGrid.get_TextMatrix(FGrid.Row, Column.Debit)) = 0 And Val(FGrid.get_TextMatrix(FGrid.Row, Column.Credit)) = 0 Then
                    FGrid.Col = Column.Debit
                    Exit Sub
                End If
                FillNo()
                If FGrid.Row = FGrid.Rows - 1 Then
                    If MsgBox("Do you want to add New Record", MsgBoxStyle.YesNo, "New Record") = MsgBoxResult.Yes Then
                        FGrid.AddItem("")
                        FGrid.Col = Column.AChead
                        FGrid.Row = FGrid.Rows - 1
                    End If
                End If
            End If
        Catch EX As Exception
            MsgBox(EX.Message)
        Finally
            'FGrid.Enabled = True
        End Try
    End Sub
    Private Sub TxT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxT.TextChanged
        Calc()
        Dim iCol As Column = FGrid.Col
        Select Case iCol
            Case Column.AChead
                Dim z As Int16 = TxT.Text.Length
                LPart.SelectedIndex = LPart.FindString(TxT.Text)
                LPart.TopIndex = LPart.SelectedIndex
                If LPart.SelectedIndex > -1 Then
                    TxT.Text = LPart.GetItemText(LPart.SelectedItem)
                    If TxT.Text.Length >= z Then
                        TxT.Select(z, TxT.Text.Length - z)
                    End If
                End If
            Case Column.Credit
                If Val(FGrid.get_TextMatrix(FGrid.Row, Column.Debit)) > 0 Then
                    TxT.Text = ""
                End If
            Case Column.Debit
                If Val(FGrid.get_TextMatrix(FGrid.Row, Column.Credit)) > 0 Then
                    TxT.Text = ""
                End If
        End Select
    End Sub
    Private Sub FGrid_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles FGrid.EnterCell
        If Flag = True Or FGrid.Col = Column.SrNo Then Exit Sub
        TxT.Text = FGrid.Text
        TxT.SelectAll()
        TxT.SetBounds(FGrid.Left + VB6.TwipsToPixelsX(FGrid.CellLeft), FGrid.Top + VB6.TwipsToPixelsY(FGrid.CellTop), VB6.TwipsToPixelsX(FGrid.CellWidth), VB6.TwipsToPixelsY(FGrid.CellHeight))
        TxT.Show()
        If FGrid.Col = Column.AChead Then
            LPart.SetBounds(FGrid.Left + VB6.TwipsToPixelsX(FGrid.CellLeft), FGrid.Top + VB6.TwipsToPixelsY(FGrid.CellTop) + VB6.TwipsToPixelsY(FGrid.CellHeight), LPart.Width, LPart.Height)
            LPart.Show()
        Else
            LPart.Hide()
        End If
        TxT.Focus()
    End Sub
    Private Sub CmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSave.Click
        CmdCopy.Visible = False
        Dim adp As OleDbDataAdapter
        Dim ds As New DataSet
        Dim acb As OleDbCommandBuilder
        Dim dr As DataRow
        Dim StrVNo As String
        Dim i As Integer
        For i = 1 To FGrid.Rows - 1
            If FGrid.get_TextMatrix(i, Column.AChead) = "" Then
                FGrid.Col = Column.AChead
                Exit Sub
            End If
        Next
        For i = 1 To FGrid.Rows - 1
            If Val(FGrid.get_TextMatrix(i, Column.Debit)) = 0 And Val(FGrid.get_TextMatrix(i, Column.Credit)) = 0 Then
                FGrid.Row = i
                FGrid.Col = Column.Debit
                Exit Sub
            End If
        Next
        If LPart.Visible = True Or TxT.Visible = True Then
            MsgBox("Can't Save This Time", MsgBoxStyle.Information, "Complete Entry")
            Exit Sub
        End If
        Dim iRow, iCol As Int16
        Dim DSum, CSum As Double
        For iRow = 1 To FGrid.Rows - 1
            DSum += Val(FGrid.get_TextMatrix(iRow, Column.Debit))
            CSum += Val(FGrid.get_TextMatrix(iRow, Column.Credit))
        Next
        If Round(DSum, 2) <> Round(CSum, 2) Or DSum = 0 Or CSum = 0 Then
            MsgBox("Debit-Credit Amount Are Not Matched", MsgBoxStyle.Critical, "Invalid Entry!!!")
            Exit Sub
        End If
        If Opr = Operation.Edit Then
            Dim CmdDelete As New OleDbCommand
            Try
                If OleDbcn.State Then OleDbcn.Close()
                OleDbcn.Open()
                CmdDelete.CommandText = "DELETE * FROM GenGl Where Vno='" & TxTVNo.Text & "'"
                CmdDelete.Connection = OleDbcn
                CmdDelete.ExecuteNonQuery()
                OleDbcn.Close()
            Catch Ex2 As Exception
                MsgBox(Ex2.Message)
                Exit Sub
            End Try
        End If
        Try
            If OleDbcn.State Then OleDbcn.Close()
            OleDbcn.Open()
            adp = New OleDbDataAdapter("Select Vno,RefNo,TDate,Part,Amt,GlCode,Book,UserID from GenGL", OleDbcn)
            adp.Fill(ds, "G")
            acb = New OleDbCommandBuilder(adp)
            If Opr = Operation.Add Then
                StrVNo = Vno(Me.Tag)
            Else
                StrVNo = TxTVNo.Text
            End If
            For i = 1 To FGrid.Rows - 1
                dr = ds.Tables("G").NewRow
                dr("Vno") = StrVNo
                dr("RefNo") = TxTRef.Text
                dr("TDate") = IDate.Value
                dr("Part") = FGrid.get_TextMatrix(i, Column.Narration)
                If Val(FGrid.get_TextMatrix(i, Column.Debit)) > 0 Then
                    dr("Amt") = Val(FGrid.get_TextMatrix(i, Column.Debit))
                Else
                    dr("Amt") = -1 * Val(FGrid.get_TextMatrix(i, Column.Credit))
                End If
                dr("GlCode") = CLng(FGrid.get_TextMatrix(i, Column.GlCode))
                dr("Book") = Me.Tag
                dr("UserID") = imUser.GetUserID
                ds.Tables("G").Rows.Add(dr)
            Next
            adp.Update(ds, "G")
            MsgBox("Record Saved Sucessfully", MsgBoxStyle.Information, "Save")
            E_D(True)
            Opr = Operation.None
            EnaDis(False)
            InitTable()
            If DT.Rows.Count > 0 Then
                DtRow = DT.Rows.Count - 1
                Display(DtRow)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDbcn.Close()
        End Try
    End Sub
    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        Dim StrSql As String
        StrSql = "SELECT Gl.Vno AS VNo, Gm.Part AS AcHead,FORMAT(Gl.TDate,'dd/MM/yyyy') as TDate,IIF(GL.Amt>0,Gl.Amt,NULL) as DAmt,IIF(GL.Amt<0,Abs(Gl.Amt),NULL) as CAmt, Gl.Part AS Narr FROM GenGL Gl, GlMast Gm WHERE Gl.GlCode=Gm.GlCode AND Gl.Book='" & Me.Tag & "' AND  Gl.Vno & Gm.Part & Gl.TDate & Gl.Amt &  Gl.Part Like"
        Dim NewSearch As New FrmSearch(CallFrom.JournalVoucher, StrSql)
        NewSearch.MdiParent = Me.MdiParent
        StrSearchResult = ""
        NewSearch.Show()
        Opr = Operation.Search
    End Sub
    Private Sub Calc()
        Dim i As Int16
        Dim Csum, DSum As Double
        For i = 1 To FGrid.Rows - 1
            Csum += Val(FGrid.get_TextMatrix(i, Column.Credit))
            DSum += Val(FGrid.get_TextMatrix(i, Column.Debit))
        Next
        LBLDr.Text = Format(DSum, "0.00")
        LBLCr.Text = Format(Csum, "0.00")
    End Sub
    Public Sub InitTable()
        Dim OleDa As OleDbDataAdapter
        If OleDbcn.State Then OleDbcn.Close()
        OleDbcn.Open()
        OleDa = New OleDbDataAdapter("SELECT Vno FROM GenGl WHERE Book='" & Me.Tag & "' Group By Vno,TDate Order by vno,Tdate", OleDbcn)
        Dst.Clear()
        OleDa.Fill(Dst, "ABC")
        DT = Dst.Tables("ABC")
        If DT.Rows.Count > 0 Then
            DtRow = 0
        Else
            DtRow = -1
        End If
        OleDbcn.Close()
    End Sub
    Public Sub SearchDisplay(ByVal StrVno As String)
        Dim Dr As OleDbDataReader
        Dim cmd As OleDbCommand
        Dim DSum, CSum As Double
        Dim I As Int16
        If DT.Rows.Count > 0 Then
            If OleDbcn.State Then OleDbcn.Close()
            OleDbcn.Open()
            cmd = New OleDbCommand("SELECT * From GenGl WHERE Vno='" & StrVno & "'", OleDbcn)
            Dr = cmd.ExecuteReader
            Flag = True
            TxTVNo.Text = StrVno
            If Dr.HasRows = True Then
                FGrid.Rows = 2
                For I = 0 To FGrid.Cols - 1
                    FGrid.set_TextMatrix(1, I, "")
                Next
                FGrid.Row = 1
                While Dr.Read
                    IDate.Value = Dr.Item("TDate")
                    TxTRef.Text = IIf(IsDBNull(Dr.Item("RefNo")), "", Dr.Item("RefNo"))
                    LPart.SelectedValue = Dr.Item("GlCode")
                    FGrid.set_TextMatrix(FGrid.Row, Column.AChead, LPart.GetItemText(LPart.SelectedItem))
                    FGrid.set_TextMatrix(FGrid.Row, Column.GlCode, Dr.Item("GlCode"))
                    If Val(Dr.Item("Amt")) > 0 Then
                        FGrid.set_TextMatrix(FGrid.Row, Column.Debit, Format(Abs(Val(Dr.Item("Amt"))), "0.00"))
                    Else
                        FGrid.set_TextMatrix(FGrid.Row, Column.Credit, Format(Abs(Val(Dr.Item("Amt"))), "0.00"))
                    End If
                    FGrid.set_TextMatrix(FGrid.Row, Column.Narration, Dr.Item("Part"))
                    FGrid.AddItem("")
                    FGrid.Row = FGrid.Row + 1
                End While
                FGrid.RemoveItem(FGrid.Rows - 1)
                For I = 1 To FGrid.Rows - 1
                    DSum += Val(FGrid.get_TextMatrix(I, Column.Debit))
                    CSum += Val(FGrid.get_TextMatrix(I, Column.Credit))
                Next
                LBLDr.Text = Format(DSum, "0.00")
                LBLCr.Text = Format(CSum, "0.00")
            End If
        End If
        Flag = False
    End Sub
    Public Sub Display(ByVal Pos As Long)
        Dim Dr As OleDbDataReader
        Dim cmd As OleDbCommand
        Dim DSum, CSum As Double
        Dim I As Int16
        If DT.Rows.Count > 0 Then
            If OleDbcn.State Then OleDbcn.Close()
            OleDbcn.Open()
            cmd = New OleDbCommand("SELECT * From GenGl WHERE Vno='" & DT.Rows(Pos).Item(0) & "'", OleDbcn)
            Dr = cmd.ExecuteReader
            Flag = True
            TxTVNo.Text = CType(DT.Rows(Pos).Item(0), String)
            If Dr.HasRows = True Then
                FGrid.Rows = 2
                For I = 1 To FGrid.Cols - 1
                    FGrid.set_TextMatrix(1, I, "")
                Next
                FGrid.Row = 1
                While Dr.Read
                    IDate.Value = Dr.Item("TDate")
                    TxTRef.Text = IIf(IsDBNull(Dr.Item("RefNo")), "", Dr.Item("RefNo"))
                    LPart.SelectedValue = Dr.Item("GlCode")
                    FGrid.set_TextMatrix(FGrid.Row, Column.AChead, LPart.GetItemText(LPart.SelectedItem))
                    FGrid.set_TextMatrix(FGrid.Row, Column.GlCode, Dr.Item("GlCode"))
                    If Val(Dr.Item("Amt")) > 0 Then
                        FGrid.set_TextMatrix(FGrid.Row, Column.Debit, Format(Abs(Val(Dr.Item("Amt"))), "0.00"))
                    Else
                        FGrid.set_TextMatrix(FGrid.Row, Column.Credit, Format(Abs(Val(Dr.Item("Amt"))), "0.00"))
                    End If
                    FGrid.set_TextMatrix(FGrid.Row, Column.Narration, IIf(IsDBNull(Dr.Item("Part")), "", Dr.Item("Part")))
                    FGrid.AddItem("")
                    FGrid.Row = FGrid.Row + 1
                End While
                FGrid.RemoveItem(FGrid.Rows - 1)
                For I = 1 To FGrid.Rows - 1
                    DSum += Val(FGrid.get_TextMatrix(I, Column.Debit))
                    CSum += Val(FGrid.get_TextMatrix(I, Column.Credit))
                Next
                LBLDr.Text = Format(DSum, "0.00")
                LBLCr.Text = Format(CSum, "0.00")
            End If
        End If
        FillNo()
        Flag = False
    End Sub

    Private Sub CmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEdit.Click
        CmdCopy.Visible = True
        E_D(False)
        EnaDis(True)
        Opr = Operation.Edit
        IDate.Focus()
    End Sub

    Private Sub Journal_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If Opr = Operation.Search Then
            Opr = Operation.None
            If StrSearchResult.ToString <> "" Or StrSearchResult.ToString.Length = 6 Then
                If StrSearchResult.Substring(0, 2) = "JV" Then
                    SearchDisplay(StrSearchResult)
                End If
            End If
        End If
    End Sub
    Private Sub FGrid_KeyPressEvent(ByVal sender As Object, ByVal e As AxMSFlexGridLib.DMSFlexGridEvents_KeyPressEvent) Handles FGrid.KeyPressEvent
        If e.keyAscii = 8 Then
            Close()
        End If
    End Sub

    Private Sub FGrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxMSFlexGridLib.DMSFlexGridEvents_KeyDownEvent) Handles FGrid.KeyDownEvent
        If e.keyCode = Keys.Delete Then
            If MsgBox("Are you sure want to delete current Row?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Row") = MsgBoxResult.Yes Then
                FGrid.RemoveItem(FGrid.RowSel)
                Calc()
                FillNo()
            End If
        End If
    End Sub

    Private Sub TxT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxT.KeyDown
        If FGrid.Col = Column.AChead Then
            Select Case e.KeyCode
                Case Keys.Down
                    If LPart.SelectedIndex < LPart.Items.Count - 1 Then
                        LPart.SelectedIndex += 1
                    End If
                Case Keys.Up
                    If LPart.SelectedIndex > 0 Then
                        LPart.SelectedIndex -= 1
                    End If
                Case Keys.Left
                    If FGrid.Col > Column.AChead Then
                        FGrid.Col -= 1
                    End If
                Case Keys.Right
                    If FGrid.Col < Column.Narration Then
                        FGrid.Text = TxT.Text
                        FGrid.set_TextMatrix(FGrid.Row, Column.GlCode, LPart.SelectedValue)
                        FGrid.Col += 1
                    End If
                Case Keys.Back
                    If TxT.Text.Length > 0 Then
                        If TxT.SelectionStart > 0 Then
                            TxT.SelectionStart = TxT.SelectionStart - 1
                            TxT.Select(TxT.SelectionStart, TxT.SelectionLength + 1)
                        End If
                    End If
            End Select
        Else
            Select Case e.KeyCode
                Case Keys.Up
                    If FGrid.Row > 1 Then
                        If FGrid.Col = Column.Credit Or FGrid.Col = Column.Debit Then
                            FGrid.Text = Format(Val(TxT.Text), "0.00")
                        Else
                            FGrid.Text = TxT.Text
                        End If
                        FGrid.Row -= 1
                    End If
                Case Keys.Down
                    If FGrid.Row < FGrid.Rows - 1 Then
                        If FGrid.Col = Column.Credit Or FGrid.Col = Column.Debit Then
                            FGrid.Text = Format(Val(TxT.Text), "0.00")
                        Else
                            FGrid.Text = TxT.Text
                        End If
                        FGrid.Row += 1
                    End If
                Case Keys.Left
                    If FGrid.Col > Column.AChead Then
                        If FGrid.Col = Column.Credit Or FGrid.Col = Column.Debit Then
                            FGrid.Text = Format(Val(TxT.Text), "0.00")
                        Else
                            FGrid.Text = TxT.Text
                        End If
                        FGrid.Col -= 1
                    End If
                Case Keys.Right
                    If FGrid.Col < Column.Narration Then
                        If FGrid.Col = Column.Credit Or FGrid.Col = Column.Debit Then
                            FGrid.Text = Format(Val(TxT.Text), "0.00")
                        Else
                            FGrid.Text = TxT.Text
                        End If
                        FGrid.Col += 1
                    End If
            End Select
        End If
    End Sub

    Private Sub LPart_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPart.SelectedIndexChanged
        TxT.Text = LPart.GetItemText(LPart.SelectedItem)
    End Sub

    Private Sub CmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDelete.Click
        If FGrid.get_TextMatrix(1, Column.AChead) = "" Then
            MsgBox("There is No Voucher To Delete", MsgBoxStyle.Critical, "Delete Voucher")
            Exit Sub
        End If
        If MsgBox("Are you sure want to Delete this Voucher?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Voucher") = MsgBoxResult.Yes Then
            Try
                If OleDbcn.State Then OleDbcn.Close()
                OleDbcn.Open()
                Dim Cmd As New OleDbCommand("DELETE * FROM GenGl WHERE Vno='" & TxTVNo.Text & "'", OleDbcn)
                Cmd.ExecuteNonQuery()
                MsgBox("Voucher Deleted Sucessfully", MsgBoxStyle.Information, "Delete")
                InitTable()
                Display(DT.Rows.Count - 1)
            Catch Ex As Exception
                MsgBox(Ex.Message)
            Finally
                OleDbcn.Close()
            End Try
        End If
    End Sub

    Private Sub TxT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxT.KeyPress
        If FGrid.Col = Column.Debit Or FGrid.Col = Column.Credit Then
            FnAmount(e, TxT.Text)
        End If
    End Sub
    Private Sub IDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles IDate.LostFocus
        TxTRef.Focus()
    End Sub
    Private Sub TxTRef_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxTRef.LostFocus
        FGrid.Col = Column.AChead
        If FGrid.Col = Column.AChead Then
            LPart.SetBounds(FGrid.Left + VB6.TwipsToPixelsX(FGrid.CellLeft), FGrid.Top + VB6.TwipsToPixelsY(FGrid.CellTop) + VB6.TwipsToPixelsY(FGrid.CellHeight), LPart.Width, LPart.Height)
            LPart.Show()
        Else
            LPart.Hide()
        End If
        TxT.SetBounds(FGrid.Left + VB6.TwipsToPixelsX(FGrid.CellLeft), FGrid.Top + VB6.TwipsToPixelsY(FGrid.CellTop), VB6.TwipsToPixelsX(FGrid.CellWidth), VB6.TwipsToPixelsY(FGrid.CellHeight))
        TxT.Show()
        TxT.Focus()
    End Sub

    Private Sub TxTRef_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxTRef.GotFocus
        TxTRef.SelectAll()
    End Sub
End Class
