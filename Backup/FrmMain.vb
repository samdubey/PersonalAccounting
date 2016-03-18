Public Class FrmMain
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
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents MnuDataEntry As System.Windows.Forms.MenuItem
    Friend WithEvents MnuD_AM As System.Windows.Forms.MenuItem
    Friend WithEvents MnuD_CR As System.Windows.Forms.MenuItem
    Friend WithEvents MnuD_CP As System.Windows.Forms.MenuItem
    Friend WithEvents MnuD_J As System.Windows.Forms.MenuItem
    Friend WithEvents MnuReport As System.Windows.Forms.MenuItem
    Friend WithEvents MnuR_AM As System.Windows.Forms.MenuItem
    Friend WithEvents MnuR_CB As System.Windows.Forms.MenuItem
    Friend WithEvents MnuR_JB As System.Windows.Forms.MenuItem
    Friend WithEvents MnuR_AEs As System.Windows.Forms.MenuItem
    Friend WithEvents MnuMISR As System.Windows.Forms.MenuItem
    Friend WithEvents MnuMR_TB As System.Windows.Forms.MenuItem
    Friend WithEvents MnuMR_BS As System.Windows.Forms.MenuItem
    Friend WithEvents MnuMR_LP As System.Windows.Forms.MenuItem
    Friend WithEvents MnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents MnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents MnuAbtUs As System.Windows.Forms.MenuItem
    Friend WithEvents MnuProInfo As System.Windows.Forms.MenuItem
    Friend WithEvents MnuHHelp As System.Windows.Forms.MenuItem
    Friend WithEvents MnuUtility As System.Windows.Forms.MenuItem
    Friend WithEvents MnuU_Calc As System.Windows.Forms.MenuItem
    Friend WithEvents MnuU_Note As System.Windows.Forms.MenuItem
    Friend WithEvents MnuU_BackUp As System.Windows.Forms.MenuItem
    Friend WithEvents MnuU_CD As System.Windows.Forms.MenuItem
    Friend WithEvents MnuU_UC As System.Windows.Forms.MenuItem
    Friend WithEvents MnuU_CC As System.Windows.Forms.MenuItem
    Friend WithEvents MnuBar1 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuBar2 As System.Windows.Forms.MenuItem
    Friend WithEvents StatBar As System.Windows.Forms.StatusBar
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents BMoveFirst As System.Windows.Forms.ToolBarButton
    Friend WithEvents BMoveNext As System.Windows.Forms.ToolBarButton
    Friend WithEvents BMovePrevious As System.Windows.Forms.ToolBarButton
    Friend WithEvents BMoveLast As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImgLst As System.Windows.Forms.ImageList
    Friend WithEvents MNU_CBK As System.Windows.Forms.MenuItem
    Friend WithEvents MNU_DCB As System.Windows.Forms.MenuItem
    Friend WithEvents MNU_JBK As System.Windows.Forms.MenuItem
    Friend WithEvents TRLBAL As System.Windows.Forms.MenuItem
    Friend WithEvents TRADE As System.Windows.Forms.MenuItem
    Friend WithEvents TBS As System.Windows.Forms.MenuItem
    Friend WithEvents TBD As System.Windows.Forms.MenuItem
    Friend WithEvents TBNW As System.Windows.Forms.MenuItem
    Friend WithEvents PL As System.Windows.Forms.MenuItem
    Friend WithEvents BS As System.Windows.Forms.MenuItem
    Friend WithEvents GLM As System.Windows.Forms.MenuItem
    Friend WithEvents GLMD As System.Windows.Forms.MenuItem
    Friend WithEvents BSHM As System.Windows.Forms.MenuItem
    Friend WithEvents LBP As System.Windows.Forms.MenuItem
    Friend WithEvents LB As System.Windows.Forms.MenuItem
    Friend WithEvents MnuGC As System.Windows.Forms.MenuItem
    Friend WithEvents MnuMT As System.Windows.Forms.MenuItem
    Friend WithEvents MnuLogOut As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_AcExD As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_AcDet As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmMain))
        Me.MainMenu = New System.Windows.Forms.MainMenu
        Me.MnuDataEntry = New System.Windows.Forms.MenuItem
        Me.MnuGC = New System.Windows.Forms.MenuItem
        Me.MnuD_AM = New System.Windows.Forms.MenuItem
        Me.MnuD_CP = New System.Windows.Forms.MenuItem
        Me.MnuD_CR = New System.Windows.Forms.MenuItem
        Me.MnuD_J = New System.Windows.Forms.MenuItem
        Me.MnuBar1 = New System.Windows.Forms.MenuItem
        Me.MnuExit = New System.Windows.Forms.MenuItem
        Me.MnuReport = New System.Windows.Forms.MenuItem
        Me.MnuMISR = New System.Windows.Forms.MenuItem
        Me.MnuMR_BS = New System.Windows.Forms.MenuItem
        Me.MnuMR_TB = New System.Windows.Forms.MenuItem
        Me.MnuMR_LP = New System.Windows.Forms.MenuItem
        Me.Mnu_AcExD = New System.Windows.Forms.MenuItem
        Me.MnuBar2 = New System.Windows.Forms.MenuItem
        Me.MnuR_AM = New System.Windows.Forms.MenuItem
        Me.MNU_CBK = New System.Windows.Forms.MenuItem
        Me.MNU_DCB = New System.Windows.Forms.MenuItem
        Me.MNU_JBK = New System.Windows.Forms.MenuItem
        Me.MnuR_AEs = New System.Windows.Forms.MenuItem
        Me.Mnu_AcDet = New System.Windows.Forms.MenuItem
        Me.LB = New System.Windows.Forms.MenuItem
        Me.MnuR_CB = New System.Windows.Forms.MenuItem
        Me.TRLBAL = New System.Windows.Forms.MenuItem
        Me.TBNW = New System.Windows.Forms.MenuItem
        Me.TBD = New System.Windows.Forms.MenuItem
        Me.TBS = New System.Windows.Forms.MenuItem
        Me.TRADE = New System.Windows.Forms.MenuItem
        Me.PL = New System.Windows.Forms.MenuItem
        Me.BS = New System.Windows.Forms.MenuItem
        Me.MnuR_JB = New System.Windows.Forms.MenuItem
        Me.GLM = New System.Windows.Forms.MenuItem
        Me.GLMD = New System.Windows.Forms.MenuItem
        Me.BSHM = New System.Windows.Forms.MenuItem
        Me.LBP = New System.Windows.Forms.MenuItem
        Me.MnuUtility = New System.Windows.Forms.MenuItem
        Me.MnuU_Calc = New System.Windows.Forms.MenuItem
        Me.MnuU_Note = New System.Windows.Forms.MenuItem
        Me.MnuU_BackUp = New System.Windows.Forms.MenuItem
        Me.MnuU_CD = New System.Windows.Forms.MenuItem
        Me.MnuMT = New System.Windows.Forms.MenuItem
        Me.MnuU_UC = New System.Windows.Forms.MenuItem
        Me.MnuU_CC = New System.Windows.Forms.MenuItem
        Me.MnuLogOut = New System.Windows.Forms.MenuItem
        Me.MnuHelp = New System.Windows.Forms.MenuItem
        Me.MnuAbtUs = New System.Windows.Forms.MenuItem
        Me.MnuProInfo = New System.Windows.Forms.MenuItem
        Me.MnuHHelp = New System.Windows.Forms.MenuItem
        Me.StatBar = New System.Windows.Forms.StatusBar
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.BMoveFirst = New System.Windows.Forms.ToolBarButton
        Me.BMovePrevious = New System.Windows.Forms.ToolBarButton
        Me.BMoveNext = New System.Windows.Forms.ToolBarButton
        Me.BMoveLast = New System.Windows.Forms.ToolBarButton
        Me.ImgLst = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuDataEntry, Me.MnuReport, Me.MnuUtility, Me.MnuHelp})
        '
        'MnuDataEntry
        '
        Me.MnuDataEntry.Index = 0
        Me.MnuDataEntry.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuGC, Me.MnuD_AM, Me.MnuD_CP, Me.MnuD_CR, Me.MnuD_J, Me.MnuBar1, Me.MnuExit})
        Me.MnuDataEntry.Text = "&Data Entry"
        '
        'MnuGC
        '
        Me.MnuGC.Index = 0
        Me.MnuGC.Shortcut = System.Windows.Forms.Shortcut.CtrlG
        Me.MnuGC.Text = "&Group Creation"
        '
        'MnuD_AM
        '
        Me.MnuD_AM.Index = 1
        Me.MnuD_AM.Shortcut = System.Windows.Forms.Shortcut.CtrlA
        Me.MnuD_AM.Text = "&Account Master"
        '
        'MnuD_CP
        '
        Me.MnuD_CP.Index = 2
        Me.MnuD_CP.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MnuD_CP.Text = "&Payment Voucher"
        '
        'MnuD_CR
        '
        Me.MnuD_CR.Index = 3
        Me.MnuD_CR.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MnuD_CR.Text = "&Receipt Voucher"
        '
        'MnuD_J
        '
        Me.MnuD_J.Index = 4
        Me.MnuD_J.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MnuD_J.Text = "&Journal Voucher"
        '
        'MnuBar1
        '
        Me.MnuBar1.Index = 5
        Me.MnuBar1.Text = "-"
        '
        'MnuExit
        '
        Me.MnuExit.Index = 6
        Me.MnuExit.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        Me.MnuExit.Text = "E&xit"
        '
        'MnuReport
        '
        Me.MnuReport.Index = 1
        Me.MnuReport.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuMISR, Me.MnuBar2, Me.MnuR_AM, Me.MnuR_CB, Me.MnuR_JB})
        Me.MnuReport.Text = "&Reports"
        '
        'MnuMISR
        '
        Me.MnuMISR.Index = 0
        Me.MnuMISR.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuMR_BS, Me.MnuMR_TB, Me.MnuMR_LP, Me.Mnu_AcExD})
        Me.MnuMISR.Text = "Drill Down Menu"
        '
        'MnuMR_BS
        '
        Me.MnuMR_BS.Index = 0
        Me.MnuMR_BS.Text = "Balance Sheet"
        Me.MnuMR_BS.Visible = False
        '
        'MnuMR_TB
        '
        Me.MnuMR_TB.Index = 1
        Me.MnuMR_TB.Shortcut = System.Windows.Forms.Shortcut.CtrlT
        Me.MnuMR_TB.Text = "Trial Balance"
        '
        'MnuMR_LP
        '
        Me.MnuMR_LP.Index = 2
        Me.MnuMR_LP.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.MnuMR_LP.Text = "Account Statement"
        '
        'Mnu_AcExD
        '
        Me.Mnu_AcExD.Index = 3
        Me.Mnu_AcExD.Text = "Account Statement Detail"
        '
        'MnuBar2
        '
        Me.MnuBar2.Index = 1
        Me.MnuBar2.Text = "-"
        '
        'MnuR_AM
        '
        Me.MnuR_AM.Index = 2
        Me.MnuR_AM.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MNU_CBK, Me.MNU_DCB, Me.MNU_JBK, Me.MnuR_AEs, Me.Mnu_AcDet, Me.LB})
        Me.MnuR_AM.Text = "Statutory Books"
        '
        'MNU_CBK
        '
        Me.MNU_CBK.Index = 0
        Me.MNU_CBK.Text = "&Cash && Bank Book"
        '
        'MNU_DCB
        '
        Me.MNU_DCB.Index = 1
        Me.MNU_DCB.Text = "&Daily Cash && Bank Balace"
        '
        'MNU_JBK
        '
        Me.MNU_JBK.Index = 2
        Me.MNU_JBK.Text = "&Journal Book"
        '
        'MnuR_AEs
        '
        Me.MnuR_AEs.Index = 3
        Me.MnuR_AEs.Text = "Account Statement"
        '
        'Mnu_AcDet
        '
        Me.Mnu_AcDet.Index = 4
        Me.Mnu_AcDet.Text = "Account Statement Detail"
        '
        'LB
        '
        Me.LB.Index = 5
        Me.LB.Text = "Ledger Book"
        '
        'MnuR_CB
        '
        Me.MnuR_CB.Index = 3
        Me.MnuR_CB.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.TRLBAL, Me.TRADE, Me.PL, Me.BS})
        Me.MnuR_CB.Text = "&Trial Balance &&  Balance Sheet"
        '
        'TRLBAL
        '
        Me.TRLBAL.Index = 0
        Me.TRLBAL.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.TBNW, Me.TBD, Me.TBS})
        Me.TRLBAL.Text = "Trial &Balance"
        '
        'TBNW
        '
        Me.TBNW.Index = 0
        Me.TBNW.Text = "Trial Balance Opening"
        '
        'TBD
        '
        Me.TBD.Index = 1
        Me.TBD.Text = "Trial Balance Detail"
        '
        'TBS
        '
        Me.TBS.Index = 2
        Me.TBS.Text = "Trial Balance Simple"
        '
        'TRADE
        '
        Me.TRADE.Index = 1
        Me.TRADE.Text = "&Trading A/c"
        '
        'PL
        '
        Me.PL.Index = 2
        Me.PL.Text = "&Profit && Loss A/c"
        '
        'BS
        '
        Me.BS.Index = 3
        Me.BS.Text = "Balance Sheet"
        '
        'MnuR_JB
        '
        Me.MnuR_JB.Index = 4
        Me.MnuR_JB.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.GLM, Me.GLMD, Me.BSHM, Me.LBP})
        Me.MnuR_JB.Text = "Master Book"
        '
        'GLM
        '
        Me.GLM.Index = 0
        Me.GLM.Text = "&General Ledger Master"
        '
        'GLMD
        '
        Me.GLMD.Index = 1
        Me.GLMD.Text = "General Ledger Master &Details"
        '
        'BSHM
        '
        Me.BSHM.Index = 2
        Me.BSHM.Text = "Balance Sheet Head Master"
        '
        'LBP
        '
        Me.LBP.Index = 3
        Me.LBP.Text = "Label Printing"
        '
        'MnuUtility
        '
        Me.MnuUtility.Index = 2
        Me.MnuUtility.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuU_Calc, Me.MnuU_Note, Me.MnuU_BackUp, Me.MnuU_CD, Me.MnuMT, Me.MnuU_UC, Me.MnuU_CC, Me.MnuLogOut})
        Me.MnuUtility.Text = "&Utility"
        '
        'MnuU_Calc
        '
        Me.MnuU_Calc.Index = 0
        Me.MnuU_Calc.Text = "&Calculator"
        '
        'MnuU_Note
        '
        Me.MnuU_Note.Index = 1
        Me.MnuU_Note.Text = "&Notepad"
        '
        'MnuU_BackUp
        '
        Me.MnuU_BackUp.Index = 2
        Me.MnuU_BackUp.MergeType = System.Windows.Forms.MenuMerge.Replace
        Me.MnuU_BackUp.Text = "&BackUp && Restore"
        '
        'MnuU_CD
        '
        Me.MnuU_CD.Index = 3
        Me.MnuU_CD.Text = "Compact &Database"
        '
        'MnuMT
        '
        Me.MnuMT.Index = 4
        Me.MnuMT.Text = "&Master Transfer"
        '
        'MnuU_UC
        '
        Me.MnuU_UC.Index = 5
        Me.MnuU_UC.Text = "U&ser Master"
        '
        'MnuU_CC
        '
        Me.MnuU_CC.Index = 6
        Me.MnuU_CC.Text = "Company C&reation"
        '
        'MnuLogOut
        '
        Me.MnuLogOut.Index = 7
        Me.MnuLogOut.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.MnuLogOut.Text = "Log &Out"
        '
        'MnuHelp
        '
        Me.MnuHelp.Index = 3
        Me.MnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuAbtUs, Me.MnuProInfo, Me.MnuHHelp})
        Me.MnuHelp.Text = "&Help"
        '
        'MnuAbtUs
        '
        Me.MnuAbtUs.Index = 0
        Me.MnuAbtUs.Text = "&About Us"
        '
        'MnuProInfo
        '
        Me.MnuProInfo.Index = 1
        Me.MnuProInfo.Text = "&Product Info"
        '
        'MnuHHelp
        '
        Me.MnuHHelp.Index = 2
        Me.MnuHHelp.Text = "He&lp"
        '
        'StatBar
        '
        Me.StatBar.Enabled = False
        Me.StatBar.Location = New System.Drawing.Point(0, 273)
        Me.StatBar.Name = "StatBar"
        Me.StatBar.ShowPanels = True
        Me.StatBar.Size = New System.Drawing.Size(520, 24)
        Me.StatBar.TabIndex = 7
        Me.StatBar.Tag = ""
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.BMoveFirst, Me.BMovePrevious, Me.BMoveNext, Me.BMoveLast})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImgLst
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(520, 28)
        Me.ToolBar1.TabIndex = 9
        '
        'BMoveFirst
        '
        Me.BMoveFirst.ImageIndex = 0
        '
        'BMovePrevious
        '
        Me.BMovePrevious.ImageIndex = 1
        '
        'BMoveNext
        '
        Me.BMoveNext.ImageIndex = 2
        '
        'BMoveLast
        '
        Me.BMoveLast.ImageIndex = 3
        '
        'ImgLst
        '
        Me.ImgLst.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImgLst.ImageStream = CType(resources.GetObject("ImgLst.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgLst.TransparentColor = System.Drawing.Color.Transparent
        '
        'FrmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(520, 297)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.StatBar)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu
        Me.Name = "FrmMain"
        Me.Text = "Personnal Accounts"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub MnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuExit.Click
        Me.Close()
    End Sub

    Private Sub MnuU_Calc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuU_Calc.Click
        Shell("Calc.exe", AppWinStyle.NormalFocus, False)
    End Sub

    Private Sub MnuU_Note_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuU_Note.Click
        Shell("Notepad.exe", AppWinStyle.NormalFocus, False)
    End Sub
    Private Sub MnuD_AM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuD_AM.Click
        Dim FrmAMNew As New FrmAM
        FrmAMNew.MdiParent = Me
        FrmAMNew.Show()
    End Sub

    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(Application.StartupPath & "\Images\BkImg.jpg") = True Then
            Me.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\BkImg.jpg")
        End If
        Dim ShowCompany As New FrmShowCompany
        Dim NewLogin As New Login
        ShowCompany.ShowInTaskbar = False
        ShowCompany.ShowDialog()
        ConStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBPath & ";Persist Security Info=False"
        CreateDSN()
        NewLogin.ShowDialog()
        CreateStatusBarPanels()
        If imUser.GetUserLevel = UserLogin.UserLevel.OWNER Then
            MnuMT.Visible = True
        Else
            MnuMT.Visible = False
        End If
    End Sub
    Public Sub CreateStatusBarPanels()
        StatBar.Panels.Clear()
        StatBar.Panels.Add(CompName)
        StatBar.Panels.Add("Financial Year : " & FromDate.Year & " - " & ToDate.Year)
        StatBar.Panels.Add(Format(Today, "dd/MM/yyyy"))
        StatBar.Panels.Add("Current User : " & imUser.GetUserID)
        StatBar.Panels(0).AutoSize = StatusBarPanelAutoSize.Spring
        StatBar.Panels(1).AutoSize = StatusBarPanelAutoSize.Contents
        StatBar.Panels(2).AutoSize = StatusBarPanelAutoSize.Contents
        StatBar.Panels(0).BorderStyle = StatusBarPanelBorderStyle.Sunken
        StatBar.Panels(1).BorderStyle = StatusBarPanelBorderStyle.Sunken
        StatBar.Panels(2).BorderStyle = StatusBarPanelBorderStyle.Sunken
        StatBar.ShowPanels = True
    End Sub

    Private Sub MnuD_CR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuD_CR.Click
        Dim NewCashReceipt As New CashReceipt
        NewCashReceipt.MdiParent = Me
        NewCashReceipt.Text = "Receipt Voucher"
        NewCashReceipt.Tag = "RV"
        NewCashReceipt.Show()
    End Sub

    Private Sub MnuD_J_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuD_J.Click
        Dim FrmJournal As New Journal
        FrmJournal.MdiParent = Me
        FrmJournal.Tag = "JV"
        FrmJournal.Show()
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case e.Button.ImageIndex
            Case 0
                StrNavigation = ModMain.Navigation.MoveFirst
            Case 1
                StrNavigation = ModMain.Navigation.MovePrevious
            Case 2
                StrNavigation = ModMain.Navigation.MoveNext
            Case 3
                StrNavigation = ModMain.Navigation.MoveLast
        End Select
        SendKeys.Send("{F2}")
    End Sub

    Private Sub MnuD_CP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuD_CP.Click
        Dim NewPayment As New CashReceipt
        NewPayment.MdiParent = Me
        NewPayment.Text = "Payment Voucher"
        NewPayment.Tag = "PV"
        NewPayment.Show()
    End Sub

    Private Sub MnuMR_TB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuMR_TB.Click
        Dim newtrlbal As New TrialBalance
        newtrlbal.MdiParent = Me
        newtrlbal.Show()
    End Sub

    Private Sub MnuR_AEi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim NReportViewer As New ReportViewer
        NReportViewer.MdiParent = Me
        NReportViewer.Show()
    End Sub

    Private Sub MnuR_AEs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuR_AEs.Click
        Dim RO As New ReportOption(Reports.AccountStatement)
        RO.MdiParent = Me
        RO.Show()
    End Sub

    Private Sub rd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim NJv As New JV
        NJv.MdiParent = Me
        NJv.Show()
    End Sub

    Private Sub MnuU_CC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuU_CC.Click
        Dim NewComp As New FrmCreateCompany
        NewComp.MdiParent = Me
        NewComp.Show()
    End Sub

    Private Sub MnuMR_LP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuMR_LP.Click
        Dim NewAcS As New AcExtract
        NewAcS.MdiParent = Me
        NewAcS.Show()
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GLMD.Click
        Dim RO As New ReportOption(Reports.GeneralLedgerMaster_Details)
        RO.MdiParent = Me
        RO.Show()
    End Sub

    Private Sub MNU_CBK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNU_CBK.Click
        Dim RO As New ReportOption(Reports.CashBook)
        RO.MdiParent = Me
        RO.Show()
    End Sub

    Private Sub MNU_DCB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNU_DCB.Click
        Dim RO As New ReportOption(Reports.DailyCashBook)
        RO.MdiParent = Me
        RO.Show()
    End Sub

    Private Sub MNU_JBK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNU_JBK.Click
        Dim RO As New ReportOption(Reports.JournalBook)
        RO.MdiParent = Me
        RO.Show()
    End Sub

    Private Sub TBS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBS.Click
        Dim RO As New ReportOption(Reports.TrialBalance)
        RO.MdiParent = Me
        RO.Show()
    End Sub

    Private Sub TBD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBD.Click
        Dim RO As New ReportOption(Reports.TrialBalance_Detail)
        RO.MdiParent = Me
        RO.Show()
    End Sub

    Private Sub TBNW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBNW.Click
        Dim RO As New ReportOption(Reports.TrialBalance_Namewise)
        RO.MdiParent = Me
        RO.Show()
    End Sub

    Private Sub TRADE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRADE.Click
        Dim RO As New ReportOption(Reports.TradingAc)
        RO.MdiParent = Me
        RO.Show()
    End Sub

    Private Sub PL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PL.Click
        Dim RO As New ReportOption(Reports.ProfitNLoss)
        RO.MdiParent = Me
        RO.Show()
    End Sub

    Private Sub BS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BS.Click
        Dim RO As New ReportOption(Reports.BalanceSheet)
        RO.MdiParent = Me
        RO.Show()
    End Sub

    Private Sub LB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB.Click
        Dim RO As New ReportOption(Reports.LedgerBook)
        RO.MdiParent = Me
        RO.Show()
    End Sub

    Private Sub GLM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GLM.Click
        Dim RO As New ReportOption(Reports.GeneralLedgerMaster)
        RO.MdiParent = Me
        RO.Show()
    End Sub

    Private Sub BSHM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSHM.Click
        Dim RO As New ReportOption(Reports.BalanceSheetHead_Master)
        RO.MdiParent = Me
        RO.Show()
    End Sub

    Private Sub LBP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBP.Click
        Dim RO As New ReportOption(Reports.LabelPrinting)
        RO.MdiParent = Me
        RO.Show()
    End Sub

    Private Sub MnuHHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuHHelp.Click
        Dim ng As New NGroup
        ng.MdiParent = Me
        ng.Show()
    End Sub

    Private Sub MnuGC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuGC.Click
        Dim Gc As New GroupCreation
        Gc.MdiParent = Me
        Gc.WindowState = FormWindowState.Maximized
        Gc.Show()
    End Sub
    Private Sub MnuU_UC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuU_UC.Click
        Dim NewUCre As New UserCre
        NewUCre.MdiParent = Me
        NewUCre.Show()
    End Sub

    Private Sub FrmMain_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LocationChanged

    End Sub

    Private Sub MnuMT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuMT.Click
        Dim Mt As New MastTrans
        Mt.MdiParent = Me
        Mt.Show()
    End Sub

    Private Sub MnuLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuLogOut.Click
        If MsgBox("Are you sure want to Log off", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Log Off") = MsgBoxResult.Yes Then
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
            FrmMain_Load(Me, e.Empty)
        End If
    End Sub

    Private Sub MnuU_BackUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuU_BackUp.Click
        Dim FrmBnR As New BnR
        FrmBnR.MdiParent = Me
        FrmBnR.Show()
    End Sub

    Private Sub Mnu_AcExD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_AcExD.Click
        Dim FrmAcExtD As New AcExtD
        FrmAcExtD.MdiParent = Me
        FrmAcExtD.Show()
    End Sub

    Private Sub Mnu_AcDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_AcDet.Click
        Dim RO As New ReportOption(Reports.AccountStatementDetail)
        RO.MdiParent = Me
        RO.Show()
    End Sub
End Class
