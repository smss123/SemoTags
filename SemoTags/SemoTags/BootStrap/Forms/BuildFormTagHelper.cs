using System.Reflection;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SemoTags.BootStrap.Common.Forms;

namespace SemoTags.BootStrap.Forms;

public class BuildFormTagHelper : TagHelper
{
    private IHtmlGenerator _htmlGenerator;

    //public ModelExpression AspFor { get; set; }
    public BuildFormTagHelper(IHtmlGenerator htmlGenerator)
    {
        _htmlGenerator = htmlGenerator;
    }

    public object Model { get; set; }
    public int Columns { get; set; } = 2;

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        BuildForm(context, output);
    }

    private void BuildForm(TagHelperContext context, TagHelperOutput output)
    {
        var forms = new TagBuilder("div");

        var form = GetProperties(context, output);
        // get columns
        var col = form.Length / Columns;
        TagBuilder row = new TagBuilder("div");
        row.AddCssClass("row");
        row.Attributes.Add("style", "background: #f5f5f5;");
        foreach (var item in form.Properties)
        {
        }

        forms.InnerHtml.AppendHtml(row);
        output.Content.AppendHtml(forms);
    }

    private FormPropertyResult GetProperties(TagHelperContext context, TagHelperOutput output)
    {
        var result = new FormPropertyResult();
        // Get the properties of 'Type' class object.
        var myPropertyInfo = Model.GetType().GetProperties();
        Console.WriteLine("Properties of System.Type are:");
        foreach (var t in myPropertyInfo)
        {
            result.Properties.Add(t);
            Console.WriteLine("____" + t.Name + "____" + t.GetValue(Model) + "____" + t.PropertyType);
        }

        result.Length = myPropertyInfo.Length;
        return result;
    }
}