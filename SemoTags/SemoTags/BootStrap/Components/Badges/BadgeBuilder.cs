using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SemoTags.BootStrap.Components.Alerts;

namespace SemoTags.BootStrap.Components.Badges;

public class BadgeBuilder
{
    public string GetBadgeType(ColorType type)
    {
        switch (type)
        {

            case ColorType.Primary:
                return "primary";
            case ColorType.Secondary:
                return "secondary";
            case ColorType.Success:
                return "success";
            case ColorType.Danger:
                return "danger";
            case ColorType.Warning:
                return "warning";
            case ColorType.Info:
                return "info";
            case ColorType.Light:
                return "light";
            case ColorType.Dark:
                return "dark";
            default:
                return "primary";
        }
    }

    public void BuildDefault(TagHelperOutput output, ColorType type)
    {
        output.TagName = "span";
        output.Attributes.Add("class", $"badge  bg-{this.GetBadgeType(type)}");
    }

    //<button type = "button" class="btn btn-primary">
    //    Notifications<span class="badge text-bg-secondary">4</span>
    //    </button
    
    public async Task BuildNotification(TagHelperOutput output, ColorType type,string badge)
    {
        output.TagName = "div";
        output.Attributes.Add("class",$"btn btn btn-${type}");
        var content =( await output.GetChildContentAsync()).GetContent();
        IHtmlContent c = new HtmlString(content += $"<span class='badge text-bg-secondary'>{badge}</span>");
        output.Content.SetHtmlContent(c);
        

    }

    public async Task BuildPositioned(TagHelperOutput output, string? href, ColorType type,PositionedArg options)
    {

        output.TagName = "a";
        if (href != null || !string.IsNullOrEmpty(href))
            output.Attributes.Add("href", href);
        output.Attributes.Add("class", $"btn btn-{GetBadgeType(type)}");
        var content = (await output.GetChildContentAsync()).GetContent();
        IHtmlContent c = new HtmlString(content += $"<span class='position-absolute top-0 start-100 translate-middle badge rounded-pill bg-{this.GetBadgeType(options.InnerColor)}'>{options.NotificationText}" +
                                                   $" <span class='visually-hidden'>{options.VisuallyHidden}</span></span>");

        output.Content.SetHtmlContent(content+c);



        //< button type = "button" class="btn btn-primary position-relative">
        //    Inbox
        //    <span class="position-absolute top-0 start-100 translate-middle badge rounded-pill bg-danger">
        //    99+
        //    <span class="visually-hidden">unread messages</span>
        //    </span>
        //    </button>


    }
}