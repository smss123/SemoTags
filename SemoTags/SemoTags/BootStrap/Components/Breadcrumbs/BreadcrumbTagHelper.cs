 
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;

namespace SemoTags.BootStrap.Components.Breadcrumbs
{
    public class BreadcrumbTagHelper:TagHelper
    {
        public Controller Controller { get; set; }
        public List<BreadcrumbItem> Items { get; set; } = new List<BreadcrumbItem>();
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (Controller == null)
                throw new ArgumentException("please specify the context controller");
            AutoFill();
            output.PostContent.Append("<ol class='breadcrumb'>");
            var html = "";
            foreach (var item in Items)
            {
                html += $"<li class='breadcrumb-item'>" +
                        $"<a href='{item.Url}'>{item.Name}</a></li>";
            }
            output.Content.SetHtmlContent(html);
            output.PostContent.Append("</ol>");
        }

        private void AutoFill()
        {
            if (Items.Count == 0)
            {
                var routeValues = Controller.HttpContext.GetRouteData().Values;
                if (routeValues.ContainsKey("controller"))
                    Items.Add(new BreadcrumbItem { Name = routeValues["controller"].ToString() });

                if (routeValues.ContainsKey("action"))
                    Items.Add(new BreadcrumbItem() { Name = routeValues.ContainsKey("action").ToString() });
            }
        }
    }
}
