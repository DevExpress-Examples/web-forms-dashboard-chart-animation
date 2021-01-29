<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DashboardChartAnimationCS._Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Test</title>

    <style type="text/css">
        html, body, form {  
            height: 100%;  
            margin: 0;  
            padding: 0;  
            overflow: hidden;  
        }
    </style>
    <script type="text/javascript">
        //<![CDATA[
        function onBeforeRender(s, e) {
            var dashboardControl = s.GetDashboardControl();
            var viewerApiExtension = dashboardControl.findExtension('viewer-api');

            if (viewerApiExtension)
                viewerApiExtension.on('itemWidgetOptionsPrepared', onItemWidgetOptionsPrepared);
        }

        function onItemWidgetOptionsPrepared(args) {
            if (args.dashboardItem instanceof DevExpress.Dashboard.Model.ChartItem ||
                args.dashboardItem instanceof DevExpress.Dashboard.Model.PieItem) {
             
                args.options.animation = {
                    enabled: true,
                    duration: 1000
                };
            }
        }
        //]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxDashboard ID="ASPxDashboard1" runat="server" DashboardStorageFolder="~/App_Data/Dashboards" Height="100%">
            <ClientSideEvents BeforeRender="onBeforeRender" />
        </dx:ASPxDashboard>
    </form>
</body>
</html>