
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// Created via this command line: "C:\Users\sandrapilarperez\AppData\Roaming\MscrmTools\XrmToolBox\Plugins\DLaB.EarlyBoundGenerator\crmsvcutil.exe" /url:"https://orgbbb84f69.api.crm4.dynamics.com" /namespace:"CrmEarlyBound" /SuppressGeneratedCodeAttribute /out:"C:\Users\sandrapilarperez\AppData\Roaming\MscrmTools\XrmToolBox\Settings\EBG\OptionSets.cs" /codecustomization:"DLaB.CrmSvcUtilExtensions.OptionSet.CustomizeCodeDomService,DLaB.CrmSvcUtilExtensions" /codegenerationservice:"DLaB.CrmSvcUtilExtensions.OptionSet.CustomCodeGenerationService,DLaB.CrmSvcUtilExtensions" /codewriterfilter:"DLaB.CrmSvcUtilExtensions.OptionSet.CodeWriterFilterService,DLaB.CrmSvcUtilExtensions" /namingservice:"DLaB.CrmSvcUtilExtensions.NamingService,DLaB.CrmSvcUtilExtensions" /metadataproviderservice:"DLaB.CrmSvcUtilExtensions.BaseMetadataProviderService,DLaB.CrmSvcUtilExtensions" 
//------------------------------------------------------------------------------

namespace CrmEarlyBound
{
	
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum mov_Costumer_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 0)]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Inactive", 1)]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum mov_Destination
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("International", 1)]
		International = 865320001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("National", 0)]
		National = 865320000,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum mov_Invoice_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 0)]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Inactive", 1)]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum mov_Line_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 0)]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Inactive", 1)]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum mov_Product_StatusCode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Active", 0)]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Inactive", 1)]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum appaction_ClientType
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Browser", 0, "#0000ff")]
		Browser = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Mobile", 1, "#0000ff")]
		Mobile = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Mail App", 2, "#0000ff")]
		MailApp = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum msdyn_knowledgemanagementsetting_msdyn_actionlist
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Link / unlink article", 0, "#0000ff")]
		Linkunlinkarticle = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Copy URL", 1, "#0000ff")]
		CopyURL = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Link article and email URL", 2, "#0000ff")]
		LinkarticleandemailURL = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Link article and send article content", 3, "#0000ff")]
		Linkarticleandsendarticlecontent = 3,
	}
}
