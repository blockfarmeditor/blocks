using BlockFarmEditor.Components.Blocks.BootstrapCarousel;
using BlockFarmEditor.Components.Blocks.Card;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Strings;

[assembly: BlockFarmEditorBlock("blockfarmeditor.bootstrap-card", "Card", PropertiesType = typeof(CardProperties), ViewPath = "~/Components/Blocks/Card/Card.cshtml", Icon = "book")]

namespace BlockFarmEditor.Components.Blocks.Card
{
    public class CardProperties : IBuilderProperties
    {
        [BlockFarmEditorDataType("Textstring", "Header")]
        public string Header { get; set; } = string.Empty;

        [BlockFarmEditorDataType("Richtext editor", "Content")]
        public IHtmlEncodedString Description { get; set; } = new HtmlEncodedString(string.Empty);

        [BlockFarmEditorDataType("Image Media Picker", "Image ")]
        public MediaWithCrops? Image { get; set; }

        [BlockFarmEditorDataType("Multi URL Picker", "Url")]
        public IEnumerable<Link> ButtonUrl { get; set; } = [];
    }
}
