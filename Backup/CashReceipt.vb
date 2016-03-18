Imports Microsoft.VisualBasic.Compatibility
Imports System.Math
Imports System.Data.OleDb
Public Class CashReceipt
    Inherits System.Windows.Forms.Form
    Dim OleCon As OleDbConnection
    Dim OleDa As OleDbDataAdapter
    Dim OleNarr As OleDbDataAdapter
    Dim OleAc As OleDbDataAdapter
    Dim Ds As New DataSet
    Dim Dt As New DataTable
    Dim Dst As New DataSet
    Dim DtRow As Long
    Dim Opr As Operation
    Dim StrVno As String
    Dim CallFromAcExt As Boolean
    Dim Flag As Boolean = False
    Enum Operation
        None = 0
        Add = 1
        Edit = 2
        search = 3
    End Enum
    Private Sub EnaDis(ByVal Flag As Boolean)
        Panel1.Enabled = Flag
        Panel3.Enabled = Flag
    End Sub
    Private Enum Column
        SrNo = 0
        DC = 1
        AcName = 2
        Amt = 3
        Narr = 4
    End Enum
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
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub
    Public Sub New(ByVal iStrVno As String, ByVal StrVType As String)
        MyBase.New()
        InitializeComponent()
        CallFromAcExt = True
        StrVno = iStrVno
        Me.Tag = StrVType
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents TxTVNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxTRefNo As System.Windows.Forms.TextBox
    Friend WithEvents ToolTipC As System.Windows.Forms.ToolTip
    Friend WithEvents CmbNarration As System.Windows.Forms.ComboBox
    Friend WithEvents BPanel As System.Windows.Forms.Panel
    Friend WithEvents CmdHelp As System.Windows.Forms.Button
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents CmdEdit As System.Windows.Forms.Button
    Friend WithEvents CmdSearch As System.Windows.Forms.Button
    Friend WithEvents CmdDelete As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents CmbBnk As System.Windows.Forms.ComboBox
    Friend WithEvents TxT As System.Windows.Forms.TextBox
    Friend WithEvents Fgrid As AxMSFlexGridLib.AxMSFlexGrid
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LBLAmt As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LPart As System.Windows.Forms.ListBox
    Friend WithEvents CmdCopy As System.Windows.Forms.Button
    Friend WithEvents IDate As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CashReceipt))
        Me.LblDisplay = New System.Windows.Forms.Label
        Me.lblDay = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbBnk = New System.Windows.Forms.ComboBox
        Me.TxTVNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.IDate = New System.Windows.Forms.DateTimePicker
        Me.CmbNarration = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxTRefNo = New System.Windows.Forms.TextBox
        Me.ToolTipC = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.TxT = New System.Windows.Forms.TextBox
        Me.Fgrid = New AxMSFlexGridLib.AxMSFlexGrid
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LBLAmt = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LPart = New System.Windows.Forms.ListBox
        Me.Panel1.SuspendLayout()
        Me.BPanel.SuspendLayout()
        CType(Me.Fgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.LblDisplay.Size = New System.Drawing.Size(712, 24)
        Me.LblDisplay.TabIndex = 0
        Me.LblDisplay.Text = "Voucher"
        Me.LblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDay
        '
        Me.lblDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDay.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(472, 16)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(120, 16)
        Me.lblDay.TabIndex = 5
        Me.lblDay.Text = "Date : "
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Voucher Number:"
        '
        'CmbBnk
        '
        Me.CmbBnk.BackColor = System.Drawing.Color.White
        Me.CmbBnk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBnk.Location = New System.Drawing.Point(168, 56)
        Me.CmbBnk.Name = "CmbBnk"
        Me.CmbBnk.Size = New System.Drawing.Size(336, 24)
        Me.CmbBnk.TabIndex = 2
        Me.ToolTipC.SetToolTip(Me.CmbBnk, "Select Party Account Number From Here")
        '
        'TxTVNo
        '
        Me.TxTVNo.BackColor = System.Drawing.Color.White
        Me.TxTVNo.Enabled = False
        Me.TxTVNo.Location = New System.Drawing.Point(168, 8)
        Me.TxTVNo.Name = "TxTVNo"
        Me.TxTVNo.Size = New System.Drawing.Size(104, 23)
        Me.TxTVNo.TabIndex = 7
        Me.TxTVNo.TabStop = False
        Me.TxTVNo.Text = ""
        Me.TxTVNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cash/Bank"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Narration"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.IDate)
        Me.Panel1.Controls.Add(Me.CmbNarration)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxTRefNo)
        Me.Panel1.Controls.Add(Me.lblDay)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxTVNo)
        Me.Panel1.Controls.Add(Me.CmbBnk)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(712, 112)
        Me.Panel1.TabIndex = 1
        '
        'IDate
        '
        Me.IDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IDate.CustomFormat = "dd/MM/yyyy"
        Me.IDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.IDate.Location = New System.Drawing.Point(592, 13)
        Me.IDate.Name = "IDate"
        Me.IDate.Size = New System.Drawing.Size(104, 23)
        Me.IDate.TabIndex = 0
        '
        'CmbNarration
        '
        Me.CmbNarration.BackColor = System.Drawing.Color.White
        Me.CmbNarration.Location = New System.Drawing.Point(168, 80)
        Me.CmbNarration.Name = "CmbNarration"
        Me.CmbNarration.Size = New System.Drawing.Size(336, 24)
        Me.CmbNarration.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Reference Number"
        '
        'TxTRefNo
        '
        Me.TxTRefNo.BackColor = System.Drawing.Color.White
        Me.TxTRefNo.Location = New System.Drawing.Point(168, 32)
        Me.TxTRefNo.Name = "TxTRefNo"
        Me.TxTRefNo.Size = New System.Drawing.Size(104, 23)
        Me.TxTRefNo.TabIndex = 1
        Me.TxTRefNo.Text = ""
        Me.TxTRefNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipC.SetToolTip(Me.TxTRefNo, "Please Enter Reference Number Here")
        '
        'ToolTipC
        '
        Me.ToolTipC.ShowAlways = True
        '
        'BPanel
        '
        Me.BPanel.BackColor = System.Drawing.Color.Ivory
        Me.BPanel.Controls.Add(Me.CmdCopy)
        Me.BPanel.Controls.Add(Me.CmdHelp)
        Me.BPanel.Controls.Add(Me.CmdCancel)
        Me.BPanel.Controls.Add(Me.CmdExit)
        Me.BPanel.Controls.Add(Me.CmdSave)
        Me.BPanel.Controls.Add(Me.CmdEdit)
        Me.BPanel.Controls.Add(Me.CmdSearch)
        Me.BPanel.Controls.Add(Me.CmdDelete)
        Me.BPanel.Controls.Add(Me.CmdAdd)
        Me.BPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.BPanel.Location = New System.Drawing.Point(620, 136)
        Me.BPanel.Name = "BPanel"
        Me.BPanel.Size = New System.Drawing.Size(92, 309)
        Me.BPanel.TabIndex = 10
        '
        'CmdCopy
        '
        Me.CmdCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdCopy.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CmdCopy.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCopy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmdCopy.Location = New System.Drawing.Point(8, 240)
        Me.CmdCopy.Name = "CmdCopy"
        Me.CmdCopy.TabIndex = 8
        Me.CmdCopy.Text = "C&opy"
        Me.CmdCopy.Visible = False
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
        Me.CmdSave.TabIndex = 1
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
        Me.CmdEdit.TabIndex = 2
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
        Me.CmdSearch.TabIndex = 4
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
        Me.CmdDelete.TabIndex = 3
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
        'TxT
        '
        Me.TxT.AutoSize = False
        Me.TxT.BackColor = System.Drawing.Color.LemonChiffon
        Me.TxT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxT.Location = New System.Drawing.Point(88, 48)
        Me.TxT.Name = "TxT"
        Me.TxT.Size = New System.Drawing.Size(208, 16)
        Me.TxT.TabIndex = 1
        Me.TxT.Text = ""
        Me.TxT.Visible = False
        Me.TxT.WordWrap = False
        '
        'Fgrid
        '
        Me.Fgrid.ContainingControl = Me
        Me.Fgrid.Location = New System.Drawing.Point(0, 0)
        Me.Fgrid.Name = "Fgrid"
        Me.Fgrid.OcxState = CType(resources.GetObject("Fgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Fgrid.Size = New System.Drawing.Size(712, 248)
        Me.Fgrid.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.LBLAmt)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 445)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(712, 32)
        Me.Panel2.TabIndex = 4
        '
        'LBLAmt
        '
        Me.LBLAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LBLAmt.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LBLAmt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LBLAmt.Location = New System.Drawing.Point(312, 8)
        Me.LBLAmt.Name = "LBLAmt"
        Me.LBLAmt.Size = New System.Drawing.Size(128, 16)
        Me.LBLAmt.TabIndex = 0
        Me.LBLAmt.Text = "0.00"
        Me.LBLAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Ivory
        Me.Panel3.Controls.Add(Me.LPart)
        Me.Panel3.Controls.Add(Me.TxT)
        Me.Panel3.Controls.Add(Me.Fgrid)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 136)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(620, 309)
        Me.Panel3.TabIndex = 2
        '
        'LPart
        '
        Me.LPart.BackColor = System.Drawing.Color.LemonChiffon
        Me.LPart.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LPart.ItemHeight = 16
        Me.LPart.Location = New System.Drawing.Point(80, 72)
        Me.LPart.Name = "LPart"
        Me.LPart.Size = New System.Drawing.Size(232, 112)
        Me.LPart.TabIndex = 2
        '
        'CashReceipt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(712, 477)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblDisplay)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "CashReceipt"
        Me.Text = "Voucher"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.BPanel.ResumeLayout(False)
        CType(Me.Fgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub IDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblDay.Text = Format(IDate.Value, "ddddd")
    End Sub
    Private Sub CashReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IDate.MinDate = FromDate
        IDate.MaxDate = ToDate
        If Today >= FromDate And Today <= ToDate Then
            IDate.Value = Today()
        End If
        LPart.Visible = False
        TxT.Visible = False
        LblDisplay.Text = Me.Text
        OleCon = New OleDbConnection(ConStr)
        OleCon.Open()
        OleDa = New OleDbDataAdapter("SELECT GlCode,Part FROM GLMast WHERE IndCode='BB' ORDER BY pART", OleCon)
        OleNarr = New OleDbDataAdapter("SELECT Distinct(Part) as N FROm GenGL", OleCon)
        OleAc = New OleDbDataAdapter("SELECT GlCode,Part FROM GlMast ORDER BY PART", OleCon)
        OleDa.Fill(Ds, "GlMast")
        OleNarr.Fill(Ds, "Narr")
        OleAc.Fill(Ds, "Acc")
        CmbBnk.DataSource = Ds
        CmbNarration.DataSource = Ds
        LPart.DataSource = Ds
        CmbBnk.DisplayMember = "GlMast.Part"
        CmbBnk.ValueMember = "GlMast.GlCode"
        CmbNarration.DisplayMember = "Narr.N"
        LPart.DisplayMember = "Acc.Part"
        LPart.ValueMember = "Acc.GlCode"
        OleCon.Close()
        InitGrid()
        Fgrid.set_ColWidth(Column.DC, 0)
        E_D(True)
        EnaDis(False)
        InitTable()
        If CallFromAcExt = True Then
            SearchDisplay(StrVno)
        Else
            If Dt.Rows.Count > 0 Then
                DtRow = Dt.Rows.Count - 1
                Display(DtRow)
            End If
        End If
    End Sub
    Private Sub CashReceipt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'If CallFromAcExt = True Then
        '    CallFromAcExt = False
        '    If e.KeyCode = Keys.Back Then
        '        Close()
        '    End If
        'End If
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
                        If Dt.Rows.Count > 0 Then
                            DtRow = 0
                            Display(DtRow)
                        End If
                    Case ModMain.Navigation.MovePrevious
                        If DtRow > 0 Then
                            DtRow = DtRow - 1
                            Display(DtRow)
                        End If
                    Case ModMain.Navigation.MoveNext
                        If DtRow < Dt.Rows.Count - 1 Then
                            DtRow = DtRow + 1
                            Display(DtRow)
                        End If
                    Case ModMain.Navigation.MoveLast
                        If Dt.Rows.Count > 0 Then
                            DtRow = Dt.Rows.Count - 1
                            Display(DtRow)
                        End If
                End Select
        End Select
    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Close()
    End Sub
    Private Sub TxT_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxT.GotFocus
        TxT.Text = Fgrid.Text
        TxT.SelectAll()
    End Sub
    Private Sub InitGrid()
        Dim i As Int16
        Fgrid.Rows = 2
        For i = 0 To Fgrid.Cols - 1
            Fgrid.set_TextMatrix(1, i, "")
        Next
    End Sub
    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        E_D(False)
        EnaDis(True)
        Fgrid.Enabled = False
        Opr = Operation.Add
        If Today >= FromDate And Today <= ToDate Then
            IDate.Value = Today
        End If
        CmbBnk.SelectedIndex = -1
        TxTRefNo.Text = ""
        CmbNarration.Text = ""
        TxTVNo.Text = Vno(Me.Tag)
        InitGrid()
        IDate.Focus()
    End Sub
    Private Sub Fgrid_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fgrid.EnterCell
        Fgrid.set_TextMatrix(Fgrid.Row, Column.SrNo, Fgrid.Row)
        If Flag = True Or Fgrid.Col = Column.SrNo Then Exit Sub
        TxT.Text = Fgrid.Text
        TxT.SelectAll()
        If Fgrid.Col = Column.AcName Then
            If LPart.FindStringExact(TxT.Text) = -1 Then
                If LPart.Items.Count > 0 Then
                    LPart.SelectedIndex = 0
                    TxT.Text = LPart.GetItemText(LPart.SelectedItem)
                End If
            End If
            LPart.SetBounds(Fgrid.Left + VB6.TwipsToPixelsX(Fgrid.CellLeft), Fgrid.Top + VB6.TwipsToPixelsY(Fgrid.CellTop) + VB6.TwipsToPixelsY(Fgrid.CellHeight), LPart.Width, LPart.Height)
            LPart.Show()
        Else
            LPart.Hide()
        End If
        TxT.SetBounds(Fgrid.Left + VB6.TwipsToPixelsX(Fgrid.CellLeft), Fgrid.Top + VB6.TwipsToPixelsY(Fgrid.CellTop), VB6.TwipsToPixelsX(Fgrid.CellWidth), VB6.TwipsToPixelsY(Fgrid.CellHeight))
        TxT.Show()
        TxT.Focus()
    End Sub
    Private Sub CmbBnk_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbBnk.GotFocus
        SendKeys.Send("{f4}")
    End Sub
    Private Sub CmbNarration_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbNarration.GotFocus
        SendKeys.Send("{F4}")
        Fgrid.Enabled = True
    End Sub

    Private Sub CmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEdit.Click
        CmdCopy.Visible = True
        E_D(False)
        EnaDis(True)
        Opr = Operation.Edit
        IDate.Focus()
    End Sub

    Private Sub CmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSave.Click
        TxT.Hide()
        CmdCopy.Visible = False
        Dim i As Integer
        If CmbBnk.SelectedIndex = -1 Then
            MsgBox("Please Select Cash/Bank Account")
            CmbBnk.Focus()
            Exit Sub
        End If
        For i = 1 To Fgrid.Rows - 1
            If Fgrid.get_TextMatrix(i, Column.AcName) = "" Then
                MsgBox("Can not Save Empty Record !!!", MsgBoxStyle.Information, "can't Save")
                Fgrid.Row = i
                Fgrid.Col = Column.AcName
                Fgrid.Focus()
                Exit Sub
            End If
        Next
        For i = 1 To Fgrid.Rows - 1
            If Not Val(Fgrid.get_TextMatrix(i, Column.Amt)) > 0 Then
                MsgBox("Invalid Amount !!!", MsgBoxStyle.Information, "can't Save")
                Fgrid.Row = i
                Fgrid.Col = Column.AcName
                Fgrid.Focus()
                Exit Sub
            End If
        Next
        Dim adp As OleDbDataAdapter
        Dim ds As New DataSet
        Dim acb As OleDbCommandBuilder
        Dim dr As DataRow
        Dim StrVNo As String
        Dim Sum As Double
        If Opr = Operation.Edit Then
            Dim CmdDelete As New OleDbCommand
            Try
                If OleCon.State Then OleCon.Close()
                OleCon.Open()
                CmdDelete.CommandText = "DELETE * FROM GenGl Where Vno='" & TxTVNo.Text & "'"
                CmdDelete.Connection = OleCon
                CmdDelete.ExecuteNonQuery()
                OleCon.Close()
            Catch Ex2 As Exception
                MsgBox(Ex2.Message)
                OleCon.Close()
                Exit Sub
            End Try
        End If
        Try
            If OleCon.State Then OleCon.Close()
            OleCon.Open()
            adp = New OleDbDataAdapter("Select Vno,RefNo,TDate,Part,Amt,GlCode,Book,UserID,Head from GenGL", OleCon)
            adp.Fill(ds, "G")
            acb = New OleDbCommandBuilder(adp)
            If Opr = Operation.Add Then
                StrVNo = Vno(Me.Tag)
            Else
                StrVNo = TxTVNo.Text
            End If
            'Head Section
            dr = ds.Tables("G").NewRow
            dr("Vno") = StrVNo
            dr("RefNo") = TxTRefNo.Text
            dr("TDate") = IDate.Value
            dr("Part") = CmbNarration.Text
            For i = 1 To Fgrid.Rows - 1
                Sum += Fgrid.get_TextMatrix(i, Column.Amt)
            Next
            If Me.Tag = "RV" Then
                dr("Amt") = Sum
            Else
                dr("Amt") = -1 * Sum
            End If
            dr("GlCode") = CmbBnk.SelectedValue
            dr("Book") = Me.Tag
            dr("UserID") = imUser.GetUserID
            dr("Head") = 0
            ds.Tables("G").Rows.Add(dr)
            'Tail Section
            For i = 1 To Fgrid.Rows - 1
                dr = ds.Tables("G").NewRow
                dr("Vno") = StrVNo
                dr("RefNo") = TxTRefNo.Text
                dr("TDate") = IDate.Value
                dr("Part") = Fgrid.get_TextMatrix(i, Column.Narr)
                If Me.Tag = "PV" Then
                    dr("Amt") = Val(Fgrid.get_TextMatrix(i, Column.Amt))
                Else
                    dr("Amt") = -1 * Val(Fgrid.get_TextMatrix(i, Column.Amt))
                End If
                dr("GlCode") = CInt(Fgrid.get_TextMatrix(i, Column.DC))
                dr("Book") = Me.Tag
                dr("UserID") = imUser.GetUserID
                dr("Head") = i
                ds.Tables("G").Rows.Add(dr)
            Next
            adp.Update(ds, "G")
            MsgBox("Record Saved Sucessfully", MsgBoxStyle.Information, "Save")
            Opr = Operation.None
            E_D(True)
            EnaDis(False)
            InitTable()
            If Dt.Rows.Count > 0 Then
                DtRow = Dt.Rows.Count - 1
                Display(DtRow)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Opr = Operation.None
            OleCon.Close()
        End Try
    End Sub

    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        CmdCopy.Visible = False
        E_D(True)
        EnaDis(False)
        Opr = Operation.None
        If Dt.Rows.Count > 0 Then
            DtRow = Dt.Rows.Count - 1
            Display(DtRow)
        End If
    End Sub
    Public Sub InitTable()
        Dim OleDa As OleDbDataAdapter
        If OleCon.State Then OleCon.Close()
        OleCon.Open()
        OleDa = New OleDbDataAdapter("SELECT Vno FROM GenGl WHERE Book='" & Me.Tag & "' Group By Vno,TDate Order by vno,Tdate", OleCon)
        Dst.Clear()
        OleDa.Fill(Dst, "ABC")
        Dt = Dst.Tables("ABC")
        If Dt.Rows.Count > 0 Then
            DtRow = 0
        Else
            DtRow = -1
        End If
        OleCon.Close()
    End Sub
    Private Sub SearchDisplay(ByVal StrVno As String)
        Dim Dr As OleDbDataReader
        Dim cmd As OleDbCommand
        Dim Sum As Double
        Dim I As Int16
        If OleCon.State Then OleCon.Close()
        OleCon.Open()
        cmd = New OleDbCommand("SELECT * From GenGl WHERE Vno='" & StrVno & "' order by Head", OleCon)
        Dr = cmd.ExecuteReader
        Flag = True
        TxTVNo.Text = StrVno
        If Dr.HasRows = True Then
            Fgrid.Rows = 2
            For I = 0 To Fgrid.Cols - 1
                Fgrid.set_TextMatrix(1, I, "")
            Next
            Fgrid.Row = 1
            While Dr.Read
                If Dr.Item("Head") = 0 Then
                    CmbBnk.SelectedValue = Dr.Item("GlCode")
                    CmbNarration.Text = Dr.Item("Part")
                    IDate.Value = Dr.Item("TDate")
                    TxTRefNo.Text = IIf(IsDBNull(Dr.Item("RefNo")), "", Dr.Item("RefNo"))
                Else
                    LPart.SelectedValue = Dr.Item("GlCode")
                    Fgrid.set_TextMatrix(Fgrid.Row, Column.AcName, LPart.GetItemText(LPart.SelectedItem))
                    Fgrid.set_TextMatrix(Fgrid.Row, Column.DC, LPart.SelectedValue)
                    Fgrid.set_TextMatrix(Fgrid.Row, Column.Amt, Format(Abs(Val(Dr.Item("Amt"))), "0.00"))
                    Fgrid.set_TextMatrix(Fgrid.Row, Column.Narr, Dr.Item("Part"))
                    Fgrid.AddItem("")
                    Fgrid.Row = Fgrid.Row + 1
                End If
            End While
            Fgrid.RemoveItem(Fgrid.Rows - 1)
            For I = 1 To Fgrid.Rows - 1
                Sum += Val(Fgrid.get_TextMatrix(I, Column.Amt))
            Next
            LBLAmt.Text = Format(Sum, "0.00")
            OleCon.Close()
        End If
        Flag = False
    End Sub
    Public Sub Display(ByVal Pos As Long)
        Dim Dr As OleDbDataReader
        Dim cmd As OleDbCommand
        Dim Sum As Double
        Dim I As Int16
        If Dt.Rows.Count > 0 Then
            If OleCon.State Then OleCon.Close()
            OleCon.Open()
            cmd = New OleDbCommand("SELECT * From GenGl WHERE Vno='" & Dt.Rows(Pos).Item(0) & "' order by Head", OleCon)
            Dr = cmd.ExecuteReader
            Flag = True
            TxTVNo.Text = CType(Dt.Rows(Pos).Item(0), String)
            If Dr.HasRows = True Then
                Fgrid.Rows = 2
                For I = 0 To Fgrid.Cols - 1
                    Fgrid.set_TextMatrix(1, I, "")
                Next
                Fgrid.Row = 1
                While Dr.Read
                    If Dr.Item("Head") = 0 Then
                        CmbBnk.SelectedValue = Dr.Item("GlCode")
                        CmbNarration.Text = IIf(IsDBNull(Dr.Item("Part")), "", Dr.Item("Part"))
                        IDate.Value = Dr.Item("TDate")
                        TxTRefNo.Text = IIf(IsDBNull(Dr.Item("RefNo")), "", Dr.Item("RefNo"))
                    Else
                        LPart.SelectedValue = Dr.Item("GlCode")
                        Fgrid.set_TextMatrix(Fgrid.Row, Column.AcName, LPart.GetItemText(LPart.SelectedItem))
                        Fgrid.set_TextMatrix(Fgrid.Row, Column.DC, LPart.SelectedValue)
                        Fgrid.set_TextMatrix(Fgrid.Row, Column.Amt, Format(Abs(Val(Dr.Item("Amt"))), "0.00"))
                        Fgrid.set_TextMatrix(Fgrid.Row, Column.Narr, IIf(IsDBNull(Dr.Item("Part")), "", Dr.Item("Part")))
                        Fgrid.AddItem("")
                        Fgrid.Row = Fgrid.Row + 1
                    End If
                End While
                If Fgrid.Rows > 2 Then
                    Fgrid.RemoveItem(Fgrid.Rows - 1)
                End If
                For I = 1 To Fgrid.Rows - 1
                    Sum += Val(Fgrid.get_TextMatrix(I, Column.Amt))
                Next
                LBLAmt.Text = Format(Sum, "0.00")
            End If
        End If
        Flag = False
    End Sub

    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        Dim StrSql As String
        Opr = Operation.search
        StrSql = "SELECT Gl.Vno AS VNo,Gl.RefNo, Gm.Part AS AcHead, FORMAT(Gl.TDate,'dd/MM/yyyy') AS TDate, GL.Amt, Gl.Part AS Narr FROM GenGL Gl, GlMast Gm WHERE Gl.GlCode=Gm.GlCode AND Gl.Book='" & Me.Tag & "' AND  Gl.Vno & Gl.RefNo & Gm.Part & Gl.TDate & Gl.Amt & Gl.Part Like"
        Dim StrCF As CallFrom
        If Me.Tag = "RV" Then
            StrCF = ModMain.CallFrom.ReceiptVoucher
        Else
            StrCF = ModMain.CallFrom.PaymentVoucher
        End If
        Dim NewSearch As New FrmSearch(StrCF, StrSql)
        NewSearch.Tag = StrSql
        StrSearchResult = ""
        NewSearch.MdiParent = Me.MdiParent
        NewSearch.Show()
    End Sub
    Private Sub TxT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxT.TextChanged
        Calc()
        Dim iCol As Column = Fgrid.Col
        Select Case iCol
            Case Column.AcName
                Dim z As Int16 = TxT.Text.Length
                LPart.SelectedIndex = LPart.FindString(TxT.Text)
                LPart.TopIndex = LPart.SelectedIndex
                If LPart.SelectedIndex > -1 Then
                    TxT.Text = LPart.GetItemText(LPart.SelectedItem)
                    If TxT.Text.Length >= z Then
                        TxT.Select(z, TxT.Text.Length - z)
                    End If
                End If
        End Select
    End Sub
    Private Sub Calc()
        Dim i As Integer
        Dim Sum As Double
        For i = 1 To Fgrid.Rows - 1
            Sum += Val(Fgrid.get_TextMatrix(i, Column.Amt))
        Next
        LBLAmt.Text = Format(Sum, "0.00")
    End Sub
    Private Sub CashReceipt_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If Opr = Operation.search Then
            Opr = Operation.None
            If StrSearchResult.ToString <> "" Or StrSearchResult.ToString.Length = 6 Then
                If StrSearchResult.Substring(0, 2) = Me.Tag Then
                    SearchDisplay(StrSearchResult)
                End If
            End If
        End If
    End Sub
    Private Sub Fgrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxMSFlexGridLib.DMSFlexGridEvents_KeyDownEvent) Handles Fgrid.KeyDownEvent
        If e.keyCode = Keys.Delete Then
            If MsgBox("Are you sure want to delete current Row?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Row") = MsgBoxResult.Yes Then
                Fgrid.RemoveItem(Fgrid.RowSel)
                Calc()
            End If
        End If
    End Sub
    Private Sub LPart_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPart.SelectedIndexChanged
        TxT.Text = LPart.GetItemText(LPart.SelectedItem)
    End Sub
    Private Sub TxT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxT.KeyDown
        If Fgrid.Col = Column.AcName Then
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
                    If Fgrid.Col > Column.AcName Then
                        Fgrid.Col -= 1
                    End If
                Case Keys.Right
                    If Fgrid.Col < Column.Narr Then
                        Fgrid.Text = TxT.Text
                        Fgrid.set_TextMatrix(Fgrid.Row, Column.DC, LPart.SelectedValue)
                        Fgrid.Col += 1
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
                    If Fgrid.Row > 1 Then
                        If Fgrid.Col = Column.Amt And Val(Fgrid.Text) <= 0 Then
                            Exit Sub
                        End If
                        If Fgrid.Col = Column.Amt Then
                            Fgrid.Text = Format(Val(TxT.Text), "0.00")
                        Else
                            Fgrid.Text = TxT.Text
                        End If
                        Fgrid.Row -= 1
                    End If
                Case Keys.Down
                    If Fgrid.Row < Fgrid.Rows - 1 Then
                        If Fgrid.Col = Column.Amt Then
                            Fgrid.Text = Format(Val(TxT.Text), "0.00")
                        Else
                            Fgrid.Text = TxT.Text
                        End If
                        If Fgrid.Col = Column.Amt And Val(Fgrid.Text) <= 0 Then
                            Exit Sub
                        End If
                        Fgrid.Row += 1
                    End If
                Case Keys.Left
                    If Fgrid.Col > Column.AcName Then
                        If Fgrid.Col = Column.Amt Then
                            Fgrid.Text = Format(Val(TxT.Text), "0.00")
                        Else
                            Fgrid.Text = TxT.Text
                        End If
                        If Fgrid.Col = Column.Amt And Val(Fgrid.Text) <= 0 Then
                            Exit Sub
                        End If
                        Fgrid.Col -= 1
                    End If
                Case Keys.Right
                    If Fgrid.Col < Column.Narr Then
                        If Fgrid.Col = Column.Amt Then
                            Fgrid.Text = Format(Val(TxT.Text), "0.00")
                        Else
                            Fgrid.Text = TxT.Text
                        End If
                        If Fgrid.Col = Column.Amt And Val(Fgrid.Text) <= 0 Then
                            Exit Sub
                        End If
                        Fgrid.Col += 1
                    End If
            End Select
        End If
    End Sub

    Private Sub TxT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxT.LostFocus
        If Fgrid.Col = Column.Amt Then
            Fgrid.Text = Format(Val(TxT.Text), "0.00")
        Else
            Fgrid.Text = TxT.Text
        End If
        TxT.Hide()
        If Fgrid.Col = Column.AcName Then
            Fgrid.set_TextMatrix(Fgrid.Row, Column.DC, LPart.SelectedValue)
        End If
        If Fgrid.Col < Column.Narr Then
            Fgrid.Col = Fgrid.Col + 1
        Else
            If Fgrid.Row = Fgrid.Rows - 1 Then
                If MsgBox("Do you want to add New Record", MsgBoxStyle.YesNo, "New Record") = MsgBoxResult.Yes Then
                    Fgrid.AddItem("")
                    Fgrid.Col = Column.AcName
                    Fgrid.Row = Fgrid.Rows - 1
                End If
            End If
        End If
    End Sub
    Private Sub CmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdDelete.Click
        If Fgrid.get_TextMatrix(1, Column.AcName) = "" Then
            MsgBox("There is No Voucher To Delete", MsgBoxStyle.Critical, "Delete Voucher")
            Exit Sub
        End If
        If MsgBox("Are you sure want to Delete this Voucher?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Voucher") = MsgBoxResult.Yes Then
            Try
                If OleCon.State Then OleCon.Close()
                OleCon.Open()
                Dim Cmd As New OleDbCommand("DELETE * FROM GenGl WHERE Vno='" & TxTVNo.Text & "'", OleCon)
                Cmd.ExecuteNonQuery()
                MsgBox("Voucher Deleted Sucessfully", MsgBoxStyle.Information, "Delete")
                InitTable()
                Display(Dt.Rows.Count - 1)
            Catch Ex As Exception
                MsgBox(Ex.Message)
            Finally
                OleCon.Close()
            End Try
        End If
    End Sub

    Private Sub IDate_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxTRefNo.Focus()
    End Sub
    Private Sub CmbBnk_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbBnk.LostFocus
        CmbNarration.Focus()
    End Sub
    Private Sub CmbNarration_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbNarration.LostFocus
        'Fgrid.Col = Column.AcName
        'If Fgrid.Col = Column.AcName Then
        '    If LPart.FindStringExact(TxT.Text) = -1 Then
        '        If LPart.Items.Count > 0 Then
        '            LPart.SelectedIndex = 0
        '            TxT.Text = LPart.GetItemText(LPart.SelectedItem)
        '        End If
        '    End If
        '    LPart.SetBounds(Fgrid.Left + VB6.TwipsToPixelsX(Fgrid.CellLeft), Fgrid.Top + VB6.TwipsToPixelsY(Fgrid.CellTop) + VB6.TwipsToPixelsY(Fgrid.CellHeight), LPart.Width, LPart.Height)
        '    LPart.Show()
        'Else
        '    LPart.Hide()
        'End If
        'TxT.SetBounds(Fgrid.Left + VB6.TwipsToPixelsX(Fgrid.CellLeft), Fgrid.Top + VB6.TwipsToPixelsY(Fgrid.CellTop), VB6.TwipsToPixelsX(Fgrid.CellWidth), VB6.TwipsToPixelsY(Fgrid.CellHeight))
        'TxT.Show()
        'TxT.Focus()
    End Sub

    Private Sub TxT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxT.KeyPress
        If Fgrid.Col = Column.Amt Then
            FnAmount(e, TxT.Text)
        End If
    End Sub
    Private Sub Fgrid_LeaveCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fgrid.LeaveCell
        'If Fgrid.Col = Column.Amt Then
        '    Fgrid.Text = Format(Val(TxT.Text), "0.00")
        'Else
        '    Fgrid.Text = TxT.Text
        'End If
        'TxT.Hide()
        'If Fgrid.Col = Column.AcName Then
        '    Fgrid.set_TextMatrix(Fgrid.Row, Column.DC, LPart.SelectedValue)
        'End If
        'If Fgrid.Col < Column.Narr Then
        '    Fgrid.Col = Fgrid.Col + 1
        'Else
        '    If Fgrid.Row = Fgrid.Rows - 1 Then
        '        If MsgBox("Do you want to add New Record", MsgBoxStyle.YesNo, "New Record") = MsgBoxResult.Yes Then
        '            Fgrid.AddItem("")
        '            Fgrid.Col = Column.AcName
        '            Fgrid.Row = Fgrid.Rows - 1
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub CmbNarration_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbNarration.SelectedIndexChanged

    End Sub

    Private Sub CmbNarration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbNarration.KeyDown
        If e.KeyCode = Keys.Enter Then
            Fgrid.Col = Column.AcName
        End If
    End Sub

    Private Sub CmdCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Fgrid_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fgrid.Enter

    End Sub
End Class
