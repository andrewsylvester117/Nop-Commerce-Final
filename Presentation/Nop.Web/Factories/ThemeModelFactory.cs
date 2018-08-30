using System;
using System.Collections.Generic;
using System.Linq;
using Nop.Core;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Common;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Orders;
using Nop.Core.Domain.Shipping;
using Nop.Core.Domain.Tax;
using Nop.Core.Domain.Vendors;
using Nop.Services.Catalog;
using Nop.Services.Directory;
using Nop.Services.Helpers;
using Nop.Services.Localization;
using Nop.Services.Media;
using Nop.Services.Orders;
using Nop.Services.Payments;
using Nop.Services.Seo;
using Nop.Services.Shipping;
using Nop.Services.Vendors;
using Nop.Web.Models.Common;
using Nop.Web.Models.Order;

namespace Nop.Web.Factories
{
    /// <summary>
    /// Represents the order model factory
    /// </summary>
    public partial class ThemeModelFactory : IThemeModelFactory
    {
		private readonly ICommonModelFactory _commonModelFactory;
		private String Theme { get; set; }

		public ThemeSelectorModel PrepareCustomerThemeModel(String currentTheme)
		{
			var model = _commonModelFactory.PrepareThemeSelectorModel(currentTheme);
			return model;
		}


		#region Ctor

		public ThemeModelFactory(ICommonModelFactory commonModelFactory)
		{
			this._commonModelFactory = commonModelFactory;
		}

        #endregion

        #region Methods

		#endregion
	}
}