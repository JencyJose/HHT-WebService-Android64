Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports DAL.TrackITKTS
Imports [Property].TrackITKTS
Namespace TrackITKTS
    Public Class clsTabkEmptyOpeningBalanceHistory
        Public Shared Function Save(ByVal objTabKEInventory As PropertyTabkEmptyOpeningBalanceHistory, ByVal SchemaName As String, ByVal AdjustmentReason As String) As Boolean
            If Not objTabKEInventory Is Nothing Then

                Dim TempId As Integer = dalTabkEmptyOpeningBalanceHistory.CreateNewTabkEmptyOpeningBalanceHistory(objTabKEInventory, SchemaName, AdjustmentReason)
                If TempId > 0 Then
                    objTabKEInventory.OBHistoryID = TempId
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        End Function
        Public Shared Function GetMaxTransactionNumber_OBHistory(ByVal SchemaName As String, ByVal type As Int32, ByVal CompanyID As Int32, ByVal type1 As Int32) As DataSet
            Return dalTabkEmptyOpeningBalanceHistory.GetMaxTransactionNumber_OBHistory(SchemaName, type, CompanyID, type1)
        End Function
        Public Shared Function GetAllTabkEmptyOBHistoryByEntityType(ByVal valCompanyID As Int32, ByVal valEntityID As Int32, ByVal valEntityType As Int32, ByVal SchemaName As String) As DataSet

            Return dalTabkEmptyOpeningBalanceHistory.GetAllTabkEmptyOBHistoryByEntityType(valCompanyID, valEntityID, valEntityType, SchemaName)
        End Function
    End Class
End Namespace

