Imports System
Imports System.Collections.Generic

Public Class SalesPersonData
	Public Property Department() As String
	Public Property SalesPerson() As String
	Public Property Quantity() As Integer

	Public Shared Function GetSalesData() As List(Of SalesPersonData)
		Dim data As New List(Of SalesPersonData)()
		Dim salesPersons() As String = { "Andrew Fuller", "Michael Suyama", "Robert King", "Nancy Davolio", "Margaret Peacock", "Laura Callahan", "Steven Buchanan", "Janet Leverling" }
		Dim rnd = New Random()
		For i As Integer = 0 To 99
			Dim record As New SalesPersonData()
			record.SalesPerson = salesPersons(rnd.Next(0, salesPersons.Length))
			record.Quantity = rnd.Next(0, 100)
			record.Department = "Dept. #" & rnd.Next(1, 3)
			data.Add(record)
		Next i
		Return data
	End Function
End Class