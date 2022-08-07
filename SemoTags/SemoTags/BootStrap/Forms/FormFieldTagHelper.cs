using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SemoTags.BootStrap.Forms;

/// <summary>
/// Easily extend form controls by adding text, buttons, or button groups on either side of textual inputs, custom selects, and custom file inputs.
/// </summary>
public class FormFieldTagHelper : TagHelper
{
    public FormFieldTagHelper(IHtmlGenerator generator)
    {
        _generator = generator;
    }

    public ModelExpression AspFor { get; set; }


    [ViewContext] public ViewContext ViewContext { get; set; }

    public bool IsSmall { get; set; } = false;
    private readonly IHtmlGenerator _generator;

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder instance = new TagBuilder("div");
        instance.AddCssClass(IsSmall ? "input-group input-group-sm" : "input-group");

        instance.InnerHtml.AppendHtml(Label());
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

        var validationMsg = _generator.GenerateValidationMessage(
            ViewContext,
            AspFor.ModelExplorer,
            AspFor.Name,
            null,
            ViewContext.ValidationMessageElement,
            new { @class = "text-danger" });

        input.Attributes.Add("name", AspFor.Name);

        input.Attributes.Add("value", AspFor.Model.ToString());
        instance.InnerHtml.AppendHtml(input);
        instance.InnerHtml.AppendHtml(validationMsg);
        output.Content.AppendHtml(instance);
    }

    private TagBuilder Label()
    {
        TagBuilder label = new TagBuilder("label");
        label.AddCssClass("control-label");
        label.InnerHtml.Append(AspFor.Metadata.DisplayName ?? AspFor.Name);
        return label;
    }
}