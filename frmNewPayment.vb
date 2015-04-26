Imports System.Data.OleDb
Public Class frmNewPayment
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
    Friend WithEvents txtRcptNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpDP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtRollno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbBatchCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtdueamt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbTowards As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtRcptNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpDP = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRollno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbBatchCode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdueamt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAmt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbTowards = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtRcptNo
        '
        Me.txtRcptNo.Location = New System.Drawing.Point(97, 13)
        Me.txtRcptNo.Name = "txtRcptNo"
        Me.txtRcptNo.Size = New System.Drawing.Size(75, 20)
        Me.txtRcptNo.TabIndex = 29
        Me.txtRcptNo.TabStop = False
        Me.txtRcptNo.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Receipt No."
        '
        'dtpDP
        '
        Me.dtpDP.CustomFormat = "dd-MMM-yy"
        Me.dtpDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDP.Location = New System.Drawing.Point(319, 14)
        Me.dtpDP.Name = "dtpDP"
        Me.dtpDP.Size = New System.Drawing.Size(122, 20)
        Me.dtpDP.TabIndex = 33
        Me.dtpDP.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(223, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Payment Date"
        '
        'txtRollno
        '
        Me.txtRollno.Location = New System.Drawing.Point(319, 43)
        Me.txtRollno.Name = "txtRollno"
        Me.txtRollno.Size = New System.Drawing.Size(117, 20)
        Me.txtRollno.TabIndex = 37
        Me.txtRollno.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(263, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Rollno"
        '
        'cmbBatchCode
        '
        Me.cmbBatchCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBatchCode.Location = New System.Drawing.Point(97, 41)
        Me.cmbBatchCode.Name = "cmbBatchCode"
        Me.cmbBatchCode.Size = New System.Drawing.Size(145, 21)
        Me.cmbBatchCode.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Batch"
        '
        'txtSname
        '
        Me.txtSname.Location = New System.Drawing.Point(97, 71)
        Me.txtSname.Name = "txtSname"
        Me.txtSname.ReadOnly = True
        Me.txtSname.Size = New System.Drawing.Size(144, 20)
        Me.txtSname.TabIndex = 39
        Me.txtSname.TabStop = False
        Me.txtSname.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Student Name"
        '
        'txtdueamt
        '
        Me.txtdueamt.Location = New System.Drawing.Point(319, 73)
        Me.txtdueamt.Name = "txtdueamt"
        Me.txtdueamt.ReadOnly = True
        Me.txtdueamt.Size = New System.Drawing.Size(110, 20)
        Me.txtdueamt.TabIndex = 41
        Me.txtdueamt.TabStop = False
        Me.txtdueamt.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(248, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Due Amt."
        '
        'txtAmt
        '
        Me.txtAmt.Location = New System.Drawing.Point(97, 104)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(117, 20)
        Me.txtAmt.TabIndex = 43
        Me.txtAmt.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(252, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Towards"
        '
        'cmbTowards
        '
        Me.cmbTowards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTowards.Items.AddRange(New Object() {"Fee", "Lab", "Registration"})
        Me.cmbTowards.Location = New System.Drawing.Point(319, 107)
        Me.cmbTowards.Name = "cmbTowards"
        Me.cmbTowards.Size = New System.Drawing.Size(121, 21)
        Me.cmbTowards.TabIndex = 45
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(68, 147)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 46
        Me.btnAdd.Text = "&Add"
        '
        'btnClear
        '
        Me.btnClear.CausesValidation = False
        Me.btnClear.Location = New System.Drawing.Point(206, 147)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.TabIndex = 47
        Me.btnClear.Text = "&Clear"
        '
        'btnExit
        '
        Me.btnExit.CausesValidation = False
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(327, 147)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 48
        Me.btnExit.Text = "&Exit"
        '
        'frmNewPayment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(482, 206)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnClear, Me.btnAdd, Me.cmbTowards, Me.Label6, Me.txtAmt, Me.Label4, Me.txtdueamt, Me.Label3, Me.txtSname, Me.Label5, Me.txtRollno, Me.Label2, Me.cmbBatchCode, Me.Label1, Me.dtpDP, Me.Label12, Me.txtRcptNo, Me.Label10})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmNewPayment"
        Me.Text = "New Payment"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmNewPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataBind()
        txtRcptNo.Text = GetNextRcptNo()
        cmbTowards.SelectedIndex = 0
    End Sub

    Sub DataBind()
        Dim da As New OleDbDataAdapter("select  bcode from batches where enddate is null", con)
        Dim ds As New DataSet()

        da.Fill(ds, "batches")

        cmbBatchCode.DisplayMember = "BCODE"
        cmbBatchCode.ValueMember = "BCODE"
        cmbBatchCode.DataSource = ds.Tables(0)

    End Sub

    Private Sub txtRollno_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRollno.Validating
        ' get details of the given rollno
        If txtRollno.Text.Trim() = "" Then
            e.Cancel = True
            Exit Sub
        End If

        Dim cmdstr As String

        cmdstr = "select  sname, tfee - feepaid due from batches b, students s where b.bcode = s.bcode and s.bcode = ? and rollno = ?"
        Dim cmd As New OleDbCommand(cmdstr, con)
        Try
            cmd.Parameters.Add("bcode", OleDbType.VarChar, 15).Value = cmbBatchCode.SelectedValue
            cmd.Parameters.Add("rollno", OleDbType.Integer).Value = txtRollno.Text

            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()

            If Not dr.Read() Then
                MsgBox("Sorry! Invalid Rollno. Please try again!", , "Error")
                e.Cancel = True
            Else
                txtdueamt.Text = dr.Item("due")
                txtSname.Text = dr.Item("sname")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim cmd As New OleDbCommand("insert into payments values (?,?,?,?,?,?) ", con)

        cmd.Parameters.Add("rcptno", OleDbType.Integer).Value = txtRcptNo.Text
        cmd.Parameters.Add("bcode", OleDbType.VarChar, 15).Value = cmbBatchCode.SelectedValue
        cmd.Parameters.Add("rollno", OleDbType.Integer).Value = txtRollno.Text
        cmd.Parameters.Add("amt", OleDbType.Integer).Value = txtAmt.Text
        cmd.Parameters.Add("dp", OleDbType.VarChar, 10).Value = dtpDP.Text
        cmd.Parameters.Add("towards", OleDbType.Char).Value = cmbTowards.Text.Substring(0, 1).ToLower()

        Try
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update students set feepaid = feepaid + ?  where rollno =? and bcode = ?"
            cmd.Parameters.Clear()
            cmd.Parameters.Add("amt", OleDbType.Integer).Value = txtAmt.Text
            cmd.Parameters.Add("rollno", OleDbType.Integer).Value = txtRollno.Text
            cmd.Parameters.Add("bcode", OleDbType.VarChar, 15).Value = cmbBatchCode.SelectedValue
            cmd.ExecuteNonQuery()
            clearform()
        Catch ex As Exception
            MsgBox("Error " + ex.Message)
        End Try
    End Sub

    Sub ClearForm()
        txtAmt.Clear()
        txtRollno.Clear()
        txtSname.Clear()
        txtdueamt.Clear()
        cmbTowards.SelectedIndex = 0
        txtRollno.Focus()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtAmt.Clear()
        txtRollno.Clear()
        txtSname.Clear()
        txtdueamt.Clear()
        cmbTowards.SelectedIndex = 0
        txtRcptNo.Text = GetNextRcptNo()
        dtpDP.Value = Now
        cmbBatchCode.Focus()
    End Sub
End Class
