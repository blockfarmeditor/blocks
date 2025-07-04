using BlockFarmEditor.Components.Blocks.Button;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using BlockFarmEditor.RCL.Models.ConfigModels;
using BlockFarmEditor.Umbraco.Models;
using Umbraco.Cms.Core.Models;

[assembly: BlockFarmEditorBlock("blockfarmeditor.bootstrap-button", "Button", PropertiesType = typeof(ButtonProperties), ViewPath = "~/Components/Blocks/Button/Button.cshtml", Icon = "hand-pointer")]

namespace BlockFarmEditor.Components.Blocks.Button
{
    public class ButtonProperties : IBuilderProperties
    {
        [BlockFarmEditorDataType("Textstring", "Button Text")]
        public string ButtonText { get; set; } = string.Empty;

        [BlockFarmEditorDataType("Multi URL Picker", "Button Link")]
        public IEnumerable<Link> ButtonLink { get; set; } = [];

        [BlockFarmEditorDataType("Dropdown", "Button Style")]
        [BlockFarmEditorDataTypeConfig(typeof(ButtonStyleConfig))]
        public string ButtonStyle { get; set; } = "btn-primary";

        [BlockFarmEditorDataType("Dropdown", "Button Size")]
        [BlockFarmEditorDataTypeConfig(typeof(ButtonSizeConfig))]
        public string ButtonSize { get; set; } = "";

        [BlockFarmEditorDataType("Checkbox", "Outline Style")]
        public bool OutlineStyle { get; set; } = false;

        [BlockFarmEditorDataType("Checkbox", "Block Button")]
        public bool BlockButton { get; set; } = false;
    }

    public class ButtonStyleConfig : IBlockFarmEditorConfig
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
                        new("Dark", "dark"),
                        new("Link", "link")
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

    public class ButtonSizeConfig : IBlockFarmEditorConfig
    {
        public async Task<IEnumerable<BlockFarmEditorConfigItem>> GetItems()
        {
            return
            [
                new ()
                {
                    Alias = "items",
                    Value = new List<DropdownEditorConfigItem>() {
                        new("Normal", ""),
                        new("Large", "btn-lg"),
                        new("Small", "btn-sm")
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
