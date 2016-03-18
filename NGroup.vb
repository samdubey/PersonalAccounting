Public Class NGroup
    Inherits System.Windows.Forms.Form
    Dim DT As DataTable
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CmbNarration As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxTRefNo As System.Windows.Forms.TextBox
    Friend WithEvents IDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxTVNo As System.Windows.Forms.TextBox
    Friend WithEvents CmbBnk As System.Windows.Forms.ComboBox
    Friend WithEvents BPanel As System.Windows.Forms.Panel
    Friend WithEvents CmdCopy As System.Windows.Forms.Button
    Friend WithEvents CmdHelp As System.Windows.Forms.Button
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents CmdEdit As System.Windows.Forms.Button
    Friend WithEvents CmdSearch As System.Windows.Forms.Button
    Friend WithEvents CmdDelete As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents LblDisplay As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LBLAmt As System.Windows.Forms.Label
    Friend WithEvents ToolTipC As System.Windows.Forms.ToolTip
    Friend WithEvents VGrid As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents SrNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Part As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Amt As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Narr As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SGRID As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CmbNarration = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxTRefNo = New System.Windows.Forms.TextBox
        Me.IDate = New System.Windows.Forms.DateTimePicker
        Me.lblDay = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxTVNo = New System.Windows.Forms.TextBox
        Me.CmbBnk = New System.Windows.Forms.ComboBox
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
        Me.LblDisplay = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LBLAmt = New System.Windows.Forms.Label
        Me.ToolTipC = New System.Windows.Forms.ToolTip(Me.components)
        Me.SGRID = New System.Windows.Forms.DataGrid
        Me.VGrid = New System.Windows.Forms.DataGridTableStyle
        Me.SrNo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Part = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Amt = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Narr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.BPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.CmbNarration)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxTRefNo)
        Me.Panel1.Controls.Add(Me.IDate)
        Me.Panel1.Controls.Add(Me.lblDay)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxTVNo)
        Me.Panel1.Controls.Add(Me.CmbBnk)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(612, 112)
        Me.Panel1.TabIndex = 12
        '
        'CmbNarration
        '
        Me.CmbNarration.BackColor = System.Drawing.Color.White
        Me.CmbNarration.Location = New System.Drawing.Point(168, 80)
        Me.CmbNarration.Name = "CmbNarration"
        Me.CmbNarration.Size = New System.Drawing.Size(336, 21)
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
        Me.TxTRefNo.Size = New System.Drawing.Size(104, 20)
        Me.TxTRefNo.TabIndex = 1
        Me.TxTRefNo.Text = ""
        Me.TxTRefNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipC.SetToolTip(Me.TxTRefNo, "Please Enter Reference Number Here")
        '
        'IDate
        '
        Me.IDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IDate.CalendarTitleForeColor = System.Drawing.Color.White
        Me.IDate.CustomFormat = "dd/MM/yyyy"
        Me.IDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.IDate.Location = New System.Drawing.Point(500, 16)
        Me.IDate.Name = "IDate"
        Me.IDate.ShowUpDown = True
        Me.IDate.Size = New System.Drawing.Size(104, 20)
        Me.IDate.TabIndex = 0
        Me.ToolTipC.SetToolTip(Me.IDate, "Please Set Date")
        '
        'lblDay
        '
        Me.lblDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDay.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(372, 16)
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
        'TxTVNo
        '
        Me.TxTVNo.BackColor = System.Drawing.Color.White
        Me.TxTVNo.Enabled = False
        Me.TxTVNo.Location = New System.Drawing.Point(168, 8)
        Me.TxTVNo.Name = "TxTVNo"
        Me.TxTVNo.Size = New System.Drawing.Size(104, 20)
        Me.TxTVNo.TabIndex = 7
        Me.TxTVNo.TabStop = False
        Me.TxTVNo.Text = ""
        Me.TxTVNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CmbBnk
        '
        Me.CmbBnk.BackColor = System.Drawing.Color.White
        Me.CmbBnk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBnk.Location = New System.Drawing.Point(168, 56)
        Me.CmbBnk.Name = "CmbBnk"
        Me.CmbBnk.Size = New System.Drawing.Size(336, 21)
        Me.CmbBnk.TabIndex = 1
        Me.ToolTipC.SetToolTip(Me.CmbBnk, "Select Party Account Number From Here")
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
        Me.BPanel.Location = New System.Drawing.Point(612, 24)
        Me.BPanel.Name = "BPanel"
        Me.BPanel.Size = New System.Drawing.Size(92, 269)
        Me.BPanel.TabIndex = 15
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
        'LblDisplay
        '
        Me.LblDisplay.BackColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.LblDisplay.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblDisplay.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDisplay.ForeColor = System.Drawing.Color.White
        Me.LblDisplay.Location = New System.Drawing.Point(0, 0)
        Me.LblDisplay.Name = "LblDisplay"
        Me.LblDisplay.Size = New System.Drawing.Size(704, 24)
        Me.LblDisplay.TabIndex = 11
        Me.LblDisplay.Text = "Voucher"
        Me.LblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.LBLAmt)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 293)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(704, 32)
        Me.Panel2.TabIndex = 14
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
        'ToolTipC
        '
        Me.ToolTipC.ShowAlways = True
        '
        'SGRID
        '
        Me.SGRID.AlternatingBackColor = System.Drawing.Color.GhostWhite
        Me.SGRID.BackColor = System.Drawing.Color.GhostWhite
        Me.SGRID.BackgroundColor = System.Drawing.Color.Lavender
        Me.SGRID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SGRID.CaptionBackColor = System.Drawing.Color.RoyalBlue
        Me.SGRID.CaptionForeColor = System.Drawing.Color.White
        Me.SGRID.CaptionVisible = False
        Me.SGRID.DataMember = ""
        Me.SGRID.Dock = System.Windows.Forms.DockStyle.Top
        Me.SGRID.FlatMode = True
        Me.SGRID.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.SGRID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.SGRID.GridLineColor = System.Drawing.Color.RoyalBlue
        Me.SGRID.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.SGRID.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.SGRID.HeaderForeColor = System.Drawing.Color.Lavender
        Me.SGRID.LinkColor = System.Drawing.Color.Teal
        Me.SGRID.Location = New System.Drawing.Point(0, 136)
        Me.SGRID.Name = "SGRID"
        Me.SGRID.ParentRowsBackColor = System.Drawing.Color.Lavender
        Me.SGRID.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.SGRID.SelectionBackColor = System.Drawing.Color.Teal
        Me.SGRID.SelectionForeColor = System.Drawing.Color.PaleGreen
        Me.SGRID.Size = New System.Drawing.Size(612, 152)
        Me.SGRID.TabIndex = 16
        Me.SGRID.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.VGrid})
        '
        'VGrid
        '
        Me.VGrid.AlternatingBackColor = System.Drawing.Color.MintCream
        Me.VGrid.BackColor = System.Drawing.Color.LightCyan
        Me.VGrid.DataGrid = Me.SGRID
        Me.VGrid.ForeColor = System.Drawing.Color.Black
        Me.VGrid.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.SrNo, Me.Part, Me.Amt, Me.Narr})
        Me.VGrid.GridLineColor = System.Drawing.Color.Azure
        Me.VGrid.HeaderBackColor = System.Drawing.Color.Wheat
        Me.VGrid.HeaderForeColor = System.Drawing.Color.SaddleBrown
        Me.VGrid.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.VGrid.MappingName = "Tab"
        Me.VGrid.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.VGrid.SelectionForeColor = System.Drawing.Color.White
        '
        'SrNo
        '
        Me.SrNo.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.SrNo.Format = "00"
        Me.SrNo.FormatInfo = Nothing
        Me.SrNo.HeaderText = "Sr.No."
        Me.SrNo.MappingName = "SRNO"
        Me.SrNo.NullText = ""
        Me.SrNo.ReadOnly = True
        Me.SrNo.Width = 50
        '
        'Part
        '
        Me.Part.Format = ""
        Me.Part.FormatInfo = Nothing
        Me.Part.HeaderText = "Particulars"
        Me.Part.MappingName = "Part"
        Me.Part.NullText = ""
        Me.Part.Width = 200
        '
        'Amt
        '
        Me.Amt.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.Amt.Format = ""
        Me.Amt.FormatInfo = Nothing
        Me.Amt.HeaderText = "Amount "
        Me.Amt.MappingName = "Amt"
        Me.Amt.NullText = ""
        Me.Amt.Width = 75
        '
        'Narr
        '
        Me.Narr.Format = ""
        Me.Narr.FormatInfo = Nothing
        Me.Narr.HeaderText = "Narration"
        Me.Narr.MappingName = "Narr"
        Me.Narr.NullText = ""
        Me.Narr.Width = 250
        '
        'NGroup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 325)
        Me.Controls.Add(Me.SGRID)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BPanel)
        Me.Controls.Add(Me.LblDisplay)
        Me.Controls.Add(Me.Panel2)
        Me.KeyPreview = True
        Me.Name = "NGroup"
        Me.Text = "Group Creation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.BPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.SGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub NGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetGrid()
    End Sub
    Private Sub SetGrid()
        DT = New DataTable("Tab")
        Dim iCol As New DataColumn("SRNO", GetType(Int16))
        DT.Columns.Add(iCol)
        iCol = New DataColumn("Part", GetType(String))
        DT.Columns.Add(iCol)
        iCol = New DataColumn("Amt", GetType(Double))
        DT.Columns.Add(iCol)
        iCol = New DataColumn("Narr", GetType(String))
        DT.Columns.Add(iCol)
        SGRID.DataSource = DT
    End Sub

    Private Sub SGRID_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles SGRID.Navigate

    End Sub

    Private Sub SGRID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SGRID.KeyDown
        If SGRID.CurrentCell.ColumnNumber = 1 Then
            DT.NewRow()
        End If
    End Sub
End Class
