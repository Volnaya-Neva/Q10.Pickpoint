﻿namespace Q10.Pickpoint.Models.JsonModel;

public abstract class JsonType2 : IJsonType
{
    public int Number { get; set; }

    public object CreateModelForDb()
    {
        throw new NotImplementedException();
    }
}