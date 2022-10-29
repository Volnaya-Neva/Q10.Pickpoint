using System.Data;

namespace Q10.Pickpoint.ExcelInterop.Tables;

public abstract class BaseTable
{
    protected List<object[,]> Values;

    protected BaseTable() => Values = new();

    protected BaseTable(List<object[,]> values) => Values = values;

    public abstract DataSet Fill();
}