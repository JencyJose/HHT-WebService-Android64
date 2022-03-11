'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTABMenu
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:57 PM
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
	Public Class dalTABMenu

		Private ConnectionString As String

		Public Shared Function CreateNewTABMenu(ByVal objTABMenu As clsTABMenu) As Integer

			If objTABMenu Is Nothing Then
				Throw New ArgumentNullException("objTABMenu")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As SqlCommand = New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@Feature_en", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTABMenu.Feature_en)
			db.AddParamToSQLCmd(sqlCmd, "@Feature_ar", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTABMenu.Feature_ar)
			db.AddParamToSQLCmd(sqlCmd, "@Description", SqlDbType.NVarChar, 255, ParameterDirection.Input, objTABMenu.Description)
			db.AddParamToSQLCmd(sqlCmd, "@ParentID", SqlDbType.Int, 0, ParameterDirection.Input, objTABMenu.ParentID)
			db.AddParamToSQLCmd(sqlCmd, "@NavigateURL", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTABMenu.NavigateURL)
			db.AddParamToSQLCmd(sqlCmd, "@FeatureType", SqlDbType.Char, 10, ParameterDirection.Input, objTABMenu.FeatureType)
            db.AddParamToSQLCmd(sqlCmd, "@Imp_View", SqlDbType.Bit, 0, ParameterDirection.Input, objTABMenu.Imp_View)
            db.AddParamToSQLCmd(sqlCmd, "@Imp_New", SqlDbType.Bit, 0, ParameterDirection.Input, objTABMenu.Imp_New)
            db.AddParamToSQLCmd(sqlCmd, "@Imp_Edit", SqlDbType.Bit, 0, ParameterDirection.Input, objTABMenu.Imp_Edit)
			db.AddParamToSQLCmd(sqlCmd, "@Imp_Delete", SqlDbType.bit, 0, ParameterDirection.Input, objTABMenu.Imp_Delete)

			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_CreateNewTABMenu")
			db.ExecuteScalarCmd(sqlCmd)
			Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
		End Function

		Public Shared Function UpdateTABMenu(ByVal objTABMenu As clsTABMenu) As Boolean

			If objTABMenu Is Nothing Then
				Throw New ArgumentNullException("objTABMenu")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As SqlCommand = New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@MenuID", SqlDbType.Int, 0, ParameterDirection.Input, objTABMenu.MenuID)
			db.AddParamToSQLCmd(sqlCmd, "@Feature_en", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTABMenu.Feature_en)
			db.AddParamToSQLCmd(sqlCmd, "@Feature_ar", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTABMenu.Feature_ar)
			db.AddParamToSQLCmd(sqlCmd, "@Description", SqlDbType.NVarChar, 255, ParameterDirection.Input, objTABMenu.Description)
			db.AddParamToSQLCmd(sqlCmd, "@ParentID", SqlDbType.Int, 0, ParameterDirection.Input, objTABMenu.ParentID)
			db.AddParamToSQLCmd(sqlCmd, "@NavigateURL", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTABMenu.NavigateURL)
			db.AddParamToSQLCmd(sqlCmd, "@FeatureType", SqlDbType.Char, 10, ParameterDirection.Input, objTABMenu.FeatureType)
			db.AddParamToSQLCmd(sqlCmd, "@Imp_View", SqlDbType.bit, 0, ParameterDirection.Input, objTABMenu.Imp_View)
			db.AddParamToSQLCmd(sqlCmd, "@Imp_New", SqlDbType.bit, 0, ParameterDirection.Input, objTABMenu.Imp_New)
			db.AddParamToSQLCmd(sqlCmd, "@Imp_Edit", SqlDbType.bit, 0, ParameterDirection.Input, objTABMenu.Imp_Edit)
			db.AddParamToSQLCmd(sqlCmd, "@Imp_Delete", SqlDbType.bit, 0, ParameterDirection.Input, objTABMenu.Imp_Delete)

			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateTABMenu")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
			If returnValue = 0 Then
				Return True
			Else
				Return False
			End If
		End Function

		Public Shared Function DeleteTABMenu(ByVal MenuID As Int32) As String

			If MenuID<= 0 Then
				Throw New ArgumentOutOfRangeException("MenuID")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@MenuID", SqlDbType.Int, 0, ParameterDirection.Input, MenuID)
			db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTABMenu")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
			If Not String.IsNullOrEmpty(returnValue) Then
				Return returnValue
			Else
				Return ""
			End If
		End Function

		Public Shared Function GetTABMenuByID(ByVal valMenuID As Int32) As clsTABMenu
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@MenuID", valMenuID))
			Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTABMenuByID"), SqlDataReader)

			If dr.HasRows Then
				Dim objTABMenu As clsTABMenu = New clsTABMenu
				While dr.Read
					If Not dr.IsDBNull(dr.GetOrdinal("MenuID")) Then
						objTABMenu.MenuID = dr.GetInt32(dr.GetOrdinal("MenuID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("Feature_en")) Then
						objTABMenu.Feature_en = dr.GetString(dr.GetOrdinal("Feature_en"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("Feature_ar")) Then
						objTABMenu.Feature_ar = dr.GetString(dr.GetOrdinal("Feature_ar"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("Description")) Then
						objTABMenu.Description = dr.GetString(dr.GetOrdinal("Description"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("ParentID")) Then
						objTABMenu.ParentID = dr.GetInt32(dr.GetOrdinal("ParentID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("NavigateURL")) Then
						objTABMenu.NavigateURL = dr.GetString(dr.GetOrdinal("NavigateURL"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("FeatureType")) Then
                        objTABMenu.FeatureType = dr.GetString(dr.GetOrdinal("FeatureType"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("Imp_View")) Then
                        objTABMenu.Imp_View = dr.GetBoolean(dr.GetOrdinal("Imp_View"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("Imp_New")) Then
                        objTABMenu.Imp_New = dr.GetBoolean(dr.GetOrdinal("Imp_New"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("Imp_Edit")) Then
                        objTABMenu.Imp_Edit = dr.GetBoolean(dr.GetOrdinal("Imp_Edit"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("Imp_Delete")) Then
                        objTABMenu.Imp_Delete = dr.GetBoolean(dr.GetOrdinal("Imp_Delete"))
					End If
				End While
				dr.Close()
				Return objTABMenu
			Else
				dr.Close()
				Return New clsTABMenu
			End If
		End Function

		Public Shared Function GetALLTABMenu(ByVal valUserName As String) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTABMenu")
			Return ds
		End Function

		Public Shared Function GetALLTABMenuDrop() As SqlDataReader
			Dim db As DBAccess = New DBAccess
			Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTABMenuDrop")
			Return dr
		End Function

	End Class
End Namespace
