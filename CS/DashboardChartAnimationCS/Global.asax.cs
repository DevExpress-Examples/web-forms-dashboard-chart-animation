using System;
using DevExpress.Utils;

namespace DashboardChartAnimationCS {
    public class Global : System.Web.HttpApplication {

        protected void Application_Start(object sender, EventArgs e) {
            DeserializationSettings.RegisterTrustedClass(typeof(SalesPersonData));

        }
    }
}