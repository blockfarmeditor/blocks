using BlockFarmEditor.Components.Blocks.Badge;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using BlockFarmEditor.RCL.Models.ConfigModels;
using BlockFarmEditor.Umbraco.Models;

[assembly: BlockFarmEditorBlock("blockfarmeditor.bootstrap-badge", "Badge", PropertiesType = typeof(BadgeProperties), ViewPath = "~/Components/Blocks/Badge/Badge.cshtml", Icon = "award")]

namespace BlockFarmEditor.Components.Blocks.Badge
{
    public class BadgeProperties : IBuilderProperties
    {
        [BlockFarmEditorDataType("Textstring", "Badge Text")]
        public string BadgeText { get; set; } = string.Empty;

        [BlockFarmEditorDataType("Dropdown", "Badge Color")]
        [BlockFarmEditorDataTypeConfig(typeof(BadgeColorConfig))]
        public string BadgeColor { get; set; } = "primary";

        [BlockFarmEditorDataType("Checkbox", "Rounded Pill")]
        public bool RoundedPill { get; set; } = false;
    }

    public class BadgeColorConfig : IBlockFarmEditorConfig
    {
        public async Task<IEnumerable<BlockFarmEditorConfigItem>> GetItems()
        {
            return
            [
                new ()
                {
                    Alias = "items",
                    Value = new List<DropdownEditorConfigItem>() {
                        new("Primary", "primary"),
                        new("Secondary", "secondary"),
                        new("Success", "success"),
                        new("Danger", "danger"),
                        new("Warning", "warning"),
                        new("Info", "info"),
                        new("Light", "light"),
                        new("Dark", "dark")
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
