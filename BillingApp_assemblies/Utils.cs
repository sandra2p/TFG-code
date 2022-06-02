using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingApp_assemblies
{
    public class Utils
    {
        public static void Trace(ILocalPluginContext localPluginContext, String totalInvoice)
        {
            localPluginContext.TracingService.Trace(totalInvoice);
        }
    }
}
