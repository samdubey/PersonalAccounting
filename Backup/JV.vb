Imports Microsoft.VisualBasic.Compatibility
Imports System.Data.OleDb
Public Class JV
    Inherits System.Windows.Forms.Form
    Enum Column
        SrNo
        AcHead
        Debit
        Credit
        Narration
        GlCode
    End Enum
    Dim Con As OleDbConnection
    Dim Da As OleDbDataAdapter
    Dim Ds As New DataSet
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
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LblDisplay As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxTRef As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxTVNo As System.Windows.Forms.TextBox
    Friend WithEvents IDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LBLCr As System.Windows.Forms.Label
    Friend WithEvents LBLDr As System.Windows.Forms.Label
    Friend WithEvents BPanel As System.Windows.Forms.Panel
    Friend WithEvents CmdHelp As System.Windows.Forms.Button
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents CmdEdit As System.Windows.Forms.Button
    Friend WithEvents CmdSearch As System.Windows.Forms.Button
    Friend WithEvents CmdDelete As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents TxT As System.Windows.Forms.TextBox
    Friend WithEvents FGrid As AxMSFlexGridLib.AxMSFlexGrid
    Friend WithEvents LPart As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(JV))
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LPart = New System.Windows.Forms.ListBox
        Me.TxT = New System.Windows.Forms.TextBox
        Me.FGrid = New AxMSFlexGridLib.AxMSFlexGrid
        Me.LblDisplay = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxTRef = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxTVNo = New System.Windows.Forms.TextBox
        Me.IDate = New System.Windows.Forms.DateTimePicker
        Me.lblDay = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LBLCr = New System.Windows.Forms.Label
        Me.LBLDr = New System.Windows.Forms.Label
        Me.BPanel = New System.Windows.Forms.Panel
        Me.CmdHelp = New System.Windows.Forms.Button
        Me.CmdCancel = New System.Windows.Forms.Button
        Me.CmdExit = New System.Windows.Forms.Button
        Me.CmdSave = New System.Windows.Forms.Button
        Me.CmdEdit = New System.Windows.Forms.Button
        Me.CmdSearch = New System.Windows.Forms.Button
        Me.CmdDelete = New System.Windows.Forms.Button
        Me.CmdAdd = New System.Windows.Forms.Button
        Me.Panel3.SuspendLayout()
        CType(Me.FGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.BPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LPart)
        Me.Panel3.Controls.Add(Me.TxT)
        Me.Panel3.Controls.Add(Me.FGrid)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 89)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(652, 367)
        Me.Panel3.TabIndex = 20
        '
        'LPart
        '
        Me.LPart.BackColor = System.Drawing.Color.LemonChiffon
        Me.LPart.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LPart.Location = New System.Drawing.Point(64, 112)
        Me.LPart.Name = "LPart"
        Me.LPart.Size = New System.Drawing.Size(232, 117)
        Me.LPart.TabIndex = 16
        '
        'TxT
        '
        Me.TxT.AutoSize = False
        Me.TxT.BackColor = System.Drawing.Color.LemonChiffon
        Me.TxT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxT.Location = New System.Drawing.Point(32, 64)
        Me.TxT.Name = "TxT"
        Me.TxT.Size = New System.Drawing.Size(216, 16)
        Me.TxT.TabIndex = 14
        Me.TxT.Text = ""
        '
        'FGrid
        '
        Me.FGrid.ContainingControl = Me
        Me.FGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FGrid.Location = New System.Drawing.Point(0, 0)
        Me.FGrid.Name = "FGrid"
        Me.FGrid.OcxState = CType(resources.GetObject("FGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FGrid.Size = New System.Drawing.Size(652, 367)
        Me.FGrid.TabIndex = 15
        '
        'LblDisplay
        '
        Me.LblDisplay.BackColor = System.Drawing.Color.Gray
        Me.LblDisplay.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblDisplay.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LblDisplay.ForeColor = System.Drawing.Color.White
        Me.LblDisplay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblDisplay.Location = New System.Drawing.Point(0, 0)
        Me.LblDisplay.Name = "LblDisplay"
        Me.LblDisplay.Size = New System.Drawing.Size(744, 24)
        Me.LblDisplay.TabIndex = 18
        Me.LblDisplay.Text = "Journal Voucher"
        Me.LblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxTRef)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxTVNo)
        Me.Panel1.Controls.Add(Me.IDate)
        Me.Panel1.Controls.Add(Me.lblDay)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(652, 65)
        Me.Panel1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(8, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Refrence Number:"
        '
        'TxTRef
        '
        Me.TxTRef.BackColor = System.Drawing.Color.White
        Me.TxTRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTRef.Location = New System.Drawing.Point(128, 34)
        Me.TxTRef.Name = "TxTRef"
        Me.TxTRef.Size = New System.Drawing.Size(96, 20)
        Me.TxTRef.TabIndex = 0
        Me.TxTRef.TabStop = False
        Me.TxTRef.Text = ""
        Me.TxTRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Voucher Number:"
        '
        'TxTVNo
        '
        Me.TxTVNo.BackColor = System.Drawing.Color.White
        Me.TxTVNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTVNo.Enabled = False
        Me.TxTVNo.Location = New System.Drawing.Point(128, 8)
        Me.TxTVNo.Name = "TxTVNo"
        Me.TxTVNo.Size = New System.Drawing.Size(96, 20)
        Me.TxTVNo.TabIndex = 7
        Me.TxTVNo.TabStop = False
        Me.TxTVNo.Text = ""
        Me.TxTVNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'IDate
        '
        Me.IDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IDate.CustomFormat = "dd/MM/yyyy"
        Me.IDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.IDate.Location = New System.Drawing.Point(550, 8)
        Me.IDate.Name = "IDate"
        Me.IDate.ShowUpDown = True
        Me.IDate.Size = New System.Drawing.Size(88, 20)
        Me.IDate.TabIndex = 0
        Me.IDate.Value = New Date(2006, 5, 18, 10, 0, 43, 453)
        '
        'lblDay
        '
        Me.lblDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDay.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblDay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDay.Location = New System.Drawing.Point(422, 8)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(120, 16)
        Me.lblDay.TabIndex = 1
        Me.lblDay.Text = "Date : "
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.LBLCr)
        Me.Panel2.Controls.Add(Me.LBLDr)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 458)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(652, 19)
        Me.Panel2.TabIndex = 19
        '
        'LBLCr
        '
        Me.LBLCr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LBLCr.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LBLCr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LBLCr.Location = New System.Drawing.Point(384, 0)
        Me.LBLCr.Name = "LBLCr"
        Me.LBLCr.Size = New System.Drawing.Size(96, 16)
        Me.LBLCr.TabIndex = 1
        Me.LBLCr.Text = "0.00"
        Me.LBLCr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LBLDr
        '
        Me.LBLDr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLDr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LBLDr.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LBLDr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LBLDr.Location = New System.Drawing.Point(280, 0)
        Me.LBLDr.Name = "LBLDr"
        Me.LBLDr.Size = New System.Drawing.Size(96, 16)
        Me.LBLDr.TabIndex = 0
        Me.LBLDr.Text = "0.00"
        Me.LBLDr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BPanel
        '
        Me.BPanel.BackColor = System.Drawing.Color.Linen
        Me.BPanel.Controls.Add(Me.CmdHelp)
        Me.BPanel.Controls.Add(Me.CmdCancel)
        Me.BPanel.Controls.Add(Me.CmdExit)
        Me.BPanel.Controls.Add(Me.CmdSave)
        Me.BPanel.Controls.Add(Me.CmdEdit)
        Me.BPanel.Controls.Add(Me.CmdSearch)
        Me.BPanel.Controls.Add(Me.CmdDelete)
        Me.BPanel.Controls.Add(Me.CmdAdd)
        Me.BPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.BPanel.Location = New System.Drawing.Point(652, 24)
        Me.BPanel.Name = "BPanel"
        Me.BPanel.Size = New System.Drawing.Size(92, 453)
        Me.BPanel.TabIndex = 17
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
        Me.CmdSearch.Text = "S&earch"
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
        'JV
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(744, 477)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BPanel)
        Me.Controls.Add(Me.LblDisplay)
        Me.Name = "JV"
        Me.Text = "JV"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        CType(Me.FGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.BPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub JV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Con = New OleDbConnection(ConStr)
        Da = New OleDbDataAdapter("SELECT Part,GlCode FROM GLMast", Con)
        Con.Open()
        Da.Fill(Ds, "A")
        LPart.DataSource = Ds
        LPart.DisplayMember = "A.Part"
        LPart.ValueMember = "A.GlCode"
        Con.Close()
        LPart.Hide()
        TxT.Hide()
        FGrid.set_ColWidth(Column.GlCode, 0)
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Close()
    End Sub
    Private Sub TxT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxT.TextChanged
        Dim iCol As Column = FGrid.Col
        Select Case iCol
            Case Column.AcHead
                Dim z As Int16 = TxT.Text.Length
                LPart.SelectedIndex = LPart.FindString(TxT.Text)
                LPart.TopIndex = LPart.SelectedIndex
                If LPart.SelectedIndex > -1 Then
                    TxT.Text = LPart.GetItemText(LPart.SelectedItem)
                    TxT.Select(z, TxT.Text.Length - z)
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

    Private Sub TxT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxT.LostFocus
        Try
            FGrid.Text = TxT.Text
            TxT.Hide()
            If FGrid.Col = Column.Credit Then
                If Not Val(TxT.Text) > 0 Then
                    If Val(FGrid.get_TextMatrix(FGrid.Row, Column.Debit)) = 0 Then
                        TxT.Show()
                        TxT.Focus()
                        Exit Sub
                    End If
                End If
            End If
            If FGrid.Col < Column.Narration Then
                FGrid.Col = FGrid.Col + 1
            Else
                If FGrid.Row = FGrid.Rows - 1 Then
                    If MsgBox("Do you want to add New Record", MsgBoxStyle.YesNo, "New Record") = MsgBoxResult.Yes Then
                        FGrid.AddItem("")
                        FGrid.Col = Column.AcHead
                        FGrid.Row = FGrid.Rows - 1
                        ' TxT.SetBounds(FGrid.Left + VB6.TwipsToPixelsX(FGrid.CellLeft), FGrid.Top + VB6.TwipsToPixelsY(FGrid.CellTop), VB6.TwipsToPixelsX(FGrid.CellWidth), VB6.TwipsToPixelsY(FGrid.CellHeight))
                        ' TxT.Show()
                        ' TxT.Focus()
                    End If
                End If
            End If
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub

    Private Sub TxT_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxT.GotFocus
        TxT.Text = FGrid.Text
        TxT.SelectAll()
    End Sub
    Private Sub FGrid_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles FGrid.EnterCell
        If FGrid.Col = Column.AcHead Then
            LPart.SetBounds(FGrid.Left + VB6.TwipsToPixelsX(FGrid.CellLeft), FGrid.Top + VB6.TwipsToPixelsY(FGrid.CellTop) + VB6.TwipsToPixelsY(FGrid.CellHeight), LPart.Width, LPart.Height)
            LPart.Show()
        Else
            LPart.Hide()
        End If
        TxT.SetBounds(FGrid.Left + VB6.TwipsToPixelsX(FGrid.CellLeft), FGrid.Top + VB6.TwipsToPixelsY(FGrid.CellTop), VB6.TwipsToPixelsX(FGrid.CellWidth), VB6.TwipsToPixelsY(FGrid.CellHeight))
        TxT.Show()
        TxT.Focus()
    End Sub
    Private Sub TxT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxT.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If FGrid.Col = Column.AcHead Then
            If e.KeyCode = Keys.Down Then
                If LPart.SelectedIndex < LPart.Items.Count - 1 Then
                    LPart.SelectedIndex += 1
                End If
            End If
            If e.KeyCode = Keys.Up Then
                If LPart.SelectedIndex > 0 Then
                    LPart.SelectedIndex -= 1
                End If
            End If
        End If
    End Sub
    Private Sub LPart_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPart.SelectedIndexChanged
        TxT.Text = LPart.GetItemText(LPart.SelectedItem)
    End Sub
    Private Sub FGrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxMSFlexGridLib.DMSFlexGridEvents_KeyDownEvent) Handles FGrid.KeyDownEvent
        FGrid.Select()
        If e.keyCode = Keys.Delete Then
            If MsgBox("Are you sure want to delete current Row?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Row") = MsgBoxResult.Yes Then
                FGrid.RemoveItem(FGrid.RowSel)
            End If
        End If
    End Sub

    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        FGrid.Col = Column.AcHead
        FGrid.Row = FGrid.Rows - 1
        TxT.SetBounds(FGrid.Left + VB6.TwipsToPixelsX(FGrid.CellLeft), FGrid.Top + VB6.TwipsToPixelsY(FGrid.CellTop), VB6.TwipsToPixelsX(FGrid.CellWidth), VB6.TwipsToPixelsY(FGrid.CellHeight))
        TxT.Show()
        TxT.Focus()
    End Sub

    Private Sub FGrid_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FGrid.Enter

    End Sub
End Class
