using BlockFarmEditor.Components.Blocks.ListGroup;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using BlockFarmEditor.RCL.Models.ConfigModels;
using BlockFarmEditor.Umbraco.Models;
using Umbraco.Cms.Core.Models.Blocks;

[assembly: BlockFarmEditorBlock("blockfarmeditor.bootstrap-list-group", "List Group", PropertiesType = typeof(ListGroupProperties), ViewPath = "~/Components/Blocks/ListGroup/ListGroup.cshtml", Icon = "list")]

namespace BlockFarmEditor.Components.Blocks.ListGroup
{
    public class ListGroupProperties : IBuilderProperties
    {
        [BlockFarmEditorDataType("Dropdown", "List Group Style")]
        [BlockFarmEditorDataTypeConfig(typeof(ListGroupStyleConfig))]
        public string ListGroupStyle { get; set; } = "";

        [BlockFarmEditorDataType("True/false", "Flush Style")]
        public bool FlushStyle { get; set; } = false;

        [BlockFarmEditorDataType("True/false", "Numbered")]
        public bool Numbered { get; set; } = false;

        [BlockFarmEditorDataType("True/false", "Horizontal")]
        public bool Horizontal { get; set; } = false;

        [BlockFarmEditorDataType("Multiple Text String", "List Items")]
        public IEnumerable<string> ListItems { get; set; } = [];
    }

    public class ListGroupStyleConfig : IBlockFarmEditorConfig
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
                        new("Small", "list-group-sm"),
                        new("Large", "list-group-lg")
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
