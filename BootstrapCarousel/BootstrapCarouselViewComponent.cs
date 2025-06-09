using BlockFarmEditor.Components.Blocks.BootstrapCarousel;
using BlockFarmEditor.RCL.Library.Attributes;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common;

[assembly: BlockFarmEditorBlock("blockfarmeditor.bootstrap-carousel", "Carousel", PropertiesType = typeof(BootstrapCarouselProperties), ViewComponentType = typeof(BootstrapCarouselViewComponent), Icon = "picture")]

namespace BlockFarmEditor.Components.Blocks.BootstrapCarousel
{
    public class BootstrapCarouselViewComponent(IUmbracoHelperAccessor umbracoHelperAccessor) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(BootstrapCarouselProperties properties)
        {
            if (!umbracoHelperAccessor.TryGetUmbracoHelper(out var helper))
            {
                return Content("");
            }

            IEnumerable<IPublishedContent> carousels = helper.Content(properties.Carousels.Select(x=>x.ToUdi()).ToArray());
            return View("~/Components/Blocks/BootstrapCarousel/BootstrapCarousel.cshtml", carousels);
        }
    }
}
