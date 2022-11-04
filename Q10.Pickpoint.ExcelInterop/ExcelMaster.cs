using Microsoft.Office.Interop.Excel;
using System.Reflection;
using Q10.Pickpoint.ExcelInterop.Tables;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace Q10.Pickpoint.ExcelInterop;

public class ExcelMaster
{
    private Application? _excelsApplication;
    private Workbook? _workbook;

    public ExcelMaster() { }

    public List<object[,]> ReadExcel(string path)
    {
        List<object[,]> objects = new();
        try
        {
            Initialize(path);
            if (_workbook is null) { return objects; }
            foreach (Worksheet sheet in _workbook.Worksheets)
            {
                Range? range = sheet.Range["A1", Missing.Value];
                range = range.End[XlDirection.xlToRight];
                range = range.End[XlDirection.xlDown];

                string downAddress = range.Address[false, false, XlReferenceStyle.xlA1, Type.Missing, Type.Missing];

                range = sheet.Range["A1", downAddress];
                object[,] values = (object[,])range.Value2;
                objects.Add(values);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            _workbook?.Close(false, Missing.Value, Missing.Value);
            _workbook = null;
            _excelsApplication?.Quit();
            _excelsApplication = null;
        }

        return objects;
    }

    public void ConvertToDataSet<T>(List<object[,]> values, ref T table) where T : class, new()
    => table = table switch
    {
        DataMosRuTypeTable => new DataMosRuTypeTable(values) as T,
        _ => throw new Exception($"Таблица \"{typeof(T)}\" не найдена")
    } ?? new();
    
    private void Initialize(string path)
    {
        _excelsApplication ??= new Application();
        _excelsApplication.Visible = false;
        _excelsApplication.ScreenUpdating = false;
        _excelsApplication.DisplayAlerts = false;
        _workbook = null;
        _workbook = _excelsApplication.Workbooks.Open
        (
            path,
            Missing.Value,
            Missing.Value,
            Missing.Value
            , Missing.Value,
            Missing.Value,
            Missing.Value,
            Missing.Value
            , Missing.Value,
            Missing.Value,
            Missing.Value,
            Missing.Value
            , Missing.Value,
            Missing.Value,
            Missing.Value
        );
    }
}