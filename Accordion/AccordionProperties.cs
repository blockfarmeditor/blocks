using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using Umbraco.Cms.Core.Models.Blocks;
using BlockFarmEditor.Components.Blocks.Accordion;

[assembly: BlockFarmEditorBlock("blockfarmeditor.bootstrap-accordion", "Accordion", PropertiesType = typeof(AccordionProperties), ViewPath = "~/Components/Blocks/Accordion/Accordion.cshtml", Icon = "pannel-close")]

namespace BlockFarmEditor.Components.Blocks.Accordion
{
    /// <summary>
    /// Represents the properties for the Accordion block in BlockFarmEditor.
    /// Accordion Items can be a Element Type with the fields ShowByDefault, Header, and Content.
    /// </summary>
    public class AccordionProperties : IBuilderProperties
    {
        [BlockFarmEditorDataType("Checkbox", "Flush Style")]
        public bool FlushStyle { get; set; } = false;

        [BlockFarmEditorDataType("Bootstrap Accordion Block List", "Accordion Items")]
        public BlockListModel AccordionItems { get; set; } = new BlockListModel([]);
    }
}
 