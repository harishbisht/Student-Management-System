Imports System.Data.OleDb
Public Class frmStudentPayments
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
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DsStudentsPayments1 As sis.dsStudentsPayments
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsStudentsPayments2 As sis.dsStudentsPayments
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents cmbBatchCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.DsStudentsPayments2 = New sis.dsStudentsPayments()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.cmbBatchCode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DsStudentsPayments2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "STUDENTS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ROLLNO", "ROLLNO"), New System.Data.Common.DataColumnMapping("SNAME", "SNAME"), New System.Data.Common.DataColumnMapping("QUAL", "QUAL"), New System.Data.Common.DataColumnMapping("CURROCUP", "CURROCUP"), New System.Data.Common.DataColumnMapping("DJ", "DJ"), New System.Data.Common.DataColumnMapping("FEEPAID", "FEEPAID")})})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT ROLLNO, SNAME, QUAL, CURROCUP, DJ, FEEPAID, BCODE FROM STUDENTS WHERE (BCO" & _
        "DE = ?) ORDER BY ROLLNO"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        Me.OleDbSelectCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BCODE", System.Data.OleDb.OleDbType.VarChar, 15, "BCODE"))
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=MSDAORA.1;Password=sis;User ID=sis"
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PAYMENTS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BCODE", "BCODE"), New System.Data.Common.DataColumnMapping("ROLLNO", "ROLLNO"), New System.Data.Common.DataColumnMapping("DP", "DP"), New System.Data.Common.DataColumnMapping("AMT", "AMT"), New System.Data.Common.DataColumnMapping("TOWARDS", "TOWARDS"), New System.Data.Common.DataColumnMapping("RCPTNO", "RCPTNO")})})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT BCODE, ROLLNO, DP, AMT, decode(TOWARDS, 'f', 'Fee', 'r', 'Registration', '" & _
        "Lab') AS TOWARDS, RCPTNO FROM PAYMENTS WHERE (BCODE = ?) ORDER BY DP"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        Me.OleDbSelectCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("BCODE", System.Data.OleDb.OleDbType.VarChar, 15, "BCODE"))
        '
        'DsStudentsPayments2
        '
        Me.DsStudentsPayments2.DataSetName = "dsStudentsPayments"
        Me.DsStudentsPayments2.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsStudentsPayments2.Namespace = "http://www.tempuri.org/dsStudentsPayments.xsd"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(2, 37)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(664, 214)
        Me.DataGrid1.TabIndex = 0
        '
        'cmbBatchCode
        '
        Me.cmbBatchCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBatchCode.Location = New System.Drawing.Point(200, 7)
        Me.cmbBatchCode.Name = "cmbBatchCode"
        Me.cmbBatchCode.Size = New System.Drawing.Size(145, 21)
        Me.cmbBatchCode.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Batch"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(367, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 23)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Get Students"
        '
        'frmStudentPayments
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(670, 259)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.cmbBatchCode, Me.Label1, Me.DataGrid1})
        Me.Name = "frmStudentPayments"
        Me.Text = "Students Payments"
        CType(Me.DsStudentsPayments2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmStudentPayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BatchesDataBind()
    End Sub

    Sub BatchesDataBind()
        Dim da As New OleDbDataAdapter("select  bcode from batches order by stdate desc ", con)
        Dim ds As New DataSet()

        da.Fill(ds, "batches")

        cmbBatchCode.DisplayMember = "BCODE"
        cmbBatchCode.ValueMember = "BCODE"
        cmbBatchCode.DataSource = ds.Tables(0)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' students 
        DsStudentsPayments2.Clear()
        OleDbDataAdapter1.SelectCommand.Parameters(0).Value = cmbBatchCode.SelectedValue
        OleDbDataAdapter1.Fill(DsStudentsPayments2)
        'payments
        OleDbDataAdapter2.SelectCommand.Parameters(0).Value = cmbBatchCode.SelectedValue
        OleDbDataAdapter2.Fill(DsStudentsPayments2)

        DataGrid1.DataSource = DsStudentsPayments2.Tables("students")
    End Sub
End Class
