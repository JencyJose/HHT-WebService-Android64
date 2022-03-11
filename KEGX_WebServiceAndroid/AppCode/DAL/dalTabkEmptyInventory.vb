
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Collections.Specialized
Imports System.Configuration
Imports System.Web.UI.WebControls
Namespace TrackITKTS
    Public Class dalTabkEmptyInventory
        Public Shared Function CreateNewTabKEmptyInventory(ByVal objTabKEInventory As clsTabkEmptyInventory, ByVal SchemaName As String) As Integer

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
            db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@OnHandQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.OnHandQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@DamagedQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.DamagedQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@TransitQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEInventory.TransitQuantity)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTabKEmptyInventory")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function
    End Class
End Namespace

