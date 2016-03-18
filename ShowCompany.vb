Imports System.IO
Public Class FrmShowCompany
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
    Friend WithEvents listviewComp As System.Windows.Forms.ListView
    Friend WithEvents CmdCreate As System.Windows.Forms.Button
    Friend WithEvents ImgComp As System.Windows.Forms.ImageList
    Friend WithEvents ImgCompSmall As System.Windows.Forms.ImageList
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents CntMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents CmdGo As System.Windows.Forms.Button
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents XSchema1 As PersonnelAcc.XSchema
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmShowCompany))
        Me.listviewComp = New System.Windows.Forms.ListView
        Me.CntMenu = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.ImgComp = New System.Windows.Forms.ImageList(Me.components)
        Me.ImgCompSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.CmdGo = New System.Windows.Forms.Button
        Me.CmdExit = New System.Windows.Forms.Button
        Me.CmdCreate = New System.Windows.Forms.Button
        Me.XSchema1 = New PersonnelAcc.XSchema
        CType(Me.XSchema1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listviewComp
        '
        Me.listviewComp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listviewComp.BackColor = System.Drawing.Color.Ivory
        Me.listviewComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listviewComp.ContextMenu = Me.CntMenu
        Me.listviewComp.LargeImageList = Me.ImgComp
        Me.listviewComp.Location = New System.Drawing.Point(0, 0)
        Me.listviewComp.MultiSelect = False
        Me.listviewComp.Name = "listviewComp"
        Me.listviewComp.Size = New System.Drawing.Size(506, 232)
        Me.listviewComp.SmallImageList = Me.ImgCompSmall
        Me.listviewComp.TabIndex = 0
        Me.listviewComp.View = System.Windows.Forms.View.Details
        '
        'CntMenu
        '
        Me.CntMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Large Icon"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Small Icon"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "List"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Details"
        '
        'ImgComp
        '
        Me.ImgComp.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImgComp.ImageStream = CType(resources.GetObject("ImgComp.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgComp.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImgCompSmall
        '
        Me.ImgCompSmall.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImgCompSmall.ImageStream = CType(resources.GetObject("ImgCompSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgCompSmall.TransparentColor = System.Drawing.Color.Transparent
        '
        'CmdGo
        '
        Me.CmdGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdGo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGo.Location = New System.Drawing.Point(208, 240)
        Me.CmdGo.Name = "CmdGo"
        Me.CmdGo.Size = New System.Drawing.Size(64, 24)
        Me.CmdGo.TabIndex = 1
        Me.CmdGo.Text = "&Go"
        '
        'CmdExit
        '
        Me.CmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExit.Location = New System.Drawing.Point(280, 240)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(64, 24)
        Me.CmdExit.TabIndex = 2
        Me.CmdExit.Text = "E&xit"
        '
        'CmdCreate
        '
        Me.CmdCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdCreate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCreate.Location = New System.Drawing.Point(136, 240)
        Me.CmdCreate.Name = "CmdCreate"
        Me.CmdCreate.Size = New System.Drawing.Size(64, 24)
        Me.CmdCreate.TabIndex = 4
        Me.CmdCreate.Text = "&Create"
        '
        'XSchema1
        '
        Me.XSchema1.DataSetName = "XSchema"
        Me.XSchema1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'FrmShowCompany
        '
        Me.AcceptButton = Me.CmdGo
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(506, 271)
        Me.ControlBox = False
        Me.Controls.Add(Me.CmdCreate)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.CmdGo)
        Me.Controls.Add(Me.listviewComp)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "FrmShowCompany"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Company"
        CType(Me.XSchema1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim opr As Operation = ModMain.Operation.None
    Private Sub FrmShowCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Int16
        Dim StrName As String
        Dim StrPath As String
        Dim StrSName As String
        Dim StrFromDate, StrToDate As Date
        Dim StrDbName As String
        Dim StrCompName, StrCompAdd As String
        listviewComp.Clear()
        listviewComp.Columns.Add("Name", listviewComp.Width / 2, HorizontalAlignment.Left)
        listviewComp.Columns.Add("Short Name", 80, HorizontalAlignment.Left)
        listviewComp.Columns.Add("From Date", 80, HorizontalAlignment.Left)
        listviewComp.Columns.Add("To Date", 80, HorizontalAlignment.Left)
        listviewComp.Columns.Add("Path", listviewComp.Width / 3, HorizontalAlignment.Left)
        listviewComp.Columns.Add("DBName", 0, HorizontalAlignment.Left)
        listviewComp.Columns.Add("CompanyName", 0, HorizontalAlignment.Left)
        listviewComp.Columns.Add("CompanyAddress", 0, HorizontalAlignment.Left)

        listviewComp.Columns.Add("TempFDate", 0, HorizontalAlignment.Left)
        listviewComp.Columns.Add("TempTDate", 0, HorizontalAlignment.Left)
        Try
            If File.Exists(Application.StartupPath & "\DataBase\Companies.xml") = True Then
                XSchema1.Clear()
                XSchema1.ReadXml(Application.StartupPath & "\DataBase\Companies.xml", FileMode.Open)
                Dim listitemComp(XSchema1.Tables("CompanyInfo").Rows.Count) As ListViewItem
                listviewComp.BeginUpdate()
                For i = 0 To XSchema1.Tables("CompanyInfo").Rows.Count - 1
                    StrName = XSchema1.Tables("CompanyInfo").Rows(i).Item("CompanyName")
                    StrSName = XSchema1.Tables("CompanyInfo").Rows(i).Item("ShortName")
                    StrFromDate = XSchema1.Tables("CompanyInfo").Rows(i).Item("FromDate")
                    StrToDate = XSchema1.Tables("CompanyInfo").Rows(i).Item("ToDate")
                    StrPath = XSchema1.Tables("CompanyInfo").Rows(i).Item("ADBPath")
                    StrDbName = XSchema1.Tables("CompanyInfo").Rows(i).Item("DBName")
                    StrCompName = XSchema1.Tables("CompanyInfo").Rows(i).Item("CompanyName")
                    StrCompAdd = IIf(IsDBNull(XSchema1.Tables("CompanyInfo").Rows(i).Item("CompanyAddress")), "", XSchema1.Tables("CompanyInfo").Rows(i).Item("CompanyAddress"))
                    listitemComp(i) = listviewComp.Items.Add(StrName & " [" & Year(StrFromDate) & "-" & Year(StrToDate) & "]", 0)
                    listviewComp.Items(i).SubItems.Add(StrSName)
                    listviewComp.Items(i).SubItems.Add(Format(StrFromDate, "dd/MM/yyyy"))
                    listviewComp.Items(i).SubItems.Add(Format(StrToDate, "dd/MM/yyyy"))
                    listviewComp.Items(i).SubItems.Add(StrPath.ToString)
                    listviewComp.Items(i).SubItems.Add(StrDbName.ToString)
                    listviewComp.Items(i).SubItems.Add(StrCompName.ToString)
                    listviewComp.Items(i).SubItems.Add(StrCompAdd.ToString)
                    listviewComp.Items(i).SubItems.Add(StrFromDate)
                    listviewComp.Items(i).SubItems.Add(StrToDate)
                Next
                listviewComp.EndUpdate()
                listviewComp.SmallImageList = ImgCompSmall
                listviewComp.LargeImageList = ImgComp
                listviewComp.View = Integer.Parse(GetSetting("Siddhi", "Option", "View", "1"))
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub
    Private Sub CmdCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCreate.Click
        Dim FrmNewComp As New FrmCreateCompany
        opr = ModMain.Operation.Search
        FrmNewComp.ShowDialog()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        listviewComp.View = View.LargeIcon
        SaveSetting("Siddhi", "Option", "View", "0")
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        listviewComp.View = View.SmallIcon
        SaveSetting("Siddhi", "Option", "View", "2")
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        listviewComp.View = View.List
        SaveSetting("Siddhi", "Option", "View", "3")
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        listviewComp.View = View.Details
        SaveSetting("Siddhi", "Option", "View", "1")
    End Sub

    Private Sub CmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGo.Click
        Dim DB As String
        If listviewComp.Items.Count > 0 Then
            If listviewComp.SelectedItems.Count > 0 Then
                DBPath = listviewComp.SelectedItems(0).SubItems(4).Text
                DB = listviewComp.SelectedItems(0).SubItems(5).Text
                CompName = listviewComp.SelectedItems(0).SubItems(6).Text
                CompAdd = listviewComp.SelectedItems(0).SubItems(7).Text
                FromDate = CDate(listviewComp.SelectedItems(0).SubItems(8).Text)
                ToDate = CDate(listviewComp.SelectedItems(0).SubItems(9).Text)
                If File.Exists(DBPath) = False Then
                    DBPath = Application.StartupPath & "\DataBase\" & DB & "\" & DB & XTension
                    If File.Exists(DBPath) = False Then
                        MsgBox("DataBase Not Found", MsgBoxStyle.Critical, "InValid Path")
                        Exit Sub
                    End If
                End If
                Close()
            Else
                MsgBox("Please Select Company", MsgBoxStyle.Information, "Select")
                listviewComp.Select()
            End If
        End If
    End Sub
    Private Sub FrmShowCompany_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If opr = ModMain.Operation.Search Then
            opr = ModMain.Operation.None
            FrmShowCompany_Load(Me, e.Empty)
        End If
    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        End
    End Sub
End Class
