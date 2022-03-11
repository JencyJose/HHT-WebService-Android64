'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabKSaleOrderBarcode
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:50 PM
'Description        :This file contains data access logic details from database...
'Modified By        :
'Modified Date      :
'***************************************************************

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
	Public Class dalTabKSaleOrderBarcode

		Private ConnectionString As String

        Public Shared Function CreateNewTabKSaleOrderBarcode(ByVal objTabKSaleOrderBarcode As clsTabKSaleOrderBarcode) As Integer

            If objTabKSaleOrderBarcode Is Nothing Then
                Throw New ArgumentNullException("objTabKSaleOrderBarcode")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@SOrderID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrderBarcode.SOrderID)
            db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrderBarcode.CustomerID)
            db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKSaleOrderBarcode.Barcode)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrderBarcode.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrderBarcode.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrderBarcode.UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@PrintedOn", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKSaleOrderBarcode.PrintedOn)
            db.AddParamToSQLCmd(sqlCmd, "@PrintedBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrderBarcode.PrintedBy)
            db.AddParamToSQLCmd(sqlCmd, "@Verified", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKSaleOrderBarcode.Verified)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_CreateNewTabKSaleOrderBarcode")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function UpdateTabKSaleOrderBarcode(ByVal objTabKSaleOrderBarcode As clsTabKSaleOrderBarcode) As Boolean

            If objTabKSaleOrderBarcode Is Nothing Then
                Throw New ArgumentNullException("objTabKSaleOrderBarcode")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@SOrderID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrderBarcode.SOrderID)
            db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrderBarcode.CustomerID)
            db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKSaleOrderBarcode.Barcode)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrderBarcode.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrderBarcode.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrderBarcode.UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@PrintedOn", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKSaleOrderBarcode.PrintedOn)
            db.AddParamToSQLCmd(sqlCmd, "@PrintedBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrderBarcode.PrintedBy)
            db.AddParamToSQLCmd(sqlCmd, "@Verified", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKSaleOrderBarcode.Verified)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateTabKSaleOrderBarcode")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        'Public Shared Function DeleteTabKSaleOrderBarcode(ByVal  As ) As String


        '    Dim db As DBAccess = New DBAccess
        '    Dim sqlCmd As New SqlCommand()
        '    db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
        '    db.AddParamToSQLCmd(sqlCmd, "@", , 0, ParameterDirection.Input, )
        '    db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
        '    db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabKSaleOrderBarcode")
        '    db.ExecuteScalarCmd(sqlCmd)
        '    Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
        '    If Not String.IsNullOrEmpty(returnValue) Then
        '        Return returnValue
        '    Else
        '        Return ""
        '    End If
        'End Function

        'Public Shared Function GetTabKSaleOrderBarcodeByID(ByVal val As ) As clsTabKSaleOrderBarcode
        '    Dim db As DBAccess = New DBAccess
        '    db.Parameters.Add(New SqlParameter("@", val))
        '    Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTabKSaleOrderBarcodeByID"), SqlDataReader)

        '    If dr.HasRows Then
        '        Dim objTabKSaleOrderBarcode As clsTabKSaleOrderBarcode = New clsTabKSaleOrderBarcode
        '        While dr.Read
        '            If Not dr.IsDBNull(dr.GetOrdinal("SOrderID")) Then
        '                objTabKSaleOrderBarcode.SOrderID = dr.GetInt32(dr.GetOrdinal("SOrderID"))
        '            End If
        '            If Not dr.IsDBNull(dr.GetOrdinal("CustomerID")) Then
        '                objTabKSaleOrderBarcode.CustomerID = dr.GetInt32(dr.GetOrdinal("CustomerID"))
        '            End If
        '            If Not dr.IsDBNull(dr.GetOrdinal("Barcode")) Then
        '                objTabKSaleOrderBarcode.Barcode = dr.GetString(dr.GetOrdinal("Barcode"))
        '            End If
        '            If Not dr.IsDBNull(dr.GetOrdinal("ItemID")) Then
        '                objTabKSaleOrderBarcode.ItemID = dr.GetInt32(dr.GetOrdinal("ItemID"))
        '            End If
        '            If Not dr.IsDBNull(dr.GetOrdinal("Quantity")) Then
        '                objTabKSaleOrderBarcode.Quantity = dr.GetInt32(dr.GetOrdinal("Quantity"))
        '            End If
        '            If Not dr.IsDBNull(dr.GetOrdinal("UOMID")) Then
        '                objTabKSaleOrderBarcode.UOMID = dr.GetInt32(dr.GetOrdinal("UOMID"))
        '            End If
        '            If Not dr.IsDBNull(dr.GetOrdinal("PrintedOn")) Then
        '                objTabKSaleOrderBarcode.PrintedOn = dr.GetDateTime(dr.GetOrdinal("PrintedOn"))
        '            End If
        '            If Not dr.IsDBNull(dr.GetOrdinal("PrintedBy")) Then
        '                objTabKSaleOrderBarcode.PrintedBy = dr.GetInt32(dr.GetOrdinal("PrintedBy"))
        '            End If
        '            If Not dr.IsDBNull(dr.GetOrdinal("Verified")) Then
        '                objTabKSaleOrderBarcode.Verified = dr.GetBoolean(dr.GetOrdinal("Verified"))
        '            End If
        '        End While
        '        dr.Close()
        '        Return objTabKSaleOrderBarcode
        '    Else
        '        dr.Close()
        '        Return New clsTabKSaleOrderBarcode
        '    End If
        'End Function

        Public Shared Function GetALLTabKSaleOrderBarcode(ByVal valUserName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKSaleOrderBarcode")
            Return ds
        End Function

        Public Shared Function GetALLTabKSaleOrderBarcodeDrop() As SqlDataReader
            Dim db As DBAccess = New DBAccess
            Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabKSaleOrderBarcodeDrop")
            Return dr
        End Function

        Public Shared Function GetTabKSaleOrderBarcodeBySOrderID(ByVal valSOrderID As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@SOrderID", valSOrderID))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKSaleOrderBarcodeBySOrderID")
            Return ds
        End Function
        Public Shared Function GetAllTabKSaleOrderBarcodeByEmployeeID(ByVal valEmployeeID As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKSaleOrderBarcodeByEmployeeID")
            Return ds
        End Function
	End Class
End Namespace
