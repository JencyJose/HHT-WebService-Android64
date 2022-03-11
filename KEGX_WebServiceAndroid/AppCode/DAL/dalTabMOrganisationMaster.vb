'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabMOrganizationMaster
'Created By         :
'File navigation    :
'Created Date       :January 17, 2014, 2:08:31 PM
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
    Public Class dalTabMOrganisationMaster
        Private ConnectionString As String

        Public Shared Function CreateNewTabMOrganization(ByVal objTabMOrganizationMaster As clsTabMOrganisationMaster, ByVal SchemaName As String) As Integer

            If objTabMOrganizationMaster Is Nothing Then
                Throw New ArgumentNullException("objTabMOrganizationMaster")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@OrganizationCode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganizationMaster.OrganizationCode)
            db.AddParamToSQLCmd(sqlCmd, "@OrganizationName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMOrganizationMaster.OrganizationName)
            db.AddParamToSQLCmd(sqlCmd, "@Address1", SqlDbType.NVarChar, 500, ParameterDirection.Input, objTabMOrganizationMaster.Address1)
            db.AddParamToSQLCmd(sqlCmd, "@Address2", SqlDbType.NVarChar, 500, ParameterDirection.Input, objTabMOrganizationMaster.Address2)
            db.AddParamToSQLCmd(sqlCmd, "@City", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganizationMaster.City)
            db.AddParamToSQLCmd(sqlCmd, "@State", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganizationMaster.State)
            db.AddParamToSQLCmd(sqlCmd, "@Phone", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganizationMaster.Phone)
            db.AddParamToSQLCmd(sqlCmd, "@Country", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganizationMaster.Country)
            db.AddParamToSQLCmd(sqlCmd, "@Email", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganizationMaster.Email)
            db.AddParamToSQLCmd(sqlCmd, "@OrganizationImage", SqlDbType.Image, 0, ParameterDirection.Input, objTabMOrganizationMaster.OrganizationImage)
            db.AddParamToSQLCmd(sqlCmd, "@Thumbnail", SqlDbType.Image, 0, ParameterDirection.Input, objTabMOrganizationMaster.Thumbnail)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTabMOrganizationMaster")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function UpdateTabMOrganization(ByVal objTabMOrganizationMaster As clsTabMOrganisationMaster, ByVal SchemaName As String) As Boolean

            If objTabMOrganizationMaster Is Nothing Then
                Throw New ArgumentNullException("objTabMOrganizationMaster")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@OrganizationID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMOrganizationMaster.OrganizationID)
            db.AddParamToSQLCmd(sqlCmd, "@OrganizationCode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganizationMaster.OrganizationCode)
            db.AddParamToSQLCmd(sqlCmd, "@OrganizationName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMOrganizationMaster.OrganizationName)
            db.AddParamToSQLCmd(sqlCmd, "@Address1", SqlDbType.NVarChar, 500, ParameterDirection.Input, objTabMOrganizationMaster.Address1)
            db.AddParamToSQLCmd(sqlCmd, "@Address2", SqlDbType.NVarChar, 500, ParameterDirection.Input, objTabMOrganizationMaster.Address2)
            db.AddParamToSQLCmd(sqlCmd, "@City", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganizationMaster.City)
            db.AddParamToSQLCmd(sqlCmd, "@State", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganizationMaster.State)
            db.AddParamToSQLCmd(sqlCmd, "@Phone", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganizationMaster.Phone)
            db.AddParamToSQLCmd(sqlCmd, "@Country", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganizationMaster.Country)
            db.AddParamToSQLCmd(sqlCmd, "@Email", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganizationMaster.Email)
            db.AddParamToSQLCmd(sqlCmd, "@OrganizationImage", SqlDbType.Image, 0, ParameterDirection.Input, objTabMOrganizationMaster.OrganizationImage)
            db.AddParamToSQLCmd(sqlCmd, "@Thumbnail", SqlDbType.Image, 0, ParameterDirection.Input, objTabMOrganizationMaster.Thumbnail)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_UpdateTabMOrganizationMaster")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabMOrganization(ByVal OrganizationID As Int32) As String

            If OrganizationID <= 0 Then
                Throw New ArgumentOutOfRangeException("OrganizationID")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@OrganizationID", SqlDbType.Int, 0, ParameterDirection.Input, OrganizationID)
            db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabMOrganizationMaster")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
            If Not String.IsNullOrEmpty(returnValue) Then
                Return returnValue
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetTabMOrganizationMasterByID(ByVal valOrganizationID As Int32, ByVal SchemaName As String) As clsTabMOrganisationMaster
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@OrganizationID", valOrganizationID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader(SchemaName + ".TIT_GetTabMOrganizationMasterByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabMOrganizationMaster As clsTabMOrganisationMaster = New clsTabMOrganisationMaster
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("OrganizationID")) Then
                        objTabMOrganizationMaster.OrganizationID = dr.GetInt32(dr.GetOrdinal("OrganizationID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("OrganizationCode")) Then
                        objTabMOrganizationMaster.OrganizationCode = dr.GetString(dr.GetOrdinal("OrganizationCode"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("OrganizationName")) Then
                        objTabMOrganizationMaster.OrganizationName = dr.GetString(dr.GetOrdinal("OrganizationName"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address1")) Then
                        objTabMOrganizationMaster.Address1 = dr.GetString(dr.GetOrdinal("Address1"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address2")) Then
                        objTabMOrganizationMaster.Address2 = dr.GetString(dr.GetOrdinal("Address2"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("City")) Then
                        objTabMOrganizationMaster.City = dr.GetString(dr.GetOrdinal("City"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("State")) Then
                        objTabMOrganizationMaster.State = dr.GetString(dr.GetOrdinal("State"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Phone")) Then
                        objTabMOrganizationMaster.Phone = dr.GetString(dr.GetOrdinal("Phone"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Country")) Then
                        objTabMOrganizationMaster.Country = dr.GetString(dr.GetOrdinal("Country"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Email")) Then
                        objTabMOrganizationMaster.Email = dr.GetString(dr.GetOrdinal("Email"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("OrganizationImage")) Then
                        'Dim byteArr As [Byte]() = New [Byte](dr.GetSqlBytes(14).Length) {}
                        'Dim i As Integer = dr.GetSqlBytes(14).Read(byteArr, 0, System.Convert.ToInt32(dr.GetSqlBytes(14).Length))
                        objTabMOrganizationMaster.OrganizationImage = CType(dr.Item("OrganizationImage"), Byte())
                    End If
                    'objTabMOrganizationMaster.OrganizationImage = CType(dr.Item("OrganizationImage"), Byte())
                    'objTabMOrganizationMaster.Thumbnail = CType(dr.Item("Thumbnail"), Byte())
                End While
                dr.Close()
                Return objTabMOrganizationMaster
            Else
                dr.Close()
                Return New clsTabMOrganisationMaster
            End If
        End Function

        Public Shared Function GetAllTabMOrganizationMaster(ByVal valUserName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabMOrganizationMaster")
            Return ds
        End Function

        Public Shared Function GetAllTabMOrganizationMasterDrop() As SqlDataReader
            Dim db As DBAccess = New DBAccess
            Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabMOrganizationMasterDrop")
            Return dr
        End Function
        Public Shared Function GetAllTabMOrganizationMasterByEmployeeID(ByVal valEmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabMOrganizationMasterByEmployeeID")
            Return ds
        End Function

        Public Shared Function GetTabMOrganizationMasterByOrgCode(ByVal valOrganizationCode As String, ByVal SchemaName As String) As clsTabMOrganisationMaster
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@OrganizationCode", valOrganizationCode))
            Dim dr As SqlDataReader = CType(db.ExecuteReader(SchemaName + ".TIT_GetTabMOrganizationMasterByOrgCode"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabMOrganizationMaster As clsTabMOrganisationMaster = New clsTabMOrganisationMaster
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("OrganizationID")) Then
                        objTabMOrganizationMaster.OrganizationID = dr.GetInt32(dr.GetOrdinal("OrganizationID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("OrganizationCode")) Then
                        objTabMOrganizationMaster.OrganizationCode = dr.GetString(dr.GetOrdinal("OrganizationCode"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("OrganizationName")) Then
                        objTabMOrganizationMaster.OrganizationName = dr.GetString(dr.GetOrdinal("OrganizationName"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address1")) Then
                        objTabMOrganizationMaster.Address1 = dr.GetString(dr.GetOrdinal("Address1"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address2")) Then
                        objTabMOrganizationMaster.Address2 = dr.GetString(dr.GetOrdinal("Address2"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("City")) Then
                        objTabMOrganizationMaster.City = dr.GetString(dr.GetOrdinal("City"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("State")) Then
                        objTabMOrganizationMaster.State = dr.GetString(dr.GetOrdinal("State"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Phone")) Then
                        objTabMOrganizationMaster.Phone = dr.GetString(dr.GetOrdinal("Phone"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Country")) Then
                        objTabMOrganizationMaster.Country = dr.GetString(dr.GetOrdinal("Country"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Email")) Then
                        objTabMOrganizationMaster.Email = dr.GetString(dr.GetOrdinal("Email"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("OrganizationImage")) Then
                        objTabMOrganizationMaster.OrganizationImage = CType(dr.Item("OrganizationImage"), Byte())
                    End If
                    
                End While
                dr.Close()
                Return objTabMOrganizationMaster
            Else
                dr.Close()
                Return New clsTabMOrganisationMaster
            End If
        End Function
    End Class
End Namespace

