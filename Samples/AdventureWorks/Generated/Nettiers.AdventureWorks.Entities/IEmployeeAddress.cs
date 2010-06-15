﻿using System;
using System.ComponentModel;

namespace Nettiers.AdventureWorks.Entities
{
	/// <summary>
	///		The data structure representation of the 'EmployeeAddress' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IEmployeeAddress 
	{
		/// <summary>			
		/// EmployeeID : Primary key. Foreign key to Employee.EmployeeID.
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "EmployeeAddress"</remarks>
		System.Int32 EmployeeId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalEmployeeId { get; set; }
			
		/// <summary>			
		/// AddressID : Primary key. Foreign key to Address.AddressID.
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "EmployeeAddress"</remarks>
		System.Int32 AddressId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalAddressId { get; set; }
			
		
		
		/// <summary>
		/// rowguid : ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
		/// </summary>
		System.Guid  Rowguid  { get; set; }
		
		/// <summary>
		/// ModifiedDate : Date and time the record was last updated.
		/// </summary>
		System.DateTime  ModifiedDate  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

