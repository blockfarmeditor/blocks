using BlockFarmEditor.Components.Blocks.Tabs;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using BlockFarmEditor.RCL.Models.ConfigModels;
using BlockFarmEditor.Umbraco.Models;
using Umbraco.Cms.Core.Models.Blocks;

[assembly: BlockFarmEditorBlock("blockfarmeditor.bootstrap-tabs", "Tabs", PropertiesType = typeof(TabsProperties), ViewPath = "~/Components/Blocks/Tabs/Tabs.cshtml", Icon = "browser-window-menu")]

namespace BlockFarmEditor.Components.Blocks.Tabs
{
    public class TabsProperties : IBuilderProperties
    {
        [BlockFarmEditorDataType("Textstring", "Tabs ID")]
        public string TabsId { get; set; } = Guid.NewGuid().ToString("N")[..8];

        [BlockFarmEditorDataType("Dropdown", "Tab Style")]
        [BlockFarmEditorDataTypeConfig(typeof(TabStyleConfig))]
        public string TabStyle { get; set; } = "nav-tabs";

        [BlockFarmEditorDataType("Dropdown", "Justification")]
        [BlockFarmEditorDataTypeConfig(typeof(JustificationConfig))]
        public string Justification { get; set; } = "";

        [BlockFarmEditorDataType("Checkbox", "Fill Available Space")]
        public bool FillSpace { get; set; } = false;

        [BlockFarmEditorDataType("BlockList", "Tab Items")]
        public BlockListModel TabItems { get; set; } = new BlockListModel([]);
    }

    public class TabStyleConfig : IBlockFarmEditorConfig
    {
        public async Task<IEnumerable<BlockFarmEditorConfigItem>> GetItems()
        {
            return
            [
                new ()
                {
                    Alias = "items",
                    Value = new List<DropdownEditorConfigItem>() {
                        new("Tabs", "nav-tabs"),
                        new("Pills", "nav-pills"),
                        new("Underline", "nav-underline")
                    }
                },
                new ()
                {
                    Alias = "multiple",
                    Value = false
                }
            ];
        }
    }

    public class JustificationConfig : IBlockFarmEditorConfig
    {
        public async Task<IEnumerable<BlockFarmEditorConfigItem>> GetItems()
        {
            return
            [
                new ()
                {
                    Alias = "items",
                    Value = new List<DropdownEditorConfigItem>() {
                        new("Default", ""),
                        new("Center", "justify-content-center"),
                        new("End", "justify-content-end")
                    }
                },
                new ()
                {
                    Alias = "multiple",
                    Value = false
                }
            ];
        }
    }
}
