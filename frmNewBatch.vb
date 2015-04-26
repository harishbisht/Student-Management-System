Imports System.Data.OleDb
Public Class frmNewBatch
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
    Friend WithEvents txtBatchCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSubject As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpStdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbTiming As System.Windows.Forms.ComboBox
    Friend WithEvents txtNoSessions As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTFee As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLFee As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBatchCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSubject = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpStdate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbTiming = New System.Windows.Forms.ComboBox()
        Me.txtNoSessions = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTFee = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLFee = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Batch Code"
        '
        'txtBatchCode
        '
        Me.txtBatchCode.Location = New System.Drawing.Point(98, 12)
        Me.txtBatchCode.Name = "txtBatchCode"
        Me.txtBatchCode.Size = New System.Drawing.Size(142, 20)
        Me.txtBatchCode.TabIndex = 1
        Me.txtBatchCode.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(274, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Subject"
        '
        'cmbSubject
        '
        Me.cmbSubject.Items.AddRange(New Object() {"ASP.NET", "C# ", "Java (Std)", "J2EE", "Oracle", "VB.NET", "", ""})
        Me.cmbSubject.Location = New System.Drawing.Point(329, 14)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(161, 21)
        Me.cmbSubject.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "St. Date"
        '
        'dtpStdate
        '
        Me.dtpStdate.CustomFormat = "dd-MMM-yy"
        Me.dtpStdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStdate.Location = New System.Drawing.Point(98, 47)
        Me.dtpStdate.Name = "dtpStdate"
        Me.dtpStdate.Size = New System.Drawing.Size(149, 20)
        Me.dtpStdate.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(274, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Timing"
        '
        'cmbTiming
        '
        Me.cmbTiming.Items.AddRange(New Object() {"7-9AM", "9-11AM", "11-1PM", "5-7PM", "7-9PM", ""})
        Me.cmbTiming.Location = New System.Drawing.Point(329, 48)
        Me.cmbTiming.Name = "cmbTiming"
        Me.cmbTiming.Size = New System.Drawing.Size(161, 21)
        Me.cmbTiming.TabIndex = 7
        '
        'txtNoSessions
        '
        Me.txtNoSessions.Location = New System.Drawing.Point(98, 86)
        Me.txtNoSessions.Name = "txtNoSessions"
        Me.txtNoSessions.Size = New System.Drawing.Size(66, 20)
        Me.txtNoSessions.TabIndex = 9
        Me.txtNoSessions.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "No. Sessions"
        '
        'txtTFee
        '
        Me.txtTFee.Location = New System.Drawing.Point(271, 86)
        Me.txtTFee.Name = "txtTFee"
        Me.txtTFee.Size = New System.Drawing.Size(66, 20)
        Me.txtTFee.TabIndex = 11
        Me.txtTFee.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(192, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Theory Fee"
        '
        'txtLFee
        '
        Me.txtLFee.Location = New System.Drawing.Point(421, 86)
        Me.txtLFee.Name = "txtLFee"
        Me.txtLFee.Size = New System.Drawing.Size(66, 20)
        Me.txtLFee.TabIndex = 13
        Me.txtLFee.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(349, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Lab Fee"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(168, 123)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "&Add"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(299, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "&Exit"
        '
        'frmNewBatch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(511, 166)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.btnAdd, Me.txtLFee, Me.Label7, Me.txtTFee, Me.Label6, Me.txtNoSessions, Me.Label5, Me.cmbTiming, Me.Label4, Me.dtpStdate, Me.Label3, Me.cmbSubject, Me.Label2, Me.txtBatchCode, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmNewBatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Batch"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim cmdstr As String

        cmdstr = "insert into batches values('" _
             & txtBatchCode.Text & "','" _
             & cmbSubject.Text & "','" _
             & dtpStdate.Text & "',null,'" _
             & cmbTiming.Text & "'," _
             & txtNoSessions.Text & "," _
             & txtTFee.Text & "," _
             & txtLFee.Text & ")"

        Try
            Dim cmd As New OleDbCommand(cmdstr, con)
            cmd.ExecuteNonQuery()
            MsgBox("Batch Has Been Added Successfully", , "Status")
            ClearForm()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Sub ClearForm()
        txtBatchCode.Clear()
        cmbSubject.SelectedIndex = -1
        cmbTiming.SelectedIndex = -1
        dtpStdate.Value = Now
        txtTFee.Clear()
        txtLFee.Clear()
        txtNoSessions.Clear()
        txtBatchCode.Focus()
    End Sub
End Class
