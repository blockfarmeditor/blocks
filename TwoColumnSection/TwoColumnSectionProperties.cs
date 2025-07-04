using BlockFarmEditor.Blocks;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;

[assembly: BlockFarmEditorContainer("blockfarmeditor.section-2-columns", "2 Column Section", ViewPath = "~/Components/Blocks/TwoColumnSection/TwoColumnSection.cshtml", Icon = "columns-2", PropertiesType = typeof(TwoColumnSectionProperties))]


namespace BlockFarmEditor.Blocks
{
    public class TwoColumnSectionProperties : IBuilderProperties
    {
        //[BlockFarmEditorPropertyEditor(Constants.PropertyEditors.Aliases.RichText, "Rich Text")]
        //[BlockFarmEditorPropertyEditorConfig(typeof(RichTextEditorConfig))]
        [BlockFarmEditorDataType("Textstring", "Header")]
        public string Header { get; set; } = string.Empty;
    }
}
