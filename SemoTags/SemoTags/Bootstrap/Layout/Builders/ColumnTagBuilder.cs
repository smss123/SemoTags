namespace SemoTags.Bootstrap.Layout.Builders;

public class ColumnTagBuilder
{
    public override string? ToString()
    {
        return Build();
    }

    private static string? _col ;
    public ColumnTagBuilder AddColumn()
    {
        _col = "col";
        return this;
    }

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


    public string? Build()
    {
        return _col;
    }

    public ColumnTagBuilder AddLargeColumn()
    {
        _col="col-lg";
        return this;
    }

    public ColumnTagBuilder AddMediumColumn()
    {
        _col="col-md";
        return this;
    }

    public ColumnTagBuilder AddSmallColumn()
    {
        _col="col-sm";
        return this;
    }

    public ColumnTagBuilder AddExtraSmallColumn()
    {
        _col="col-xs";
        return this;
    }
}