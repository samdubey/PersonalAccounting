Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class ReportViewer
    Inherits System.Windows.Forms.Form
    Dim PFields As ParameterFields
    Dim StrSelFormula As String
    Dim WithEvents RD As New ReportDocument
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub
    Public Sub New(ByVal ReportDoc As ReportDocument, ByVal ParamFields As ParameterFields, Optional ByVal strSql As String = "", Optional ByVal StrSelectionFormula As String = "")
        MyBase.New()
        InitializeComponent()
        PFields = ParamFields
        StrSelFormula = StrSelectionFormula
        RD = ReportDoc
    End Sub
    Public Sub New(ByVal ReportDoc As ReportDocument, Optional ByVal SelectionFormula As String = "")
        MyBase.New()
        InitializeComponent()
        RD = ReportDoc
        StrSelFormula = SelectionFormula
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
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = -1
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Location = New System.Drawing.Point(0, 0)
        Me.CRV.Name = "CRV"
        Me.CRV.ReportSource = Nothing
        Me.CRV.Size = New System.Drawing.Size(292, 273)
        Me.CRV.TabIndex = 0
        '
        'ReportViewer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.CRV)
        Me.Name = "ReportViewer"
        Me.Text = "ReportViewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            CRV.SelectionFormula = StrSelFormula
            CRV.ReportSource = RD
            CRV.ShowRefreshButton = False
            CRV.DisplayGroupTree = False
            CRV.Zoom(90)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ''''''''''''''''''''''''''Parameter Field Demo'''''''''
    '    Me.Cursor = Cursors.WaitCursor
    '    Dim ParamFieldS As New ParameterFields
    '    Dim ParamField As New ParameterField
    '    Dim DesreateVal As New ParameterDiscreteValue
    '    ParamField.ParameterFieldName = "CmpName"
    '    DesreateVal.Value = "Siddhi Softwares"
    '    ParamField.CurrentValues.Add(DesreateVal)
    '    ParamFieldS.Add(ParamField)
    '    ParamField = New ParameterField
    '    ParamField.ParameterFieldName = "CmpAdd"
    '    DesreateVal = New ParameterDiscreteValue
    '    DesreateVal.Value = "Near New Bus Stand Jalgaon"
    '    ParamField.CurrentValues.Add(DesreateVal)
    '    ParamFieldS.Add(ParamField)
    '    ParamField = New ParameterField
    '    ParamField.ParameterFieldName = "ToDate"
    '    DesreateVal = New ParameterDiscreteValue
    '    DesreateVal.Value = ToDate.AddDays(-1)
    '    ParamField.CurrentValues.Add(DesreateVal)
    '    ParamFieldS.Add(ParamField)
    '    CRV.ParameterFieldInfo = ParamFieldS
    '    CRV.SelectionFormula = "{BsHead.IndCode}='BB' AND {GEnGl.TDate}<=DATE(2006,06,02)"
    '    CRV.ReportSource = Application.StartupPath & "\..\TRLBAL.RPT"
    '    Me.Cursor = Cursors.Default

    Private Sub CRV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRV.Load

    End Sub
End Class
