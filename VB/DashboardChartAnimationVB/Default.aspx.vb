Imports System
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb

Namespace DashboardChartAnimationVB

	Partial Public Class _Default
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ASPxDashboard1.SetDataSourceStorage(CreateDataSourceStorage())
		End Sub

		Public Function CreateDataSourceStorage() As DataSourceInMemoryStorage
			Dim dataSourceStorage As New DataSourceInMemoryStorage()
			Dim objDataSource As New DashboardObjectDataSource("Object Data Source", GetType(SalesPersonData))

			objDataSource.DataMember = "GetSalesData"
			dataSourceStorage.RegisterDataSource("objectDataSource", objDataSource.SaveToXml())

			Return dataSourceStorage
		End Function
	End Class
End Namespace