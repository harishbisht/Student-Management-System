Imports System.Data.OleDb
Public Class frmUpdateBatch
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents dtpStdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTiming As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNoSessions As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTFee As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLFee As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbBatchCode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.dtpStdate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTiming = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNoSessions = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTFee = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLFee = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbBatchCode
        '
        Me.cmbBatchCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBatchCode.Location = New System.Drawing.Point(110, 5)
        Me.cmbBatchCode.Name = "cmbBatchCode"
        Me.cmbBatchCode.Size = New System.Drawing.Size(145, 21)
        Me.cmbBatchCode.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select Batch"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(274, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Subject "
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(339, 7)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(140, 20)
        Me.txtSubject.TabIndex = 7
        Me.txtSubject.Text = ""
        '
        'dtpStdate
        '
        Me.dtpStdate.CustomFormat = "dd-MMM-yy"
        Me.dtpStdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStdate.Location = New System.Drawing.Point(110, 36)
        Me.dtpStdate.Name = "dtpStdate"
        Me.dtpStdate.Size = New System.Drawing.Size(122, 20)
        Me.dtpStdate.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "St. Date"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Checked = False
        Me.dtpEndDate.CustomFormat = "dd-MMM-yy"
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(339, 40)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.ShowCheckBox = True
        Me.dtpEndDate.Size = New System.Drawing.Size(128, 20)
        Me.dtpEndDate.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(268, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "End Date"
        '
        'txtTiming
        '
        Me.txtTiming.Location = New System.Drawing.Point(110, 70)
        Me.txtTiming.Name = "txtTiming"
        Me.txtTiming.Size = New System.Drawing.Size(119, 20)
        Me.txtTiming.TabIndex = 13
        Me.txtTiming.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Timing"
        '
        'txtNoSessions
        '
        Me.txtNoSessions.Location = New System.Drawing.Point(339, 70)
        Me.txtNoSessions.Name = "txtNoSessions"
        Me.txtNoSessions.Size = New System.Drawing.Size(64, 20)
        Me.txtNoSessions.TabIndex = 15
        Me.txtNoSessions.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(232, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "No. Of Sessions"
        '
        'txtTFee
        '
        Me.txtTFee.Location = New System.Drawing.Point(110, 99)
        Me.txtTFee.Name = "txtTFee"
        Me.txtTFee.Size = New System.Drawing.Size(64, 20)
        Me.txtTFee.TabIndex = 17
        Me.txtTFee.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Theory Fee"
        '
        'txtLFee
        '
        Me.txtLFee.Location = New System.Drawing.Point(339, 99)
        Me.txtLFee.Name = "txtLFee"
        Me.txtLFee.Size = New System.Drawing.Size(64, 20)
        Me.txtLFee.TabIndex = 19
        Me.txtLFee.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(274, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Lab Fee"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(60, 137)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "&Update"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(210, 137)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "&Delete"
        '
        'btnexit
        '
        Me.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnexit.Location = New System.Drawing.Point(360, 137)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.TabIndex = 22
        Me.btnexit.Text = "&Exit"
        '
        'frmUpdateBatch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(494, 183)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnexit, Me.btnDelete, Me.btnUpdate, Me.txtLFee, Me.Label8, Me.txtTFee, Me.Label7, Me.txtNoSessions, Me.Label6, Me.txtTiming, Me.Label5, Me.dtpEndDate, Me.Label4, Me.dtpStdate, Me.Label3, Me.txtSubject, Me.Label2, Me.cmbBatchCode, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmUpdateBatch"
        Me.Text = "Updation Of Batch"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmUpdateBatch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataBind()
    End Sub

    Sub DataBind()
        Dim da As New OleDbDataAdapter("select  bcode from batches where enddate is null", con)
        Dim ds As New DataSet()

        da.Fill(ds, "batches")

        cmbBatchCode.DisplayMember = "BCODE"
        cmbBatchCode.ValueMember = "BCODE"
        cmbBatchCode.DataSource = ds.Tables(0)

    End Sub

    Private Sub cmbBatchCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBatchCode.Leave
        ' get details of selected batch
        Dim cmd As New OleDbCommand("select * from batches where bcode = '" & cmbBatchCode.SelectedValue & "'", con)
        Dim dr As OleDbDataReader

        dr = cmd.ExecuteReader()

        dr.Read()
        ' copy  data into controls
        txtSubject.Text = dr.Item("subject")
        txtTFee.Text = dr.Item("tfee")
        txtLFee.Text = dr.Item("lfee")
        txtTiming.Text = dr.Item("timing")
        dtpStdate.Value = dr.Item("stdate")
        txtNoSessions.Text = dr.Item("nosessions")

        dr.Close()


    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim cmd As New OleDbCommand("update batches set  subject = ?, timing = ?, stdate = ? , enddate = ?,  tfee  = ?, lfee = ?, nosessions = ? where bcode = ?", con)

        cmd.Parameters.Add("subject", OleDbType.VarChar, 10).Value = txtSubject.Text
        cmd.Parameters.Add("timing", OleDbType.VarChar, 15).Value = txtTiming.Text
        cmd.Parameters.Add("stdate", OleDbType.VarChar, 10).Value = dtpStdate.Text

        If dtpEndDate.Checked Then
            cmd.Parameters.Add("enddate", OleDbType.VarChar, 10).Value = dtpEndDate.Text
        Else
            cmd.Parameters.Add("enddate", OleDbType.VarChar, 10).Value = DBNull.Value
        End If

        cmd.Parameters.Add("tfee", OleDbType.Integer).Value = txtTFee.Text
        cmd.Parameters.Add("lfee", OleDbType.Integer).Value = txtLFee.Text
        cmd.Parameters.Add("nosessions", OleDbType.Integer).Value = txtNoSessions.Text

        cmd.Parameters.Add("bcode", OleDbType.VarChar, 15).Value = cmbBatchCode.SelectedValue

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Updation is sucessfull1", , "Status")
        Catch ex As Exception
            MsgBox("Error :" & ex.Message)
        End Try

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ' take confirmation
        Dim resp As DialogResult

        resp = MessageBox.Show("Do you want to delete current batch?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resp = DialogResult.No Then
            Exit Sub
        End If

        ' delete current batch
        Dim cmd As New OleDbCommand()

        cmd.CommandText = "deletebatch"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con

        cmd.Parameters.Add("batchcode", OleDbType.VarChar, 15).Value = cmbBatchCode.SelectedValue

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Batch has been deleted sucessfully", , "Status")
            clearform()
            DataBind()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, , "Error")
        End Try

    End Sub

    Sub ClearForm()
        txtSubject.Clear()
        txtTiming.Clear()
        txtTFee.Clear()
        txtLFee.Clear()
        dtpEndDate.Checked = False
        txtNoSessions.Clear()
        cmbBatchCode.Focus()
    End Sub
End Class
