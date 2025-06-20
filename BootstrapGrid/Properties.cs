
using BlockFarmEditor.Blocks;
using BlockFarmEditor.Components.Blocks.DynamicDropdownExample;
using BlockFarmEditor.Components.TestingBlocks.BootstrapContainer;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using BlockFarmEditor.RCL.Models.ConfigModels;
using BlockFarmEditor.Umbraco.Models;
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
        [BlockFarmEditorPropertyEditor(Constants.PropertyEditors.Aliases.DropDownListFlexible, "Container")]
        [BlockFarmEditorPropertyEditorConfig(typeof(ContainerPropertiesConfig))]
        public IEnumerable<string> Container { get; set; } = [];
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
        //[BlockFarmEditorPropertyEditor(Constants.PropertyEditors.Aliases.BlockList, "Columns")]
        //[BlockFarmEditorPropertyEditorConfig(typeof(RowPropertiesConfig))]
        [BlockFarmEditorDataType("BootstrapColumnDataType", "Columns")]
        public BlockListModel Columns { get; set; } = new BlockListModel([]);
    }

    public class RowPropertiesConfig : IBlockFarmEditorConfig
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
}
