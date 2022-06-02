/// <reference path="../node_modules/@types/xrm/index.d.ts" />
declare namespace Mov_invoiceEnum {
    const enum mov_destination {
        National = 865320000,
        International = 865320001,
    }

}

declare namespace Xrm {
    type Mov_invoice = Omit<FormContext, 'getAttribute'> & Omit<FormContext, 'getControl'> & Mov_invoiceAttributes;

    interface EventContext {
        getFormContext(): Mov_invoice;
    }

    interface Mov_invoiceAttributes {
        getAttribute(name: "createdby"): Attributes.LookupAttribute;
        getAttribute(name: "createdbyname"): Attributes.StringAttribute;
        getAttribute(name: "createdbyyominame"): Attributes.StringAttribute;
        getAttribute(name: "createdon"): Attributes.DateAttribute;
        getAttribute(name: "createdonbehalfby"): Attributes.LookupAttribute;
        getAttribute(name: "createdonbehalfbyname"): Attributes.StringAttribute;
        getAttribute(name: "createdonbehalfbyyominame"): Attributes.StringAttribute;
        getAttribute(name: "importsequencenumber"): Attributes.NumberAttribute;
        getAttribute(name: "modifiedby"): Attributes.LookupAttribute;
        getAttribute(name: "modifiedbyname"): Attributes.StringAttribute;
        getAttribute(name: "modifiedbyyominame"): Attributes.StringAttribute;
        getAttribute(name: "modifiedon"): Attributes.DateAttribute;
        getAttribute(name: "modifiedonbehalfby"): Attributes.LookupAttribute;
        getAttribute(name: "modifiedonbehalfbyname"): Attributes.StringAttribute;
        getAttribute(name: "modifiedonbehalfbyyominame"): Attributes.StringAttribute;
        getAttribute(name: "mov_costumer"): Attributes.LookupAttribute;
        getAttribute(name: "mov_costumerid"): Attributes.NumberAttribute;
        getAttribute(name: "mov_costumername"): Attributes.StringAttribute;
        getAttribute(name: "mov_destination"): Attributes.OptionSetAttribute;
        getAttribute(name: "mov_fraction"): Attributes.NumberAttribute;
        getAttribute(name: "mov_id"): Attributes.StringAttribute;
        getAttribute(name: "mov_interest"): Attributes.NumberAttribute;
        getAttribute(name: "mov_invoiceid"): Attributes.StringAttribute;
        getAttribute(name: "mov_paid"): Attributes.BooleanAttribute;
        getAttribute(name: "mov_placementdate"): Attributes.DateAttribute;
        getAttribute(name: "mov_prueba"): Attributes.StringAttribute;
        getAttribute(name: "mov_share"): Attributes.NumberAttribute;
        getAttribute(name: "mov_taxes"): Attributes.NumberAttribute;
        getAttribute(name: "mov_totalinvoice"): Attributes.NumberAttribute;
        getAttribute(name: "overriddencreatedon"): Attributes.DateAttribute;
        getAttribute(name: "ownerid"): Attributes.LookupAttribute;
        getAttribute(name: "owneridname"): Attributes.StringAttribute;
        getAttribute(name: "owneridtype"): Attributes.Attribute;
        getAttribute(name: "owneridyominame"): Attributes.StringAttribute;
        getAttribute(name: "owningbusinessunit"): Attributes.LookupAttribute;
        getAttribute(name: "owningbusinessunitname"): Attributes.StringAttribute;
        getAttribute(name: "owningteam"): Attributes.LookupAttribute;
        getAttribute(name: "owninguser"): Attributes.LookupAttribute;
        getAttribute(name: "statecode"): Attributes.OptionSetAttribute;
        getAttribute(name: "statuscode"): Attributes.OptionSetAttribute;
        getAttribute(name: "timezoneruleversionnumber"): Attributes.NumberAttribute;
        getAttribute(name: "utcconversiontimezonecode"): Attributes.NumberAttribute;
        getAttribute(name: "versionnumber"): Attributes.NumberAttribute;
        getControl(name: "createdby"): Controls.LookupControl;
        getControl(name: "createdbyname"): Controls.StringControl;
        getControl(name: "createdbyyominame"): Controls.StringControl;
        getControl(name: "createdon"): Controls.DateControl;
        getControl(name: "createdonbehalfby"): Controls.LookupControl;
        getControl(name: "createdonbehalfbyname"): Controls.StringControl;
        getControl(name: "createdonbehalfbyyominame"): Controls.StringControl;
        getControl(name: "importsequencenumber"): Controls.NumberControl;
        getControl(name: "modifiedby"): Controls.LookupControl;
        getControl(name: "modifiedbyname"): Controls.StringControl;
        getControl(name: "modifiedbyyominame"): Controls.StringControl;
        getControl(name: "modifiedon"): Controls.DateControl;
        getControl(name: "modifiedonbehalfby"): Controls.LookupControl;
        getControl(name: "modifiedonbehalfbyname"): Controls.StringControl;
        getControl(name: "modifiedonbehalfbyyominame"): Controls.StringControl;
        getControl(name: "mov_costumer"): Controls.LookupControl;
        getControl(name: "mov_costumerid"): Controls.NumberControl;
        getControl(name: "mov_costumername"): Controls.StringControl;
        getControl(name: "mov_destination"): Controls.OptionSetControl;
        getControl(name: "mov_fraction"): Controls.NumberControl;
        getControl(name: "mov_id"): Controls.StringControl;
        getControl(name: "mov_interest"): Controls.NumberControl;
        getControl(name: "mov_invoiceid"): Controls.StringControl;
        getControl(name: "mov_paid"): Controls.StandardControl;
        getControl(name: "mov_placementdate"): Controls.DateControl;
        getControl(name: "mov_prueba"): Controls.StringControl;
        getControl(name: "mov_share"): Controls.NumberControl;
        getControl(name: "mov_taxes"): Controls.NumberControl;
        getControl(name: "mov_totalinvoice"): Controls.NumberControl;
        getControl(name: "overriddencreatedon"): Controls.DateControl;
        getControl(name: "ownerid"): Controls.LookupControl;
        getControl(name: "owneridname"): Controls.StringControl;
        getControl(name: "owneridtype"): Controls.Control;
        getControl(name: "owneridyominame"): Controls.StringControl;
        getControl(name: "owningbusinessunit"): Controls.LookupControl;
        getControl(name: "owningbusinessunitname"): Controls.StringControl;
        getControl(name: "owningteam"): Controls.LookupControl;
        getControl(name: "owninguser"): Controls.LookupControl;
        getControl(name: "statecode"): Controls.OptionSetControl;
        getControl(name: "statuscode"): Controls.OptionSetControl;
        getControl(name: "timezoneruleversionnumber"): Controls.NumberControl;
        getControl(name: "utcconversiontimezonecode"): Controls.NumberControl;
        getControl(name: "versionnumber"): Controls.NumberControl;
    }

}

