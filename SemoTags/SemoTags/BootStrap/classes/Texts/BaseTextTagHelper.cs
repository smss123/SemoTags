

using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

using System.Text.Encodings.Web;

namespace SemoTags.BootStrap.classes.Texts;

public class BaseTextTagHelper : TagHelper
{
    public bool Xl { get; set; } = false;
    public bool Lg { get; set; } = false;
    public bool Md { get; set; } = false;
    public bool Sm { get; set; } = false;
    public bool Xs { get; set; } = false;



    protected const string BaseClass = "text-";


    protected void BuildText(TagHelperContext context, TagHelperOutput output, string cls)
    {
        output.TagName = "div";
        if (Xl)
        {
            output.Attributes.RemoveAll($"{BaseClass}{cls}");
            if (output.Attributes.All(p => p.Name != "class"))
                output.Attributes.Add("class", $"{BaseClass}xl-{cls}");
            else
                output.AddClass($"{BaseClass}xl-{cls}", HtmlEncoder.Default);
        }
        else if (Lg)
        {
            output.Attributes.RemoveAll($"{BaseClass}{cls}");
            if (output.Attributes.All(p => p.Name != "class"))
                output.Attributes.Add("class", $"{BaseClass}lg-{cls}");
            else
                output.AddClass($"{BaseClass}lg-{cls}", HtmlEncoder.Default);
        }

        else if (Md)
        {
            output.Attributes.RemoveAll($"{BaseClass}{cls}");
            if (output.Attributes.All(p => p.Name != "class"))
                output.Attributes.Add("class", $"{BaseClass}md-{cls}");
            else
                output.AddClass($"{BaseClass}md-{cls}", HtmlEncoder.Default);
        }


        else if (Sm)
        {
            output.Attributes.RemoveAll($"{BaseClass}{cls}");
            if (output.Attributes.All(p => p.Name != "class"))
                output.Attributes.Add("class", $"{BaseClass}sm-{cls}");
            else
                output.AddClass($"{BaseClass}sm-{cls}", HtmlEncoder.Default);
        }
        else if (Xs)
        {
            output.Attributes.RemoveAll($"{BaseClass}{cls}");
            if (output.Attributes.All(p => p.Name != "class"))
                output.Attributes.Add("class", $"{BaseClass}xs-{cls}");
            else
                output.AddClass($"{BaseClass}xs-{cls}", HtmlEncoder.Default);
        }
        else
        {
            output.Attributes.RemoveAll($"{BaseClass}{cls}");
            if (output.Attributes.All(p => p.Name != "class"))
                output.Attributes.Add("class", $"{BaseClass}{cls}");
            else
                output.AddClass($"{BaseClass}{cls}", HtmlEncoder.Default);
        }




    }

}