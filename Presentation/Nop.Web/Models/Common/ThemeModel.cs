using Nop.Web.Framework.Models;

namespace Nop.Web.Models.Common
{
    public partial class ThemeModel : BaseNopEntityModel
    {

		public ThemeModel(string name)
		{
			this.Name = name;
		}
        public string Name { get; set; }
    }
}