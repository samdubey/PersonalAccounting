Imports System.IO
Public Class BnR
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
    Friend WithEvents TBBR As System.Windows.Forms.TabControl
    Friend WithEvents TB_BkUP As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListViewComp As System.Windows.Forms.ListView
    Friend WithEvents XSchema1 As PersonnelAcc.XSchema
    Friend WithEvents TxT As System.Windows.Forms.TextBox
    Friend WithEvents CmdBrowse As System.Windows.Forms.Button
    Friend WithEvents CmdBkUp As System.Windows.Forms.Button
    Friend WithEvents TB_REST As System.Windows.Forms.TabPage
    Friend WithEvents CmdRest As System.Windows.Forms.Button
    Friend WithEvents SFDia As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BtnRest As System.Windows.Forms.Button
    Friend WithEvents TxTRest As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LVREST As System.Windows.Forms.ListView
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TBBR = New System.Windows.Forms.TabControl
        Me.TB_BkUP = New System.Windows.Forms.TabPage
        Me.CmdBkUp = New System.Windows.Forms.Button
        Me.CmdBrowse = New System.Windows.Forms.Button
        Me.TxT = New System.Windows.Forms.TextBox
        Me.ListViewComp = New System.Windows.Forms.ListView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TB_REST = New System.Windows.Forms.TabPage
        Me.LVREST = New System.Windows.Forms.ListView
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnRest = New System.Windows.Forms.Button
        Me.TxTRest = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmdRest = New System.Windows.Forms.Button
        Me.XSchema1 = New PersonnelAcc.XSchema
        Me.SFDia = New System.Windows.Forms.SaveFileDialog
        Me.OFD = New System.Windows.Forms.OpenFileDialog
        Me.TBBR.SuspendLayout()
        Me.TB_BkUP.SuspendLayout()
        Me.TB_REST.SuspendLayout()
        CType(Me.XSchema1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBBR
        '
        Me.TBBR.Controls.Add(Me.TB_BkUP)
        Me.TBBR.Controls.Add(Me.TB_REST)
        Me.TBBR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBBR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBR.HotTrack = True
        Me.TBBR.Location = New System.Drawing.Point(10, 10)
        Me.TBBR.Name = "TBBR"
        Me.TBBR.SelectedIndex = 0
        Me.TBBR.ShowToolTips = True
        Me.TBBR.Size = New System.Drawing.Size(660, 325)
        Me.TBBR.TabIndex = 0
        '
        'TB_BkUP
        '
        Me.TB_BkUP.Controls.Add(Me.CmdBkUp)
        Me.TB_BkUP.Controls.Add(Me.CmdBrowse)
        Me.TB_BkUP.Controls.Add(Me.TxT)
        Me.TB_BkUP.Controls.Add(Me.ListViewComp)
        Me.TB_BkUP.Controls.Add(Me.Label2)
        Me.TB_BkUP.Controls.Add(Me.Label1)
        Me.TB_BkUP.Location = New System.Drawing.Point(4, 22)
        Me.TB_BkUP.Name = "TB_BkUP"
        Me.TB_BkUP.Size = New System.Drawing.Size(652, 299)
        Me.TB_BkUP.TabIndex = 0
        Me.TB_BkUP.Text = "Backup [Advanced]"
        '
        'CmdBkUp
        '
        Me.CmdBkUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdBkUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdBkUp.Location = New System.Drawing.Point(536, 264)
        Me.CmdBkUp.Name = "CmdBkUp"
        Me.CmdBkUp.Size = New System.Drawing.Size(104, 23)
        Me.CmdBkUp.TabIndex = 6
        Me.CmdBkUp.Text = "&Start Backup"
        '
        'CmdBrowse
        '
        Me.CmdBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdBrowse.Location = New System.Drawing.Point(344, 264)
        Me.CmdBrowse.Name = "CmdBrowse"
        Me.CmdBrowse.Size = New System.Drawing.Size(64, 23)
        Me.CmdBrowse.TabIndex = 5
        Me.CmdBrowse.Text = "&Browse"
        '
        'TxT
        '
        Me.TxT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxT.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxT.Location = New System.Drawing.Point(8, 264)
        Me.TxT.Name = "TxT"
        Me.TxT.Size = New System.Drawing.Size(328, 22)
        Me.TxT.TabIndex = 4
        Me.TxT.Text = ""
        '
        'ListViewComp
        '
        Me.ListViewComp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListViewComp.BackColor = System.Drawing.Color.FloralWhite
        Me.ListViewComp.CheckBoxes = True
        Me.ListViewComp.Location = New System.Drawing.Point(8, 32)
        Me.ListViewComp.Name = "ListViewComp"
        Me.ListViewComp.Size = New System.Drawing.Size(632, 200)
        Me.ListViewComp.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Backup media or file name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Click to select the check box for any company  that you want to backup"
        '
        'TB_REST
        '
        Me.TB_REST.Controls.Add(Me.LVREST)
        Me.TB_REST.Controls.Add(Me.Label4)
        Me.TB_REST.Controls.Add(Me.BtnRest)
        Me.TB_REST.Controls.Add(Me.TxTRest)
        Me.TB_REST.Controls.Add(Me.Label3)
        Me.TB_REST.Controls.Add(Me.CmdRest)
        Me.TB_REST.Location = New System.Drawing.Point(4, 22)
        Me.TB_REST.Name = "TB_REST"
        Me.TB_REST.Size = New System.Drawing.Size(652, 299)
        Me.TB_REST.TabIndex = 1
        Me.TB_REST.Text = "Restore [Advanced]"
        '
        'LVREST
        '
        Me.LVREST.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LVREST.BackColor = System.Drawing.Color.FloralWhite
        Me.LVREST.CheckBoxes = True
        Me.LVREST.Location = New System.Drawing.Point(8, 65)
        Me.LVREST.Name = "LVREST"
        Me.LVREST.Size = New System.Drawing.Size(632, 191)
        Me.LVREST.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(362, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Click to select the check box for any company  that you want to restore"
        '
        'BtnRest
        '
        Me.BtnRest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnRest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRest.Location = New System.Drawing.Point(344, 23)
        Me.BtnRest.Name = "BtnRest"
        Me.BtnRest.Size = New System.Drawing.Size(64, 23)
        Me.BtnRest.TabIndex = 10
        Me.BtnRest.Text = "&Browse"
        '
        'TxTRest
        '
        Me.TxTRest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxTRest.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTRest.Location = New System.Drawing.Point(8, 24)
        Me.TxTRest.Name = "TxTRest"
        Me.TxTRest.Size = New System.Drawing.Size(328, 22)
        Me.TxTRest.TabIndex = 9
        Me.TxTRest.Text = ""
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "File to restore"
        '
        'CmdRest
        '
        Me.CmdRest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdRest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdRest.Location = New System.Drawing.Point(536, 264)
        Me.CmdRest.Name = "CmdRest"
        Me.CmdRest.Size = New System.Drawing.Size(104, 23)
        Me.CmdRest.TabIndex = 7
        Me.CmdRest.Text = "&Start Restore"
        '
        'XSchema1
        '
        Me.XSchema1.DataSetName = "XSchema"
        Me.XSchema1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'BnR
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(680, 345)
        Me.Controls.Add(Me.TBBR)
        Me.DockPadding.All = 10
        Me.MaximizeBox = False
        Me.Name = "BnR"
        Me.Text = "Backup or Restore Wizard"
        Me.TBBR.ResumeLayout(False)
        Me.TB_BkUP.ResumeLayout(False)
        Me.TB_REST.ResumeLayout(False)
        CType(Me.XSchema1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub BnR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillCompany()
    End Sub
    Private Sub CmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBrowse.Click
        SFDia.Filter = "Backup files (*.bkf)|*.bkf"
        If SFDia.ShowDialog() = DialogResult.No Then
            Exit Sub
        End If
        TxT.Text = SFDia.FileName
    End Sub
    Private Sub FillCompany()
        Dim i As Int16
        Dim StrName As String
        Dim StrPath As String
        Dim StrSName As String
        Dim StrFromDate, StrToDate As Date
        Dim StrDbName As String
        Dim StrCompName, StrCompAdd As String
        ListViewComp.Clear()

        LVREST.Clear()

        ListViewComp.Columns.Add("Name", ListViewComp.Width / 2, HorizontalAlignment.Left)
        ListViewComp.Columns.Add("Short Name", 80, HorizontalAlignment.Left)
        ListViewComp.Columns.Add("From Date", 80, HorizontalAlignment.Left)
        ListViewComp.Columns.Add("To Date", 80, HorizontalAlignment.Left)
        ListViewComp.Columns.Add("Path", ListViewComp.Width / 3, HorizontalAlignment.Left)
        ListViewComp.Columns.Add("DBName", 0, HorizontalAlignment.Left)
        ListViewComp.Columns.Add("CompanyName", 0, HorizontalAlignment.Left)
        ListViewComp.Columns.Add("CompanyAddress", 0, HorizontalAlignment.Left)


        LVREST.Columns.Add("Name", LVREST.Width / 2, HorizontalAlignment.Left)
        LVREST.Columns.Add("Short Name", 80, HorizontalAlignment.Left)
        LVREST.Columns.Add("From Date", 80, HorizontalAlignment.Left)
        LVREST.Columns.Add("To Date", 80, HorizontalAlignment.Left)
        LVREST.Columns.Add("Path", LVREST.Width / 3, HorizontalAlignment.Left)
        LVREST.Columns.Add("DBName", 0, HorizontalAlignment.Left)
        LVREST.Columns.Add("CompanyName", 0, HorizontalAlignment.Left)
        LVREST.Columns.Add("CompanyAddress", 0, HorizontalAlignment.Left)

        Try
            If File.Exists(Application.StartupPath & "\DataBase\Companies.xml") = True Then
                XSchema1.Clear()
                XSchema1.ReadXml(Application.StartupPath & "\DataBase\Companies.xml", FileMode.Open)
                Dim listitemComp(XSchema1.Tables("CompanyInfo").Rows.Count) As ListViewItem
                Dim LvItem(XSchema1.Tables("CompanyInfo").Rows.Count) As ListViewItem
                ListViewComp.BeginUpdate()
                LVREST.BeginUpdate()
                For i = 0 To XSchema1.Tables("CompanyInfo").Rows.Count - 1
                    StrName = XSchema1.Tables("CompanyInfo").Rows(i).Item("CompanyName")
                    StrSName = XSchema1.Tables("CompanyInfo").Rows(i).Item("ShortName")
                    StrFromDate = XSchema1.Tables("CompanyInfo").Rows(i).Item("FromDate")
                    StrToDate = XSchema1.Tables("CompanyInfo").Rows(i).Item("ToDate")
                    StrPath = XSchema1.Tables("CompanyInfo").Rows(i).Item("ADBPath")
                    StrDbName = XSchema1.Tables("CompanyInfo").Rows(i).Item("DBName")
                    StrCompName = XSchema1.Tables("CompanyInfo").Rows(i).Item("CompanyName")
                    StrCompAdd = IIf(IsDBNull(XSchema1.Tables("CompanyInfo").Rows(i).Item("CompanyAddress")), "", XSchema1.Tables("CompanyInfo").Rows(i).Item("CompanyAddress"))
                    listitemComp(i) = ListViewComp.Items.Add(StrName & " [" & Year(StrFromDate) & "-" & Year(StrToDate) & "]", 0)
                    LvItem(i) = LVREST.Items.Add(StrName & " [" & Year(StrFromDate) & "-" & Year(StrToDate) & "]", 0)

                    ListViewComp.Items(i).SubItems.Add(StrSName)
                    ListViewComp.Items(i).SubItems.Add(Format(StrFromDate, "dd/MM/yyyy"))
                    ListViewComp.Items(i).SubItems.Add(Format(StrToDate, "dd/MM/yyyy"))
                    ListViewComp.Items(i).SubItems.Add(StrPath.ToString)
                    ListViewComp.Items(i).SubItems.Add(StrDbName.ToString)
                    ListViewComp.Items(i).SubItems.Add(StrCompName.ToString)
                    ListViewComp.Items(i).SubItems.Add(StrCompAdd.ToString)
                    ListViewComp.Items(i).SubItems.Add(StrFromDate)
                    ListViewComp.Items(i).SubItems.Add(StrToDate)

                    LVREST.Items(i).SubItems.Add(StrSName)
                    LVREST.Items(i).SubItems.Add(Format(StrFromDate, "dd/MM/yyyy"))
                    LVREST.Items(i).SubItems.Add(Format(StrToDate, "dd/MM/yyyy"))
                    LVREST.Items(i).SubItems.Add(StrPath.ToString)
                    LVREST.Items(i).SubItems.Add(StrDbName.ToString)
                    LVREST.Items(i).SubItems.Add(StrCompName.ToString)
                    LVREST.Items(i).SubItems.Add(StrCompAdd.ToString)
                    LVREST.Items(i).SubItems.Add(StrFromDate)
                    LVREST.Items(i).SubItems.Add(StrToDate)
                Next
                ListViewComp.EndUpdate()
                LVREST.EndUpdate()
                ListViewComp.View = View.Details
                LVREST.View = View.Details
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub

    Private Sub CmdBkUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBkUp.Click
        If Not ListViewComp.CheckedItems.Count > 0 Then
            MsgBox("Please Select Company To Backup", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Trim(TxT.Text).Length = 0 Then
            MsgBox("Please Enter The Path of File to Backup", MsgBoxStyle.Information)
            Exit Sub
        End If
        If File.Exists(TxT.Text) = True Then
            If MsgBox("File Already Exist at a given path" & ControlChars.CrLf & "Do you want to append on media?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        Dim StrFromFile As String = ListViewComp.CheckedItems(0).SubItems(4).Text
        Try
            File.Copy(StrFromFile, TxT.Text)
            MsgBox("Company Backuped Successfully", MsgBoxStyle.Information, "Backup")
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub

    Private Sub ListViewComp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewComp.SelectedIndexChanged

    End Sub

    Private Sub ListViewComp_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles ListViewComp.ItemCheck
        Dim i As Int16
        For i = 0 To ListViewComp.Items.Count - 1
            If i <> e.Index Then
                ListViewComp.Items(i).Checked = False
            End If
        Next
    End Sub

    Private Sub BtnRest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRest.Click
        OFD.Filter = "Backuped files (*.bkf)|*.bkf"
        If OFD.ShowDialog() = DialogResult.No Then
            Exit Sub
        End If
        TxTRest.Text = OFD.FileName
    End Sub

    Private Sub LVREST_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVREST.SelectedIndexChanged

    End Sub

    Private Sub LVREST_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles LVREST.ItemCheck
        Dim i As Int16
        For i = 0 To LVREST.Items.Count - 1
            If i <> e.Index Then
                LVREST.Items(i).Checked = False
            End If
        Next
    End Sub

    Private Sub CmdRest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRest.Click
        If Not LVREST.CheckedItems.Count > 0 Then
            MsgBox("Please Select Company To Restore", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Trim(TxTRest.Text).Length = 0 Then
            MsgBox("Please Enter The Path of File to Restore", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim StrToFile As String = LVREST.CheckedItems(0).SubItems(4).Text
        Dim StrFromFile As String = TxTRest.Text
        If File.Exists(StrToFile) = False Then
            MsgBox("Company Does not exist First create company", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Try
            If File.Exists(StrToFile) = True Then
                If MsgBox("Over Write Company ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "OverWrite") = MsgBoxResult.Yes Then
                    File.Copy(StrFromFile, StrToFile, True)
                End If
            Else
                File.Copy(StrFromFile, StrToFile, False)
            End If
            MsgBox("Company restored Successfully", MsgBoxStyle.Information, "Restore")
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub
End Class
