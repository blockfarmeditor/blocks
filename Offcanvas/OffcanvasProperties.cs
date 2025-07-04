using BlockFarmEditor.Components.Blocks.Offcanvas;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using BlockFarmEditor.RCL.Models.ConfigModels;
using BlockFarmEditor.Umbraco.Models;
using Umbraco.Cms.Core.Strings;

[assembly: BlockFarmEditorBlock("blockfarmeditor.bootstrap-offcanvas", "Offcanvas", PropertiesType = typeof(OffcanvasProperties), ViewPath = "~/Components/Blocks/Offcanvas/Offcanvas.cshtml", Icon = "outdent")]

namespace BlockFarmEditor.Components.Blocks.Offcanvas
{
    public class OffcanvasProperties : IBuilderProperties
    {
        [BlockFarmEditorDataType("Textstring", "Offcanvas ID")]
        public string OffcanvasId { get; set; } = Guid.NewGuid().ToString("N")[..8];

        [BlockFarmEditorDataType("Textstring", "Trigger Button Text")]
        public string TriggerButtonText { get; set; } = "Open Offcanvas";

        [BlockFarmEditorDataType("Dropdown", "Trigger Button Style")]
        [BlockFarmEditorDataTypeConfig(typeof(ButtonStyleConfig))]
        public string TriggerButtonStyle { get; set; } = "btn-primary";

        [BlockFarmEditorDataType("Textstring", "Offcanvas Title")]
        public string OffcanvasTitle { get; set; } = string.Empty;

        [BlockFarmEditorDataType("Richtext editor", "Offcanvas Content")]
        public IHtmlEncodedString OffcanvasContent { get; set; } = new HtmlEncodedString(string.Empty);

        [BlockFarmEditorDataType("Dropdown", "Placement")]
        [BlockFarmEditorDataTypeConfig(typeof(PlacementConfig))]
        public string Placement { get; set; } = "offcanvas-start";

        [BlockFarmEditorDataType("True/false", "Backdrop")]
        public bool Backdrop { get; set; } = true;

        [BlockFarmEditorDataType("True/false", "Keyboard")]
        public bool Keyboard { get; set; } = true;

        [BlockFarmEditorDataType("True/false", "Scroll")]
        public bool Scroll { get; set; } = false;
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

    public class PlacementConfig : IBlockFarmEditorConfig
    {
        public async Task<IEnumerable<BlockFarmEditorConfigItem>> GetItems()
        {
            return
            [
                new ()
                {
                    Alias = "items",
                    Value = new List<DropdownEditorConfigItem>() {
                        new("Start (Left)", "offcanvas-start"),
                        new("End (Right)", "offcanvas-end"),
                        new("Top", "offcanvas-top"),
                        new("Bottom", "offcanvas-bottom")
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
