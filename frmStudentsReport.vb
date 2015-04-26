Public Class frmStudentsReport
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
    Friend WithEvents DsStudents1 As sis.dsStudents
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.DsStudents1 = New sis.dsStudents()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DsStudents1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "STUDENTS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BCODE", "BCODE"), New System.Data.Common.DataColumnMapping("ROLLNO", "ROLLNO"), New System.Data.Common.DataColumnMapping("SNAME", "SNAME"), New System.Data.Common.DataColumnMapping("FNAME", "FNAME"), New System.Data.Common.DataColumnMapping("EMAIL", "EMAIL"), New System.Data.Common.DataColumnMapping("CURROCUP", "CURROCUP"), New System.Data.Common.DataColumnMapping("DJ", "DJ"), New System.Data.Common.DataColumnMapping("FEEPAID", "FEEPAID")})})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT BCODE, ROLLNO, SNAME, FNAME, EMAIL, CURROCUP, DJ, FEEPAID FROM STUDENTS OR" & _
        "DER BY BCODE, ROLLNO"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=MSDAORA.1;Password=sis;User ID=sis"
        '
        'DsStudents1
        '
        Me.DsStudents1.DataSetName = "dsStudents"
        Me.DsStudents1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsStudents1.Namespace = "http://www.tempuri.org/dsStudents.xsd"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(695, 277)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'frmStudentsReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(695, 277)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.CrystalReportViewer1})
        Me.Name = "frmStudentsReport"
        Me.Text = "frmStudentsReport"
        CType(Me.DsStudents1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmStudentsReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OleDbDataAdapter1.Fill(DsStudents1)
        Dim rep As New StudentsReport()
        rep.SetDataSource(DsStudents1.Tables(0))

        CrystalReportViewer1.ReportSource = rep


    End Sub
End Class
