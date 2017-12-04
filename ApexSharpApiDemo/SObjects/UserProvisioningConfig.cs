namespace ApexSharpApiDemo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;

	public class UserProvisioningConfig : SObject
	{
		public bool IsDeleted {set;get;}
		public string DeveloperName {set;get;}
		public string Language {set;get;}
		public string MasterLabel {set;get;}
		public string NamespacePrefix {set;get;}
		public DateTime CreatedDate {set;get;}
		public string CreatedById {set;get;}
		public User CreatedBy {set;get;}
		public DateTime LastModifiedDate {set;get;}
		public string LastModifiedById {set;get;}
		public User LastModifiedBy {set;get;}
		public DateTime SystemModstamp {set;get;}
		public string ConnectedAppId {set;get;}
		public ConnectedApplication ConnectedApp {set;get;}
		public string Notes {set;get;}
		public bool Enabled {set;get;}
		public string ApprovalRequired {set;get;}
		public string UserAccountMapping {set;get;}
		public string EnabledOperations {set;get;}
		public string OnUpdateAttributes {set;get;}
		public DateTime LastReconDateTime {set;get;}
		public string NamedCredentialId {set;get;}
		public NamedCredential NamedCredential {set;get;}
		public string ReconFilter {set;get;}
	}
}
