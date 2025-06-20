using BlockFarmEditor.Components.Blocks.ProgressBar;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using BlockFarmEditor.RCL.Models.ConfigModels;
using BlockFarmEditor.Umbraco.Models;

[assembly: BlockFarmEditorBlock("blockfarmeditor.bootstrap-progress", "Progress Bar", PropertiesType = typeof(ProgressBarProperties), ViewPath = "~/Components/Blocks/ProgressBar/ProgressBar.cshtml", Icon = "loading")]

namespace BlockFarmEditor.Components.Blocks.ProgressBar
{
    public class ProgressBarProperties : IBuilderProperties
    {
        [BlockFarmEditorDataType("Decimal", "Progress Value")]
        public decimal ProgressValue { get; set; } = 0;

        [BlockFarmEditorDataType("Decimal", "Min Value")]
        public decimal MinValue { get; set; } = 0;

        [BlockFarmEditorDataType("Decimal", "Max Value")]
        public decimal MaxValue { get; set; } = 100;

        [BlockFarmEditorDataType("Textstring", "Label")]
        public string Label { get; set; } = string.Empty;

        [BlockFarmEditorDataType("Dropdown", "Progress Color")]
        [BlockFarmEditorDataTypeConfig(typeof(ProgressColorConfig))]
        public string ProgressColor { get; set; } = "";

        [BlockFarmEditorDataType("Checkbox", "Striped")]
        public bool Striped { get; set; } = false;

        [BlockFarmEditorDataType("Checkbox", "Animated")]
        public bool Animated { get; set; } = false;

        [BlockFarmEditorDataType("Textstring", "Height (e.g., 20px)")]
        public string Height { get; set; } = string.Empty;
    }

    public class ProgressColorConfig : IBlockFarmEditorConfig
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
                        new("Success", "bg-success"),
                        new("Info", "bg-info"),
                        new("Warning", "bg-warning"),
                        new("Danger", "bg-danger")
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
