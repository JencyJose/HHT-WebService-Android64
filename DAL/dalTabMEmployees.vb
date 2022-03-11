'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabMEmployees
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:56 PM
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
    Public Class dalTabMEmployees

        Private ConnectionString As String

        Public Shared Function CreateNewTabMEmployees(ByVal objTabMEmployees As PropertyTabMEmployees, ByVal SchemaName As String) As Integer

            If objTabMEmployees Is Nothing Then
                Throw New ArgumentNullException("objTabMEmployees")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@EmployeeName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMEmployees.EmployeeName)
            db.AddParamToSQLCmd(sqlCmd, "@EmployeeNo", SqlDbType.NVarChar, 20, ParameterDirection.Input, objTabMEmployees.EmployeeNo)
            db.AddParamToSQLCmd(sqlCmd, "@Position", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMEmployees.Position)
            db.AddParamToSQLCmd(sqlCmd, "@Phone", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMEmployees.Phone)
            db.AddParamToSQLCmd(sqlCmd, "@Email", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMEmployees.Email)
            db.AddParamToSQLCmd(sqlCmd, "@Comments", SqlDbType.NVarChar, 200, ParameterDirection.Input, objTabMEmployees.Comments)
            db.AddParamToSQLCmd(sqlCmd, "@UserName", SqlDbType.NVarChar, 20, ParameterDirection.Input, objTabMEmployees.UserName)
            db.AddParamToSQLCmd(sqlCmd, "@Password", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMEmployees.Password)
            db.AddParamToSQLCmd(sqlCmd, "@ChangedBy", SqlDbType.NVarChar, 20, ParameterDirection.Input, objTabMEmployees.ChangedBy)
            db.AddParamToSQLCmd(sqlCmd, "@Disable", SqlDbType.NVarChar, 3, ParameterDirection.Input, objTabMEmployees.Disable)
            db.AddParamToSQLCmd(sqlCmd, "@Reason", SqlDbType.NVarChar, 25, ParameterDirection.Input, objTabMEmployees.Reason)
            db.AddParamToSQLCmd(sqlCmd, "@Logged", SqlDbType.NVarChar, 3, ParameterDirection.Input, objTabMEmployees.Logged)
            db.AddParamToSQLCmd(sqlCmd, "@Mobile", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMEmployees.Mobile)
            db.AddParamToSQLCmd(sqlCmd, "@EmpPhoto", SqlDbType.Image, 0, ParameterDirection.Input, objTabMEmployees.EmpPhoto)
            db.AddParamToSQLCmd(sqlCmd, "@IsOrganization", SqlDbType.Bit, 100, ParameterDirection.Input, objTabMEmployees.IsOrganization)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMEmployees.SchemaName)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTabMEmployees")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function UpdateTabMEmployees(ByVal objTabMEmployees As PropertyTabMEmployees, ByVal SchemaName As String) As Boolean

            If objTabMEmployees Is Nothing Then
                Throw New ArgumentNullException("objTabMEmployees")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@EmployeeID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMEmployees.EmployeeID)
            db.AddParamToSQLCmd(sqlCmd, "@EmployeeName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMEmployees.EmployeeName)
            db.AddParamToSQLCmd(sqlCmd, "@EmployeeNo", SqlDbType.NVarChar, 20, ParameterDirection.Input, objTabMEmployees.EmployeeNo)
            db.AddParamToSQLCmd(sqlCmd, "@Position", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMEmployees.Position)
            db.AddParamToSQLCmd(sqlCmd, "@Phone", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMEmployees.Phone)
            db.AddParamToSQLCmd(sqlCmd, "@Email", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMEmployees.Email)
            db.AddParamToSQLCmd(sqlCmd, "@Comments", SqlDbType.NVarChar, 200, ParameterDirection.Input, objTabMEmployees.Comments)
            db.AddParamToSQLCmd(sqlCmd, "@UserName", SqlDbType.NVarChar, 20, ParameterDirection.Input, objTabMEmployees.UserName)
            db.AddParamToSQLCmd(sqlCmd, "@Password", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMEmployees.Password)
            db.AddParamToSQLCmd(sqlCmd, "@ChangedBy", SqlDbType.NVarChar, 20, ParameterDirection.Input, objTabMEmployees.ChangedBy)
            db.AddParamToSQLCmd(sqlCmd, "@Disable", SqlDbType.NVarChar, 3, ParameterDirection.Input, objTabMEmployees.Disable)
            db.AddParamToSQLCmd(sqlCmd, "@Reason", SqlDbType.NVarChar, 25, ParameterDirection.Input, objTabMEmployees.Reason)
            db.AddParamToSQLCmd(sqlCmd, "@Logged", SqlDbType.NVarChar, 3, ParameterDirection.Input, objTabMEmployees.Logged)
            db.AddParamToSQLCmd(sqlCmd, "@Mobile", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMEmployees.Mobile)
            db.AddParamToSQLCmd(sqlCmd, "@EmpPhoto", SqlDbType.Image, 0, ParameterDirection.Input, objTabMEmployees.EmpPhoto)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_UpdateTabMEmployees")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabMEmployees(ByVal EmployeeID As Int32) As String

            If EmployeeID <= 0 Then
                Throw New ArgumentOutOfRangeException("EmployeeID")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@EmployeeID", SqlDbType.Int, 0, ParameterDirection.Input, EmployeeID)
            db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabMEmployees")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
            If Not String.IsNullOrEmpty(returnValue) Then
                Return returnValue
            Else
                Return ""
            End If
        End Function


        Public Shared Function GetTabMEmployeesByID(ByVal valEmployeeID As Int32, ByVal SchemaName As String) As PropertyTabMEmployees
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader(SchemaName + ".TIT_GetTabMEmployeesByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabMEmployees As PropertyTabMEmployees = New PropertyTabMEmployees
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("EmployeeID")) Then
                        objTabMEmployees.EmployeeID = dr.GetInt32(dr.GetOrdinal("EmployeeID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("EmployeeName")) Then
                        objTabMEmployees.EmployeeName = dr.GetString(dr.GetOrdinal("EmployeeName"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("EmployeeNo")) Then
                        objTabMEmployees.EmployeeNo = dr.GetString(dr.GetOrdinal("EmployeeNo"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Position")) Then
                        objTabMEmployees.Position = dr.GetString(dr.GetOrdinal("Position"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Phone")) Then
                        objTabMEmployees.Phone = dr.GetString(dr.GetOrdinal("Phone"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Email")) Then
                        objTabMEmployees.Email = dr.GetString(dr.GetOrdinal("Email"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Comments")) Then
                        objTabMEmployees.Comments = dr.GetString(dr.GetOrdinal("Comments"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("UserName")) Then
                        objTabMEmployees.UserName = dr.GetString(dr.GetOrdinal("UserName"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Password")) Then
                        objTabMEmployees.Password = dr.GetString(dr.GetOrdinal("Password"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ChangedBy")) Then
                        objTabMEmployees.ChangedBy = dr.GetString(dr.GetOrdinal("ChangedBy"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Disable")) Then
                        objTabMEmployees.Disable = dr.GetString(dr.GetOrdinal("Disable"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Reason")) Then
                        objTabMEmployees.Reason = dr.GetString(dr.GetOrdinal("Reason"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Logged")) Then
                        objTabMEmployees.Logged = dr.GetString(dr.GetOrdinal("Logged"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Mobile")) Then
                        objTabMEmployees.Mobile = dr.GetString(dr.GetOrdinal("Mobile"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("EmpPhoto")) Then
                        objTabMEmployees.EmpPhoto = CType(dr.Item("EmpPhoto"), Byte())
                    End If
                End While
                dr.Close()
                Return objTabMEmployees
            Else
                dr.Close()
                Return New PropertyTabMEmployees
            End If
        End Function

        Public Shared Function GetAllTabMEmployeesByUserName(ByVal valUserName As String, ByVal SchemaName As String) As PropertyTabMEmployees
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
            Dim dr As SqlDataReader = CType(db.ExecuteReader(SchemaName + ".TIT_GetAllTabMEmployeesByUserName"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabMEmployees As PropertyTabMEmployees = New PropertyTabMEmployees
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("EmployeeID")) Then
                        objTabMEmployees.EmployeeID = dr.GetInt32(dr.GetOrdinal("EmployeeID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("EmployeeName")) Then
                        objTabMEmployees.EmployeeName = dr.GetString(dr.GetOrdinal("EmployeeName"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("EmployeeNo")) Then
                        objTabMEmployees.EmployeeNo = dr.GetString(dr.GetOrdinal("EmployeeNo"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Position")) Then
                        objTabMEmployees.Position = dr.GetString(dr.GetOrdinal("Position"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Phone")) Then
                        objTabMEmployees.Phone = dr.GetString(dr.GetOrdinal("Phone"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Email")) Then
                        objTabMEmployees.Email = dr.GetString(dr.GetOrdinal("Email"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Comments")) Then
                        objTabMEmployees.Comments = dr.GetString(dr.GetOrdinal("Comments"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("UserName")) Then
                        objTabMEmployees.UserName = dr.GetString(dr.GetOrdinal("UserName"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Password")) Then
                        objTabMEmployees.Password = dr.GetString(dr.GetOrdinal("Password"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ChangedBy")) Then
                        objTabMEmployees.ChangedBy = dr.GetString(dr.GetOrdinal("ChangedBy"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Disable")) Then
                        objTabMEmployees.Disable = dr.GetString(dr.GetOrdinal("Disable"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Reason")) Then
                        objTabMEmployees.Reason = dr.GetString(dr.GetOrdinal("Reason"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Logged")) Then
                        objTabMEmployees.Logged = dr.GetString(dr.GetOrdinal("Logged"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Mobile")) Then
                        objTabMEmployees.Mobile = dr.GetString(dr.GetOrdinal("Mobile"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("EmpPhoto")) Then
                        objTabMEmployees.EmpPhoto = CType(dr.Item("EmpPhoto"), Byte())
                    End If
                End While
                dr.Close()
                Return objTabMEmployees
            Else
                dr.Close()
                Return New PropertyTabMEmployees
            End If
        End Function

        Public Shared Function GetAllTabMEmployeesByEmployeeName(ByVal valEmployeeName As String, ByVal SchemaName As String) As PropertyTabMEmployees
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeName", valEmployeeName))
            Dim dr As SqlDataReader = CType(db.ExecuteReader(SchemaName + ".TIT_GetAllTabMEmployeesByEmployeeName"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabMEmployees As PropertyTabMEmployees = New PropertyTabMEmployees
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("EmployeeID")) Then
                        objTabMEmployees.EmployeeID = dr.GetInt32(dr.GetOrdinal("EmployeeID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("EmployeeName")) Then
                        objTabMEmployees.EmployeeName = dr.GetString(dr.GetOrdinal("EmployeeName"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("EmployeeNo")) Then
                        objTabMEmployees.EmployeeNo = dr.GetString(dr.GetOrdinal("EmployeeNo"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Position")) Then
                        objTabMEmployees.Position = dr.GetString(dr.GetOrdinal("Position"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Phone")) Then
                        objTabMEmployees.Phone = dr.GetString(dr.GetOrdinal("Phone"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Email")) Then
                        objTabMEmployees.Email = dr.GetString(dr.GetOrdinal("Email"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Comments")) Then
                        objTabMEmployees.Comments = dr.GetString(dr.GetOrdinal("Comments"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("UserName")) Then
                        objTabMEmployees.UserName = dr.GetString(dr.GetOrdinal("UserName"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Password")) Then
                        objTabMEmployees.Password = dr.GetString(dr.GetOrdinal("Password"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ChangedBy")) Then
                        objTabMEmployees.ChangedBy = dr.GetString(dr.GetOrdinal("ChangedBy"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Disable")) Then
                        objTabMEmployees.Disable = dr.GetString(dr.GetOrdinal("Disable"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Reason")) Then
                        objTabMEmployees.Reason = dr.GetString(dr.GetOrdinal("Reason"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Logged")) Then
                        objTabMEmployees.Logged = dr.GetString(dr.GetOrdinal("Logged"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Mobile")) Then
                        objTabMEmployees.Mobile = dr.GetString(dr.GetOrdinal("Mobile"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("EmpPhoto")) Then
                        objTabMEmployees.EmpPhoto = CType(dr.Item("EmpPhoto"), Byte())
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("SchemaName")) Then
                        objTabMEmployees.SchemaName = dr.GetString(dr.GetOrdinal("SchemaName"))
                    End If
                End While
                dr.Close()
                Return objTabMEmployees
            Else
                dr.Close()
                Return New PropertyTabMEmployees
            End If
        End Function

        Public Shared Function GetALLTabMEmployees(ByVal valUserName As String, ByVal valCompanyID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabMEmployees")
            Return ds
        End Function
        Public Shared Function GetALLTabMEmployeesByEmployeeID(ByVal valUserName As String, ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabMEmployeesBYEmployeeiD")
            Return ds
        End Function


        Public Shared Function GetALLTabMEmployeesDrop() As SqlDataReader
            Dim db As DBAccess = New DBAccess
            Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabMEmployeesDrop")
            Return dr
        End Function

        Public Shared Function GetTabMEmployeesByCompanyID(ByVal valCompanyID As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabMEmployeesByCompanyID")
            Return ds
        End Function

        Public Shared Function GetTabMEmployeesByRoleID(ByVal valRoleID As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@RoleID", valRoleID))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabMEmployeesByRoleID")
            Return ds
        End Function

        Public Shared Function chkValidUser(ByVal objATSUsers As PropertyTabMEmployees) As Hashtable

            If objATSUsers Is Nothing Then
                Throw New ArgumentNullException("objATSUsers")
            End If
            Dim objUserDetails As New Hashtable()

            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@UserName", objATSUsers.UserName))
            db.Parameters.Add(New SqlParameter("@Password", objATSUsers.Password))
            Dim dr As SqlDataReader = CType(db.ExecuteReader("dbo.TIT_CheckValidUser"), SqlDataReader)

            If dr.HasRows Then
                While dr.Read
                    objUserDetails.Add("empID", dr.GetInt32(dr.GetOrdinal("EmployeeID")))
                    objUserDetails.Add("userName", dr.GetString(dr.GetOrdinal("UserName")))
                    'If Not dr.IsDBNull(dr.GetOrdinal("Role")) Then
                    '    objUserDetails.Add("userRoles", dr.GetString(dr.GetOrdinal("Role")))
                    'Else
                    '    objUserDetails.Add("userRoles", "")
                    'End If
                    objUserDetails.Add("disabled", dr.GetString(dr.GetOrdinal("disabled")))
                    If Not dr.IsDBNull(dr.GetOrdinal("ChangedBy")) Then
                        objUserDetails.Add("changedby", dr.GetString(dr.GetOrdinal("ChangedBy")))
                    Else
                        objUserDetails.Add("changedby", "")
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Logged")) Then
                        objUserDetails.Add("Logged", dr.GetString(dr.GetOrdinal("Logged")))
                    Else
                        objUserDetails.Add("Logged", "")
                    End If
                    'If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
                    '    objUserDetails.Add("companyID", dr.GetString(dr.GetOrdinal("CompanyID")))
                    'Else
                    '    objUserDetails.Add("companyID", "")
                    'End If
                    If Not dr.IsDBNull(dr.GetOrdinal("EmployeeName")) Then
                        objUserDetails.Add("employeeName", dr.GetString(dr.GetOrdinal("EmployeeName")))
                    Else
                        objUserDetails.Add("employeeName", "")
                    End If
                    'If Not dr.IsDBNull(dr.GetOrdinal("OrganizationID")) Then
                    '    objUserDetails.Add("organizationID", dr.GetString(dr.GetOrdinal("OrganizationID")))
                    'Else
                    '    objUserDetails.Add("organizationID", "")
                    'End If
                    If Not dr.IsDBNull(dr.GetOrdinal("IsOrganisation")) Then
                        objUserDetails.Add("isOrganisation", dr.GetBoolean(dr.GetOrdinal("IsOrganisation")))
                    Else
                        objUserDetails.Add("isOrganisation", "")
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("SchemaName")) Then
                        objUserDetails.Add("schemaName", dr.GetString(dr.GetOrdinal("SchemaName")))
                    Else
                        objUserDetails.Add("schemaName", "")
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("EmployeeNo")) Then
                        objUserDetails.Add("employeeNo", dr.GetString(dr.GetOrdinal("EmployeeNo")))
                    Else
                        objUserDetails.Add("employeeNo", "")
                    End If
                End While
                dr.Close()
                Return objUserDetails
            Else
                dr.Close()
                Return (Nothing)
            End If
        End Function

        Public Shared Function ValidateAzureADUser(UserName As String) As Hashtable

            Dim objUserDetails As New Hashtable()

            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@UserName", UserName))
            Dim dr As SqlDataReader = CType(db.ExecuteReader("dbo.TIT_CheckValidUserAzureAD"), SqlDataReader)

            If dr.HasRows Then
                While dr.Read
                    If dr.GetInt32(dr.GetOrdinal("EmployeeID")) = 0 Then
                        objUserDetails.Add("empID", dr.GetInt32(dr.GetOrdinal("EmployeeID")))
                        objUserDetails.Add("userName", dr.GetString(dr.GetOrdinal("UserName")))
                    Else

                        objUserDetails.Add("empID", dr.GetInt32(dr.GetOrdinal("EmployeeID")))
                        objUserDetails.Add("userName", dr.GetString(dr.GetOrdinal("UserName")))
                        'If Not dr.IsDBNull(dr.GetOrdinal("Role")) Then
                        '    objUserDetails.Add("userRoles", dr.GetString(dr.GetOrdinal("Role")))
                        'Else
                        '    objUserDetails.Add("userRoles", "")
                        'End If
                        objUserDetails.Add("disabled", dr.GetString(dr.GetOrdinal("disabled")))
                        If Not dr.IsDBNull(dr.GetOrdinal("ChangedBy")) Then
                            objUserDetails.Add("changedby", dr.GetString(dr.GetOrdinal("ChangedBy")))
                        Else
                            objUserDetails.Add("changedby", "")
                        End If
                        If Not dr.IsDBNull(dr.GetOrdinal("Logged")) Then
                            objUserDetails.Add("Logged", dr.GetString(dr.GetOrdinal("Logged")))
                        Else
                            objUserDetails.Add("Logged", "")
                        End If
                        'If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
                        '    objUserDetails.Add("companyID", dr.GetString(dr.GetOrdinal("CompanyID")))
                        'Else
                        '    objUserDetails.Add("companyID", "")
                        'End If
                        If Not dr.IsDBNull(dr.GetOrdinal("EmployeeName")) Then
                            objUserDetails.Add("employeeName", dr.GetString(dr.GetOrdinal("EmployeeName")))
                        Else
                            objUserDetails.Add("employeeName", "")
                        End If
                        'If Not dr.IsDBNull(dr.GetOrdinal("OrganizationID")) Then
                        '    objUserDetails.Add("organizationID", dr.GetString(dr.GetOrdinal("OrganizationID")))
                        'Else
                        '    objUserDetails.Add("organizationID", "")
                        'End If
                        If Not dr.IsDBNull(dr.GetOrdinal("IsOrganisation")) Then
                            objUserDetails.Add("isOrganisation", dr.GetBoolean(dr.GetOrdinal("IsOrganisation")))
                        Else
                            objUserDetails.Add("isOrganisation", "")
                        End If
                        If Not dr.IsDBNull(dr.GetOrdinal("SchemaName")) Then
                            objUserDetails.Add("schemaName", dr.GetString(dr.GetOrdinal("SchemaName")))
                        Else
                            objUserDetails.Add("schemaName", "")
                        End If
                        If Not dr.IsDBNull(dr.GetOrdinal("EmployeeNo")) Then
                            objUserDetails.Add("employeeNo", dr.GetString(dr.GetOrdinal("EmployeeNo")))
                        Else
                            objUserDetails.Add("employeeNo", "")
                        End If
                    End If
                End While
                dr.Close()
                Return objUserDetails
            Else
                dr.Close()
                Return (Nothing)
            End If
        End Function

        Public Shared Function UpdateTabMEmployees_LoggedIn(ByVal objTabMEmployees As PropertyTabMEmployees, ByVal SchemaName As String) As Boolean

            If objTabMEmployees Is Nothing Then
                Throw New ArgumentNullException("objTabMEmployees")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@EmployeeID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMEmployees.EmployeeID)
            db.AddParamToSQLCmd(sqlCmd, "@Logged", SqlDbType.NVarChar, 3, ParameterDirection.Input, objTabMEmployees.Logged)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_UpdateTabMEmployees_LoggedIn")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Shared Function GetAllTABUserPrivilegesByEmployeeID(ByVal EmployeeID As Int32, ByVal CompanyID As Int32, ByVal OrganizationID As Int32, ByVal SchemaName As String) As Hashtable

            If EmployeeID <= 0 Then
                Throw New ArgumentNullException("objATSUsers")
            End If
            Dim objUserPrivileges As New Hashtable()

            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            db.Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
            db.Parameters.Add(New SqlParameter("@OrganizationID", OrganizationID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader(SchemaName + ".TIT_GetAllTABUserPrivilegesByEmployeeID"), SqlDataReader)

            Dim prevStr As String = Nothing
            Dim splitprevStr As String()
            If dr.HasRows Then
                While dr.Read
                    splitprevStr = Nothing

                    If objUserPrivileges.Contains(dr.GetString(dr.GetOrdinal("NavigateURL"))) Then
                        prevStr = objUserPrivileges.Item(dr.GetString(dr.GetOrdinal("NavigateURL")))
                        splitprevStr = prevStr.Split(",")
                    End If

                    Dim str As String = ""

                    If dr("AllowView") = True Then
                        str = str & "1,"
                    Else
                        If Not splitprevStr Is Nothing Then
                            If splitprevStr(0) = 1 Then
                                str = str & "1,"
                            Else
                                str = str & "0,"
                            End If
                        Else
                            str = str & "0,"
                        End If
                    End If
                    If dr("AllowAdd") = True Then
                        str = str & "1,"
                    Else
                        If Not splitprevStr Is Nothing Then
                            If splitprevStr(1) = 1 Then
                                str = str & "1,"
                            Else
                                str = str & "0,"
                            End If
                        Else
                            str = str & "0,"
                        End If
                    End If
                    If dr("AllowEdit") = True Then
                        str = str & "1,"
                    Else
                        If Not splitprevStr Is Nothing Then
                            If splitprevStr(2) = 1 Then
                                str = str & "1,"
                            Else
                                str = str & "0,"
                            End If
                        Else
                            str = str & "0,"
                        End If
                    End If
                    If dr("AllowDelete") = True Then
                        str = str & "1"
                    Else
                        If Not splitprevStr Is Nothing Then
                            If splitprevStr(3) = 1 Then
                                str = str & "1,"
                            Else
                                str = str & "0,"
                            End If
                        Else
                            str = str & "0,"
                        End If
                    End If
                    If Not objUserPrivileges.Contains(dr.GetString(dr.GetOrdinal("NavigateURL"))) Then
                        objUserPrivileges.Add(dr.GetString(dr.GetOrdinal("NavigateURL")), str)
                    End If
                End While
                dr.Close()
                Return objUserPrivileges
            Else
                dr.Close()
                Return (Nothing)
            End If
        End Function


        Public Shared Function GetAllTABUserPrivilegesByEmployeeID_Menu(ByVal valEmployeeID As Int32, ByVal valCompanyID As Int32, ByVal valOrganizationID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@OrganizationID", valOrganizationID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTABUserPrivilegesByEmployeeID_Menu")
            Return ds
        End Function
        Public Shared Function UpdateATSUserPassword(ByVal objATSUsers As PropertyTabMEmployees, ByVal oldPass As String, ByVal SchemaName As String) As Boolean

            If objATSUsers Is Nothing Then
                Throw New ArgumentNullException("objATSUsers")
            End If

            Dim db As DBAccess = New DBAccess

            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@UserName", SqlDbType.NVarChar, 20, ParameterDirection.Input, objATSUsers.UserName)
            db.AddParamToSQLCmd(sqlCmd, "@Password", SqlDbType.NVarChar, 100, ParameterDirection.Input, objATSUsers.Password)
            db.AddParamToSQLCmd(sqlCmd, "@OldPassword", SqlDbType.NVarChar, 100, ParameterDirection.Input, oldPass)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_UpdateATSUserPasswordCHNAGED")
            ' db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateATSUserPassword")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Shared Function GetEmployeeCompanyAndRoles(ByVal objATSUsers As PropertyTabMEmployees, ByVal SchemaName As String) As Hashtable

            If objATSUsers Is Nothing Then
                Throw New ArgumentNullException("objATSUsers")
            End If
            Dim objUserRoleDetails As New Hashtable()

            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@UserName", objATSUsers.UserName))
            db.Parameters.Add(New SqlParameter("@Password", objATSUsers.Password))
            Dim dr As SqlDataReader = CType(db.ExecuteReader(SchemaName + ".TIT_GetEmployeeCompanyAndRoles"), SqlDataReader)

            If dr.HasRows Then
                While dr.Read
                    objUserRoleDetails.Add("employeeID", dr.GetInt32(dr.GetOrdinal("EmployeeID")))

                    If Not dr.IsDBNull(dr.GetOrdinal("RoleIDS")) Then
                        objUserRoleDetails.Add("userRoles", dr.GetString(dr.GetOrdinal("RoleIDS")))
                    Else
                        objUserRoleDetails.Add("userRoles", "")
                    End If

                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyIDS")) Then
                        objUserRoleDetails.Add("companyIDS", dr.GetString(dr.GetOrdinal("CompanyIDS")))
                    Else
                        objUserRoleDetails.Add("companyIDS", "")
                    End If

                    If Not dr.IsDBNull(dr.GetOrdinal("OrganizationIDS")) Then
                        objUserRoleDetails.Add("organizationIDS", dr.GetString(dr.GetOrdinal("OrganizationIDS")))
                    Else
                        objUserRoleDetails.Add("organizationIDS", "")
                    End If
                End While
                dr.Close()
                Return objUserRoleDetails
            Else
                dr.Close()
                Return (Nothing)
            End If
        End Function

        Public Shared Function GetEmployeeCompanyAndRolesAzureAD(ByVal objATSUsers As PropertyTabMEmployees, ByVal SchemaName As String) As Hashtable

            If objATSUsers Is Nothing Then
                Throw New ArgumentNullException("objATSUsers")
            End If
            Dim objUserRoleDetails As New Hashtable()

            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@UserName", objATSUsers.UserName))
            'db.Parameters.Add(New SqlParameter("@Password", objATSUsers.Password))
            Dim dr As SqlDataReader = CType(db.ExecuteReader(SchemaName + ".TIT_GetEmployeeCompanyAndRolesAzureAD"), SqlDataReader)

            If dr.HasRows Then
                While dr.Read
                    objUserRoleDetails.Add("employeeID", dr.GetInt32(dr.GetOrdinal("EmployeeID")))

                    If Not dr.IsDBNull(dr.GetOrdinal("RoleIDS")) Then
                        objUserRoleDetails.Add("userRoles", dr.GetString(dr.GetOrdinal("RoleIDS")))
                    Else
                        objUserRoleDetails.Add("userRoles", "")
                    End If

                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyIDS")) Then
                        objUserRoleDetails.Add("companyIDS", dr.GetString(dr.GetOrdinal("CompanyIDS")))
                    Else
                        objUserRoleDetails.Add("companyIDS", "")
                    End If

                    If Not dr.IsDBNull(dr.GetOrdinal("OrganizationIDS")) Then
                        objUserRoleDetails.Add("organizationIDS", dr.GetString(dr.GetOrdinal("OrganizationIDS")))
                    Else
                        objUserRoleDetails.Add("organizationIDS", "")
                    End If
                End While
                dr.Close()
                Return objUserRoleDetails
            Else
                dr.Close()
                Return (Nothing)
            End If
        End Function

        'HHT Methds
        Public Shared Function ChkUserValidity(ByVal objATSUsers As PropertyTabMEmployees) As DataSet

            If objATSUsers Is Nothing Then
                Throw New ArgumentNullException("objATSUsers")
            End If
            Dim objUserDetails As New DataSet

            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@UserName", objATSUsers.UserName))
            db.Parameters.Add(New SqlParameter("@Password", objATSUsers.Password))
            objUserDetails = db.ExecuteDataSet("dbo.TIT_CheckValidUser")
            Return objUserDetails

        End Function
        Public Shared Function GetEmployeeCompanyAndRolesHHT(ByVal objATSUsers As PropertyTabMEmployees, ByVal SchemaName As String) As DataSet

            If objATSUsers Is Nothing Then
                Throw New ArgumentNullException("objATSUsers")
            End If
            Dim dsUserRoleDetails As New DataSet

            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@UserName", objATSUsers.UserName))
            db.Parameters.Add(New SqlParameter("@Password", objATSUsers.Password))
            dsUserRoleDetails = db.ExecuteDataSet(SchemaName + ".TIT_GetEmployeeCompanyAndRoles")

            If dsUserRoleDetails.Tables(0).Rows.Count > 0 Then

                Return dsUserRoleDetails
            Else

                Return (Nothing)
            End If
        End Function
        Public Shared Function GetAllTABUserPrivilegesByEmployeeID_HHTMenu(ByVal valEmployeeID As Int32, ByVal valCompanyID As Int32, ByVal valOrganizationID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@OrganizationID", valOrganizationID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTABUserPrivilegesByEmployeeID_HHTMenu")
            Return ds
        End Function
    End Class
End Namespace
