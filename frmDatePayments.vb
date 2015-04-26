Imports CrystalDecisions.CrystalReports.Engine
Public Class frmDatePayments
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsDatePayments1 As sis.dsDatePayments
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.DsDatePayments1 = New sis.dsDatePayments()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DsDatePayments1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Starting Date:"
        '
        'dtpStart
        '
        Me.dtpStart.CustomFormat = "dd-MMM-yy"
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStart.Location = New System.Drawing.Point(156, 15)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(105, 20)
        Me.dtpStart.TabIndex = 1
        '
        'dtpEnd
        '
        Me.dtpEnd.CustomFormat = "dd-MMM-yy"
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Location = New System.Drawing.Point(444, 19)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(105, 20)
        Me.dtpEnd.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(350, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ending Date :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(579, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PAYMENTS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RCPTNO", "RCPTNO"), New System.Data.Common.DataColumnMapping("BCODE", "BCODE"), New System.Data.Common.DataColumnMapping("ROLLNO", "ROLLNO"), New System.Data.Common.DataColumnMapping("SNAME", "SNAME"), New System.Data.Common.DataColumnMapping("AMT", "AMT"), New System.Data.Common.DataColumnMapping("DP", "DP")})})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT P.RCPTNO, P.BCODE, P.ROLLNO, S.SNAME, P.AMT, P.DP, S.BCODE AS EXPR1, S.ROL" & _
        "LNO AS EXPR2 FROM PAYMENTS P, STUDENTS S WHERE P.BCODE = S.BCODE AND P.ROLLNO = " & _
        "S.ROLLNO AND (P.DP BETWEEN ? AND ?)"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        Me.OleDbSelectCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DP", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "DP"))
        Me.OleDbSelectCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DP1", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "DP"))
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=MSDAORA.1;Password=sis;User ID=sis"
        '
        'DsDatePayments1
        '
        Me.DsDatePayments1.DataSetName = "dsDatePayments"
        Me.DsDatePayments1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsDatePayments1.Namespace = "http://www.tempuri.org/dsDatePayments.xsd"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(20, 47)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(680, 233)
        Me.CrystalReportViewer1.TabIndex = 5
        '
        'frmDatePayments
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(718, 256)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.CrystalReportViewer1, Me.Button1, Me.dtpEnd, Me.Label2, Me.dtpStart, Me.Label1})
        Me.Name = "frmDatePayments"
        Me.Text = "frmDatePayments"
        CType(Me.DsDatePayments1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DsDatePayments1.Clear()
        OleDbDataAdapter1.SelectCommand.Parameters(0).Value = dtpStart.Text
        OleDbDataAdapter1.SelectCommand.Parameters(1).Value = dtpEnd.Text
        OleDbDataAdapter1.Fill(DsDatePayments1)
        Dim rep As New DatePayments()
        rep.SetDataSource(DsDatePayments1.Tables(0))

        Dim t As TextObject

        t = CType(rep.ReportDefinition.ReportObjects("txtdates"), TextObject)
        t.Text = "From : " & dtpStart.Text & " To :" & dtpEnd.Text

        CrystalReportViewer1.ReportSource = rep


    End Sub

    Private Sub frmDatePayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
