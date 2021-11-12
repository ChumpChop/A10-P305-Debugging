Imports System.Collections.Generic
Public Class Debug
    'Using the Generics class
    Private objStringValues As New Generics(Of String)
    Private objIntegerValues As New Generics(Of Integer)

    'Using the List(Of T)(Of T) class
    Private objCustomerList As New List(Of Customer)

    Private Sub ListCustomer(ByVal customerToList As Customer)
        lstData.Items.Add(customerToList.CustomerID &
"—" & customerToList.CustomerName)
    End Sub

    Private Sub Debug_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Declare variables
        Dim strData As String
        lstData.Items.Add("String variable data:")

        ''If strData.Length > 0 Then
        ''    lstData.Items.Add(strData)
        ''End If

        'If strData IsNot Nothing Then
        '    If strData.Length > 0 Then
        '        lstData.Items.Add(strData)
        '    End If
        'Else
        '    strData = "String now initialized"
        '    lstData.Items.Add(strData)
        'End If

        Try
            If strData.Length > 0 Then
                lstData.Items.Add(strData)
            End If
        Catch NullReferenceExceptionErr As NullReferenceException
            strData = "String now initialized"
            lstData.Items.Add(strData)
        End Try

        'Add an empty string to the ListBox
        lstData.Items.Add(String.Empty)
        'Demonstrates the use of the List(Of T) class
        lstData.Items.Add("Customers in the Customer Class:")
        objCustomerList.Add(New Customer(1001, "Henry For"))
        objCustomerList.Add(New Customer(1002, "Orville Wright"))
        For Each objCustomer As Customer In objCustomerList
            ListCustomer(objCustomer)
        Next
        'Add an empty string to the ListBox
        lstData.Items.Add(String.Empty)
        'Demonstrates the use of Generics
        lstData.Items.Add("Generics Class Key/Value Pairs using String Values:")
        objStringValues.Add("1001", "Henry Ford")
        lstData.Items.Add(objStringValues.Key(0) & " = " &
        objStringValues.Value(0))
        'Add an empty string to the ListBox
        lstData.Items.Add(String.Empty)
        'Demonstrates the use of Generics
        lstData.Items.Add("Generics Class Key/Value Pairs using Integer Values:")
        objIntegerValues.Add("Henry Ford", 1001)
        lstData.Items.Add(objIntegerValues.Key(0) & " = " &
        objIntegerValues.Value(0))
        'Add an empty string to the ListBox
        lstData.Items.Add(String.Empty)
        'Demonstrates the use of the Using statement
        'Allows acquisition, usage and disposal of the resource
        lstData.Items.Add("Computer Class Properties:")
        Using objMemory As New Computer
            lstData.Items.Add("FreeMemory = " & objMemory.FreeMemory)
            lstData.Items.Add("TotalMemory = " & objMemory.TotalMemory)
        End Using
        'Add an empty string to the ListBox
        lstData.Items.Add(String.Empty)
        'Demonstrates the use of the Continue statement
        Dim strPassword As String = "POpPassword"
        Dim strLowerCaseLetters As String = String.Empty
        'Extract lowercase characters from string
        For intIndex As Integer = 0 To strPassword.Length - 1
            'Demonstrates the use of the Continue statement
            'If no uppercase character is found, continue the loop
            If Not strPassword.Substring(intIndex, 1) Like "[a-z]" Then
                'No upper case character found, continue loop
                Continue For
            End If
            'Lowercase character found, save it
            strLowerCaseLetters &= strPassword.Substring(intIndex, 1)
        Next
        'Display lowercase characters
        lstData.Items.Add("Password lower case characters:")
        lstData.Items.Add(strLowerCaseLetters)
    End Sub
End Class
