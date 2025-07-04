using BlockFarmEditor.Components.Blocks.Collapse;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using BlockFarmEditor.RCL.Models.ConfigModels;
using BlockFarmEditor.Umbraco.Models;
using Umbraco.Cms.Core.Strings;

[assembly: BlockFarmEditorBlock("blockfarmeditor.bootstrap-collapse", "Collapse", PropertiesType = typeof(CollapseProperties), ViewPath = "~/Components/Blocks/Collapse/Collapse.cshtml", Icon = "page-down")]

namespace BlockFarmEditor.Components.Blocks.Collapse
{
    public class CollapseProperties : IBuilderProperties
    {
        [BlockFarmEditorDataType("Textstring", "Collapse ID")]
        public string CollapseId { get; set; } = Guid.NewGuid().ToString("N")[..8];

        [BlockFarmEditorDataType("Textstring", "Trigger Button Text")]
        public string TriggerButtonText { get; set; } = "Toggle Collapse";

        [BlockFarmEditorDataType("Dropdown", "Trigger Button Style")]
        [BlockFarmEditorDataTypeConfig(typeof(ButtonStyleConfig))]
        public string TriggerButtonStyle { get; set; } = "btn-primary";

        [BlockFarmEditorDataType("Richtext editor", "Collapse Content")]
        public IHtmlEncodedString CollapseContent { get; set; } = new HtmlEncodedString(string.Empty);

        [BlockFarmEditorDataType("True/false", "Show by Default")]
        public bool ShowByDefault { get; set; } = false;

        [BlockFarmEditorDataType("True/false", "Horizontal Collapse")]
        public bool HorizontalCollapse { get; set; } = false;
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
                        new("Primary", "btn-primary"),
                        new("Secondary", "btn-secondary"),
                        new("Success", "btn-success"),
                        new("Danger", "btn-danger"),
                        new("Warning", "btn-warning"),
                        new("Info", "btn-info"),
                        new("Light", "btn-light"),
                        new("Dark", "btn-dark"),
                        new("Link", "btn-link")
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
