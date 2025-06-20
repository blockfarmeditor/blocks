using BlockFarmEditor.Components.Blocks.Toast;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using BlockFarmEditor.RCL.Models.ConfigModels;
using BlockFarmEditor.Umbraco.Models;
using Umbraco.Cms.Core.Strings;

[assembly: BlockFarmEditorBlock("blockfarmeditor.bootstrap-toast", "Toast", PropertiesType = typeof(ToastProperties), ViewPath = "~/Components/Blocks/Toast/Toast.cshtml", Icon = "chat")]

namespace BlockFarmEditor.Components.Blocks.Toast
{
    public class ToastProperties : IBuilderProperties
    {
        [BlockFarmEditorDataType("Textstring", "Toast ID")]
        public string ToastId { get; set; } = Guid.NewGuid().ToString("N")[..8];

        [BlockFarmEditorDataType("Textstring", "Header Title")]
        public string HeaderTitle { get; set; } = string.Empty;

        [BlockFarmEditorDataType("Textstring", "Header Subtitle")]
        public string HeaderSubtitle { get; set; } = string.Empty;

        [BlockFarmEditorDataType("Richtext editor", "Toast Content")]
        public IHtmlEncodedString ToastContent { get; set; } = new HtmlEncodedString(string.Empty);

        [BlockFarmEditorDataType("Dropdown", "Toast Color")]
        [BlockFarmEditorDataTypeConfig(typeof(ToastColorConfig))]
        public string ToastColor { get; set; } = "";

        [BlockFarmEditorDataType("Checkbox", "Auto Hide")]
        public bool AutoHide { get; set; } = true;

        [BlockFarmEditorDataType("Integer", "Delay (milliseconds)")]
        public int Delay { get; set; } = 5000;

        [BlockFarmEditorDataType("Textstring", "Trigger Button Text")]
        public string TriggerButtonText { get; set; } = "Show Toast";
    }

    public class ToastColorConfig : IBlockFarmEditorConfig
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
                        new("Primary", "text-bg-primary"),
                        new("Secondary", "text-bg-secondary"),
                        new("Success", "text-bg-success"),
                        new("Danger", "text-bg-danger"),
                        new("Warning", "text-bg-warning"),
                        new("Info", "text-bg-info"),
                        new("Light", "text-bg-light"),
                        new("Dark", "text-bg-dark")
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
