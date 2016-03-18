Imports System.Data.OleDb
Public Class FrmSearch
    Inherits System.Windows.Forms.Form
    Dim StrFindQuery As String
    Dim Con As OleDbConnection
    Dim Da As OleDbDataAdapter
    Dim Ds As New DataSet
    Dim StrCall As CallFrom
    Dim StrTab As String
#Region " Windows Form Designer generated code "
    Public Sub New()
        MyBase.new()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub
    Public Sub New(ByVal StrCallFrom As Int16, ByVal SearchSQL As String)
        MyBase.new()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        StrCall = StrCallFrom
        StrFindQuery = SearchSQL
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
    Friend WithEvents TxTSearch As System.Windows.Forms.TextBox
    Friend WithEvents CmdGo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AcMast As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents AcCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents AcHead As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Gr As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Amt As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents City As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Pin As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Tin As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents RPVoucher As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents JV As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents Vno As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents RefNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents AcH As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents IDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents AMM As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Narr As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents JVno As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents JVRefNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents JVAc As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents JVIDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CAmt As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DAmt As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents N As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxTSearch = New System.Windows.Forms.TextBox
        Me.DGrid = New System.Windows.Forms.DataGrid
        Me.AcMast = New System.Windows.Forms.DataGridTableStyle
        Me.AcCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.AcHead = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Gr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Amt = New System.Windows.Forms.DataGridTextBoxColumn
        Me.City = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Pin = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Tin = New System.Windows.Forms.DataGridTextBoxColumn
        Me.RPVoucher = New System.Windows.Forms.DataGridTableStyle
        Me.Vno = New System.Windows.Forms.DataGridTextBoxColumn
        Me.RefNo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.AcH = New System.Windows.Forms.DataGridTextBoxColumn
        Me.IDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.AMM = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Narr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.JV = New System.Windows.Forms.DataGridTableStyle
        Me.JVno = New System.Windows.Forms.DataGridTextBoxColumn
        Me.JVRefNo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.JVAc = New System.Windows.Forms.DataGridTextBoxColumn
        Me.JVIDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DAmt = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CAmt = New System.Windows.Forms.DataGridTextBoxColumn
        Me.N = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CmdGo = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.DGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxTSearch
        '
        Me.TxTSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxTSearch.BackColor = System.Drawing.Color.LightYellow
        Me.TxTSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTSearch.Location = New System.Drawing.Point(104, 8)
        Me.TxTSearch.Name = "TxTSearch"
        Me.TxTSearch.Size = New System.Drawing.Size(512, 23)
        Me.TxTSearch.TabIndex = 0
        Me.TxTSearch.Text = ""
        '
        'DGrid
        '
        Me.DGrid.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DGrid.BackgroundColor = System.Drawing.Color.FloralWhite
        Me.DGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGrid.CaptionVisible = False
        Me.DGrid.DataMember = ""
        Me.DGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGrid.Location = New System.Drawing.Point(0, 40)
        Me.DGrid.Name = "DGrid"
        Me.DGrid.ReadOnly = True
        Me.DGrid.Size = New System.Drawing.Size(754, 394)
        Me.DGrid.TabIndex = 2
        Me.DGrid.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.AcMast, Me.RPVoucher, Me.JV})
        '
        'AcMast
        '
        Me.AcMast.AlternatingBackColor = System.Drawing.Color.Khaki
        Me.AcMast.BackColor = System.Drawing.Color.LightYellow
        Me.AcMast.DataGrid = Me.DGrid
        Me.AcMast.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.AcCode, Me.AcHead, Me.Gr, Me.Amt, Me.City, Me.Pin, Me.Tin})
        Me.AcMast.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.AcMast.MappingName = "AC"
        '
        'AcCode
        '
        Me.AcCode.Format = ""
        Me.AcCode.FormatInfo = Nothing
        Me.AcCode.MappingName = "AcCode"
        Me.AcCode.NullText = ""
        Me.AcCode.Width = 0
        '
        'AcHead
        '
        Me.AcHead.Format = ""
        Me.AcHead.FormatInfo = Nothing
        Me.AcHead.HeaderText = "A/C Name"
        Me.AcHead.MappingName = "AcHead"
        Me.AcHead.NullText = ""
        Me.AcHead.Width = 200
        '
        'Gr
        '
        Me.Gr.Format = ""
        Me.Gr.FormatInfo = Nothing
        Me.Gr.HeaderText = "Group"
        Me.Gr.MappingName = "Gr"
        Me.Gr.NullText = ""
        Me.Gr.Width = 200
        '
        'Amt
        '
        Me.Amt.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.Amt.Format = ""
        Me.Amt.FormatInfo = Nothing
        Me.Amt.HeaderText = "Amount"
        Me.Amt.MappingName = "Amt"
        Me.Amt.NullText = ""
        Me.Amt.Width = 75
        '
        'City
        '
        Me.City.Format = ""
        Me.City.FormatInfo = Nothing
        Me.City.HeaderText = "City"
        Me.City.MappingName = "City"
        Me.City.NullText = ""
        Me.City.Width = 75
        '
        'Pin
        '
        Me.Pin.Format = ""
        Me.Pin.FormatInfo = Nothing
        Me.Pin.HeaderText = "Pin Code"
        Me.Pin.MappingName = "Pin"
        Me.Pin.NullText = ""
        Me.Pin.Width = 75
        '
        'Tin
        '
        Me.Tin.Format = ""
        Me.Tin.FormatInfo = Nothing
        Me.Tin.HeaderText = "Tin"
        Me.Tin.MappingName = "Tin"
        Me.Tin.NullText = ""
        Me.Tin.Width = 75
        '
        'RPVoucher
        '
        Me.RPVoucher.AlternatingBackColor = System.Drawing.Color.Khaki
        Me.RPVoucher.BackColor = System.Drawing.Color.LightYellow
        Me.RPVoucher.DataGrid = Me.DGrid
        Me.RPVoucher.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.Vno, Me.RefNo, Me.AcH, Me.IDate, Me.AMM, Me.Narr})
        Me.RPVoucher.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.RPVoucher.MappingName = "RP"
        '
        'Vno
        '
        Me.Vno.Format = ""
        Me.Vno.FormatInfo = Nothing
        Me.Vno.HeaderText = "Voucher No"
        Me.Vno.MappingName = "Vno"
        Me.Vno.Width = 75
        '
        'RefNo
        '
        Me.RefNo.Format = ""
        Me.RefNo.FormatInfo = Nothing
        Me.RefNo.HeaderText = "Ref No."
        Me.RefNo.MappingName = "RefNo"
        Me.RefNo.Width = 75
        '
        'AcH
        '
        Me.AcH.Format = ""
        Me.AcH.FormatInfo = Nothing
        Me.AcH.HeaderText = "A/c Name"
        Me.AcH.MappingName = "AcHead"
        Me.AcH.NullText = ""
        Me.AcH.Width = 200
        '
        'IDate
        '
        Me.IDate.Format = ""
        Me.IDate.FormatInfo = Nothing
        Me.IDate.HeaderText = "Date"
        Me.IDate.MappingName = "TDATE"
        Me.IDate.NullText = ""
        Me.IDate.Width = 75
        '
        'AMM
        '
        Me.AMM.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.AMM.Format = ""
        Me.AMM.FormatInfo = Nothing
        Me.AMM.HeaderText = "Amount"
        Me.AMM.MappingName = "Amt"
        Me.AMM.NullText = ""
        Me.AMM.Width = 75
        '
        'Narr
        '
        Me.Narr.Format = ""
        Me.Narr.FormatInfo = Nothing
        Me.Narr.HeaderText = "Narration"
        Me.Narr.MappingName = "Narr"
        Me.Narr.NullText = ""
        Me.Narr.Width = 200
        '
        'JV
        '
        Me.JV.AlternatingBackColor = System.Drawing.Color.Khaki
        Me.JV.BackColor = System.Drawing.Color.LightYellow
        Me.JV.DataGrid = Me.DGrid
        Me.JV.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.JVno, Me.JVRefNo, Me.JVAc, Me.JVIDate, Me.DAmt, Me.CAmt, Me.N})
        Me.JV.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.JV.MappingName = "J"
        '
        'JVno
        '
        Me.JVno.Format = ""
        Me.JVno.FormatInfo = Nothing
        Me.JVno.HeaderText = "Voucher No."
        Me.JVno.MappingName = "Vno"
        Me.JVno.NullText = ""
        Me.JVno.Width = 75
        '
        'JVRefNo
        '
        Me.JVRefNo.Format = ""
        Me.JVRefNo.FormatInfo = Nothing
        Me.JVRefNo.HeaderText = "RefNo"
        Me.JVRefNo.MappingName = "RefNo"
        Me.JVRefNo.NullText = ""
        Me.JVRefNo.Width = 75
        '
        'JVAc
        '
        Me.JVAc.Format = ""
        Me.JVAc.FormatInfo = Nothing
        Me.JVAc.HeaderText = "Particulars"
        Me.JVAc.MappingName = "AcHead"
        Me.JVAc.NullText = ""
        Me.JVAc.Width = 200
        '
        'JVIDate
        '
        Me.JVIDate.Format = ""
        Me.JVIDate.FormatInfo = Nothing
        Me.JVIDate.HeaderText = "Date"
        Me.JVIDate.MappingName = "TDate"
        Me.JVIDate.NullText = ""
        Me.JVIDate.Width = 75
        '
        'DAmt
        '
        Me.DAmt.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DAmt.Format = ""
        Me.DAmt.FormatInfo = Nothing
        Me.DAmt.HeaderText = "Debit Amt"
        Me.DAmt.MappingName = "DAmt"
        Me.DAmt.NullText = ""
        Me.DAmt.Width = 75
        '
        'CAmt
        '
        Me.CAmt.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.CAmt.Format = ""
        Me.CAmt.FormatInfo = Nothing
        Me.CAmt.HeaderText = "Credit Amt"
        Me.CAmt.MappingName = "CAmt"
        Me.CAmt.NullText = ""
        Me.CAmt.Width = 75
        '
        'N
        '
        Me.N.Format = ""
        Me.N.FormatInfo = Nothing
        Me.N.HeaderText = "Narration"
        Me.N.MappingName = "Narr"
        Me.N.NullText = ""
        Me.N.Width = 200
        '
        'CmdGo
        '
        Me.CmdGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdGo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CmdGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGo.Location = New System.Drawing.Point(624, 8)
        Me.CmdGo.Name = "CmdGo"
        Me.CmdGo.Size = New System.Drawing.Size(56, 23)
        Me.CmdGo.TabIndex = 3
        Me.CmdGo.Text = "&Go"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(686, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "E&xit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Search Text :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.CmdGo)
        Me.Panel1.Controls.Add(Me.TxTSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 40)
        Me.Panel1.TabIndex = 0
        '
        'FrmSearch
        '
        Me.AcceptButton = Me.CmdGo
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(754, 434)
        Me.Controls.Add(Me.DGrid)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmSearch"
        Me.Opacity = 0.8
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Search"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Con = New OleDbConnection(ConStr)
        Con.Open()
        Da = New OleDbDataAdapter(StrFindQuery & " '%" & TxTSearch.Text.ToString & "%'", Con)
        Ds.Clear()
        Select Case StrCall
            Case ModMain.CallFrom.AccountMaster
                StrTab = "AC"
            Case ModMain.CallFrom.PaymentVoucher, ModMain.CallFrom.ReceiptVoucher
                StrTab = "RP"
            Case ModMain.CallFrom.JournalVoucher
                StrTab = "J"
        End Select
        Da.Fill(Ds, StrTab)
        DGrid.SetDataBinding(Ds, StrTab)
        Con.Close()
    End Sub

    Private Sub TxTSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxTSearch.TextChanged
        Con.Open()
        Da = New OleDbDataAdapter(StrFindQuery & " '%" & Replace(TxTSearch.Text, "'", "''") & "%'", Con)
        Ds.Clear()
        Da.Fill(Ds, strTab)
        DGrid.SetDataBinding(Ds, StrTab)
        Con.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGo.Click
        If DGrid.VisibleRowCount > 0 Then
            StrSearchResult = DGrid.Item(DGrid.CurrentRowIndex, 0)
            Close()
        End If
    End Sub

    Private Sub TxTSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxTSearch.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                If DGrid.CurrentRowIndex > 0 Then
                    DGrid.CurrentRowIndex = DGrid.CurrentRowIndex - 1
                End If
            Case Keys.Down
                If DGrid.CurrentRowIndex < Ds.Tables(0).Rows.Count - 1 Then
                    DGrid.CurrentRowIndex = DGrid.CurrentRowIndex + 1
                End If
        End Select
    End Sub
    Private Sub DGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGrid.DoubleClick
        If DGrid.VisibleRowCount > 0 Then
            StrSearchResult = DGrid.Item(DGrid.CurrentRowIndex, 0)
            Close()
        End If
    End Sub
End Class
