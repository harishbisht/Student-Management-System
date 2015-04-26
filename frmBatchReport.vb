Public Class frmBatchReport
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
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsBatches1 As sis.dsBatches
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.DsBatches1 = New sis.dsBatches()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DsBatches1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "BATCHES", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BCODE", "BCODE"), New System.Data.Common.DataColumnMapping("SUBJECT", "SUBJECT"), New System.Data.Common.DataColumnMapping("STDATE", "STDATE"), New System.Data.Common.DataColumnMapping("ENDDATE", "ENDDATE"), New System.Data.Common.DataColumnMapping("TIMING", "TIMING"), New System.Data.Common.DataColumnMapping("NOSESSIONS", "NOSESSIONS"), New System.Data.Common.DataColumnMapping("TFEE", "TFEE"), New System.Data.Common.DataColumnMapping("LFEE", "LFEE")})})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT BCODE, SUBJECT, STDATE, ENDDATE, TIMING, NOSESSIONS, TFEE, LFEE FROM BATCH" & _
        "ES ORDER BY STDATE DESC"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=MSDAORA.1;Password=sis;User ID=sis"
        '
        'DsBatches1
        '
        Me.DsBatches1.DataSetName = "dsBatches"
        Me.DsBatches1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsBatches1.Namespace = "http://www.tempuri.org/dsBatches.xsd"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(597, 256)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'frmBatchReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(597, 256)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.CrystalReportViewer1})
        Me.Name = "frmBatchReport"
        Me.Text = "frmBatchReport"
        CType(Me.DsBatches1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmBatchReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OleDbDataAdapter1.Fill(DsBatches1)
        Dim rep As New BatchReport()
        rep.SetDataSource(DsBatches1.Tables(0))

        CrystalReportViewer1.ReportSource = rep


    End Sub
End Class
