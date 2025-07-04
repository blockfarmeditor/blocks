using BlockFarmEditor.Components.Blocks.Breadcrumb;
using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using Umbraco.Cms.Core.Models;

[assembly: BlockFarmEditorBlock("blockfarmeditor.bootstrap-breadcrumb", "Breadcrumb", PropertiesType = typeof(BreadcrumbProperties), ViewPath = "~/Components/Blocks/Breadcrumb/Breadcrumb.cshtml", Icon = "navigation")]

namespace BlockFarmEditor.Components.Blocks.Breadcrumb
{
    public class BreadcrumbProperties : IBuilderProperties
    {
        [BlockFarmEditorDataType("Multi URL Picker", "Breadcrumb Items")]
        public IEnumerable<Link> BreadcrumbItems { get; set; } = [];
    }
}
