using BlockFarmEditor.Blocks;
using BlockFarmEditor.Components.Blocks.DynamicDropdownExample;
using BlockFarmEditor.RCL.Library.Attributes;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Services;

[assembly: BlockFarmEditorBlock("blockfarmeditor.domain-display", "Domain Display", ViewComponentType = typeof(DomainDisplayViewComponent), Icon = "wand", PropertiesType = typeof(DomainDisplayExampleProperties))]

namespace BlockFarmEditor.Components.Blocks.DynamicDropdownExample
{
    public class DomainDisplayViewComponent(IDomainService domainService) : ViewComponent
    {
        /// <summary>
        /// Invokes the view component asynchronously with the provided properties.
        /// </summary>
        /// <param name="properties"></param>
        /// <returns></returns>
        public async Task<IViewComponentResult> InvokeAsync(DomainDisplayExampleProperties properties)
        {
            if (properties.Domain == null || !properties.Domain.Any())
            {
                return Content("Domain not selected");
            }

            var domain = domainService.GetByName(properties.Domain.FirstOrDefault());
            if (domain == null)
            {
                return Content("Domain not found");
            }
            // Return the view with the properties
            return View("~/Components/Blocks/DynamicDropdownExample/DomainDisplayExample.cshtml", domain);
        }
    }
}
