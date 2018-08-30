using System.Collections.Generic;
using Nop.Web.Framework.Models;

namespace Nop.Web.Models.Common
{
    public partial class ThemeSelectorModel : BaseNopModel
    {
        public ThemeSelectorModel(string currentTheme)
        {
            AvaliableThemes = new List<ThemeModel>();
			CurrentTheme = currentTheme;
        }

        public List<ThemeModel> AvaliableThemes { get; set; }

        public string CurrentTheme { get; set; }

		public string ChangeTheme(string currentTheme) { 
			if(currentTheme.Equals("Light") || string.IsNullOrEmpty(currentTheme))
			{
				this.CurrentTheme = "Dark";
			}
			else if (currentTheme.Equals("Dark"))
			{
				this.CurrentTheme.Equals("Light");
			}
			
			return this.CurrentTheme;
		}
    }
}