
using BlockFarmEditor.Components.Blocks.BootstrapGrid;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using BlockFarmEditor.RCL.Models.ConfigModels;
using BlockFarmEditor.Umbraco.Models;
using Umbraco.Cms.Core.Models.Blocks;

[assembly: BlockFarmEditorContainer("blockfarmeditor.bootstrap-container", "Container", ViewPath = "~/Components/Blocks/BootstrapGrid/Container.cshtml", Icon = "folder", PropertiesType = typeof(ContainerProperties))]
[assembly: BlockFarmEditorContainer("blockfarmeditor.bootstrap-row", "Row", ViewPath = "~/Components/Blocks/BootstrapGrid/Row.cshtml", Icon = "folder", PropertiesType = typeof(RowProperties))]


namespace BlockFarmEditor.Components.Blocks.BootstrapGrid
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
        [BlockFarmEditorDataType("Dropdown", "Prefix")]
        [BlockFarmEditorDataTypeConfig(typeof(PrefixRowPropertiesConfig))]
        public string Prefix { get; set; } = "col-md";

        [BlockFarmEditorDataType("Bootstrap Grid Column Block List", "Columns")]
        public BlockListModel Columns { get; set; } = new BlockListModel([]);

        [BlockFarmEditorDataType("Dropdown", "Row Direction")]
        [BlockFarmEditorDataTypeConfig(typeof(DirectionRowPropertiesConfig))]
        public string RowDirection { get; set; } = string.Empty;

        [BlockFarmEditorDataType("Textsring", "Row Custom Class")]
        public string RowCustomCss { get; set; } = string.Empty;
    }

    public class PrefixRowPropertiesConfig : IBlockFarmEditorConfig
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
                        new("Extra Small (0px to 575px)", "col"),
                        new("Small (576px to 767px)", "col-sm"),
                        new("Medium (768px to 991px)", "col-md"),
                        new("Large (992px to 1199px)", "col-lg"),
                        new("Extra Large (1200px to 1399px)", "col-xl"),
                        new("Extra extra large (1400px)", "col-xxl")
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

    public class DirectionRowPropertiesConfig : IBlockFarmEditorConfig
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
                        new("Left to Right", ""),
                        new("Right to Left", "flex-row-reverse")
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
