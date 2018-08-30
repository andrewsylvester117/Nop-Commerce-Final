using Nop.Core.Domain.Orders;
using Nop.Core.Domain.Shipping;
using Nop.Web.Models.Common;
using Nop.Web.Models.Order;

namespace Nop.Web.Factories
{
    /// <summary>
    /// Represents the interface of the order model factory
    /// </summary>
    public partial interface IThemeModelFactory
    {
		/// <summary>
		/// Prepare the customer theme list model
		/// </summary>
		/// <returns>Customer theme list model</returns>
		ThemeSelectorModel PrepareCustomerThemeModel(string currentTheme);
    }
}
