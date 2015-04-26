﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.0.3705.0
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class dsDatePayments
    Inherits DataSet
    
    Private tablePAYMENTS As PAYMENTSDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("PAYMENTS")) Is Nothing) Then
                Me.Tables.Add(New PAYMENTSDataTable(ds.Tables("PAYMENTS")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property PAYMENTS As PAYMENTSDataTable
        Get
            Return Me.tablePAYMENTS
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsDatePayments = CType(MyBase.Clone,dsDatePayments)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("PAYMENTS")) Is Nothing) Then
            Me.Tables.Add(New PAYMENTSDataTable(ds.Tables("PAYMENTS")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tablePAYMENTS = CType(Me.Tables("PAYMENTS"),PAYMENTSDataTable)
        If (Not (Me.tablePAYMENTS) Is Nothing) Then
            Me.tablePAYMENTS.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsDatePayments"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dsDatePayments.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablePAYMENTS = New PAYMENTSDataTable
        Me.Tables.Add(Me.tablePAYMENTS)
    End Sub
    
    Private Function ShouldSerializePAYMENTS() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub PAYMENTSRowChangeEventHandler(ByVal sender As Object, ByVal e As PAYMENTSRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class PAYMENTSDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnRCPTNO As DataColumn
        
        Private columnBCODE As DataColumn
        
        Private columnROLLNO As DataColumn
        
        Private columnSNAME As DataColumn
        
        Private columnAMT As DataColumn
        
        Private columnDP As DataColumn
        
        Private columnEXPR1 As DataColumn
        
        Private columnEXPR2 As DataColumn
        
        Friend Sub New()
            MyBase.New("PAYMENTS")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property RCPTNOColumn As DataColumn
            Get
                Return Me.columnRCPTNO
            End Get
        End Property
        
        Friend ReadOnly Property BCODEColumn As DataColumn
            Get
                Return Me.columnBCODE
            End Get
        End Property
        
        Friend ReadOnly Property ROLLNOColumn As DataColumn
            Get
                Return Me.columnROLLNO
            End Get
        End Property
        
        Friend ReadOnly Property SNAMEColumn As DataColumn
            Get
                Return Me.columnSNAME
            End Get
        End Property
        
        Friend ReadOnly Property AMTColumn As DataColumn
            Get
                Return Me.columnAMT
            End Get
        End Property
        
        Friend ReadOnly Property DPColumn As DataColumn
            Get
                Return Me.columnDP
            End Get
        End Property
        
        Friend ReadOnly Property EXPR1Column As DataColumn
            Get
                Return Me.columnEXPR1
            End Get
        End Property
        
        Friend ReadOnly Property EXPR2Column As DataColumn
            Get
                Return Me.columnEXPR2
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As PAYMENTSRow
            Get
                Return CType(Me.Rows(index),PAYMENTSRow)
            End Get
        End Property
        
        Public Event PAYMENTSRowChanged As PAYMENTSRowChangeEventHandler
        
        Public Event PAYMENTSRowChanging As PAYMENTSRowChangeEventHandler
        
        Public Event PAYMENTSRowDeleted As PAYMENTSRowChangeEventHandler
        
        Public Event PAYMENTSRowDeleting As PAYMENTSRowChangeEventHandler
        
        Public Overloads Sub AddPAYMENTSRow(ByVal row As PAYMENTSRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddPAYMENTSRow(ByVal RCPTNO As Decimal, ByVal BCODE As String, ByVal ROLLNO As Decimal, ByVal SNAME As String, ByVal AMT As Decimal, ByVal DP As Date, ByVal EXPR1 As String, ByVal EXPR2 As Decimal) As PAYMENTSRow
            Dim rowPAYMENTSRow As PAYMENTSRow = CType(Me.NewRow,PAYMENTSRow)
            rowPAYMENTSRow.ItemArray = New Object() {RCPTNO, BCODE, ROLLNO, SNAME, AMT, DP, EXPR1, EXPR2}
            Me.Rows.Add(rowPAYMENTSRow)
            Return rowPAYMENTSRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As PAYMENTSDataTable = CType(MyBase.Clone,PAYMENTSDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New PAYMENTSDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnRCPTNO = Me.Columns("RCPTNO")
            Me.columnBCODE = Me.Columns("BCODE")
            Me.columnROLLNO = Me.Columns("ROLLNO")
            Me.columnSNAME = Me.Columns("SNAME")
            Me.columnAMT = Me.Columns("AMT")
            Me.columnDP = Me.Columns("DP")
            Me.columnEXPR1 = Me.Columns("EXPR1")
            Me.columnEXPR2 = Me.Columns("EXPR2")
        End Sub
        
        Private Sub InitClass()
            Me.columnRCPTNO = New DataColumn("RCPTNO", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRCPTNO)
            Me.columnBCODE = New DataColumn("BCODE", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnBCODE)
            Me.columnROLLNO = New DataColumn("ROLLNO", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnROLLNO)
            Me.columnSNAME = New DataColumn("SNAME", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSNAME)
            Me.columnAMT = New DataColumn("AMT", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAMT)
            Me.columnDP = New DataColumn("DP", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDP)
            Me.columnEXPR1 = New DataColumn("EXPR1", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnEXPR1)
            Me.columnEXPR2 = New DataColumn("EXPR2", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnEXPR2)
            Me.columnRCPTNO.AllowDBNull = false
            Me.columnEXPR1.AllowDBNull = false
            Me.columnEXPR2.AllowDBNull = false
        End Sub
        
        Public Function NewPAYMENTSRow() As PAYMENTSRow
            Return CType(Me.NewRow,PAYMENTSRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New PAYMENTSRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(PAYMENTSRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.PAYMENTSRowChangedEvent) Is Nothing) Then
                RaiseEvent PAYMENTSRowChanged(Me, New PAYMENTSRowChangeEvent(CType(e.Row,PAYMENTSRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.PAYMENTSRowChangingEvent) Is Nothing) Then
                RaiseEvent PAYMENTSRowChanging(Me, New PAYMENTSRowChangeEvent(CType(e.Row,PAYMENTSRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.PAYMENTSRowDeletedEvent) Is Nothing) Then
                RaiseEvent PAYMENTSRowDeleted(Me, New PAYMENTSRowChangeEvent(CType(e.Row,PAYMENTSRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.PAYMENTSRowDeletingEvent) Is Nothing) Then
                RaiseEvent PAYMENTSRowDeleting(Me, New PAYMENTSRowChangeEvent(CType(e.Row,PAYMENTSRow), e.Action))
            End If
        End Sub
        
        Public Sub RemovePAYMENTSRow(ByVal row As PAYMENTSRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class PAYMENTSRow
        Inherits DataRow
        
        Private tablePAYMENTS As PAYMENTSDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablePAYMENTS = CType(Me.Table,PAYMENTSDataTable)
        End Sub
        
        Public Property RCPTNO As Decimal
            Get
                Return CType(Me(Me.tablePAYMENTS.RCPTNOColumn),Decimal)
            End Get
            Set
                Me(Me.tablePAYMENTS.RCPTNOColumn) = value
            End Set
        End Property
        
        Public Property BCODE As String
            Get
                Try 
                    Return CType(Me(Me.tablePAYMENTS.BCODEColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePAYMENTS.BCODEColumn) = value
            End Set
        End Property
        
        Public Property ROLLNO As Decimal
            Get
                Try 
                    Return CType(Me(Me.tablePAYMENTS.ROLLNOColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePAYMENTS.ROLLNOColumn) = value
            End Set
        End Property
        
        Public Property SNAME As String
            Get
                Try 
                    Return CType(Me(Me.tablePAYMENTS.SNAMEColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePAYMENTS.SNAMEColumn) = value
            End Set
        End Property
        
        Public Property AMT As Decimal
            Get
                Try 
                    Return CType(Me(Me.tablePAYMENTS.AMTColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePAYMENTS.AMTColumn) = value
            End Set
        End Property
        
        Public Property DP As Date
            Get
                Try 
                    Return CType(Me(Me.tablePAYMENTS.DPColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePAYMENTS.DPColumn) = value
            End Set
        End Property
        
        Public Property EXPR1 As String
            Get
                Return CType(Me(Me.tablePAYMENTS.EXPR1Column),String)
            End Get
            Set
                Me(Me.tablePAYMENTS.EXPR1Column) = value
            End Set
        End Property
        
        Public Property EXPR2 As Decimal
            Get
                Return CType(Me(Me.tablePAYMENTS.EXPR2Column),Decimal)
            End Get
            Set
                Me(Me.tablePAYMENTS.EXPR2Column) = value
            End Set
        End Property
        
        Public Function IsBCODENull() As Boolean
            Return Me.IsNull(Me.tablePAYMENTS.BCODEColumn)
        End Function
        
        Public Sub SetBCODENull()
            Me(Me.tablePAYMENTS.BCODEColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsROLLNONull() As Boolean
            Return Me.IsNull(Me.tablePAYMENTS.ROLLNOColumn)
        End Function
        
        Public Sub SetROLLNONull()
            Me(Me.tablePAYMENTS.ROLLNOColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSNAMENull() As Boolean
            Return Me.IsNull(Me.tablePAYMENTS.SNAMEColumn)
        End Function
        
        Public Sub SetSNAMENull()
            Me(Me.tablePAYMENTS.SNAMEColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsAMTNull() As Boolean
            Return Me.IsNull(Me.tablePAYMENTS.AMTColumn)
        End Function
        
        Public Sub SetAMTNull()
            Me(Me.tablePAYMENTS.AMTColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDPNull() As Boolean
            Return Me.IsNull(Me.tablePAYMENTS.DPColumn)
        End Function
        
        Public Sub SetDPNull()
            Me(Me.tablePAYMENTS.DPColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class PAYMENTSRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As PAYMENTSRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As PAYMENTSRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As PAYMENTSRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
