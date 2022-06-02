using CrmEarlyBound;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;



namespace PuginApi
{
    /*
     * Plugin development guide: https://docs.microsoft.com/powerapps/developer/common-data-service/plug-ins
     * Best practices and guidance: https://docs.microsoft.com/powerapps/developer/common-data-service/best-practices/business-logic/
     */
    public class Plugin1 : PluginBase
    {
        public Plugin1(string unsecureConfiguration, string secureConfiguration)
            : base(typeof(Plugin1))
        {}

        // Entry point for custom business logic execution
        protected override void ExecuteCdsPlugin(ILocalPluginContext localPluginContext)
        {

            if (localPluginContext == null)
            {
                throw new ArgumentNullException(nameof(localPluginContext));
            }

            var context = localPluginContext.PluginExecutionContext;

            string fieldName = (string)context.InputParameters["mov_Field_Name"];
            var targetEntity = (string)context.InputParameters["mov_TargetEntity_Name"];
            var targetId = (string)context.InputParameters["mov_TargetEntityId"];

            var line = localPluginContext.SystemUserService.Retrieve(targetEntity, new Guid(targetId), new ColumnSet("mov_quantity","mov_product")).ToEntity<mov_Line>();
            var product = localPluginContext.SystemUserService.Retrieve(line.mov_Product.LogicalName, line.mov_Product.Id, new ColumnSet("mov_price")).ToEntity<mov_Product>();

            var quantity = line.mov_Quantity.Value;
            var price = product.mov_Price.Value;

            //line.mov_Total = (Money)(quantity * price);
            //localPluginContext.SystemUserService.Update(line);

            context.OutputParameters["mov_testapi_price"] = price;
            context.OutputParameters["mov_testapi_quantity"] = quantity;
            context.OutputParameters["mov_testapi_total"] = price * quantity;


        }
    }
}
