namespace ApexSharpApiDemo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;

	public class OrderItemHistory : SObject
	{
		public bool IsDeleted {set;get;}
		public string OrderItemId {set;get;}
		public OrderItem OrderItem {set;get;}
		public string CreatedById {set;get;}
		public User CreatedBy {set;get;}
		public DateTime CreatedDate {set;get;}
		public string Field {set;get;}
		public object OldValue {set;get;}
		public object NewValue {set;get;}
	}
}
