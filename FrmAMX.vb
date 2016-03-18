

Public Class FrmAMN
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
    Friend WithEvents FGrid As AxMSFlexGridLib.AxMSFlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmAMN))
        Me.FGrid = New AxMSFlexGridLib.AxMSFlexGrid
        CType(Me.FGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FGrid
        '
        Me.FGrid.Location = New System.Drawing.Point(8, 8)
        Me.FGrid.Name = "FGrid"
        Me.FGrid.OcxState = CType(resources.GetObject("FGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FGrid.Size = New System.Drawing.Size(376, 248)
        Me.FGrid.TabIndex = 0
        '
        'FrmAMN
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(392, 301)
        Me.Controls.Add(Me.FGrid)
        Me.Name = "FrmAMN"
        Me.Text = "Account Master"
        CType(Me.FGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmAMN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FGrid.Cols = 2
        FGrid.Rows = 10

    End Sub
End Class
