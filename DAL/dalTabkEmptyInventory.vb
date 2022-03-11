
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
    Public Class dalTabkEmptyInventory
        Public Shared Function CreateNewTabKEmptyInventory(ByVal objTabKEInventory As PropertyTabkEmptyInventory, ByVal SchemaName As String, ByVal AdjustementQty As Int32) As Integer

            If objTabKEInventory Is Nothing Then
                Throw New ArgumentNullException("objTabKEInventory")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@EntityID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.EntityID)
            db.AddParamToSQLCmd(sqlCmd, "@EntityTypeID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.EntityTypeID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@OnHandQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.OnHandQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@DamagedQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.DamagedQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@TransitQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.TransitQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@AdjustmentQuantity", SqlDbType.Int, 0, ParameterDirection.Input, AdjustementQty)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTabKEmptyInventory")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function
        Public Shared Function GetAllTabKEmptyInventoryLatestOB(ByVal valCompanyID As Int32, ByVal valEntityID As Int32, ByVal valEntityType As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@EntityID", valEntityID))
            db.Parameters.Add(New SqlParameter("@EntityType", valEntityType))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKEmptyInventoryLatestOB")
            Return ds
        End Function
        Public Shared Function CheckEmptyOpeningBalExist(ByVal valCompanyID As Int32, ByVal valEntityID As Int32, ByVal valEntityType As Int32, ByVal valItemID As Int32, ByVal SchemaName As String) As Integer

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, valCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@EntityID", SqlDbType.Int, 0, ParameterDirection.Input, valEntityID)
            db.AddParamToSQLCmd(sqlCmd, "@EntityTypeID", SqlDbType.Int, 0, ParameterDirection.Input, valEntityType)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, valItemID)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CheckEmptyOpeningBalExist")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function CheckAndGetEmptyOpeningBal(ByVal valCompanyID As Int32, ByVal valEntityID As Int32, ByVal valEntityType As Int32, ByVal valItemID As Int32, ByVal SchemaName As String) As String

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@Qty", SqlDbType.NVarChar, 100, ParameterDirection.Output, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, valCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@EntityID", SqlDbType.Int, 0, ParameterDirection.Input, valEntityID)
            db.AddParamToSQLCmd(sqlCmd, "@EntityTypeID", SqlDbType.Int, 0, ParameterDirection.Input, valEntityType)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, valItemID)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CheckAndGetEmptyOpeningBal")
            db.ExecuteScalarCmd(sqlCmd)

            Return sqlCmd.Parameters("@Qty").Value.ToString
        End Function

        Public Shared Function CheckAndGetEmptyOpeningBalInTransit(ByVal valCompanyID As Int32, ByVal valEntityID As Int32, ByVal valEntityType As Int32, ByVal valItemID As Int32, ByVal SchemaName As String) As Integer

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, valCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@EntityID", SqlDbType.Int, 0, ParameterDirection.Input, valEntityID)
            db.AddParamToSQLCmd(sqlCmd, "@EntityTypeID", SqlDbType.Int, 0, ParameterDirection.Input, valEntityType)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, valItemID)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CheckAndGetEmptyOpeningBalInTransit")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function GetAllTabKEmptyInventoryHHT(ByVal valEmployeeID As Integer, ByVal SchemaName As String)
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKEmptyInventoryHHT")
            Return ds
        End Function
        Public Shared Function GetAllTabKEmptyInventoryLatestOBNyItemID(ByVal valCompanyID As Int32, ByVal valEntityID As Int32, ByVal valEntityType As Int32, ByVal valItemID As Integer, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@EntityID", valEntityID))
            db.Parameters.Add(New SqlParameter("@EntityType", valEntityType))
            db.Parameters.Add(New SqlParameter("@ItemID", valItemID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKEmptyInventoryLatestOBByItemID")
            Return ds
        End Function
    End Class
End Namespace

