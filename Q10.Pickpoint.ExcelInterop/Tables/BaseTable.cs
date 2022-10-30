using System.Data;

namespace Q10.Pickpoint.ExcelInterop.Tables;

public abstract class BaseTable
{
    protected List<object[,]> Values;

    protected BaseTable() => Values = new();

    protected BaseTable(List<object[,]> values) => Values = values;

    public virtual DataSet Fill<T>() where T : BaseTable
    {
        DataSet dataSet = new();

        foreach (object[,] values in Values)
        {
            DataTable table = dataSet.Tables.Add(nameof(T));
            SetColumns(values, ref table);
            SetRows(values, ref table);
        }

        return dataSet;
    }

    private static void SetColumns(object[,] values, ref DataTable table)
    {
        for (int i = 1; i <= values.GetLength(1); i++)
        {
            table.Columns.Add($"{values[1, i]}", typeof(string));
        }
    }

    private static void SetRows(object[,] values, ref DataTable table)
    {
        for (int i = 2; i <= values.GetLength(0); i++)
        {
            List<object> param = new();
            for (int j = 1; j <= values.GetLength(1); j++)
            {
                param.Add(values[i, j]);
            }
            table.Rows.Add(param.ToArray());
        }
    }
}