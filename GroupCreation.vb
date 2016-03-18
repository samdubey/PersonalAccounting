Imports System.Data.OleDb
Public Class GroupCreation
    Inherits System.Windows.Forms.Form
    Dim Con As OleDbConnection
    Dim Da As OleDbDataAdapter
    Dim DaM As OleDbDataAdapter
    Dim CmdBuild As OleDbCommandBuilder
    Dim DsS As New DataSet
    Dim Ds As New DataSet
    Dim strGr, strUCode, strBsType As String
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
    Friend WithEvents DGrid As System.Windows.Forms.DataGrid
    Friend WithEvents MainGroup As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents Code As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents MGroup As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Group As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents UCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SubGr As System.Windows.Forms.Panel
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents DGSlave As System.Windows.Forms.DataGrid
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents UGr As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DGrid = New System.Windows.Forms.DataGrid
        Me.MainGroup = New System.Windows.Forms.DataGridTableStyle
        Me.Code = New System.Windows.Forms.DataGridTextBoxColumn
        Me.MGroup = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Group = New System.Windows.Forms.DataGridTextBoxColumn
        Me.UCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Type = New System.Windows.Forms.DataGridTextBoxColumn
        Me.UGr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CmdExit = New System.Windows.Forms.Button
        Me.SubGr = New System.Windows.Forms.Panel
        Me.CmdClose = New System.Windows.Forms.Button
        Me.CmdSave = New System.Windows.Forms.Button
        Me.DGSlave = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.DGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SubGr.SuspendLayout()
        CType(Me.DGSlave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGrid
        '
        Me.DGrid.AlternatingBackColor = System.Drawing.Color.Moccasin
        Me.DGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGrid.BackColor = System.Drawing.Color.OldLace
        Me.DGrid.BackgroundColor = System.Drawing.Color.Tan
        Me.DGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGrid.CaptionBackColor = System.Drawing.Color.SaddleBrown
        Me.DGrid.CaptionForeColor = System.Drawing.Color.OldLace
        Me.DGrid.CaptionText = "Group Creation"
        Me.DGrid.DataMember = ""
        Me.DGrid.FlatMode = True
        Me.DGrid.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DGrid.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.DGrid.GridLineColor = System.Drawing.Color.Tan
        Me.DGrid.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DGrid.HeaderBackColor = System.Drawing.Color.Wheat
        Me.DGrid.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DGrid.HeaderForeColor = System.Drawing.Color.SaddleBrown
        Me.DGrid.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.DGrid.Location = New System.Drawing.Point(0, 0)
        Me.DGrid.Name = "DGrid"
        Me.DGrid.ParentRowsBackColor = System.Drawing.Color.OldLace
        Me.DGrid.ParentRowsForeColor = System.Drawing.Color.DarkSlateGray
        Me.DGrid.PreferredColumnWidth = 150
        Me.DGrid.PreferredRowHeight = 25
        Me.DGrid.ReadOnly = True
        Me.DGrid.RowHeaderWidth = 50
        Me.DGrid.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.DGrid.SelectionForeColor = System.Drawing.Color.White
        Me.DGrid.Size = New System.Drawing.Size(632, 344)
        Me.DGrid.TabIndex = 0
        Me.DGrid.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.MainGroup})
        '
        'MainGroup
        '
        Me.MainGroup.AlternatingBackColor = System.Drawing.Color.PapayaWhip
        Me.MainGroup.BackColor = System.Drawing.Color.OldLace
        Me.MainGroup.DataGrid = Me.DGrid
        Me.MainGroup.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.Code, Me.MGroup, Me.Group, Me.UCode, Me.Type, Me.UGr})
        Me.MainGroup.GridLineColor = System.Drawing.Color.Tan
        Me.MainGroup.HeaderBackColor = System.Drawing.Color.Wheat
        Me.MainGroup.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.MainGroup.MappingName = "MainGroup"
        Me.MainGroup.PreferredRowHeight = 24
        '
        'Code
        '
        Me.Code.Format = ""
        Me.Code.FormatInfo = Nothing
        Me.Code.HeaderText = "Code"
        Me.Code.MappingName = "Code"
        Me.Code.NullText = ""
        Me.Code.Width = 75
        '
        'MGroup
        '
        Me.MGroup.Format = ""
        Me.MGroup.FormatInfo = Nothing
        Me.MGroup.HeaderText = "Main Group"
        Me.MGroup.MappingName = "Main Group"
        Me.MGroup.NullText = ""
        Me.MGroup.Width = 250
        '
        'Group
        '
        Me.Group.Format = ""
        Me.Group.FormatInfo = Nothing
        Me.Group.HeaderText = "Group"
        Me.Group.MappingName = "Group"
        Me.Group.NullText = ""
        Me.Group.Width = 75
        '
        'UCode
        '
        Me.UCode.Format = ""
        Me.UCode.FormatInfo = Nothing
        Me.UCode.HeaderText = "Upper Code"
        Me.UCode.MappingName = "Under Code"
        Me.UCode.NullText = ""
        Me.UCode.ReadOnly = True
        Me.UCode.Width = 75
        '
        'Type
        '
        Me.Type.Format = ""
        Me.Type.FormatInfo = Nothing
        Me.Type.HeaderText = "Type"
        Me.Type.MappingName = "Type"
        Me.Type.Width = 0
        '
        'UGr
        '
        Me.UGr.Format = ""
        Me.UGr.FormatInfo = Nothing
        Me.UGr.HeaderText = "Upper Group"
        Me.UGr.MappingName = "UGroup"
        Me.UGr.NullText = ""
        Me.UGr.Width = 200
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExit.Location = New System.Drawing.Point(552, 352)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.TabIndex = 2
        Me.CmdExit.Text = "E&xit"
        '
        'SubGr
        '
        Me.SubGr.BackColor = System.Drawing.Color.AliceBlue
        Me.SubGr.Controls.Add(Me.CmdClose)
        Me.SubGr.Controls.Add(Me.CmdSave)
        Me.SubGr.Controls.Add(Me.DGSlave)
        Me.SubGr.Location = New System.Drawing.Point(16, 168)
        Me.SubGr.Name = "SubGr"
        Me.SubGr.Size = New System.Drawing.Size(568, 144)
        Me.SubGr.TabIndex = 4
        '
        'CmdClose
        '
        Me.CmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClose.Location = New System.Drawing.Point(480, 116)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.TabIndex = 2
        Me.CmdClose.Text = "&Cancel"
        '
        'CmdSave
        '
        Me.CmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdSave.Location = New System.Drawing.Point(400, 116)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.TabIndex = 1
        Me.CmdSave.Text = "&Save"
        '
        'DGSlave
        '
        Me.DGSlave.AlternatingBackColor = System.Drawing.Color.GhostWhite
        Me.DGSlave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGSlave.BackColor = System.Drawing.Color.GhostWhite
        Me.DGSlave.BackgroundColor = System.Drawing.Color.Lavender
        Me.DGSlave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGSlave.CaptionBackColor = System.Drawing.Color.RoyalBlue
        Me.DGSlave.CaptionForeColor = System.Drawing.Color.White
        Me.DGSlave.DataMember = ""
        Me.DGSlave.FlatMode = True
        Me.DGSlave.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DGSlave.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DGSlave.GridLineColor = System.Drawing.Color.RoyalBlue
        Me.DGSlave.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DGSlave.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DGSlave.HeaderForeColor = System.Drawing.Color.Lavender
        Me.DGSlave.LinkColor = System.Drawing.Color.Teal
        Me.DGSlave.Location = New System.Drawing.Point(0, 0)
        Me.DGSlave.Name = "DGSlave"
        Me.DGSlave.ParentRowsBackColor = System.Drawing.Color.Lavender
        Me.DGSlave.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DGSlave.SelectionBackColor = System.Drawing.Color.Teal
        Me.DGSlave.SelectionForeColor = System.Drawing.Color.PaleGreen
        Me.DGSlave.Size = New System.Drawing.Size(568, 112)
        Me.DGSlave.TabIndex = 0
        Me.DGSlave.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.GhostWhite
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.Lavender
        Me.DataGridTableStyle1.DataGrid = Me.DGSlave
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Azure
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "S"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = "##"
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Code"
        Me.DataGridTextBoxColumn1.MappingName = "Code"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Particulars"
        Me.DataGridTextBoxColumn2.MappingName = "Particulars"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 250
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Group"
        Me.DataGridTextBoxColumn3.MappingName = "Group"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Upper Code"
        Me.DataGridTextBoxColumn4.MappingName = "UCode"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.MappingName = "BsType"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'GroupCreation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(632, 381)
        Me.Controls.Add(Me.SubGr)
        Me.Controls.Add(Me.DGrid)
        Me.Controls.Add(Me.CmdExit)
        Me.Name = "GroupCreation"
        Me.Text = "Group Creation"
        CType(Me.DGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SubGr.ResumeLayout(False)
        CType(Me.DGSlave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub GroupCreation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Con = New OleDbConnection(ConStr)
        'Dim DaM As New OleDbDataAdapter("SELECT IndCode as Code,Part as [Main Group],BsGroup as [Group],UCode as [Under Code],BsType as [Type]FROM BsHead", Con)
        DaM = New OleDbDataAdapter("SELECT B1.IndCode as Code,B1.Part as [Main Group],B1.BsGroup as [Group],B1.UCode as [Under Code],B1.BsType as [Type],B2.Part as UGroup FROM BsHead B1,BsHead B2 WHERE B2.IndCode=B1.UCode", Con)
        'Dim DaS As New OleDbDataAdapter("SELECT IndCode as Code,Part as [Particulars],BsGroup as [Group],UCode as UCode From BsHead WHERE IndCode<>UCode", Con)
        DaM.Fill(Ds, "MainGroup")
        'DaS.Fill(Ds, "Slave")
        'Dim MSRelation As DataRelation = Ds.Relations.Add("Show", Ds.Tables("MainGroup").Columns("Code"), Ds.Tables("Slave").Columns("UCode"))
        DGrid.DataSource = Ds
        DGrid.DataMember = "MainGroup"
        Con.Close()
        DGrid.ReadOnly = True
        SubGr.Hide()
    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Close()
    End Sub
    Private Sub DGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGrid.Click
        If SubGr.Visible = True Then Exit Sub
        Dim L, T As Integer
        Dim iRow As Int16
        iRow = DGrid.CurrentRowIndex
        If iRow >= 0 Then
            ShowSubGroup(DGrid.Item(iRow, 0), DGrid.Item(iRow, 1))
            L = DGrid.GetCellBounds(DGrid.CurrentCell.RowNumber, 0).Left
            If DGrid.GetCellBounds(DGrid.CurrentCell.RowNumber, 0).Top < Me.Height / 2 Then
                T = DGrid.GetCellBounds(DGrid.CurrentCell.RowNumber, 0).Top + DGrid.GetCellBounds(DGrid.CurrentCell.RowNumber, 0).Height
            Else
                T = DGrid.GetCellBounds(DGrid.CurrentCell.RowNumber, 0).Top - SubGr.Height
            End If
            SubGr.SetBounds(L, T, SubGr.Width, SubGr.Height)
            SubGr.Show()
            DGSlave.Focus()
            strGr = IIf(IsDBNull(DGrid.Item(iRow, 2)), "", DGrid.Item(iRow, 2))
            strUCode = IIf(IsDBNull(DGrid.Item(iRow, 0)), "", DGrid.Item(iRow, 0))
            strBsType = IIf(IsDBNull(DGrid.Item(iRow, 4)), "", DGrid.Item(iRow, 4))
            DGrid.Enabled = False
        End If
    End Sub

    Private Sub DGrid_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGrid.Scroll
        SubGr.Hide()
    End Sub

    Private Sub Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        SubGr.Hide()
        DGrid.Enabled = True
    End Sub
    Private Sub ShowSubGroup(ByVal StrUCode As String, ByVal MainGr As String, Optional ByVal Gr As String = "", Optional ByVal UCode As String = "")
        If Con.State Then Con.Close()
        Da = New OleDbDataAdapter("SELECT IndCode as Code,Part as [Particulars],BsGroup as [Group],UCode as UCode,BsType From BsHead WHERE IndCode<>UCode AND UCode='" & StrUCode & "'", Con)
        CmdBuild = New OleDbCommandBuilder(Da)
        Try
            Con.Open()
            DsS.Clear()
            Da.Fill(DsS, "S")
            DGSlave.DataSource = DsS
            DGSlave.DataMember = "S"
            DGSlave.CaptionText = "Main Group : " & MainGr
        Catch ex As OleDbException
            MsgBox(ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub CmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSave.Click
        Try
            Da.Update(DsS, "S")
            DsS.AcceptChanges()
            MsgBox("The Record Saved Sucessfully")
            CmdSave.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DGrid.Enabled = True
        End Try
    End Sub
    Private Sub DGSlave_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGSlave.CurrentCellChanged
        DGSlave.Item(DGSlave.CurrentRowIndex, 2) = strGr
        DGSlave.Item(DGSlave.CurrentRowIndex, 3) = strUCode
        DGSlave.Item(DGSlave.CurrentRowIndex, 4) = strBsType
        CmdSave.Enabled = True
    End Sub
    Private Sub DGSlave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGSlave.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                CmdSave_Click(Me, e.Empty)
            Case Keys.Escape
                SubGr.Hide()
        End Select
    End Sub

    Private Sub DGSlave_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DGSlave.Navigate

    End Sub

    Private Sub DGrid_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DGrid.Navigate

    End Sub
End Class
