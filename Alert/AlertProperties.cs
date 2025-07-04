using BlockFarmEditor.Components.Blocks.Alert;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using BlockFarmEditor.RCL.Models.ConfigModels;
using BlockFarmEditor.Umbraco.Models;
using Umbraco.Cms.Core.Strings;

[assembly: BlockFarmEditorBlock("blockfarmeditor.bootstrap-alert", "Alert", PropertiesType = typeof(AlertProperties), ViewPath = "~/Components/Blocks/Alert/Alert.cshtml", Icon = "bell")]

namespace BlockFarmEditor.Components.Blocks.Alert
{
    public class AlertProperties : IBuilderProperties
    {
        [BlockFarmEditorDataType("Dropdown", "Alert Type")]
        [BlockFarmEditorDataTypeConfig(typeof(AlertTypeConfig))]
        public string AlertType { get; set; } = "primary";

        [BlockFarmEditorDataType("Textstring", "Title")]
        public string Title { get; set; } = string.Empty;

        [BlockFarmEditorDataType("Richtext editor", "Content")]
        public IHtmlEncodedString Content { get; set; } = new HtmlEncodedString(string.Empty);

        [BlockFarmEditorDataType("True/false", "Dismissible")]
        public bool Dismissible { get; set; } = false;
    }

    public class AlertTypeConfig : IBlockFarmEditorConfig
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
