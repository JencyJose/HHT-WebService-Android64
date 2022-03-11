Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports DAL.TrackITKTS
Imports [Property].TrackITKTS
Namespace TrackITKTS
    Public Class clsTabKFullKegReturnsCustomer
      
        Public Shared Function Save(ByVal objTabKFullKegReturnCustomer As PropertyTabKFullKegReturnsCustomer, ByVal SchemaName As String) As String
            If Not objTabKFullKegReturnCustomer Is Nothing Then
                If objTabKFullKegReturnCustomer.FCOrderID <= 0 Then
                    Dim TempId As String = dalTabKFullKegReturnsCustomer.CreateNewTabKFullKegReturnsCustomer(objTabKFullKegReturnCustomer, SchemaName)
                    If Not TempId Is Nothing Then
                        objTabKFullKegReturnCustomer.TransactionNumber = TempId
                        Return TempId
                    Else
                        Return Nothing
                    End If

                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Function

        Public Shared Function SaveHHT(ByVal objTabKFullCustomer As PropertyTabKFullKegReturnsCustomer, ByVal SchemaName As String) As String
            If Not objTabKFullCustomer Is Nothing Then
                If objTabKFullCustomer.FCOrderID <= 0 Then
                    Dim TempId As String = dalTabKFullKegReturnsCustomer.CreateNewTabKFullCustomerHHT(objTabKFullCustomer, SchemaName)
                    If Not TempId Is Nothing Then
                        objTabKFullCustomer.TransactionNumber = TempId
                        Return TempId
                    Else
                        Return Nothing
                    End If
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Function
        Public Shared Function UpdateTabKFullKegReturnCustomer(ByVal objTabKFullKegReturnCustomer As PropertyTabKFullKegReturnsCustomer, ByVal SchemaName As String, ByVal PrevQty As Int32) As Boolean
            If Not objTabKFullKegReturnCustomer Is Nothing Then
                Return dalTabKFullKegReturnsCustomer.UpdateTabKFullKegReturnsCustomer(objTabKFullKegReturnCustomer, SchemaName, PrevQty)
            Else
                Return False
            End If
        End Function


        Public Shared Function GetAllTabKFullKegReturnCustomerByCompanyID(ByVal CompanyID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String) As DataSet
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKFullKegReturnsCustomer.GetAllTabKFullKegReturnsCustomerByCompanyID(CompanyID, SchemaName, TransactionNumber)
        End Function
        Public Shared Function GetAllTabKFullKegReturnCustomerByCompanyID_Search(ByVal CompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String, ByVal ItemCode As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKFullKegReturnsCustomer.GetAllTabKFullKegReturnsCustomerByCompanyID_Search(CompanyID, EmployeeID, SchemaName, TransactionNumber, ItemCode)
        End Function
        Public Shared Function BarcodeValidationFullKegReturn(ByVal valItemID As Int32, ByVal valCompanyID As Int32, ByVal valCustomerID As Int32, ByVal valBarcode As String, ByVal SchemaName As String) As Integer
            Return dalTabKFullKegReturnsCustomer.BarcodeValidationFullKegReturn(valItemID, valCompanyID, valCustomerID, valBarcode, SchemaName)
        End Function

        Public Shared Function GetAllTabKFullKegReturnCustomerByCompanyID_Search_Bulk(ByVal CompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String, ByVal SOrderID As String, ByVal OrderNumber As String, ByVal CustomerID As String, ByVal ItemCode As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKFullKegReturnsCustomer.GetAllTabKFullKegReturnCustomerByCompanyID_Search_Bulk(CompanyID, EmployeeID, SchemaName, SOrderID, OrderNumber, CustomerID, ItemCode)
        End Function

        Public Shared Function SaveBulk(ByVal objTabKFullKegReturnCustomer As PropertyTabKFullKegReturnsCustomer, ByVal SchemaName As String) As String
            If Not objTabKFullKegReturnCustomer Is Nothing Then
                If objTabKFullKegReturnCustomer.FCOrderID <= 0 Then
                    Dim TempId As String = dalTabKFullKegReturnsCustomer.CreateNewTabKFullKegReturnsCustomer_Bulk(objTabKFullKegReturnCustomer, SchemaName)
                    If Not TempId Is Nothing Then
                        objTabKFullKegReturnCustomer.TransactionNumber = TempId
                        Return TempId
                    Else
                        Return Nothing
                    End If

                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Function

    End Class
End Namespace
