using System.Linq;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using CrmEarlyBound;
using static BillingApp_assemblies.Utils;

namespace BillingApp_assemblies
{
    /*
     * Plugin development guide: https://docs.microsoft.com/powerapps/developer/common-data-service/plug-ins
     * Best practices and guidance: https://docs.microsoft.com/powerapps/developer/common-data-service/best-practices/business-logic/
     */
    public class TotalInvoice : PluginBase
    {
        public TotalInvoice(string unsecureConfiguration, string secureConfiguration)
            : base(typeof(TotalInvoice))
        {
        }

        // Entry point for custom business logic execution
        protected override void ExecuteCdsPlugin(ILocalPluginContext localPluginContext)
        {
            if (localPluginContext == null)
            {
                throw new ArgumentNullException(nameof(localPluginContext));
            }

            var context = localPluginContext.PluginExecutionContext;
            if (context.Depth > 1) return;

            
            Trace(localPluginContext, "[TotalInvoice] Start");
            // Check for the entity on which the plugin would be registered
            //if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            if (context.PostEntityImages.Contains("Image"))
            {
                var invoiceLine = context.PostEntityImages["Image"].ToEntity<mov_Line>();
                var invoiceRef = invoiceLine.mov_Invoice;

                var query = new QueryExpression(mov_Line.EntityLogicalName);
                query.ColumnSet.AddColumns("mov_total");
                query.Criteria.AddCondition("mov_invoice", ConditionOperator.Equal, $"{invoiceRef.Id}");
                var invoiceLines = localPluginContext.SystemUserService.RetrieveMultiple(query).Entities.Cast<mov_Line>();

                var totalInvoice = invoiceLines.Aggregate(0m, (acc, curr) =>acc + curr.mov_Total.Value);

                Trace(localPluginContext, totalInvoice.ToString());
                var invoice = new Entity(invoiceRef.LogicalName, invoiceRef.Id).ToEntity<mov_Invoice>();
                invoice.mov_totalinvoice = totalInvoice;
                localPluginContext.SystemUserService.Update(invoice);

            }
            Trace(localPluginContext, "[TotalInvoice] End");
        }

    
    }
}
