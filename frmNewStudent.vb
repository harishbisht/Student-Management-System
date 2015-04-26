Imports System.Data.OleDb
Public Class frmNewStudent
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
    Friend WithEvents txtRollno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbBatchCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCurrOcup As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtQual As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRcptNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents dtpDP As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAmt As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtRollno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbBatchCode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCurrOcup = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtQual = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpDP = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAmt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRcptNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRollno
        '
        Me.txtRollno.Location = New System.Drawing.Point(413, 10)
        Me.txtRollno.Name = "txtRollno"
        Me.txtRollno.ReadOnly = True
        Me.txtRollno.Size = New System.Drawing.Size(59, 20)
        Me.txtRollno.TabIndex = 11
        Me.txtRollno.TabStop = False
        Me.txtRollno.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(365, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Rollno"
        '
        'cmbBatchCode
        '
        Me.cmbBatchCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBatchCode.Location = New System.Drawing.Point(98, 9)
        Me.cmbBatchCode.Name = "cmbBatchCode"
        Me.cmbBatchCode.Size = New System.Drawing.Size(145, 21)
        Me.cmbBatchCode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Batch"
        '
        'txtSname
        '
        Me.txtSname.Location = New System.Drawing.Point(98, 39)
        Me.txtSname.Name = "txtSname"
        Me.txtSname.Size = New System.Drawing.Size(172, 20)
        Me.txtSname.TabIndex = 15
        Me.txtSname.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Student Name"
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(413, 40)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(172, 20)
        Me.txtFname.TabIndex = 17
        Me.txtFname.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(322, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Father's Name"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(98, 69)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(492, 20)
        Me.txtAddress.TabIndex = 19
        Me.txtAddress.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Address"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(413, 108)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(172, 20)
        Me.txtEmail.TabIndex = 23
        Me.txtEmail.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(369, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Email"
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Location = New System.Drawing.Point(98, 107)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(172, 20)
        Me.txtPhoneNo.TabIndex = 21
        Me.txtPhoneNo.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Phone No."
        '
        'txtCurrOcup
        '
        Me.txtCurrOcup.Location = New System.Drawing.Point(413, 145)
        Me.txtCurrOcup.Name = "txtCurrOcup"
        Me.txtCurrOcup.Size = New System.Drawing.Size(172, 20)
        Me.txtCurrOcup.TabIndex = 27
        Me.txtCurrOcup.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(325, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Current Ocup."
        '
        'txtQual
        '
        Me.txtQual.Location = New System.Drawing.Point(98, 144)
        Me.txtQual.Name = "txtQual"
        Me.txtQual.Size = New System.Drawing.Size(172, 20)
        Me.txtQual.TabIndex = 25
        Me.txtQual.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Qualification"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpDP, Me.Label12, Me.txtAmt, Me.Label11, Me.txtRcptNo, Me.Label10})
        Me.GroupBox1.Location = New System.Drawing.Point(18, 174)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 110)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Details"
        '
        'dtpDP
        '
        Me.dtpDP.CustomFormat = "dd-MMM-yy"
        Me.dtpDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDP.Location = New System.Drawing.Point(107, 79)
        Me.dtpDP.Name = "dtpDP"
        Me.dtpDP.Size = New System.Drawing.Size(122, 20)
        Me.dtpDP.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Payment Date"
        '
        'txtAmt
        '
        Me.txtAmt.Location = New System.Drawing.Point(109, 52)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(75, 20)
        Me.txtAmt.TabIndex = 29
        Me.txtAmt.Text = "250"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(58, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Amount"
        '
        'txtRcptNo
        '
        Me.txtRcptNo.Location = New System.Drawing.Point(110, 22)
        Me.txtRcptNo.Name = "txtRcptNo"
        Me.txtRcptNo.Size = New System.Drawing.Size(75, 20)
        Me.txtRcptNo.TabIndex = 27
        Me.txtRcptNo.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Receipt No."
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(474, 199)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(87, 23)
        Me.btnAdd.TabIndex = 29
        Me.btnAdd.Text = "&Add Student"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(472, 241)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 23)
        Me.btnExit.TabIndex = 30
        Me.btnExit.Text = "&Exit"
        '
        'frmNewStudent
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(623, 293)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnAdd, Me.GroupBox1, Me.txtCurrOcup, Me.Label8, Me.txtQual, Me.Label9, Me.txtEmail, Me.Label6, Me.txtPhoneNo, Me.Label7, Me.txtAddress, Me.Label4, Me.txtFname, Me.Label3, Me.txtSname, Me.Label5, Me.txtRollno, Me.Label2, Me.cmbBatchCode, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmNewStudent"
        Me.Text = "New Student"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmNewStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataBind()
        txtRcptNo.Text = GetNextRcptno()
    End Sub

    Sub DataBind()
        Dim da As New OleDbDataAdapter("select  bcode from batches where enddate is null", con)
        Dim ds As New DataSet()

        da.Fill(ds, "batches")

        cmbBatchCode.DisplayMember = "BCODE"
        cmbBatchCode.ValueMember = "BCODE"
        cmbBatchCode.DataSource = ds.Tables(0)

    End Sub

    Public Function GetNextRcptNo() As Integer
        Dim cmd As New OleDbCommand("select  nvl(max(rcptno),0) + 1 from payments", con)
        Return cmd.ExecuteScalar()

    End Function

    Public Function GetNextRollno() As Integer
        Dim cmd As New OleDbCommand("select  nvl(max(rollno),0) + 1 from students where bcode = '" & cmbBatchCode.SelectedValue & "'", con)
        Return cmd.ExecuteScalar()
    End Function

    Private Sub cmbBatchCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBatchCode.Leave
        txtRollno.Text = GetNextRollno()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim cmd As New OleDbCommand(" insert into students values (?,?,?,?,?,?,?,?,?,?,?) ", con)
        cmd.Parameters.Add("bcode", OleDbType.VarChar, 15).Value = cmbBatchCode.SelectedValue
        cmd.Parameters.Add("rollno", OleDbType.Integer).Value = txtRollno.Text
        cmd.Parameters.Add("sname", OleDbType.VarChar, 30).Value = txtSname.Text
        cmd.Parameters.Add("fname", OleDbType.VarChar, 30).Value = txtFname.Text
        cmd.Parameters.Add("address", OleDbType.VarChar, 100).Value = txtAddress.Text
        cmd.Parameters.Add("phoneno", OleDbType.VarChar, 30).Value = txtPhoneNo.Text
        cmd.Parameters.Add("email", OleDbType.VarChar, 30).Value = txtEmail.Text
        cmd.Parameters.Add("qual", OleDbType.VarChar, 30).Value = txtQual.Text
        cmd.Parameters.Add("currocup", OleDbType.VarChar, 30).Value = txtCurrOcup.Text
        cmd.Parameters.Add("dj", OleDbType.VarChar, 10).Value = dtpDP.Text
        cmd.Parameters.Add("feepaid", OleDbType.Integer).Value = txtAmt.Text

        Try
            ' begin trans
            cmd.ExecuteNonQuery()
            ' add payment record
            cmd.Parameters.Clear()
            cmd.CommandText = "insert into payments values (?,?,?,?,?,'r')"

            cmd.Parameters.Add("rcptno", OleDbType.Integer).Value = txtRcptNo.Text
            cmd.Parameters.Add("bcode", OleDbType.VarChar, 15).Value = cmbBatchCode.SelectedValue
            cmd.Parameters.Add("rollno", OleDbType.Integer).Value = txtRollno.Text
            cmd.Parameters.Add("amt", OleDbType.Integer).Value = txtAmt.Text
            cmd.Parameters.Add("dp", OleDbType.VarChar, 15).Value = dtpDP.Text

            cmd.ExecuteNonQuery()
            'commit 
            MsgBox("New Student Details Have Been Successfully Added", , "Status")

            clearform()
        Catch ex As Exception
            'rollback 
            MsgBox("Erro r: " & ex.Message)
        End Try

    End Sub

    Sub ClearForm()
        Dim c As Control

        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next

        txtRollno.Text = GetNextRollno()
        txtRcptNo.Text = GetNextRcptNo()
        txtAmt.Text = "250"
        dtpDP.Value = Now
        txtSname.Focus()

    End Sub
End Class
