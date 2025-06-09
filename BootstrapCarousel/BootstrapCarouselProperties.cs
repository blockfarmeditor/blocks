using BlockFarmEditor.Components.Blocks.BootstrapCarousel;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using BlockFarmEditor.Umbraco.Models;
using Umbraco.Cms.Core.Models.PublishedContent;



namespace BlockFarmEditor.Components.Blocks.BootstrapCarousel
{
    public class BootstrapCarouselProperties : IBuilderProperties
    {
        [BlockFarmEditorDataType("Carousel Picker", "Carousels")]
        public IEnumerable<BlockFarmEditorPickerItem> Carousels { get; set; } = [];
    }
}
