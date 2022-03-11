'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabUOMMaster
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:46:03 PM
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
Imports [Property].TrackITKTS

Namespace TrackITKTS
    Public Class dalTabUOMMaster

        Private ConnectionString As String

        Public Shared Function CreateNewTabUOMMaster(ByVal objTabUOMMaster As PropertyTabUOMMaster) As Integer

            If objTabUOMMaster Is Nothing Then
                Throw New ArgumentNullException("objTabUOMMaster")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@ItemCode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabUOMMaster.ItemCode)
            db.AddParamToSQLCmd(sqlCmd, "@PrimayUOM", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabUOMMaster.PrimayUOM)
            db.AddParamToSQLCmd(sqlCmd, "@RelatedUOM", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabUOMMaster.RelatedUOM)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabUOMMaster.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Factor", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabUOMMaster.Factor)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_CreateNewTabUOMMaster")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function UpdateTabUOMMaster(ByVal objTabUOMMaster As PropertyTabUOMMaster) As Boolean

            If objTabUOMMaster Is Nothing Then
                Throw New ArgumentNullException("objTabUOMMaster")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, objTabUOMMaster.UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemCode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabUOMMaster.ItemCode)
            db.AddParamToSQLCmd(sqlCmd, "@PrimayUOM", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabUOMMaster.PrimayUOM)
            db.AddParamToSQLCmd(sqlCmd, "@RelatedUOM", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabUOMMaster.RelatedUOM)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabUOMMaster.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Factor", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabUOMMaster.Factor)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateTabUOMMaster")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabUOMMaster(ByVal UOMID As Int32) As String

            If UOMID <= 0 Then
                Throw New ArgumentOutOfRangeException("UOMID")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabUOMMaster")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
            If Not String.IsNullOrEmpty(returnValue) Then
                Return returnValue
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetTabUOMMasterByID(ByVal valUOMID As Int32) As PropertyTabUOMMaster
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@UOMID", valUOMID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTabUOMMasterByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabUOMMaster As PropertyTabUOMMaster = New PropertyTabUOMMaster
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("UOMID")) Then
                        objTabUOMMaster.UOMID = dr.GetInt32(dr.GetOrdinal("UOMID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ItemCode")) Then
                        objTabUOMMaster.ItemCode = dr.GetString(dr.GetOrdinal("ItemCode"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("PrimayUOM")) Then
                        objTabUOMMaster.PrimayUOM = dr.GetString(dr.GetOrdinal("PrimayUOM"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("RelatedUOM")) Then
                        objTabUOMMaster.RelatedUOM = dr.GetString(dr.GetOrdinal("RelatedUOM"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ItemID")) Then
                        objTabUOMMaster.ItemID = dr.GetInt32(dr.GetOrdinal("ItemID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Factor")) Then
                        objTabUOMMaster.Factor = dr.GetString(dr.GetOrdinal("Factor"))
                    End If
                End While
                dr.Close()
                Return objTabUOMMaster
            Else
                dr.Close()
                Return New PropertyTabUOMMaster
            End If
        End Function

        Public Shared Function GetALLTabUOMMaster(ByVal valUserName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabUOMMaster")
            Return ds
        End Function

        Public Shared Function GetALLTabUOMMasterDrop() As SqlDataReader
            Dim db As DBAccess = New DBAccess
            Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabUOMMasterDrop")
            Return dr
        End Function

        Public Shared Function GetTabUOMMasterByItemID(ByVal valItemID As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@ItemID", valItemID))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabUOMMasterByItemID")
            Return ds
        End Function
        Public Shared Function GetTabUOMMasterByItemCode(ByVal valItemCode As String, ByVal SchemaName As String, ByVal valCompanyID As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@ItemCode", valItemCode))
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabUOMMasterByItemCode")
            Return ds
        End Function
        Public Shared Function GetTabUOMMasterByEmployeeID(ByVal valEmployeeID As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabUOMMasterByEmployeeID")
            Return ds
        End Function

        Public Shared Function ItemCodeValForTwoCompanies(ByVal valItemCode As String, ByVal valFromCompanyID As Int32, ByVal valToCompanyID As Int32, ByVal SchemaName As String) As Boolean
            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@ItemCode", SqlDbType.NVarChar, 100, ParameterDirection.Input, valItemCode)
            db.AddParamToSQLCmd(sqlCmd, "@FromCompanyID", SqlDbType.Int, 0, ParameterDirection.Input, valFromCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ToCompanyID", SqlDbType.Int, 0, ParameterDirection.Input, valToCompanyID)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_ITEMCODEXISTSFORTWOCOMPANY")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

    End Class
End Namespace
