Imports System.Data.OleDb
Public Class TrialBalance
    Inherits System.Windows.Forms.Form
    Enum Column
        Ac = 0
        AcHead = 1
        Debit = 2
        Credit = 3
    End Enum
    Dim iRowIndicator As Int16
    Dim GrandDSum, GrandCSum As Double
    Dim StrBsHead As String
    Dim StrBsHeadName As String
    Dim DtToDate As Date
    Dim DtFromDate As Date
    Dim Con As OleDbConnection
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub
    'Public Sub New(ByVal BsHead As String, ByVal BsHeadName As String, ByVal FDate As Date, ByVal TDate As Date)
    '    MyBase.New()
    '    InitializeComponent()
    '    StrBsHead = BsHead
    '    StrBsHeadName = BsHeadName
    '    DtToDate = TDate
    '    DtFromDate = FDate
    'End Sub

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
    Friend WithEvents FGrid As AxMSFlexGridLib.AxMSFlexGrid
    Friend WithEvents PanelHead As System.Windows.Forms.Panel
    Friend WithEvents LbLTrial As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CmdGo As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToDTDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents PBar As System.Windows.Forms.ProgressBar
    Friend WithEvents CmbAcHeaD As System.Windows.Forms.ListBox
    Friend WithEvents TxT As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TrialBalance))
        Me.FGrid = New AxMSFlexGridLib.AxMSFlexGrid
        Me.PanelHead = New System.Windows.Forms.Panel
        Me.TxT = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.CmdGo = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ToDTDate = New System.Windows.Forms.DateTimePicker
        Me.LbLTrial = New System.Windows.Forms.Label
        Me.CmbAcHeaD = New System.Windows.Forms.ListBox
        Me.PBar = New System.Windows.Forms.ProgressBar
        CType(Me.FGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHead.SuspendLayout()
        Me.SuspendLayout()
        '
        'FGrid
        '
        Me.FGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FGrid.Location = New System.Drawing.Point(0, 88)
        Me.FGrid.Name = "FGrid"
        Me.FGrid.OcxState = CType(resources.GetObject("FGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FGrid.Size = New System.Drawing.Size(736, 293)
        Me.FGrid.TabIndex = 1
        '
        'PanelHead
        '
        Me.PanelHead.BackColor = System.Drawing.Color.Khaki
        Me.PanelHead.Controls.Add(Me.TxT)
        Me.PanelHead.Controls.Add(Me.Button1)
        Me.PanelHead.Controls.Add(Me.CmdGo)
        Me.PanelHead.Controls.Add(Me.Label3)
        Me.PanelHead.Controls.Add(Me.Label2)
        Me.PanelHead.Controls.Add(Me.ToDTDate)
        Me.PanelHead.Controls.Add(Me.LbLTrial)
        Me.PanelHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHead.Location = New System.Drawing.Point(0, 0)
        Me.PanelHead.Name = "PanelHead"
        Me.PanelHead.Size = New System.Drawing.Size(736, 88)
        Me.PanelHead.TabIndex = 0
        '
        'TxT
        '
        Me.TxT.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxT.Location = New System.Drawing.Point(96, 32)
        Me.TxT.Name = "TxT"
        Me.TxT.Size = New System.Drawing.Size(376, 23)
        Me.TxT.TabIndex = 3
        Me.TxT.Text = ""
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(640, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "E&xit"
        '
        'CmdGo
        '
        Me.CmdGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdGo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CmdGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGo.Location = New System.Drawing.Point(560, 16)
        Me.CmdGo.Name = "CmdGo"
        Me.CmdGo.Size = New System.Drawing.Size(72, 23)
        Me.CmdGo.TabIndex = 4
        Me.CmdGo.Text = "&Show"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Group :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "To Date :"
        '
        'ToDTDate
        '
        Me.ToDTDate.CalendarFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToDTDate.CustomFormat = "dd-MM-yyyy"
        Me.ToDTDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToDTDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDTDate.Location = New System.Drawing.Point(96, 8)
        Me.ToDTDate.Name = "ToDTDate"
        Me.ToDTDate.Size = New System.Drawing.Size(104, 22)
        Me.ToDTDate.TabIndex = 1
        '
        'LbLTrial
        '
        Me.LbLTrial.BackColor = System.Drawing.Color.LightYellow
        Me.LbLTrial.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LbLTrial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbLTrial.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLTrial.Location = New System.Drawing.Point(0, 64)
        Me.LbLTrial.Name = "LbLTrial"
        Me.LbLTrial.Size = New System.Drawing.Size(736, 24)
        Me.LbLTrial.TabIndex = 6
        Me.LbLTrial.Text = "Trial Balance As on "
        '
        'CmbAcHeaD
        '
        Me.CmbAcHeaD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CmbAcHeaD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAcHeaD.ItemHeight = 14
        Me.CmbAcHeaD.Location = New System.Drawing.Point(96, 104)
        Me.CmbAcHeaD.Name = "CmbAcHeaD"
        Me.CmbAcHeaD.Size = New System.Drawing.Size(368, 84)
        Me.CmbAcHeaD.TabIndex = 18
        '
        'PBar
        '
        Me.PBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PBar.Location = New System.Drawing.Point(0, 381)
        Me.PBar.Name = "PBar"
        Me.PBar.Size = New System.Drawing.Size(736, 16)
        Me.PBar.TabIndex = 3
        '
        'TrialBalance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(736, 397)
        Me.Controls.Add(Me.CmbAcHeaD)
        Me.Controls.Add(Me.FGrid)
        Me.Controls.Add(Me.PBar)
        Me.Controls.Add(Me.PanelHead)
        Me.Name = "TrialBalance"
        Me.Text = "Trial Balance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHead.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub TrialBalance_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToDTDate.MinDate = FromDate
        ToDTDate.MaxDate = ToDate
        CmbAcHeaD.Visible = False
        FGrid.set_ColWidth(Column.Ac, 0)
        Try
            Con = New OleDbConnection(ConStr)
            Con.Open()
            Dim Da As New OleDbDataAdapter("SELECT IndCode,Part FROM BsHead", Con)
            Dim Ds As New DataSet
            Da.Fill(Ds, "A")
            CmbAcHeaD.DataSource = Ds
            CmbAcHeaD.DisplayMember = "A.Part"
            CmbAcHeaD.ValueMember = "A.IndCode"
        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub
    Private Sub FillData()
        Dim iRowCount As Int16
        Dim i As Int16
        PBar.Show()
        LbLTrial.Text = "Trial Balance As on " & Format(ToDTDate.Value, "dd-MM-yyyy")
        iRowIndicator = 1
        FGrid.Rows = 2
        ColorRow(0, Color.PowderBlue, True)
        For i = 0 To FGrid.Cols - 1
            FGrid.set_TextMatrix(1, i, "")
        Next
        PBar.Minimum = 0
        PBar.Maximum = CmbAcHeaD.Items.Count - 1
        For iRowCount = 0 To CmbAcHeaD.Items.Count - 1
            CmbAcHeaD.SelectedIndex = iRowCount
            FillGridX(CmbAcHeaD.SelectedValue, CmbAcHeaD.Text, ToDTDate.Value)
            PBar.Value = iRowCount
        Next
        PBar.Hide()
        Dim DiffSum As Double
        Dim StrShow As String = "Grand Total "
        If GrandCSum > GrandDSum Then
            DiffSum = GrandCSum - GrandDSum
            StrShow += "[Diffrence : " & Format(DiffSum, "0.00") & "]"
        ElseIf GrandCSum < GrandDSum Then
            DiffSum = GrandDSum - GrandCSum
            StrShow += "[Diffrence : " & Format(DiffSum, "0.00") & "]"
        End If
        FGrid.set_TextMatrix(iRowIndicator, Column.AcHead, StrShow)
        FGrid.set_TextMatrix(iRowIndicator, Column.Debit, Format(GrandDSum, "0.00"))
        FGrid.set_TextMatrix(iRowIndicator, Column.Credit, Format(GrandCSum, "0.00"))
        ColorRow(iRowIndicator, Color.Aquamarine, True)
    End Sub
    Private Sub FillGrid(ByVal StrbsHead As String, ByVal StrBsHEadName As String, ByVal TDate As Date)
        LbLTrial.Text = "Trial Balance As on " & Format(TDate, "dd-MM-yyyy")
        Dim CmdTrlBal As New OleDbCommand
        Dim Dr As OleDbDataReader
        Try
            If Con.State Then Con.Close()
            Con.Open()
            CmdTrlBal.CommandText = "TRLBAL"
            CmdTrlBal.CommandType = CommandType.StoredProcedure
            CmdTrlBal.Connection = Con
            Dim P As New OleDbParameter
            P.ParameterName = "@BsHead"
            P.DbType = DbType.String
            P.Direction = ParameterDirection.Input
            P.Value = StrbsHead
            CmdTrlBal.Parameters.Add(P)
            P = New OleDbParameter
            P.ParameterName = "@TDate"
            P.Direction = ParameterDirection.Input
            P.DbType = DbType.Date
            P.Value = TDate
            CmdTrlBal.Parameters.Add(P)
            Dr = CmdTrlBal.ExecuteReader
            Dim i As Integer = 1
            Dim DSum, CSum As Double
            FGrid.Rows = 2
            For i = 0 To FGrid.Cols - 1
                FGrid.set_TextMatrix(1, i, "")
            Next
            FGrid.set_TextMatrix(1, Column.AcHead, StrBsHEadName)
            FGrid.Row = 1
            FGrid.Col = Column.AcHead
            FGrid.CellForeColor = Color.DarkSlateGray
            FGrid.CellFontBold = True
            i = 1
            While Dr.Read
                If i <> 1 Then
                    If i Mod 2 = 0 Then
                        ColorRow(i, Color.Ivory)
                    Else
                        ColorRow(i, Color.Azure)
                    End If
                End If
                FGrid.AddItem("")
                i += 1
                FGrid.set_TextMatrix(i, Column.Ac, Dr.Item(0))
                FGrid.set_TextMatrix(i, Column.AcHead, Dr.Item(1))
                Dim TempDr, TempCr As Double
                TempDr = Val(IIf(IsDBNull(Dr.Item(4)), "", Dr.Item(4)))
                TempCr = Val(IIf(IsDBNull(Dr.Item(5)), "", Dr.Item(5)))
                If TempDr <> 0 Then
                    FGrid.set_TextMatrix(i, Column.Debit, Format(TempDr, "0.00"))
                End If
                If TempCr <> 0 Then
                    FGrid.set_TextMatrix(i, Column.Credit, Format(TempCr, "0.00"))
                End If
            End While
            FGrid.AddItem("")
            With FGrid
                For i = 1 To .Rows - 1
                    DSum += Val(.get_TextMatrix(i, Column.Debit))
                    CSum += Val(.get_TextMatrix(i, Column.Credit))
                Next
                .set_TextMatrix(.Rows - 1, Column.AcHead, "Sub Total :")
                .set_TextMatrix(.Rows - 1, Column.Debit, Format(DSum, "0.00"))
                .set_TextMatrix(.Rows - 1, Column.Credit, Format(CSum, "0.00"))
                ColorRow(.Rows - 1, Color.Aquamarine, True)
            End With
            ColorRow(0, Color.PowderBlue, True)
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub
    Private Sub FillGridX(ByVal StrbsHead As String, ByVal StrBsHEadName As String, ByVal TDate As Date)
        Dim CmdTrlBal As New OleDbCommand
        Dim Dr As OleDbDataReader
        Try
            If Con.State Then Con.Close()
            Con.Open()
            CmdTrlBal.CommandText = "TRLBAL"
            CmdTrlBal.CommandType = CommandType.StoredProcedure
            CmdTrlBal.Connection = Con
            Dim P As New OleDbParameter
            P.ParameterName = "@BsHead"
            P.DbType = DbType.String
            P.Direction = ParameterDirection.Input
            P.Value = StrbsHead
            CmdTrlBal.Parameters.Add(P)
            P = New OleDbParameter
            P.ParameterName = "@TDate"
            P.Direction = ParameterDirection.Input
            P.DbType = DbType.Date
            P.Value = TDate
            CmdTrlBal.Parameters.Add(P)
            Dr = CmdTrlBal.ExecuteReader
            If Dr.HasRows = True Then
                Dim DSum, CSum As Double
                FGrid.set_TextMatrix(iRowIndicator, Column.AcHead, StrBsHEadName)
                FGrid.Row = iRowIndicator
                FGrid.Col = Column.AcHead
                FGrid.CellForeColor = Color.DarkSlateGray
                ColorRow(iRowIndicator, Color.PowderBlue, True)
                Dim i As Integer = iRowIndicator
                While Dr.Read
                    If i <> iRowIndicator Then
                        ColorRow(i, Color.Ivory)
                    End If
                    FGrid.AddItem("")
                    i += 1
                    FGrid.set_TextMatrix(i, Column.Ac, Dr.Item(0))
                    FGrid.set_TextMatrix(i, Column.AcHead, Dr.Item(1))
                    Dim TempDr, TempCr As Double
                    TempDr = Val(IIf(IsDBNull(Dr.Item(4)), "", Dr.Item(4)))
                    TempCr = Val(IIf(IsDBNull(Dr.Item(5)), "", Dr.Item(5)))
                    If TempDr <> 0 Then
                        FGrid.set_TextMatrix(i, Column.Debit, Format(TempDr, "0.00"))
                    End If
                    If TempCr <> 0 Then
                        FGrid.set_TextMatrix(i, Column.Credit, Format(TempCr, "0.00"))
                    End If
                End While
                FGrid.AddItem("")
                i = i + 1
                With FGrid
                    Dim iCount As Int16
                    For iCount = iRowIndicator To i - 1
                        DSum += Val(.get_TextMatrix(iCount, Column.Debit))
                        CSum += Val(.get_TextMatrix(iCount, Column.Credit))
                    Next
                    GrandDSum += DSum
                    GrandCSum += CSum
                    .set_TextMatrix(i, Column.AcHead, "Sub Total :")
                    .set_TextMatrix(i, Column.Debit, Format(DSum, "0.00"))
                    .set_TextMatrix(i, Column.Credit, Format(CSum, "0.00"))
                    ColorRow(i, Color.Azure, True)
                End With
                FGrid.AddItem("")
                iRowIndicator = i + 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub ColorRow(ByVal iRow As Int16, ByVal IColor As Color, Optional ByVal FBold As Boolean = False)
        Dim i As Int16
        For i = 0 To FGrid.Cols - 1
            FGrid.Row = iRow
            FGrid.Col = i
            FGrid.CellBackColor = IColor
            FGrid.CellFontBold = FBold
        Next
    End Sub

    Private Sub CmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGo.Click
        If Trim(TxT.Text) <> "" Then
            LbLTrial.Text = "Trial Balance As on " & Format(ToDTDate.Value, "dd-MM-yyyy")
            FGrid.Rows = 2
            Dim i As Int16
            For i = 0 To FGrid.Cols - 1
                FGrid.set_TextMatrix(1, i, "")
            Next
            FGrid.set_TextMatrix(1, Column.AcHead, StrBsHeadName)
            iRowIndicator = 1
            FillGridX(CmbAcHeaD.SelectedValue, CmbAcHeaD.Text, ToDTDate.Value)
            If FGrid.Rows > 2 Then FGrid.RemoveItem(FGrid.Rows - 1)
        Else
            FillData()
        End If
        FGrid.Select()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub FGrid_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles FGrid.DblClick
        ShowEvent()
    End Sub
    Public Sub ShowEvent()
        Dim i As Integer = CInt(FGrid.get_TextMatrix(FGrid.Row, Column.Ac))
        If i > 0 Then
            Dim NewAcExtract As New AcExtract(i, FromDate, ToDTDate.Value, True)
            NewAcExtract.MdiParent = Me.MdiParent
            NewAcExtract.Show()
        End If
    End Sub

    Private Sub FGrid_KeyPressEvent(ByVal sender As Object, ByVal e As AxMSFlexGridLib.DMSFlexGridEvents_KeyPressEvent) Handles FGrid.KeyPressEvent
        If e.keyAscii = 13 Then
            ShowEvent()
        End If
        If e.keyAscii = 8 Then
            Close()
        End If
    End Sub

    Private Sub CmbAcHeaD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            CmdGo.Focus()
        End If
    End Sub
    Private Sub SelectRow(ByVal iRow As Int16)
        FGrid.RowSel = iRow
    End Sub

    Private Sub ToDTDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToDTDate.ValueChanged

    End Sub

    Private Sub ToDTDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToDTDate.LostFocus
        CmbAcHeaD.SelectedIndex = -1
        CmbAcHeaD.Text = ""
    End Sub

    Private Sub ToDTDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToDTDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CmbAcHeaD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PanelHead_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelHead.Paint

    End Sub

    Private Sub TxT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxT.TextChanged
        Dim z As Int16 = TxT.Text.Length
        CmbAcHeaD.SelectedIndex = CmbAcHeaD.FindString(TxT.Text)
        CmbAcHeaD.TopIndex = CmbAcHeaD.SelectedIndex
        If CmbAcHeaD.SelectedIndex > -1 Then
            TxT.Text = CmbAcHeaD.GetItemText(CmbAcHeaD.SelectedItem)
            If TxT.Text.Length >= z Then
                TxT.Select(z, TxT.Text.Length - z)
            End If
        End If
    End Sub

    Private Sub TxT_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxT.GotFocus
        CmbAcHeaD.SetBounds(TxT.Left, TxT.Top + TxT.Height, CmbAcHeaD.Width, CmbAcHeaD.Height)
        CmbAcHeaD.Show()
    End Sub

    Private Sub TxT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxT.LostFocus
        CmbAcHeaD.Hide()
    End Sub

    Private Sub TxT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxT.KeyDown
        Select Case e.KeyCode
            Case Keys.Down
                If CmbAcHeaD.SelectedIndex < CmbAcHeaD.Items.Count - 1 Then
                    CmbAcHeaD.SelectedIndex += 1
                End If
            Case Keys.Up
                If CmbAcHeaD.SelectedIndex > 0 Then
                    CmbAcHeaD.SelectedIndex -= 1
                End If
            Case Keys.Back
                If TxT.Text.Length > 0 Then
                    If TxT.SelectionStart > 0 Then
                        TxT.SelectionStart = TxT.SelectionStart - 1
                        TxT.Select(TxT.SelectionStart, TxT.SelectionLength + 1)
                    End If
                End If
            Case Keys.Delete
                TxT.Text = ""
                SendKeys.Send(" ")
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub TrialBalance_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class
