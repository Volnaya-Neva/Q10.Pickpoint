using System.Data;

namespace Q10.Pickpoint.ExcelInterop.Tables;

public class DataMosRuTypeTable : BaseTable
{
    public DataMosRuTypeTable() {}

    public DataMosRuTypeTable(List<object[,]> values) : base(values)
    {
    }

    public override List<DataSet> Fill()
    {
        List<DataSet> dataSets = new();
        foreach (object[,] values in Values)
        {
            DataSet dataSet = new();
            DataTable table = dataSet.Tables.Add(nameof(DataMosRuTypeTable));
            SetColumns(values, ref table);
            SetRows(values, ref table);
            dataSets.Add(dataSet);
        }

        return dataSets;
    }

    private void SetColumns(object[,] values, ref DataTable table)
    {
        for (int i = 1; i <= values.GetLength(1); i++)
        {
            table.Columns.Add($"{values[1, i]}", typeof(string));
        }
    }

    private void SetRows(object[,] values, ref DataTable table)
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