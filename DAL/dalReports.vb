Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Collections.Specialized
Imports System.Configuration

Namespace TrackITKTS

    Public Class dalReports
        Private ConnectionString As String

        Public Shared Function REPCustomerSOA(ByVal valCompanyID As Int32, ByVal valFromDate As DateTime, ByVal valToDate As DateTime, ByVal valCustCode As String, valItemIDs As String, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@FromDate", valFromDate))
            db.Parameters.Add(New SqlParameter("@ToDate", valToDate))
            db.Parameters.Add(New SqlParameter("@MultipleCustomerIDs", valCustCode))
            db.Parameters.Add(New SqlParameter("@MultipleItemIDs", valItemIDs))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".REPCustomerSOA")
            Return ds
        End Function
        Public Shared Function REPCustomerSummary(ByVal valChannelName As String, ByVal valFromDate As DateTime, ByVal valToDate As DateTime, valItemIDs As String, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@ChannelName", valChannelName))
            db.Parameters.Add(New SqlParameter("@FromDate", valFromDate))
            db.Parameters.Add(New SqlParameter("@ToDate", valToDate))
            db.Parameters.Add(New SqlParameter("@MultipleItemIDs", valItemIDs))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".REPCustomerSummary")
            Return ds
        End Function
        Public Shared Function REPCustomerReconciliation(ByVal valCompanyID As Int32, ByVal valFromDate As DateTime, ByVal valToDate As DateTime, ByVal valCustCode As String, valItemIDs As String, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@FromDate", valFromDate))
            db.Parameters.Add(New SqlParameter("@ToDate", valToDate))
            db.Parameters.Add(New SqlParameter("@MultipleCustomerIDs", valCustCode))
            db.Parameters.Add(New SqlParameter("@MultipleItemIDs", valItemIDs))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".REPCustomerReconciliation")
            Return ds
        End Function
        Public Shared Function REPDiscrepancyTimeDelay(ByVal valCompanyID As Int32, ByVal valCustCode As String, valItemIDs As String, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@CustomerID", valCustCode))
            db.Parameters.Add(New SqlParameter("@MultipleItemIDs", valItemIDs))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".REPDiscrepancyTimeDelay")
            Return ds
        End Function
        Public Shared Function REPTotalKegEmpties(ByVal valCompanyID As Int32, valItemIDs As String, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@MultipleItemIDs", valItemIDs))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".REPEmptiesinyard")
            Return ds
        End Function
        Public Shared Function REPTotalKegPopulation(ByVal valCompanyID As Int32, valItemIDs As String, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@MultipleItemIDs", valItemIDs))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".REPTotalKegPopulation")
            Return ds
        End Function
        Public Shared Function REPSupplierSOA(ByVal valCompanyID As Int32, ByVal valFromDate As DateTime, ByVal valToDate As DateTime, ByVal valSuppCode As String, valItemIDs As String, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@FromDate", valFromDate))
            db.Parameters.Add(New SqlParameter("@ToDate", valToDate))
            db.Parameters.Add(New SqlParameter("@MultipleSupplierIDs", valSuppCode))
            db.Parameters.Add(New SqlParameter("@MultipleItemIDs", valItemIDs))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".REPSupplierSOA")
            Return ds
        End Function
        Public Shared Function REPSupplierReconciliation(ByVal valCompanyID As Int32, ByVal valFromDate As DateTime, ByVal valToDate As DateTime, ByVal valSuppCode As String, valItemIDs As String, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@FromDate", valFromDate))
            db.Parameters.Add(New SqlParameter("@ToDate", valToDate))
            db.Parameters.Add(New SqlParameter("@MultipleSupplierIDs", valSuppCode))
            db.Parameters.Add(New SqlParameter("@MultipleItemIDs", valItemIDs))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".REPSupplierReconciliation")
            Return ds
        End Function
        Public Shared Function REPSupplierSummary(ByVal valCompanyID As Int32, ByVal valFromDate As DateTime, ByVal valToDate As DateTime, valItemIDs As String, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@FromDate", valFromDate))
            db.Parameters.Add(New SqlParameter("@ToDate", valToDate))
            db.Parameters.Add(New SqlParameter("@MultipleItemIDs", valItemIDs))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".REPSupplierSummary")
            Return ds
        End Function
        Public Shared Function REPDiscrepancy(ByVal valChannelName As String, ByVal valFromDate As DateTime, ByVal valToDate As DateTime, valItemIDs As String, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@ChannelName", valChannelName))
            db.Parameters.Add(New SqlParameter("@FromDate", valFromDate))
            db.Parameters.Add(New SqlParameter("@ToDate", valToDate))
            db.Parameters.Add(New SqlParameter("@MultipleItemIDs", valItemIDs))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".REPDiscrepancy")
            Return ds
        End Function
        Public Shared Function REPDiscrepancy1(ByVal ChannelName As String, ByVal FromDate As DateTime, ByVal ToDate As DateTime, ByVal valCustCode As String, strItemIDs As String, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@ChannelName", ChannelName))
            db.Parameters.Add(New SqlParameter("@FromDate", FromDate))
            db.Parameters.Add(New SqlParameter("@ToDate", ToDate))
            db.Parameters.Add(New SqlParameter("@MultipleCustomerIDs", valCustCode))
            db.Parameters.Add(New SqlParameter("@MultipleItemIDs", strItemIDs))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".REPDiscrepancy1")
            Return ds
        End Function

        Public Shared Function REPBPReconciliation(ByVal valCompanyID As Int32, ByVal valBPCode As String, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@BPCode", valBPCode))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".REPBPReconciliation")
            Return ds
        End Function

        Public Shared Function REPCustomerEmptyKegCollection(ByVal valFromDate As DateTime, ByVal valToDate As DateTime, ByVal UserID As Int32, valItemIDs As String, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@FromDate", valFromDate))
            db.Parameters.Add(New SqlParameter("@ToDate", valToDate))
            db.Parameters.Add(New SqlParameter("@UserID", UserID))
            db.Parameters.Add(New SqlParameter("@MultipleItemCodes", valItemIDs))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".REPCustomerKegReturnHHT")
            Return ds
        End Function

    End Class
End Namespace
