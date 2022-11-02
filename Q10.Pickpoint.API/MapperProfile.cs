using AutoMapper;
using Q10.Pickpoint.Models.JsonModel;

namespace Q10.Pickpoint.API;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMapping();
    }

    public void CreateMapping()
    {
        CreateMap<IJsonType, JsonDbModel>()
        .ForMember(dest => dest.Number,
        opt => opt.MapFrom(item => item.Number))
        .ForMember(dest => dest.Type,
        opt => opt.MapFrom(item => GetBaseType(item)))
        .ForMember(dest => dest.Features,
        opt => opt.MapFrom(item => GetFeatures(item)));
    }

    private string GetBaseType(IJsonType jsonType) => jsonType switch
    {
        JsonType1 jsonType1 => jsonType1.Type,
        JsonType2 jsonType2 => jsonType2.Type,
        JsonType3 jsonType3 => jsonType3.Type,
        _ => string.Empty// throw new ArgumentOutOfRangeException(nameof(jsonType), jsonType, null)
    };


    private JsonDbModel.Feature[] GetFeatures(IJsonType jsonType)
    => jsonType switch
    {
        JsonType1 jsonType1 => jsonType1.Features.Select(GetFeature).ToArray(),
        JsonType2 jsonType2 => jsonType2.Features.Select(GetFeature).ToArray(),
        JsonType3 jsonType3 => jsonType3.Features.Select(GetFeature).ToArray(),
        _ => Array.Empty<JsonDbModel.Feature>()// throw new ArgumentOutOfRangeException(nameof(jsonType), jsonType, null)
    };


    private JsonDbModel.Feature GetFeature(JsonType1.Feature feature)
    => new()
    {
        Geometry = GetGeometry(feature.Geometry),
        Type = feature.Type,
        Properties = GetProperties(feature.Properties)
    };

    private JsonDbModel.Geometry GetGeometry(JsonType1.Geometry geometry)
    => new()
    {
        Coordinates = geometry.Coordinates,
        Type = geometry.Type
    };

    private JsonDbModel.Properties GetProperties(JsonType1.Properties properties)
    => new()
    {
        Address = properties.Address,
        Area = properties.Area,
        CommonName = properties.CommonName,
        FullName = properties.FullName,
        GlobalId = properties.GlobalId,
        ShortName = properties.ShortName
    };

    private JsonDbModel.Feature GetFeature(JsonType2.Feature feature)
    => new()
    {
        Geometry = GetGeometry(feature.Geometry),
        Type = feature.Type,
        Properties = GetProperties(feature.Properties)
    };

    private JsonDbModel.Geometry GetGeometry(JsonType2.Geometry geometry)
    => new()
    {
        Coordinates2 = geometry.Coordinates,
        Type = geometry.Type
    };

    private JsonDbModel.Properties GetProperties(JsonType2.Properties properties)
    => new()
    {
        Address = properties.Address,
        Area = properties.Area,
        CommonName = properties.CommonName,
        FullName = properties.FullName,
        GlobalId = properties.GlobalId,
        ShortName = properties.ShortName
    };

    private JsonDbModel.Feature GetFeature(JsonType3.Feature feature)
    => new()
    {
        Geometry = GetGeometry(feature.Geometry),
        Type = feature.Type,
        Properties = GetProperties(feature.Properties)
    };

    private JsonDbModel.Geometry GetGeometry(JsonType3.Geometry geometry)
    => new()
    {
        Coordinates3 = geometry.Coordinates,
        Type = geometry.Type
    };

    private JsonDbModel.Properties GetProperties(JsonType3.Properties properties)
    => new()
    {
        Address = properties.Address,
        Area = properties.Area,
        CommonName = properties.CommonName,
        FullName = properties.FullName,
        GlobalId = properties.GlobalId,
        ShortName = properties.ShortName
    };
}