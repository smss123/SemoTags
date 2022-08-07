using System.Reflection;

namespace SemoTags.BootStrap.Common.Forms;

public class FormPropertyResult
{
    public IList<PropertyInfo> Properties { get; set; } = new List<PropertyInfo>();
    public int Length { get; set; }
}