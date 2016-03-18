Imports System.Data.OleDb
Imports System.IO
Public Class MastTrans
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
    Friend WithEvents FromLV As System.Windows.Forms.ListView
    Friend WithEvents ToLV As System.Windows.Forms.ListView
    Friend WithEvents ChkAcc As System.Windows.Forms.CheckBox
    Friend WithEvents LblDisplay As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmdTrans As System.Windows.Forms.Button
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents XSchema1 As PersonnelAcc.XSchema
    Friend WithEvents ImgComp As System.Windows.Forms.ImageList
    Friend WithEvents CntMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents ImgCompSmall As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MastTrans))
        Me.FromLV = New System.Windows.Forms.ListView
        Me.CntMenu = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.ToLV = New System.Windows.Forms.ListView
        Me.ChkAcc = New System.Windows.Forms.CheckBox
        Me.LblDisplay = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmdTrans = New System.Windows.Forms.Button
        Me.CmdExit = New System.Windows.Forms.Button
        Me.XSchema1 = New PersonnelAcc.XSchema
        Me.ImgComp = New System.Windows.Forms.ImageList(Me.components)
        Me.ImgCompSmall = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.XSchema1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FromLV
        '
        Me.FromLV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FromLV.CheckBoxes = True
        Me.FromLV.ContextMenu = Me.CntMenu
        Me.FromLV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FromLV.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromLV.Location = New System.Drawing.Point(19, 64)
        Me.FromLV.MultiSelect = False
        Me.FromLV.Name = "FromLV"
        Me.FromLV.Size = New System.Drawing.Size(376, 312)
        Me.FromLV.TabIndex = 0
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
        'ToLV
        '
        Me.ToLV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToLV.CheckBoxes = True
        Me.ToLV.ContextMenu = Me.CntMenu
        Me.ToLV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToLV.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToLV.HideSelection = False
        Me.ToLV.Location = New System.Drawing.Point(403, 64)
        Me.ToLV.MultiSelect = False
        Me.ToLV.Name = "ToLV"
        Me.ToLV.Size = New System.Drawing.Size(376, 312)
        Me.ToLV.TabIndex = 1
        '
        'ChkAcc
        '
        Me.ChkAcc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ChkAcc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAcc.Location = New System.Drawing.Point(24, 392)
        Me.ChkAcc.Name = "ChkAcc"
        Me.ChkAcc.Size = New System.Drawing.Size(152, 24)
        Me.ChkAcc.TabIndex = 2
        Me.ChkAcc.Text = "With Account Balance"
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
        Me.LblDisplay.Size = New System.Drawing.Size(528, 24)
        Me.LblDisplay.TabIndex = 3
        Me.LblDisplay.Text = "Master Transfer"
        Me.LblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select From Company "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(408, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select To Company "
        '
        'CmdTrans
        '
        Me.CmdTrans.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdTrans.Location = New System.Drawing.Point(360, 416)
        Me.CmdTrans.Name = "CmdTrans"
        Me.CmdTrans.Size = New System.Drawing.Size(75, 24)
        Me.CmdTrans.TabIndex = 6
        Me.CmdTrans.Text = "&Transfer"
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdExit.Location = New System.Drawing.Point(440, 416)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.TabIndex = 7
        Me.CmdExit.Text = "&Cancel"
        '
        'XSchema1
        '
        Me.XSchema1.DataSetName = "XSchema"
        Me.XSchema1.Locale = New System.Globalization.CultureInfo("en-US")
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
        'MastTrans
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(528, 453)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.CmdTrans)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblDisplay)
        Me.Controls.Add(Me.ChkAcc)
        Me.Controls.Add(Me.ToLV)
        Me.Controls.Add(Me.FromLV)
        Me.Name = "MastTrans"
        Me.Text = "Master Transfer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.XSchema1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ConX As OleDbConnection
    Dim StrFromDBPath, StrToDBPath As String
    Dim SQLQuery As String
    Dim StrDate As Date
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        If MsgBox("Are You Sure Want To Exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Quit") = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub
    Private Sub MastTrans_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Int16
        Dim StrName As String
        Dim StrPath As String
        Dim StrSName As String
        Dim StrFromDate, StrToDate As Date
        Dim StrDbName As String

        FromLV.Clear()
        FromLV.Columns.Add("Name", FromLV.Width / 2, HorizontalAlignment.Left)
        FromLV.Columns.Add("Short Name", 80, HorizontalAlignment.Left)
        FromLV.Columns.Add("From Date", 80, HorizontalAlignment.Left)
        FromLV.Columns.Add("To Date", 80, HorizontalAlignment.Left)
        FromLV.Columns.Add("Path", FromLV.Width / 3, HorizontalAlignment.Left)
        FromLV.Columns.Add("DBName", 0, HorizontalAlignment.Left)


        ToLV.Clear()
        ToLV.Columns.Add("Name", FromLV.Width / 2, HorizontalAlignment.Left)
        ToLV.Columns.Add("Short Name", 80, HorizontalAlignment.Left)
        ToLV.Columns.Add("From Date", 80, HorizontalAlignment.Left)
        ToLV.Columns.Add("To Date", 80, HorizontalAlignment.Left)
        ToLV.Columns.Add("Path", FromLV.Width / 3, HorizontalAlignment.Left)
        ToLV.Columns.Add("DBName", 0, HorizontalAlignment.Left)

        Try
            If File.Exists(Application.StartupPath & "\DataBase\Companies.xml") = True Then
                XSchema1.Clear()
                XSchema1.ReadXml(Application.StartupPath & "\DataBase\Companies.xml", FileMode.Open)
                Dim FromLVItem(XSchema1.Tables("CompanyInfo").Rows.Count) As ListViewItem
                Dim ToLVItem(XSchema1.Tables("CompanyInfo").Rows.Count) As ListViewItem
                FromLV.BeginUpdate()
                ToLV.BeginUpdate()
                For i = 0 To XSchema1.Tables("CompanyInfo").Rows.Count - 1
                    StrName = XSchema1.Tables("CompanyInfo").Rows(i).Item("CompanyName")
                    StrSName = XSchema1.Tables("CompanyInfo").Rows(i).Item("ShortName")
                    StrFromDate = XSchema1.Tables("CompanyInfo").Rows(i).Item("FromDate")
                    StrToDate = XSchema1.Tables("CompanyInfo").Rows(i).Item("ToDate")
                    StrPath = XSchema1.Tables("CompanyInfo").Rows(i).Item("ADBPath")
                    StrDbName = XSchema1.Tables("CompanyInfo").Rows(i).Item("DBName")

                    FromLVItem(i) = FromLV.Items.Add(StrName & " [" & Year(StrFromDate) & "-" & Year(StrToDate) & "]", 0)
                    FromLV.Items(i).SubItems.Add(StrSName)
                    FromLV.Items(i).SubItems.Add(Format(StrFromDate, "dd/MM/yyyy"))
                    FromLV.Items(i).SubItems.Add(Format(StrToDate, "dd/MM/yyyy"))
                    FromLV.Items(i).SubItems.Add(StrPath.ToString)
                    FromLV.Items(i).SubItems.Add(StrDbName.ToString)

                    ToLVItem(i) = ToLV.Items.Add(StrName & " [" & Year(StrFromDate) & "-" & Year(StrToDate) & "]", 0)
                    ToLV.Items(i).SubItems.Add(StrSName)
                    ToLV.Items(i).SubItems.Add(Format(StrFromDate, "dd/MM/yyyy"))
                    ToLV.Items(i).SubItems.Add(Format(StrToDate, "dd/MM/yyyy"))
                    ToLV.Items(i).SubItems.Add(StrPath.ToString)
                    ToLV.Items(i).SubItems.Add(StrDbName.ToString)

                Next
                FromLV.EndUpdate()
                ToLV.EndUpdate()
                ToLV.SmallImageList = ImgCompSmall
                ToLV.LargeImageList = ImgComp
                FromLV.SmallImageList = ImgCompSmall
                FromLV.LargeImageList = ImgComp
                ToLV.View = Integer.Parse(GetSetting("Siddhi", "Option", "View", "1"))
                FromLV.View = Integer.Parse(GetSetting("Siddhi", "Option", "View", "1"))
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        FromLV.View = View.LargeIcon
        ToLV.View = View.LargeIcon
        SaveSetting("Siddhi", "Option", "View", "0")
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        FromLV.View = View.SmallIcon
        ToLV.View = View.SmallIcon
        SaveSetting("Siddhi", "Option", "View", "2")
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        FromLV.View = View.List
        ToLV.View = View.List
        SaveSetting("Siddhi", "Option", "View", "3")
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        FromLV.View = View.Details
        ToLV.View = View.Details
        SaveSetting("Siddhi", "Option", "View", "1")
    End Sub

    Private Sub FromLV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FromLV.SelectedIndexChanged

    End Sub

    Private Sub FromLV_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles FromLV.ItemCheck
        Dim i As Int16
        For i = 0 To FromLV.Items.Count - 1
            If i <> e.Index Then
                FromLV.Items(i).Checked = False
            End If
        Next
    End Sub

    Private Sub ToLV_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles ToLV.ItemCheck
        Dim i As Int16
        For i = 0 To ToLV.Items.Count - 1
            If i <> e.Index Then
                ToLV.Items(i).Checked = False
            End If
        Next
    End Sub

    Private Sub CmdTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTrans.Click
        If FromLV.CheckedItems.Count = 0 Then
            MsgBox("Please Select Company " & ControlChars.CrLf & " From Which Master Will Transfer", MsgBoxStyle.Information, "Select From Company.")
            FromLV.Focus()
            Exit Sub
        End If
        If ToLV.CheckedItems.Count = 0 Then
            MsgBox("Please Select Company " & ControlChars.CrLf & " To Which Master Will Transfer", MsgBoxStyle.Information, "Select To Company.")
            ToLV.Focus()
            Exit Sub
        End If
        If FromLV.CheckedItems(0).SubItems(5).Text = ToLV.CheckedItems(0).SubItems(5).Text Then
            MsgBox("Can't Transfer Master Of Same Company " & ControlChars.CrLf & "Please Select Different Company", MsgBoxStyle.Critical, "Invalid Selection")
            ToLV.Focus()
            Exit Sub
        End If
        If MsgBox("Are you Sure Want Proceed" & ControlChars.CrLf & "All Transaction In To Company Will Be Deleted", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Proceed?") = MsgBoxResult.No Then
            Exit Sub
        End If
        StrDate = DateSerial(CDate(ToLV.CheckedItems(0).SubItems(2).Text).Year, 3, 31)
        StrFromDBPath = FromLV.CheckedItems(0).SubItems(4).Text
        StrToDBPath = ToLV.CheckedItems(0).SubItems(4).Text
        If File.Exists(StrFromDBPath) = False Then
            MsgBox("From Company Path is Invalid " & ControlChars.CrLf & "Please Check Path & Continue", MsgBoxStyle.Critical, "Invalid Path")
            Exit Sub
        End If
        If File.Exists(StrToDBPath) = False Then
            MsgBox("To Company Path is Invalid " & ControlChars.CrLf & "Please Check Path & Continue", MsgBoxStyle.Critical, "Invalid Path")
            Exit Sub
        End If
        Dim StrConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & StrToDBPath & ";Persist Security Info=False"
        ConX = New OleDb.OleDbConnection(StrConnectionString)
        Dim Cmd As New OleDbCommand("SELECT * FROM GenGL WHERE Book<>'OP'", ConX)
        Dim DataR As OleDbDataReader
        If ConX.State Then ConX.Close()
        ConX.Open()
        DataR = Cmd.ExecuteReader()
        DataR.Read()
        If DataR.HasRows = True Then
            MsgBox("Can't Transfer Company " & ControlChars.CrLf & "Transaction Exist For That Target Company (To Company)", MsgBoxStyle.Critical, "Can't Transfer")
            Exit Sub
        End If
        ConX.Close()
        SQLQuery = "DELETE * FROM GLMAST WHERE GlCode<>1;"
        ExecuteCommand(SQLQuery)
        SQLQuery = "INSERT INTO BsHead SELECT * FROM " & StrFromDBPath & ".BsHead WHERE IndCode<>UCode"
        ExecuteCommand(SQLQuery)
        If ChkAcc.Checked = True Then            SQLQuery = "INSERT INTO GLMAST SELECT " & _                     "GLCode,GName,IndCode,Part,Add1,Add2,City," & _                     "Pin,PhO,PhR,Fax,Mobile,Email,Site,PAN,TIN,Amount " & _                     "FROM " & StrFromDBPath & ".GLMAST WHERE GlCode<>1"            ExecuteCommand(SQLQuery)            SQLQuery = "INSERT INTO GENGL SELECT * FROM " & StrFromDBPath & ".GENGL WHERE BOOK='OP' AND GLCODE<>1"            ExecuteCommand(SQLQuery)        Else
            SQLQuery = "INSERT INTO GLMAST SELECT " & _                     "GLCode,GName,IndCode,Part,Add1,Add2,City," & _                     "Pin,PhO,PhR,Fax,Mobile,Email,Site,PAN,TIN " & _                     "FROM " & StrFromDBPath & ".GLMAST WHERE GlCode<>1"
            ExecuteCommand(SQLQuery)
            SQLQuery = "INSERT INTO GENGL SELECT Vno,RefNo,TDate,Part,GlCode,Book,UserID,Head FROM " & StrFromDBPath & ".GENGL WHERE Book='OP' AND GLCode<>1"
            ExecuteCommand(SQLQuery)
        End If        SQLQuery = "UPDATE GENGL SET TDate=#" & StrDate & "# WHERE Book='OP' AND GlCode<>1"        ExecuteCommand(SQLQuery)        MsgBox("Transfer Completed Sucessfully", MsgBoxStyle.Information, "Sucess ! ! ! ")
    End Sub
    Private Sub ExecuteCommand(ByVal StrSQL As String)
        Dim Cmd As New OleDbCommand
        Cmd.CommandText = StrSQL
        Cmd.CommandType = CommandType.Text
        Cmd.Connection = ConX
        If ConX.State Then ConX.Close()
        Try
            ConX.Open()
            Cmd.ExecuteNonQuery()
        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            ConX.Close()
        End Try
    End Sub
End Class
