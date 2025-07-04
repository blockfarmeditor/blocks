using BlockFarmEditor.Components.Blocks.BootstrapCarousel;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using BlockFarmEditor.Umbraco.Models;
using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.Models.PublishedContent;

[assembly: BlockFarmEditorBlock("blockfarmeditor.bootstrap-carousel", "Carousel", PropertiesType = typeof(BootstrapCarouselProperties), ViewPath = "~/Components/Blocks/BootstrapCarousel/BootstrapCarousel.cshtml", Icon = "slideshow")]


namespace BlockFarmEditor.Components.Blocks.BootstrapCarousel
{
    public class BootstrapCarouselProperties : IBuilderProperties
    {
        [BlockFarmEditorDataType("Bootstrap Carousel Content Picker", "Carousels")]
        public IEnumerable<IPublishedContent> Carousels { get; set; } = [];
    }
}
