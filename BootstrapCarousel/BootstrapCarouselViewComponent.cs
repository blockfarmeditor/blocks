using BlockFarmEditor.Components.Blocks.BootstrapCarousel;
using BlockFarmEditor.RCL.Library.Attributes;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common;

[assembly: BlockFarmEditorBlock("blockfarmeditor.bootstrap-carousel", "Carousel", PropertiesType = typeof(BootstrapCarouselProperties), ViewComponentType = typeof(BootstrapCarouselViewComponent), Icon = "picture")]

namespace BlockFarmEditor.Components.Blocks.BootstrapCarousel
{
    public class BootstrapCarouselViewComponent(IUmbracoHelperAccessor umbracoHelperAccessor) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(BootstrapCarouselProperties properties)
        {
            List<IPublishedContent> carousels = new List<IPublishedContent>();
            if (!umbracoHelperAccessor.TryGetUmbracoHelper(out var helper))
            {
                return Content("");
            }


            foreach (var carousel in properties.Carousels) {
                var content = helper.Content(carousel.Unique);
                if(content == null)
                {
                    continue;
                }
                carousels.Add(content);
            }
            return View("~/Components/Blocks/BootstrapCarousel/BootstrapCarousel.cshtml", carousels);
        }
    }
}
