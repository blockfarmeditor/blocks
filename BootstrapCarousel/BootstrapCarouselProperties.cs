using BlockFarmEditor.Components.Blocks.BootstrapCarousel;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using BlockFarmEditor.Umbraco.Models;
using Umbraco.Cms.Core.Models.PublishedContent;

[assembly: BlockFarmEditorBlock("blockfarmeditor.bootstrap-carousel", "Carousel", PropertiesType = typeof(BootstrapCarouselProperties), ViewPath = "~/Components/Blocks/BootstrapCarousel/BootstrapCarousel.cshtml", Icon = "picture")]


namespace BlockFarmEditor.Components.Blocks.BootstrapCarousel
{
    public class BootstrapCarouselProperties : IBuilderProperties
    {
        [BlockFarmEditorDataType("Carousel Picker", "Carousels")]
        public IEnumerable<IPublishedContent> Carousels { get; set; } = [];
    }
}
