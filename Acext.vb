Imports System.Data.OleDb
Imports System.Math
Public Class AcExtD
    Inherits System.Windows.Forms.Form
    Dim oleCon As OleDbConnection
    Dim iAccode As Integer
    Dim FDt, TDt As Date
    Dim IDate As Date
    Dim CallFromTRLBAL As Boolean
    Enum Column
        Vno = 0
        TDate = 1
        RefNo = 2
        Particulars = 3
        Debit = 4
        Credit = 5
        Balance = 6
        DrCr = 7
        Book = 8
        Narr = 9
    End Enum

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
    Friend WithEvents PanelHead As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CmdGo As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbAcHeaD As System.Windows.Forms.ComboBox
    Friend WithEvents ToDTDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents FromDTDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LBLDisplay As System.Windows.Forms.Label
    Friend WithEvents FGrid As AxMSFlexGridLib.AxMSFlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(AcExtD))
        Me.PanelHead = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.CmdGo = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbAcHeaD = New System.Windows.Forms.ComboBox
        Me.ToDTDate = New System.Windows.Forms.DateTimePicker
        Me.FromDTDate = New System.Windows.Forms.DateTimePicker
        Me.LBLDisplay = New System.Windows.Forms.Label
        Me.FGrid = New AxMSFlexGridLib.AxMSFlexGrid
        Me.PanelHead.SuspendLayout()
        CType(Me.FGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHead
        '
        Me.PanelHead.BackColor = System.Drawing.Color.Khaki
        Me.PanelHead.Controls.Add(Me.Button1)
        Me.PanelHead.Controls.Add(Me.CmdGo)
        Me.PanelHead.Controls.Add(Me.Label3)
        Me.PanelHead.Controls.Add(Me.Label2)
        Me.PanelHead.Controls.Add(Me.Label1)
        Me.PanelHead.Controls.Add(Me.CmbAcHeaD)
        Me.PanelHead.Controls.Add(Me.ToDTDate)
        Me.PanelHead.Controls.Add(Me.FromDTDate)
        Me.PanelHead.Controls.Add(Me.LBLDisplay)
        Me.PanelHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHead.Location = New System.Drawing.Point(0, 0)
        Me.PanelHead.Name = "PanelHead"
        Me.PanelHead.Size = New System.Drawing.Size(760, 80)
        Me.PanelHead.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(680, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "E&xit"
        '
        'CmdGo
        '
        Me.CmdGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdGo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CmdGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGo.Location = New System.Drawing.Point(600, 16)
        Me.CmdGo.Name = "CmdGo"
        Me.CmdGo.Size = New System.Drawing.Size(72, 23)
        Me.CmdGo.TabIndex = 8
        Me.CmdGo.Text = "&Show"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "A/c Head :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(280, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "To Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "From Date:"
        '
        'CmbAcHeaD
        '
        Me.CmbAcHeaD.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAcHeaD.Location = New System.Drawing.Point(88, 29)
        Me.CmbAcHeaD.Name = "CmbAcHeaD"
        Me.CmbAcHeaD.Size = New System.Drawing.Size(360, 22)
        Me.CmbAcHeaD.TabIndex = 4
        '
        'ToDTDate
        '
        Me.ToDTDate.CalendarFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToDTDate.CustomFormat = "dd-MM-yyyy"
        Me.ToDTDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToDTDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDTDate.Location = New System.Drawing.Point(344, 5)
        Me.ToDTDate.Name = "ToDTDate"
        Me.ToDTDate.Size = New System.Drawing.Size(104, 22)
        Me.ToDTDate.TabIndex = 3
        '
        'FromDTDate
        '
        Me.FromDTDate.CalendarFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromDTDate.CustomFormat = "dd-MM-yyyy"
        Me.FromDTDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromDTDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDTDate.Location = New System.Drawing.Point(88, 4)
        Me.FromDTDate.Name = "FromDTDate"
        Me.FromDTDate.Size = New System.Drawing.Size(104, 22)
        Me.FromDTDate.TabIndex = 2
        '
        'LBLDisplay
        '
        Me.LBLDisplay.BackColor = System.Drawing.Color.LightCyan
        Me.LBLDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLDisplay.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LBLDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBLDisplay.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDisplay.ForeColor = System.Drawing.Color.Teal
        Me.LBLDisplay.Location = New System.Drawing.Point(0, 56)
        Me.LBLDisplay.Name = "LBLDisplay"
        Me.LBLDisplay.Size = New System.Drawing.Size(760, 24)
        Me.LBLDisplay.TabIndex = 0
        Me.LBLDisplay.Text = "Account Exact For "
        Me.LBLDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FGrid
        '
        Me.FGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FGrid.Location = New System.Drawing.Point(0, 80)
        Me.FGrid.Name = "FGrid"
        Me.FGrid.OcxState = CType(resources.GetObject("FGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FGrid.Size = New System.Drawing.Size(760, 349)
        Me.FGrid.TabIndex = 5
        '
        'AcExtD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(760, 429)
        Me.Controls.Add(Me.FGrid)
        Me.Controls.Add(Me.PanelHead)
        Me.Name = "AcExtD"
        Me.Text = "Account Extract ( Detail )"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelHead.ResumeLayout(False)
        CType(Me.FGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub AcExtract_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FromDTDate.MinDate = FromDate
        FromDTDate.MaxDate = ToDate
        ToDTDate.MinDate = FromDate
        ToDTDate.MaxDate = ToDate
        FromDTDate.Value = FromDate
        Try
            oleCon = New OleDbConnection(ConStr)
            oleCon.Open()
            Dim Da As New OleDbDataAdapter("SELECT GlCode,Part FROM GlMAST", oleCon)
            Dim Ds As New DataSet
            Da.Fill(Ds, "A")
            CmbAcHeaD.DataSource = Ds
            CmbAcHeaD.DisplayMember = "A.Part"
            CmbAcHeaD.ValueMember = "A.GlCode"
            If CallFromTRLBAL = True Then
                CmbAcHeaD.SelectedValue = iAccode
                FromDTDate.Value = FDt
                ToDTDate.Value = TDt
                FillGrid(iAccode, FromDTDate.Value, ToDTDate.Value)
            End If
            FGrid.set_ColWidth(Column.Vno, 0)
        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            oleCon.Close()
        End Try
    End Sub
    Private Sub FillGrid(ByVal AcCode As Integer, ByVal FDate As Date, ByVal TDate As Date)
        Dim Cmd As New OleDbCommand
        Dim DR As OleDbDataReader
        Dim Sum As Double
        Dim strDrCr As String
        Try
            LBLDisplay.Text = "Account Exact For " & CmbAcHeaD.Text
            If oleCon.State Then oleCon.Close()
            oleCon.Open()
            Cmd.CommandText = "AcExt"
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = oleCon
            Dim P As New OleDbParameter
            P.ParameterName = "@GlCode"
            P.Direction = ParameterDirection.Input
            P.DbType = DbType.Int16
            P.Value = AcCode
            Cmd.Parameters.Add(P)
            P = New OleDbParameter
            P.ParameterName = "@FDate"
            P.Direction = ParameterDirection.Input
            P.DbType = DbType.Date
            P.Value = FDate
            Cmd.Parameters.Add(P)
            P = New OleDbParameter
            P.ParameterName = "@TDate"
            P.Direction = ParameterDirection.Input
            P.DbType = DbType.Date
            P.Value = TDate
            Cmd.Parameters.Add(P)
            DR = Cmd.ExecuteReader
            FGrid.Rows = 2
            Dim i As Int16 = 1
            For i = 1 To FGrid.Cols - 1
                FGrid.set_TextMatrix(1, i, "")
            Next
            i = 1
            While DR.Read
                With FGrid
                    .set_TextMatrix(i, Column.Vno, DR.Item("Vno"))
                    .set_TextMatrix(i, Column.TDate, IIf(IsDBNull(DR.Item("IDate")), "", DR.Item("IDate")))
                    .set_TextMatrix(i, Column.RefNo, IIf(IsDBNull(DR.Item("RefNo")), "", DR.Item("RefNo")))
                    .set_TextMatrix(i, Column.Book, DR.Item("Book"))
                    .set_TextMatrix(i, Column.Particulars, DR.Item("Acc"))
                    .set_TextMatrix(i, Column.Narr, IIf(IsDBNull(DR.Item("Narr")), "", DR.Item("Narr")))
                    Dim TempDr, TempCr As Double
                    TempDr = Val(IIf(IsDBNull(DR.Item("Debit")), "", DR.Item("Debit")))
                    TempCr = Val(IIf(IsDBNull(DR.Item("Credit")), "", DR.Item("Credit")))
                    If TempDr <> 0 Then
                        FGrid.set_TextMatrix(i, Column.Debit, Format(TempDr, "0.00"))
                    End If
                    If TempCr <> 0 Then
                        FGrid.set_TextMatrix(i, Column.Credit, Format(TempCr, "0.00"))
                    End If
                    '.set_TextMatrix(i, Column.Debit, IIf(IsDBNull(DR.Item("Debit")), "", DR.Item("Debit")))
                    '.set_TextMatrix(i, Column.Credit, IIf(IsDBNull(DR.Item("Credit")), "", DR.Item("Credit")))
                    Sum += CType(IIf(IsDBNull(DR.Item("OPBAL")), 0, DR.Item("OPBAL")), Double)
                    .set_TextMatrix(i, Column.Balance, Format(Abs(Sum), "0.00"))
                    If Sum >= 0 Then
                        strDrCr = "DR"
                    Else
                        strDrCr = "CR"
                    End If
                    .set_TextMatrix(i, Column.DrCr, strDrCr)
                    If i <> 1 Then
                        If i Mod 2 = 0 Then
                            ColorRow(i, Color.Ivory, False)
                        Else
                            ColorRow(i, Color.Azure, False)
                        End If
                    Else
                        ColorRow(i, Color.Azure, True)
                    End If
                    .AddItem("")
                    i = i + 1
                End With
            End While
            Dim Lb As Int16 = FGrid.Rows - 1
            Dim Ub As Int16 = Lb + 1
            For i = Lb To Ub
                FGrid.AddItem("")
            Next
            With FGrid
                Dim Dsum, CSum As Double
                For i = 2 To Lb - 1
                    Dsum += Val(.get_TextMatrix(i, Column.Debit))
                    CSum += Val(.get_TextMatrix(i, Column.Credit))
                Next
                .set_TextMatrix(Lb, Column.Particulars, "Sub Total :")
                .set_TextMatrix(Lb, Column.Debit, Format(Dsum, "0.00"))
                .set_TextMatrix(Lb, Column.Credit, Format(CSum, "0.00"))
                ColorRow(Lb, Color.PowderBlue, True)
                .set_TextMatrix(Lb + 1, Column.Particulars, "Closing Balance :")
                If .get_TextMatrix(Lb - 1, Column.DrCr) = "CR" Then
                    .set_TextMatrix(Lb + 1, Column.Debit, .get_TextMatrix(Lb - 1, Column.Balance))
                Else
                    .set_TextMatrix(Lb + 1, Column.Credit, .get_TextMatrix(Lb - 1, Column.Balance))
                End If
                .set_TextMatrix(Lb + 1, Column.DrCr, .get_TextMatrix(Lb - 1, Column.DrCr))
                ColorRow(Lb + 1, Color.Azure, True)
                .set_TextMatrix(Lb + 2, Column.Particulars, "Net Total :")
                Dim NetDSum, NetCSum As Double
                NetDSum = Val(.get_TextMatrix(1, Column.Debit)) + Val(.get_TextMatrix(Lb, Column.Debit)) + Val(.get_TextMatrix(Lb + 1, Column.Debit))
                NetCSum = Val(.get_TextMatrix(1, Column.Credit)) + Val(.get_TextMatrix(Lb, Column.Credit)) + Val(.get_TextMatrix(Lb + 1, Column.Credit))
                .set_TextMatrix(Lb + 2, Column.Debit, Format(NetDSum, "0.00"))
                .set_TextMatrix(Lb + 2, Column.Credit, Format(NetCSum, "0.00"))
                ColorRow(Lb + 2, Color.PowderBlue, True)
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oleCon.Close()
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
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
        FillGrid(CmbAcHeaD.SelectedValue, FromDTDate.Value, ToDTDate.Value)
    End Sub

    Private Sub CmbAcHeaD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAcHeaD.SelectedIndexChanged

    End Sub

    Private Sub FGrid_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FGrid.Enter

    End Sub

    Private Sub FGrid_DblClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles FGrid.DblClick
        ShowEvent()
    End Sub
    Private Sub ShowEvent()
        Dim StrVno As String = FGrid.get_TextMatrix(FGrid.Row, Column.Vno)
        If Len(StrVno) = 6 Then
            Dim strVType As String = StrVno.Substring(0, 2)
            Select Case strVType
                Case "PV"
                    Dim NewPv As New CashReceipt(StrVno, strVType)
                    NewPv.MdiParent = Me.MdiParent
                    NewPv.Text = "Payment Voucher"
                    NewPv.Show()
                Case "RV"
                    Dim NewRv As New CashReceipt(StrVno, strVType)
                    NewRv.MdiParent = Me.MdiParent
                    NewRv.Text = "Receipt Voucher"
                    NewRv.Show()
                Case "JV"
                    Dim NewJv As New Journal(StrVno, strVType)
                    NewJv.MdiParent = Me.MdiParent
                    NewJv.Show()
            End Select
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

    Private Sub PanelHead_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelHead.Paint

    End Sub
End Class
