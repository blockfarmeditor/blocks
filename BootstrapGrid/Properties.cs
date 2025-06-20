
using BlockFarmEditor.Blocks;
using BlockFarmEditor.Components.Blocks.DynamicDropdownExample;
using BlockFarmEditor.Components.TestingBlocks.BootstrapContainer;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using BlockFarmEditor.RCL.Models.ConfigModels;
using BlockFarmEditor.Umbraco.Models;
using System.Text.Json.Nodes;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;

[assembly: BlockFarmEditorContainer("blockfarmeditor.bootstrap-container", "Container", ViewPath = "~/Components/Blocks/BootstrapGrid/Container.cshtml", Icon = "folder", PropertiesType = typeof(ContainerProperties))]
[assembly: BlockFarmEditorContainer("blockfarmeditor.bootstrap-row", "Row", ViewPath = "~/Components/Blocks/BootstrapGrid/Row.cshtml", Icon = "folder", PropertiesType = typeof(RowProperties))]


namespace BlockFarmEditor.Components.TestingBlocks.BootstrapContainer
{
    public class ContainerProperties : IBuilderProperties
    {
        [BlockFarmEditorDataType("Dropdown", "Container")]
        [BlockFarmEditorDataTypeConfig(typeof(ContainerPropertiesConfig))]
        public string Container { get; set; } = string.Empty;
    }

    public class ContainerPropertiesConfig : IBlockFarmEditorConfig
    {
        public async Task<IEnumerable<BlockFarmEditorConfigItem>> GetItems()
        {
            return
            [
                new ()
                {
                    Alias = "items",
                    // Generate a list of name,value pairs for the dropdown items
                    Value =new List<DropdownEditorConfigItem>() {
                        new("Container", "container"),
                        new("Container Fluid", "container-fluid"),
                    }
                },
                new ()
                {
                    Alias = "multiple",
                    Value = false // Assuming single selection for this example
                }
            ];
        }
    }

    public class RowProperties : IBuilderProperties
    {
        [BlockFarmEditorDataType("BlockList", "Columns")]
        public BlockListModel Columns { get; set; } = new BlockListModel([]);
    }
}
