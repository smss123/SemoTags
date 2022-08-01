using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.Forms;

public class FormField : TagHelper
{
    private IHtmlGenerator _generator { get; set; }

    public FormField(IHtmlGenerator generator)
    {
        _generator = generator;
    }


    public ModelExpression AspFor { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder instance = new TagBuilder("div");
        instance.AddCssClass("input-group");
        TagBuilder label = new TagBuilder("label");
        label.AddCssClass("control-label");
        label.InnerHtml.Append(AspFor.Metadata.DisplayName ?? AspFor.Name);
        instance.InnerHtml.AppendHtml(label);
        TagBuilder input = new TagBuilder("input");

        if (AspFor.Metadata.ModelType.Name == "Boolean")
        {
            input.AddCssClass("form-check-input");
            input.Attributes.Add("type", "checkbox");
        }

        else if (AspFor.Metadata.ModelType.Name == "DateTime")
            input.Attributes.Add("type", "dateTime");
        else if (AspFor.Metadata.ModelType.Name == "DateTimeOffset")
            input.Attributes.Add("type", "dateTimeOffset");
        else if (AspFor.Metadata.ModelType.Name == "TimeSpan")
            input.Attributes.Add("type", "time");
        else if (AspFor.Metadata.ModelType.Name == "Decimal")
            input.Attributes.Add("type", "number");
        else if (AspFor.Metadata.ModelType.Name == "Double")
            input.Attributes.Add("type", "number");
        else if (AspFor.Metadata.ModelType.Name == "Single")
            input.Attributes.Add("type", "number");
        else if (AspFor.Metadata.ModelType.Name == "Int32")
            input.Attributes.Add("type", "number");

        else if (AspFor.Metadata.ModelType.Name == "Int64")
            input.Attributes.Add("type", "number");
        else
        {
            input.Attributes.Add("type", "text");
        }

        if (AspFor.Metadata.ModelType.Name != "Boolean")
        {
            input.AddCssClass("form-control");
        }

        input.Attributes.Add("name", AspFor.Name);
        Console.WriteLine(AspFor.Metadata.ModelType.Name);
        input.Attributes.Add("value", AspFor.Model.ToString());
        instance.InnerHtml.AppendHtml(input);
        output.Content.AppendHtml(instance);
    }
}

public class FormFieldFactory
{
    public static readonly string Prefix = "<div class='input-group'>";
    public static readonly string Suffix = "</div>";
}