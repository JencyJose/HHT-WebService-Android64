'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabMCompEmp
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:53 PM
'Description        :This file contains business logic details and get the data from data access layer...
'Modified By        :
'Modified Date      :
'***************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports DAL.TrackITKTS
Imports [Property].TrackITKTS
Namespace TrackITKTS

	Public Class clsTabMCompEmp

        Public Shared Function Save(ByVal objTabMCompEmp As PropertyTabMCompEmp, ByVal SchemaName As String) As Boolean
            If Not objTabMCompEmp Is Nothing Then
                Dim TempId As Integer = dalTabMCompEmp.CreateNewTabMCompEmp(objTabMCompEmp, SchemaName)
                If TempId > 0 Then
                    objTabMCompEmp.CompanyID = TempId
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        End Function

        Public Shared Function UpdateTabMCompEmp(ByVal objTabMCompEmp As PropertyTabMCompEmp) As Boolean
            If Not objTabMCompEmp Is Nothing Then
                Return dalTabMCompEmp.UpdateTabMCompEmp(objTabMCompEmp)
            Else
                Return False
            End If
        End Function

		Public Shared Function DeleteTabMCompEmp(ByVal CompanyID As Int32) As String
			If CompanyID<= 0 Then
				Return ""
			End If

			Return dalTabMCompEmp.DeleteTabMCompEmp(CompanyID)
		End Function

		Public Shared Function GetAllTabMCompEmp(ByVal valUserName As String) As  DataSet
			Return dalTabMCompEmp.GetALLTabMCompEmp(valUserName)
		End Function

		Public Shared Function GetAllTabMCompEmpDrop() As  SqlDataReader
			Return dalTabMCompEmp.GetALLTabMCompEmpDrop()
		End Function

        Public Shared Function GetTabMCompEmpByID(ByVal CompanyID As Int32) As PropertyTabMCompEmp
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMCompEmp.GetTabMCompEmpByID(CompanyID)
        End Function

        Public Shared Function GetTabMAllCompEmpByEmployeeID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMCompEmp.GetTabMAllCompEmpByEmployeeID(EmployeeID, SchemaName)
        End Function

        Public Shared Function GetTabMCompEmpByEmployeeID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMCompEmp.GetTabMCompEmpByEmployeeID(EmployeeID, SchemaName)
        End Function
		Public Shared Function GetTabMCompEmpByCompanyID(ByVal CompanyID As Int32) As DataSet
			If CompanyID<= 0 Then
				Return (Nothing)
			End If

			Return dalTabMCompEmp.GetTabMCompEmpByCompanyID(CompanyID)
		End Function
        Public Shared Function GetAllTabMCompEmpOrgByEmployeeID(ByVal valUserName As String, ByVal SchemaName As String) As DataSet
            Return dalTabMCompEmp.GetAllTabMCompEmpOrgByEmployeeID(valUserName, SchemaName)
        End Function
        Public Shared Function GetTabMAllHHTUsersNewCR(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMCompEmp.GetTabMAllHHTUsersNewCR(EmployeeID, SchemaName)
        End Function


	End Class

End Namespace
