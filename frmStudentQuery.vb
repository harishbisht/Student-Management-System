Imports System.Data.OleDb
Public Class frmStudentQuery
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
    Friend WithEvents cmbBatchCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSubject As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFromRollno As System.Windows.Forms.TextBox
    Friend WithEvents txtToRollno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents btnQuery As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsname As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtocup As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbFeePaid As System.Windows.Forms.ComboBox
    Friend WithEvents txtfeepaid As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbBatchCode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSubject = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFromRollno = New System.Windows.Forms.TextBox()
        Me.txtToRollno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsname = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtocup = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbFeePaid = New System.Windows.Forms.ComboBox()
        Me.txtfeepaid = New System.Windows.Forms.TextBox()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbBatchCode
        '
        Me.cmbBatchCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBatchCode.Location = New System.Drawing.Point(74, 10)
        Me.cmbBatchCode.Name = "cmbBatchCode"
        Me.cmbBatchCode.Size = New System.Drawing.Size(145, 21)
        Me.cmbBatchCode.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Batch"
        '
        'cmbSubject
        '
        Me.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubject.Location = New System.Drawing.Point(280, 10)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(145, 21)
        Me.cmbSubject.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(231, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Subject"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(441, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Rollno"
        '
        'txtFromRollno
        '
        Me.txtFromRollno.Location = New System.Drawing.Point(494, 10)
        Me.txtFromRollno.Name = "txtFromRollno"
        Me.txtFromRollno.Size = New System.Drawing.Size(51, 20)
        Me.txtFromRollno.TabIndex = 41
        Me.txtFromRollno.Text = ""
        '
        'txtToRollno
        '
        Me.txtToRollno.Location = New System.Drawing.Point(610, 10)
        Me.txtToRollno.Name = "txtToRollno"
        Me.txtToRollno.Size = New System.Drawing.Size(51, 20)
        Me.txtToRollno.TabIndex = 43
        Me.txtToRollno.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(568, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "To"
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(586, 75)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.TabIndex = 44
        Me.btnQuery.Text = "&Query"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(9, 111)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(706, 196)
        Me.DataGrid1.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Name "
        '
        'txtsname
        '
        Me.txtsname.Location = New System.Drawing.Point(74, 41)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(144, 20)
        Me.txtsname.TabIndex = 47
        Me.txtsname.Text = ""
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(281, 41)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(144, 20)
        Me.txtFname.TabIndex = 49
        Me.txtFname.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(234, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Father"
        '
        'txtocup
        '
        Me.txtocup.Location = New System.Drawing.Point(517, 41)
        Me.txtocup.Name = "txtocup"
        Me.txtocup.Size = New System.Drawing.Size(144, 20)
        Me.txtocup.TabIndex = 51
        Me.txtocup.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(441, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Occupation"
        '
        'dtpFrom
        '
        Me.dtpFrom.Checked = False
        Me.dtpFrom.CustomFormat = "dd-MMM-yy"
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(73, 75)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.ShowCheckBox = True
        Me.dtpFrom.Size = New System.Drawing.Size(89, 20)
        Me.dtpFrom.TabIndex = 53
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Joined"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(182, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 13)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "To"
        '
        'dtpTo
        '
        Me.dtpTo.Checked = False
        Me.dtpTo.CustomFormat = "dd-MMM-yy"
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(213, 75)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.ShowCheckBox = True
        Me.dtpTo.Size = New System.Drawing.Size(91, 20)
        Me.dtpTo.TabIndex = 55
        Me.dtpTo.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(326, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Fee Paid"
        '
        'cmbFeePaid
        '
        Me.cmbFeePaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFeePaid.Items.AddRange(New Object() {">", "<", "=", "<>", ">=", "<="})
        Me.cmbFeePaid.Location = New System.Drawing.Point(390, 75)
        Me.cmbFeePaid.Name = "cmbFeePaid"
        Me.cmbFeePaid.Size = New System.Drawing.Size(70, 21)
        Me.cmbFeePaid.TabIndex = 57
        '
        'txtfeepaid
        '
        Me.txtfeepaid.Location = New System.Drawing.Point(484, 75)
        Me.txtfeepaid.Name = "txtfeepaid"
        Me.txtfeepaid.Size = New System.Drawing.Size(78, 20)
        Me.txtfeepaid.TabIndex = 58
        Me.txtfeepaid.Text = ""
        '
        'frmStudentQuery
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 314)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtfeepaid, Me.cmbFeePaid, Me.Label9, Me.dtpTo, Me.Label8, Me.dtpFrom, Me.Label12, Me.txtocup, Me.Label7, Me.txtFname, Me.Label6, Me.txtsname, Me.Label5, Me.DataGrid1, Me.btnQuery, Me.txtToRollno, Me.Label4, Me.txtFromRollno, Me.Label3, Me.cmbSubject, Me.Label2, Me.cmbBatchCode, Me.Label1})
        Me.Name = "frmStudentQuery"
        Me.Text = "Student Query"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmStudentQuery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BatchesDataBind()
        SubjectsDataBind()
    End Sub

    Sub BatchesDataBind()
        Dim da As New OleDbDataAdapter("select  bcode from batches order by stdate desc ", con)
        Dim ds As New DataSet()

        da.Fill(ds, "batches")

        Dim dr As DataRow
        dr = ds.Tables(0).NewRow
        dr.Item(0) = "ALL"

        ds.Tables(0).Rows.InsertAt(dr, 0)

        cmbBatchCode.DisplayMember = "BCODE"
        cmbBatchCode.ValueMember = "BCODE"
        cmbBatchCode.DataSource = ds.Tables(0)

    End Sub


    Sub SubjectsDataBind()
        Dim da As New OleDbDataAdapter("select  distinct subject from batches order by subject", con)
        Dim ds As New DataSet()

        da.Fill(ds, "subjects")

        Dim dr As DataRow
        dr = ds.Tables(0).NewRow
        dr.Item(0) = "ALL"

        ds.Tables(0).Rows.InsertAt(dr, 0)

        cmbSubject.DisplayMember = "SUBJECT"
        cmbSubject.ValueMember = "SUBJECT"
        cmbSubject.DataSource = ds.Tables(0)

    End Sub

    
    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        Dim cond As String = "1=1"

        If cmbBatchCode.SelectedIndex <> 0 Then
            cond &= " and  bcode = '" & cmbBatchCode.SelectedValue & "'"
        End If

        If cmbSubject.SelectedIndex <> 0 Then
            cond &= " and  bcode in ( select bcode from batches where subject = '" & cmbSubject.SelectedValue & "')"
        End If

        If txtFromRollno.Text <> "" Then
            cond &= "  and  rollno >= " & txtFromRollno.Text
        End If

        If txtToRollno.Text <> "" Then
            cond &= "  and  rollno <= " & txtToRollno.Text
        End If

        If txtsname.Text <> "" Then
            cond &= " and upper(sname) like '%" & txtsname.Text.ToUpper() & "%'"
        End If


        If txtFname.Text <> "" Then
            cond &= " and  upper(fname) like '%" & txtFname.Text.ToUpper() & "%'"
        End If


        If txtocup.Text <> "" Then
            cond &= "  and upper(currocup) like '%" & txtocup.Text.ToUpper() & "%'"
        End If

        If dtpFrom.Checked Then
            cond &= " and dj  >= '" & dtpFrom.Text & "'"
        End If

        If dtpTo.Checked Then
            cond &= " and dj  <= '" & dtpTo.Text & "'"
        End If

        If txtfeepaid.Text <> "" Then
            cond &= " and feepaid  " & cmbFeePaid.Text & txtfeepaid.Text
        End If


        MsgBox(cond)

        Dim da As New OleDbDataAdapter("select * from students where " & cond, con)
        Dim ds As New DataSet()

        da.Fill(ds, "students")

        DataGrid1.DataSource = ds.Tables(0)




    End Sub
End Class
