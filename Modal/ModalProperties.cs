using BlockFarmEditor.Components.Blocks.Modal;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using BlockFarmEditor.RCL.Models.ConfigModels;
using BlockFarmEditor.Umbraco.Models;
using Umbraco.Cms.Core.Strings;

[assembly: BlockFarmEditorBlock("blockfarmeditor.bootstrap-modal", "Modal", PropertiesType = typeof(ModalProperties), ViewPath = "~/Components/Blocks/Modal/Modal.cshtml", Icon = "box")]

namespace BlockFarmEditor.Components.Blocks.Modal
{
    public class ModalProperties : IBuilderProperties
    {
        [BlockFarmEditorDataType("Textstring", "Modal ID")]
        public string ModalId { get; set; } = Guid.NewGuid().ToString("N")[..8];

        [BlockFarmEditorDataType("Textstring", "Trigger Button Text")]
        public string TriggerButtonText { get; set; } = "Open Modal";

        [BlockFarmEditorDataType("Dropdown", "Trigger Button Style")]
        [BlockFarmEditorDataTypeConfig(typeof(ButtonStyleConfig))]
        public string TriggerButtonStyle { get; set; } = "btn-primary";

        [BlockFarmEditorDataType("Textstring", "Modal Title")]
        public string ModalTitle { get; set; } = string.Empty;

        [BlockFarmEditorDataType("Richtext editor", "Modal Content")]
        public IHtmlEncodedString ModalContent { get; set; } = new HtmlEncodedString(string.Empty);

        [BlockFarmEditorDataType("Dropdown", "Modal Size")]
        [BlockFarmEditorDataTypeConfig(typeof(ModalSizeConfig))]
        public string ModalSize { get; set; } = "";

        [BlockFarmEditorDataType("Checkbox", "Centered")]
        public bool Centered { get; set; } = false;

        [BlockFarmEditorDataType("Checkbox", "Scrollable")]
        public bool Scrollable { get; set; } = false;

        [BlockFarmEditorDataType("Checkbox", "Static Backdrop")]
        public bool StaticBackdrop { get; set; } = false;
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

    public class ModalSizeConfig : IBlockFarmEditorConfig
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
                        new("Small", "modal-sm"),
                        new("Large", "modal-lg"),
                        new("Extra Large", "modal-xl"),
                        new("Full Screen", "modal-fullscreen")
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
