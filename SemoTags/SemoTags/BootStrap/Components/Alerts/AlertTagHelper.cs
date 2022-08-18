 

using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.Components.Alerts
{
    public class AlertTagHelper:TagHelper
    {
        public ColorType AlertType { get; set; }
        
       
        

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var builder = new AlertBuilder();
             output.Attributes.Add("class", $"badge    text-bg-{builder.GetAlertType(AlertType)}");

        }
    }
}
