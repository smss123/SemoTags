namespace SemoTags.Bootstrap.Layout.Builders;

public class ColumnTagBuilder
{
    private static string _col = "col";

    public ColumnTagBuilder AddSize(string size)
    {
        _col += "-" + size;
        return this;
    }

    public ColumnTagBuilder AddOffset(string offset)
    {
        _col += "-" + offset;
        return this;
    }

    public ColumnTagBuilder AddPush(string push)
    {
        _col += "-" + push;
        return this;
    }

    public ColumnTagBuilder AddPull(string pull)
    {
        _col += "-" + pull;
        return this;
    }

    public ColumnTagBuilder AddHidden(string hidden)
    {
        _col += "-" + hidden;
        return this;
    }

    public ColumnTagBuilder AddVisible(string visible)
    {
        _col += "-" + visible;
        return this;
    }


    public string Build()
    {
        return _col;
    }
}