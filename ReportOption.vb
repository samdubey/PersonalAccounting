Imports CrystalDecisions.CrystalReports.Engine
Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Public Class ReportOption1
    Inherits System.Windows.Forms.Form
    Dim ReportName As Reports
    Dim WithEvents ReportDoc As New ReportDocument
#Region " Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    Public Sub New(ByVal Report_Name As Integer)
        MyBase.New()
        InitializeComponent()
        ReportName = Report_Name
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
    Friend WithEvents _TDT As System.Windows.Forms.DateTimePicker
    Friend WithEvents _FDT As System.Windows.Forms.DateTimePicker
    Friend WithEvents _CMB As System.Windows.Forms.ComboBox
    Friend WithEvents CmdPP As System.Windows.Forms.Button
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents _FDate As System.Windows.Forms.Label
    Friend WithEvents _TDate As System.Windows.Forms.Label
    Friend WithEvents _LBLCMB As System.Windows.Forms.Label
    Friend WithEvents ChkNarr As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me._TDT = New System.Windows.Forms.DateTimePicker
        Me._FDT = New System.Windows.Forms.DateTimePicker
        Me._CMB = New System.Windows.Forms.ComboBox
        Me._FDate = New System.Windows.Forms.Label
        Me._TDate = New System.Windows.Forms.Label
        Me._LBLCMB = New System.Windows.Forms.Label
        Me.CmdPP = New System.Windows.Forms.Button
        Me.CmdExit = New System.Windows.Forms.Button
        Me.ChkNarr = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        '_TDT
        '
        Me._TDT.CustomFormat = "dd-MM-yyyy"
        Me._TDT.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me._TDT.Location = New System.Drawing.Point(136, 32)
        Me._TDT.Name = "_TDT"
        Me._TDT.Size = New System.Drawing.Size(120, 23)
        Me._TDT.TabIndex = 1
        '
        '_FDT
        '
        Me._FDT.CustomFormat = "dd-MM-yyyy"
        Me._FDT.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me._FDT.Location = New System.Drawing.Point(136, 8)
        Me._FDT.Name = "_FDT"
        Me._FDT.Size = New System.Drawing.Size(120, 23)
        Me._FDT.TabIndex = 0
        '
        '_CMB
        '
        Me._CMB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CMB.Location = New System.Drawing.Point(136, 56)
        Me._CMB.Name = "_CMB"
        Me._CMB.Size = New System.Drawing.Size(336, 24)
        Me._CMB.TabIndex = 2
        '
        '_FDate
        '
        Me._FDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FDate.Location = New System.Drawing.Point(8, 13)
        Me._FDate.Name = "_FDate"
        Me._FDate.Size = New System.Drawing.Size(100, 16)
        Me._FDate.TabIndex = 3
        Me._FDate.Text = "From Date :"
        '
        '_TDate
        '
        Me._TDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TDate.Location = New System.Drawing.Point(8, 35)
        Me._TDate.Name = "_TDate"
        Me._TDate.Size = New System.Drawing.Size(100, 16)
        Me._TDate.TabIndex = 4
        Me._TDate.Text = "To Date    :"
        '
        '_LBLCMB
        '
        Me._LBLCMB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LBLCMB.Location = New System.Drawing.Point(8, 58)
        Me._LBLCMB.Name = "_LBLCMB"
        Me._LBLCMB.Size = New System.Drawing.Size(100, 16)
        Me._LBLCMB.TabIndex = 5
        Me._LBLCMB.Text = "Select"
        '
        'CmdPP
        '
        Me.CmdPP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPP.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPP.Location = New System.Drawing.Point(296, 96)
        Me.CmdPP.Name = "CmdPP"
        Me.CmdPP.Size = New System.Drawing.Size(96, 24)
        Me.CmdPP.TabIndex = 3
        Me.CmdPP.Text = "&Print Preview"
        '
        'CmdExit
        '
        Me.CmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdExit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExit.Location = New System.Drawing.Point(400, 96)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(72, 24)
        Me.CmdExit.TabIndex = 4
        Me.CmdExit.Text = "E&xit"
        '
        'ChkNarr
        '
        Me.ChkNarr.Checked = True
        Me.ChkNarr.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkNarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkNarr.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNarr.Location = New System.Drawing.Point(138, 93)
        Me.ChkNarr.Name = "ChkNarr"
        Me.ChkNarr.Size = New System.Drawing.Size(136, 24)
        Me.ChkNarr.TabIndex = 6
        Me.ChkNarr.Text = "With Narration"
        Me.ChkNarr.Visible = False
        '
        'ReportOption1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 125)
        Me.Controls.Add(Me.ChkNarr)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.CmdPP)
        Me.Controls.Add(Me._LBLCMB)
        Me.Controls.Add(Me._TDate)
        Me.Controls.Add(Me._FDate)
        Me.Controls.Add(Me._CMB)
        Me.Controls.Add(Me._FDT)
        Me.Controls.Add(Me._TDT)
        Me.MaximizeBox = False
        Me.Name = "ReportOption1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options - "
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ReportOption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            _FDT.MinDate = FromDate
            _FDT.MaxDate = ToDate
            _TDT.MinDate = FromDate
            _TDT.MaxDate = ToDate
            _FDT.Value = FromDate
            If Today >= FromDate And Today <= ToDate Then
                _TDT.Value = Today
            Else
                _TDT.Value = ToDate
            End If
            Select Case ReportName
                Case ModMain.Reports.CashBook
                    Me.Text += "Cash & Bank Book"
                    _LBLCMB.Text = "GL Name:"
                    View(True, True, True)
                    _CMB.DropDownStyle = ComboBoxStyle.DropDownList
                Case ModMain.Reports.DailyCashBook
                    Me.Text += "Daily Cash & Bank Book"
                    _LBLCMB.Text = "A/c Name:"
                    View(True, True, True)
                    _CMB.DropDownStyle = ComboBoxStyle.DropDownList
                Case ModMain.Reports.JournalBook
                    Me.Text += "Journal Book"
                    View(True, True, False)
                Case ModMain.Reports.AccountStatement
                    Me.Text += "Account Statement"
                    _LBLCMB.Text = "A/c Name:"
                    ViewAll()
                    _CMB.DropDownStyle = ComboBoxStyle.DropDownList
                Case ModMain.Reports.AccountStatementDetail
                    Me.Text += "Account Statement [Detail]"
                    _LBLCMB.Text = "A/c Name:"
                    ViewAll()
                    _CMB.DropDownStyle = ComboBoxStyle.DropDownList
                    ChkNarr.Show()
                Case ModMain.Reports.TrialBalance
                    Me.Text += "Trial Balance"
                    _LBLCMB.Text = "Bs Head:"
                    View(False, True, True)
                Case ModMain.Reports.TrialBalance_Detail
                    Me.Text += "Trial Balace Details"
                    _LBLCMB.Text = "Bs Head:"
                    View(False, True, True)
                Case ModMain.Reports.TrialBalance_Namewise
                    Me.Text += "Trial Balance Opening"
                    HideALL()
                Case ModMain.Reports.GeneralLedgerMaster
                    Me.Text += "General Ledger Master"
                    HideALL()
                Case ModMain.Reports.GeneralLedgerMaster_Details
                    Me.Text += "General Ledger Master Details"
                    HideALL()
                Case ModMain.Reports.BalanceSheetHead_Master
                    Me.Text += "Balance Sheet Head Master"
                    HideALL()
                Case ModMain.Reports.TradingAc
                    Me.Text += "Trading Account"
                    View(False, True, False)
                Case ModMain.Reports.BalanceSheet
                    Me.Text += "BalanceSheet"
                    View(False, True, False)
                Case ModMain.Reports.ProfitNLoss
                    Me.Text += "Profit & Loss Account"
                    View(True, True, False)
                Case ModMain.Reports.LabelPrinting
                    Me.Text += "Label Printing"
                    HideALL()
                Case ModMain.Reports.LedgerBook
                    Me.Text += "Ledger Book"
                    View(True, True, False)
            End Select
            FillCombo()
            _CMB.SelectedIndex = -1
            _CMB.Text = ""
        Catch Ex As Exception
            MsgBox(Ex.ToString)
        End Try
    End Sub
    Private Sub FillCombo()
        Dim Con As OleDbConnection
        Dim Da As OleDbDataAdapter
        Dim Ds As New DataSet
        Dim StrSql As String = ""
        Con = New OleDbConnection(ConStr)
        Select Case ReportName
            Case ModMain.Reports.AccountStatement, ModMain.Reports.AccountStatementDetail
                StrSql = "SELECT Part,GlCode as V FROM GlMAST"
            Case ModMain.Reports.LedgerBook, ModMain.Reports.TrialBalance, ModMain.Reports.TrialBalance_Detail
                StrSql = "SELECT IndCode as V,Part FROM BsHead"
            Case Reports.CashBook, ModMain.Reports.DailyCashBook
                StrSql = "SELECT Part,GlCode AS V FROM GlMast WHERE IndCode='BB'"
        End Select
        If StrSql <> "" Then
            Con.Open()
            Da = New OleDbDataAdapter(StrSql, Con)
            Da.Fill(Ds, "A")
            _CMB.DataSource = Ds
            _CMB.DisplayMember = "A.Part"
            _CMB.ValueMember = "A.V"
            Con.Close()
        End If
    End Sub
    Private Sub HideALL()
        _LBLCMB.Hide()
        _TDate.Hide()
        _FDate.Hide()
        _TDT.Hide()
        _FDT.Hide()
        _CMB.Hide()
    End Sub
    Private Sub ViewAll()
        _LBLCMB.Show()
        _TDate.Show()
        _FDate.Show()
        _TDT.Show()
        _FDT.Show()
        _CMB.Show()
    End Sub
    Private Sub View(ByVal FCntl As Boolean, ByVal TCntl As Boolean, ByVal CCntl As Boolean)
        _FDate.Visible = FCntl
        _FDT.Visible = FCntl
        _TDT.Visible = TCntl
        _TDate.Visible = TCntl
        _LBLCMB.Visible = CCntl
        _CMB.Visible = CCntl
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Close()
    End Sub
    Private Sub CmdPP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPP.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim StrReportPath As String = Application.StartupPath & "\Reports\"
            Dim StrSelectFormula As String = ""
            Select Case ReportName
                Case ModMain.Reports.AccountStatement
                    ReportDoc.Load(StrReportPath & "AcStat.rpt")
                    ReportDoc.SetParameterValue("FromDate", _FDT.Value)
                    ReportDoc.SetParameterValue("FromToDate", Format(_FDT.Value, "dd/MM/yyyy") & "-" & Format(_TDT.Value, "dd/MM/yyyy"))
                    If _CMB.SelectedIndex = -1 And _CMB.Text = "" Then
                        StrSelectFormula = "{GenGL.TDATE}<=DATE(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & Day(_TDT.Value) & ")"
                    Else
                        StrSelectFormula = "{GenGl.GlCode}=" & _CMB.SelectedValue & " AND {GenGL.TDATE}<=DATE(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & Day(_TDT.Value) & ")"
                    End If
                Case ModMain.Reports.AccountStatementDetail
                    ReportDoc.Load(StrReportPath & "AcStatD.rpt")
                    ReportDoc.SetParameterValue("FromDate", _FDT.Value)
                    ReportDoc.SetParameterValue("FromToDate", Format(_FDT.Value, "dd/MM/yyyy") & "-" & Format(_TDT.Value, "dd/MM/yyyy"))
                    ReportDoc.SetParameterValue("CBCode", _CMB.SelectedValue)
                    ReportDoc.SetParameterValue("WithNarr", ChkNarr.Checked)
                    'If _CMB.SelectedIndex = -1 And _CMB.Text = "" Then
                    StrSelectFormula = "{GenGLOPP.TDATE}<=DATE(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & Day(_TDT.Value) & ")"
                    StrSelectFormula += " AND {GenGL.GLCode}={?CBCode} and {GenGLOpp.GLCode}<>{?CBCode} or ({GenGLOpp.Book}='OP' AND {GenGLOpp.GLCode}={?CBCode})"
                    'Else
                    '    StrSelectFormula = "{GenGl.GlCode}=" & _CMB.SelectedValue & " AND {GenGL.TDATE}<=DATE(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & Day(_TDT.Value) & ")"
                    'End If
                Case ModMain.Reports.BalanceSheet
                    ReportDoc.Load(StrReportPath & "BS_H.rpt")
                    ReportDoc.SetParameterValue("ToDate", _TDT.Value)
                    ReportDoc.SetParameterValue("FromToDate", Format(_TDT.Value, "dd/MM/yyyy"))
                    StrSelectFormula = "{GenGL.TDate}<={?ToDate}"
                Case ModMain.Reports.BalanceSheetHead_Master
                    ReportDoc.Load(StrReportPath & "BsHead.rpt")
                Case ModMain.Reports.CashBook
                    Dim iCode As Int16
                    iCode = _CMB.SelectedValue
                    ReportDoc.Load(StrReportPath & "C_BBook.rpt")
                    ReportDoc.SetParameterValue("FromDate", _FDT.Value)
                    ReportDoc.SetParameterValue("CBCode", iCode)
                    ReportDoc.SetParameterValue("ToDate", _TDT.Value)
                    ReportDoc.SetParameterValue("FromToDate", Format(_FDT.Value, "dd/MM/yyyy") & "-" & Format(_TDT.Value, "dd/MM/yyyy"))
                    StrSelectFormula = "{GenGL.GLCode}=" & iCode & " and {GenGL_Opp.GLCode}<>" & iCode & " or ({GenGL_Opp.Book}='OP' AND {GenGL_Opp.GLCode}=" & iCode & ")"
                    'StrSelectFormula += " AND {GenGl_Opp.TDate}<=Date(" & _TDT.Value.Year & "," & _TDT.Value.Month & "," & _TDT.Value.Day & ")"
                Case ModMain.Reports.DailyCashBook
                    ReportDoc.Load(StrReportPath & "DlyCashBal.rpt")
                    ReportDoc.SetParameterValue("FromDate", _FDT.Value)
                    ReportDoc.SetParameterValue("FromToDate", Format(_FDT.Value, "dd/MM/yyyy") & "-" & Format(_TDT.Value, "dd/MM/yyyy"))
                    ReportDoc.SetParameterValue("Code", _CMB.SelectedValue)
                    'StrSelectFormula = "{GenGl.GlCode}=" & _CMB.SelectedValue & " AND {GenGl.TDate}<=Date(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & Day(_TDT.Value) & ")"
                    StrSelectFormula = "{Gengl.GLCode}={?Code} AND {GenGl.TDate}<=Date(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & Day(_TDT.Value) & ")"
                Case ModMain.Reports.GeneralLedgerMaster
                    ReportDoc.Load(StrReportPath & "GLMaster.rpt")
                Case ModMain.Reports.GeneralLedgerMaster_Details
                    ReportDoc.Load(StrReportPath & "GLMasterDtl.rpt")
                Case ModMain.Reports.JournalBook
                    ReportDoc.Load(StrReportPath & "JournalBook.rpt")
                    ReportDoc.SetParameterValue("FromToDate", Format(_FDT.Value, "dd/MM/yyyy") & "-" & Format(_TDT.Value, "dd/MM/yyyy"))
                    StrSelectFormula = "{GenGl.Book}='JV' AND {GenGl.Tdate}>=Date(" & Year(_FDT.Value) & "," & Month(_FDT.Value) & "," & Day(_FDT.Value) & ")" & " AND {GenGl.Tdate}<=Date(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & Day(_TDT.Value) & ")"
                Case ModMain.Reports.LabelPrinting
                    ReportDoc.Load(StrReportPath & "lblPrint.rpt")
                Case ModMain.Reports.LedgerBook
                    ReportDoc.Load(StrReportPath & "LedgerBk.rpt")
                    ReportDoc.SetParameterValue("FromDate", _FDT.Value)
                    ReportDoc.SetParameterValue("FromToDate", Format(_FDT.Value, "dd/MM/yyyy") & "-" & Format(_TDT.Value, "dd/MM/yyyy"))
                    'If _CMB.Text = "" And _CMB.SelectedIndex = -1 Then
                    StrSelectFormula = "{GenGL.TDATE}<=DATE(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & Day(_TDT.Value) & ")"
                    'Else
                    '    StrSelectFormula = "{GenGl.Part}='" & _CMB.GetItemText(_CMB.SelectedItem) & "' AND {GenGL.TDATE}<=DATE(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & Day(_TDT.Value) & ")"
                    'End If
                Case ModMain.Reports.ProfitNLoss
                    ReportDoc.Load(StrReportPath & "PLAc.rpt")
                    ReportDoc.SetParameterValue("fromtoDate", Format(_FDT.Value, "dd/MM/yyyy") & " - " & Format(_TDT.Value, "dd/MM/yyyy"))
                    StrSelectFormula = "{GLMast.indCode}='TR' or {GLMast.indCode}='PL' AND {Gengl.TDate}>=Date(" & Year(_FDT.Value) & "," & Month(_FDT.Value) & "," & Day(_FDT.Value) & ") AND {Gengl.TDate}<=Date(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & Day(_TDT.Value) & ")"
                Case ModMain.Reports.TradingAc
                    ReportDoc.Load(StrReportPath & "TrdAc.rpt")
                    ReportDoc.SetParameterValue("FromToDate", Format(_TDT.Value, "dd/MM/yyyy"))
                    StrSelectFormula = "{GlMast.IndCode}='TR' AND {Gengl.TDate}<=Date(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & Day(_TDT.Value) & ")"
                Case ModMain.Reports.TrialBalance
                    ReportDoc.Load(StrReportPath & "TrialBal.rpt")
                    ReportDoc.SetParameterValue("FromToDate", Format(_TDT.Value, "dd/MM/yyyy"))
                    If _CMB.Text = "" Or _CMB.SelectedIndex = -1 Then
                        StrSelectFormula = "{Gengl.TDate}<=Date(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & Day(_TDT.Value) & ")"
                    Else
                        StrSelectFormula = "{GlMast.IndCode}='" & _CMB.SelectedValue & "' AND {Gengl.TDate}<=Date(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & Day(_TDT.Value) & ")"
                    End If
                Case ModMain.Reports.TrialBalance_Detail
                    ReportDoc.Load(StrReportPath & "TrialBalDtl.rpt")
                    ReportDoc.SetParameterValue("FromToDate", Format(_TDT.Value, "dd/MM/yyyy"))
                    If _CMB.SelectedIndex <> -1 Then
                        StrSelectFormula = "{GlMast.IndCode}='" & _CMB.SelectedValue & "' AND {Gengl.TDate}<=Date(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & Day(_TDT.Value) & ")"
                    Else
                        StrSelectFormula = "{Gengl.TDate}<=Date(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & Day(_TDT.Value) & ")"
                    End If
                Case ModMain.Reports.TrialBalance_Namewise
                    ReportDoc.Load(StrReportPath & "TrBalop.rpt")
                    ReportDoc.SetParameterValue("FromToDate", Format(FromDate, "dd/MM/yyyy"))
                    StrSelectFormula = "{GenGl.Book}='OP'"
            End Select
            'To Load Parameter Values
            ReportDoc.SetParameterValue("CompanyName", CompName)
            ReportDoc.SetParameterValue("CompanyAddress", CompAdd)
            'To Show Report Viewer Form
            Dim RV As New ReportViewer(ReportDoc, StrSelectFormula)
            RV.MdiParent = Me.MdiParent
            RV.Show()
        Catch Ex As Exception
            MsgBox(Ex.ToString())
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub _CMB_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles _CMB.GotFocus
        SendKeys.Send("{F4}")
    End Sub

    Private Sub _FDT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles _FDT.LostFocus
        If _CMB.Visible = True Then
            _CMB.Text = ""
        End If
    End Sub

    Private Sub _CMB_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _CMB.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub _FDT_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _FDT.ValueChanged

    End Sub

    Private Sub _FDT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _FDT.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub _TDT_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _TDT.ValueChanged

    End Sub

    Private Sub _TDT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _TDT.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub _TDT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles _TDT.LostFocus
        If _CMB.Visible = True Then
            _CMB.Text = ""
        End If
    End Sub
End Class
