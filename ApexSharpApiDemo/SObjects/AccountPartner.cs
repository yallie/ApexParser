namespace ApexSharpApiDemo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;

	public class AccountPartner : SObject
	{
		public string AccountFromId {set;get;}
		public Account AccountFrom {set;get;}
		public string AccountToId {set;get;}
		public Account AccountTo {set;get;}
		public string OpportunityId {set;get;}
		public Opportunity Opportunity {set;get;}
		public string Role {set;get;}
		public bool IsPrimary {set;get;}
		public DateTime CreatedDate {set;get;}
		public string CreatedById {set;get;}
		public User CreatedBy {set;get;}
		public DateTime LastModifiedDate {set;get;}
		public string LastModifiedById {set;get;}
		public User LastModifiedBy {set;get;}
		public DateTime SystemModstamp {set;get;}
		public bool IsDeleted {set;get;}
		public string ReversePartnerId {set;get;}
	}
}
