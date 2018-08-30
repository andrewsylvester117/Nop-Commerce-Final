using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Domain.Common;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Orders;
using Nop.Services.Common;
using Nop.Web.Factories;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;
using Nop.Web.Framework.Security;

namespace Nop.Web.Controllers
{
    public partial class ThemeController : BasePublicController
    {
        private readonly IThemeModelFactory _themeModelFactory;
		private readonly CommonSettings commonSettings;
        public ThemeController(IThemeModelFactory themeModelFactory, CommonSettings commonSettings)
        {
            this._themeModelFactory = themeModelFactory;
			this.commonSettings = commonSettings;
        }

        [HttpsRequirement(SslRequirement.Yes)]
        public virtual IActionResult CustomerTheme()
		{
			//String currentTheme = commonSettings.CurrentTheme;
			var model = _themeModelFactory.PrepareCustomerThemeModel("Dark");
			commonSettings.CurrentTheme = model.CurrentTheme;
            return View(model);
        }       
    }
}