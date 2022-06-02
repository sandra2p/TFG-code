using Microsoft.Xrm.Sdk;
using System;
using System.Linq;
using Microsoft.Xrm.Sdk.Query;
using System.Text;
using BillingApp_assemblies;
using static BillingApp_assemblies.Utils;
using CrmEarlyBound;

namespace InvoiceName_plugin
{
    /*
     * Plugin development guide: https://docs.microsoft.com/powerapps/developer/common-data-service/plug-ins
     * Best practices and guidance: https://docs.microsoft.com/powerapps/developer/common-data-service/best-practices/business-logic/
     */
    public class InvoiceName : PluginBase
    {
        public static DateTime today { get; set; }
        public InvoiceName(string unsecureConfiguration, string secureConfiguration)
            : base(typeof(InvoiceName))
        {
            // TODO: Implement your custom configuration handling
            // https://docs.microsoft.com/powerapps/developer/common-data-service/register-plug-in#set-configuration-data
        }

        // Entry point for custom business logic execution
        protected override void ExecuteCdsPlugin(ILocalPluginContext localPluginContext)
        {
            Trace(localPluginContext, "[InvoiceName] Start");

            if (localPluginContext == null)
            {
                throw new ArgumentNullException(nameof(localPluginContext));
            }

            var context = localPluginContext.PluginExecutionContext;

            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                var line = ((Entity)context.InputParameters["Target"]).ToEntity<mov_Line>();
                

                Trace(localPluginContext, "[InvoiceName] BeforeRetrieve");
                var invoice = localPluginContext.SystemUserService.Retrieve(line.mov_Invoice.LogicalName, line.mov_Invoice.Id, new ColumnSet("mov_id")).ToEntity<mov_Invoice>();
                Trace(localPluginContext, "[InvoiceName] AfetrRetrieve");
                String invNumber = invoice.mov_ID;
                Trace(localPluginContext, $"Invoice code: {invNumber}");
                string invName = buildName(invNumber);

                line.mov_Line1 = invName;
                Trace(localPluginContext, "[InvoiceName] End");
            }
        }

        private static string getDate() => DateTime.Now.ToString("ddMMyyyy");
        
        private static string buildName (String num) => $"Inv_{num}_{getDate()}";
    }
}
