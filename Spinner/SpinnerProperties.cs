using BlockFarmEditor.Components.Blocks.Spinner;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using BlockFarmEditor.RCL.Models.ConfigModels;
using BlockFarmEditor.Umbraco.Models;

[assembly: BlockFarmEditorBlock("blockfarmeditor.bootstrap-spinner", "Spinner", PropertiesType = typeof(SpinnerProperties), ViewPath = "~/Components/Blocks/Spinner/Spinner.cshtml", Icon = "loading")]

namespace BlockFarmEditor.Components.Blocks.Spinner
{
    public class SpinnerProperties : IBuilderProperties
    {
        [BlockFarmEditorDataType("Dropdown", "Spinner Type")]
        [BlockFarmEditorDataTypeConfig(typeof(SpinnerTypeConfig))]
        public string SpinnerType { get; set; } = "spinner-border";

        [BlockFarmEditorDataType("Dropdown", "Spinner Color")]
        [BlockFarmEditorDataTypeConfig(typeof(SpinnerColorConfig))]
        public string SpinnerColor { get; set; } = "";

        [BlockFarmEditorDataType("Dropdown", "Spinner Size")]
        [BlockFarmEditorDataTypeConfig(typeof(SpinnerSizeConfig))]
        public string SpinnerSize { get; set; } = "";

        [BlockFarmEditorDataType("Textstring", "Screen Reader Text")]
        public string ScreenReaderText { get; set; } = "Loading...";
    }

    public class SpinnerTypeConfig : IBlockFarmEditorConfig
    {
        public async Task<IEnumerable<BlockFarmEditorConfigItem>> GetItems()
        {
            return
            [
                new ()
                {
                    Alias = "items",
                    Value = new List<DropdownEditorConfigItem>() {
                        new("Border", "spinner-border"),
                        new("Grow", "spinner-grow")
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

    public class SpinnerColorConfig : IBlockFarmEditorConfig
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
                        new("Primary", "text-primary"),
                        new("Secondary", "text-secondary"),
                        new("Success", "text-success"),
                        new("Danger", "text-danger"),
                        new("Warning", "text-warning"),
                        new("Info", "text-info"),
                        new("Light", "text-light"),
                        new("Dark", "text-dark")
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

    public class SpinnerSizeConfig : IBlockFarmEditorConfig
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
                        new("Small", "spinner-border-sm"),
                        new("Small Grow", "spinner-grow-sm")
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
