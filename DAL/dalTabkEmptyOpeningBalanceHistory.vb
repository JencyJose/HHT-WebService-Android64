Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Collections.Specialized
Imports System.Configuration
Imports [Property].TrackITKTS
Namespace TrackITKTS
    Public Class dalTabkEmptyOpeningBalanceHistory
        Public Shared Function CreateNewTabkEmptyOpeningBalanceHistory(ByVal objTabKEInventory As PropertyTabkEmptyOpeningBalanceHistory, ByVal SchemaName As String, ByVal AdjustmentReason As String) As Integer

            If objTabKEInventory Is Nothing Then
                Throw New ArgumentNullException("objTabKEInventory")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionID", SqlDbType.NVarChar, 0, ParameterDirection.Input, objTabKEInventory.TransactionID)
            db.AddParamToSQLCmd(sqlCmd, "@InventoryID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.InventoryID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@AdjustmentQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.AdjustmentQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@CreatedDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEInventory.CreatedDate)
            db.AddParamToSQLCmd(sqlCmd, "@CreatedBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.CreatedBy)
            db.AddParamToSQLCmd(sqlCmd, "@ModifiedDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEInventory.ModifiedDate)
            db.AddParamToSQLCmd(sqlCmd, "@ModifiedBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.ModifiedBy)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@EntityType", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.EntityType)
            db.AddParamToSQLCmd(sqlCmd, "@EntityID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.EntityID)
            db.AddParamToSQLCmd(sqlCmd, "@AdjustmentReason", SqlDbType.NVarChar, 0, ParameterDirection.Input, AdjustmentReason)
            'added y suresh
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTabkEmptyOpeningBalanceHistoryNew")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function
        Public Shared Function CreateNewTabkEmptyOpeningBalanceHistoryold(ByVal objTabKEInventory As PropertyTabkEmptyOpeningBalanceHistory, ByVal SchemaName As String) As Integer

            If objTabKEInventory Is Nothing Then
                Throw New ArgumentNullException("objTabKEInventory")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionID", SqlDbType.NVarChar, 0, ParameterDirection.Input, objTabKEInventory.TransactionID)
            db.AddParamToSQLCmd(sqlCmd, "@InventoryID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.InventoryID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@AdjustmentQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.AdjustmentQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@CreatedDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEInventory.CreatedDate)
            db.AddParamToSQLCmd(sqlCmd, "@CreatedBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.CreatedBy)
            db.AddParamToSQLCmd(sqlCmd, "@ModifiedDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEInventory.ModifiedDate)
            db.AddParamToSQLCmd(sqlCmd, "@ModifiedBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.ModifiedBy)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@EntityType", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.EntityType)
            db.AddParamToSQLCmd(sqlCmd, "@EntityID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.EntityID)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTabkEmptyOpeningBalanceHistory")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function
        Public Shared Function GetMaxTransactionNumber_OBHistory(ByVal SchemaName As String, ByVal type As Int32, ByVal CompanyID As Int32, ByVal type1 As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EntityType", type))
            db.Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
            db.Parameters.Add(New SqlParameter("@Type", type1))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetMaxTransactionNumber_OBHistory")
            Return ds
        End Function
        Public Shared Function GetAllTabkEmptyOBHistoryByEntityType(ByVal valCompanyID As Int32, ByVal valEntityID As Int32, ByVal valEntityType As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EntityType", valEntityType))
            db.Parameters.Add(New SqlParameter("@EntityID", valEntityID))
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabkEmptyOBHistoryByEntityType")
            Return ds
        End Function
        Public Shared Function GetAllTabkEmptyOBHistoryByEntityTypeold(ByVal valCompanyID As Int32, ByVal valEntityID As Int32, ByVal valEntityType As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EntityType", valEntityType))
            db.Parameters.Add(New SqlParameter("@EntityID", valEntityID))
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabkEmptyOBHistoryByEntityType")
            Return ds
        End Function
    End Class
End Namespace

