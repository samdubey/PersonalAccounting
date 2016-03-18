Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.OleDb
Imports Microsoft.VisualBasic
Public Class ReportOption
    Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents ChkNarr As System.Windows.Forms.CheckBox
    Friend WithEvents CmdPP As System.Windows.Forms.Button
    Friend WithEvents _TDate As System.Windows.Forms.Label
    Friend WithEvents _FDate As System.Windows.Forms.Label
    Friend WithEvents _FDT As System.Windows.Forms.DateTimePicker
    Friend WithEvents _TDT As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents _LBLCMB As System.Windows.Forms.Label
    Friend WithEvents PBTN As System.Windows.Forms.Panel
    Friend WithEvents PCOMBO As System.Windows.Forms.Panel
    Friend WithEvents PDT As System.Windows.Forms.Panel
    Friend WithEvents TxT As System.Windows.Forms.TextBox
    Friend WithEvents _CMB As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ChkNarr = New System.Windows.Forms.CheckBox
        Me.CmdExit = New System.Windows.Forms.Button
        Me.CmdPP = New System.Windows.Forms.Button
        Me._TDate = New System.Windows.Forms.Label
        Me._FDate = New System.Windows.Forms.Label
        Me._FDT = New System.Windows.Forms.DateTimePicker
        Me._TDT = New System.Windows.Forms.DateTimePicker
        Me.PBTN = New System.Windows.Forms.Panel
        Me._LBLCMB = New System.Windows.Forms.Label
        Me.PCOMBO = New System.Windows.Forms.Panel
        Me.TxT = New System.Windows.Forms.TextBox
        Me._CMB = New System.Windows.Forms.ListBox
        Me.PDT = New System.Windows.Forms.Panel
        Me.PBTN.SuspendLayout()
        Me.PCOMBO.SuspendLayout()
        Me.PDT.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChkNarr
        '
        Me.ChkNarr.Checked = True
        Me.ChkNarr.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkNarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkNarr.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNarr.Location = New System.Drawing.Point(40, 8)
        Me.ChkNarr.Name = "ChkNarr"
        Me.ChkNarr.Size = New System.Drawing.Size(136, 24)
        Me.ChkNarr.TabIndex = 0
        Me.ChkNarr.Text = "&With Narration"
        Me.ChkNarr.Visible = False
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdExit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExit.Location = New System.Drawing.Point(376, 8)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(72, 24)
        Me.CmdExit.TabIndex = 2
        Me.CmdExit.Text = "E&xit"
        '
        'CmdPP
        '
        Me.CmdPP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdPP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPP.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPP.Location = New System.Drawing.Point(272, 8)
        Me.CmdPP.Name = "CmdPP"
        Me.CmdPP.Size = New System.Drawing.Size(96, 24)
        Me.CmdPP.TabIndex = 1
        Me.CmdPP.Text = "&Print Preview"
        '
        '_TDate
        '
        Me._TDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TDate.Location = New System.Drawing.Point(8, 31)
        Me._TDate.Name = "_TDate"
        Me._TDate.Size = New System.Drawing.Size(100, 16)
        Me._TDate.TabIndex = 2
        Me._TDate.Text = "&To Date    :"
        '
        '_FDate
        '
        Me._FDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FDate.Location = New System.Drawing.Point(8, 7)
        Me._FDate.Name = "_FDate"
        Me._FDate.Size = New System.Drawing.Size(100, 16)
        Me._FDate.TabIndex = 0
        Me._FDate.Text = "&From Date :"
        '
        '_FDT
        '
        Me._FDT.CustomFormat = "dd-MM-yyyy"
        Me._FDT.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._FDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me._FDT.Location = New System.Drawing.Point(128, 7)
        Me._FDT.Name = "_FDT"
        Me._FDT.Size = New System.Drawing.Size(120, 23)
        Me._FDT.TabIndex = 1
        '
        '_TDT
        '
        Me._TDT.CustomFormat = "dd-MM-yyyy"
        Me._TDT.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me._TDT.Location = New System.Drawing.Point(128, 31)
        Me._TDT.Name = "_TDT"
        Me._TDT.Size = New System.Drawing.Size(120, 23)
        Me._TDT.TabIndex = 3
        '
        'PBTN
        '
        Me.PBTN.Controls.Add(Me.CmdExit)
        Me.PBTN.Controls.Add(Me.CmdPP)
        Me.PBTN.Controls.Add(Me.ChkNarr)
        Me.PBTN.Dock = System.Windows.Forms.DockStyle.Top
        Me.PBTN.Location = New System.Drawing.Point(0, 256)
        Me.PBTN.Name = "PBTN"
        Me.PBTN.Size = New System.Drawing.Size(464, 40)
        Me.PBTN.TabIndex = 2
        '
        '_LBLCMB
        '
        Me._LBLCMB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LBLCMB.Location = New System.Drawing.Point(8, 8)
        Me._LBLCMB.Name = "_LBLCMB"
        Me._LBLCMB.Size = New System.Drawing.Size(100, 16)
        Me._LBLCMB.TabIndex = 0
        Me._LBLCMB.Text = "Select"
        '
        'PCOMBO
        '
        Me.PCOMBO.Controls.Add(Me.TxT)
        Me.PCOMBO.Controls.Add(Me._CMB)
        Me.PCOMBO.Controls.Add(Me._LBLCMB)
        Me.PCOMBO.Dock = System.Windows.Forms.DockStyle.Top
        Me.PCOMBO.Location = New System.Drawing.Point(0, 64)
        Me.PCOMBO.Name = "PCOMBO"
        Me.PCOMBO.Size = New System.Drawing.Size(464, 192)
        Me.PCOMBO.TabIndex = 1
        '
        'TxT
        '
        Me.TxT.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxT.Location = New System.Drawing.Point(128, 8)
        Me.TxT.Name = "TxT"
        Me.TxT.Size = New System.Drawing.Size(328, 23)
        Me.TxT.TabIndex = 1
        Me.TxT.Text = ""
        '
        '_CMB
        '
        Me._CMB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CMB.ItemHeight = 16
        Me._CMB.Location = New System.Drawing.Point(128, 32)
        Me._CMB.Name = "_CMB"
        Me._CMB.Size = New System.Drawing.Size(328, 148)
        Me._CMB.TabIndex = 2
        Me._CMB.TabStop = False
        '
        'PDT
        '
        Me.PDT.Controls.Add(Me._TDT)
        Me.PDT.Controls.Add(Me._FDate)
        Me.PDT.Controls.Add(Me._TDate)
        Me.PDT.Controls.Add(Me._FDT)
        Me.PDT.Dock = System.Windows.Forms.DockStyle.Top
        Me.PDT.Location = New System.Drawing.Point(0, 0)
        Me.PDT.Name = "PDT"
        Me.PDT.Size = New System.Drawing.Size(464, 64)
        Me.PDT.TabIndex = 0
        '
        'ReportOption
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(464, 293)
        Me.Controls.Add(Me.PBTN)
        Me.Controls.Add(Me.PCOMBO)
        Me.Controls.Add(Me.PDT)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "ReportOption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options - "
        Me.PBTN.ResumeLayout(False)
        Me.PCOMBO.ResumeLayout(False)
        Me.PDT.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ReportName As Reports
    Dim WithEvents ReportDoc As ReportDocument
    Private Sub FillCombo()
        Dim Con As OleDbConnection
        Dim Da As OleDbDataAdapter
        Dim Ds As New DataSet
        Dim StrSql As String = ""
        Dim i As Int16
        Con = New OleDbConnection(ConStr)
        Select Case ReportName
            Case ModMain.Reports.AccountStatement, ModMain.Reports.AccountStatementDetail
                StrSql = "SELECT Part,GlCode as V FROM GlMAST Order By Part"
            Case ModMain.Reports.LedgerBook, ModMain.Reports.TrialBalance, ModMain.Reports.TrialBalance_Detail
                StrSql = "SELECT IndCode as V,Part FROM BsHead Order by Part"
            Case Reports.CashBook, ModMain.Reports.DailyCashBook
                StrSql = "SELECT Part,GlCode AS V FROM GlMast WHERE IndCode='BB' ORDER BY PART"
        End Select
        If StrSql <> "" Then
            Try
                Con.Open()
                Da = New OleDbDataAdapter(StrSql, Con)
                Da.Fill(Ds, "A")
                _CMB.DataSource = Ds
                _CMB.DisplayMember = "A.Part"
                _CMB.ValueMember = "A.V"
            Catch Ex As Exception
                MsgBox(Ex.Message)
            Finally
                Con.Close()
            End Try
        End If
    End Sub
    Private Sub HideALL()
        '_LBLCMB.Hide()
        '_TDate.Hide()
        '_FDate.Hide()
        '_TDT.Hide()
        '_FDT.Hide()
        '_CMB.Hide()
        PDT.Hide()
        PCOMBO.Hide()
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
        PCOMBO.Visible = CCntl
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Close()
    End Sub
    Private Sub CmdPP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPP.Click
        Me.Cursor = Cursors.WaitCursor
        Me.MdiParent.Cursor = Cursors.WaitCursor
        Try
            ReportDoc = New ReportDocument
            Dim StrReportPath As String = Application.StartupPath & "\Reports\"
            Dim StrSelectFormula As String = ""
            Select Case ReportName
                Case ModMain.Reports.AccountStatement
                    ReportDoc.Load(StrReportPath & "AcStat.rpt")
                    ReportDoc.SetParameterValue("FromDate", _FDT.Value)
                    ReportDoc.SetParameterValue("FromToDate", Format(_FDT.Value, "dd/MM/yyyy") & "-" & Format(_TDT.Value, "dd/MM/yyyy"))
                    If TxT.Text = "" Then
                        StrSelectFormula = "{GenGL.TDATE}<=DATE(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & _TDT.Value.Day & ")"
                    Else
                        StrSelectFormula = "{GenGl.GlCode}=" & _CMB.SelectedValue & " AND {GenGL.TDATE}<=DATE(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & _TDT.Value.Day & ")"
                    End If
                Case ModMain.Reports.AccountStatementDetail
                    ReportDoc.Load(StrReportPath & "AcStatD.rpt")
                    ReportDoc.SetParameterValue("FromDate", _FDT.Value)
                    ReportDoc.SetParameterValue("FromToDate", Format(_FDT.Value, "dd/MM/yyyy") & "-" & Format(_TDT.Value, "dd/MM/yyyy"))
                    ReportDoc.SetParameterValue("CBCode", _CMB.SelectedValue)
                    ReportDoc.SetParameterValue("WithNarr", ChkNarr.Checked)
                    StrSelectFormula = "{GenGLOPP.TDATE}<=DATE(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & _TDT.Value.Day & ")"
                    StrSelectFormula += " AND {GenGL.GLCode}={?CBCode} and {GenGLOpp.GLCode}<>{?CBCode} or ({GenGLOpp.Book}='OP' AND {GenGLOpp.GLCode}={?CBCode})"
                    'StrSelectFormula = "{GenGl.GlCode}=" & _CMB.SelectedValue & " AND {GenGL.TDATE}<=DATE(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & Day(_TDT.Value) & ")"
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
                    ReportDoc.SetParameterValue("WithNarr", ChkNarr.Checked)
                    StrSelectFormula = "{GenGL.GLCode}=" & iCode & " and {GenGL_Opp.GLCode}<>" & iCode & " or ({GenGL_Opp.Book}='OP' AND {GenGL_Opp.GLCode}=" & iCode & ")"
                    'StrSelectFormula += " AND {GenGl_Opp.TDate}<=Date(" & _TDT.Value.Year & "," & _TDT.Value.Month & "," & _TDT.Value.Day & ")"
                Case ModMain.Reports.DailyCashBook
                    ReportDoc.Load(StrReportPath & "DlyCashBal.rpt")
                    ReportDoc.SetParameterValue("FromDate", _FDT.Value)
                    ReportDoc.SetParameterValue("FromToDate", Format(_FDT.Value, "dd/MM/yyyy") & "-" & Format(_TDT.Value, "dd/MM/yyyy"))
                    ReportDoc.SetParameterValue("Code", _CMB.SelectedValue)
                    'StrSelectFormula = "{GenGl.GlCode}=" & _CMB.SelectedValue & " AND {GenGl.TDate}<=Date(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & Day(_TDT.Value) & ")"
                    StrSelectFormula = "{Gengl.GLCode}={?Code} AND {GenGl.TDate}<=Date(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & _TDT.Value.Day & ")"
                Case ModMain.Reports.GeneralLedgerMaster
                    ReportDoc.Load(StrReportPath & "GLMaster.rpt")
                Case ModMain.Reports.GeneralLedgerMaster_Details
                    ReportDoc.Load(StrReportPath & "GLMasterDtl.rpt")
                Case ModMain.Reports.JournalBook
                    ReportDoc.Load(StrReportPath & "JournalBook.rpt")
                    ReportDoc.SetParameterValue("FromToDate", Format(_FDT.Value, "dd/MM/yyyy") & "-" & Format(_TDT.Value, "dd/MM/yyyy"))
                    ReportDoc.SetParameterValue("WithNarr", ChkNarr.Checked)
                    StrSelectFormula = "{GenGl.Book}='JV' AND {GenGl.Tdate}>=Date(" & Year(_FDT.Value) & "," & Month(_FDT.Value) & "," & _FDT.Value.Day & ")" & " AND {GenGl.Tdate}<=Date(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & _TDT.Value.Day & ")"
                Case ModMain.Reports.LabelPrinting
                    ReportDoc.Load(StrReportPath & "lblPrint.rpt")
                Case ModMain.Reports.LedgerBook
                    ReportDoc.Load(StrReportPath & "LedgerBk.rpt")
                    ReportDoc.SetParameterValue("FromDate", _FDT.Value)
                    ReportDoc.SetParameterValue("FromToDate", Format(_FDT.Value, "dd/MM/yyyy") & "-" & Format(_TDT.Value, "dd/MM/yyyy"))
                    If TxT.Text = "" Then
                        StrSelectFormula = "{GenGL.TDATE}<=DATE(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & _TDT.Value.Day & ")"
                    Else
                        StrSelectFormula = "{GenGl.Part}='" & _CMB.GetItemText(_CMB.SelectedItem) & "' AND {GenGL.TDATE}<=DATE(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & Day(_TDT.Value) & ")"
                    End If
                Case ModMain.Reports.ProfitNLoss
                        ReportDoc.Load(StrReportPath & "PLAc.rpt")
                        ReportDoc.SetParameterValue("fromtoDate", Format(_FDT.Value, "dd/MM/yyyy") & " - " & Format(_TDT.Value, "dd/MM/yyyy"))
                        StrSelectFormula = "{GLMast.indCode}='TR' or {GLMast.indCode}='PL' AND {Gengl.TDate}>=Date(" & Year(_FDT.Value) & "," & Month(_FDT.Value) & "," & _FDT.Value.Day & ") AND {Gengl.TDate}<=Date(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & _TDT.Value.Day & ")"
                Case ModMain.Reports.TradingAc
                        ReportDoc.Load(StrReportPath & "TrdAc.rpt")
                        ReportDoc.SetParameterValue("FromToDate", Format(_TDT.Value, "dd/MM/yyyy"))
                        StrSelectFormula = "{GlMast.IndCode}='TR' AND {Gengl.TDate}<=Date(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & _TDT.Value.Day & ")"
                Case ModMain.Reports.TrialBalance
                        ReportDoc.Load(StrReportPath & "TrialBal.rpt")
                        ReportDoc.SetParameterValue("FromToDate", Format(_TDT.Value, "dd/MM/yyyy"))
                    If Trim(TxT.Text) = "" Then
                        StrSelectFormula = "{Gengl.TDate}<=Date(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & _TDT.Value.Day & ")"
                    Else
                        StrSelectFormula = "{GlMast.IndCode}='" & _CMB.SelectedValue & "' AND {Gengl.TDate}<=Date(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & _TDT.Value.Day & ")"
                    End If
                Case ModMain.Reports.TrialBalance_Detail
                        ReportDoc.Load(StrReportPath & "TrialBalDtl.rpt")
                        ReportDoc.SetParameterValue("FromToDate", Format(_TDT.Value, "dd/MM/yyyy"))
                    If Trim(TxT.Text) <> "" Then
                        StrSelectFormula = "{GlMast.IndCode}='" & _CMB.SelectedValue & "' AND {Gengl.TDate}<=Date(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & _TDT.Value.Day & ")"
                    Else
                        StrSelectFormula = "{Gengl.TDate}<=Date(" & Year(_TDT.Value) & "," & Month(_TDT.Value) & "," & _TDT.Value.Day & ")"
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
            Me.MdiParent.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ReportAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                    _LBLCMB.Text = "&Ac Name:"
                    View(True, True, True)
                    ChkNarr.Show()
                Case ModMain.Reports.DailyCashBook
                    Me.Text += "Daily Cash & Bank Book"
                    _LBLCMB.Text = "&A/c Name:"
                    View(True, True, True)
                Case ModMain.Reports.JournalBook
                    Me.Text += "Journal Book"
                    View(True, True, False)
                    ChkNarr.Show()
                Case ModMain.Reports.AccountStatement
                    Me.Text += "Account Statement"
                    _LBLCMB.Text = "&A/c Name:"
                    ViewAll()
                Case ModMain.Reports.AccountStatementDetail
                    Me.Text += "Account Statement [Detail]"
                    _LBLCMB.Text = "&A/c Name:"
                    ViewAll()
                    ChkNarr.Show()
                Case ModMain.Reports.TrialBalance
                    Me.Text += "Trial Balance"
                    _LBLCMB.Text = "&Group :"
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
            TxT.Text = ""
        Catch Ex As Exception
            MsgBox(Ex.ToString)
        End Try
    End Sub

    Private Sub TxT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxT.TextChanged
        Dim z As Int16 = TxT.Text.Length
        _CMB.SelectedIndex = _CMB.FindString(TxT.Text)
        _CMB.TopIndex = _CMB.SelectedIndex
        If _CMB.SelectedIndex > -1 Then
            TxT.Text = _CMB.GetItemText(_CMB.SelectedItem)
            If TxT.Text.Length >= z Then
                TxT.Select(z, TxT.Text.Length - z)
            End If
        End If
    End Sub

    Private Sub _CMB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _CMB.SelectedIndexChanged
        Select Case ReportName
            Case ModMain.Reports.AccountStatement, ModMain.Reports.AccountStatementDetail, ModMain.Reports.CashBook, ModMain.Reports.DailyCashBook
                TxT.Text = _CMB.GetItemText(_CMB.SelectedItem)
        End Select
    End Sub

    Private Sub TxT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxT.KeyDown
        Select Case e.KeyCode
            Case Keys.Down
                If _CMB.SelectedIndex < _CMB.Items.Count - 1 Then
                    _CMB.SelectedIndex += 1
                End If
            Case Keys.Up
                If _CMB.SelectedIndex > 0 Then
                    _CMB.SelectedIndex -= 1
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
        End Select
    End Sub

    Private Sub ReportOption_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class
