namespace ApexSharpApiDemo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;

	public class CategoryData : SObject
	{
		public string CategoryNodeId {set;get;}
		public string RelatedSobjectId {set;get;}
		public bool IsDeleted {set;get;}
		public DateTime CreatedDate {set;get;}
		public string CreatedById {set;get;}
		public User CreatedBy {set;get;}
		public DateTime LastModifiedDate {set;get;}
		public string LastModifiedById {set;get;}
		public User LastModifiedBy {set;get;}
		public DateTime SystemModstamp {set;get;}
	}
}
