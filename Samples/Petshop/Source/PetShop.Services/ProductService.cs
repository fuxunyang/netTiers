﻿	

#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Data;

using PetShop.Business;
using PetShop.Business.Validation;

using PetShop.Data;
using Microsoft.Practices.EnterpriseLibrary.Logging;

#endregion

namespace PetShop.Services
{		
	/// <summary>
	/// An component type implementation of the 'Product' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ProductService : PetShop.Services.ProductServiceBase
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the ProductService class.
		/// </summary>
		public ProductService() : base()
		{
		}
		#endregion Constructors
		
	}//End Class

} // end namespace
