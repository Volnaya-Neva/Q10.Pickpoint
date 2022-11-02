﻿using System.Data;

namespace Q10.Pickpoint.DAL.Repositories;

public interface ITestRepository : IGeneralRepository
{
    void WriteDataSets(string tvpName, DataSet dataSet);

    void WriteDataRecords(string tvpName, List<string> nameColumn, List<List<string>> source);

    bool CheckIsUseByNumber(int number);
}