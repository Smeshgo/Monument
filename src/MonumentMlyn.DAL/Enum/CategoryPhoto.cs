using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MonumentMlyn.DAL.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CategoryPhoto
    {
        Одинарні = 1,
        Подвійні,
        Елітні,
        Стаття
    }
}