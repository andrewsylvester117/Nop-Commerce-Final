using Microsoft.AspNetCore.Mvc;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;

namespace Nop.Web.Components
{
    public class ThemeSelectorViewComponent : NopViewComponent
    {
        private readonly ICommonModelFactory _commonModelFactory;

        public ThemeSelectorViewComponent(ICommonModelFactory commonModelFactory)
        {
            this._commonModelFactory = commonModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            var model = _commonModelFactory.PrepareThemeSelectorModel("");

            if (model.AvaliableThemes.Count == 1)
                return Content("");
			
            return View(model);
        }
    }
}
