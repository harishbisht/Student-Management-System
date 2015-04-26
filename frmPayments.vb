Public Class frmPayments
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
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents objdsPayments As sis.dsPayments
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancelAll As System.Windows.Forms.Button
    Friend WithEvents lblRCPTNO As System.Windows.Forms.Label
    Friend WithEvents lblBCODE As System.Windows.Forms.Label
    Friend WithEvents lblROLLNO As System.Windows.Forms.Label
    Friend WithEvents editRCPTNO As System.Windows.Forms.TextBox
    Friend WithEvents editBCODE As System.Windows.Forms.TextBox
    Friend WithEvents editROLLNO As System.Windows.Forms.TextBox
    Friend WithEvents lblAMT As System.Windows.Forms.Label
    Friend WithEvents lblDP As System.Windows.Forms.Label
    Friend WithEvents lblTOWARDS As System.Windows.Forms.Label
    Friend WithEvents editAMT As System.Windows.Forms.TextBox
    Friend WithEvents editDP As System.Windows.Forms.TextBox
    Friend WithEvents editTOWARDS As System.Windows.Forms.TextBox
    Friend WithEvents btnNavFirst As System.Windows.Forms.Button
    Friend WithEvents btnNavPrev As System.Windows.Forms.Button
    Friend WithEvents lblNavLocation As System.Windows.Forms.Label
    Friend WithEvents btnNavNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.objdsPayments = New sis.dsPayments()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancelAll = New System.Windows.Forms.Button()
        Me.lblRCPTNO = New System.Windows.Forms.Label()
        Me.lblBCODE = New System.Windows.Forms.Label()
        Me.lblROLLNO = New System.Windows.Forms.Label()
        Me.editRCPTNO = New System.Windows.Forms.TextBox()
        Me.editBCODE = New System.Windows.Forms.TextBox()
        Me.editROLLNO = New System.Windows.Forms.TextBox()
        Me.lblAMT = New System.Windows.Forms.Label()
        Me.lblDP = New System.Windows.Forms.Label()
        Me.lblTOWARDS = New System.Windows.Forms.Label()
        Me.editAMT = New System.Windows.Forms.TextBox()
        Me.editDP = New System.Windows.Forms.TextBox()
        Me.editTOWARDS = New System.Windows.Forms.TextBox()
        Me.btnNavFirst = New System.Windows.Forms.Button()
        Me.btnNavPrev = New System.Windows.Forms.Button()
        Me.lblNavLocation = New System.Windows.Forms.Label()
        Me.btnNavNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.objdsPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT RCPTNO, BCODE, ROLLNO, AMT, DP, TOWARDS FROM PAYMENTS"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO PAYMENTS(RCPTNO, BCODE, ROLLNO, AMT, DP, TOWARDS) VALUES (?, ?, ?, ?," & _
        " ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RCPTNO", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "RCPTNO", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BCODE", System.Data.OleDb.OleDbType.VarChar, 15, "BCODE"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ROLLNO", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(3, Byte), CType(0, Byte), "ROLLNO", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AMT", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "AMT", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DP", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "DP"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TOWARDS", System.Data.OleDb.OleDbType.VarChar, 1, "TOWARDS"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE PAYMENTS SET RCPTNO = ?, BCODE = ?, ROLLNO = ?, AMT = ?, DP = ?, TOWARDS =" & _
        " ? WHERE (RCPTNO = ?) AND (AMT = ? OR ? IS NULL AND AMT IS NULL) AND (BCODE = ? " & _
        "OR ? IS NULL AND BCODE IS NULL) AND (DP = ? OR ? IS NULL AND DP IS NULL) AND (RO" & _
        "LLNO = ? OR ? IS NULL AND ROLLNO IS NULL) AND (TOWARDS = ? OR ? IS NULL AND TOWA" & _
        "RDS IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("RCPTNO", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "RCPTNO", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BCODE", System.Data.OleDb.OleDbType.VarChar, 15, "BCODE"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ROLLNO", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(3, Byte), CType(0, Byte), "ROLLNO", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AMT", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "AMT", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DP", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "DP"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TOWARDS", System.Data.OleDb.OleDbType.VarChar, 1, "TOWARDS"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RCPTNO", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "RCPTNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AMT", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "AMT", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AMT1", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "AMT", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BCODE", System.Data.OleDb.OleDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BCODE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BCODE1", System.Data.OleDb.OleDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BCODE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DP", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DP1", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ROLLNO", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(3, Byte), CType(0, Byte), "ROLLNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ROLLNO1", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(3, Byte), CType(0, Byte), "ROLLNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TOWARDS", System.Data.OleDb.OleDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TOWARDS", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TOWARDS1", System.Data.OleDb.OleDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TOWARDS", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM PAYMENTS WHERE (RCPTNO = ?) AND (AMT = ? OR ? IS NULL AND AMT IS NULL" & _
        ") AND (BCODE = ? OR ? IS NULL AND BCODE IS NULL) AND (DP = ? OR ? IS NULL AND DP" & _
        " IS NULL) AND (ROLLNO = ? OR ? IS NULL AND ROLLNO IS NULL) AND (TOWARDS = ? OR ?" & _
        " IS NULL AND TOWARDS IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_RCPTNO", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "RCPTNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AMT", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "AMT", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AMT1", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "AMT", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BCODE", System.Data.OleDb.OleDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BCODE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BCODE1", System.Data.OleDb.OleDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BCODE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DP", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DP1", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ROLLNO", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(3, Byte), CType(0, Byte), "ROLLNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ROLLNO1", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(3, Byte), CType(0, Byte), "ROLLNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TOWARDS", System.Data.OleDb.OleDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TOWARDS", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TOWARDS1", System.Data.OleDb.OleDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TOWARDS", System.Data.DataRowVersion.Original, Nothing))
        '
        'objdsPayments
        '
        Me.objdsPayments.DataSetName = "dsPayments"
        Me.objdsPayments.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objdsPayments.Namespace = "http://www.tempuri.org/dsPayments.xsd"
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=MSDAORA.1;Password=sis;User ID=sis"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PAYMENTS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RCPTNO", "RCPTNO"), New System.Data.Common.DataColumnMapping("BCODE", "BCODE"), New System.Data.Common.DataColumnMapping("ROLLNO", "ROLLNO"), New System.Data.Common.DataColumnMapping("AMT", "AMT"), New System.Data.Common.DataColumnMapping("DP", "DP"), New System.Data.Common.DataColumnMapping("TOWARDS", "TOWARDS")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(10, 10)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "&Load"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(365, 10)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "&Update"
        '
        'btnCancelAll
        '
        Me.btnCancelAll.Location = New System.Drawing.Point(365, 43)
        Me.btnCancelAll.Name = "btnCancelAll"
        Me.btnCancelAll.TabIndex = 2
        Me.btnCancelAll.Text = "Ca&ncel All"
        '
        'lblRCPTNO
        '
        Me.lblRCPTNO.Location = New System.Drawing.Point(10, 76)
        Me.lblRCPTNO.Name = "lblRCPTNO"
        Me.lblRCPTNO.TabIndex = 3
        Me.lblRCPTNO.Text = "RCPTNO"
        '
        'lblBCODE
        '
        Me.lblBCODE.Location = New System.Drawing.Point(10, 109)
        Me.lblBCODE.Name = "lblBCODE"
        Me.lblBCODE.TabIndex = 4
        Me.lblBCODE.Text = "BCODE"
        '
        'lblROLLNO
        '
        Me.lblROLLNO.Location = New System.Drawing.Point(10, 142)
        Me.lblROLLNO.Name = "lblROLLNO"
        Me.lblROLLNO.TabIndex = 5
        Me.lblROLLNO.Text = "ROLLNO"
        '
        'editRCPTNO
        '
        Me.editRCPTNO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsPayments, "PAYMENTS.RCPTNO"))
        Me.editRCPTNO.Location = New System.Drawing.Point(120, 76)
        Me.editRCPTNO.Name = "editRCPTNO"
        Me.editRCPTNO.TabIndex = 6
        Me.editRCPTNO.Text = ""
        '
        'editBCODE
        '
        Me.editBCODE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsPayments, "PAYMENTS.BCODE"))
        Me.editBCODE.Location = New System.Drawing.Point(120, 109)
        Me.editBCODE.Name = "editBCODE"
        Me.editBCODE.TabIndex = 7
        Me.editBCODE.Text = ""
        '
        'editROLLNO
        '
        Me.editROLLNO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsPayments, "PAYMENTS.ROLLNO"))
        Me.editROLLNO.Location = New System.Drawing.Point(120, 142)
        Me.editROLLNO.Name = "editROLLNO"
        Me.editROLLNO.TabIndex = 8
        Me.editROLLNO.Text = ""
        '
        'lblAMT
        '
        Me.lblAMT.Location = New System.Drawing.Point(230, 76)
        Me.lblAMT.Name = "lblAMT"
        Me.lblAMT.TabIndex = 9
        Me.lblAMT.Text = "AMT"
        '
        'lblDP
        '
        Me.lblDP.Location = New System.Drawing.Point(230, 109)
        Me.lblDP.Name = "lblDP"
        Me.lblDP.TabIndex = 10
        Me.lblDP.Text = "DP"
        '
        'lblTOWARDS
        '
        Me.lblTOWARDS.Location = New System.Drawing.Point(230, 142)
        Me.lblTOWARDS.Name = "lblTOWARDS"
        Me.lblTOWARDS.TabIndex = 11
        Me.lblTOWARDS.Text = "TOWARDS"
        '
        'editAMT
        '
        Me.editAMT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsPayments, "PAYMENTS.AMT"))
        Me.editAMT.Location = New System.Drawing.Point(340, 76)
        Me.editAMT.Name = "editAMT"
        Me.editAMT.TabIndex = 12
        Me.editAMT.Text = ""
        '
        'editDP
        '
        Me.editDP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsPayments, "PAYMENTS.DP"))
        Me.editDP.Location = New System.Drawing.Point(340, 109)
        Me.editDP.Name = "editDP"
        Me.editDP.TabIndex = 13
        Me.editDP.Text = ""
        '
        'editTOWARDS
        '
        Me.editTOWARDS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdsPayments, "PAYMENTS.TOWARDS"))
        Me.editTOWARDS.Location = New System.Drawing.Point(340, 142)
        Me.editTOWARDS.Name = "editTOWARDS"
        Me.editTOWARDS.TabIndex = 14
        Me.editTOWARDS.Text = ""
        '
        'btnNavFirst
        '
        Me.btnNavFirst.Location = New System.Drawing.Point(195, 175)
        Me.btnNavFirst.Name = "btnNavFirst"
        Me.btnNavFirst.Size = New System.Drawing.Size(40, 23)
        Me.btnNavFirst.TabIndex = 15
        Me.btnNavFirst.Text = "<<"
        '
        'btnNavPrev
        '
        Me.btnNavPrev.Location = New System.Drawing.Point(235, 175)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(35, 23)
        Me.btnNavPrev.TabIndex = 16
        Me.btnNavPrev.Text = "<"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.BackColor = System.Drawing.Color.White
        Me.lblNavLocation.Location = New System.Drawing.Point(270, 175)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Size = New System.Drawing.Size(95, 23)
        Me.lblNavLocation.TabIndex = 17
        Me.lblNavLocation.Text = "No Records"
        Me.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNavNext
        '
        Me.btnNavNext.Location = New System.Drawing.Point(365, 175)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(35, 23)
        Me.btnNavNext.TabIndex = 18
        Me.btnNavNext.Text = ">"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(400, 175)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(40, 23)
        Me.btnLast.TabIndex = 19
        Me.btnLast.Text = ">>"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(195, 208)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "&Add"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(280, 208)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "&Delete"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(365, 208)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "&Cancel"
        '
        'frmPayments
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(442, 239)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnLoad, Me.btnUpdate, Me.btnCancelAll, Me.lblRCPTNO, Me.lblBCODE, Me.lblROLLNO, Me.editRCPTNO, Me.editBCODE, Me.editROLLNO, Me.lblAMT, Me.lblDP, Me.lblTOWARDS, Me.editAMT, Me.editDP, Me.editTOWARDS, Me.btnNavFirst, Me.btnNavPrev, Me.lblNavLocation, Me.btnNavNext, Me.btnLast, Me.btnAdd, Me.btnDelete, Me.btnCancel})
        Me.Name = "frmPayments"
        Me.Text = "frmPayments"
        CType(Me.objdsPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(objdsPayments, "PAYMENTS").CancelCurrentEdit()
        Me.objdsPayments_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (Me.BindingContext(objdsPayments, "PAYMENTS").Count > 0) Then
            Me.BindingContext(objdsPayments, "PAYMENTS").RemoveAt(Me.BindingContext(objdsPayments, "PAYMENTS").Position)
            Me.objdsPayments_PositionChanged()
        End If

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            'Clear out the current edits
            Me.BindingContext(objdsPayments, "PAYMENTS").EndCurrentEdit()
            Me.BindingContext(objdsPayments, "PAYMENTS").AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.objdsPayments_PositionChanged()

    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            'Attempt to update the datasource.
            Me.UpdateDataSet()
        Catch eUpdate As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        End Try
        Me.objdsPayments_PositionChanged()

    End Sub
    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objdsPayments_PositionChanged()

    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavFirst.Click
        Me.BindingContext(objdsPayments, "PAYMENTS").Position = 0
        Me.objdsPayments_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(objdsPayments, "PAYMENTS").Position = (Me.objdsPayments.Tables("PAYMENTS").Rows.Count - 1)
        Me.objdsPayments_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavPrev.Click
        Me.BindingContext(objdsPayments, "PAYMENTS").Position = (Me.BindingContext(objdsPayments, "PAYMENTS").Position - 1)
        Me.objdsPayments_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavNext.Click
        Me.BindingContext(objdsPayments, "PAYMENTS").Position = (Me.BindingContext(objdsPayments, "PAYMENTS").Position + 1)
        Me.objdsPayments_PositionChanged()

    End Sub
    Private Sub objdsPayments_PositionChanged()
        Me.lblNavLocation.Text = (((Me.BindingContext(objdsPayments, "PAYMENTS").Position + 1).ToString + " of  ") _
                    + Me.BindingContext(objdsPayments, "PAYMENTS").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAll.Click
        Me.objdsPayments.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As sis.dsPayments = New sis.dsPayments()
        'Stop any current edits.
        Me.BindingContext(objdsPayments, "PAYMENTS").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objdsPayments.GetChanges, sis.dsPayments)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                objdsPayments.Merge(objDataSetChanges)
                objdsPayments.AcceptChanges()
            Catch eUpdate As System.Exception
                'Add your error handling code here.
                Throw eUpdate
            End Try
            'Add your code to check the returned dataset for any errors that may have been
            'pushed into the row object's error.
        End If

    End Sub
    Public Sub LoadDataSet()
        'Create a new dataset to hold the records returned from the call to FillDataSet.
        'A temporary dataset is used because filling the existing dataset would
        'require the databindings to be rebound.
        Dim objDataSetTemp As sis.dsPayments
        objDataSetTemp = New sis.dsPayments()
        Try
            'Attempt to fill the temporary dataset.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            objdsPayments.Clear()
            'Merge the records into the main dataset.
            objdsPayments.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As sis.dsPayments)
        Try
            'The data source only needs to be updated if there are changes pending.
            If (Not (ChangedRows) Is Nothing) Then
                'Open the connection.
                Me.OleDbConnection1.Open()
                'Attempt to update the data source.
                OleDbDataAdapter1.Update(ChangedRows)
            End If
        Catch updateException As System.Exception
            'Add your error handling code here.
            Throw updateException
        Finally
            'Close the connection whether or not the exception was thrown.
            Me.OleDbConnection1.Close()
        End Try

    End Sub
    Public Sub FillDataSet(ByVal dataSet As sis.dsPayments)
        'Turn off constraint checking before the dataset is filled.
        'This allows the adapters to fill the dataset without concern
        'for dependencies between the tables.
        dataSet.EnforceConstraints = False
        Try
            'Open the connection.
            Me.OleDbConnection1.Open()
            'Attempt to fill the dataset through the OleDbDataAdapter1.
            Me.OleDbDataAdapter1.Fill(dataSet)
        Catch fillException As System.Exception
            'Add your error handling code here.
            Throw fillException
        Finally
            'Turn constraint checking back on.
            dataSet.EnforceConstraints = True
            'Close the connection whether or not the exception was thrown.
            Me.OleDbConnection1.Close()
        End Try

    End Sub
End Class
