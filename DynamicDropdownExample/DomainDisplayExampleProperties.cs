using BlockFarmEditor.RCL.Library.Attributes;
using BlockFarmEditor.RCL.Models.BuilderModels;
using BlockFarmEditor.RCL.Models.ConfigModels;
using BlockFarmEditor.Umbraco.Models;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Services;

namespace BlockFarmEditor.Components.Blocks.DynamicDropdownExample
{
    public class DomainDisplayExampleProperties : IBuilderProperties
    {
        /// <summary>
        /// Represents a domain selection property for the dynamic dropdown example.
        /// Constants.PropertyEditors.Aliases.DropDownListFlexible returns either a string or an IEnumerable<string>.
        /// </summary>
        [BlockFarmEditorDataType("Dropdown", "Domain List")]
        [BlockFarmEditorDataTypeConfig(typeof(DomainDisplayExamplePropertiesConfig))]
        public string Domain { get; set; } = string.Empty;
    }

    /// <summary>
    /// Configuration for the DomainDisplayExampleProperties block.
    /// </summary>
    /// <param name="domainService"></param>
    public class DomainDisplayExamplePropertiesConfig(IDomainService domainService) : IBlockFarmEditorConfig
    {
        /// <summary>
        /// Asynchronously retrieves a list of domain items for the dropdown editor configuration.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<BlockFarmEditorConfigItem>> GetItems()
        {
            var domains = await domainService.GetAllAsync(false);
            return
            [
                new ()
                {
                    Alias = "items",
                    // Generate a list of name,value pairs for the dropdown items
                    Value = domains.Select(d => new DropdownEditorConfigItem(d.DomainName, d.DomainName))
                },
                new ()
                {
                    Alias = "multiple",
                    Value = false // Assuming single selection for this example
                }
            ];
        }
    }
}
